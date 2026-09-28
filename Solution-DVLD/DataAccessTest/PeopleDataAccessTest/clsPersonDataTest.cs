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
    }
}
