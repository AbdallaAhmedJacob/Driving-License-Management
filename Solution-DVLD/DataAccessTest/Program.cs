using DataAccessTest;
using DVLD.DataAccess.CountriesDataAccess;
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
            clsCountriesDataAccessTest.GetAllContris_ReturnAllCountries();



        }
    }
}
