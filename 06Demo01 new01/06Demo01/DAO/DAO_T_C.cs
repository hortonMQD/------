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
    class DAO_T_C:DAOimpl
    {
        //添加课程时调用方法
        public static bool AddClass(string courseName, string courseType, string teacherName,string courseTime)
        {
            bool result = false;
            SqlConnection sqlConnection = GetSqlConnection();
            sqlConnection.Open();
            bool result1 = false;
            DataSet dataSet = DAO_Course.selectCourseData(courseName, courseType);      //查询是否有此门课程
            if (dataSet.Tables[0].Rows.Count == 0)      //若查询结果为0，则添加此门课程
            {
                result1 = DAO_Course.addCourse(courseName, courseType,courseTime);     //调用方法，向课程表中添加此课程，若result1的值为true，则添加成功
            }
            if (result1)    //若向课程表添加成功，则想教师授课表添加数据
            {

                string sql = "insert T_C(courseName,teaId) values(@courseName,@teacherId)";
                string teacherId = DAO_Teacher.getTeacherId(teacherName);
                SqlParameter[] parameters = new SqlParameter[]
                    {
                    new SqlParameter("courseName",courseName),
                    new SqlParameter("teacherId",teacherId)
                    };
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlCommand.Parameters.AddRange(parameters);
                int count = sqlCommand.ExecuteNonQuery();
                if (count > 0)
                {
                    result = true;
                }
            }
            sqlConnection.Close();
            return result;
        }

        //查询教师授课信息时调用方法
        public static DataSet selectT_CData(string courseName, string courseType,string teacherName)
        {
            SqlConnection sqlConnection = GetSqlConnection();
            string sql = "select * from Tea_Cour where 1 = 1";
            if (courseName != null)
            {
                sql = sql + " and courseName = '" + courseName + "' ";
            }
            if (courseType != null)
            {
                sql = sql + " and courseType = '" + courseType + "' ";
            }
            if (teacherName != null)
            {
                sql = sql + " and teaName = '" + teacherName + "' ";
            }
            SqlDataAdapter da = new SqlDataAdapter(sql, sqlConnection);
            DataSet ds = new DataSet();
            da.Fill(ds, "t_c_View");
            return ds;
        }
        //修改教师授课表时调用方法
        public static bool updateT_C(string courseName,string teaName,string NewCourseName, string NewTeaName)
        {
            bool result = false;
            SqlConnection sqlConnection = GetSqlConnection();
            sqlConnection.Open();
            string teacherId = DAO_Teacher.getTeacherId(teaName);
            string NewTeacherId = DAO_Teacher.getTeacherId(NewTeaName);
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("teaId",teacherId),
                new SqlParameter("courseName",courseName),
                new SqlParameter("NewTeaId",NewTeacherId),
                new SqlParameter("NewCourseName",NewCourseName)
            };
            string sql = "update T_C set";
            if (courseName != "") { sql = sql + " courseName = @NewCourseName, "; }   //判断课程名称是否为空
            if (teacherId != "") { sql = sql + " teaId = @NewTeaId "; }      //判断成绩是否为空
            sql = sql + " where ";
            if (courseName != "") { sql = sql + " courseName = @courseName "; }   //添加修改条件，判断课程名称是否为空
            if (teacherId != "") { sql = sql + " and teaId = @teaId "; }      //添加修改条件，判断成绩是否为空
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlCommand.Parameters.AddRange(parameter);
            int count = sqlCommand.ExecuteNonQuery();
            if (count > 0) { result = true; }      //判断SQL语句执行结果
            sqlConnection.Close();
            return result;
        }
    }
}
