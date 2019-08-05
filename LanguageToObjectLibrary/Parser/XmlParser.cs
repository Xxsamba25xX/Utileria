using LanguageToObjectLibrary.Parser.Configuration;
using LanguageToObjectLibrary.Parser.Models;
using Newtonsoft.Json;
using System;
using System.Collections;
using LanguageToObjectLibrary.Extensions;
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
        }

        public string GetClasses(string xmlAsString)
        {
            ProcessXml(xmlAsString);
            FixClasses();
            var stringifiedClasses = ClassesToString();
            string prueba1 = GenerateCSharpDocument(stringifiedClasses);
            return prueba1;
        }

        private string GenerateCSharpDocument(Dictionary<string, string> stringifiedClasses)
        {
            StringBuilder sb = new StringBuilder();

            Dictionary<string, bool> processedClasses = new Dictionary<string, bool>();
            if (Document.Childs.Count == 0) return "";
            LinkedList<GeneratedChild> stack = new LinkedList<GeneratedChild>();
            stack.AddFirst(Document.Childs.Values);
            var pointer = stack.First;
            while (stack.Count != 0)
            {
                var childClass = pointer.Value.Type;
                if (childClass != null && !processedClasses.ContainsKey(childClass.Id))
                {
                    sb.AppendLine(stringifiedClasses[childClass.Id]);
                    processedClasses.Add(childClass.Id, true);
                }
                stack.RemoveFirst();
                stack.AddFirst(childClass.Childs.Values);
                pointer = stack.First;
            }

            return sb.ToString();
        }

        private Dictionary<string, string> ClassesToString()
        {
            int level = 0;
            var stringifiedClass = new Dictionary<string, string>();

            foreach (var classItem in Classes.Values)
            {
                StringBuilder sb = new StringBuilder();
                bool rootByConfig = Configuration.TreatedAsRoot != null && Configuration.TreatedAsRoot.Any(x => Regex.IsMatch(classItem.Name, x.Name) && Regex.IsMatch(classItem.Namespace, x.Namespace));
                bool rootByRight = Document.Childs.ContainsKey(classItem.Id);
                if (rootByConfig || rootByRight)
                {
                    sb.Append(GetTab(level)).AppendLine($"[System.Xml.Serialization.XmlRootAttribute(ElementName =\"{classItem.Name}\", Namespace = \"{classItem.Namespace}\", IsNullable = false)]");
                }
                sb.Append(GetTab(level)).AppendLine($"public partial class {classItem.ShowName}");
                sb.Append(GetTab(level)).AppendLine("{");
                level++;

                //Recorrer las propiedades.
                var propertiesAsString = PropertiesAsString(level, classItem.Childs);
                //Recorrer los attributos.
                var attributesAsString = AttributesAsString(level, classItem.Attributes);
                //Agregar el Value de la clase si hace falta
                (string field, string property) valueAsString = ("", "");
                if (classItem.Value != null)
                {
                    valueAsString = ValueAsString(level, classItem.Value);
                }
                //Rellenamos los fields
                sb.Append(propertiesAsString.field).Append(attributesAsString.field).Append(valueAsString.field);
                //Rellenamos las properties
                sb.Append(propertiesAsString.property).Append(attributesAsString.property).Append(valueAsString.property);
                level--;
                sb.Append(GetTab(level)).AppendLine("}");

                stringifiedClass.Add(classItem.Id, sb.ToString());
            }

            return stringifiedClass;
        }

        private (string field, string property) ValueAsString(int level, Value value)
        {
            StringBuilder property = new StringBuilder();
            StringBuilder field = new StringBuilder();
            var type = value.Type;

            //Generamos la firma
            property.Append(GetTab(level)).AppendLine("[System.Xml.Serialization.XmlTextAttribute()]");

            //Generamos la propiedad y los campos
            property.Append(GetTab(level)).Append($"public {type} {value.ShowName}");
            if (Configuration.UseFullProperties)
            {
                var fieldName = value.ShowName[0].ToString().ToLower() + (value.ShowName.Length > 1 ? value.ShowName.Substring(1) : "") + "Field";
                field.Append(GetTab(level)).AppendLine($"private {type} {fieldName};");

                property.Append(GetTab(level)).AppendLine("{");
                level++;
                property.Append(GetTab(level)).AppendLine("get");
                property.Append(GetTab(level)).AppendLine("{");
                level++;
                property.Append(GetTab(level)).AppendLine($"return this.{fieldName};");
                level--;
                property.Append(GetTab(level)).AppendLine("}");
                property.Append(GetTab(level)).AppendLine("set");
                property.Append(GetTab(level)).AppendLine("{");
                level++;
                property.Append(GetTab(level)).AppendLine($"this.{fieldName} = value;");
                level--;
                property.Append(GetTab(level)).AppendLine("}");
                level--;
                property.Append(GetTab(level)).AppendLine("}");
            }
            else
            {
                property.AppendLine("{ get; set; }");
            }

            property.AppendLine();
            field.AppendLine();

            return (field.ToString(), property.ToString());
        }

        private (string field, string property) AttributesAsString(int level, Dictionary<string, GeneratedAttribute> attributes)
        {
            List<string> fields = new List<string>();
            List<string> properties = new List<string>();

            foreach (var attribute in attributes.Values)
            {
                StringBuilder property = new StringBuilder();
                StringBuilder field = new StringBuilder();
                var type = attribute.Value.Type;

                //Generamos la firma
                property.Append(GetTab(level)).AppendLine($"[System.Xml.Serialization.XmlAttributeAttribute(AttributeName = \"{attribute.Name}\", Namespace = \"{attribute.Namespace}\")]");

                //Generamos la propiedad y los campos
                property.Append(GetTab(level)).Append($"public {type} {attribute.ShowName}");
                if (Configuration.UseFullProperties)
                {
                    var fieldName = attribute.ShowName[0].ToString().ToLower() + (attribute.ShowName.Length > 1 ? attribute.ShowName.Substring(1) : "") + "Field";
                    field.Append(GetTab(level)).AppendLine($"private {type} {fieldName};");

                    property.Append(GetTab(level)).AppendLine("{");
                    level++;
                    property.Append(GetTab(level)).AppendLine("get");
                    property.Append(GetTab(level)).AppendLine("{");
                    level++;
                    property.Append(GetTab(level)).AppendLine($"return this.{fieldName};");
                    level--;
                    property.Append(GetTab(level)).AppendLine("}");
                    property.Append(GetTab(level)).AppendLine("set");
                    property.Append(GetTab(level)).AppendLine("{");
                    level++;
                    property.Append(GetTab(level)).AppendLine($"this.{fieldName} = value;");
                    level--;
                    property.Append(GetTab(level)).AppendLine("}");
                    level--;
                    property.Append(GetTab(level)).AppendLine("}");
                }
                else
                {
                    property.AppendLine("{ get; set; }");
                }

                property.AppendLine();
                field.AppendLine();
                fields.Add(field.ToString());
                properties.Add(property.ToString());
            }

            return (string.Join("\n", fields), string.Join("\n", properties));
        }

        private (string field, string property) PropertiesAsString(int level, Dictionary<string, GeneratedChild> childs)
        {
            List<string> fields = new List<string>();
            List<string> properties = new List<string>();
            foreach (var child in childs.Values)
            {
                StringBuilder property = new StringBuilder();
                StringBuilder field = new StringBuilder();
                var type = "";
                var arrangedType = "";

                //Generamos los nesting de arrays
                List<GeneratedClass> nestedChilds = new List<GeneratedClass>();
                GeneratedChild actualNestedChild = child;
                while (IsNesteableChild(actualNestedChild))
                {
                    nestedChilds.Add(actualNestedChild.Type);
                    if (actualNestedChild.Type.Childs.Values.First() != null)
                        actualNestedChild = actualNestedChild.Type.Childs.Values.First();
                }
                Configuration.maxArrayDepth = Math.Max(1, Configuration.maxArrayDepth);//=0 minimo

                //Generamos las firmas
                if (nestedChilds.Count == 0)
                {
                    type = child.Type.ShowName;

                    if (IsLeafClass(child.Type) && !Configuration.PropertiesAsClasses)
                    {
                        type = child.Type.Value.Type;
                        child.Type = null;
                    }
                    arrangedType = Arrange(type, child.IsArray ? 1 : 0);

                    //Si no hay un nested solo procesar el child;
                    property.Append(GetTab(level)).AppendLine($"[System.Xml.Serialization.XmlElementAttribute(ElementName = \"{child.Name}\", Namespace = \"{child.Namespace}\", IsNullable = false)]");
                }
                else
                {
                    //Si tiene mas de uno procesar la lista 
                    var depth = Math.Min(nestedChilds.Count, Configuration.maxArrayDepth);
                    var lastClass = nestedChilds[depth - 1];
                    var lastClassFirstChild = lastClass.Childs.First().Value;
                    type = lastClassFirstChild.Type.ShowName;

                    if (IsLeafClass(lastClassFirstChild.Type) && !Configuration.PropertiesAsClasses)
                    {
                        type = lastClassFirstChild.Type.Value.Type;
                        child.Type = null;
                    }
                    else
                    {
                        child.Type = lastClassFirstChild.Type;
                    }

                    for (int i = 0; i < depth; i++)
                    {
                        var firstChild = nestedChilds[i].Childs.First().Value;
                        var name = firstChild.Name;
                        var nameSpace = firstChild.Namespace;

                        property.Append(GetTab(level)).AppendLine($"[System.Xml.Serialization.XmlArrayItemAttribute(ElementName = \"{name}\", Namespace = \"{nameSpace}\", Type = typeof({Arrange(type, depth - i - 1)}), IsNullable = false, NestingLevel = {i})]");
                    }
                    arrangedType = Arrange(type, depth + 1);
                    property.Append(GetTab(level)).AppendLine($"[System.Xml.Serialization.XmlArray(ElementName = \"{child.Name}\", Namespace = \"{child.Namespace}\", IsNullable = false)]");
                }

                //Generamos la propiedad y los campos
                property.Append(GetTab(level)).Append($"public {arrangedType} {child.ShowName}");
                if (Configuration.UseFullProperties)
                {
                    var fieldName = child.ShowName[0].ToString().ToLower() + (child.ShowName.Length > 1 ? child.ShowName.Substring(1) : "") + "Field";
                    field.Append(GetTab(level)).AppendLine($"private {arrangedType} {fieldName};");

                    property.Append(GetTab(level)).AppendLine("{");
                    level++;
                    property.Append(GetTab(level)).AppendLine("get");
                    property.Append(GetTab(level)).AppendLine("{");
                    level++;
                    property.Append(GetTab(level)).AppendLine($"return this.{fieldName};");
                    level--;
                    property.Append(GetTab(level)).AppendLine("}");
                    property.Append(GetTab(level)).AppendLine("set");
                    property.Append(GetTab(level)).AppendLine("{");
                    level++;
                    property.Append(GetTab(level)).AppendLine($"this.{fieldName} = value;");
                    level--;
                    property.Append(GetTab(level)).AppendLine("}");
                    level--;
                    property.Append(GetTab(level)).AppendLine("}");
                }
                else
                {
                    property.AppendLine("{ get; set; }");
                }

                property.AppendLine();
                field.AppendLine();
                fields.Add(field.ToString());
                properties.Add(property.ToString());
            }

            return (string.Join("\n", fields), string.Join("\n", properties));
        }

        private string Arrange(string type, int depth)
        {
            string result = type;
            for (int i = 0; i < depth; i++)
            {
                if (Configuration.ArrayAsList)
                {
                    result = $"List<{result}>";
                }
                else
                {
                    result = $"{result}[]";
                }
            }

            return result;
        }

        private bool IsLeafClass(GeneratedClass generatedClass)
        {
            bool hasAttributes = generatedClass.Attributes.Count == 0;
            bool hasValue = generatedClass.Value != null;
            bool hasChilds = generatedClass.Childs.Count == 0;

            return hasValue && !hasAttributes && !hasChilds;
        }

        private bool IsNesteableChild(GeneratedChild child)
        {
            if (child == null) return false;

            bool isArray = child.IsArray;
            bool hasValue = child.Type.Value != null;
            bool hasUniqueChild = child.Type.Childs?.Count == 1;
            bool hasAttributes = child.Type.Attributes?.Count > 0;
            bool hasOnlyUniqueChild = !hasValue && hasUniqueChild && !hasAttributes;

            return isArray && hasOnlyUniqueChild;
        }

        private string GetTab(int level)
        {
            string tab = "   ";
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < level; i++)
            {
                sb.Append(tab);
            }

            return sb.ToString();
        }

        private void FixClasses()
        {
            var nameTable = new Dictionary<string, bool>();

            List<string> idsToRemove = new List<string>();
            foreach (var classGroup in Classes.GroupBy(x => x.Value.Name))
            {
                var classGroupCount = classGroup.Count();
                foreach (var classItem in classGroup)
                {
                    bool hasChilds = classItem.Value.Childs?.Count > 0;
                    bool hasValue = classItem.Value.Value != null;
                    bool hasAttributes = classItem.Value.Attributes?.Count > 0;
                    bool isValueObject = hasValue && classItem.Value.Value.Type == "object";
                    if (hasChilds)
                    {
                        if (isValueObject)
                        {
                            //Borrar los Values de tipo Object cuando la clase tenga childs
                            classItem.Value.Value = null;
                        }
                        else if (hasValue)
                        {
                            //Value Showname
                            int showNameCount = 0;
                            do
                            {
                                classItem.Value.Value.ShowName = classItem.Value.Value.Name + (showNameCount == 0 ? "" : $"_{showNameCount}");
                                showNameCount++;
                            } while (classItem.Value.Childs.Any(x => x.Value.ShowName == classItem.Value.Value.ShowName));
                        }
                    }
                    if (!hasChilds && !hasAttributes && hasValue && !Configuration.PropertiesAsClasses)
                    {
                        //Borrar de Classes los nodos valor, Si la configuración lo desea
                        idsToRemove.Add(classItem.Key);
                    }
                    else
                    {
                        //Renombrar los shownames de Document
                        int showNameCount = 0;
                        do
                        {
                            classItem.Value.ShowName = classItem.Value.Name + (showNameCount == 0 ? "" : $"_{showNameCount}");
                            showNameCount++;
                        } while (nameTable.ContainsKey(classItem.Value.ShowName));
                        nameTable.Add(classItem.Value.ShowName, true);
                    }
                }
            }

            foreach (string item in idsToRemove)
            {
                Classes.Remove(item);
            }
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

                if (lastStackedElement.node.NodeType == XmlNodeType.Element && lastStackedElement.node.ChildNodes.Count == 0)
                {
                    //Se setea un value en object. Luego hay que limpiar los que tienen value en object y encima childs
                    SetValue(lastStackedElement.element, "object", lastStackedElement.element.Namespace, false);
                }

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
                        bool hasAttributes = itemNode.Attributes.Where(x => !IsIgnoredAttribute(x.NamespaceURI, x.LocalName)).Count() > 0;
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
            SetValue(parent, valueType, itemInGroup.NamespaceURI, isArray);
        }

        private void SetValue(GeneratedClass parent, string valueType, string namespaceURI, bool isArray)
        {
            if (parent.Value == null)
            {
                parent.Value = new Value()
                {
                    Id = "_Value",
                    Name = "Value",
                    ShowName = "Value",
                    Namespace = namespaceURI,
                    Type = valueType
                };
            }
            else
            {
                parent.Value.Type = GetBiggerType(new string[] { parent.Value.Type, valueType });
            }
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
                    Id = internalId,
                    Name = node.LocalName,
                    ShowName = node.LocalName,
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
                    ShowName = node.LocalName,
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
                        ShowName = item.LocalName,
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
            if (Configuration.IgnoredAttributes == null) return false;
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





