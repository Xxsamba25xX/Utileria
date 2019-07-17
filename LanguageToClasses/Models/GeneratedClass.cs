using System;
using System.Collections.Generic;
using System.Text;

namespace LanguageToClasses.Models
{
	public class GeneratedClass
	{
		public Dictionary<string, GeneratedProperty> properties { get; set; }
		public Dictionary<string, GeneratedProperty> attributes { get; set; }

		public string Name { get; set; }
		public string Namespace { get; set; }
		public bool isArray { get; set; }
	}

	public class GeneratedProperty
	{
		public string Name { get; set; } = "Value";
		public string NameSpace { get; set; } = "";
		public string ValueType { get; set; } = "object";
		public bool isArray { get; set; } = false;
	}
}
