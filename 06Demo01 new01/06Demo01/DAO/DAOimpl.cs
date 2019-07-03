using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Demo01.DAO
{
    class DAOimpl
    {
        public static SqlConnection GetSqlConnection()
        {
            string sqlString = "server = .;Initial Catalog = stuscoremanager;uid = sa;pwd = 123;Integrated Security = true";
            SqlConnection sqlConnection = new SqlConnection(sqlString);
            return sqlConnection;
        }
    }
}
