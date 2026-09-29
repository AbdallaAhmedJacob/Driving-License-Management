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
    }
}
