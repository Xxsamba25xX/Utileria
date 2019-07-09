using System;
using System.Collections.Generic;
using System.Text;

namespace LanguageToClasses.Models
{
	public class XmlNode : AbstractNode
	{
		public string Namespace { get; set; } = "";
		public List<XmlAttribute> Attributes { get; set; } = new List<XmlAttribute>();
	}

	public class XmlAttribute
	{
		public string Name { get; set; } = "";
		public string Namespace { get; set; } = "";
		public string ValueType { get; set; } = "";
	}
}
