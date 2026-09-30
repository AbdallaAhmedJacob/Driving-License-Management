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
        public static int AddNewPerson(string nationalNo, string firstName, string secondName, string thirdName,
        string lastName, string gendor, DateTime dateOfBirth, string address, string phoneNumber, 
        string email, short countryID, string notes, string imagePath)
        {
            // Validation

            int ID = -1;
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string sql = @"INSERT INTO tblPeople(
                                NationalNo, 
                                FirstName, 
                                SecondName, 
                                ThirdName,
                                LastName, 
                                Gendor, 
                                DateOfBirth,
                                Address, 
                                PhoneNumber, 
                                Email, 
                                CountryID,
                                Notes, 
                                ImagePath
                          )
                          VALUES (
                                @NationalNo, 
                                @FirstName, 
                                @SecondName, 
                                @ThirdName,
                                @LastName, 
                                @Gendor, 
                                @DateOfBirth,
                                @Address, 
                                @PhoneNumber, 
                                @Email, 
                                @CountryID,
                                @Notes, 
                                @ImagePath
                           )
                           SELECT SCOPE_IDENTITY()";
            SqlCommand command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@NationalNo", nationalNo);
            command.Parameters.AddWithValue("@FirstName", firstName);
            command.Parameters.AddWithValue("@SecondName", secondName);
            command.Parameters.AddWithValue("@ThirdName", thirdName);
            command.Parameters.AddWithValue("@LastName", lastName);
            command.Parameters.AddWithValue("@Gendor", gendor);
            command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
            command.Parameters.AddWithValue("@Address", string.IsNullOrEmpty(address) ? (object)DBNull.Value : address);
            command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
            command.Parameters.AddWithValue("@Email", string.IsNullOrEmpty(email) ? (object)DBNull.Value : email);
            command.Parameters.AddWithValue("@CountryID", countryID);
            command.Parameters.AddWithValue("@Notes", string.IsNullOrEmpty(notes) ? (object)DBNull.Value : notes);
            if (string.IsNullOrEmpty(imagePath))
                command.Parameters.AddWithValue("@imagePath", (object)DBNull.Value);
            else
                command.Parameters.AddWithValue("@imagePath", imagePath);               

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    ID = insertedID;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return ID;
        }
    }
}
