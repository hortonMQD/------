using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Demo01.DAO
{
    class DAO_Major:DAOimpl
    {
        //查询教师表调用方法
        public static DataSet getMajorData()
        {
            SqlConnection sqlConnection = GetSqlConnection();
            string sql = "select * from major where 1 = 1";
            SqlDataAdapter da = new SqlDataAdapter(sql, sqlConnection);
            DataSet ds = new DataSet();
            da.Fill(ds, "major");
            return ds;
        }
    }
}
