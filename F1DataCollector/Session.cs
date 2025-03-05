using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1DataCollector
{
	internal class Session
	{
		public int meeting_key { get; set; }
		public int session_key { get; set; }
		public string session_name { get; set; }
		public string session_type { get; set; }
		public int year { get; set; }

		public override string ToString()
		{
			return session_name;
		}
	}
}
