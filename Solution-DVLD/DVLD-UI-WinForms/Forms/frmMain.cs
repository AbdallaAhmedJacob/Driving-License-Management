using DVLD.WinForms.UI;
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

    }
}
