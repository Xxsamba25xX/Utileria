using System;
using System.Collections.Generic;
using LanguageToClasses.Contracts;
using LanguageToClasses.Models;

namespace LanguageToClasses.Converters
{
	public abstract class AbstractConverter : IConverter
	{
		protected IConfiguration _configuration;

		public AbstractConverter(IConfiguration configuration)
		{
			_configuration = configuration;
		}

		public abstract List<AbstractNode> Convert(string source);
	}
}

