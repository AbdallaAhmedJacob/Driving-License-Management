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
            this.SuspendLayout();
            // 
            // usrManagePeople
            // 
            this.usrManagePeople.DataSource = null;
            this.usrManagePeople.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usrManagePeople.Location = new System.Drawing.Point(0, 0);
            this.usrManagePeople.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usrManagePeople.Name = "usrManagePeople";
            this.usrManagePeople.Padding = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.usrManagePeople.ScreenTitle = "Manage People";
            this.usrManagePeople.SearchText = "";
            this.usrManagePeople.SelectedFilterItem = null;
            this.usrManagePeople.Size = new System.Drawing.Size(800, 450);
            this.usrManagePeople.TabIndex = 0;
            this.usrManagePeople.Load += new System.EventHandler(this.usrManagePeople_Load);
            // 
            // frmListPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.usrManagePeople);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListPeople";
            this.Text = "frmListPeople";
            this.ResumeLayout(false);

        }

        #endregion

        private Cntrols.usrManagementScreen usrManagePeople;
    }
}