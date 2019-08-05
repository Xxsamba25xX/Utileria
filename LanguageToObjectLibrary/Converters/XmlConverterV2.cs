using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using LanguageToObjectLibrary.Contracts;
using LanguageToObjectLibrary.Models;
using LanguageToObjectLibrary.Parser.Configuration;

namespace LanguageToObjectLibrary.Converters
{
    public class XmlConverterV2 : AbstractConverter
    {
        public XmlConverterV2(IConfiguration configuration) : base(configuration)
        {
        }

        public override List<AbstractNode> Convert(string source)
        {
            return null;
        }

        /// <summary>
        /// Procesa un texto solo si su inicio indica ser un comentario.
        /// </summary>
        /// <param name="source">texto del cual sacar el elemento procesado</param>
        /// <returns>source sin el elemento procesado</returns>
        public Status ProcessComment(Status status)
        {
            //De comment solo podríamos sacar content;
            Regex matcher = new Regex($"^(?<isMatch>{Utils.GroupedComment})?(?<rest>{Utils.Anything}*)", RegexOptions.IgnoreCase);
            var match = matcher.Match(status.Source);
            var newSource = match.Groups["rest"].Value;
            var node = match.Groups["isMatch"].Value;

            if (!string.IsNullOrWhiteSpace(node))
            {
                XMLCommentNode result = new XMLCommentNode(status.ActualNode, match.Value);

                result.Value = match.Groups[nameof(Utils.CommentContent)].Value;

                status.ActualNode = result;
            }

            return status;
        }

        /// <summary>
        /// Procesa un texto solo si su inicio indica ser una declaracion XML.
        /// </summary>
        /// <param name="source">texto del cual sacar el elemento procesado</param>
        /// <returns>source sin el elemento procesado</returns>
        public Status ProcessXMLDeclaration(Status status)
        {
            Regex matcher = new Regex($"^(?<isMatch>{Utils.GroupedXmlDeclaration})?(?<rest>.*)", RegexOptions.IgnoreCase);
            var match = matcher.Match(status.Source);
            var newSource = match.Groups["rest"].Value;
            var node = match.Groups["isMatch"].Value;

            if (string.IsNullOrWhiteSpace(node))
            {
                XMLDeclarationNode result = new XMLDeclarationNode(status.ActualNode);
                string fullVersion = match.Groups[nameof(Utils.VersionInfo)].Value;
                string fullEncoding = match.Groups[nameof(Utils.EncodingDeclaration)].Value;
                string fullStandalone = match.Groups[nameof(Utils.StandaloneDocumentDeclaration)].Value;

                if (!string.IsNullOrWhiteSpace(fullVersion))
                {
                    matcher = new Regex($"{Utils.GroupedVersionInfo}", RegexOptions.IgnoreCase);
                    result.Version = matcher.Match(fullVersion).Groups[nameof(Utils.versionNum)].Value;
                    if (result.Version.Length >= 3)
                        result.Version = result.Version.Substring(1, result.Version.Length - 2);
                }
                if (!string.IsNullOrWhiteSpace(fullEncoding))
                {
                    matcher = new Regex($"{Utils.GroupedEncodingDeclaration}", RegexOptions.IgnoreCase);
                    result.EncodingName = matcher.Match(fullVersion).Groups[nameof(Utils.EncodingName)].Value;
                    if (result.EncodingName.Length >= 3)
                        result.EncodingName = result.EncodingName.Substring(1, result.EncodingName.Length - 2);
                }
                if (!string.IsNullOrWhiteSpace(fullStandalone))
                {
                    matcher = new Regex($"{Utils.GroupedVersionInfo}", RegexOptions.IgnoreCase);
                    var standalone = matcher.Match(fullVersion).Groups[nameof(Utils.YesOrNo)].Value;
                    if (standalone.Length >= 3)
                        standalone = standalone.Substring(1, standalone.Length - 2);

                    result.isStandAlone = standalone.Equals("yes", StringComparison.InvariantCultureIgnoreCase);
                }


                status.ActualNode = result;
            }

            return status;
        }



    }
}




[System.Xml.Serialization.XmlRootAttribute(ElementName = "a", Namespace = "", IsNullable = false)]
public partial class A
{


    [System.Xml.Serialization.XmlArrayItemAttribute(ElementName = "c", Namespace = "", Type = typeof(E[]), IsNullable = false, NestingLevel = 0)]
    [System.Xml.Serialization.XmlArrayItemAttribute(ElementName = "e", Namespace = "", Type = typeof(E), IsNullable = false, NestingLevel = 1)]
    [System.Xml.Serialization.XmlArray(ElementName = "b", Namespace = "", IsNullable = false)]
    public E[][][] B { get; set; }

    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value { get; set; }

}

public partial class E
{


    [System.Xml.Serialization.XmlElementAttribute(ElementName = "d", Namespace = "", IsNullable = false)]
    public D[] D { get; set; }

    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "aux", Namespace = "")]
    public string Aux { get; set; }

}

public partial class D
{


    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "aux", Namespace = "")]
    public string Aux { get; set; }

    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value { get; set; }

}






// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class a
{

    private aBCE[][][] bField;

    private string[] textField;

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("c", typeof(aBCE[]), IsNullable = false)]
    [System.Xml.Serialization.XmlArrayItemAttribute("e", typeof(aBCE), IsNullable = false, NestingLevel = 1)]
    public aBCE[][][] b
    {
        get
        {
            return this.bField;
        }
        set
        {
            this.bField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string[] Text
    {
        get
        {
            return this.textField;
        }
        set
        {
            this.textField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class aBCE
{

    private aBCED[] dField;

    private string auxField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("d")]
    public aBCED[] d
    {
        get
        {
            return this.dField;
        }
        set
        {
            this.dField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string aux
    {
        get
        {
            return this.auxField;
        }
        set
        {
            this.auxField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class aBCED
{

    private string auxField;

    private byte valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string aux
    {
        get
        {
            return this.auxField;
        }
        set
        {
            this.auxField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public byte Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

