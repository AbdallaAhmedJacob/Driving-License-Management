namespace DVLD.WinForms.UI
{
    partial class frmTest
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
            this.usrPerson1 = new DVLD.WinForms.Cntrols.People.usrPerson();
            this.SuspendLayout();
            // 
            // usrPerson1
            // 
            this.usrPerson1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usrPerson1.Location = new System.Drawing.Point(10, 10);
            this.usrPerson1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usrPerson1.Name = "usrPerson1";
            this.usrPerson1.Padding = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.usrPerson1.Size = new System.Drawing.Size(1005, 617);
            this.usrPerson1.TabIndex = 0;
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 637);
            this.Controls.Add(this.usrPerson1);
            this.Name = "frmTest";
            this.Text = "frmTest";
            this.ResumeLayout(false);

        }

        #endregion

        private Cntrols.People.usrPerson usrPerson1;
    }
}