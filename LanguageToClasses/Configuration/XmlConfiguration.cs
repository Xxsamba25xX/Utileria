using LanguageToClasses.Contracts;
using LanguageToClasses.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LanguageToClasses.Configuration
{
	public class XmlConfiguration : IConfiguration
	{
		public List<DataRef> IgnoredAttributeTags { get; set; }
		public List<string> ClassDecorators { get; set; }
		public IntegralTypeEnumerator UsedIntegralTypes { get; set; }
		public FloatingTypeEnumerator UsedFloatingTypes { get; set; }
		public SpecialTypeEnumerator UsedSpecialTypes { get; set; }
		public bool UseFullProperties { get; set; }
	}
}
