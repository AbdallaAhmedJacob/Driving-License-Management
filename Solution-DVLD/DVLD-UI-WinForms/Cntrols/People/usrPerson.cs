using System;
using System.Data;
using System.Windows.Forms;
using DVLD.Business.Country;
using DVLD.Business.People;

namespace DVLD.WinForms.Cntrols.People
{
    public partial class usrPerson : UserControl
    {
        public int PersonID = -1;
        private clsPerson _Person;
        public usrPerson()
        {
            InitializeComponent();
            _Load_usrPerson();
            _LoadPersonData();
        }

        private void _Load_usrPerson()
        {
            txtFerstName.Focus();
            rbMale.Checked = true;
            _FillCountryInComboBox();
            _PopulatedtpDateOfBirth();
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

        private void _LoadPersonData()
        {
            if (PersonID < 0) return;

            // ID
            _Person = clsPerson.FindPersonByID(PersonID);

            // Name

            gpContainer.Text = $"ID: {PersonID}";
            txtFerstName.Text = _Person.FirstName.ToString();
            txtSecondName.Text = _Person.SecondName.ToString();
            txtThirdName.Text = _Person.ThirdName.ToString();
            txtLastName.Text = _Person.LastName.ToString();

            // National NO
            
            txtNationalNO.Text = _Person.NationalNo.ToString();

            // Contact Info

            txtPhonNumber.Text = _Person.PhoneNumber.ToString();
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

            rtbAddress.Text = _Person.Address;

            // Image

            if (string.IsNullOrEmpty(_Person.ImagePath))
                pbImage.Load(_Person.ImagePath);
            

        }
    }
}
