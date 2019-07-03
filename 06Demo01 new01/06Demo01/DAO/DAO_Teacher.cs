using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace _06Demo01.DAO
{
    class DAO_Teacher:DAOimpl
    {
        //查询教师表调用方法
        public static DataSet getTeacherData(string teaName, string teaId,string teaQX, string teaPasswd)
        {
            SqlConnection sqlConnection = GetSqlConnection();
            string sql = "select * from teacher where 1 = 1";
            if (teaName != "")
            {
                sql = sql + " and teaName = '" + teaName + "'";
            }
            if (teaId != "")
            {
                sql = sql + " and teaId = '" + teaId + "'";
            }
            if (teaPasswd != "")
            {
                sql = sql + " and teaPasswd = '" + teaPasswd + "'";
            }
            if (teaQX != "" && teaQX.Equals("管理员"))
            {
                sql = sql +" and teaQX = 'admin'";
            }
            SqlDataAdapter da = new SqlDataAdapter(sql, sqlConnection);
            DataSet ds = new DataSet();
            da.Fill(ds, "teacher");
            return ds;
        }


        //教师登陆调用方法
        public static DataSet getTeacherDataForLogin(string teaId, string teaQX, string teaPasswd)
        {
            SqlConnection sqlConnection = GetSqlConnection();
            string sql = "select * from teacher where teaId = '"+teaId+"' and teaPasswd = '"+teaPasswd+"'";
            
            if (teaQX != "" && teaQX.Equals("管理员"))
            {
                sql = sql + " and teaQX = 'admin'";
            }

            
            
            SqlDataAdapter da = new SqlDataAdapter(sql, sqlConnection);
            DataSet ds = new DataSet();
            da.Fill(ds, "teacher");
            return ds;
        }




        //删除教师调用方法
        public static bool DeleteTeacher(string teaId)
        {
            bool result = false;
            SqlConnection sqlConnection = GetSqlConnection();
            sqlConnection.Open();
            string sql = "delete teacher where teaId = '" + teaId + "'";
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            int count = sqlCommand.ExecuteNonQuery();
            if (count > 0)
            {
                result = true;
            }
            return result;
        }


        public static string getTeacherId(string TeacherName)
        {
            string id = "";
            string passwd = "";
            string teaQX = "";
            DataSet dataSet = getTeacherData(TeacherName, id,teaQX, passwd);
            id = dataSet.Tables["teacher"].Rows[0][0].ToString();
            return id;
        }


        //添加教师信息调用方法
        public static bool AddTeacher(string teaId,string teaName,string teaPasswd,string teaSex,string teaDuties,string teaTelePhone)
        {
            Boolean result = false;
            SqlParameter[] parameter = new SqlParameter[]
                {
                new SqlParameter("teaId",teaId),
                new SqlParameter("teaName",teaName),
                new SqlParameter("teaPasswd",teaPasswd),
                new SqlParameter("teaSex",teaSex),
                new SqlParameter("teaDuties",teaDuties),
                new SqlParameter("teaTelephone",teaTelePhone)
                };
            string sql = "insert teacher(teaId,teaName,teaPasswd,teaSex,teaDuties,teaTelephone) " +
                 "values(@teaId,@teaName,@teaPasswd,@teaSex,@teaDuties,@teaTelephone);";
            SqlConnection sqlConnection = GetSqlConnection();
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlCommand.Parameters.AddRange(parameter);
            int count = sqlCommand.ExecuteNonQuery();
            if (count > 0)
            {
                result = true;
            }
            sqlConnection.Close();
            return result;
        }


        //修改教师信息时调用方法
        public static bool UpdataTeaInfo(string teaId,string teaName,string teaSex,string teaDuties,string teaTelephone, string teaPasswd)
        {
            bool result = false;
            SqlConnection sqlConnection = GetSqlConnection();
            sqlConnection.Open();
            string sql = "update teacher set ";
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("teaId",teaId),
                new SqlParameter("teaName",teaName),
                new SqlParameter("teaPasswd",teaPasswd),
                new SqlParameter("teaDuties",teaDuties),
                new SqlParameter("teaTelephone",teaTelephone),
                new SqlParameter("teaSex",teaSex)
            };
            if (teaName != "") { sql = sql + " teaName = @teaName "; }
            if (teaSex != "") { sql = sql + " ,teaSex = @teaSex "; }
            if (teaDuties != "") { sql = sql + "  ,teaDuties = @teaDuties "; }
            if (teaTelephone != "") { sql = sql + " ,teaTelephone = @teaTelephone "; }
            if (teaPasswd != "") { sql = sql + ",teaPasswd = @teaPasswd "; }
            sql = sql + " where teaId = @teaId";
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlCommand.Parameters.AddRange(parameter);
            int count = sqlCommand.ExecuteNonQuery();
            if (count > 0)
            {
                result = true;
            }
            return result;
        }
    }
}
