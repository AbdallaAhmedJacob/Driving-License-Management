using DVLD.Business.Country;
using DVLD.Business.People;
using DVLD.WinForms.Forms;
using DVLD.WinForms.Forms.People;
using DVLD.WinForms.UI;
using System.Windows.Forms;

namespace DVLD.WinForms.Cntrols.People
{
    public partial class usrPersonCard : UserControl
    {
        clsPerson _Person = new clsPerson();

        public usrPersonCard()
        {
            InitializeComponent();
            clsUIHelper.ApplyTheme(this);
            linkEditPersonInfo.Visible = false;
        }

        public void LoadPersonData(int personID)
        {
            if (personID < 0) return;

            _Person = clsPerson.FindPersonByID(personID);

            if (_Person == null) return;

            linkEditPersonInfo.Visible = true;

            // Name

            lblPersonID.Text = _Person.PersonID.ToString();
            lblFullName.Text = _Person.FullName.ToString();            

            // National NO

            lblNationalNo.Text = _Person.NationalNo.ToString();

            // Contact Info

            lblPhone.Text = _Person.PhoneNumber.ToString();
            lblEmail.Text = _Person.Email.ToString();

            // Date Of Birth

            lblDateOfBirth.Text = _Person.DateOfBirth.ToString("yyyy-MM-dd");

            // Gender

            lblGender.Text = (_Person.Gender.ToString() == "M")? "Male" : "Female";

            // Country 

            lblCountry.Text = clsCountry.GetCountryByID(_Person.CountryID);

            // Address

            lblAddress.Text = _Person.Address;

            // Image

            if (!string.IsNullOrEmpty(_Person.ImagePath))
                pbImage.Load(_Person.ImagePath);

        }


        private void linkEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(_Person.PersonID < 1) return;
            Form form = new frmPerson(_Person.PersonID, clsPerson.enMode.Update);
            form.ShowDialog();
            LoadPersonData(_Person.PersonID);
        }
    }
}
