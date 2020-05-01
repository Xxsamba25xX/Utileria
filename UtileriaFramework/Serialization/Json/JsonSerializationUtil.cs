using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtileriaFramework.Serialization.Json
{
	public static class JsonSerializationUtil
	{
		private static string serializableFile = Path.Combine(Directory.GetCurrentDirectory(), "Serialization", "Json", "serializable.json");
		private static string deserializableFile = Path.Combine(Directory.GetCurrentDirectory(), "Serialization", "Json", "deserializable.json");

		public static void TestSerialize()
		{
			var obj = new Serializable();
			File.WriteAllText(serializableFile, JsonConvert.SerializeObject(obj));
		}

		public static void TestDeserialize()
		{
			var str = File.ReadAllText(deserializableFile);
			var obj = JsonConvert.DeserializeObject<Deserializable>(str);
		}
	}
}
