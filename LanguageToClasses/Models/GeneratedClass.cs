using System;
using System.Collections.Generic;
using System.Text;

namespace LanguageToClasses.Models
{
	public abstract class GeneratedElement
	{
		protected string name = "";
		public string Name
		{
			get
			{
				return name;
			}
			set
			{
				name = value;
				ShowName = value;
			}
		}
		public string Namespace { get; set; }
		public bool isArray { get; set; }
		public string ShowName { get; set; }
	}


	public class GeneratedClass : GeneratedElement
	{
		public Dictionary<string, GeneratedProperty> Properties { get; set; } = new Dictionary<string, GeneratedProperty>();
		public Dictionary<string, GeneratedAttribute> Attributes { get; set; } = new Dictionary<string, GeneratedAttribute>();
		public Dictionary<string, GeneratedClass> Childs { get; set; } = new Dictionary<string, GeneratedClass>();
	}

	public class GeneratedProperty : GeneratedElement
	{
		public GeneratedProperty()
		{
			Name = "Value";
			Namespace = "";
		}

		public string ValueType { get; set; } = "object";
	}

	public class GeneratedAttribute : GeneratedElement
	{
		public GeneratedAttribute()
		{
			Name = "Value";
			Namespace = "";
		}
		public string ValueType { get; set; } = "object";
	}
}
