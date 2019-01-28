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
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.signUpPanel = new System.Windows.Forms.Panel();
            this.btnOut = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.dateOfBirthPicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.genderGroupBox = new System.Windows.Forms.GroupBox();
            this.radioBtnOther = new System.Windows.Forms.RadioButton();
            this.radioBtnFemale = new System.Windows.Forms.RadioButton();
            this.radioBtnMale = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.occupationSelector = new System.Windows.Forms.ComboBox();
            this.dgvVisitors = new System.Windows.Forms.DataGridView();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.signUpPanel.SuspendLayout();
            this.genderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitors)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(99, 62);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(177, 20);
            this.txtFullName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Full Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(99, 100);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(177, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Contact No.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Occupation";
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(99, 244);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(177, 20);
            this.txtContactNumber.TabIndex = 10;
            this.txtContactNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContactNumber_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(342, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(317, 42);
            this.label7.TabIndex = 12;
            this.label7.Text = "Skeleton Museum";
            // 
            // signUpPanel
            // 
            this.signUpPanel.Controls.Add(this.btnOut);
            this.signUpPanel.Controls.Add(this.label6);
            this.signUpPanel.Controls.Add(this.txtCardNumber);
            this.signUpPanel.Controls.Add(this.dateOfBirthPicker);
            this.signUpPanel.Controls.Add(this.label3);
            this.signUpPanel.Controls.Add(this.label8);
            this.signUpPanel.Controls.Add(this.genderGroupBox);
            this.signUpPanel.Controls.Add(this.btnClear);
            this.signUpPanel.Controls.Add(this.btnRegister);
            this.signUpPanel.Controls.Add(this.occupationSelector);
            this.signUpPanel.Controls.Add(this.txtFullName);
            this.signUpPanel.Controls.Add(this.label1);
            this.signUpPanel.Controls.Add(this.label2);
            this.signUpPanel.Controls.Add(this.txtContactNumber);
            this.signUpPanel.Controls.Add(this.txtEmail);
            this.signUpPanel.Controls.Add(this.label4);
            this.signUpPanel.Controls.Add(this.label5);
            this.signUpPanel.Location = new System.Drawing.Point(12, 68);
            this.signUpPanel.Name = "signUpPanel";
            this.signUpPanel.Size = new System.Drawing.Size(310, 379);
            this.signUpPanel.TabIndex = 13;
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(201, 327);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(75, 23);
            this.btnOut.TabIndex = 21;
            this.btnOut.Text = "Out";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Card No.";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(99, 21);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(177, 20);
            this.txtCardNumber.TabIndex = 19;
            this.txtCardNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCardNumber_KeyPress);
            this.txtCardNumber.Leave += new System.EventHandler(this.txtCardNumber_Leave);
            // 
            // dateOfBirthPicker
            // 
            this.dateOfBirthPicker.CustomFormat = "dd-MMM-yyyy";
            this.dateOfBirthPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateOfBirthPicker.Location = new System.Drawing.Point(99, 140);
            this.dateOfBirthPicker.Name = "dateOfBirthPicker";
            this.dateOfBirthPicker.Size = new System.Drawing.Size(177, 20);
            this.dateOfBirthPicker.TabIndex = 18;
            this.dateOfBirthPicker.Value = new System.DateTime(1998, 12, 27, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Date of Birth";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Gender";
            // 
            // genderGroupBox
            // 
            this.genderGroupBox.Controls.Add(this.radioBtnOther);
            this.genderGroupBox.Controls.Add(this.radioBtnFemale);
            this.genderGroupBox.Controls.Add(this.radioBtnMale);
            this.genderGroupBox.Location = new System.Drawing.Point(99, 174);
            this.genderGroupBox.Name = "genderGroupBox";
            this.genderGroupBox.Size = new System.Drawing.Size(177, 52);
            this.genderGroupBox.TabIndex = 15;
            this.genderGroupBox.TabStop = false;
            // 
            // radioBtnOther
            // 
            this.radioBtnOther.AutoSize = true;
            this.radioBtnOther.Location = new System.Drawing.Point(120, 19);
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
            this.radioBtnFemale.Location = new System.Drawing.Point(61, 19);
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
            this.radioBtnMale.Location = new System.Drawing.Point(7, 20);
            this.radioBtnMale.Name = "radioBtnMale";
            this.radioBtnMale.Size = new System.Drawing.Size(48, 17);
            this.radioBtnMale.TabIndex = 0;
            this.radioBtnMale.TabStop = true;
            this.radioBtnMale.Text = "Male";
            this.radioBtnMale.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(110, 327);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(18, 327);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 12;
            this.btnRegister.Text = "In";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnIn_Click);
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
            this.occupationSelector.Location = new System.Drawing.Point(99, 283);
            this.occupationSelector.Name = "occupationSelector";
            this.occupationSelector.Size = new System.Drawing.Size(177, 21);
            this.occupationSelector.TabIndex = 11;
            // 
            // dgvVisitors
            // 
            this.dgvVisitors.AllowUserToAddRows = false;
            this.dgvVisitors.AllowUserToDeleteRows = false;
            this.dgvVisitors.AllowUserToResizeRows = false;
            this.dgvVisitors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvVisitors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisitors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Day,
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
            this.dgvVisitors.Location = new System.Drawing.Point(349, 68);
            this.dgvVisitors.MultiSelect = false;
            this.dgvVisitors.Name = "dgvVisitors";
            this.dgvVisitors.ReadOnly = true;
            this.dgvVisitors.RowHeadersVisible = false;
            this.dgvVisitors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVisitors.Size = new System.Drawing.Size(866, 281);
            this.dgvVisitors.TabIndex = 14;
            this.dgvVisitors.SelectionChanged += new System.EventHandler(this.dgvVisitors_SelectionChanged);
            // 
            // Day
            // 
            this.Day.HeaderText = "Day";
            this.Day.Name = "Day";
            this.Day.ReadOnly = true;
            this.Day.Width = 51;
            // 
            // CardNumber
            // 
            this.CardNumber.FillWeight = 80.70174F;
            this.CardNumber.HeaderText = "Card No.";
            this.CardNumber.Name = "CardNumber";
            this.CardNumber.ReadOnly = true;
            this.CardNumber.Width = 69;
            // 
            // FullName
            // 
            this.FullName.FillWeight = 88.6041F;
            this.FullName.HeaderText = "Full Name";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 73;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.FillWeight = 81.16398F;
            this.DateOfBirth.HeaderText = "Date of Birth";
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.ReadOnly = true;
            this.DateOfBirth.Width = 65;
            // 
            // Email
            // 
            this.Email.FillWeight = 73.6611F;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 57;
            // 
            // Gender
            // 
            this.Gender.FillWeight = 90.09483F;
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Width = 67;
            // 
            // ContactNumber
            // 
            this.ContactNumber.FillWeight = 112.9859F;
            this.ContactNumber.HeaderText = "Contact No.";
            this.ContactNumber.Name = "ContactNumber";
            this.ContactNumber.ReadOnly = true;
            this.ContactNumber.Width = 82;
            // 
            // Occupation
            // 
            this.Occupation.FillWeight = 120.4325F;
            this.Occupation.HeaderText = "Occupation";
            this.Occupation.Name = "Occupation";
            this.Occupation.ReadOnly = true;
            this.Occupation.Width = 87;
            // 
            // EntryTime
            // 
            this.EntryTime.FillWeight = 105.0303F;
            this.EntryTime.HeaderText = "Entry Time";
            this.EntryTime.Name = "EntryTime";
            this.EntryTime.ReadOnly = true;
            this.EntryTime.Width = 76;
            // 
            // ExitTime
            // 
            this.ExitTime.FillWeight = 96.44043F;
            this.ExitTime.HeaderText = "Exit Time";
            this.ExitTime.Name = "ExitTime";
            this.ExitTime.ReadOnly = true;
            this.ExitTime.Width = 69;
            // 
            // Duration
            // 
            this.Duration.FillWeight = 150.885F;
            this.Duration.HeaderText = "Total Duration (in Mins)";
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            this.Duration.Width = 106;
            // 
            // btnDailyReport
            // 
            this.btnDailyReport.Location = new System.Drawing.Point(15, 36);
            this.btnDailyReport.Name = "btnDailyReport";
            this.btnDailyReport.Size = new System.Drawing.Size(75, 23);
            this.btnDailyReport.TabIndex = 15;
            this.btnDailyReport.Text = "Daily Report";
            this.btnDailyReport.UseVisualStyleBackColor = true;
            this.btnDailyReport.Click += new System.EventHandler(this.btnDailyReport_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnWeeklyReport);
            this.groupBox1.Controls.Add(this.btnDailyReport);
            this.groupBox1.Location = new System.Drawing.Point(349, 369);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 78);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generate";
            // 
            // btnWeeklyReport
            // 
            this.btnWeeklyReport.Location = new System.Drawing.Point(117, 36);
            this.btnWeeklyReport.Name = "btnWeeklyReport";
            this.btnWeeklyReport.Size = new System.Drawing.Size(90, 23);
            this.btnWeeklyReport.TabIndex = 16;
            this.btnWeeklyReport.Text = "Weekly Report";
            this.btnWeeklyReport.UseVisualStyleBackColor = true;
            this.btnWeeklyReport.Click += new System.EventHandler(this.btnWeeklyReport_Click);
            // 
            // MuseumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1222, 459);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvVisitors);
            this.Controls.Add(this.signUpPanel);
            this.Controls.Add(this.label7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MuseumForm";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Museum Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.signUpPanel.ResumeLayout(false);
            this.signUpPanel.PerformLayout();
            this.genderGroupBox.ResumeLayout(false);
            this.genderGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitors)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel signUpPanel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ComboBox occupationSelector;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox genderGroupBox;
        private System.Windows.Forms.RadioButton radioBtnOther;
        private System.Windows.Forms.RadioButton radioBtnFemale;
        private System.Windows.Forms.RadioButton radioBtnMale;
        private System.Windows.Forms.DataGridView dgvVisitors;
        private System.Windows.Forms.DateTimePicker dateOfBirthPicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnDailyReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnWeeklyReport;
    }
}

