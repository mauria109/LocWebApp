using MySqlConnector;

namespace LocWebApp.Models.DataBase
{
    public class DBConnect
    {
        public static MySqlConnection GetSqlConnection(string host,int port, string database,
                                                       string username, string password)
        {
            // Connection String.
            var connString = "Server=" + host + ";Database=" + database
                             + ";port=" + port + ";User Id=" + username + 
                             ";password=" + password;
            
            var conn = new MySqlConnection(connString);
 
            return conn;
        }
    }
}