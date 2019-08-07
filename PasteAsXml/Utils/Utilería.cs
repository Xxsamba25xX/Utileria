using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace PasteAsXml.Utils
{
	public class XmlSerializer
	{
		private XmlSerializerNamespaces _xmlSerializerNamespaces = new XmlSerializerNamespaces();

		// <summary>
		/// XML serializer namespaces to be used when serializing <see cref="SoapEnvelope"/>
		/// </summary>
		/// <exception cref="ArgumentNullException"></exception>
		public XmlSerializerNamespaces XmlSerializerNamespaces
		{
			get { return _xmlSerializerNamespaces; }
			set
			{
				if (value == null) throw new ArgumentNullException(nameof(value));
				_xmlSerializerNamespaces = value;
			}
		}

		public string SerializeObject<T>(T value) where T : class
		{
			var xmlWriterSettings = new XmlWriterSettings()
			{
				OmitXmlDeclaration = true,
				Indent = false,
				IndentChars = "\t",
				NamespaceHandling = NamespaceHandling.Default,
				NewLineChars = Environment.NewLine,
				NewLineHandling = NewLineHandling.Replace,

			};

			if (value == null) return null;

			using (var textWriter = new StringWriter())
			using (var xmlWriter = XmlWriter.Create(textWriter, xmlWriterSettings))
			{
				new System.Xml.Serialization.XmlSerializer(typeof(T)).Serialize(xmlWriter, value, _xmlSerializerNamespaces);
				return textWriter.ToString();
			}

		}

		public T DeserializeObject<T>(string buffer) where T : class
		{
			if (string.IsNullOrEmpty(buffer))
			{
				return default(T);
			}

			System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
			var settings = new XmlReaderSettings
			{
				DtdProcessing = DtdProcessing.Ignore,
				ValidationType = ValidationType.None,
				IgnoreWhitespace = true,
				IgnoreProcessingInstructions = true,
				IgnoreComments = true,
			};

			using (StringReader textReader = new StringReader(buffer))
			{
				using (XmlReader xmlReader = XmlReader.Create(textReader, settings))
				{
					return (T)serializer.Deserialize(xmlReader);
				}
			}
		}
	}
}
