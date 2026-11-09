using DVLD.Business.People;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business.Test.PeopleTest
{
    internal class clsUserTest
    {
        internal static void GetAllUsersTest_ReurnAllUsersData()
        {
            DataTable dtUsers = clsUser.GetAllUsers();

            foreach (DataRow row in dtUsers.Rows)
            {
                for (int i = 0; i < dtUsers.Columns.Count; i++)
                {
                    Console.Write($"{row[i].ToString().Trim()} | ");
                }
                Console.Write("\n");
            }
        }

        internal static void AddNewUser_AddUserData_ReturnUserID()
        {
            clsUser user = new clsUser();
            user.Mode = clsUser.enMode.AddNew;
            user.PersonID = 89;
            user.UserName = "user6";
            user.Password = "1234";
            user.Permissions = -1;
            user.IsActive = true;


            Console.WriteLine(user.Save());
            Console.WriteLine(user.UserID);
        }
    }
}
