using _06Demo01.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06Demo01.Frame.BusinessForm
{
    public partial class AddCourse : Form
    {
        public AddCourse()
        {
            InitializeComponent();
            setTeaData();
        }
        //设置选择老师下拉框数据
        private void setTeaData()
        {
            string teaName = "";
            string teaPasswd = "";
            string teaId = "";
            string teaQX = "";
            DataSet ds = DAO_Teacher.getTeacherData(teaName, teaId,teaQX, teaPasswd);
            DataTable dtGroup = ds.Tables["teacher"];
            cb_classTeacher.DataSource = dtGroup;
            cb_classTeacher.DisplayMember = "teaName";
            cb_classTeacher.ValueMember = "teaName";
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            string CourseTeacher = cb_classTeacher.Text;
            string CourseName = tb_className.Text;
            string CourseType = cb_classType.Text;
            string CourseTime = tb_CourseTime.Text;
            bool result = DAO_T_C.AddClass(CourseName, CourseType, CourseTeacher,CourseTime); 
            if (result)
            {
                MessageBox.Show("添加成功");
            }
            else
            {
                MessageBox.Show("添加失败");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lb_classTeacher_Click(object sender, EventArgs e)
        {

        }

        private void AddCourse_Load(object sender, EventArgs e)
        {
            skinEngine1.SkinFile = "Steel\\SteelBlue.ssk";
        }
    }
}
