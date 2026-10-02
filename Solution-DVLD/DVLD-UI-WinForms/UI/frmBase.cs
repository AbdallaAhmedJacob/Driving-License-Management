using System;
using System.Windows.Forms;

namespace DVLD.WinForms.UI
{
    public partial class frmBase : Form
    {
        public frmBase()
        {
            InitializeComponent();

            ApplyBaseSettings();
        }


        // =========================================================
        // Base Form Settings
        // =========================================================

        private void ApplyBaseSettings()
        {
            this.StartPosition = clsTheme.DefaultStartPosition;

            this.BackColor = clsTheme.Background;

            this.ForeColor = clsTheme.TextPrimary;

            this.Font = clsTheme.FontRegular;

            this.FormBorderStyle =
                clsTheme.DefaultFormBorderStyle;

            this.AutoScaleMode =
                AutoScaleMode.Font;

            this.RightToLeft =
                RightToLeft.No;

            this.KeyPreview = true;

            clsUIHelper.ApplyTheme(this);
        }
    }
}

