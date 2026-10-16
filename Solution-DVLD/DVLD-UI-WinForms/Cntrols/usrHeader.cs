using DVLD.WinForms.UI;
using System;
using System.Windows.Forms;

namespace DVLD.WinForms.Cntrols
{
    public partial class usrHeader : UserControl
    {
        public usrHeader()
        {
            InitializeComponent();
            clsUIHelper.ApplyTheme(this);
        }

        public string Title
        {
            get
            {
                return lblTitle.Text;
            }
            set
            {
                lblTitle.Text = value;
            }
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            lblTitle.Left = (int)(panel1.Width / 2) - (lblTitle.Width / 2);
            lblTitle.Top = (int)(panel1.Height / 2) - (panel1.Height / 2);
        }
        
    }
}
