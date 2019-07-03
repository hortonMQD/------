using _06Demo01.pojo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Demo01.DAO
{
    class DAO_Student:DAOimpl
    {
        //查询学生信息调用方法
        public static DataSet SelectStuData(student stu)
        {
            SqlConnection sqlConnection = GetSqlConnection();
            string sql = "select * from student where 1 = 1";
            if (stu.StuName != null)
            {
                sql = sql + " and stuName = '" + stu.StuName + "'";
            }
            if (stu.StuClassName != null)
            {
                sql = sql + " and stuClassName = '" + stu.StuClassName + "'";
            }
            if (stu.StuMajor != null)
            {
                sql = sql + " and stuMajor = '" + stu.StuMajor + "'";
            }
            if (stu.StuGrade != null)
            {
                sql = sql + " and stuGrade = '" + stu.StuGrade + "'";
            }
            if (stu.StuSex != null)
            {
                sql = sql + " and stuSex = '" + stu.StuSex + "'";
            }
            if (stu.StuHome != null)
            {
                sql = sql + " and stuHome = '" + stu.StuHome + "'";
            }
            if (stu.StuId != null)
            {
                sql = sql + " and stuId = '" + stu.StuId + "'";
            }
            if (stu.Passwd != null)
            {
                sql = sql + " and stuPasswd = '" + stu.Passwd + "'";
            }
            SqlDataAdapter da = new SqlDataAdapter(sql, sqlConnection);
            DataSet ds = new DataSet();
            da.Fill(ds, "student");
            return ds;
        }



        public static DataSet SelectStuDataForLogin(student stu)
        {
            SqlConnection sqlConnection = GetSqlConnection();
            string sql = "select * from student ";
            
            if (stu.StuId != null)
            {
                sql = sql + " where stuId = '" + stu.StuId + "'";
            }
            if (stu.Passwd != null)
            {
                sql = sql + " and stuPasswd = '" + stu.Passwd + "'";
            }
            SqlDataAdapter da = new SqlDataAdapter(sql, sqlConnection);
            DataSet ds = new DataSet();
            da.Fill(ds, "student");
            return ds;
        }




        //添加学生信息调用方法
        public static bool AddStudent(student student)
        {
            Boolean result = false;
            SqlParameter[] parameter = new SqlParameter[]
                {
                new SqlParameter("stuName",student.StuName),
                new SqlParameter("stuId",student.StuId),
                new SqlParameter("stuGrade",student.StuGrade),
                new SqlParameter("stuMajor",student.StuMajor),
                new SqlParameter("stuSex",student.StuSex),
                new SqlParameter("stuPasswd",student.Passwd),
                new SqlParameter("stuClassName",student.StuClassName),
                new SqlParameter("stuHome",student.StuHome)
                };
            string sql = "insert student(stuId,stuName,stuSex,stuPasswd,stuHome,stuMajor,stuGrade,stuClassName) " +
                 "values(@stuId,@stuName,@stuSex,@stuPasswd,@stuHome,@stuMajor,@stuGrade,@stuClassName);";
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

        //删除学生调用方法
        public static bool DeleteStudent(string stuId)
        {
            bool result = false;
            SqlConnection sqlConnection = GetSqlConnection();
            sqlConnection.Open();
            string sql = "delete student where stuId = '" + stuId + "'";
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            int count = sqlCommand.ExecuteNonQuery();
            if (count > 0)
            {
                result = true;
            }
            return result;
        }

        //修改学生信息调用方法
        public static bool UpdataStudent(student stu)
        {
            bool result = false;
            SqlConnection sqlConnection = GetSqlConnection();
            sqlConnection.Open();
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("stuName",stu.StuName),
                new SqlParameter("stuId",stu.StuId),
                new SqlParameter("stuGrade",stu.StuGrade),
                new SqlParameter("stuMajor",stu.StuMajor),
                new SqlParameter("stuSex",stu.StuSex),
                new SqlParameter("stuClassName",stu.StuClassName),
                new SqlParameter("stuHome",stu.StuHome)
            };
            string sql = "update student set";
            if (stu.StuName != "")
            {
                sql = sql + " stuName = @stuName, ";
            }
            if (stu.StuClassName != "")
            {
                sql = sql + " stuClassName = @stuClassName,";
            }

            if (stu.StuMajor != "")
            {
                sql = sql + " stuMajor = @stuMajor,";
            }

            if (stu.StuGrade != "")
            {
                sql = sql + " stuGrade = @stuGrade,";
            }
            if (stu.StuSex != "")
            {
                sql = sql + " stuSex = @stuSex,";
            }
            if (stu.StuHome != "")
            {
                sql = sql + " stuHome = @stuHome ";
            }
            
            sql = sql + " where stuId = @stuId ";
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlCommand.Parameters.AddRange(parameter);
            int count = sqlCommand.ExecuteNonQuery();
            if (count > 0)
            {
                result = true;
            }
            return result;
        }

        public static bool UpdataStudentPasswd(string stuName, string stuPasswd)
        {
            bool result = false;
            SqlConnection sqlConnection = GetSqlConnection();
            sqlConnection.Open();
            string sql = "update student set stuPasswd = '" + stuPasswd + "' where stuName = '" + stuName + "'";
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
