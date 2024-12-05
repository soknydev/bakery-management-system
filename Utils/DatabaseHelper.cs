using MySql.Data.MySqlClient;

namespace bakery_management_system.Utils
{
    public static class DatabaseHelper
    {
        private static string server = "localhost";         // Server IP or domain
        private static string database = "bakery_ms_db";    // Database name
        private static string userId = "sokny";             // Username
        private static string password = "1234Dev&&";       // Password
        private static int port = 3306;                     // MySQL port

        // Construct the connection string
        private static readonly string connectionString =
            $"Server={server};Port={port};Database={database};User Id={userId};Password={password};";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }




}
