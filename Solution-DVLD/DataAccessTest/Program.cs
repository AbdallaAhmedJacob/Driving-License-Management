using DataAccessTest;
using DVLD.DataAccess.CountryDataAccess;
using DVLD.DataAccess.PeopleDataAccess;
using DVLD.DataAccess.Test.PeopleDataAccessTest;
using System;

namespace DataAccessTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Settings.TestConnection();
            //clsPersonDataTest.GetAllPeopleTest();  
            //clsPersonDataTest.AddNewPerson_PersonData_PersonID();
            //clsPersonDataTest.UpdatePerson_EditPersonData_Return1();
            //Console.WriteLine(clsPersonDataTest.GetPersonByID_SetPersonID_ReturnPersonData(4));
            //Console.WriteLine(clsPersonDataTest.IsExist_SetNationalNo_ReturnBoolean("N001"));
            //Console.WriteLine(clsPersonDataTest.DeletePersonByID_SetPersonID_ReturnBoolean(12));
            //clsCountryDataAccessTest.GetAllContris_ReturnAllCountry();
            //clsPersonDataTest.GetPersonByNationalNo_SetNationalNo_ReturnPersonData("N1");
            //clsPersonDataTest.IsLinked_SetPersonID_ReturnBooleanResult(1);
            //clsPersonDataTest.IsLinked_SetPersonID_ReturnBooleanResult(7);
            //clsUserDataTest.AddNewUser_AddUserData_ReturnUserID();
            //clsPersonDataTest.IsLinkedToUser_SetPersonID_ReturnBooleanResult(1);
            clsUserDataTest.IsExsitsUserName_SetUserName_ReturnBoolean("user2");


        }
    }
}
