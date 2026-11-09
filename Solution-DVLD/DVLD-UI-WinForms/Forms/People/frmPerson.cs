using System;
using DVLD.WinForms.Cntrols.People;
using DVLD.Business.People;
using System.Windows.Forms;
using DVLD.WinForms.UI;

namespace DVLD.WinForms.Forms.People
{
    public partial class frmPerson : frmBase
    {
        private int _PersonID = -1;
        private clsPerson.enMode _Mode;

        public frmPerson(int personID, clsPerson.enMode mode)
        {
            InitializeComponent();
            _PersonID = personID;
            _Mode = mode;

            usrPerson.SavedClick += _Save;
        }

        // ===================================
        // Manage Person
        // ===================================

        private void frmPersonCard_Load(object sender, EventArgs e)
        {
            usrPerson.LoadInfo(_PersonID, _Mode);

        }

        private void _Save(object sender, EventArgs e)
        {
            frmPersonCard_Load(this, EventArgs.Empty);
        }

    }
}
