using System;
using System.Data;
using System.Data.SqlClient;
using DVLD_DataAccess.Settings;


namespace DataAccessTest.Settings
{
    internal class Settings
    {
        public static void TestConnection()
        {
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            try
            {
                connection.Open();

                Console.WriteLine("Connection Successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
