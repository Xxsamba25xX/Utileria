using LanguageToClasses.Contracts;
using LanguageToClasses.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LanguageToClasses.Configuration
{
    public class XmlConfiguration : IConfiguration
    {
        /// <summary>
        /// Incluir aquí los namespace:name que no se desean usar como atributos. Se pueden usar Regex.
        /// </summary>
        public List<string> IgnoredAttributeTags { get; set; }
        /// <summary>
        /// Aqui se especifican los tipos de datos enteros con los que se trabajará.
        /// </summary>
        public IntegralTypeEnumerator UsedIntegralTypes { get; set; }
        /// <summary>
        /// Aqui se especifican los tipos de datos decimales con los que se trabajará.
        /// </summary>
        public FloatingTypeEnumerator UsedFloatingTypes { get; set; }
        /// <summary>
        /// Aqui se especifican los tipos de datos especiales con los que se trabajará.
        /// </summary>
        public SpecialTypeEnumerator UsedSpecialTypes { get; set; }
        /// <summary>
        /// Usa field + Property en true. Solo Property en false.
        /// </summary>
        public bool UseFullProperties { get; set; }
        /// <summary>
        /// Especifica como se compondrá el id de una clase. si por namespace y name (mas comprimido) o agregandole a eso el path (mas legible)
        /// </summary>
        public XmlClassDefinition XmlClassDefinition { get; set; } = XmlClassDefinition.byNamespaceAndName;
    }
}

