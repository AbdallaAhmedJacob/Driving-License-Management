using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD.DataAccess.PeopleDataAccess;

namespace DVLD.DataAccess.Test.PeopleDataAccessTest
{
    public class clsUserDataTest
    {
        internal static void AddNewUser_AddUserData_ReturnUserID()
        {
            Console.WriteLine(clsUserData.AddNewUser(4, "user2", "1234", -1, true));
        }
    }
}
