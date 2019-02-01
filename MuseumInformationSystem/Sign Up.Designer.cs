namespace MuseumInformationSystem
{
    partial class MuseumForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MuseumForm));
            this.label7 = new System.Windows.Forms.Label();
            this.dgvVisitors = new System.Windows.Forms.DataGridView();
            this.CardNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Occupation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntryTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExitTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDailyReport = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnWeeklyReport = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GrpVisitorDetails = new System.Windows.Forms.GroupBox();
            this.btnOut = new System.Windows.Forms.Button();
            this.dateOfBirthPicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.genderGroupBox = new System.Windows.Forms.GroupBox();
            this.radioBtnOther = new System.Windows.Forms.RadioButton();
            this.radioBtnFemale = new System.Windows.Forms.RadioButton();
            this.radioBtnMale = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.occupationSelector = new System.Windows.Forms.ComboBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.datePickerVisitors = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitors)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.GrpVisitorDetails.SuspendLayout();
            this.genderGroupBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Curlz MT", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(346, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(334, 57);
            this.label7.TabIndex = 12;
            this.label7.Text = "Skeleton Museum";
            // 
            // dgvVisitors
            // 
            this.dgvVisitors.AllowUserToAddRows = false;
            this.dgvVisitors.AllowUserToDeleteRows = false;
            this.dgvVisitors.AllowUserToResizeRows = false;
            this.dgvVisitors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvVisitors.BackgroundColor = System.Drawing.Color.Gray;
            this.dgvVisitors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisitors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CardNumber,
            this.FullName,
            this.DateOfBirth,
            this.Email,
            this.Gender,
            this.ContactNumber,
            this.Occupation,
            this.EntryTime,
            this.ExitTime,
            this.Duration});
            this.dgvVisitors.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvVisitors.Location = new System.Drawing.Point(341, 162);
            this.dgvVisitors.MultiSelect = false;
            this.dgvVisitors.Name = "dgvVisitors";
            this.dgvVisitors.ReadOnly = true;
            this.dgvVisitors.RowHeadersVisible = false;
            this.dgvVisitors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVisitors.Size = new System.Drawing.Size(806, 342);
            this.dgvVisitors.TabIndex = 14;
            this.dgvVisitors.SelectionChanged += new System.EventHandler(this.DgvVisitors_SelectionChanged);
            // 
            // CardNumber
            // 
            this.CardNumber.FillWeight = 44.78945F;
            this.CardNumber.HeaderText = "Card No.";
            this.CardNumber.Name = "CardNumber";
            this.CardNumber.ReadOnly = true;
            this.CardNumber.Width = 69;
            // 
            // FullName
            // 
            this.FullName.FillWeight = 41.72706F;
            this.FullName.HeaderText = "Full Name";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 73;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.FillWeight = 49.39613F;
            this.DateOfBirth.HeaderText = "Date of Birth";
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.ReadOnly = true;
            this.DateOfBirth.Width = 65;
            // 
            // Email
            // 
            this.Email.FillWeight = 79.15803F;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 57;
            // 
            // Gender
            // 
            this.Gender.FillWeight = 101.693F;
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Width = 67;
            // 
            // ContactNumber
            // 
            this.ContactNumber.FillWeight = 130.7776F;
            this.ContactNumber.HeaderText = "Contact No.";
            this.ContactNumber.Name = "ContactNumber";
            this.ContactNumber.ReadOnly = true;
            this.ContactNumber.Width = 82;
            // 
            // Occupation
            // 
            this.Occupation.FillWeight = 169.3922F;
            this.Occupation.HeaderText = "Occupation";
            this.Occupation.Name = "Occupation";
            this.Occupation.ReadOnly = true;
            this.Occupation.Width = 87;
            // 
            // EntryTime
            // 
            this.EntryTime.FillWeight = 166.2065F;
            this.EntryTime.HeaderText = "Entry Time";
            this.EntryTime.Name = "EntryTime";
            this.EntryTime.ReadOnly = true;
            this.EntryTime.Width = 76;
            // 
            // ExitTime
            // 
            this.ExitTime.FillWeight = 13.8142F;
            this.ExitTime.HeaderText = "Exit Time";
            this.ExitTime.Name = "ExitTime";
            this.ExitTime.ReadOnly = true;
            this.ExitTime.Width = 69;
            // 
            // Duration
            // 
            this.Duration.FillWeight = 203.0457F;
            this.Duration.HeaderText = "Total Duration (in Mins)";
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            this.Duration.Width = 106;
            // 
            // btnDailyReport
            // 
            this.btnDailyReport.BackColor = System.Drawing.Color.Teal;
            this.btnDailyReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDailyReport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDailyReport.Location = new System.Drawing.Point(27, 21);
            this.btnDailyReport.Name = "btnDailyReport";
            this.btnDailyReport.Size = new System.Drawing.Size(117, 33);
            this.btnDailyReport.TabIndex = 15;
            this.btnDailyReport.Text = "Daily Report";
            this.btnDailyReport.UseVisualStyleBackColor = false;
            this.btnDailyReport.Click += new System.EventHandler(this.BtnDailyReport_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnWeeklyReport);
            this.groupBox1.Controls.Add(this.btnDailyReport);
            this.groupBox1.Location = new System.Drawing.Point(836, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 64);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generate";
            // 
            // btnWeeklyReport
            // 
            this.btnWeeklyReport.BackColor = System.Drawing.Color.Teal;
            this.btnWeeklyReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWeeklyReport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnWeeklyReport.Location = new System.Drawing.Point(168, 21);
            this.btnWeeklyReport.Name = "btnWeeklyReport";
            this.btnWeeklyReport.Size = new System.Drawing.Size(117, 33);
            this.btnWeeklyReport.TabIndex = 16;
            this.btnWeeklyReport.Text = "Weekly Report";
            this.btnWeeklyReport.UseVisualStyleBackColor = false;
            this.btnWeeklyReport.Click += new System.EventHandler(this.BtnWeeklyReport_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1147, 75);
            this.panel1.TabIndex = 17;
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(99, 28);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(177, 20);
            this.txtCardNumber.TabIndex = 19;
            this.txtCardNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCardNumber_KeyPress);
            this.txtCardNumber.Leave += new System.EventHandler(this.TxtCardNumber_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Card No.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCardNumber);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 64);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Returning Visitor";
            // 
            // GrpVisitorDetails
            // 
            this.GrpVisitorDetails.Controls.Add(this.btnOut);
            this.GrpVisitorDetails.Controls.Add(this.dateOfBirthPicker);
            this.GrpVisitorDetails.Controls.Add(this.label3);
            this.GrpVisitorDetails.Controls.Add(this.label8);
            this.GrpVisitorDetails.Controls.Add(this.genderGroupBox);
            this.GrpVisitorDetails.Controls.Add(this.btnClear);
            this.GrpVisitorDetails.Controls.Add(this.btnIn);
            this.GrpVisitorDetails.Controls.Add(this.occupationSelector);
            this.GrpVisitorDetails.Controls.Add(this.txtFullName);
            this.GrpVisitorDetails.Controls.Add(this.label1);
            this.GrpVisitorDetails.Controls.Add(this.label2);
            this.GrpVisitorDetails.Controls.Add(this.txtContactNumber);
            this.GrpVisitorDetails.Controls.Add(this.txtEmail);
            this.GrpVisitorDetails.Controls.Add(this.label4);
            this.GrpVisitorDetails.Controls.Add(this.label5);
            this.GrpVisitorDetails.Location = new System.Drawing.Point(12, 157);
            this.GrpVisitorDetails.Name = "GrpVisitorDetails";
            this.GrpVisitorDetails.Size = new System.Drawing.Size(309, 347);
            this.GrpVisitorDetails.TabIndex = 22;
            this.GrpVisitorDetails.TabStop = false;
            this.GrpVisitorDetails.Text = "Visitor Details";
            // 
            // btnOut
            // 
            this.btnOut.BackColor = System.Drawing.Color.IndianRed;
            this.btnOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOut.Location = new System.Drawing.Point(201, 295);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(75, 33);
            this.btnOut.TabIndex = 36;
            this.btnOut.Text = "Out";
            this.btnOut.UseVisualStyleBackColor = false;
            this.btnOut.Click += new System.EventHandler(this.BtnOut_Click);
            // 
            // dateOfBirthPicker
            // 
            this.dateOfBirthPicker.CustomFormat = "dd-MMM-yyyy";
            this.dateOfBirthPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateOfBirthPicker.Location = new System.Drawing.Point(99, 108);
            this.dateOfBirthPicker.Name = "dateOfBirthPicker";
            this.dateOfBirthPicker.Size = new System.Drawing.Size(177, 20);
            this.dateOfBirthPicker.TabIndex = 35;
            this.dateOfBirthPicker.Value = new System.DateTime(1998, 12, 27, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Date of Birth";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Gender";
            // 
            // genderGroupBox
            // 
            this.genderGroupBox.Controls.Add(this.radioBtnOther);
            this.genderGroupBox.Controls.Add(this.radioBtnFemale);
            this.genderGroupBox.Controls.Add(this.radioBtnMale);
            this.genderGroupBox.Location = new System.Drawing.Point(99, 142);
            this.genderGroupBox.Name = "genderGroupBox";
            this.genderGroupBox.Size = new System.Drawing.Size(177, 52);
            this.genderGroupBox.TabIndex = 32;
            this.genderGroupBox.TabStop = false;
            // 
            // radioBtnOther
            // 
            this.radioBtnOther.AutoSize = true;
            this.radioBtnOther.Location = new System.Drawing.Point(120, 22);
            this.radioBtnOther.Name = "radioBtnOther";
            this.radioBtnOther.Size = new System.Drawing.Size(51, 17);
            this.radioBtnOther.TabIndex = 2;
            this.radioBtnOther.TabStop = true;
            this.radioBtnOther.Text = "Other";
            this.radioBtnOther.UseVisualStyleBackColor = true;
            // 
            // radioBtnFemale
            // 
            this.radioBtnFemale.AutoSize = true;
            this.radioBtnFemale.Location = new System.Drawing.Point(61, 22);
            this.radioBtnFemale.Name = "radioBtnFemale";
            this.radioBtnFemale.Size = new System.Drawing.Size(59, 17);
            this.radioBtnFemale.TabIndex = 1;
            this.radioBtnFemale.TabStop = true;
            this.radioBtnFemale.Text = "Female";
            this.radioBtnFemale.UseVisualStyleBackColor = true;
            // 
            // radioBtnMale
            // 
            this.radioBtnMale.AutoSize = true;
            this.radioBtnMale.Location = new System.Drawing.Point(7, 22);
            this.radioBtnMale.Name = "radioBtnMale";
            this.radioBtnMale.Size = new System.Drawing.Size(48, 17);
            this.radioBtnMale.TabIndex = 0;
            this.radioBtnMale.TabStop = true;
            this.radioBtnMale.Text = "Male";
            this.radioBtnMale.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkCyan;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.Location = new System.Drawing.Point(110, 295);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 33);
            this.btnClear.TabIndex = 31;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.DarkCyan;
            this.btnIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIn.Location = new System.Drawing.Point(18, 295);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 33);
            this.btnIn.TabIndex = 30;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.BtnIn_Click);
            // 
            // occupationSelector
            // 
            this.occupationSelector.FormattingEnabled = true;
            this.occupationSelector.Items.AddRange(new object[] {
            "Footballer",
            "Teacher",
            "Engineer",
            "Software Developer",
            "Doctor",
            "Astronaut"});
            this.occupationSelector.Location = new System.Drawing.Point(99, 251);
            this.occupationSelector.Name = "occupationSelector";
            this.occupationSelector.Size = new System.Drawing.Size(177, 21);
            this.occupationSelector.TabIndex = 29;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(99, 30);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(177, 20);
            this.txtFullName.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Full Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Email";
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(99, 212);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(177, 20);
            this.txtContactNumber.TabIndex = 28;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(99, 68);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(177, 20);
            this.txtEmail.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Contact No.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Occupation";
            // 
            // datePickerVisitors
            // 
            this.datePickerVisitors.CustomFormat = "dd-MMM-yyyy, ddddd";
            this.datePickerVisitors.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickerVisitors.Location = new System.Drawing.Point(15, 28);
            this.datePickerVisitors.Name = "datePickerVisitors";
            this.datePickerVisitors.Size = new System.Drawing.Size(200, 20);
            this.datePickerVisitors.TabIndex = 23;
            this.datePickerVisitors.ValueChanged += new System.EventHandler(this.DatePickerVisitors_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.datePickerVisitors);
            this.groupBox3.Location = new System.Drawing.Point(341, 87);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(243, 63);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Visitors for the Date";
            // 
            // MuseumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1161, 515);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.GrpVisitorDetails);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvVisitors);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MuseumForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Museum Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitors)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.GrpVisitorDetails.ResumeLayout(false);
            this.GrpVisitorDetails.PerformLayout();
            this.genderGroupBox.ResumeLayout(false);
            this.genderGroupBox.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvVisitors;
        private System.Windows.Forms.Button btnDailyReport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnWeeklyReport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox GrpVisitorDetails;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.DateTimePicker dateOfBirthPicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox genderGroupBox;
        private System.Windows.Forms.RadioButton radioBtnOther;
        private System.Windows.Forms.RadioButton radioBtnFemale;
        private System.Windows.Forms.RadioButton radioBtnMale;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.ComboBox occupationSelector;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker datePickerVisitors;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Occupation;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntryTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExitTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
    }
}

