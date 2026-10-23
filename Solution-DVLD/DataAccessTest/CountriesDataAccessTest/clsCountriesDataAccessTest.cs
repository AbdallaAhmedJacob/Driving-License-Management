using DVLD.DataAccess.CountriesDataAccess;
using System;
using System.Data;

namespace DataAccessTest
{
    internal class clsCountriesDataAccessTest
    {
        internal static void GetAllContris_ReturnAllCountries()
        {
            DataTable dtCountries = clsCountriesDataAccess.GetAllCountries();

            foreach (DataRow row in dtCountries.Rows)
            {
                for (int i = 0; i < dtCountries.Columns.Count; i++)
                {
                    Console.Write($"{row[i].ToString().Trim()} | ");
                }
                Console.Write("\n");
            }
        }
    }
}
