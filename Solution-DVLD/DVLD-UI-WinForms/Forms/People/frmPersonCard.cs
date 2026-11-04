using System;
using DVLD.WinForms.Cntrols.People;
using System.Windows.Forms;

namespace DVLD.WinForms.Forms.People
{
    public partial class frmPersonCard : Form
    {
        private int _PersonID = -1;
        private usrPerson.enMode _Mode;

        public frmPersonCard(int personID, usrPerson.enMode mode)
        {
            InitializeComponent();
            _PersonID = personID;
            _Mode = mode;

            //usrPerson.SavedClick += _Save;
        }

        // ===================================
        // Manage Person
        // ===================================

        private void frmPersonCard_Load(object sender, EventArgs e)
        {
            usrPerson.LoadInfo(_PersonID, _Mode);

        }

        //private void _Save(object sender, EventArgs e)
        //{
        //    frmPersonCard_Load(this, EventArgs.Empty);
        //}

    }
}
