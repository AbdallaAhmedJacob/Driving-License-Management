using DVLD.Business.People;
using DVLD.WinForms.UI;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD.WinForms.Forms.People
{
    public partial class frmListPeople : frmBase
    {
        DataTable _dtPeople = clsPerson.GetAllPeople();

        public frmListPeople()
        {
            InitializeComponent();
        }

        private void usrManagePeople_Load(object sender, EventArgs e)
        {
            pnlGenderFilter.Visible = false;
            dtpDateFilter.Visible = false;
            dtpDateFilter.MaxDate = DateTime.Now;

            LoadPeopleData();
        }

        private void LoadPeopleData()
        {
            usrManagePeople.NumericFilterFields = new string[] { "Person ID", "Phone" };
            usrManagePeople.DataSource = _dtPeople;
            usrManagePeople.RecordsCount = _dtPeople.Rows.Count;
            usrManagePeople.PopulateFilterOptionsFromGrid();
            PopulateContextMenuStrip();

            usrManagePeople.SearchTextChanged += usrManagePeople_SearchTextChanged;
            usrManagePeople.FilterByIndexChanged += usrManagePeople_FilterByIndexChanged;
        }

        private void usrManagePeople_SearchTextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void usrManagePeople_FilterByIndexChanged(object sender, EventArgs e)
        {
            string filterColumn = usrManagePeople.SelectedFilterItem?.ToString();
            usrManagePeople.SearchText = "";
            rdMale.Checked = false; 
            rdFemale.Checked = false;

            switch (filterColumn)
            {
                case "None":
                    usrManagePeople.IsSearchTextBoxVisible = false;
                    pnlGenderFilter.Visible = false;
                    dtpDateFilter.Visible = false;
                    break;
                case "Person ID":
                    pnlGenderFilter.Visible = false;
                    dtpDateFilter.Visible = false;

                    usrManagePeople.IsSearchTextBoxVisible = true;
                    break;
                case "Gender":
                    usrManagePeople.IsSearchTextBoxVisible = false;
                    dtpDateFilter.Visible = false;
                    
                    pnlGenderFilter.Dock = DockStyle.Fill;
                    usrManagePeople.FilterContainer.Controls.Add(pnlGenderFilter);
                    pnlGenderFilter.Visible = true;
                    break;
                case "Date Of Birth":
                    usrManagePeople.IsSearchTextBoxVisible = false;
                    pnlGenderFilter.Visible = false;

                    dtpDateFilter.Dock = DockStyle.Fill;
                    usrManagePeople.FilterContainer.Controls.Add(dtpDateFilter);
                    dtpDateFilter.Visible = true;
                    break;
                default:
                    pnlGenderFilter.Visible = false;
                    dtpDateFilter.Visible = false;
                    usrManagePeople.IsSearchTextBoxVisible = true;
                    break;
            }
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            if (_dtPeople == null) return;

            string filterColumn = usrManagePeople.SelectedFilterItem?.ToString();
            string filterValue = "";

            if (filterColumn == "None")
            {
                _dtPeople.DefaultView.RowFilter = "";
            }
            else
            {
                switch (filterColumn)
                {
                    case "Person ID":
                        filterValue = usrManagePeople.SearchText.Trim();

                        usrManagePeople.IsSearchTextBoxVisible = true;
                        if (filterValue is int)
                            _dtPeople.DefaultView.RowFilter = $"[{filterColumn}] = {filterValue}";
                        break;
                    case "Gender":
                        if (rdMale.Checked)
                            _dtPeople.DefaultView.RowFilter = $"[{filterColumn}] = 'Male'";
                        else if(rdFemale.Checked)
                            _dtPeople.DefaultView.RowFilter = $"[{filterColumn}] = 'Female'";
                        break;
                    case "Date Of Birth":
                        filterValue = dtpDateFilter.Value.ToString("MM/dd/yyyy");
                        _dtPeople.DefaultView.RowFilter = $"[{filterColumn}] = #{filterValue}#";
                        break;
                    default:
                        filterValue = usrManagePeople.SearchText.Trim();

                        _dtPeople.DefaultView.RowFilter = $"[{filterColumn}] LIKE '%{filterValue}%'";
                        break;
                }
            }

            usrManagePeople.RecordsCount = _dtPeople.DefaultView.Count;
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


        private void dtpDateFilter_ValueChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void rdMale_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                ApplyFilter();
            }
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