using DVLD_DataAccess.PeopleDataAccess;
using System;
using System.Data;

namespace DataAccessTest
{
    internal class clsPersonDataTest
    {
        internal static void GetAllPeopleTest()
        {
            DataTable dtPeople = clsPersonData.GetAllPeople();

            foreach (DataRow row in dtPeople.Rows)
            {
                for (int i = 0; i < dtPeople.Columns.Count; i++)
                {
                    Console.Write($"{row[i].ToString().Trim()} | ");
                }
                Console.Write("\n");
            }
        }

        internal static void AddNewPerson_PersonData_PersonID()
        {
            int personID = -1;
            string nationalNo = "N011";
            string firstName = "Slah";
            string secondName = "Ali";
            string thirdName = "Ahmed";
            string lastName = "Sood";
            string gendor = "M";
            DateTime dateOfBirth = DateTime.Now.AddYears(-20);
            string address = "X, Y, Z";
            string phoneNumber = "987654321";
            string email = "Sood@e.c";
            short countryID = 5;
            string notes = "";
            string imagePath = "";

            personID = clsPersonData.AddNewPerson(nationalNo, firstName, secondName, thirdName,
            lastName, gendor, dateOfBirth, address, phoneNumber, email,
            countryID, notes, imagePath);

            Console.WriteLine(personID);
        }
    }
}
