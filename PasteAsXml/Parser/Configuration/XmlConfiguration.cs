using LanguageToObjectLibrary.Parser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LanguageToObjectLibrary.Parser.Configuration
{
	public class XmlConfiguration : IConfiguration, ICloneable
	{
		/// <summary>
		/// Incluir aquí los namespace:name que no se desean usar como atributos. Se pueden usar Regex.
		/// </summary>
		public List<ElementNameFilter> IgnoredClasses { get; set; } = new List<ElementNameFilter>();
		/// <summary>
		/// Incluir aquí los namespace:name que no se desean usar como atributos. Se pueden usar Regex.
		/// </summary>
		public List<ElementNameFilter> IgnoredAttributes { get; set; } = new List<ElementNameFilter>();
		/// <summary>
		/// Especifica que filtros se usarán para tratar a una clase como root
		/// </summary>
		public List<ElementNameFilter> TreatedAsRoot { get; set; } = new List<ElementNameFilter>();
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
		public XmlClassDefinition XmlClassIdentifier { get; set; } = XmlClassDefinition.byNamespaceAndName;
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
		/// Especifica si el Namespace se intenta esconder en caso de ser irrelevante.
		/// </summary>
		public bool HideNamespace { get; set; }
		/// <summary>
		/// Especifica si el Name se intenta esconder en caso de ser irrelevante.
		/// </summary>
		public bool HideName { get; set; }
		/// <summary>
		/// Especifica el maximo numero de anidaciones que se pueden usar para los arrayItem (a mas numero mas dificil de entender la clase generada)
		/// </summary>
		public int maxArrayDepth { get; set; }

		/// <summary>
		/// Especifica los usings de la clase generada
		/// </summary>
		public List<string> Usings { get; set; } = new List<string>();
		/// <summary>
		/// Especifica los decoradores que se usarán para las clases Root
		/// </summary>
		public List<string> RootDecorators { get; set; } = new List<string>();
		/// <summary>
		/// Especifica los decoradores que se usarán para las clases
		/// </summary>
		public List<string> ClassDecorators { get; set; } = new List<string>();
		/// <summary>
		/// Especifica los decoradores que se usarán en las Properties
		/// </summary>
		public List<string> PropertyDecorators { get; set; } = new List<string>();
		/// <summary>
		/// Especifica los decoradores que se usaran en los atributos
		/// </summary>
		public List<string> AttributeDecorators { get; set; } = new List<string>();
		/// <summary>
		/// Especifica los decoradores que se usaran en los arrays
		/// </summary>
		public List<string> ArrayDecorators { get; set; } = new List<string>();

		public XmlConfiguration()
		{

		}

		public XmlConfiguration(XmlConfiguration other)
		{
			IgnoredAttributes = other.IgnoredAttributes.Select(x => (ElementNameFilter)x.Clone()).ToList();
			TreatedAsRoot = other.IgnoredAttributes.Select(x => (ElementNameFilter)x.Clone()).ToList();
			IgnoredClasses = other.IgnoredAttributes.Select(x => (ElementNameFilter)x.Clone()).ToList();
			UsedFloatingTypes = other.UsedFloatingTypes;
			UsedIntegralTypes = other.UsedIntegralTypes;
			UsedSpecialTypes = other.UsedSpecialTypes;
			XmlClassIdentifier = other.XmlClassIdentifier;
			UseFullProperties = other.UseFullProperties;
			ArrayAsList = other.ArrayAsList;
			PropertiesAsClasses = other.PropertiesAsClasses;
			HideNamespace = other.HideNamespace;
			HideName = other.HideName;
			maxArrayDepth = other.maxArrayDepth;
			Usings = other.Usings.ToList();
			RootDecorators = other.RootDecorators.ToList();
			ClassDecorators = other.ClassDecorators.ToList();
			PropertyDecorators = other.PropertyDecorators.ToList();
			ArrayDecorators = other.ArrayDecorators.ToList();
			AttributeDecorators = other.AttributeDecorators.ToList();
		}

		public object Clone()
		{
			return new XmlConfiguration(this);
		}
	}

	public enum XmlClassDefinition
	{
		byNamespaceAndName = 1,
		byNamespaceNameAndPath = 2
	}

	public class ElementNameFilter
	{
		public string Namespace { get; set; }
		public string Name { get; set; }

		public ElementNameFilter()
		{

		}

		public ElementNameFilter(ElementNameFilter other)
		{
			Namespace = other.Namespace;
			Name = other.Name;
		}

		public object Clone()
		{
			return new ElementNameFilter(this);
		}
	}
}

