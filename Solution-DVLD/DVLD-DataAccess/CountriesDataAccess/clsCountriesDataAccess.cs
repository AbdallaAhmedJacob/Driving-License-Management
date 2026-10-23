using System;
using System.Data;
using System.Data.SqlClient;
using DVLD.DataAccess.Settings;

namespace DVLD.DataAccess.CountriesDataAccess
{
    public class clsCountriesDataAccess
    {
        public static DataTable GetAllCountries()
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
    }
}
