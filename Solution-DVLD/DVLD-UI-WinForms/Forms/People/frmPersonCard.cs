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

            usrPerson.SavedClick += (s, e) => this.DialogResult = DialogResult.OK;
        }

        // ===================================
        // Manage Person
        // ===================================

        private void frmPersonCard_Load(object sender, EventArgs e)
        {
            usrPerson.LoadInfo(_PersonID, _Mode);

            if (_Mode == usrPerson.enMode.AddNew)
            {
                this.Text = "Add New Person";
            }
            else if (_Mode == usrPerson.enMode.Update)
            {
                this.Text = "Update Person";
            }
            else if (_Mode == usrPerson.enMode.ShowDetails)
            {
                this.Text = "Person Details";
            }
        }

    }
}
