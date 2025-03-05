
namespace F1DataCollector
{
	public partial class View : Form
	{
		private Control Control;
		public View()
		{
			InitializeComponent();
			Control = new Control();
		}

		private async void View_ShownAsync(object sender, EventArgs e)
		{
			foreach (String year in await Control.GetYears())
			{
				comboBoxYear.Items.Add(year);
			}
		}

		private async void comboBoxYear_SelectedIndexChanged(object sender, EventArgs e)
		{
			comboBoxTrack.SelectedIndex = -1;
			comboBoxTrack.Items.Clear();

			if (comboBoxYear.SelectedIndex != -1)
			{
				foreach (Meeting meeting in await Control.GetTracksForYear(comboBoxYear.SelectedItem.ToString()))
				{
					comboBoxTrack.Items.Add(meeting);
				}
			}
		}

		private async void comboBoxTrack_SelectedIndexChanged(object sender, EventArgs e)
		{
			comboBoxSession.SelectedIndex = -1;
			comboBoxSession.Items.Clear();

			if (comboBoxTrack.SelectedIndex != -1)
			{
				foreach (Session session in await Control.GetSessionsForTrack(comboBoxTrack.SelectedItem as Meeting))
				{
					comboBoxSession.Items.Add(session);
				}
			}
		}

		private async void comboBoxSession_SelectedIndexChanged(object sender, EventArgs e)
		{
			comboBoxDriver.SelectedIndex = -1;
			comboBoxDriver.Items.Clear();

			if (comboBoxSession.SelectedIndex != -1)
			{
				foreach (Driver driver in await Control.GetDriversForSession(comboBoxSession.SelectedItem as Session))
				{
					comboBoxDriver.Items.Add(driver);
				}
			}
		}

		private void comboBoxDriver_SelectedIndexChanged(object sender, EventArgs e)
		{
			buttonExportLapsAsCSV.Enabled = comboBoxDriver.SelectedIndex != -1;
		}

		private async void buttonExportLapsAsCSV_Click(object sender, EventArgs e)
		{
			using (SaveFileDialog saveFileDialog = new SaveFileDialog())
			{
				saveFileDialog.Title = "Save As";
				saveFileDialog.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
				saveFileDialog.DefaultExt = "csv";
				saveFileDialog.AddExtension = true;

				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					string filePath = saveFileDialog.FileName;
					List<String> lines = await Control.GetLapsAsCSV(comboBoxDriver.SelectedItem as Driver, comboBoxSession.SelectedItem as Session);
					File.WriteAllLines(filePath, lines);
				}
			}
		}
	}
}
