using System;
using System.Data;
using System.Data.SqlClient;
using DVLD.DataAccess.Settings;

namespace DVLD.DataAccess.CountryDataAccess
{
    public class clsCountryDataAccess
    {
        public static DataTable GetAllCountry()
        {
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string sql = @"SELECT * FROM tblCountries";
            SqlCommand command = new SqlCommand(sql, connection);
            DataTable dtCountries = new DataTable();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.HasRows)
                {
                    dtCountries.Load(reader);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return dtCountries;
        }

        public static string GetCountryByID(short countryID)
        {
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string sql = @"SELECT CountryName FROM tblCountries
                           WHERE CountryID = @CountryID";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@CountryID", countryID);
            string countryName = "";

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                countryName = result.ToString().Trim();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return countryName;
        }
    }
}
