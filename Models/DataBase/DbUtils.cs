using MySqlConnector;

namespace LocWebApp.Models.DataBase
{
    public class DbUtils
    {
        public static MySqlConnection GetSqlConnection( )
        {
            var host = "127.0.0.1";
            var port = 3306;
            var database = "asp-location";
            var username = "root";
            var password = "";
 
            return DBConnect.GetSqlConnection(host, port, database, username, password);
        }
    }
}