using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasteAsXml.Utils
{
	public static class EnvironmentVariables
	{
		public static string NameFilterFormat = @"^(\/)?(?<inside>.*?)(\/|(?<ignoreCase>\/i))?$";
	}
}
