using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtileriaFramework.Contracts.Json
{

	public class Rootobject
	{
		public Postpaid postpaid { get; set; }
	}

	public class Postpaid
	{
		public string source_currency { get; set; }
		public int source_total { get; set; }
		public string display_currency { get; set; }
		public int display_total { get; set; }
		public Breakdown[] breakdown { get; set; }
	}

	public class Breakdown
	{
		public string type { get; set; }
		public int is_prepaid { get; set; }
		public string description { get; set; }
		public string source_currency { get; set; }
		public int source_total { get; set; }
		public string display_currency { get; set; }
		public int display_total { get; set; }
	}

}


