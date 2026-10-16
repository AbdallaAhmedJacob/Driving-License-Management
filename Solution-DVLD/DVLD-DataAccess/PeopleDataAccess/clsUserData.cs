//using System;
//using System.Data;
//using System.Data.SqlClient;
//using DVLD_DataAccess.Settings;

//namespace DVLD.DataAccess.PeopleDataAccess
//{
//    public class clsUserData
//    {
//        public static DataTable GetAllUsers()
//        {
//            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
//            string sql = @"SELECT * FROM vwUsers";
//            SqlCommand command = new SqlCommand(sql, connection);
//            DataTable dtUsers = new DataTable();

//            try
//            {
//                connection.Open();
//                SqlDataReader reader = command.ExecuteReader();
//                while (reader.HasRows)
//                {
//                    dtUsers.Load(reader);
//                }
//            }
//            catch (Exception ex)
//            {

//            }
//            finally
//            {
//                connection.Close();
//            }

//            return dtUsers;
//        }
//        public static bool GetUserByID(ref int userID,
//                                       ref string userName,
//                                       ref string password)
//        {
//            bool IsFound = false;
//            if (userID == -1) return false;

//            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
//            string sql = @"SELECT * FROM tblUsers WHERE UserID = @UserID";
//            SqlCommand command = new SqlCommand(sql, connection);
//            command.Parameters.AddWithValue("@UserID", userID);

//            try
//            {
//                connection.Open();
//                SqlDataReader reader = command.ExecuteReader();
//                if (reader.Read())
//                {
//                    userID = (int)reader["UserID"];
//                    return true;
//                }
//            }
//            catch (Exception ex)
//            {

//            }
//            finally
//            {
//                connection.Close();
//            }

//            return IsFound;
//        }
//        public static int AddNewUser(int userID,
//                                     int personID,
//                                     string userName,
//                                     string password,
//                                     int permissions,
//                                     bool isActive)
//        {
//            int ID = -1;
//            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
//            string sql = @"INSERT INTO tblUsers(
//                                UserID,
//                                PersonID,
//                                UserName,
//                                Password,
//                                Permissions,
//                                IsActive
//                          )
//                          VALUES (
//                                @UserID,
//                                @PersonID,
//                                @UserName,
//                                @Password,
//                                @Permissions,
//                                @IsActive
//                           )
//                           SELECT SCOPE_IDENTITY()";
//            SqlCommand command = new SqlCommand(sql, connection);

//            command.Parameters.AddWithValue("@UserID", userID);
//            command.Parameters.AddWithValue("@PersonID", personID);
//            command.Parameters.AddWithValue("@UserName", userName);
//            command.Parameters.AddWithValue("@Password", password);
//            command.Parameters.AddWithValue("@Permissions", permissions);
//            command.Parameters.AddWithValue("@IsActive", isActive);

//            try
//            {
//                connection.Open();
//                object result = command.ExecuteScalar();
//                if (result != null && int.TryParse(result.ToString(), out int insertedID))
//                {
//                    ID = insertedID;
//                }
//            }
//            catch (Exception ex)
//            {

//            }
//            finally
//            {
//                connection.Close();
//            }

//            return ID;
//        }

//        public static bool UpdatePerson(int userID,
//                                        string userName,
//                                        string password,
//                                        int permissions,
//                                        bool isActive)
//        {
//            bool IsUpdated = false;

//            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
//            string sql = @"UPDATE tblUsers
//                            SET UserID = @UserID,   
//                                UserName = @UserName,    
//                                Password = @Password,   
//                                Permissions = @Permissions,   
//                                IsActive = @IsActive,     
//                            WHERE UserID = @UserID";

//            SqlCommand command = new SqlCommand(sql, connection);

//            command.Parameters.AddWithValue("@UserID", userID);
//            command.Parameters.AddWithValue("@UserName", userName);
//            command.Parameters.AddWithValue("@Password", password);
//            command.Parameters.AddWithValue("@Permissions", permissions);
//            command.Parameters.AddWithValue("@IsActive", isActive);

//            try
//            {
//                connection.Open();
//                int result = command.ExecuteNonQuery();
//                if (result != 0)
//                {
//                    IsUpdated = true;
//                }
//            }
//            catch (Exception ex)
//            {

//            }
//            finally
//            {
//                connection.Close();
//            }

//            return IsUpdated;
//        }
        
//        public static bool DeleteUserByID(int userID)
//        {
//            bool IsDeleted = false;
//            if (userID == -1) return false;

//            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);
//            string sql = @"DELETE FROM tblUsers WHERE UserID = @UserID";
//            SqlCommand command = new SqlCommand(sql, connection);
//            command.Parameters.AddWithValue("@UserID", userID);
//            try
//            {
//                connection.Open();
//                int RowsAffected = command.ExecuteNonQuery();
//                if (RowsAffected > 0) IsDeleted = true;
//            }
//            catch (Exception ex)
//            {

//            }
//            finally
//            {
//                connection.Close();
//            }
//            return IsDeleted;
//        }
//    }
//}
