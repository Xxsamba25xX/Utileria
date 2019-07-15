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

        /// <summary>
        /// Matchea cualquier tipo de los espacios comunes
        /// </summary>
        public static string space = @"([ \t\r\n]+)";
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
        public static string versionNum => $"({number}.{number}+)";
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
        /// Estructura para la info de version
        /// </summary>
        public static string versionInfo => $"({space}version{eq}('{versionNum}'|{'"'}{versionNum}{'"'}))";
        /// <summary>
        /// Especificación para referencia
        /// </summary>
        public static string Reference => $"({entityRef}|{charRef})";
        /// <summary>
        /// Especificación nombres de atributos prefijados
        /// </summary>
        public static string prefixedAttName => $"(xmlns:{normalizedName})";
        /// <summary>
        /// Especificación espacio de nombres por defectos
        /// </summary>
        public static string defaultAttName => $"(xmlns)";
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

        private static string Misc => $"({Comment}|{PI}|{space})";

        private static string Prolog => $"({XmlDeclaration}?{Misc}*({DocTypeDecl}{Misc}*)?)";
        #endregion

        #region XMLDeclaration
        /// <summary>
        /// Especificación para las declaraciones xml (<?XML version="4.1" ?>)
        /// </summary>
        public static string XmlDeclaration => $"(<[?](xml|XML){versionInfo}({EncodingDeclaration})?({StandaloneDocumentDeclaration})?({space})?[?]>)";
        /// <summary>
        /// Información de la version (version="2.0")
        /// </summary>
        public static string VersionInfo => $"({space}version{eq}({sq}{versionNum}{sq}|{dq}{versionNum}{dq}))";
        /// <summary>
        /// Declaracion de la codificación (encoding="UTF-8")
        /// </summary>
        public static string EncodingDeclaration => $"({space}encoding{eq}({sq}{EncodingName}{sq}|{dq}{EncodingName}{dq}))";
        /// <summary>
        /// Declaracion de si el documento es standAlone (standalone="yes")
        /// </summary>
        public static string StandaloneDocumentDeclaration => $"({space}standalone{eq}({sq}{"(yes|no)"}{sq}|{dq}{"(yes|no)"}{dq}))";
        /// <summary>
        /// Nombre de un codificador (UTF-8)
        /// </summary>
        public static string EncodingName => $"({letter}({letter}|{number}|[.]|{anyHyphen})*)";
        #endregion

        #region Comment
        /// <summary>
        /// Especificación para las etiquetas de comentarios (<?-- Hole tode bien? -->)
        /// </summary>
        public static string Comment => $"(<[!][-]{2}{space}?(.*?){space}?[-]{2}>)";
        #endregion

        #region ProcessingInstruction
        /// <summary>
        /// Especificación para las etiquetas de Processing Instructions (<?php asdasdasdas asd asd [ ]as ?>)
        /// </summary>
        public static string PI => $"(<[?]{name}({space}(.*?)({space})?)?[?]>)";
        #endregion

        #region CDATA
        /// <summary>
        /// Especificación para las etiquetas de CDATA (<![CDATA[<p>tu vieja en tanga</p>]]>)
        /// </summary>
        public static string CDATA => $"(<!{@"\["}CDATA{@"\["}.*?{@"\]"}{@"\]>"})";
        #endregion

        #region DocumentTypeDeclaration
        /// <summary>
        /// Especificación para el DOCUMENT TYPE DECLARATION (<!DOCTYPE tuvi >)
        /// </summary>
        public static string DocTypeDecl => $"(<!DOCTYPE{space}{qualifiedName}({space}{ExternalID})?{space}?({@"\["}{IntSubset}{@"\]"}{space}?)?>)";

        private static string ExternalID => $"((SYSTEM{space}{SystemLiteral})|(PUBLIC{space}{PubIdLiteral}{space}{SystemLiteral}))";
        private static string SystemLiteral => $"({sq}[.*]{sq}|{dq}[.*]{dq})";
        private static string PubIdLiteral => $"({sq}{PubIdChar}{sq}|{dq}{PubIdChar}{dq})";
        private static string PubIdChar => $"(({letter})|({anyHyphen})|['()+,.:=?;!*#@$%])|{@"\/\r\n "}";

        private static string IntSubset => $"({MarkupDecl}|{DeclSep})*";
        private static string MarkupDecl => $"({ElementDecl}|{AttListDecl}|{EntityDecl}|{NotationDecl}|{PI}|{Comment})";
        private static string DeclSep => $"({PEReference}|{space})";
        private static string PEReference => $"([%]{name}[;])";

        private static string ElementDecl => $"(<!ELEMENT{space}{qualifiedName}{space}{ContentSpec}{space}?>)";
        private static string ContentSpec => $"(EMPTY|ANY|{Mixed}|{Children})";
        private static string Mixed => $"([(]{space}?[#]PCDATA({space}?[|]{space}{qualifiedName})*{space}?[)])";
        private static string Children => $"({Choice}|{Seq})";
        private static string Choice => $"(?<choice>[(]{space}?{cp}({space}?[|]{space}?{cp})+{space}?[)])";
        private static string Seq => $"(?<seq>[(]{space}?{cp}({space}?[,]{space}?{cp})+{space}?[)])";
        private static string cp => $"({qualifiedName}|{@"\g<choice>"}|{@"\g<seq>"})([?]|[*]|[+])";

        private static string AttListDecl => $"(<!ATTLIST{space}{qualifiedName}{AttDef}*{space}?>)";
        private static string AttDef => $"({space}({qualifiedName}|{NSAttName}){space}{AttType}{space}{DefaultDecl})";
        private static string AttType => $"(CDATA|ID|IDREF|IDREFS|ENTITY|ENTITIES|NMTOKEN|NMTOKENS|{EnumeratedType})";
        private static string DefaultDecl => $"([#]REQUIRED|[#]IMPLIED|(([#]FIXED{space})?{attValue}))";
        private static string EnumeratedType => $"({NotationType}|{Enumeration})";
        private static string NotationType => $"(NOTATION{space}[(]{space}?{name}({space}?[|]{space}?{name})*{space}?[)])";
        private static string Enumeration => $"([(]{space}?{NMToken}({space}?[|]{space}?{NMToken})*{space}?[)])";
        private static string NMToken => $"({nameChar})+";

        private static string EntityDecl => $"({GEDecl}|{PEDecl})";
        private static string GEDecl => $"(<!ENTITY{space}{name}{space}{EntityDef}{space}?>)";
        private static string PEDecl => $"(<!ENTITY{space}[%]{space}{name}{space}{PEDef}{space}?>)";
        private static string EntityDef => $"({EntityValue}|({ExternalID}{NDataDecl}?))";
        private static string PEDef => $"({EntityValue}|{ExternalID})";
        private static string EntityValue => $"(({dq}([^%&{dq}]|{PEReference}|{Reference})*{dq})|({sq}([^%&{sq}]|{PEReference}|{Reference})*{sq}))";
        private static string NDataDecl => $"({space}NDATA{space}{name})";

        private static string NotationDecl => $"(<!NOTATION{space}{name}{space}({ExternalID}|{PublicID}){space}?>)";
        private static string PublicID => $"(PUBLIC{space}{PubIdLiteral})";

        #endregion

        #region Element
        /// <summary>
        /// Especificación para las etiquetas de Elementos
        /// </summary>
        public static string Element => $"(?<element>({EmptyElementTag}|{STag}{Content}{ETag}))";
        public static string EmptyElementTag => $"(<{qualifiedName}(({space}{attribute})*){space}?/>)";
        public static string STag => $"(<{qualifiedName}(({space}{attribute})*){space}?>)";
        public static string ETag => $"(</{qualifiedName}{space}?>)";

        public static string attribute => $"({NSAttName}{eq}{attValue}|{qualifiedName}{eq}{attValue})";
        public static string NSAttName => $"({prefixedAttName}|{defaultAttName})";
        public static string attValue => $"({'"'}([^<&{'"'}]|{Reference})*{'"'}|{"'"}([^<&{"'"}]|{Reference})*{"'"})";
        private static object Content => $"({charData}?(({@"\g<element>"}|{Reference}|{CDATA}|{PI}|{Comment}){charData}?)*)";

        #endregion

        //public static string contentLiteral => $"(^(([^<{'"'}'])*?)((?<{strQuoted}>([{'"'}][^{'"'}]*?[{'"'}])|(['][^']*?[']))(([^<{'"'}'])*?))*?(?<{strTagStart}>[<]))";

    }
}


