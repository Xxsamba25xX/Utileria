﻿using LanguageToClasses.Configuration;
using LanguageToClasses.Models;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

namespace LanguageToClasses.Parser
{
	public class XmlParser
	{
		Dictionary<string, GeneratedClass> Classes { get; set; }
		XmlConfiguration Configuration { get; set; }

		public XmlParser(XmlConfiguration config)
		{
			Configuration = config;
		}

		public GeneratedClass GetClasses(string xmlAsString)
		{
			Stack<(XmlNode node, GeneratedClass element)> nodeStack = new Stack<(XmlNode node, GeneratedClass element)>();
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(xmlAsString);

			//path=nodo(namespace)/@attributeName(Namespace)
			//path=nodo(namespace)/nodoHoja(namespace)

			XmlNode node = doc;
			(XmlNode node, GeneratedClass element) lastStackedElement = default;
			do
			{
				bool stackHasElements = nodeStack.TryPop(out lastStackedElement);
				node = lastStackedElement == default ? lastStackedElement.node : doc;

				foreach (var groupedNode in node.ChildNodes.ToList().GroupBy(x => $"{x.NamespaceURI}:{x.Name}"))
				{
					bool isArray = groupedNode.Count() > 1;
					var childNode = groupedNode.First();

					if (childNode.NodeType == XmlNodeType.Element)
					{
						bool isLeafNode = groupedNode.All(itemNode => itemNode.IsLeafNode());

						foreach (var itemInGroup in groupedNode)
						{
							if (isLeafNode)
							{
								processLeafNode(lastStackedElement.element, itemInGroup);
							}
							else
							{
								processNode(lastStackedElement, itemInGroup, isArray);
							}
						}

					}
				}
			}
			while (node != null && node.ChildNodes.Count > 0);
			return null;
		}

		private GeneratedClass processNode((XmlNode node, GeneratedClass element) parent, XmlNode itemInGroup, bool isArray)
		{
			//crear un generatedClass
			var result = new GeneratedClass()
			{
				Name = itemInGroup.Name,
				Namespace = itemInGroup.NamespaceURI,
				isArray = isArray
			};
			//procesar los atributos
			//agregarlo al diccionario
			return null;
		}

		private void processLeafNode(GeneratedClass parent, XmlNode leafNode)
		{
			var result = new GeneratedProperty()
			{
				Name = leafNode.Name,
				NameSpace = leafNode.NamespaceURI,
				ValueType = GetValueType(leafNode.InnerText)
			};
			var resultKeyName = $"#{leafNode.Name}({leafNode.NamespaceURI})";
			//Si ya existe esta propiedad en el parent, calcular el nuevo tipo, si no insertarlo así nomas.
			if (parent.properties.ContainsKey(resultKeyName))
			{
				var element = parent.properties[resultKeyName];
				element.ValueType = GetBiggerType(new string[] { element.ValueType, result.ValueType });
			}
			else
			{
				parent.properties.Add(resultKeyName, result);
			}
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


			if (Regex.IsMatch(source, $"^[0-9]+?[{CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator}][0-9]+$", RegexOptions.IgnoreCase))
			{
				if (Configuration.UsedIntegralTypes.HasFlag(IntegralTypeEnumerator.ulongType) && ulong.TryParse(source, out ulongValue))
					resultType = "ulong";
				else if (Configuration.UsedIntegralTypes.HasFlag(IntegralTypeEnumerator.uintType) && uint.TryParse(source, out uintValue))
					resultType = "uint";
				else if (Configuration.UsedIntegralTypes.HasFlag(IntegralTypeEnumerator.ushortType) && ushort.TryParse(source, out ushortValue))
					resultType = "ushort";
				else if (Configuration.UsedIntegralTypes.HasFlag(IntegralTypeEnumerator.byteType) && byte.TryParse(source, out byteValue))
					resultType = "byte";

				if (string.IsNullOrWhiteSpace(resultType))
				{
					if (Configuration.UsedIntegralTypes.HasFlag(IntegralTypeEnumerator.longType) && long.TryParse(source, out longValue))
						resultType = "long";
					else if (Configuration.UsedIntegralTypes.HasFlag(IntegralTypeEnumerator.intType) && int.TryParse(source, out intValue))
						resultType = "int";
					else if (Configuration.UsedIntegralTypes.HasFlag(IntegralTypeEnumerator.shortType) && short.TryParse(source, out shortValue))
						resultType = "short";
					else if (Configuration.UsedIntegralTypes.HasFlag(IntegralTypeEnumerator.sbyteType) && sbyte.TryParse(source, out sbyteValue))
						resultType = "sbyte";
				}

				if (string.IsNullOrWhiteSpace(resultType))
				{
					if (Configuration.UsedFloatingTypes.HasFlag(FloatingTypeEnumerator.decimalType) && decimal.TryParse(source, out decimalValue))
						resultType = "decimal";
					else if (Configuration.UsedFloatingTypes.HasFlag(FloatingTypeEnumerator.doubleType) && double.TryParse(source, out doubleValue))
						resultType = "double";
					else if (Configuration.UsedFloatingTypes.HasFlag(FloatingTypeEnumerator.floatType) && float.TryParse(source, out floatValue))
						resultType = "float";
				}
			}
			else
			{
				if (Configuration.UsedSpecialTypes.HasFlag(SpecialTypeEnumerator.datetime) && DateTime.TryParse(source, out datetimeValue))
					resultType = "DateTime";
				else if (Configuration.UsedSpecialTypes.HasFlag(SpecialTypeEnumerator.charType) && char.TryParse(source, out charValue))
					resultType = "char";
				else if (Configuration.UsedSpecialTypes.HasFlag(SpecialTypeEnumerator.boolean) && bool.TryParse(source, out boolValue))
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
		foreach (XmlNode item in me)
		{
			if (func(item))
				yield return item;
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

	public static string Stringify(this XmlNode me, bool isArray)
	{
		bool isAttribute = me.NodeType == XmlNodeType.Attribute;
		bool isProperty = me.IsLeafNode();
		bool isValue = me.ChildNodes.Count == 0;

		if (isAttribute)
			return $"@{me.NamespaceURI}:{me.Name}";
		else if (isProperty)
			return $"#{me.NamespaceURI}:{me.Name}";
		else if (isValue)
			return $"_{me.NamespaceURI}:{me.Name}";
		else
			return $"{me.NamespaceURI}:{me.Name}";
	}


	public static bool IsLeafNode(this XmlNode me)
	{
		bool isFirstNode = me.ParentNode.NodeType == XmlNodeType.Document;
		bool hasChilds = me.ChildNodes.Count > 0;
		bool singleChild = hasChilds && me.ChildNodes.Count <= 1;
		bool notElementChild = hasChilds && (me.FirstChild.NodeType == XmlNodeType.Text || me.FirstChild.NodeType == XmlNodeType.CDATA);
		bool hasAttributes = me.Attributes.Where(x => !x.Name.StartsWith("xmlns")).Count() > 0;

		return !isFirstNode && singleChild && notElementChild && !hasAttributes;
	}
}





