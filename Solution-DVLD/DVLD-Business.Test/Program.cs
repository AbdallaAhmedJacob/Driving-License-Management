using DataAccessTest;
using DVLD.Business.Countries;
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
            //clsPersonTest.Delete_SetPersonID_ReturnBoolean(10);
            clsCountriesTest.GetAllContris_ReturnAllCountries();
        }
    }
}
