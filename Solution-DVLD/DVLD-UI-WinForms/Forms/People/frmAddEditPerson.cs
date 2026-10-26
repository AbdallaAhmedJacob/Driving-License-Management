using System;
using System.Windows.Forms;

namespace DVLD.WinForms.Forms.People
{
    public partial class frmAddEditPerson : Form
    {
        public frmAddEditPerson(int personID)
        {
            InitializeComponent();
            usrPerson.PersonID = personID;
        }
    }
}
