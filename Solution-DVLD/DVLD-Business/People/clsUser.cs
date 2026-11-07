using DVLD.Business.Helpers;
using DVLD.DataAccess.PeopleDataAccess;
using DVLD.Shared.Validation.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.Business.People
{
    public class clsUser
    {
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode = enMode.AddNew;

        public clsPerson person = new clsPerson();
        public int UserID {  get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Permissions { get; set; }
        public bool IsActive { get; set; }

        public clsUser(enMode mode, clsPerson person, int userID, string userName, string password, int permissions, bool isActive)
        {
            Mode = mode;
            this.person = person;
            UserID = userID;
            UserName = userName;
            Password = password;
            Permissions = permissions;
            IsActive = isActive;
        }

        private int _AddNewUser()
        {
            if(clsPersonData.IsLinkedToUser(this.person.PersonID))
            {
                // ex
                return -1;
            }

            if(clsUserData.IsExistUserName(this.UserName))
            {
                // ex

                return -1;
            }

            this.UserID = clsUserData.AddNewUser(this.person.PersonID,
                                                 this.UserName,
                                                 this.Password,
                                                 this.Permissions,
                                                 this.IsActive);
            if (this.UserID != -1)
                this.Mode = enMode.Update;

            return this.UserID;
        }

        public bool Save()
        {
            
            switch (this.Mode)
            {
                case enMode.AddNew:
                    return (this._AddNewUser() != -1);
                case enMode.Update:
                    //return (this._UpdateUser());
                default: return false;
            }
        }
    }
}
