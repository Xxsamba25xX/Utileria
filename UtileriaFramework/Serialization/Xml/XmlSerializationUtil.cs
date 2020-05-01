using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtileriaFramework.Serialization.Serializers;

namespace UtileriaFramework.Serialization.Xml
{
	public static class XmlSerializationUtil
	{
		private static XmlSerializer xml = new XmlSerializer();
		private static string serializableFile = Path.Combine(Directory.GetCurrentDirectory(), "Serialization", "Xml", "serializable.xml");
		private static string deserializableFile = Path.Combine(Directory.GetCurrentDirectory(), "Serialization", "Xml", "deserializable.xml");

		public static void TestSerialize()
		{
			var obj = new Serializable();
			File.WriteAllText(serializableFile, xml.SerializeObject(obj));
		}

		public static void TestDeserialize()
		{
			var str = File.ReadAllText(deserializableFile);
			var obj = xml.DeserializeObject<Deserializable>(str);
		}
	}
}
