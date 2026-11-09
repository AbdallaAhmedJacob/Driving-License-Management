using DVLD.WinForms.UI;

namespace DVLD.WinForms.Forms.People
{
    public partial class frmPersonDetails : frmBase
    {
        public frmPersonDetails(int personID)
        {
            InitializeComponent();
            usrPersonCard1.LoadPersonData(personID);
        }
    }
}
