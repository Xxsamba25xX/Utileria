using LanguageToObjectLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LanguageToObjectLibrary.Contracts
{
	public interface IConverter
	{
		List<AbstractNode> Convert(string source);
	}
}
