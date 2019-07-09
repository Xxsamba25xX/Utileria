using LanguageToClasses.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LanguageToClasses.Contracts
{
	public interface IConverter
	{
		List<AbstractNode> Convert(string source);
	}
}
