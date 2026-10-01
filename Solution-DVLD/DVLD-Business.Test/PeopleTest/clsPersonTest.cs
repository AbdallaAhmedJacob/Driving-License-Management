using DVLD_Business.People;
using System;
using System.Data;

namespace DVLD_Business.Test
{
    internal class clsPersonTest
    {
        internal static void GetAllPeopleTest()
        {
            DataTable dtPeople = clsPerson.GetAllPeople();

            foreach (DataRow row in dtPeople.Rows)
            {
                for (int i = 0; i < dtPeople.Columns.Count; i++)
                {
                    Console.Write($"{row[i].ToString().Trim()} | ");
                }
                Console.Write("\n");
            }
        }

        internal static void AddNewPerson_AddPersonData_ReturnPersonID()
        {
            clsPerson person = new clsPerson();
            person.NationalNo = "N014";
            person.FirstName = "Ali";
            person.SecondName = "Slah";
            person.ThirdName = "Ahmed";
            person.LastName = "Qasm";
            person.Gendor = "M";
            person.DateOfBirth = DateTime.Now.AddYears(-20);
            person.Address = "A, Y, N";
            person.PhoneNumber = "987654321";
            person.Email = "lml@e.c";
            person.CountryID = 100;
            person.Notes = "";
            person.ImagePath = "";

            Console.WriteLine(person.Save());
        }
    }
}