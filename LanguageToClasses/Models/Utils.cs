using System;
using System.Collections.Generic;
using System.Text;

namespace LanguageToClasses.Models
{
    public static class Utils
    {
        public static string strTagStart = "tagStart";
        public static string strNamespace = "namespace";
        public static string strLocalName = "localName";
        public static string strAttributes = "attributes";
        public static string strQuoted = "quoted";

        public static string strElementNameTag = "elementNameTagQueEsSecreto";

        /// <summary>
        /// Matchea cualquier tipo de los espacios comunes
        /// </summary>
        public static string space = @"([ \t\r\n]+)";

        public static string Anything => $"(.|{space})";

        /// <summary>
        /// Simple Quotes
        /// </summary>
        public static string sq = "'";
        /// <summary>
        /// Double Quotes
        /// </summary>
        public static string dq = "\"";
        /// <summary>
        /// Letters
        /// </summary>
        public static string letter = "[a-zA-Z]";
        /// <summary>
        /// Numbers
        /// </summary>
        public static string number = "[0-9]";
        /// <summary>
        /// Hypens
        /// </summary>
        public static string anyHyphen = "'-'|[_]";
        /// <summary>
        /// Especifica la estructura de un numero de version
        /// </summary>
        public static string versionNum => $"({number}[.]{number}+)";
        /// <summary>
        /// Matchea los simbolos de igual, Ejemplo los que componen un atributo
        /// </summary>
        public static string eq => $"({space}?[=]{space}?)";
        /// <summary>
        /// Caracter de inicio de un nombre
        /// </summary>
        public static string nameStartChar = @"([:_]|[a-z])";
        /// <summary>
        /// Caracter de nombre, si te fijas hay caracteres que no se pueden usar como inicio de nombre.
        /// </summary>
        public static string nameChar => $"({"([-.]|[0-9])"}|{nameStartChar})";
        /// <summary>
        /// Tipo de caracter aceptado para matchear todo aquello que sea un value, el contenido de un elemento o un comentario.
        /// </summary>
        public static string charData => $"([^<&]*)";
        /// <summary>
        /// Especificación de un nombre
        /// </summary>
        public static string name => $"({nameStartChar}{nameChar}*)";
        /// <summary>
        /// Especificación de un nombre Normalizado, no tiene ':' como inicio ni contenido de un nombre. Usado para el nombre de las etiquetas.
        /// </summary>
        public static string normalizedName => $"({name.Replace(":", "")})";
        /// <summary>
        /// Referencias a una entidad o elemento quizas 
        /// </summary>
        public static string entityRef => $"(&{name};)";
        /// <summary>
        /// Referencias a un caracter unicode u otro. Ejemplo:&#x0000;
        /// </summary>
        public static string charRef => $"(&#[0-9]+;)|(&#x[0-9a-fA-F];)";
        /// <summary>
        /// Especificación para referencia
        /// </summary>
        public static string Reference => $"({entityRef}|{charRef})";
        
        /// <summary>
        /// Especificación para cualquier atributo que tenga relación con los espacios de nombres
        /// </summary>
        /// <summary>
        /// Especificación de nombre prefijado
        /// </summary>
        public static string prefixedName => $"({normalizedName}):({normalizedName})";
        /// <summary>
        /// Especificación de nombre sin prefijar
        /// </summary>
        public static string unprefixedName => $"({normalizedName})";
        /// <summary>
        /// Nombres que pueden ser prefijado o no.
        /// <para>Grupos: </para>
        /// </summary>
        public static string qualifiedName => $"({prefixedName}|{unprefixedName})";

        #region Document
        public static string Document => $"({Prolog}{Element}{Misc}*)";

        public static string Misc => $"({Comment}|{PI}|{space})";

        public static string Prolog => $"({XmlDeclaration}?{Misc}*({DocTypeDecl}{Misc}*)?)";
        #endregion

        #region XMLDeclaration
        /// <summary>
        /// Especificación para las declaraciones xml (<?XML version="4.1" ?>)
        /// </summary>
        public static string XmlDeclaration => $"((<[?](xml|XML))({VersionInfo})({EncodingDeclaration})?({StandaloneDocumentDeclaration})?(({space})?[?]>))";
        public static string GroupedXmlDeclaration => $"((<[?](xml|XML))(?<{nameof(VersionInfo)}>{VersionInfo})(?<{nameof(EncodingDeclaration)}>{EncodingDeclaration})?(?<{nameof(StandaloneDocumentDeclaration)}>{StandaloneDocumentDeclaration})?(({space})?[?]>))";

        /// <summary>
        /// Información de la version (version="2.0")
        /// </summary>
        public static string VersionInfo => $"({space}version{eq}({sq}{versionNum}{sq}|{dq}{versionNum}{dq}))";
        public static string GroupedVersionInfo => $"({space}version{eq}(?<{nameof(versionNum)}>{sq}{versionNum}{sq}|{dq}{versionNum}{dq}))";

        /// <summary>
        /// Declaracion de la codificación (encoding="UTF-8")
        /// </summary>
        public static string EncodingDeclaration => $"({space}encoding{eq}({sq}{EncodingName}{sq}|{dq}{EncodingName}{dq}))";
        public static string GroupedEncodingDeclaration => $"({space}encoding{eq}(?<{nameof(EncodingName)}>{sq}{EncodingName}{sq}|{dq}{EncodingName}{dq}))";
        /// <summary>
        /// Nombre de un codificador (UTF-8)
        /// </summary>
        public static string EncodingName => $"({letter}({letter}|{number}|[.]|{anyHyphen})*)";

        /// <summary>
        /// Declaracion de si el documento es standAlone (standalone="yes")
        /// </summary>
        public static string StandaloneDocumentDeclaration => $"({space}standalone{eq}({sq}{YesOrNo}{sq}|{dq}{YesOrNo}{dq}))";
        public static string GroupedStandaloneDocumentDeclaration => $"({space}standalone{eq}(?<{nameof(YesOrNo)}>{sq}{YesOrNo}{sq}|{dq}{YesOrNo}{dq}))";
        public static string YesOrNo => $"(yes|no)";

        #endregion

        #region Comment
        /// <summary>
        /// Especificación para las etiquetas de comentarios (<?-- Hole tode bien? -->)
        /// </summary>
        public static string Comment => $"(<[!][-]{@"{2}"}{space}?{CommentContent}?{space}?[-]{@"{2}"}>)";
        public static string GroupedComment => $"(<[!][-]{@"{2}"}{space}?(?<CommentContent>{CommentContent})?{space}?[-]{@"{2}"}>)";

        public static string CommentContent => $"({Anything}*?)";
        #endregion

        #region ProcessingInstruction
        /// <summary>
        /// Especificación para las etiquetas de Processing Instructions (<?php asdasdasdas asd asd [ ]as ?>)
        /// </summary>
        public static string PI => $"(<[?]{name}({space}({Anything}*?)({space})?)?[?]>)";
        #endregion

        #region CDATA
        /// <summary>
        /// Especificación para las etiquetas de CDATA (<![CDATA[<p>tu vieja en tanga</p>]]>)
        /// </summary>
        public static string CDATA => $"(<!{@"\["}CDATA{@"\["}({CDATAContent}){@"\]"}{@"\]>"})";
        public static string GroupedCDATA => $"(<!{@"\["}CDATA{@"\["}(?<{nameof(CDATAContent)}>{CDATAContent}){@"\]"}{@"\]>"})";

        public static string CDATAContent => $"({Anything}*?)";
        #endregion

        #region DocumentTypeDeclaration
        /// <summary>
        /// Especificación para el DOCUMENT TYPE DECLARATION (<!DOCTYPE tuvi >)
        /// </summary>
        public static string DocTypeDecl => $"(<!DOCTYPE{space}{qualifiedName}({space}{ExternalID})?{space}?({@"\["}{IntSubset}{@"\]"}{space}?)?>)";

        public static string ExternalID => $"((SYSTEM{space}{SystemLiteral})|(PUBLIC{space}{PubIdLiteral}{space}{SystemLiteral}))";
        public static string SystemLiteral => $"({sq}[.]*{sq}|{dq}[.]*{dq})";
        public static string PubIdLiteral => $"({sq}{PubIdChar}{sq}|{dq}{PubIdChar}{dq})";
        public static string PubIdChar => $"(({letter})|({anyHyphen})|['()+,.:=?;!*#@$%])|{@"\/\r\n "}";

        public static string IntSubset => $"({MarkupDecl}|{DeclSep})*";
        public static string MarkupDecl => $"({ElementDecl}|{AttListDecl}|{EntityDecl}|{NotationDecl}|{PI}|{Comment})";
        public static string DeclSep => $"({PEReference}|{space})";
        public static string PEReference => $"([%]{name}[;])";

        public static string ElementDecl => $"(<!ELEMENT{space}{qualifiedName}{space}{ContentSpec}{space}?>)";
        public static string ContentSpec => $"(EMPTY|ANY|{Mixed}|{Children})";
        public static string Mixed => $"([(]{space}?[#]PCDATA({space}?[|]{space}{qualifiedName})*{space}?[)])";
        public static string Children => $"({Choice}|{Seq})";
        public static string Choice => $"(?<choice>[(]{space}?{cp}({space}?[|]{space}?{cp})+{space}?[)])";
        public static string Seq => $"(?<seq>[(]{space}?{cp}({space}?[,]{space}?{cp})+{space}?[)])";
        public static string cp => $"(({qualifiedName}|{@"\g<choice>"}|{@"\g<seq>"})([?]|[*]|[+])?)";

        public static string AttListDecl => $"(<!ATTLIST{space}{qualifiedName}{AttDef}*{space}?>)";
        public static string AttDef => $"({space}({qualifiedName}|{NSAttName}){space}{AttType}{space}{DefaultDecl})";
        public static string AttType => $"(CDATA|ID|IDREF|IDREFS|ENTITY|ENTITIES|NMTOKEN|NMTOKENS|{EnumeratedType})";
        public static string DefaultDecl => $"([#]REQUIRED|[#]IMPLIED|(([#]FIXED{space})?{attValue}))";
        public static string EnumeratedType => $"({NotationType}|{Enumeration})";
        public static string NotationType => $"(NOTATION{space}[(]{space}?{name}({space}?[|]{space}?{name})*{space}?[)])";
        public static string Enumeration => $"([(]{space}?{NMToken}({space}?[|]{space}?{NMToken})*{space}?[)])";
        public static string NMToken => $"({nameChar})+";

        public static string EntityDecl => $"({GEDecl}|{PEDecl})";
        public static string GEDecl => $"(<!ENTITY{space}{name}{space}{EntityDef}{space}?>)";
        public static string PEDecl => $"(<!ENTITY{space}[%]{space}{name}{space}{PEDef}{space}?>)";
        public static string EntityDef => $"({EntityValue}|({ExternalID}{NDataDecl}?))";
        public static string PEDef => $"({EntityValue}|{ExternalID})";
        public static string EntityValue => $"(({dq}([^%&{dq}]|{PEReference}|{Reference})*{dq})|({sq}([^%&{sq}]|{PEReference}|{Reference})*{sq}))";
        public static string NDataDecl => $"({space}NDATA{space}{name})";

        public static string NotationDecl => $"(<!NOTATION{space}{name}{space}({ExternalID}|{PublicID}){space}?>)";
        public static string PublicID => $"(PUBLIC{space}{PubIdLiteral})";

        #endregion

        #region Element
        /// <summary>
        /// Especificación para las etiquetas de Elementos
        /// </summary>
        public static string Element => $"(?<{strElementNameTag}>({EmptyElementTag}|{STag}{Content}{ETag}))";
        public static string GroupedElement => $"(?<{strElementNameTag}>((?<{nameof(EmptyElementTag)}>{EmptyElementTag})|(?<{nameof(STag)}>{STag})(?<{nameof(Content)}>{Content})(?<{nameof(ETag)}>{ETag})))";

        public static string EmptyElementTag => $"(<({EmptyElementTagName})({EmptyElementTagAttributes}){space}?\\/>)";
        public static string EmptyElementTagName => $"({qualifiedName})";
        public static string EmptyElementTagAttributes => $"(({space}{attribute})*)";

        public static string STag => $"(<({STagName})({STagAttributes}){space}?>)";
        public static string STagName => $"({qualifiedName})";
        public static string STagAttributes => $"(({space}{attribute})*)";

        public static string ETag => $"(<\\/({ETagName}){space}?>)";
        public static string ETagName => $"({qualifiedName})";

        public static string attribute => $"({NSAttName}{eq}{attValue}|{qualifiedName}{eq}{attValue})";
        public static string NSAttName => $"({prefixedAttName}|{defaultAttName})";
        public static string prefixedAttName => $"(xmlns:{normalizedName})";
        public static string defaultAttName => $"(xmlns)";
        public static string attValue => $"({'"'}([^<&{'"'}]|{Reference})*{'"'}|{"'"}([^<&{"'"}]|{Reference})*{"'"})";
        public static object Content => $"({charData}?(({@"\g<" + strElementNameTag + ">"}|{Reference}|{CDATA}|{PI}|{Comment}){charData}?)*)";

        #endregion


        //public static string contentLiteral => $"(^(([^<{'"'}'])*?)((?<{strQuoted}>([{'"'}][^{'"'}]*?[{'"'}])|(['][^']*?[']))(([^<{'"'}'])*?))*?(?<{strTagStart}>[<]))";

    }
}


