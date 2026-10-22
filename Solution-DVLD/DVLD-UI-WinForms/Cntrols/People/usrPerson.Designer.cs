namespace DVLD.WinForms.Cntrols.People
{
    partial class usrPerson
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpContainer = new System.Windows.Forms.GroupBox();
            this.txtNationalNO = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhonNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.gbFullName = new System.Windows.Forms.GroupBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtThirdName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFerstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.cbCountries = new System.Windows.Forms.ComboBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.lklblChangeImage = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtbAddress = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.usrHeader = new DVLD.WinForms.Cntrols.usrHeader();
            this.gpContainer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbGender.SuspendLayout();
            this.gbFullName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpContainer
            // 
            this.gpContainer.Controls.Add(this.btnClose);
            this.gpContainer.Controls.Add(this.btnSave);
            this.gpContainer.Controls.Add(this.groupBox2);
            this.gpContainer.Controls.Add(this.lklblChangeImage);
            this.gpContainer.Controls.Add(this.pbImage);
            this.gpContainer.Controls.Add(this.cbCountries);
            this.gpContainer.Controls.Add(this.dtpDateOfBirth);
            this.gpContainer.Controls.Add(this.txtNationalNO);
            this.gpContainer.Controls.Add(this.label9);
            this.gpContainer.Controls.Add(this.label8);
            this.gpContainer.Controls.Add(this.label7);
            this.gpContainer.Controls.Add(this.groupBox1);
            this.gpContainer.Controls.Add(this.gbGender);
            this.gpContainer.Controls.Add(this.gbFullName);
            this.gpContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpContainer.Location = new System.Drawing.Point(10, 60);
            this.gpContainer.Name = "gpContainer";
            this.gpContainer.Padding = new System.Windows.Forms.Padding(5);
            this.gpContainer.Size = new System.Drawing.Size(980, 430);
            this.gpContainer.TabIndex = 2;
            this.gpContainer.TabStop = false;
            this.gpContainer.Text = "ID: N/A";
            // 
            // txtNationalNO
            // 
            this.txtNationalNO.Location = new System.Drawing.Point(108, 172);
            this.txtNationalNO.Name = "txtNationalNO";
            this.txtNationalNO.Size = new System.Drawing.Size(266, 22);
            this.txtNationalNO.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(564, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "Country";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(392, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Birth Of Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "National NO";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtPhonNumber);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(5, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 119);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contact Info";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(71, 76);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(298, 22);
            this.txtEmail.TabIndex = 9;
            // 
            // txtPhonNumber
            // 
            this.txtPhonNumber.Location = new System.Drawing.Point(71, 32);
            this.txtPhonNumber.Name = "txtPhonNumber";
            this.txtPhonNumber.Size = new System.Drawing.Size(298, 22);
            this.txtPhonNumber.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "phone";
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.rbFemale);
            this.gbGender.Controls.Add(this.rbMale);
            this.gbGender.Location = new System.Drawing.Point(387, 217);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(159, 55);
            this.gbGender.TabIndex = 4;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Gender ";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(77, 21);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(74, 20);
            this.rbFemale.TabIndex = 1;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(8, 21);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(58, 20);
            this.rbMale.TabIndex = 0;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // gbFullName
            // 
            this.gbFullName.Controls.Add(this.txtLastName);
            this.gbFullName.Controls.Add(this.label4);
            this.gbFullName.Controls.Add(this.txtThirdName);
            this.gbFullName.Controls.Add(this.label3);
            this.gbFullName.Controls.Add(this.txtSecondName);
            this.gbFullName.Controls.Add(this.label2);
            this.gbFullName.Controls.Add(this.txtFerstName);
            this.gbFullName.Controls.Add(this.label1);
            this.gbFullName.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbFullName.Location = new System.Drawing.Point(5, 20);
            this.gbFullName.Name = "gbFullName";
            this.gbFullName.Padding = new System.Windows.Forms.Padding(5);
            this.gbFullName.Size = new System.Drawing.Size(970, 112);
            this.gbFullName.TabIndex = 0;
            this.gbFullName.TabStop = false;
            this.gbFullName.Text = "Full Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(811, 55);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(149, 22);
            this.txtLastName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(863, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Last";
            // 
            // txtThirdName
            // 
            this.txtThirdName.Location = new System.Drawing.Point(545, 55);
            this.txtThirdName.Name = "txtThirdName";
            this.txtThirdName.Size = new System.Drawing.Size(149, 22);
            this.txtThirdName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(597, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Third";
            // 
            // txtSecondName
            // 
            this.txtSecondName.Location = new System.Drawing.Point(279, 55);
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(149, 22);
            this.txtSecondName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Second";
            // 
            // txtFerstName
            // 
            this.txtFerstName.Location = new System.Drawing.Point(13, 55);
            this.txtFerstName.Name = "txtFerstName";
            this.txtFerstName.Size = new System.Drawing.Size(149, 22);
            this.txtFerstName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "First";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(492, 172);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(307, 22);
            this.dtpDateOfBirth.TabIndex = 2;
            // 
            // cbCountries
            // 
            this.cbCountries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountries.FormattingEnabled = true;
            this.cbCountries.Location = new System.Drawing.Point(636, 234);
            this.cbCountries.Name = "cbCountries";
            this.cbCountries.Size = new System.Drawing.Size(163, 24);
            this.cbCountries.TabIndex = 5;
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(820, 156);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(150, 180);
            this.pbImage.TabIndex = 11;
            this.pbImage.TabStop = false;
            // 
            // lklblChangeImage
            // 
            this.lklblChangeImage.AutoSize = true;
            this.lklblChangeImage.Location = new System.Drawing.Point(868, 345);
            this.lklblChangeImage.Name = "lklblChangeImage";
            this.lklblChangeImage.Size = new System.Drawing.Size(68, 16);
            this.lklblChangeImage.TabIndex = 7;
            this.lklblChangeImage.TabStop = true;
            this.lklblChangeImage.Text = "linkLabel1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtbAddress);
            this.groupBox2.Location = new System.Drawing.Point(387, 278);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 58);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Address";
            // 
            // rtbAddress
            // 
            this.rtbAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbAddress.Location = new System.Drawing.Point(3, 18);
            this.rtbAddress.Name = "rtbAddress";
            this.rtbAddress.Size = new System.Drawing.Size(409, 37);
            this.rtbAddress.TabIndex = 0;
            this.rtbAddress.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(835, 384);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 38);
            this.btnSave.TabIndex = 8;
            this.btnSave.Tag = "Primary";
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(650, 384);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 38);
            this.btnClose.TabIndex = 9;
            this.btnClose.Tag = "Secondary";
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // usrHeader
            // 
            this.usrHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.usrHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.usrHeader.Location = new System.Drawing.Point(10, 10);
            this.usrHeader.Name = "usrHeader";
            this.usrHeader.Size = new System.Drawing.Size(980, 50);
            this.usrHeader.TabIndex = 0;
            this.usrHeader.Title = "Person Info";
            // 
            // usrPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gpContainer);
            this.Controls.Add(this.usrHeader);
            this.Name = "usrPerson";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(1000, 500);
            this.gpContainer.ResumeLayout(false);
            this.gpContainer.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            this.gbFullName.ResumeLayout(false);
            this.gbFullName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private usrHeader usrHeader;
        private System.Windows.Forms.GroupBox gpContainer;
        private System.Windows.Forms.GroupBox gbFullName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtThirdName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSecondName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFerstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhonNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNationalNO;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.LinkLabel lklblChangeImage;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.ComboBox cbCountries;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtbAddress;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
    }
}
