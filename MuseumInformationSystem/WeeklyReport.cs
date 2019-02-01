using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuseumInformationSystem
{
    public partial class WeeklyReport : Form
    {
        public List<Visitor> lstVisitors = new List<Visitor>();
        private string[] weekdays;
        private WeekdayTotal[] weekdaysTotal = new WeekdayTotal[5];

        public WeeklyReport()
        {
            InitializeComponent();
            ReadFromCsv();

            //get all days of week
            weekdays = Enum.GetNames(typeof(DayOfWeek));
            //remove weekend
            weekdays = weekdays.Where(value => value != "Saturday" && value != "Sunday").ToArray();

            for(int i = 0; i < 5; i++)
            {
                weekdaysTotal[i] = new WeekdayTotal();
            }

            orderSelector.SelectedIndex = 0;
            //trigger weekpicker_value changed
        }
        
        private void ReadFromCsv()
        {
            String path = @"Data.csv";
            using (StreamReader reader = new StreamReader(path))
            {
                //read until end of line reached
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] data = line.Split(',');
                    Visitor visitor = new Visitor(data);
                    lstVisitors.Add(visitor);
                }
            }
        }

        private int CalculateTotal(DateTime day)
        {
            int visitorCount = 0;
            foreach (Visitor visitor in lstVisitors)
            {
                if (visitor.EntryTime.Date.Equals(day.Date))
                {
                    visitorCount++;
                }
            }
            return visitorCount;
        }

        private int CalculateDuration(DateTime day)
        {
            int duration = 0;
            foreach (Visitor visitor in lstVisitors)
            {
                if (visitor.EntryTime.Date.Equals(day.Date) && visitor.ExitTime != default(DateTime))
                {
                    duration += (int)Math.Round(visitor.ExitTime.Subtract(visitor.EntryTime).TotalMinutes);
                }
            }
            return duration;
        }

        private void MonthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime date = monthCalendar.SelectionStart;
            int i = (int)date.DayOfWeek;
            monthCalendar.SelectionStart = date.AddDays(1 - i);
            monthCalendar.SelectionEnd = date.AddDays(5 - i);
        }

        private void PrepareReport()
        {
            dgvWeeklyReport.Rows.Clear();

            DateTime monday = monthCalendar.SelectionRange.Start;

            int i = 0;
            foreach (string day in weekdays)
            {
                //Add to array
                weekdaysTotal[i].Weekday = day;
                weekdaysTotal[i].TotalVisitors = CalculateTotal(monday.AddDays(i));
                weekdaysTotal[i].TotalDuration = CalculateDuration(monday.AddDays(i));
                i++;
            }

            RenderChart(weekdaysTotal);

            if (orderSelector.Text == "Ascending") {
                BubbleSortAscending(weekdaysTotal);
            } else {
                BubbleSortDescending(weekdaysTotal);
            } 

            foreach (WeekdayTotal wt in weekdaysTotal)
            {
                //Creating new row
                int rowId = dgvWeeklyReport.Rows.Add();
                //Grabbing new row
                DataGridViewRow row = dgvWeeklyReport.Rows[rowId];
                //Populatin row
                row.Cells["Weekday"].Value = wt.Weekday;
                row.Cells["TotalVisitors"].Value = wt.TotalVisitors;
                i++;
            }
        }

        private void MonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            PrepareReport();
        }

        private void OrderSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrepareReport();
        }

        private void RenderChart(WeekdayTotal[] w)
        {
            chartWeekly.Series["WeekDays"].Points.Clear();
            for(int i = 0; i < 5; i++)
            {
                chartWeekly.Series["WeekDays"].Points.AddXY(w[i].Weekday, w[i].TotalDuration);
            }
        }

        private void BubbleSortAscending(WeekdayTotal[] arr)
        {
            for (int i = arr.Length - 1; i > 0; i--)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    if (arr[j].TotalVisitors > arr[j + 1].TotalVisitors)

                    {
                        WeekdayTotal big = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = big;
                    }
                }
            }
        }

        private void BubbleSortDescending(WeekdayTotal[] arr)
        {
            for (int i = arr.Length - 1; i > 0; i--)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    if (arr[j].TotalVisitors < arr[j + 1].TotalVisitors)

                    {
                        WeekdayTotal big = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = big;
                    }
                }
            }
        }
    }
}
