using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UtileriaFramework.FileUtils
{
	public static class FileUtils
	{
		private static string WorkingPath = "FileUtils";
		private static String ResultFolder => Path.Combine(WorkingPath, "Result");
		private static String FileLocation => Path.Combine(WorkingPath, "file.txt");
		private static string ContentPath => Path.Combine(WorkingPath, "Content.txt");

		public static List<string> CreateFiles()
		{
			List<string> filenames = new List<string>();
			foreach (var line in File.ReadAllLines(FileLocation))
			{
				string aux = Path.Combine(ResultFolder, line);
				if (!Directory.Exists(ResultFolder))
					Directory.CreateDirectory(ResultFolder);
				File.Create(aux).Close();
				filenames.Add(aux);
			}
			return filenames;
		}

		public static void SetFileContent(string filename, params string[] parameters)
		{
			string aux = File.ReadAllText(ContentPath);
			for (int i = 0; i < parameters.Length; i++)
			{
				aux = aux.Replace("{{Parameter" + (i + 1) + "}}", parameters[i]);
			}
			File.WriteAllText(filename, aux);
		}
	}
}
