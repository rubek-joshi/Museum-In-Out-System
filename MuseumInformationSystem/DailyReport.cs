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
    public partial class DailyReport : Form
    {
        public List<Visitor> lstVisitors = new List<Visitor>();

        public DailyReport()
        {
            InitializeComponent();
            ReadFromCsv();
            //trigger date picker value changed 
            datePicker.Value = DateTime.Now.AddDays(-1);
            datePicker.Value = DateTime.Now;
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

        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {
            dgvDailyReport.Rows.Clear();
            String selectedDate = datePicker.Value.ToShortDateString();            

            //data.GroupBy(x => x.CardNumber).SelectMany(y => y.Sum());

            foreach (Visitor visitor in lstVisitors)
            {
                if(visitor.EntryTime.ToShortDateString() == selectedDate && visitor.ExitTime != default(DateTime))
                {
                    //Creating new row
                    int rowId = dgvDailyReport.Rows.Add();
                    //Grabbing new row
                    DataGridViewRow row = dgvDailyReport.Rows[rowId];
                    //Populating row
                    row.Cells["VisitorNumber"].Value = visitor.CardNumber;
                    row.Cells["Duration"].Value = (int)Math.Round(visitor.ExitTime.Subtract(visitor.EntryTime).TotalMinutes);
                    row.Cells["InTime"].Value = visitor.EntryTime.TimeOfDay;
                    row.Cells["OutTime"].Value = visitor.ExitTime.TimeOfDay;
                }
            }
            //display no data message
            lblNoVisitorsMsg.Visible = (dgvDailyReport.RowCount < 1) ? true : false;

            var data = lstVisitors.Where(x => x.EntryTime.Date == datePicker.Value.Date && x.ExitTime != default(DateTime)).Select(i => i.CardNumber);
            lblTotalVisitors.Text = data.Distinct().Count().ToString();

            int totalDuration = 0;
            foreach (DataGridViewRow row in dgvDailyReport.Rows)
            {
                totalDuration += int.Parse(row.Cells["Duration"].Value.ToString());
            }
            lblTotalDuration.Text = totalDuration.ToString() + " minutes";
            
            ClearVisitorInfo();

            dgvDailyReport.ClearSelection();
        }

        private void ClearVisitorInfo()
        {
            lblFullName.Text = "";
            lblDateOfBirth.Text = "";
            lblEmail.Text = "";
            lblGender.Text = "";
            lblContactNumber.Text = "";
            lblOccupation.Text = "";
        }

        private void DgvDailyReport_SelectionChanged(object sender, EventArgs e)
        {
            if (!lblNoVisitorsMsg.Visible && dgvDailyReport.Focused)
            {
                string selectedCardNumber = dgvDailyReport.CurrentRow.Cells["VisitorNumber"].Value.ToString();
                Visitor foundVisitor = lstVisitors.FirstOrDefault<Visitor>(item => item.CardNumber.Equals(int.Parse(selectedCardNumber)));
                lblFullName.Text = foundVisitor.FullName;
                lblDateOfBirth.Text = foundVisitor.DateOfBirth;
                lblEmail.Text = foundVisitor.Email;
                lblGender.Text = foundVisitor.Gender;
                lblContactNumber.Text = foundVisitor.ContactNumber;
                lblOccupation.Text = foundVisitor.Occupation;
                lblVisitorInfoHelp.Visible = false;
            } else
            {
                lblVisitorInfoHelp.Visible = true;
            }
        }
    }
}
