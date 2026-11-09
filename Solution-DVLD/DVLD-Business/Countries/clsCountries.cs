using System;
using System.Data;
using DVLD.DataAccess.CountryDataAccess;

namespace DVLD.Business.Country
{
    public class clsCountry
    {
        public static DataTable GetAllCountry()
        {
            return clsCountryDataAccess.GetAllCountry();
        }

        public static string GetCountryByID(short CountryID)
        {
            return clsCountryDataAccess.GetCountryByID(CountryID);
        }
    }
}
