using DVLD.Business.People;
using DVLD.WinForms.UI;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD.WinForms.Forms.People
{
    public partial class frmListPeople : frmBase
    {
        public frmListPeople()
        {
            InitializeComponent();
        }

        private void usrManagePeople_Load(object sender, EventArgs e)
        {
            LoadPeopleData();
        }

        private void LoadPeopleData()
        {
            usrManagePeople.NumericFilterFields = new string[] { "Person ID", "Phone" };

            DataTable dtPeople = clsPerson.GetAllPeople();
            usrManagePeople.DataSource = dtPeople;
            usrManagePeople.RecordsCount = dtPeople.Rows.Count;
            usrManagePeople.PopulateFilterOptionsFromGrid();
        }
    }
}
