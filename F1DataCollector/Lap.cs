﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1DataCollector
{
	internal class Lap
	{
		public int meeting_key { get; set; }
		public int session_key { get; set; }
		public int driver_number { get; set; }
		public int? i1_speed { get; set; }
		public int? i2_speed { get; set; }
		public int? st_speed { get; set; }
		public DateTime date_start { get; set; }
		public double? lap_duration { get; set; }
		public bool is_pit_out_lap { get; set; }
		public double? duration_sector_1 { get; set; }
		public double? duration_sector_2 { get; set; }
		public double? duration_sector_3 { get; set; }
		public List<int?> segments_sector_1 { get; set; }
		public List<int?> segments_sector_2 { get; set; }
		public List<int?> segments_sector_3 { get; set; }
		public int? lap_number { get; set; }

		public override string ToString()
		{
			return $"{lap_number};{is_pit_out_lap};{date_start};{duration_sector_1};{duration_sector_2};{duration_sector_3};{lap_duration}";
		}
	}
}
