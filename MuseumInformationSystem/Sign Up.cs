using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuseumInformationSystem
{
    public partial class MuseumForm : Form
    {
        public List<Visitor> lstVisitor = new List<Visitor>();

        public MuseumForm()
        {
            InitializeComponent();
            if (!File.Exists(@"Data.csv"))
            {
                File.Create(@"Data.csv");
            }
            ReadFromCsv();
            FillGrid();
        }

        private void BtnIn_Click(object sender, EventArgs e)
        {
            if (IsMuseumClose())
            {
                return;
            }

            Visitor newVisitor = new Visitor();
            
            int cardNumber;
            if(txtCardNumber.Text.Equals("")) {
                Random generateRandom = new Random();
                // check for used numbers
                do
                {
                    cardNumber = generateRandom.Next(1000, 10000);
                } while (lstVisitor.FirstOrDefault<Visitor>(item => item.CardNumber == cardNumber) != null);
            }
            else
            {
                try
                {
                    cardNumber = int.Parse(txtCardNumber.Text);
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                    MessageBox.Show("Invalid Card Number.");
                    btnClear.PerformClick();
                    return;
                }
                
                //check double entry
                if(lstVisitor.FirstOrDefault<Visitor>(item => item.CardNumber == cardNumber && item.ExitTime == default(DateTime)) != null)
                {
                    MessageBox.Show("Visitor cannot enter again without exiting.", "Entry failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            newVisitor.CardNumber = cardNumber;

            if (txtFullName.Text == "")
            {
                MessageBox.Show(GrpVisitorDetails, "Please enter full name and try again.", "Full Name missing!");
                return;
            } else
            {
                newVisitor.FullName = txtFullName.Text;
            }
            newVisitor.DateOfBirth = dateOfBirthPicker.Value.ToString("dd/MMM/yyyy");

            string pattern = @"^([\w]+)([\.\-]?)([\w]+)@(\w+)\.([a-z]{2,3})$";
            Match match = Regex.Match(txtEmail.Text, pattern);
            if (match.Success)
            {
                newVisitor.Email = txtEmail.Text;
            } else
            {
                MessageBox.Show(GrpVisitorDetails, "Please enter email and try again.", "Invalid Email!");
                return;
            }
            if(radioBtnMale.Checked)
            {
                newVisitor.Gender = "Male";
            }
            else if (radioBtnFemale.Checked)
            {
                newVisitor.Gender = "Female";
            }
            else if (radioBtnOther.Checked)
            {
                newVisitor.Gender = "Other";
            } else
            {
                MessageBox.Show(GrpVisitorDetails, "Please select you gender and try again.", "Gender missing!");
                return;
            }
            if (occupationSelector.Text == "Select an occupation")
            {
                MessageBox.Show(GrpVisitorDetails, "Please select an occupation.", "Occupation missing!");
                return;
            }
            pattern = @"^(98\d{8})$";
            match = Regex.Match(txtContactNumber.Text, pattern);
            if (match.Success)
            {
                newVisitor.ContactNumber = txtContactNumber.Text;
            }
            else
            {
                MessageBox.Show(GrpVisitorDetails, "Contact number should be in the format: 98XXXXXXXX", "Invalid Contact No.");
                return;
            }
            newVisitor.Occupation = occupationSelector.Text;
            newVisitor.EntryTime = DateTime.Now;
            
            String data = newVisitor.CardNumber + "," + newVisitor.FullName + "," + newVisitor.Email + "," + newVisitor.DateOfBirth + "," + 
                newVisitor.Gender + "," + newVisitor.ContactNumber + "," + newVisitor.Occupation + "," + 
                newVisitor.EntryTime;
            SaveToCSV(data);
            lstVisitor.Add(newVisitor);
            AddToGrid(newVisitor);
            MessageBox.Show("Visitor has been successfully checked in!\nVisitor Card Number: " + newVisitor.CardNumber,"Successfully Checked In!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private Boolean IsMuseumClose()
        {
            //get present day
            DateTime presentDate = DateTime.Now;
            //museum opening time
            TimeSpan start = new TimeSpan(10, 0, 0); //10 AM
            //museum closing time
            TimeSpan end = new TimeSpan(17, 0, 0); //5 PM
            TimeSpan now = presentDate.TimeOfDay;

            if (presentDate.DayOfWeek == DayOfWeek.Saturday || presentDate.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("The museum is closed on weekends.", "Museum Closed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else if (now < start)
            {
                MessageBox.Show("Museum has not opened yet. It will open in 10 AM.", "Museum currently closed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else if (now > end)
            {
                MessageBox.Show("Museum has been closed. Come back another day", "Museum already closed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
            {
                return false;
            }
        }

        private void SaveToCSV(String data)
        {
            String path = @"Data.csv";
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(data);
            }
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
                    lstVisitor.Add(visitor);
                }
            }
        }

        private void AddToGrid(Visitor visitor)
        {
            //Creating new row
            int rowId = dgvVisitors.Rows.Add();
            //Grabbing new row
            DataGridViewRow row = dgvVisitors.Rows[rowId];
            //Populatin row
            row.Cells["CardNumber"].Value = visitor.CardNumber;
            row.Cells["FullName"].Value = visitor.FullName;
            row.Cells["DateOfBirth"].Value = visitor.DateOfBirth;
            row.Cells["Email"].Value = visitor.Email;
            row.Cells["Gender"].Value = visitor.Gender;
            row.Cells["ContactNumber"].Value = visitor.ContactNumber;
            row.Cells["Occupation"].Value = visitor.Occupation;
            row.Cells["EntryTime"].Value = visitor.EntryTime.ToString("hh:mm tt");
            row.Cells["ExitTime"].Value = visitor.ExitTime == default(DateTime) ? "Not exited" : visitor.ExitTime.ToString("hh:mm tt");
            if (visitor.ExitTime != default(DateTime))
            {
                row.Cells["Duration"].Value = CalculateDuration(visitor.EntryTime, visitor.ExitTime);
            }
            
        }

        private void FillGrid()
        {
            foreach (Visitor visitor in lstVisitor)
            {
                if (visitor.EntryTime.Date.ToShortDateString() == datePickerVisitors.Value.Date.ToShortDateString())
                {
                    AddToGrid(visitor);
                }
                //AddToGrid(visitor);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            occupationSelector.SelectedItem = null;
            occupationSelector.Text = "Select an occupation";
            dgvVisitors.ClearSelection();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtCardNumber.Text = "";
            txtFullName.Text = "";
            txtEmail.Text = "";
            txtContactNumber.Text = "";
            foreach (RadioButton radioBtn in genderGroupBox.Controls.OfType<RadioButton>()) {
                radioBtn.Checked = false;
            }
            occupationSelector.SelectedItem = null;
            occupationSelector.Text = "Select an occupation";
            dgvVisitors.ClearSelection();
        }

        private void TxtContactNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                ToolTip msgTip = new ToolTip();
                msgTip.Show("Enter digits only", txtContactNumber, 0, 20, 1000);
            }
        }

        private void TxtCardNumber_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(txtCardNumber.Text, out int cardNumber))
            {
                Visitor foundVisitor = lstVisitor.FirstOrDefault(v => v.CardNumber == cardNumber);
                if(foundVisitor == null)
                {
                    ToolTip tt = new ToolTip();
                    tt.Show("Visitor not found", txtCardNumber, 0, 20, 2000);
                    txtCardNumber.Clear();
                    txtCardNumber.Focus();
                } else
                {
                    txtFullName.Text = foundVisitor.FullName;
                    txtEmail.Text = foundVisitor.Email;
                    dateOfBirthPicker.Value = DateTime.Parse(foundVisitor.DateOfBirth);
                    if (foundVisitor.Gender == "Male")
                    {
                        radioBtnMale.Checked = true;
                    } else if ( foundVisitor.Gender == "Female" )
                    {
                        radioBtnFemale.Checked = true;
                    } else
                    {
                        radioBtnOther.Checked = true;
                    }
                    txtContactNumber.Text = foundVisitor.ContactNumber;
                    occupationSelector.SelectedIndex = occupationSelector.FindStringExact(foundVisitor.Occupation);
                    btnIn.Focus();

                    int rowIndex = -1;
                    DataGridViewRow row = dgvVisitors.Rows.Cast<DataGridViewRow>().Where(r => r.Cells["CardNumber"].Value.ToString().Equals(foundVisitor.CardNumber.ToString())).Last();

                    rowIndex = row.Index;
                    dgvVisitors.Rows[rowIndex].Selected = true;
                }
            }
        }

        private void TxtCardNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                ToolTip msgTip = new ToolTip();
                msgTip.Show("Enter digits only", txtCardNumber, 0, 20, 1000);
            }
        }

        private void BtnOut_Click(object sender, EventArgs e)
        {
            if(dgvVisitors.SelectedRows.Count == 1)
            {
                int cardNumber = int.Parse(dgvVisitors.CurrentRow.Cells["CardNumber"].Value.ToString());
                //txtCardNumber.Text = cardNumber.ToString();
                Visitor leavingVisitor = lstVisitor.FirstOrDefault<Visitor>(v => v.CardNumber == cardNumber && v.ExitTime == default(DateTime));
                if(leavingVisitor != null)
                {
                    leavingVisitor.ExitTime = DateTime.Now;
                    //save changes to csv file
                    UpdateCSV(leavingVisitor);
                    dgvVisitors.Rows.Clear();
                    FillGrid();
                    MessageBox.Show("Visitor has been successfully checked out.", "Successfully Checked Out!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show("No visitor record of entry found to exit", "Record Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("Please select a row in the table", "Selection missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateCSV(Visitor updatedVisitor)
        {
            String path = @"Data.csv";            
            //read old file
            string[] lines = File.ReadAllLines(path);
            //rewrite all
            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int currentLine = 1; currentLine <= lines.Length; ++currentLine)
                {
                    string[] data = lines[currentLine - 1].Split(',');
                    if (data[0] == updatedVisitor.CardNumber.ToString() && data.Length.Equals(8))
                    {
                        //add new exit time data
                        writer.WriteLine(lines[currentLine - 1] + "," + updatedVisitor.ExitTime);
                    }
                    else
                    {
                        writer.WriteLine(lines[currentLine - 1]);
                    }
                }
            }
        }

        private int CalculateDuration(DateTime entryTime, DateTime exitTime)
        {
            return (int)Math.Round(exitTime.Subtract(entryTime).TotalMinutes);
        }

        private void DgvVisitors_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVisitors.Focused)
            {
                string selectedCardNumber = dgvVisitors.CurrentRow.Cells["CardNumber"].Value.ToString();
                txtCardNumber.Text = selectedCardNumber;
                //Firing txtCardNumber_Leave event
                txtCardNumber.Focus();
                btnOut.Focus();
            }
        }

        private void BtnDailyReport_Click(object sender, EventArgs e)
        {
            new DailyReport().Show();
        }

        private void BtnWeeklyReport_Click(object sender, EventArgs e)
        {
            new WeeklyReport().Show();
        }

        private void TxtFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void TxtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void DatePickerVisitors_ValueChanged(object sender, EventArgs e)
        {
            dgvVisitors.Rows.Clear();
            FillGrid();
            dgvVisitors.ClearSelection();
            btnClear.PerformClick();
        }
    }
}
