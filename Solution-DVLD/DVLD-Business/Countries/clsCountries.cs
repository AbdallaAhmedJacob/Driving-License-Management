using System;
using System.Data;
using DVLD.DataAccess.CountriesDataAccess;

namespace DVLD.Business.Countries
{
    public class clsCountries
    {
        public static DataTable GetAllCountries()
        {
            return clsCountriesDataAccess.GetAllCountries();
        }
    }
}
