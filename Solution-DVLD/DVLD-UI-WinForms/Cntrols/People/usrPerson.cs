using DVLD.Business.Country;
using DVLD.Business.People;
using DVLD.WinForms.Forms.People;
using DVLD.WinForms.UI;
using DVLD.Shared.Validation.People;
using System;
using System.ComponentModel;
using System.Data;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD.WinForms.Cntrols.People
{
    public partial class usrPerson : UserControl
    {
        public enum enMode { AddNew = 0, Update = 1, ShowDetails = 2 };

        private enMode _Mode = enMode.AddNew;
        private clsPerson _Person = new clsPerson();
        public usrPerson()
        {
            InitializeComponent();
            clsUIHelper.ApplyTheme(this);
            _Load_usrPerson();
        }

        // ===================================
        // Load
        // ===================================

        private void _Load_usrPerson()
        {
            txtFirstName.Focus();
            rbMale.Checked = true;
            _FillCountryInComboBox();
            _PopulatedtpDateOfBirth();
        }

        public void LoadInfo(int personID, enMode mode)
        {
            _Mode = mode;

            switch (_Mode)
            {
                case enMode.AddNew:
                    usrHeader.Text = "Add New Person";
                    _ClearFields();
                    btnSave.Visible = true;
                    linkSetImage.Visible = true;
                    break;
                case enMode.Update:
                    usrHeader.Text = "Edit Person Info";
                    _LoadPersonData(personID);
                    _EnableControls(true);
                    btnSave.Visible = true;
                    linkSetImage.Text = "Change Image";
                    linkSetImage.Visible = true;
                    break;
                case enMode.ShowDetails:
                    _LoadPersonData(personID);
                    _ConfigureForShowDetails();
                    break;
            }
        }

        private void _LoadPersonData(int personID)
        {
            if (personID < 0) return;

            _Person = clsPerson.FindPersonByID(personID);

            if (_Person == null) return;
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
                rbFemale.Checked = true;

            // Country 

            cbCountry.SelectedValue = _Person.CountryID;

            // Address

            txtAddress.Text = _Person.Address;

            // Image

            if (!string.IsNullOrEmpty(_Person.ImagePath))
                pbImage.Load(_Person.ImagePath);

        }

        // ===================================
        // Helpers
        // ===================================

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

            dtpDateOfBirth.Value.AddYears(-16);
            rbMale.Checked = true;
            rbFemale.Checked = false;
            cbCountry.SelectedValue = 191;

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

        private void _ConfigureForShowDetails()
        {
            _Mode = enMode.ShowDetails;

            _LoadPersonData(_Person.PersonID);

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

        private void _FillPersonData()
        {
            // Name
            _Person.FirstName = txtFirstName.Text;
            _Person.SecondName = txtSecondName.Text;
            _Person.ThirdName = txtThirdName.Text;
            _Person.LastName = txtLastName.Text;

            // National NO
            _Person.NationalNo = txtNationalNo.Text;

            // Contact Info
            _Person.PhoneNumber = txtPhoneNumber.Text;
            _Person.Email = txtEmail.Text;

            // Date Of Birth
            _Person.DateOfBirth = dtpDateOfBirth.Value;

            // Gender
            if (rbMale.Checked)
                _Person.Gender = "M";
            else if (rbFemale.Checked)
                _Person.Gender = "F";

            // Country 
            _Person.CountryID = (short)cbCountry.SelectedValue;

            // Address
            _Person.Address = txtAddress.Text;

            // Image

            if (!string.IsNullOrEmpty(_Person.ImagePath))
                _Person.ImagePath = pbImage.ImageLocation;

        }

        // ===================================
        // Manage Person
        // ===================================

        private void _AddNewPerson()
        {
            if (_Person.Save())
            {
                MessageBox.Show("Person Saved Saccessfuly", "Saccessfuly", MessageBoxButtons.OK);
                _Mode = enMode.Update;
                usrHeader.Title = "Edit Person Info";
                LoadInfo(_Person.PersonID, _Mode);
            }
            else
            {
                MessageBox.Show("Error: Data Was not Saved Saccessfuly", "Fiald", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _UpdatePerson()
        {
            if (_Person.Save())
            {
                MessageBox.Show("Person Updated Saccessfuly");
                _Mode = enMode.Update;
                LoadInfo(_Person.PersonID, _Mode);
            }
            else
            {
                MessageBox.Show("Error: Data Was not Updated Saccessfuly", "Fiald", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _Save()
        {
            _FillPersonData();
            if (!clsPersonValidation.ValidatePersonInfo(_Person.NationalNo,
                                                        _Person.FirstName,
                                                        _Person.SecondName,
                                                        _Person.ThirdName,
                                                        _Person.LastName,
                                                        _Person.Gender,
                                                        _Person.DateOfBirth,
                                                        _Person.Address,
                                                        _Person.PhoneNumber,
                                                        _Person.Email,
                                                        _Person.CountryID,
                                                        _Person.Notes,
                                                        _Person.ImagePath,
                                                        out string errorMessage))
            {
                MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (_Mode)
            {
                case enMode.AddNew:
                    _AddNewPerson();
                    break;
                case enMode.Update:
                    _UpdatePerson();
                    break;
            }
        }

        // ===================================
        // Validation
        // ===================================

        private void txtTextBox_Validating(object sender, CancelEventArgs e)
        {
            Control tempControl = sender as Control;
            if (sender is TextBox)
            {
                tempControl = (TextBox)sender;
            }
            else if (sender is RichTextBox)
            {
                tempControl = (RichTextBox)sender;
            }

            if (string.IsNullOrWhiteSpace(tempControl.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(tempControl, "This field is required!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tempControl, "");
            }

        }
        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {
            Control tempControl = sender as TextBox;

            if (string.IsNullOrWhiteSpace(tempControl.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(tempControl, "This field is required!");
            }
            else if(clsPerson.IsExistNationalNo(tempControl.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(tempControl, "National Number Used by Another Person!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tempControl, "");
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                e.Cancel = false;
                errorProvider.SetError(txtEmail, "");
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(txtEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                e.Cancel = true;
                txtEmail.Focus();
                errorProvider.SetError(txtEmail, "Invalid Email Address Format!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtEmail, "");
            }
        }

        // ===================================
        // Events
        // ===================================

        public event EventHandler CloseClick;

        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseClick?.Invoke(this, e);
            this.FindForm()?.Close();
        }

        public event EventHandler SavedClick;

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Save();
            SavedClick?.Invoke(this, e);
            //this.FindForm()?.Close();
        }
    }
}