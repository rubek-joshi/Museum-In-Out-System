namespace MuseumInformationSystem
{
    partial class WeeklyReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.orderSelector = new System.Windows.Forms.ComboBox();
            this.dgvWeeklyReport = new System.Windows.Forms.DataGridView();
            this.Weekday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalVisitors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chartWeekly = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeeklyReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartWeekly)).BeginInit();
            this.SuspendLayout();
            // 
            // orderSelector
            // 
            this.orderSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orderSelector.FormattingEnabled = true;
            this.orderSelector.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.orderSelector.Location = new System.Drawing.Point(379, 21);
            this.orderSelector.Name = "orderSelector";
            this.orderSelector.Size = new System.Drawing.Size(121, 21);
            this.orderSelector.TabIndex = 1;
            this.orderSelector.SelectedIndexChanged += new System.EventHandler(this.orderSelector_SelectedIndexChanged);
            // 
            // dgvWeeklyReport
            // 
            this.dgvWeeklyReport.AllowUserToAddRows = false;
            this.dgvWeeklyReport.AllowUserToDeleteRows = false;
            this.dgvWeeklyReport.AllowUserToResizeRows = false;
            this.dgvWeeklyReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWeeklyReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWeeklyReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Weekday,
            this.TotalVisitors});
            this.dgvWeeklyReport.Location = new System.Drawing.Point(315, 54);
            this.dgvWeeklyReport.MultiSelect = false;
            this.dgvWeeklyReport.Name = "dgvWeeklyReport";
            this.dgvWeeklyReport.ReadOnly = true;
            this.dgvWeeklyReport.RowHeadersVisible = false;
            this.dgvWeeklyReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWeeklyReport.Size = new System.Drawing.Size(345, 162);
            this.dgvWeeklyReport.TabIndex = 2;
            // 
            // Weekday
            // 
            this.Weekday.HeaderText = "Weekday";
            this.Weekday.Name = "Weekday";
            this.Weekday.ReadOnly = true;
            // 
            // TotalVisitors
            // 
            this.TotalVisitors.HeaderText = "Total No. of Visitors";
            this.TotalVisitors.Name = "TotalVisitors";
            this.TotalVisitors.ReadOnly = true;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(18, 54);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.SelectionRange = new System.Windows.Forms.SelectionRange(new System.DateTime(2019, 1, 28, 0, 0, 0, 0), new System.DateTime(2019, 2, 1, 0, 0, 0, 0));
            this.monthCalendar.ShowWeekNumbers = true;
            this.monthCalendar.TabIndex = 4;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            this.monthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateSelected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select a Week:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sort By:";
            // 
            // chartWeekly
            // 
            chartArea1.AxisX.LabelStyle.Format = "0.00";
            chartArea1.Name = "ChartArea1";
            this.chartWeekly.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartWeekly.Legends.Add(legend1);
            this.chartWeekly.Location = new System.Drawing.Point(18, 228);
            this.chartWeekly.Name = "chartWeekly";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "WeekDays";
            this.chartWeekly.Series.Add(series1);
            this.chartWeekly.Size = new System.Drawing.Size(642, 300);
            this.chartWeekly.TabIndex = 7;
            this.chartWeekly.Text = "WeeklyChart";
            title1.Name = "Title1";
            title1.Text = "Weekly Chart";
            this.chartWeekly.Titles.Add(title1);
            // 
            // WeeklyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 565);
            this.Controls.Add(this.chartWeekly);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.dgvWeeklyReport);
            this.Controls.Add(this.orderSelector);
            this.Name = "WeeklyReport";
            this.Text = "WeeklyReport";
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeeklyReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartWeekly)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox orderSelector;
        private System.Windows.Forms.DataGridView dgvWeeklyReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weekday;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalVisitors;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartWeekly;
    }
}