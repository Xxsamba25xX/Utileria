using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using LanguageToClasses.Configuration;
using LanguageToClasses.Contracts;
using LanguageToClasses.Models;

namespace LanguageToClasses.Converters
{
	public class XmlConverter : AbstractConverter
	{

		public static string strTagStart = "tagStart";
		public static string strNamespace = "namespace";
		public static string strLocalName = "localName";
		public static string strAttributes = "attributes";
		public static string strQuoted = "quoted";

		/// <summary>
		/// Matchea cualquier tipo de los espacios comunes
		/// </summary>
		public static string space = @"([ \t\r\n]+)";
		/// <summary>
		/// Especifica la estructura de un numero de version
		/// </summary>
		public static string versionNum = $"[1-2].[0-9]+";
		/// <summary>
		/// Matchea los simbolos de igual, Ejemplo los que componen un atributo
		/// </summary>
		public static string eq = $"{space}?[=]{space}?";
		/// <summary>
		/// Caracter de inicio de un nombre
		/// </summary>
		public static string nameStartChar = @"([:_]|[a-z])";
		/// <summary>
		/// Caracter de nombre, si te fijas hay caracteres que no se pueden usar como inicio de nombre.
		/// </summary>
		public static string nameChar = $"{@"([-.]|[0-9])"}|{nameStartChar}";
		/// <summary>
		/// Tipo de caracter aceptado para matchear todo aquello que sea un value, el contenido de un elemento o un comentario.
		/// </summary>
		public static string charData = $"([^<&]*)";
		/// <summary>
		/// Especificación de un nombre
		/// </summary>
		public static string name = $"{nameStartChar}{nameChar}*";
		/// <summary>
		/// Especificación de un nombre Normalizado, no tiene ':' como inicio ni contenido de un nombre. Usado para el nombre de las etiquetas.
		/// </summary>
		public static string normalizedName = $"{name.Replace(":", "")}";
		/// <summary>
		/// Referencias a una entidad o elemento quizas 
		/// </summary>
		public static string entityRef = $"&{name};";
		/// <summary>
		/// Referencias a un caracter unicode u otro. Ejemplo:&#x0000;
		/// </summary>
		public static string charRef = $"(&#[0-9]+;)|(&#x[0-9a-fA-F];)";
		/// <summary>
		/// Estructura para la info de version
		/// </summary>
		public static string versionInfo = $"{space}version{eq}('{versionNum}'|{'"'}{versionNum}{'"'})";
		/// <summary>
		/// Especificación para referencia
		/// </summary>
		public static string reference = $"{entityRef}|{charRef}";
		/// <summary>
		/// Especificación nombres de atributos prefijados
		/// </summary>
		public static string prefixedAttName = $"xmlns:{normalizedName}";
		/// <summary>
		/// Especificación espacio de nombres por defectos
		/// </summary>
		public static string defaultAttName = $"xmlns";
		/// <summary>
		/// Especificación para cualquier atributo que tenga relación con los espacios de nombres
		/// </summary>
		public static string namespacedAttName = $"{prefixedAttName}|{defaultAttName}";
		/// <summary>
		/// Especificación de nombre prefijado
		/// </summary>
		public static string prefixedName = $"(?<{strNamespace}>{normalizedName}):(?<{strLocalName}>{normalizedName})";
		/// <summary>
		/// Especificación de nombre sin prefijar
		/// </summary>
		public static string unprefixedName = $"(?<{strLocalName}>{normalizedName})";
		/// <summary>
		/// Nombres que pueden ser prefijado o no.
		/// <para>Grupos: </para>
		/// </summary>
		public static string qualifiedName = $"{prefixedName}|{unprefixedName}";
		/// <summary>
		/// Especificación de posibles valores que puede tomar un atributo
		/// <para>Grupos: </para>
		/// </summary>
		public static string attValue = $"{'"'}([^<&{'"'}]|{reference})*{'"'}|{"'"}([^<&{"'"}]|{reference})*{"'"}";
		/// <summary>
		/// Especificación de estructura de un atributo
		/// <para>Grupos: </para>
		/// </summary>
		public static string attribute = $"{namespacedAttName}{eq}{attValue}|{qualifiedName}{eq}{attValue}";

		/// <summary>
		/// Especificación de un elemento vacío
		/// <para>Grupos: namespace, localName, attributes</para>
		/// </summary>
		public static string emptyElementTag = $"<{qualifiedName}(?<{strAttributes}>({space}{attribute})*){space}?/>";
		/// <summary>
		/// Especificación de la etiqueta de inicio de un elemento
		/// <para>Grupos: namespace, localName, attributes</para>
		/// </summary>
		public static string elementStartTag = $"<{qualifiedName}(?<{strAttributes}>({space}{attribute})*){space}?>";
		/// <summary>
		/// Especificación de la etiqueta de fin de un elemento.
		/// <para>Grupos: </para>
		/// </summary>
		public static string elementEndTag = $"</{qualifiedName}{space}?>";
		/// <summary>
		/// Especificación para los literales dentro de los elementos.
		/// <para>Grupos: tagStart, quoted</para>
		/// </summary>
		public static string contentLiteral = $"^(([^<{'"'}'])*?)((?<{strQuoted}>([{'"'}][^{'"'}]*?[{'"'}])|(['][^']*?[']))(([^<{'"'}'])*?))*?(?<{strTagStart}>[<])";
		/// <summary>
		/// Especificación para las etiquetas de comentarios
		/// </summary>
		public static string commentTag = $"<[!][-]{2}{space}?(.*?){space}?[-]{2}>";
		/// <summary>
		/// Especificación para las etiquetas de Elementos
		/// </summary>
		public static string elementTag = $"<[!](([^>]|\\s)*?)([\\[](([^>]|\\s)*?)>(([^>]|\\s)*?)[\\]])?(([^>]|\\s)*?)>";
		/// <summary>
		/// Valida si el string es numerico.
		/// </summary>
		Regex regNumericValidator = new Regex(@"^(?<hasMinus>-)?[0-9]+?(?<hasPoint>[.])[0-9]*$");


		XmlConfiguration Configuration => (_configuration as XmlConfiguration);

		public XmlConverter(XmlConfiguration configuration) : base(configuration)
		{

		}

		public override List<AbstractNode> Convert(string source)
		{
			List<AbstractNode> rootNodes = new List<AbstractNode>();
			Queue<(XmlNode node, Status innerText)> nodes = new Queue<(XmlNode node, Status innerText)>(new (XmlNode node, Status innerText)[]{
				(null, new Status(){
					DefaultNamespace = "",
					InnerText = source,
					Namespaces = new Dictionary<string, string>()
				})});

			(XmlNode node, Status status) lastQueueItem = default;

			//Encontrar un <
			//Categorizar si es comentario, elemento o algun otra cosa (de momento solo diferenciar comentario de elemento)
			//Si es comentario eliminar hasta el cierre del mismo
			//Si es elemento
			//peekear el ultimo nodo de la queue
			//si hay contenido antes del < asignarseló al nodo padre del que estamos procesando
			//Si no hay contenido
			//Definir si es inicio o fin de nodo
			//Si es inicio procesarlo, crear un nuevo nodo y guardarlo en la queue
			//Si es fin sacar el ultimo nodo de la queue y fijarse que sea del mismo nombre

			while (true)
			{
				Match untilNextTag = Regex.Match(source, contentLiteral, RegexOptions.IgnoreCase);
				if (!untilNextTag.Success) break;
				int startTagChar = untilNextTag.Groups[strTagStart].Index;
				int endTagChar = 0;
				nodes.TryPeek(out lastQueueItem);
				string tagPart = source.Substring(untilNextTag.Groups[strTagStart].Index);
				string innerTag = "";
				var actualNode = getNode("", lastQueueItem.node, lastQueueItem.status.Namespaces, lastQueueItem.status.DefaultNamespace);

			}

			return null;
			
		}

		private XmlNode getNode(string source, XmlNode parent, Dictionary<string, string> namespaces, string defaultNamespace)
		{
			Match match = Regex.Match(source, $"{elementStartTag}");
			if (!match.Success)
				return null;

			XmlNode newNode = new XmlNode();

			newNode.Name = match.Groups["localName"].Value;
			if (string.IsNullOrWhiteSpace(newNode.Name))
				throw new Exception("No se encontró ningun nombre dentro del tag: " + source);


			return null;
		}

		//source = regCommentsFinder.Replace(source, "");
		//XmlNode root = new XmlNode()
		//{
		//	Name = "root",
		//	ValueType = "Root"
		//};
		//Status statusIni = new Status()
		//{
		//	InnerText = source
		//};

		//nodes.Enqueue((root, statusIni));
		//(XmlNode node, Status status) lastNode = default;

		//while (true)
		//{
		//	nodes.TryPeek(out lastNode);

		//	var emptyNodesFound = regNodeEmptyFinder.Matches(lastNode.status.InnerText);
		//	var nodesFound = regNodeFinder.Matches(lastNode.status.InnerText);
		//	if ((nodesFound.Count + emptyNodesFound.Count) > 0)
		//	{
		//		foreach (Match nodeMatch in emptyNodesFound.Concat(nodesFound))
		//		{
		//			var tag = nodeMatch.Groups["tag"].Value.Trim();

		//			string defaultNamespace = lastNode.status?.DefaultNamespace ?? "";
		//			Dictionary<string, string> namespaces = lastNode.status?.Namespaces ?? new Dictionary<string, string>();

		//			var node = ProcessTag(tag, lastNode.node, ref namespaces, ref defaultNamespace);

		//			//Esto es para diferenciar entre emptyTag (object/null) de tag (string/"") 
		//			string innerText = null;
		//			if (string.IsNullOrWhiteSpace(nodeMatch.Groups["emptyKeyword"].Value))
		//				innerText = nodeMatch.Groups["InnerText"].Value.Trim();

		//			nodes.Enqueue((node, new Status() { InnerText = innerText, Namespaces = namespaces, DefaultNamespace = defaultNamespace }));
		//		}
		//	}
		//	else
		//	{
		//		//GetValueType(lastNode.node, lastNode.status.InnerText);
		//	}
		//}

		//return rootNodes;


		private XmlNode ProcessTag(string tag, XmlNode parent, ref Dictionary<string, string> namespaces, ref string defaultNamespace)
		{
			XmlNode node = new XmlNode();
			Match match = null;// regTagSplitter.Match(tag);
			if (match.Success)
			{
				var strNamespace = match.Groups["namespace"].Value.Trim();
				var strElement = match.Groups["element"].Value.Trim();
				var strAttributes = match.Groups["attributes"].Value.Trim();

				node.Name = strElement;
				node.Parent = parent;

				ProcessAttributes(strAttributes, node, namespaces, ref defaultNamespace);

				if (!string.IsNullOrWhiteSpace(strNamespace))
				{
					node.Namespace = namespaces[strNamespace];
				}
				else
				{
					node.Namespace = defaultNamespace;
				}
			}
			else
			{
				throw new Exception("El nodo procesado no es un \"Nodo\": " + tag);
			}

			return node;
		}

		private void ProcessAttributes(string attributesAsString, XmlNode actual, Dictionary<string, string> namespaces, ref string defaultNamespace)
		{
			var attributes = new List<XmlAttribute>();

			if (string.IsNullOrWhiteSpace(attributesAsString)) return;

			MatchCollection stringAttributes = null; //regAttributeFinder.Matches(attributesAsString);

			foreach (Match attributeMatch in stringAttributes)
			{
				string atrName = attributeMatch.Groups["atrName"].Value.Trim();
				string atrNamespace = attributeMatch.Groups["atrNamespace"].Value.Trim();
				string atrValue = attributeMatch.Groups["atrValue"].Value.Trim();

				bool isNamespace = atrNamespace.Equals("xmlns", StringComparison.InvariantCultureIgnoreCase);
				bool isDefaultNamespace = string.IsNullOrWhiteSpace(atrNamespace) && atrName.Equals("xmlns", StringComparison.InvariantCultureIgnoreCase);
				bool isAttribute = !isNamespace && !isDefaultNamespace;

				if (isNamespace)
				{
					if (!namespaces.ContainsKey(atrNamespace))
						namespaces.Add(atrNamespace, atrValue);
					else
						namespaces[atrNamespace] = atrValue;
				}
				else if (isDefaultNamespace)
				{
					defaultNamespace = atrValue;
				}
				else if (isAttribute)
				{
					XmlAttribute attribute = new XmlAttribute()
					{
						Name = atrName,
						Namespace = atrNamespace,
						ValueType = GetValueType(atrValue, "")
					};
					attributes.Add(attribute);
				}
			}

			foreach (var attribute in attributes)
			{
				if (!string.IsNullOrWhiteSpace(attribute.Namespace))
				{
					attribute.Namespace = namespaces[attribute.Namespace];
				}
				else
				{
					attribute.Namespace = defaultNamespace;
				}

				var attributeAsDataref = new DataRef(attribute.Namespace, attribute.Name);
				if (!Configuration.IgnoredAttributeTags.Contains(attributeAsDataref))
				{
					actual.Attributes.Add(attribute);
				}
			}
		}

		private string GetNamespace(string strNamespace, Dictionary<string, string> namespaces, string defaultNamespace)
		{
			if (!string.IsNullOrWhiteSpace(strNamespace))
			{
				if (!namespaces.ContainsKey(strNamespace.Trim()))
					throw new Exception("No se registró el espacio de nombres: " + strNamespace);

				return namespaces[strNamespace.Trim()];
			}
			else
			{
				return defaultNamespace;
			}
		}

		private string GetValueType(string source, string defaultType)
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
			string stringValue = "";
			char charValue = '0';
			bool boolValue = false;

			var numericValidation = regNumericValidator.Match(source);
			if (numericValidation.Success)
			{
				if (Configuration.UsedIntegralTypes.HasFlag(IntegralTypeEnumerator.ulongType) && ulong.TryParse(source, out ulongValue))
					defaultType = "ulong";
				else if (Configuration.UsedIntegralTypes.HasFlag(IntegralTypeEnumerator.uintType) && uint.TryParse(source, out uintValue))
					defaultType = "uint";
				else if (Configuration.UsedIntegralTypes.HasFlag(IntegralTypeEnumerator.ushortType) && ushort.TryParse(source, out ushortValue))
					defaultType = "ushort";
				else if (Configuration.UsedIntegralTypes.HasFlag(IntegralTypeEnumerator.byteType) && byte.TryParse(source, out byteValue))
					defaultType = "byte";

				if (string.IsNullOrWhiteSpace(defaultType))
				{
					if (Configuration.UsedIntegralTypes.HasFlag(IntegralTypeEnumerator.longType) && long.TryParse(source, out longValue))
						defaultType = "long";
					else if (Configuration.UsedIntegralTypes.HasFlag(IntegralTypeEnumerator.intType) && int.TryParse(source, out intValue))
						defaultType = "int";
					else if (Configuration.UsedIntegralTypes.HasFlag(IntegralTypeEnumerator.shortType) && short.TryParse(source, out shortValue))
						defaultType = "short";
					else if (Configuration.UsedIntegralTypes.HasFlag(IntegralTypeEnumerator.sbyteType) && sbyte.TryParse(source, out sbyteValue))
						defaultType = "sbyte";
				}

				if (string.IsNullOrWhiteSpace(defaultType))
				{
					if (Configuration.UsedFloatingTypes.HasFlag(FloatingTypeEnumerator.decimalType) && decimal.TryParse(source, out decimalValue))
						defaultType = "decimal";
					else if (Configuration.UsedFloatingTypes.HasFlag(FloatingTypeEnumerator.doubleType) && double.TryParse(source, out doubleValue))
						defaultType = "double";
					else if (Configuration.UsedFloatingTypes.HasFlag(FloatingTypeEnumerator.floatType) && float.TryParse(source, out floatValue))
						defaultType = "float";
				}
			}
			else
			{
				if (Configuration.UsedSpecialTypes.HasFlag(SpecialTypeEnumerator.datetime) && DateTime.TryParse(source, out datetimeValue))
					defaultType = "DateTime";
				else if (Configuration.UsedSpecialTypes.HasFlag(SpecialTypeEnumerator.charType) && char.TryParse(source, out charValue))
					defaultType = "char";
				else if (Configuration.UsedSpecialTypes.HasFlag(SpecialTypeEnumerator.boolean) && bool.TryParse(source, out boolValue))
					defaultType = "bool";
			}

			if (string.IsNullOrWhiteSpace(defaultType))
			{
				if (source == null)
					defaultType = "object";
				else
					defaultType = "string";
			}

			return defaultType;
		}

	}

	public class Status
	{
		public string InnerText { get; set; } = "";
		public Dictionary<string, string> Namespaces { get; set; } = new Dictionary<string, string>();
		public string DefaultNamespace { get; set; } = "";
	}

}

/*
<soap:Envelope xmlns:soap="http://schemas.xmlsoap.org/soap/envelope/" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
   <soap:Body>
      <getComisionesResponse xmlns="http://tempuri.org/">
         <getComisionesResult>
            <diffgr:diffgram xmlns:msdata="urn:schemas-microsoft-com:xml-msdata" xmlns:diffgr="urn:schemas-microsoft-com:xml-diffgram-v1">
               <DocumentElement xmlns="">
                  <OPERADORES_COMISIONES diffgr:id="OPERADORES_COMISIONES1" msdata:rowOrder="0">
                     <SERIE>CLASICA</SERIE>
                     <COMISION>20.00</COMISION>
                  </OPERADORES_COMISIONES>
                  <OPERADORES_COMISIONES diffgr:id="OPERADORES_COMISIONES2" msdata:rowOrder="1">
                     <SERIE>COSTARICA</SERIE>
                     <COMISION>20.00</COMISION>
                  </OPERADORES_COMISIONES>
               </DocumentElement>
            </diffgr:diffgram>
         </getComisionesResult>
      </getComisionesResponse>
   </soap:Body>
</soap:Envelope>



1º: Regex <(?<tag>(?<elementName>[^ >]+?)([ ][^>]*?)?)>.+?</\k{elementName}>
Foreach match
{
2º: from tag Regex ((?<namespace>[^<>: ]+?):)?(?<element>[^<>: ]+?)($|[ ]+)(?<attributes>(([^<>= ]+?=[^ =<>]+?($|[ ]+))+?))?($|[ ]+)
3º: Llamar al 1º
}
 * 
 */


