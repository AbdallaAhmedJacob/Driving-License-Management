using System;
using System.Collections.Generic;
using System.Data;
using DVLD.Business.Helpers;
using DVLD.DataAccess.PeopleDataAccess;
using DVLD.Shared.Validation.People;

namespace DVLD.Business.People
{
    public class clsPerson
    {
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode = enMode.AddNew;

        private int PersonID { get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {SecondName} {ThirdName} {LastName}";
        public string Gendor { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public short CountryID { get; set; }
        public string Notes { get; set; }
        public string ImagePath { get; set; }

        public clsPerson()
        {
            this.PersonID = -1;
            this.NationalNo = "";
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.Gendor = "M";
            this.DateOfBirth = DateTime.Now;
            this.Address = "";
            this.PhoneNumber = "";
            this.Email = "";
            this.CountryID = -1;
            this.Notes = "";
            this.ImagePath = "";

            Mode = enMode.AddNew;
        }

        private clsPerson(int personID,
                          string nationalNo,
                          string firstName,
                          string secondName,
                          string thirdName,
                          string lastName,
                          string gendor,
                          DateTime dateOfBirth,
                          string address,
                          string phoneNumber,
                          string email,
                          short countryID,
                          string notes,
                          string imagePath)
        {
            this.PersonID = personID;
            this.NationalNo = nationalNo;
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.ThirdName = thirdName;
            this.LastName = lastName;
            this.Gendor = gendor;
            this.DateOfBirth = dateOfBirth;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.CountryID = countryID;
            this.Notes = notes;
            this.ImagePath = imagePath;

            Mode = enMode.Update;
        }

        public static DataTable GetAllPeople()
        {
            return clsPersonData.GetAllPeople();
        }
        public static clsPerson FindPersonByID(int PersonID)
        {
            int personID = PersonID;
            string nationalNo = "";
            string firstName = "";
            string secondName = "";
            string thirdName = "";
            string lastName = "";
            string gendor = "";
            DateTime dateOfBirth = DateTime.Now;
            string address = "";
            string phoneNumber = "";
            string email = "";
            short countryID = -1;
            string notes = "";
            string imagePath = "";  
            
            if (clsPersonData.GetPersonByID(ref personID,
                                            ref nationalNo,
                                            ref firstName,
                                            ref secondName,
                                            ref thirdName,
                                            ref lastName,
                                            ref gendor,
                                            ref dateOfBirth,
                                            ref address,
                                            ref phoneNumber,
                                            ref email,
                                            ref countryID,
                                            ref notes,
                                            ref imagePath) 
                == false) return null;

            return new clsPerson(personID,
                                 nationalNo,
                                 firstName,
                                 secondName,
                                 thirdName,
                                 lastName,
                                 gendor,
                                 dateOfBirth,
                                 address,
                                 phoneNumber,
                                 email,
                                 countryID,
                                 notes,
                                 imagePath);
        }
        private int _AddNewPerson()
        {
            if (this.ImagePath != "")
                this.ImagePath = clsImageHelper.SavePersonImage(this.ImagePath);

            if(clsPersonData.IsExistNationalNo(this.NationalNo)) return -1;

            this.PersonID = clsPersonData.AddNewPerson(this.NationalNo, this.FirstName, this.SecondName, this.ThirdName,
                this.LastName, this.Gendor, this.DateOfBirth, this.Address,this.PhoneNumber, this.Email,
                this.CountryID, this.Notes, this.ImagePath);
            if(this.PersonID != -1) 
                this.Mode = enMode.Update;

            return this.PersonID;
        }
        private bool _UpdatePerson()
        {
            if (this.ImagePath != "")
                this.ImagePath = clsImageHelper.SavePersonImage(this.ImagePath);

            return clsPersonData.UpdatePerson(this.PersonID, this.NationalNo, this.FirstName, this.SecondName, this.ThirdName,
                this.LastName, this.Gendor, this.DateOfBirth, this.Address,this.PhoneNumber, this.Email,
                this.CountryID, this.Notes, this.ImagePath);
        }
        public bool Save()
        {
            if(!clsPersonValidation.ValidatePersonInfo(this.NationalNo, this.FirstName, this.SecondName, this.ThirdName,
                this.LastName, this.Gendor, this.DateOfBirth, this.Address, this.PhoneNumber, this.Email,
                this.CountryID, this.Notes, this.ImagePath, out string errorMassage)) return false;

            switch (this.Mode)
            {
                case enMode.AddNew:
                    return (this._AddNewPerson() != -1);
                case enMode.Update:
                    return (this._UpdatePerson());
                default: return false;
            }
        }
        public static bool IsExistNationalNo(String nationalNO)
        {
            return clsPersonData.IsExistNationalNo(nationalNO);
        }
    }
}
