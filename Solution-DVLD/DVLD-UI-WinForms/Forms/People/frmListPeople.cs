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
            PopulateContextMenuStrip();
        }
        
        private void PopulateContextMenuStrip()
        {
            ContextMenuStrip peopleMenu = new ContextMenuStrip();
            peopleMenu.Items.Add("Show Details", null, ShowDetails_Click);
            peopleMenu.Items.Add("-"); 
            peopleMenu.Items.Add("Add New Person", null, AddNewPerson_Click);
            peopleMenu.Items.Add("Edit", null, Edit_Click);
            peopleMenu.Items.Add("Delete", null, Delete_Click);
            peopleMenu.Items.Add("-");
            peopleMenu.Items.Add("Send Email", null, SendEmail_Click);
            peopleMenu.Items.Add("Phone Call", null, PhoneCall_Click);

            usrManagePeople.GridContextMenu = peopleMenu;
        }

        private void ShowDetails_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Show Details Will Be Here");
        }
        private void AddNewPerson_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add New Person Will Be Here");
        }
        private void Edit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edit Will Be Here");
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete Will Be Here");
        }
        private void SendEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Send Email Will Be Here");
        }
        private void PhoneCall_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phone Call Will Be Here");
        }

    }
}