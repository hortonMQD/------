using _06Demo01.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06Demo01.Frame.BusinessForm
{
    public partial class UpdateTeaCourse : Form
    {
        string courTea = null;
        string courseType = null;
        string courseName = null;

        public UpdateTeaCourse(string courseName)
        {
            InitializeComponent();
            setTeaData();
            this.courseName = courseName;
            DataSet dataSet = DAO_T_C.selectT_CData(courseName, courseType, courTea);
            DataTable dataTable = dataSet.Tables["t_c_View"];
            courTea = dataTable.Rows[0][2].ToString();
            tb_courseName.Text =courseName;
            cb_courseTea.Text = courTea;
            
        }

        //设置选择老师下拉框数据
        private void setTeaData()
        {
            string teaName = "";
            string teaPasswd = "";
            string teaId = "";
            string teaQX = "";
            DataSet ds = DAO_Teacher.getTeacherData(teaName, teaId, teaQX,teaPasswd);
            DataTable dtGroup = ds.Tables["teacher"];
            cb_courseTea.DataSource = dtGroup;
            cb_courseTea.DisplayMember = "teaName";
            cb_courseTea.ValueMember = "teaName";
        }

        private void change_button_Click(object sender, EventArgs e)
        {
            string courseTea_New = cb_courseTea.Text;
            string courseName_New = tb_courseName.Text;
            string courseType = "";
            string NewcourseType = "";
            string NewcourseTime = "";
            bool result = DAO_T_C.updateT_C(courseName,courTea,courseName_New,courseTea_New); //调用方法修改授课表
            bool result_1 = DAO_Course.updateCourse(courseName,courseType,courseName_New,NewcourseType,NewcourseTime);
            if (result && result_1) { MessageBox.Show("修改成功"); }    //判断是否修改成功
            else { MessageBox.Show("修改失败，请重试"); };  
        }

        private void UpdateTeaCourse_Load(object sender, EventArgs e)
        {
            skinEngine1.SkinFile = "Steel\\SteelBlue.ssk";
        }
    }
}
