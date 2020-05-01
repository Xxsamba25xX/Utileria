using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using UtileriaFramework.Extensions;
using System.Globalization;
using System.Xml;
using Newtonsoft.Json;
using LanguageToObjectLibrary.Parser;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Xml.Linq;
using UtileriaFramework.Serialization.Serializers;
using UtileriaFramework.Serialization.Xml;
using UtileriaFramework.Serialization.Json;

namespace UtileriaFramework
{

	internal class Program
	{

		private static void Main(string[] args)
		{
			XmlSerializationUtil.TestSerialize();
			//JsonSerializationUtil.TestSerialize();
		}

	}
}















