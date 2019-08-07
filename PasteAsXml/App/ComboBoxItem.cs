using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasteAsXml.App
{
	public static class ComboBoxItem
	{
		public static ComboBoxItem<TKey, TValue> Create<TKey, TValue>(TKey key, TValue value)
		{
			return new ComboBoxItem<TKey, TValue>(key, value);
		}
	}

	public class ComboBoxItem<TKey, TValue>
	{
		public TKey Key { get; set; }
		public TValue Value { get; set; }

		public ComboBoxItem(TKey key, TValue value)
		{
			Key = key;
			Value = value;
		}

		public override string ToString()
		{
			return Value.ToString();
		}
	}
}
