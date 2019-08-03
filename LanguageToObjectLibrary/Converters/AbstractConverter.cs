using System;
using System.Collections.Generic;
using LanguageToObjectLibrary.Contracts;
using LanguageToObjectLibrary.Models;
using LanguageToObjectLibrary.Parser.Configuration;

namespace LanguageToObjectLibrary.Converters
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

