using DataAccessTest;
using DVLD.Business.Country;
using DVLD_Business.Test.PeopleTest;
using System;


namespace DVLD.Business.Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //clsPersonTest.GetAllPeopleTest();
            //clsPersonTest.AddNewPerson_AddPersonData_ReturnPersonID();
            //clsPersonTest.FindPersonByID_SetPersonID_ReturnPersonObject();
            //clsPersonTest.UpdatePerson_EditPersonData_Return1();
            //clsPersonTest.IsExistNationalNo_ReturnBoolean("N009");
            //clsPersonTest.Delete_SetPersonID_ReturnBoolean(512);
            //clsCountryTest.GetAllContris_ReturnAllCountry();
            //clsPersonTest.FindPersonByNationalNo_SetPersonNationalNo_ReturnPersonObject();
            clsUserTest.AddNewUser_AddUserData_ReturnUserID();
        }
    }
}
