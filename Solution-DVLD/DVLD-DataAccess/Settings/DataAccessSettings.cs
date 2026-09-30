using System;
using System.Data.SqlClient;

namespace DVLD_DataAccess.Settings
{
    public class DataAccessSettings
    {
        public static string ConnectionString = @"Server=localhost\mssqlserver01;Database=DVLD_DB;User Id=sa;Password=sa123456;";
        public static string PeoleImagesPathFolder = @"D:\DVLD.Images\Peolple";
    }
}
