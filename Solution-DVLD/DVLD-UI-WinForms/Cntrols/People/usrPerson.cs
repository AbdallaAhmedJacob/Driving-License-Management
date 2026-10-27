using DVLD.Business.Country;
using DVLD.Business.People;
using DVLD.WinForms.Forms.People;
using DVLD.WinForms.UI;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD.WinForms.Cntrols.People
{
    public partial class usrPerson : UserControl
    {
        public enum enMode { AddNew = 0, Update = 1, ShowDetails = 2 };

        private enMode _Mode = enMode.AddNew;
        private int _PersonID = -1;
        private clsPerson _Person;
        public usrPerson()
        {
            InitializeComponent();
            clsUIHelper.ApplyTheme(this);
            _Load_usrPerson();
        }

        private void _Load_usrPerson()
        {
            txtFirstName.Focus();
            rbMale.Checked = true;
            _FillCountryInComboBox();
            _PopulatedtpDateOfBirth();
        }

        public void LoadInfo(int personID, enMode mode)
        {
            _PersonID = personID;
            _Mode = mode;

            switch (_Mode)
            {
                case enMode.AddNew:
                    usrHeader.Text = "Add New Person";
                    _ClearFields();
                    break;

                case enMode.Update:
                    usrHeader.Text = "Update Person Info";
                    _LoadPersonData(_PersonID);
                    _EnableControls(true);
                    break;

                case enMode.ShowDetails:
                    _LoadPersonData(_PersonID);
                    _ConfigureForShowDetails();
                    break;
            }
        }

        private void _ClearFields()
        {
            gpContainer.Text = "ID: N/A";
            txtFirstName.Clear();
            txtSecondName.Clear();
            txtThirdName.Clear();
            txtLastName.Clear();
            txtNationalNo.Clear();
            txtPhoneNumber.Clear();
            txtEmail.Clear();
            txtAddress.Clear();

            dtpDateOfBirth.Value = DateTime.Now.AddYears(-16);
            rbMale.Checked = false;
            rbFemale .Checked = false;
            cbCountry.SelectedValue = 190;

            linkSetImage.Visible = false;
            btnSave.Visible = false;
        }

        private void _EnableControls(bool isEnabled)
        {
            txtFirstName.Enabled = isEnabled;
            txtSecondName.Enabled = isEnabled;
            txtThirdName.Enabled = isEnabled;
            txtLastName.Enabled = isEnabled;
            txtNationalNo.Enabled = isEnabled;
            txtPhoneNumber.Enabled = isEnabled;
            txtEmail.Enabled = isEnabled;
            txtAddress.Enabled = isEnabled;

            dtpDateOfBirth.Enabled = isEnabled;
            rbMale.Enabled = isEnabled;
            rbFemale.Enabled = isEnabled;
            cbCountry.Enabled = isEnabled;

            linkSetImage.Visible = isEnabled;
            btnSave.Visible = isEnabled;
        }

        private void _FillCountryInComboBox()
        {
            cbCountry.Items.Clear();
            DataTable dtCountry = clsCountry.GetAllCountry();
            cbCountry.DataSource = dtCountry;
            cbCountry.DisplayMember = "CountryName";
            cbCountry.ValueMember = "CountryID";
            cbCountry.SelectedIndex = 190;
        }

        private void _PopulatedtpDateOfBirth()
        {
            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-16);
        }

        private void _LoadPersonData(int personID)
        {
            if (personID < 0) return;

            // ID
            _Person = clsPerson.FindPersonByID(personID);

            // Name

            gpContainer.Text = $"ID: {personID}";
            txtFirstName.Text = _Person.FirstName.ToString();
            txtSecondName.Text = _Person.SecondName.ToString();
            txtThirdName.Text = _Person.ThirdName.ToString();
            txtLastName.Text = _Person.LastName.ToString();

            // National NO

            txtNationalNo.Text = _Person.NationalNo.ToString();

            // Contact Info

            txtPhoneNumber.Text = _Person.PhoneNumber.ToString();
            txtEmail.Text = _Person.Email.ToString();

            // Date Of Birth

            dtpDateOfBirth.Value = _Person.DateOfBirth;

            // Gender

            if (_Person.Gender == "Male")
                rbMale.Checked = true;
            else
                rbMale.Checked = true;

            // Country 

            cbCountry.SelectedValue = _Person.CountryID;

            // Address

            txtAddress.Text = _Person.Address;

            // Image

            if (!string.IsNullOrEmpty(_Person.ImagePath))
                pbImage.Load(_Person.ImagePath);

        }

        private void _ConfigureForShowDetails()
        {
            _Mode = enMode.ShowDetails;

            _LoadPersonData(_PersonID);

            txtFirstName.Enabled = false;
            txtSecondName.Enabled = false;
            txtThirdName.Enabled = false;
            txtLastName.Enabled = false;
            txtNationalNo.Enabled = false;
            txtPhoneNumber.Enabled = false;
            txtEmail.Enabled = false;
            txtAddress.Enabled = false;

            dtpDateOfBirth.Enabled = false;
            rbMale.Enabled = false;
            rbFemale.Enabled = false;
            cbCountry.Enabled = false;

            linkSetImage.Visible = false;
            btnSave.Visible = false;

             usrHeader.Title = "Person Details";
        }

        public event EventHandler CloseClick;

        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseClick?.Invoke(this, e);
            this.FindForm()?.Close();
        }

        public event EventHandler SavedClick;

        private void btnSave_Click(object sender, EventArgs e)
        {
            SavedClick?.Invoke(this, e);
            this.FindForm()?.Close();
        }
    }
}