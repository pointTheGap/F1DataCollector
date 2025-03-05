using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1DataCollector
{
	internal class Meeting
	{
		public int meeting_key { get; set; }
		public string meeting_name { get; set; }
		public int year { get; set; }

		public override string ToString()
		{
			return meeting_name;
		}
	}
}
