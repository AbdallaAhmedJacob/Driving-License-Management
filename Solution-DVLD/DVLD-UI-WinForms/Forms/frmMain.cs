using DVLD.WinForms.Forms.People;
using DVLD.WinForms.UI;
using System;
using System.Windows.Forms;

namespace DVLD.WinForms.Forms
{
    public partial class frmMain : frmBase
    {
        public frmMain()
        {
            InitializeComponent();

            clsUIHelper.ApplyTheme(menuMain);
            clsUIHelper.ApplyTheme(pnlContent);
            clsUIHelper.ApplyTheme(pnlFooter);
        }
        private void OpenFormInPanel(Form subForm)
        {
            if (pnlContent.Controls.Count > 0)
            {
                Control oldControl = pnlContent.Controls[0];
                oldControl.Dispose();
            }

            subForm.TopLevel = false;
            subForm.FormBorderStyle = FormBorderStyle.None;
            subForm.Dock = DockStyle.Fill;

            pnlContent.Controls.Add(subForm);
            pnlContent.Tag = subForm;
            subForm.Show();
        }

        private void menuPeople_Click(object sender, EventArgs e)
        {
            frmListPeople frm = new frmListPeople();
            OpenFormInPanel(frm);
        }
    }
}
