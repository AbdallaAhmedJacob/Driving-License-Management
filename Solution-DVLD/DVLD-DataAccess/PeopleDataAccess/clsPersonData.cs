using System;
using System.Data;
using System.Data.SqlClient;
using DVLD_DataAccess.Settings;

namespace DVLD.DataAccess.PeopleDataAccess
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
        public static bool GetPersonByID(ref int personID,
                                         ref string nationalNo,
                                         ref string firstName,
                                         ref string secondName,
                                         ref string thirdName,
                                         ref string lastName,
                                         ref string gendor,
                                         ref DateTime dateOfBirth,
                                         ref string address,
                                         ref string phoneNumber,
                                         ref string email,
                                         ref short CountryID,
                                         ref string notes,
                                         ref string imagePath)
        {
            bool IsFound = false;
            if (personID == -1) return false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string sql = @"SELECT * FROM tblPeople WHERE PersonID = @PersonID";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@PersonID", personID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    personID = (int)reader["PersonID"];
                    nationalNo = (string)reader["NationalNo"];
                    firstName = (string)reader["FirstName"];
                    secondName = (string)reader["SecondName"];
                    thirdName = (string)reader["ThirdName"];
                    lastName = (string)reader["LastName"];
                    gendor = (string)reader["Gendor"];
                    dateOfBirth = (DateTime)reader["DateOfBirth"];
                    address = (string)reader["Address"];
                    phoneNumber = (string)reader["PhoneNumber"];
                    email = (string)reader["Email"];
                    CountryID = (short)reader["CountryID"];
                    notes = (reader["Notes"] == DBNull.Value) ? "" : (string)reader["Notes"];
                    imagePath = (reader["ImagePath"] == DBNull.Value) ? "" : (string)reader["ImagePath"];
                    return true;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }
        public static int AddNewPerson(string nationalNo,
                                       string firstName,
                                       string secondName,
                                       string thirdName,
                                       string lastName,
                                       string gendor,
                                       DateTime dateOfBirth,
                                       string address,
                                       string phoneNumber,
                                       string email,
                                       short countryID,
                                       string notes,
                                       string imagePath)
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

        public static bool UpdatePerson(int PersonID,
                                        string nationalNo,
                                        string firstName,
                                        string secondName,
                                        string thirdName,
                                        string lastName,
                                        string gendor,
                                        DateTime dateOfBirth,
                                        string address,
                                        string phoneNumber,
                                        string email,
                                        short countryID,
                                        string notes,
                                        string imagePath)
        {
            bool IsUpdated = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string sql = @"UPDATE tblPeople
                            SET NationalNo = @NationalNo,   
                                FirstName = @FirstName,    
                                SecondName = @SecondName,   
                                ThirdName = @ThirdName,   
                                LastName = @LastName,     
                                Gendor = @Gendor,       
                                DateOfBirth = @DateOfBirth, 
                                Address = @Address,      
                                PhoneNumber = @PhoneNumber,   
                                Email = @Email,        
                                CountryID = @CountryID,   
                                Notes = @Notes,        
                                ImagePath = @ImagePath   
                            WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
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
                int result = command.ExecuteNonQuery();
                if (result != 0)
                {
                    IsUpdated = true;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return IsUpdated;
        }
        public static bool IsExistNationalNo(string nationalNo)
        {
            bool IsExist = false;
            if (nationalNo == "") return false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
            string sql = @"SELECT FOUND = 1 FROM tblPeople WHERE nationalNo = @nationalNo";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@nationalNo", nationalNo);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null) IsExist = true;
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return IsExist;
        }
    }
}
