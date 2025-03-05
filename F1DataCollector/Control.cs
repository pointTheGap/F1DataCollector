using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace F1DataCollector
{
	internal class Control
	{
		public async Task<List<String>> GetYears()
		{
			List<String> years = new List<String>();
			using HttpClient client = new HttpClient();

			try
			{
				string url = "https://api.openf1.org/v1/meetings";
				HttpResponseMessage response = await client.GetAsync(url);
				response.EnsureSuccessStatusCode();
				String responseBody = await response.Content.ReadAsStringAsync();
				List<Meeting> meetings = JsonSerializer.Deserialize<List<Meeting>>(responseBody);

				foreach(Meeting meeting in meetings)
				{
					if(!years.Contains(meeting.year.ToString()))
					{
						years.Add(meeting.year.ToString());
					}
				}
			}
			catch (Exception e)
			{
				System.Diagnostics.Debug.WriteLine($"Request error: {e.Message}");
			}
			return years;
		}

		public async Task<List<Meeting>> GetTracksForYear(String year)
		{
			List<Meeting> meetings = new List<Meeting>();
			using HttpClient client = new HttpClient();

			try
			{
				string url = $"https://api.openf1.org/v1/meetings?year={year}";
				HttpResponseMessage response = await client.GetAsync(url);
				response.EnsureSuccessStatusCode();
				String responseBody = await response.Content.ReadAsStringAsync();
				meetings = JsonSerializer.Deserialize<List<Meeting>>(responseBody);
			}
			catch (Exception e)
			{
				System.Diagnostics.Debug.WriteLine($"Request error: {e.Message}");
			}
			return meetings;
		}

		public async Task<List<Session>> GetSessionsForTrack(Meeting meeting)
		{
			List<Session> sessions = new List<Session>();
			using HttpClient client = new HttpClient();

			try
			{
				string url = $"https://api.openf1.org/v1/sessions?meeting_key={meeting.meeting_key}";
				HttpResponseMessage response = await client.GetAsync(url);
				response.EnsureSuccessStatusCode();
				String responseBody = await response.Content.ReadAsStringAsync();
				sessions = JsonSerializer.Deserialize<List<Session>>(responseBody);
			}
			catch (Exception e)
			{
				System.Diagnostics.Debug.WriteLine($"Request error: {e.Message}");
			}
			return sessions;
		}

		public async Task<List<Driver>> GetDriversForSession(Session session)
		{
			List<Driver> drivers = new List<Driver>();
			using HttpClient client = new HttpClient();

			try
			{
				string url = $"https://api.openf1.org/v1/drivers?session_key={session.session_key}";
				HttpResponseMessage response = await client.GetAsync(url);
				response.EnsureSuccessStatusCode();
				String responseBody = await response.Content.ReadAsStringAsync();
				drivers = JsonSerializer.Deserialize<List<Driver>>(responseBody);
			}
			catch (Exception e)
			{
				System.Diagnostics.Debug.WriteLine($"Request error: {e.Message}");
			}
			return drivers;
		}

		public async Task<List<String>> GetLapsAsCSV(Driver driver, Session session)
		{
			List<String> lines = new List<string> ();
			lines.Add("Lap Number;Out Lap;Start;Sector 1;Sector 2;Sector 3;Lap Time");
			List<Lap> laps = await GetLapsForDriver(driver, session);

			foreach (Lap lap in laps)
			{
				lines.Add(lap.ToString());
			}

			return lines;
		}

		private async Task<List<Lap>> GetLapsForDriver(Driver driver, Session session)
		{
			List<Lap> laps = new List<Lap>();
			using HttpClient client = new HttpClient();

			try
			{
				string url = $"https://api.openf1.org/v1/laps?session_key={session.session_key}&driver_number={driver.driver_number}";
				HttpResponseMessage response = await client.GetAsync(url);
				response.EnsureSuccessStatusCode();
				String responseBody = await response.Content.ReadAsStringAsync();
				laps = JsonSerializer.Deserialize<List<Lap>>(responseBody);
			}
			catch (Exception e)
			{
				System.Diagnostics.Debug.WriteLine($"Request error: {e.Message}");
			}
			return laps;
		}

		public async Task GetQualifyingTimesQ3Brasilia2024()
		{
			using HttpClient client = new HttpClient();

			try
			{
				// Define the API endpoint
				string url = "https://api.openf1.org/v1/laps?session_key=9658&driver_number=1&is_pit_out_lap=false";

				// Send a GET request
				HttpResponseMessage response = await client.GetAsync(url);

				// Ensure the response is successful
				response.EnsureSuccessStatusCode();

				// Read response content
				String responseBody = await response.Content.ReadAsStringAsync();

				// Deserialize JSON into a C# object
				List<Lap> laps = JsonSerializer.Deserialize<List<Lap>>(responseBody);
				
				foreach(Lap lap in laps)
				{
					
				}
			}
			catch (Exception e)
			{
				System.Diagnostics.Debug.WriteLine($"Request error: {e.Message}");
			}
		}
	}
}
