using DVLD.DataAccess.PeopleDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.DataAccess.Test.PeopleDataAccessTest
{
    public class clsUserDataTest
    {
        internal static void GetAllUsersTest_ReturnAllUsersData()
        {
            DataTable dtUsers = clsUserData.GetAllUsers();

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
            Console.WriteLine(clsUserData.AddNewUser(4, "user2", "1234", -1, true));
        }

        internal static void IsExsitsUserName_SetUserName_ReturnBoolean(string userName)
        {
            Console.WriteLine(clsUserData.IsExistUserName(userName));
        }

    }
}
