namespace DVLD.WinForms.Forms
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menuApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPeople = new System.Windows.Forms.ToolStripMenuItem();
            this.managePeopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDrivers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAccountSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.menuMain.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuApplications,
            this.menuPeople,
            this.menuDrivers,
            this.menuUsers,
            this.menuAccountSettings});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Padding = new System.Windows.Forms.Padding(10, 4, 10, 4);
            this.menuMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuMain.Size = new System.Drawing.Size(800, 32);
            this.menuMain.TabIndex = 1;
            this.menuMain.Text = "Menu Main";
            // 
            // menuApplications
            // 
            this.menuApplications.Name = "menuApplications";
            this.menuApplications.Size = new System.Drawing.Size(114, 24);
            this.menuApplications.Text = "Applications ";
            // 
            // menuPeople
            // 
            this.menuPeople.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managePeopleToolStripMenuItem});
            this.menuPeople.Name = "menuPeople";
            this.menuPeople.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.menuPeople.Size = new System.Drawing.Size(70, 24);
            this.menuPeople.Text = "&People";
            // 
            // managePeopleToolStripMenuItem
            // 
            this.managePeopleToolStripMenuItem.Name = "managePeopleToolStripMenuItem";
            this.managePeopleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.managePeopleToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.managePeopleToolStripMenuItem.Text = "&Manage People";
            // 
            // menuDrivers
            // 
            this.menuDrivers.Name = "menuDrivers";
            this.menuDrivers.Size = new System.Drawing.Size(73, 24);
            this.menuDrivers.Text = "Drivers";
            // 
            // menuUsers
            // 
            this.menuUsers.Name = "menuUsers";
            this.menuUsers.Size = new System.Drawing.Size(62, 24);
            this.menuUsers.Text = "Users";
            // 
            // menuAccountSettings
            // 
            this.menuAccountSettings.Name = "menuAccountSettings";
            this.menuAccountSettings.Size = new System.Drawing.Size(142, 24);
            this.menuAccountSettings.Text = "Account Settings";
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.pbLogo);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 32);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(20);
            this.pnlContent.Size = new System.Drawing.Size(800, 530);
            this.pnlContent.TabIndex = 3;
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(20, 20);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(760, 490);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 526);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(800, 36);
            this.pnlFooter.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.menuMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuMain;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmMain";
            this.Text = "DVLD - Driving & Vehicle License Department ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuApplications;
        private System.Windows.Forms.ToolStripMenuItem menuPeople;
        private System.Windows.Forms.ToolStripMenuItem menuDrivers;
        private System.Windows.Forms.ToolStripMenuItem menuUsers;
        private System.Windows.Forms.ToolStripMenuItem menuAccountSettings;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.ToolStripMenuItem managePeopleToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}