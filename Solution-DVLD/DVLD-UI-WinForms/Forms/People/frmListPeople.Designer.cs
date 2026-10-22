namespace DVLD.WinForms.Forms.People
{
    partial class frmListPeople
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
            this.components = new System.ComponentModel.Container();
            this.usrManagePeople = new DVLD.WinForms.Cntrols.usrManagementScreen();
            this.pnlGenderFilter = new System.Windows.Forms.Panel();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.dtpDateFilter = new System.Windows.Forms.DateTimePicker();
            this.pnlGenderFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // usrManagePeople
            // 
            this.usrManagePeople.DataSource = null;
            this.usrManagePeople.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usrManagePeople.IsSearchTextBoxVisible = true;
            this.usrManagePeople.Location = new System.Drawing.Point(0, 0);
            this.usrManagePeople.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usrManagePeople.Name = "usrManagePeople";
            this.usrManagePeople.NumericFilterFields = null;
            this.usrManagePeople.Padding = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.usrManagePeople.ScreenTitle = "Manage People";
            this.usrManagePeople.SearchText = "";
            this.usrManagePeople.SelectedFilterItem = null;
            this.usrManagePeople.Size = new System.Drawing.Size(800, 450);
            this.usrManagePeople.TabIndex = 0;
            this.usrManagePeople.Load += new System.EventHandler(this.usrManagePeople_Load);
            // 
            // pnlGenderFilter
            // 
            this.pnlGenderFilter.Controls.Add(this.rdFemale);
            this.pnlGenderFilter.Controls.Add(this.rdMale);
            this.pnlGenderFilter.Location = new System.Drawing.Point(215, 116);
            this.pnlGenderFilter.Name = "pnlGenderFilter";
            this.pnlGenderFilter.Size = new System.Drawing.Size(200, 31);
            this.pnlGenderFilter.TabIndex = 1;
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Location = new System.Drawing.Point(119, 3);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(78, 24);
            this.rdFemale.TabIndex = 1;
            this.rdFemale.TabStop = true;
            this.rdFemale.Text = "Female";
            this.rdFemale.UseVisualStyleBackColor = true;
            this.rdFemale.CheckedChanged += new System.EventHandler(this.rdMale_CheckedChanged);
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Location = new System.Drawing.Point(3, 3);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(63, 24);
            this.rdMale.TabIndex = 0;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Male";
            this.rdMale.UseVisualStyleBackColor = true;
            this.rdMale.CheckedChanged += new System.EventHandler(this.rdMale_CheckedChanged);
            // 
            // dtpDateFilter
            // 
            this.dtpDateFilter.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateFilter.Location = new System.Drawing.Point(215, 116);
            this.dtpDateFilter.Name = "dtpDateFilter";
            this.dtpDateFilter.Size = new System.Drawing.Size(200, 27);
            this.dtpDateFilter.TabIndex = 2;
            this.dtpDateFilter.ValueChanged += new System.EventHandler(this.dtpDateFilter_ValueChanged);
            // 
            // frmListPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlGenderFilter);
            this.Controls.Add(this.dtpDateFilter);
            this.Controls.Add(this.usrManagePeople);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListPeople";
            this.Text = "frmListPeople";
            this.pnlGenderFilter.ResumeLayout(false);
            this.pnlGenderFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Cntrols.usrManagementScreen usrManagePeople;
        private System.Windows.Forms.Panel pnlGenderFilter;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.DateTimePicker dtpDateFilter;
    }
}