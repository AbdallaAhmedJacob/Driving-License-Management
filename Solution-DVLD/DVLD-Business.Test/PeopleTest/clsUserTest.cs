using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD.Business.People;

namespace DVLD_Business.Test.PeopleTest
{
    internal class clsUserTest
    {
        internal static void AddNewUser_AddUserData_ReturnUserID()
        {
            clsPerson person = clsPerson.FindPersonByID(80);
            clsUser user = new clsUser(clsUser.enMode.AddNew, person, -1, "user4", "1234", -1, true);


            Console.WriteLine(user.Save());
            Console.WriteLine(user.UserID);
        }
    }
}
