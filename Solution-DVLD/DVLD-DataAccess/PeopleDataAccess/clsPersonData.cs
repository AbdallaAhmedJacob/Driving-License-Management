using System;
using System.Data;
using System.Data.SqlClient;
using DVLD_DataAccess.Settings;

namespace DVLD_DataAccess.PeopleDataAccess
{
    public class clsPersonData
    {
        public static DataTable GetAllPeople()
        {
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string sql = @"SELECT * FROM vwPeople";
            SqlCommand command = new SqlCommand(sql, connection);
            DataTable dtPeople = new DataTable();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.HasRows)
                {                    
                      dtPeople.Load(reader);
                }
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                connection.Close();
            }

            return dtPeople;
        }
    }
}
