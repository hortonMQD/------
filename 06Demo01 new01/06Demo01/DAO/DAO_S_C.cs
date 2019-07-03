using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Demo01.DAO
{
    class DAO_S_C:DAOimpl
    {
        //初始化学生选课视图数据
        public static DataSet selectS_CData(string stuName,string CourseName)
        {
            SqlConnection sqlConnection = GetSqlConnection();
            SqlParameter[] parameter = new SqlParameter[]
                {
                new SqlParameter("stuName",stuName),
                new SqlParameter("courseName",CourseName)
                };
            string sql = "select * from Stu_Cour where 1 = 1";      //设置查询学生选课视图SQL语句
            if (CourseName != null)
            {
                sql = sql + " and courseName = '" + CourseName + "' ";
            }
            if (stuName != null)
            {
                sql = sql + " and stuName = '" + stuName + "' ";
            }
            SqlDataAdapter da = new SqlDataAdapter(sql, sqlConnection);
            DataSet ds = new DataSet();
            da.Fill(ds, "s_c");
            return ds;
        }

        //学生选课操作执行方法
        //传入学生学号和课程名称，将选课信息添加到选课表中
        public static bool choiceCourse(string stuId,string courseName)
        {
            Boolean result = false;
            SqlParameter[] parameter = new SqlParameter[]
                {
                new SqlParameter("stuId",stuId),
                new SqlParameter("courseName",courseName)
                };
            string sql = "insert S_C(stuId,courseName) values(@stuId,@courseName);";
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

        //修改学生选课、录入学生成绩执行方法，
        //判断传入学生学号，分数，课程名称是否为空值
        public static bool updateS_C(string stuId,string courseName,string score)
        {
            
                bool result = false;
                SqlConnection sqlConnection = GetSqlConnection();
                sqlConnection.Open();
                SqlParameter[] parameter = new SqlParameter[]
                {
                new SqlParameter("stuId",stuId),
                new SqlParameter("courseName",courseName),
                new SqlParameter("result",score)
                };
                string sql = "update S_C set";
                if (score != "")    {  sql = sql + " result = @result "; }      //判断成绩是否为空
                sql = sql + " where stuId = @stuId and courseName = @courseName";
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlCommand.Parameters.AddRange(parameter);
                int count = sqlCommand.ExecuteNonQuery();
                if (count > 0) {  result = true; }      //判断SQL语句执行结果
            sqlConnection.Close();
                return result;
            
        }

        //删除学生选课记录
        public static bool deleteS_C(string stuId)
        {
            bool result = false;
            SqlConnection sqlConnection = GetSqlConnection();
            sqlConnection.Open();
            string sql = "delete S_C where stuId = '" + stuId + "'";
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            int count = sqlCommand.ExecuteNonQuery();
            if (count > 0)
            {
                result = true;
            }
            return result;
        }
    }
}
