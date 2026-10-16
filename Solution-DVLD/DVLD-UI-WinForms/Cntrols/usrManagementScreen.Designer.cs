namespace DVLD.WinForms.Cntrols
{
    partial class usrManagementScreen
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
            this.components = new System.ComponentModel.Container();
            this.usrHeaderManagementScreen = new DVLD.WinForms.Cntrols.usrHeader();
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.pnlGridContainer = new System.Windows.Forms.Panel();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.cmsPeopleOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pnlToolbar.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlGridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // usrHeaderManagementScreen
            // 
            this.usrHeaderManagementScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.usrHeaderManagementScreen.Dock = System.Windows.Forms.DockStyle.Top;
            this.usrHeaderManagementScreen.Location = new System.Drawing.Point(10, 10);
            this.usrHeaderManagementScreen.Name = "usrHeaderManagementScreen";
            this.usrHeaderManagementScreen.Padding = new System.Windows.Forms.Padding(10);
            this.usrHeaderManagementScreen.Size = new System.Drawing.Size(634, 70);
            this.usrHeaderManagementScreen.TabIndex = 0;
            this.usrHeaderManagementScreen.Title = "Title";
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.Controls.Add(this.txtSearch);
            this.pnlToolbar.Controls.Add(this.cbFilterBy);
            this.pnlToolbar.Controls.Add(this.lblFilterBy);
            this.pnlToolbar.Controls.Add(this.btnAddNew);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(10, 80);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Padding = new System.Windows.Forms.Padding(10);
            this.pnlToolbar.Size = new System.Drawing.Size(634, 50);
            this.pnlToolbar.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSearch.Location = new System.Drawing.Point(232, 14);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 22);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Tag = "Control";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Location = new System.Drawing.Point(79, 13);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(121, 24);
            this.cbFilterBy.TabIndex = 0;
            this.cbFilterBy.Tag = "Control";
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Location = new System.Drawing.Point(14, 17);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(58, 16);
            this.lblFilterBy.TabIndex = 1;
            this.lblFilterBy.Tag = "LabelSecondary";
            this.lblFilterBy.Text = "Filter By:";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddNew.Location = new System.Drawing.Point(523, 5);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(106, 40);
            this.btnAddNew.TabIndex = 2;
            this.btnAddNew.Tag = "Primary";
            this.btnAddNew.Text = "Add New...";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.btnClose);
            this.pnlFooter.Controls.Add(this.lblRecordsCount);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(10, 384);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Padding = new System.Windows.Forms.Padding(10);
            this.pnlFooter.Size = new System.Drawing.Size(634, 40);
            this.pnlFooter.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClose.Location = new System.Drawing.Point(523, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(106, 32);
            this.btnClose.TabIndex = 0;
            this.btnClose.Tag = "Secondary";
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Location = new System.Drawing.Point(13, 12);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(62, 16);
            this.lblRecordsCount.TabIndex = 2;
            this.lblRecordsCount.Tag = "LabelSecondary";
            this.lblRecordsCount.Text = "Records:";
            // 
            // pnlGridContainer
            // 
            this.pnlGridContainer.Controls.Add(this.dgvResults);
            this.pnlGridContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridContainer.Location = new System.Drawing.Point(10, 130);
            this.pnlGridContainer.Name = "pnlGridContainer";
            this.pnlGridContainer.Padding = new System.Windows.Forms.Padding(10);
            this.pnlGridContainer.Size = new System.Drawing.Size(634, 254);
            this.pnlGridContainer.TabIndex = 1;
            // 
            // dgvResults
            // 
            this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.ContextMenuStrip = this.cmsPeopleOptions;
            this.dgvResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResults.Location = new System.Drawing.Point(10, 10);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.RowHeadersWidth = 51;
            this.dgvResults.RowTemplate.Height = 24;
            this.dgvResults.Size = new System.Drawing.Size(614, 234);
            this.dgvResults.TabIndex = 0;
            // 
            // cmsPeopleOptions
            // 
            this.cmsPeopleOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsPeopleOptions.Name = "cmsPeopleOptions";
            this.cmsPeopleOptions.Size = new System.Drawing.Size(61, 4);
            // 
            // usrManagementScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlGridContainer);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlToolbar);
            this.Controls.Add(this.usrHeaderManagementScreen);
            this.Name = "usrManagementScreen";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(654, 434);
            this.pnlToolbar.ResumeLayout(false);
            this.pnlToolbar.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.pnlGridContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private usrHeader usrHeaderManagementScreen;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlGridContainer;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.ContextMenuStrip cmsPeopleOptions;
    }
}
