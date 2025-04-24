using System.Data;
using Microsoft.Data.SqlClient;

namespace AdoNET.Helpers
{
    public static class SqlHelper
    {
        private const string _connString = @"Server=.\SQLEXPRESS;Database=PizzaMizzaConsole;Trusted_Connection=True;TrustServerCertificate=True";
        public static DataTable Query(string query)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                //connection.Open();
                using(SqlDataAdapter sda = new(query, connection))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    return dt;
                }
            }
        }
        public static bool Exec(string command)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                connection.Open();
                using (SqlCommand cmd = new(command, connection))
                {
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
