namespace F1DataCollector
{
	partial class View
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			comboBoxYear = new ComboBox();
			labelYear = new Label();
			labelTrack = new Label();
			comboBoxTrack = new ComboBox();
			labelSession = new Label();
			comboBoxSession = new ComboBox();
			comboBoxDriver = new ComboBox();
			labelDriver = new Label();
			buttonExportLapsAsCSV = new Button();
			SuspendLayout();
			// 
			// comboBoxYear
			// 
			comboBoxYear.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			comboBoxYear.FormattingEnabled = true;
			comboBoxYear.Location = new Point(160, 11);
			comboBoxYear.Margin = new Padding(3, 4, 3, 4);
			comboBoxYear.Name = "comboBoxYear";
			comboBoxYear.Size = new Size(240, 27);
			comboBoxYear.TabIndex = 1;
			comboBoxYear.SelectedIndexChanged += comboBoxYear_SelectedIndexChanged;
			// 
			// labelYear
			// 
			labelYear.AutoSize = true;
			labelYear.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			labelYear.Location = new Point(16, 11);
			labelYear.Name = "labelYear";
			labelYear.Size = new Size(37, 19);
			labelYear.TabIndex = 2;
			labelYear.Text = "Year";
			// 
			// labelTrack
			// 
			labelTrack.AutoSize = true;
			labelTrack.Font = new Font("Calibri", 12F);
			labelTrack.Location = new Point(16, 47);
			labelTrack.Name = "labelTrack";
			labelTrack.Size = new Size(43, 19);
			labelTrack.TabIndex = 3;
			labelTrack.Text = "Track";
			// 
			// comboBoxTrack
			// 
			comboBoxTrack.DropDownWidth = 240;
			comboBoxTrack.Font = new Font("Calibri", 12F);
			comboBoxTrack.FormattingEnabled = true;
			comboBoxTrack.Location = new Point(160, 47);
			comboBoxTrack.Margin = new Padding(3, 4, 3, 4);
			comboBoxTrack.Name = "comboBoxTrack";
			comboBoxTrack.Size = new Size(240, 27);
			comboBoxTrack.TabIndex = 4;
			comboBoxTrack.SelectedIndexChanged += comboBoxTrack_SelectedIndexChanged;
			// 
			// labelSession
			// 
			labelSession.AutoSize = true;
			labelSession.Font = new Font("Calibri", 12F);
			labelSession.Location = new Point(16, 81);
			labelSession.Name = "labelSession";
			labelSession.Size = new Size(58, 19);
			labelSession.TabIndex = 5;
			labelSession.Text = "Session";
			// 
			// comboBoxSession
			// 
			comboBoxSession.Font = new Font("Calibri", 12F);
			comboBoxSession.FormattingEnabled = true;
			comboBoxSession.Location = new Point(160, 81);
			comboBoxSession.Margin = new Padding(3, 4, 3, 4);
			comboBoxSession.Name = "comboBoxSession";
			comboBoxSession.Size = new Size(240, 27);
			comboBoxSession.TabIndex = 6;
			comboBoxSession.SelectedIndexChanged += comboBoxSession_SelectedIndexChanged;
			// 
			// comboBoxDriver
			// 
			comboBoxDriver.Font = new Font("Calibri", 12F);
			comboBoxDriver.FormattingEnabled = true;
			comboBoxDriver.Location = new Point(160, 116);
			comboBoxDriver.Margin = new Padding(3, 4, 3, 4);
			comboBoxDriver.Name = "comboBoxDriver";
			comboBoxDriver.Size = new Size(240, 27);
			comboBoxDriver.TabIndex = 8;
			comboBoxDriver.SelectedIndexChanged += comboBoxDriver_SelectedIndexChanged;
			// 
			// labelDriver
			// 
			labelDriver.AutoSize = true;
			labelDriver.Font = new Font("Calibri", 12F);
			labelDriver.Location = new Point(16, 116);
			labelDriver.Name = "labelDriver";
			labelDriver.Size = new Size(48, 19);
			labelDriver.TabIndex = 7;
			labelDriver.Text = "Driver";
			// 
			// buttonExportLapsAsCSV
			// 
			buttonExportLapsAsCSV.Enabled = false;
			buttonExportLapsAsCSV.Location = new Point(160, 150);
			buttonExportLapsAsCSV.Name = "buttonExportLapsAsCSV";
			buttonExportLapsAsCSV.Size = new Size(240, 27);
			buttonExportLapsAsCSV.TabIndex = 9;
			buttonExportLapsAsCSV.Text = "Export Laps as csv file";
			buttonExportLapsAsCSV.UseVisualStyleBackColor = true;
			buttonExportLapsAsCSV.Click += buttonExportLapsAsCSV_Click;
			// 
			// View
			// 
			AutoScaleDimensions = new SizeF(8F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(425, 357);
			Controls.Add(buttonExportLapsAsCSV);
			Controls.Add(comboBoxDriver);
			Controls.Add(labelDriver);
			Controls.Add(comboBoxSession);
			Controls.Add(labelSession);
			Controls.Add(comboBoxTrack);
			Controls.Add(labelTrack);
			Controls.Add(labelYear);
			Controls.Add(comboBoxYear);
			Font = new Font("Calibri", 12F);
			Margin = new Padding(3, 4, 3, 4);
			Name = "View";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "F1 Data Collector";
			Shown += View_ShownAsync;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private ComboBox comboBoxYear;
		private Label labelYear;
		private Label labelTrack;
		private ComboBox comboBoxTrack;
		private Label labelSession;
		private ComboBox comboBoxSession;
		private ComboBox comboBoxDriver;
		private Label labelDriver;
		private Button buttonExportLapsAsCSV;
	}
}
