using DVLD.DataAccess.CountryDataAccess;
using System;
using System.Data;

namespace DataAccessTest
{
    internal class clsCountryDataAccessTest
    {
        internal static void GetAllContris_ReturnAllCountry()
        {
            DataTable dtCountry = clsCountryDataAccess.GetAllCountry();

            foreach (DataRow row in dtCountry.Rows)
            {
                for (int i = 0; i < dtCountry.Columns.Count; i++)
                {
                    Console.Write($"{row[i].ToString().Trim()} | ");
                }
                Console.Write("\n");
            }
        }
    }
}
