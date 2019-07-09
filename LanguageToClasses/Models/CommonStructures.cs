using System;
using System.Collections.Generic;
using System.Text;

namespace LanguageToClasses.Models
{
	public class DataRef : IEquatable<DataRef>
	{
		public DataRef()
		{

		}

		public DataRef(string key, string value)
		{
			Key = key;
			Value = value;
		}

		public string Key { get; set; }
		public string Value { get; set; }

		public bool Equals(DataRef other)
		{
			return Key == other.Key
				&& Value == other.Value;
		}

		public static bool operator ==(DataRef obj1, object obj2)
		{
			if (obj2 is DataRef)
				return obj1.Key == (obj2 as DataRef).Key
					&& obj1.Value == (obj2 as DataRef).Value;
			else
				return obj1.GetHashCode() == obj2.GetHashCode();
		}

		public static bool operator !=(DataRef obj1, object obj2)
		{
			return !(obj1 == obj2);
		}
	}
}
