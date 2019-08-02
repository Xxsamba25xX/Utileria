﻿using LanguageToObjectLibrary.Parser.Configuration;
using LanguageToObjectLibrary.Parser.Models;
using Newtonsoft.Json;
using System;
using System.Collections;
using UtileriaFramework.Extensions;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

namespace LanguageToObjectLibrary.Parser
{

	public class XmlParser
	{
		Dictionary<string, bool> ClassNameTable { get; set; } = new Dictionary<string, bool>();
		Dictionary<string, GeneratedClass> Classes { get; set; } = new Dictionary<string, GeneratedClass>();
		GeneratedClass Document { get; set; } = new GeneratedClass();
		XmlConfiguration Configuration { get; set; }

		public XmlParser(XmlConfiguration config)
		{
			Configuration = config;
			Document.Attributes = null;
			Document.Value = null;
			Document.Id = "/";
			Document.Name = "/";
			Document.ShowName = "/";
			Document.Namespace = "";
			ClassNameTable.Add(Document.ShowName, true);
		}

		public GeneratedClass GetClasses(string xmlAsString)
		{
			ProcessXml(xmlAsString);
			var list = OrderClasses_Original();
			BuildCSharpCode(list);
			return null;
		}

		private void BuildCSharpCode(List<GeneratedClass> list)
		{
			StringBuilder sb = new StringBuilder();
			//Clases
		}

		private string CreateUsings()
		{
			StringBuilder sb = new StringBuilder();
			foreach (var usingValue in Configuration.Usings)
			{
				Regex validador = new Regex("^(?<start>(using[ ]|[ ])?)(?<content>[^ ;,]+)(?<ending>[ ]?[;])$", RegexOptions.IgnoreCase);
				Match match = validador.Match(usingValue);

				if (!match.Success) continue;

				sb.AppendLine($"using {match.Groups["content"].Value};");
			}
			return sb.ToString();
		}

		//Original porque despues podría poner otros ordenamiento de clase
		private List<GeneratedClass> OrderClasses_Original()
		{
			LinkedList<GeneratedClass> result = new LinkedList<GeneratedClass>();
			var classesAdded = new Dictionary<string, GeneratedClass>();
			//dictionary de string,bool es como un hashset pero mejor en velocidad porque YOLO.
			var nameTable = new Dictionary<string, bool>();

			var additionIndex = result.First;
			foreach (var classItem in Classes)
			{
				var item = classItem.Value;

				//if (!classItem.Value.IsRoot
				//	 || classesAdded.ContainsKey(item.Id))
				//	continue;

				if (additionIndex == null)
				{
					additionIndex = result.AddFirst(item);
					GenerateShowName(nameTable, item);
				}
				else
				{
					additionIndex = result.AddAfter(additionIndex, item);
					//Agregar a clasesAdded
					classesAdded.Add(item.Id, item);
					//Generar un showName para la clase
					GenerateShowName(nameTable, item);
				}
			}

			LinkedListNode<GeneratedClass> actualItem = result.First;
			//Si no se agregó ningunItem
			if (actualItem == null) return result.ToList();

			do
			{
				additionIndex = actualItem;

				//Proceso Childs(agregar la clase en caso de tenerlas, normalizar los nombres para que no se repitan)
				var childNames = new Dictionary<string, bool>();
				foreach (var childItem in actualItem.Value.Childs.Values)
				{
					//normalizar los nombres para que no se repitan
					GenerateShowName(childNames, childItem);

					//agregar la clase en caso de tenerla
					var item = childItem.Type;
					if (classesAdded.ContainsKey(item.Id))
						continue;

					additionIndex = result.AddAfter(additionIndex, item);
					classesAdded.Add(item.Id, item);
					GenerateShowName(nameTable, item);
				}

				var attributeNames = new Dictionary<string, bool>();
				foreach (var attItem in actualItem.Value.Attributes.Values)
				{
					GenerateShowName(attributeNames, attItem);
				}

			} while ((actualItem = actualItem.Next) != null);

			return result.ToList();
		}

		private void GenerateShowName(Dictionary<string, bool> nameTable, GeneratedElement item)
		{
			int showNameCount = 0;
			string added = showNameCount == 0 ? "" : $"_{showNameCount}";
			while (nameTable.ContainsKey(item.ShowName + added))
				showNameCount++;

			item.ShowName = item.ShowName + added;

			nameTable.Add(item.ShowName, true);
		}

		private void ProcessXml(string xmlAsString)
		{
			Stack<(XmlNode node, GeneratedClass element)> nodeStack = new Stack<(XmlNode node, GeneratedClass element)>();
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(xmlAsString);

			nodeStack.Push((doc, Document));

			(XmlNode node, GeneratedClass element) lastStackedElement = default;
			do
			{

				bool stackHasElements = nodeStack.TryPop(out lastStackedElement);

				if (!stackHasElements) break;

				foreach (var groupedNode in lastStackedElement.node.ChildNodes.ToList().GroupBy(x => $"{x.NamespaceURI}:{x.LocalName}"))
				{
					bool isArray = groupedNode.Count() > 1;
					var childNode = groupedNode.First();

					if (childNode.NodeType != XmlNodeType.Element
						&& childNode.NodeType != XmlNodeType.Text
						&& childNode.NodeType != XmlNodeType.CDATA)
						continue;

					bool isValueNode = groupedNode.All(itemNode =>
					{
						bool isText = itemNode.NodeType == XmlNodeType.Text || itemNode.NodeType == XmlNodeType.CDATA;
						bool isEmpty = itemNode.ChildNodes.Count == 0;
						bool hasAttributes = itemNode.Attributes.Where(x => !IsIgnoredAttribute(x.NamespaceURI, x.LocalName)).Count() == 0;
						return (isText || isEmpty) && !hasAttributes;
					});

					var processedClass = new GeneratedClass();
					foreach (var itemInGroup in groupedNode)
					{
						if (isValueNode)
						{
							processValueNode(lastStackedElement.element, itemInGroup, isArray);
						}
						else
						{
							processedClass = processNode(lastStackedElement, itemInGroup, isArray);
							nodeStack.Push((itemInGroup, processedClass));
						}
					}
				}
			}
			while (nodeStack.Count > 0);
		}

		private void processValueNode(GeneratedClass parent, XmlNode itemInGroup, bool isArray)
		{
			var valueType = GetValueType(itemInGroup.InnerText);
			parent.Value.Type = GetBiggerType(new string[] { parent.Value.Type, valueType });
			parent.Value.isArray |= isArray;
		}

		private GeneratedClass processNode((XmlNode node, GeneratedClass element) parent, XmlNode node, bool isArray)
		{
			var internalId = node.Stringify();
			GeneratedChild result = null;

			if (parent.element.Childs.ContainsKey(internalId))
				result = parent.element.Childs[internalId];

			if (result == null)
			{
				result = new GeneratedChild()
				{
					Name = node.LocalName,
					Namespace = node.NamespaceURI,
					IsArray = isArray
				};

				//Proceso de clase
				result.Type = ProcessClass(node);

				//Linkeo padre con hijo
				if (parent.element != null)
					parent.element.Childs.Add(internalId, result);
				else
					Document.Childs.Add(internalId, result);
			}
			else
			{
				result.IsArray |= isArray;
				var attributes = result.Type.Attributes ?? new Dictionary<string, GeneratedAttribute>();
				ProcessAttributes(node, ref attributes);
			}

			return result.Type;
		}

		private GeneratedClass ProcessClass(XmlNode node)
		{
			string id = GenerateId(node);
			GeneratedClass result = null;

			if (Classes.ContainsKey(id))
			{
				result = Classes[id];
			}
			else
			{
				result = new GeneratedClass()
				{
					Name = node.LocalName,
					Namespace = node.NamespaceURI,
					Id = id
				};
				Classes.Add(id, result);
			}

			//procesar los atributos
			var attributes = result.Attributes ?? new Dictionary<string, GeneratedAttribute>();
			ProcessAttributes(node, ref attributes);
			result.Attributes = attributes;

			return result;
		}

		private string GenerateId(XmlNode node)
		{
			switch (Configuration.XmlClassIdentifier)
			{
				case XmlClassDefinition.byNamespaceAndName:
					return node.Stringify();
					break;
				case XmlClassDefinition.byNamespaceNameAndPath:
					return node.GetPath();
					break;
				default:
					throw new Exception("LCDTM ALL BOYS!!!");
					break;
			}
		}

		private void ProcessAttributes(XmlNode itemInGroup, ref Dictionary<string, GeneratedAttribute> existingAttributes)
		{
			if (existingAttributes == null) existingAttributes = new Dictionary<string, GeneratedAttribute>();

			foreach (XmlNode item in itemInGroup.Attributes)
			{
				if (IsIgnoredAttribute(item.NamespaceURI, item.LocalName)) continue;

				var stringNode = item.Stringify();
				GeneratedAttribute sameAttr = null;
				if (existingAttributes.ContainsKey(stringNode))
					sameAttr = existingAttributes[stringNode];

				if (sameAttr == null)
				{
					var result = new GeneratedAttribute()
					{
						Name = item.LocalName,
						Namespace = item.NamespaceURI,
						Value = new Value()
						{
							Type = GetValueType(item.InnerText)
						}
					};
					existingAttributes.Add(stringNode, result);
				}
				else
				{
					var valueType = GetValueType(item.InnerText);
					sameAttr.Value.Type = GetBiggerType(new string[] { valueType, sameAttr.Value.Type });
				}
			}

		}

		private bool IsIgnoredAttribute(string namespaceValue, string nameValue)
		{
			foreach (var filter in Configuration.IgnoredAttributes)
			{
				Regex namespaceFilter = new Regex(filter.Namespace, RegexOptions.IgnoreCase);
				Regex nameFilter = new Regex(filter.Name, RegexOptions.IgnoreCase);

				if (namespaceFilter.IsMatch(namespaceValue)
					&& nameFilter.IsMatch(nameValue)) return true;
			}
			return false;
		}

		private string GetValueType(string source)
		{
			ulong ulongValue = 0;
			uint uintValue = 0;
			ushort ushortValue = 0;
			byte byteValue = 0;

			long longValue = 0;
			int intValue = 0;
			short shortValue = 0;
			sbyte sbyteValue = 0;

			decimal decimalValue = 0;
			double doubleValue = 0;
			float floatValue = 0;

			DateTime datetimeValue = DateTime.MinValue;
			char charValue = '0';
			bool boolValue = false;
			string resultType = "";


			if (Regex.IsMatch(source, $"^[0-9]+?([{CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator}][0-9]+)?$", RegexOptions.IgnoreCase))
			{
				if (Configuration.UsedIntegralTypes.HasFlag(IntegralTypeEnumerator.ulongType) && ulong.TryParse(source, out ulongValue))
					resultType = "ulong";
				if (Configuration.UsedIntegralTypes.HasFlag(IntegralTypeEnumerator.uintType) && uint.TryParse(source, out uintValue))
					resultType = "uint";
				if (Configuration.UsedIntegralTypes.HasFlag(IntegralTypeEnumerator.ushortType) && ushort.TryParse(source, out ushortValue))
					resultType = "ushort";
				if (Configuration.UsedIntegralTypes.HasFlag(IntegralTypeEnumerator.byteType) && byte.TryParse(source, out byteValue))
					resultType = "byte";

				if (string.IsNullOrWhiteSpace(resultType))
				{
					if (Configuration.UsedIntegralTypes.HasFlag(IntegralTypeEnumerator.longType) && long.TryParse(source, out longValue))
						resultType = "long";
					if (Configuration.UsedIntegralTypes.HasFlag(IntegralTypeEnumerator.intType) && int.TryParse(source, out intValue))
						resultType = "int";
					if (Configuration.UsedIntegralTypes.HasFlag(IntegralTypeEnumerator.shortType) && short.TryParse(source, out shortValue))
						resultType = "short";
					if (Configuration.UsedIntegralTypes.HasFlag(IntegralTypeEnumerator.sbyteType) && sbyte.TryParse(source, out sbyteValue))
						resultType = "sbyte";
				}

				if (string.IsNullOrWhiteSpace(resultType))
				{
					if (Configuration.UsedFloatingTypes.HasFlag(FloatingTypeEnumerator.decimalType) && decimal.TryParse(source, out decimalValue))
						resultType = "decimal";
					if (Configuration.UsedFloatingTypes.HasFlag(FloatingTypeEnumerator.doubleType) && double.TryParse(source, out doubleValue))
						resultType = "double";
					if (Configuration.UsedFloatingTypes.HasFlag(FloatingTypeEnumerator.floatType) && float.TryParse(source, out floatValue))
						resultType = "float";
				}
			}
			else
			{
				if (Configuration.UsedSpecialTypes.HasFlag(SpecialTypeEnumerator.datetime) && DateTime.TryParse(source, out datetimeValue))
					resultType = "DateTime";
				if (Configuration.UsedSpecialTypes.HasFlag(SpecialTypeEnumerator.charType) && char.TryParse(source, out charValue))
					resultType = "char";
				if (Configuration.UsedSpecialTypes.HasFlag(SpecialTypeEnumerator.boolean) && bool.TryParse(source, out boolValue))
					resultType = "bool";
			}

			if (string.IsNullOrWhiteSpace(resultType))
			{
				if (source == null)
					resultType = "object";
				else
					resultType = "string";
			}

			return resultType;
		}

		private string GetBiggerType(IEnumerable<string> types)
		{
			string possibleResult = "";
			int differentGroups = 0;

			if (types.Any(x => x.Equals("string", StringComparison.InvariantCultureIgnoreCase)))
				return "string";

			if (types.Any(x => x.Equals("char", StringComparison.InvariantCultureIgnoreCase)))
			{
				differentGroups++;
				possibleResult = "char";
			}

			if (types.Any(x => x.Equals("bool", StringComparison.InvariantCultureIgnoreCase)))
			{
				differentGroups++;
				possibleResult = "bool";
			}

			if (types.Any(x => x.Equals("DateTime", StringComparison.InvariantCultureIgnoreCase)))
			{
				differentGroups++;
				possibleResult = "DateTime";
			}

			if (types.Any(x => x.Equals("decimal", StringComparison.InvariantCultureIgnoreCase)))
			{
				differentGroups++;
				possibleResult = "decimal";
			}
			else if (types.Any(x => x.Equals("ulong", StringComparison.InvariantCultureIgnoreCase)))
			{
				differentGroups++;
				possibleResult = "ulong";
			}
			else if (types.Any(x => x.Equals("long", StringComparison.InvariantCultureIgnoreCase)))
			{
				differentGroups++;
				possibleResult = "long";
			}
			else if (types.Any(x => x.Equals("double", StringComparison.InvariantCultureIgnoreCase)))
			{
				differentGroups++;
				possibleResult = "double";
			}
			else if (types.Any(x => x.Equals("uint", StringComparison.InvariantCultureIgnoreCase)))
			{
				differentGroups++;
				possibleResult = "uint";
			}
			else if (types.Any(x => x.Equals("int", StringComparison.InvariantCultureIgnoreCase)))
			{
				differentGroups++;
				possibleResult = "int";
			}
			else if (types.Any(x => x.Equals("float", StringComparison.InvariantCultureIgnoreCase)))
			{
				differentGroups++;
				possibleResult = "float";
			}
			else if (types.Any(x => x.Equals("ushort", StringComparison.InvariantCultureIgnoreCase)))
			{
				differentGroups++;
				possibleResult = "ushort";
			}
			else if (types.Any(x => x.Equals("short", StringComparison.InvariantCultureIgnoreCase)))
			{
				differentGroups++;
				possibleResult = "short";
			}
			else if (types.Any(x => x.Equals("byte", StringComparison.InvariantCultureIgnoreCase)))
			{
				differentGroups++;
				possibleResult = "byte";
			}
			else if (types.Any(x => x.Equals("sbyte", StringComparison.InvariantCultureIgnoreCase)))
			{
				differentGroups++;
				possibleResult = "sbyte";
			}

			if (differentGroups > 1)
				return "string";
			else if (differentGroups == 1)
				return possibleResult;
			else
				return "object";
		}

	}

}

public static class XmlNodeUtils
{
	public static IEnumerable<XmlNode> Where(this XmlAttributeCollection me, Func<XmlNode, bool> func)
	{
		if (me != null)
		{
			foreach (XmlNode item in me)
			{
				if (func(item))
					yield return item;
			}
		}
	}

	public static List<XmlNode> ToList(this XmlNodeList me)
	{
		List<XmlNode> nodes = new List<XmlNode>();
		foreach (XmlNode item in me)
		{
			nodes.Add(item);
		}
		return nodes;
	}

	public static string Stringify(this XmlNode me)
	{
		string initialCharacter = "";

		if (me.NodeType == XmlNodeType.Attribute)
			initialCharacter = "@";

		return $"{initialCharacter}{me.NamespaceURI}:{me.LocalName}";
	}

	public static string GetPath(this XmlNode me)
	{
		if (me == null) return "";

		Stack<string> path = new Stack<string>();
		var actualNode = me;
		while (actualNode != null)
		{
			if (actualNode.NodeType == XmlNodeType.Document)
			{
				path.Push("/");
			}
			else
			{
				path.Push(actualNode.Stringify());
			}
			actualNode = actualNode.ParentNode;
		}

		StringBuilder sb = new StringBuilder();
		string pathItem = "";
		while (path.TryPop(out pathItem))
		{
			sb.Append(pathItem);
		}

		return sb.ToString();
	}


	public static bool IsLeafNode(this XmlNode me)
	{
		bool isElement = me.NodeType == XmlNodeType.Element;
		bool isFirstNode = me.ParentNode != null && me.ParentNode.NodeType == XmlNodeType.Document;
		bool hasChilds = me.ChildNodes.Count > 0;
		bool singleChild = hasChilds && me.ChildNodes.Count <= 1;
		bool notElementChild = hasChilds && (me.FirstChild.NodeType == XmlNodeType.Text || me.FirstChild.NodeType == XmlNodeType.CDATA);
		bool hasAttributes = isElement && me.Attributes.Where(x => !x.Name.StartsWith("xmlns")).Count() > 0;

		return isElement && !isFirstNode && (!hasChilds || (singleChild && notElementChild)) && !hasAttributes;
	}

	/// <summary>
	/// Evalua si un nodo es de tipo valor
	/// </summary>
	/// <param name="me"></param>
	/// <returns>true si es text o CDATA y si no tiene atributos</returns>
	public static bool IsValueNode(this XmlNode me)
	{
		bool isValue = me.NodeType == XmlNodeType.Text || me.NodeType == XmlNodeType.CDATA;
		bool hasAttributes = isValue && me.Attributes.Where(x => !x.Name.StartsWith("xmlns")).Count() > 0;

		return isValue && !hasAttributes;
	}
}





