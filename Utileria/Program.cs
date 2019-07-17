using Newtonsoft.Json;
using Serializers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using Utileria.Contracts;
using Utileria.Extensions;
using LanguageToClasses.Converters;
using LanguageToClasses.Configuration;
using LanguageToClasses.Models;
using System.Globalization;
using Utileria.ObjectUtils;
using Utileria.Utils;
using PCRE;
using System.Xml;
using LanguageToClasses.Parser;

namespace Utileria
{


	// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://es.wikipedia.org/wiki/Espacio_de_nombres_XML/cliente")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://es.wikipedia.org/wiki/Espacio_de_nombres_XML/cliente", IsNullable = false)]
	public partial class cliente
	{

		private clienteNumero_ID numero_IDField;

		private string nombreField;

		private uint telefonoField;

		private pedido pedidoField;

		/// <remarks/>
		public clienteNumero_ID numero_ID
		{
			get
			{
				return this.numero_IDField;
			}
			set
			{
				this.numero_IDField = value;
			}
		}

		/// <remarks/>
		public string nombre
		{
			get
			{
				return this.nombreField;
			}
			set
			{
				this.nombreField = value;
			}
		}

		/// <remarks/>
		public uint telefono
		{
			get
			{
				return this.telefonoField;
			}
			set
			{
				this.telefonoField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Namespace = "http://es.wikipedia.org/wiki/Espacio_de_nombres_XML/pedido")]
		public pedido pedido
		{
			get
			{
				return this.pedidoField;
			}
			set
			{
				this.pedidoField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://es.wikipedia.org/wiki/Espacio_de_nombres_XML/cliente")]
	public partial class clienteNumero_ID
	{

		private string tubiField;

		private uint valueField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://es.wikipedia.org/wiki/Espacio_de_nombres_XML/pedido")]
		public string tubi
		{
			get
			{
				return this.tubiField;
			}
			set
			{
				this.tubiField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlTextAttribute()]
		public uint Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://es.wikipedia.org/wiki/Espacio_de_nombres_XML/pedido")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://es.wikipedia.org/wiki/Espacio_de_nombres_XML/pedido", IsNullable = false)]
	public partial class pedido
	{

		private uint numero_IDField;

		private string articuloField;

		private string precioField;

		/// <remarks/>
		public uint numero_ID
		{
			get
			{
				return this.numero_IDField;
			}
			set
			{
				this.numero_IDField = value;
			}
		}

		/// <remarks/>
		public string articulo
		{
			get
			{
				return this.articuloField;
			}
			set
			{
				this.articuloField = value;
			}
		}

		/// <remarks/>
		public string precio
		{
			get
			{
				return this.precioField;
			}
			set
			{
				this.precioField = value;
			}
		}
	}


	internal class Program
	{
		private static void Main(string[] args)
		{


			PcreRegex document = new PcreRegex(LanguageToClasses.Models.Utils.Element, PcreOptions.IgnoreCase);

			var file = File.ReadAllText("file");

			XmlParser parser = new XmlParser(new XmlConfiguration());
			parser.GetClasses(file);

			var aux = document.Matches(file).ToList();

			foreach (var match in aux)
			{
				foreach (var item in match.Groups)
				{
					Console.WriteLine(match.Groups["Content"]);
				}
			}

			Console.WriteLine(MatrixGenerator.Generate(5, 5, CharType.Letters, false));

			TestDeserialize();
			//Console.WriteLine(GetException(new Exception("easdaea", new Exception("qqq"))));
			string prueba = "asdasda<si";

			Regex regex = new Regex(@"^(([^<""'])*?)((?<quoted>([""][^""]*?[""])|(['][^']*?[']))(([^<""'])*?))*?<", RegexOptions.Multiline);

			var matches = regex.Matches(prueba);

			TestMail();
		}

		#region charGenerator

		#endregion


		private static void TestMail()
		{
			//Envia mails usando el smtp de google
			SmtpClient mailClient = new SmtpClient();
			mailClient.EnableSsl = true;
			mailClient.UseDefaultCredentials = false;
			mailClient.Port = 587;
			mailClient.Host = "smtp.gmail.com";
			mailClient.DeliveryMethod = SmtpDeliveryMethod.Network;
			mailClient.Credentials = new NetworkCredential("samba25leo@gmail.com", "samba025");
			MailMessage message = new MailMessage();
			message.IsBodyHtml = true;
			message.From = new MailAddress("samba25leo@gmail.com");
			message.To.Add("leonardo.ramallo@juantoselli.com");
			message.Subject = "Boludeando con el cliente de mail";
			message.Body = "Hola bestia, como estas?<img src=\"C:\\Users\\Lautaro\\Pictures\\saldaa.jpg\">";
			mailClient.Send(message);
		}

		private static void TestDeserialize()
		{
			var file = File.ReadAllText("file");
			var serializator = new XmlSerializer();
			var deserialized = serializator.DeserializeObject<GetHotelInfoResponse>(file);
			Console.WriteLine("Se deserializó");
		}

		private static string GenerateString(string seed, string capsuleIni = "{", string capsuleEnd = "}", string separator = ",")
		{
			return Regex.Replace(seed, @"(?<before>[^\\])([" + capsuleIni + @"])((?<min>\d+?)[" + separator + @"]?(?<max>\d+?)?)([" + capsuleEnd + @"])", match =>
			 {
				 var min = 0;
				 var max = 0;

				 if (!Int32.TryParse(match.Groups["min"]?.Value, out min))
					 min = 0;
				 if (!Int32.TryParse(match.Groups["max"]?.Value, out max))
					 max = min;

				 Random r = new Random();

				 var characters = new char[r.Next(min, max)];

				 for (int i = 0; i < characters.Length; i++)
				 {
					 do
					 {
						 characters[i] = Convert.ToChar(r.Next(0, 256));
					 } while (!IsLetterOrDigitReworked(characters[i]));
				 }

				 var cadenaGenerada = new string(characters.Select(x => Convert.ToChar(x)).ToArray());

				 return $"{match.Groups["before"].Value}{cadenaGenerada}";

			 }, RegexOptions.IgnoreCase);
		}

		private static bool IsLetterOrDigitReworked(char character)
		{
			var numeric = (int)character;
			if (numeric >= 48 && numeric <= 57) return true;//Numbers
			if (numeric >= 65 && numeric <= 90) return true;//Upper
			if (numeric >= 97 && numeric <= 122) return true;//Lower
			return false;
		}

		public static string GetException(Exception ex)
		{
			StringBuilder sb = new StringBuilder();


			return "";
		}

		public static void aux<Tasda>()
			 where Tasda : IEnumerable<object>
		{

		}

		public static void ChangeDirectorySubFileNames(string directoryPath, string from, string to, string extension = ".cs")
		{
			foreach (var file in Directory.EnumerateFiles(directoryPath, $"*{extension}", SearchOption.AllDirectories))
			{
				FileInfo fi = new FileInfo(file);
				var newName = fi.Name.Substring(0, fi.Name.Length - fi.Extension.Length);
				newName = newName.Replace(from, to);
				var newFilename = fi.DirectoryName + Path.DirectorySeparatorChar + newName + fi.Extension;
				File.Move(file, newFilename);
			}
		}
	}

	public class AddTransferServiceRequest
	{
		public string BasketId { get; set; }
		public string WebSiteId { get; set; }
		public string AvailUrl { get; set; }
		public string[] SelectedServices { get; set; }
		public KeyValuePair<string, string> algo { get; set; }
	}

	public class Dataref
	{
		public string Key { get; set; }
		public string Value { get; set; }
		public Dataref(string key, string value)
		{
			Key = key;
			Value = value;
		}
	}
}

