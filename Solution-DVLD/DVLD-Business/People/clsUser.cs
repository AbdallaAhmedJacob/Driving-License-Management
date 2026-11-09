using DVLD.Business.Helpers;
using DVLD.DataAccess.PeopleDataAccess;
using DVLD.Shared.Utile;
using DVLD.Shared.Validation.People;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.Business.People
{
    public class clsUser
    {
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode = enMode.AddNew;

        public int UserID {  get; set; }
        public int PersonID {  get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Permissions { get; set; }
        public bool IsActive { get; set; }
        public clsUser()
        {
            Mode = enMode.AddNew;
            PersonID = -1;
            UserID = -1;
            UserName = "";
            Password = "";
            Permissions = 0;
            IsActive = true;
        }

        private clsUser(enMode mode,
                       int person,
                       int userID,
                       string userName,
                       string password,
                       int permissions,
                       bool isActive)
        {
            Mode = mode;
            PersonID = person;
            UserID = userID;
            UserName = userName;
            Password = password;
            Permissions = permissions;
            IsActive = isActive;
        }

        public static DataTable GetAllUsers()
        {
            DataTable dtUsers = clsUserData.GetAllUsers();
            clsUtile.TrimDataTableStrings(ref dtUsers);
            return dtUsers;
        }

        private int _AddNewUser()
        {
            if (this == null)
            {
                return -1;
                // ex
            }

            if(clsPersonData.IsLinkedToUser(PersonID))
            {
                // ex
                return -1;
            }

            if(clsUserData.IsExistUserName(this.UserName))
            {
                // ex

                return -1;
            }

            this.UserID = clsUserData.AddNewUser(this.PersonID,
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
