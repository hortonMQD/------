using System;
using System.Data;
using System.Data.SqlClient;

namespace _06Demo01.DAO
{
    class DAO_Course:DAOimpl
    {
        //查询课程信息时调用方法
        public static DataSet selectCourseData(string courseName, string courseType)
        {
            SqlConnection sqlConnection = GetSqlConnection();
            string sql = "select * from course where 1 = 1";
            if (courseName != null)
            {
                sql = sql + " and courseName = '" + courseName + "'";
            }
            if (courseType != null)
            {
                sql = sql + " and courseType = '" + courseType + "'";
            }
            SqlDataAdapter da = new SqlDataAdapter(sql, sqlConnection);
            DataSet ds = new DataSet();
            da.Fill(ds, "course");
            return ds;
        }

        //添加课程时调用方法，调用方为DAO_T_C.cs
        public static bool addCourse(string courseName, string courseType,string courseTime)
        {
            Boolean result = false;
            SqlConnection sqlConnection = GetSqlConnection();
            sqlConnection.Open();
            string sql = "insert course(courseName,courseType,courseTime) values(@courseName,@courseType,@courseTime);";
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("courseName",courseName),
                new SqlParameter("courseType",courseType),
                new SqlParameter("courseTime",courseTime)
            };
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


        //修改课程表时调用方法
        public static bool updateCourse(string courseName, string CourseType, string NewCourseName, string NewCourseType,string NewCourseTime)
        {
            bool result = false;
            SqlConnection sqlConnection = GetSqlConnection();
            sqlConnection.Open();
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("CourseType",CourseType),
                new SqlParameter("courseName",courseName),
                new SqlParameter("NewCourseType",NewCourseType),
                new SqlParameter("NewCourseName",NewCourseName),
                new SqlParameter("NewCourseTime",NewCourseTime)
            };
            string sql = "update course set";
            if (courseName != "") { sql = sql + " courseName = @NewCourseName "; }   //判断课程名称是否为空
            if (NewCourseType != "") { sql = sql + " ,courseType = @NewCourseType "; }      //判断课程类型是否为空
            if (NewCourseTime != "") { sql = sql + " ,courseTime = @NewCourseTime "; }      //判断课程时长是否为空
            sql = sql + " where ";
            if (courseName != "") { sql = sql + " courseName = @courseName "; }   //添加修改条件，判断课程名称是否为空
            if (CourseType != "") { sql = sql + " and courseType = @courseType "; }      //添加修改条件，判断课程类型是否为空
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlCommand.Parameters.AddRange(parameter);
            int count = sqlCommand.ExecuteNonQuery();
            if (count > 0) { result = true; }      //判断SQL语句执行结果
            sqlConnection.Close();
            return result;
        }
    }
}
