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
    public partial class SelectCourse : Form
    {
        public SelectCourse()
        {
            InitializeComponent();
            setTeaData();
            //setTea_CourData();
        }


        public SelectCourse(String limit)
        {
            InitializeComponent();
            setTeaData();
            //setTea_CourData();
            if (limit.Equals("学生"))
            {
                bt_update.Visible = false;
            }
            
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
            cb_classTeacher.DataSource = dtGroup;
            cb_classTeacher.DisplayMember = "teaName";
            cb_classTeacher.ValueMember = "teaName";
        }

        

        //设置授课情况表格数据
        private void setTea_CourData()
        {
            string courseName = null;
            string courTea = null;
            string courseType = null;

            DataSet dataSet = DAO_T_C.selectT_CData(courseName, courseType, courTea);
            DataTable dataTable = dataSet.Tables["t_c_View"];
            dataGridView1.DataSource = dataTable;

        }

        private void selectCourse_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“tea_Course_New.Tea_Cour”中。您可以根据需要移动或删除它。
            //this.tea_CourTableAdapter1.Fill(this.tea_Course_New.Tea_Cour);
            // TODO: 这行代码将数据加载到表“tea_Cour_View.Tea_Cour”中。您可以根据需要移动或删除它。
            //this.tea_CourTableAdapter.Fill(this.tea_Cour_View.Tea_Cour);
            setTea_CourData();
            skinEngine1.SkinFile = "Steel\\SteelBlue.ssk";
        }

        private void bt_select_Click(object sender, EventArgs e)
        {
            string courseName = null;
            string courseType = isNull(cb_courseType.Text);
            string courseTea = isNull(cb_classTeacher.SelectedValue.ToString());
            DataSet ds = DAO_T_C.selectT_CData(courseName,courseType,courseTea);
            DataTable dataTable = ds.Tables["t_c_View"];
            dataGridView1.DataSource = dataTable;
        }

        //判断传入字符串是否有数据
        private string isNull(string data)
        {
            string data1 = null;
            if (data != "")
            {
                data1 = data;
            }
            return data1;
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            string courseName = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            UpdateTeaCourse update = new UpdateTeaCourse(courseName);
            update.ShowDialog();
            setTea_CourData();
        }

        private void cb_className_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
