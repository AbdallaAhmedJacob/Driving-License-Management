namespace DVLD.WinForms.Forms.People
{
    partial class frmPersonDetails
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
            this.usrPersonCard1 = new DVLD.WinForms.Cntrols.People.usrPersonCard();
            this.SuspendLayout();
            // 
            // usrPersonCard1
            // 
            this.usrPersonCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usrPersonCard1.Location = new System.Drawing.Point(10, 10);
            this.usrPersonCard1.Name = "usrPersonCard1";
            this.usrPersonCard1.Padding = new System.Windows.Forms.Padding(10);
            this.usrPersonCard1.Size = new System.Drawing.Size(743, 541);
            this.usrPersonCard1.TabIndex = 0;
            // 
            // frmPersonDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 561);
            this.Controls.Add(this.usrPersonCard1);
            this.Name = "frmPersonDetails";
            this.Text = "Person Details";
            this.ResumeLayout(false);

        }

        #endregion

        private Cntrols.People.usrPersonCard usrPersonCard1;
    }
}