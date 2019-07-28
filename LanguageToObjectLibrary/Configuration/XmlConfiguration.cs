using LanguageToObjectLibrary.Contracts;
using LanguageToObjectLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LanguageToObjectLibrary.Configuration
{
	public class XmlConfiguration : IConfiguration
	{
		/// <summary>
		/// Incluir aquí los namespace:name que no se desean usar como atributos. Se pueden usar Regex.
		/// </summary>
		public List<ElementNameFilter> IgnoredAttributeTags { get; set; }
		/// <summary>
		/// Especifica que filtros se usarán para tratar a una clase como root
		/// </summary>
		public List<ElementNameFilter> TreatedAsRoot { get; set; }
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
		/// Especifica como se compondrá el id de una clase. si por namespace y name (mas comprimido) o agregandole a eso el path (mas legible)
		/// </summary>
		public XmlClassDefinition XmlClassDefinition { get; set; } = XmlClassDefinition.byNamespaceAndName;
		/// <summary>
		/// Usa field + Property en true. Solo Property en false.
		/// </summary>
		public bool UseFullProperties { get; set; }
		/// <summary>
		/// Especifica si los arrays se usarán como tales o se usaran como Lists
		/// </summary>
		public bool ArrayAsList { get; set; }
		/// <summary>
		/// Especifica si las properties se tratarán como clases
		/// </summary>
		public bool PropertiesAsClasses { get; set; }
		/// <summary>
		/// Especifica el maximo numero de anidaciones que se pueden usar para los arrayItem (a mas numero mas dificil de entender la clase generada)
		/// </summary>
		public int maxArrayItemLevel { get; set; }

		/// <summary>
		/// Especifica los usings de la clase generada
		/// </summary>
		public List<string> Usings { get; set; }
		/// <summary>
		/// Especifica los decoradores que se usarán para las clases Root
		/// </summary>
		public List<string> RootDecorators { get; set; }
		/// <summary>
		/// Especifica los decoradores que se usarán para las clases
		/// </summary>
		public List<string> ClassDecorators { get; set; }
		/// <summary>
		/// Especifica los decoradores que se usarán en las Properties
		/// </summary>
		public List<string> PropertyDecorators { get; set; }
		/// <summary>
		/// Especifica los decoradores que se usaran en los atributos
		/// </summary>
		public List<string> AttributeDecorators { get; set; }
		/// <summary>
		/// Especifica los decoradores que se usaran en los arrays
		/// </summary>
		public List<string> ArrayDecorators { get; set; }
	}


	public class ElementNameFilter
	{
		public string Namespace { get; set; }
		public string Name { get; set; }
	}
}

