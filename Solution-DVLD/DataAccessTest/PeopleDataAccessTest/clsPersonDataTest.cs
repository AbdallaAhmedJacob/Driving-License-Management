using DVLD.DataAccess.PeopleDataAccess;
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
        internal static bool GetPersonByID_SetPersonID_ReturnPersonData(int PersonID)
        {
            int personID = PersonID;
            string nationalNo = "";
            string firstName = "";
            string secondName = "";
            string thirdName = "";
            string lastName = "";
            string gendor = "";
            DateTime dateOfBirth = DateTime.Now;
            string address = "";
            string phoneNumber = "";
            string email = "";
            short CountryID = -1;
            string notes = "";
            string imagePath = "";

            if (clsPersonData.GetPersonByID(ref personID,
                                               ref nationalNo,
                                               ref firstName,
                                               ref secondName,
                                               ref thirdName,
                                               ref lastName,
                                               ref gendor,
                                               ref dateOfBirth,
                                               ref address,
                                               ref phoneNumber,
                                               ref email,
                                               ref CountryID,
                                               ref notes,
                                               ref imagePath))
            {
                Console.WriteLine(PersonID);
                Console.WriteLine(nationalNo);
                Console.WriteLine(firstName);
                Console.WriteLine(secondName);
                Console.WriteLine(thirdName);
                Console.WriteLine(lastName);
                Console.WriteLine(gendor);
                Console.WriteLine(dateOfBirth);
                Console.WriteLine(address);
                Console.WriteLine(phoneNumber);
                Console.WriteLine(email);
                Console.WriteLine(CountryID);
                Console.WriteLine(notes);
                Console.WriteLine(imagePath);
                return true;
            }
            else
                return false;
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
        internal static void UpdatePerson_EditPersonData_Return1()
        {
            int personID = 12;
            string nationalNo = "N012";
            string firstName = "Slah";
            string secondName = "Ali";
            string thirdName = "Ahmed";
            string lastName = "Sood";
            string gendor = "M";
            DateTime dateOfBirth = DateTime.Now.AddYears(-20);
            string address = "456 Oak Avenue, London, UK";
            string phoneNumber = "987654321";
            string email = "Sood@e.c";
            short countryID = 7;
            string notes = "";
            string imagePath = "";

            bool result = clsPersonData.UpdatePerson(personID,
                                                  nationalNo,
                                                  firstName,
                                                  secondName,
                                                  thirdName,
                                                  lastName,
                                                  gendor,
                                                  dateOfBirth,
                                                  address,
                                                  phoneNumber,
                                                  email,
                                                  countryID,
                                                  notes,
                                                  imagePath);

            Console.WriteLine(result);
        }
        internal static bool IsExist_SetNationalNo_ReturnBoolean(string nationalNo)
        {
            return clsPersonData.IsExistNationalNo(nationalNo);
        }
        internal static bool DeletePersonByID_SetPersonID_ReturnBoolean(int personID)
        {
            return clsPersonData.DeletePersonByID(personID);
        }
    }
}
