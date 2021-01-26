using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Greenhouse
{
    class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "localhost";
            int port = 3306;
            string database = "greenhouse";
            string username = "root";
            string password = "0987654321";

            return DBMySQLUtils.GetDBConnection(host, port, database, username, password);
        }
    }
}
