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
    public partial class ChoiceCourse : Form
    {
        public ChoiceCourse()
        {
            InitializeComponent();
            setCourData();
            
        }

        //设置选择课程下拉框数据
        private void setCourData()
        {
            string courseName = null; string courseType = null;
            DataSet ds = DAO_Course.selectCourseData(courseName, courseType);
            DataTable dtGroup = ds.Tables["course"];
            cb_className.DataSource = dtGroup;
            cb_className.DisplayMember = "courseName";
            cb_className.ValueMember = "courseName";
        }

        //设置授课情况表格数据
        private void setStu_CourData()
        {
            string courseName = null;
            string stuName = null;
           
            DataSet dataSet = DAO_S_C.selectS_CData(stuName,courseName);
            DataTable dataTable = dataSet.Tables["s_c"];
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

        private void choiceCourse_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“stu_Course_New.Stu_Cour”中。您可以根据需要移动或删除它。
            //this.stu_CourTableAdapter.Fill(this.stu_Course_New.Stu_Cour);
            skinEngine1.SkinFile = "Steel\\SteelBlue.ssk";
            setStu_CourData();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            string courseName = cb_className.SelectedValue.ToString();
            string stuId = tb_stuId.Text;
            bool result = DAO_S_C.choiceCourse(stuId, courseName);
            if (result)
            {
                MessageBox.Show("选课成功");
                setStu_CourData();
            }
            else { MessageBox.Show("选课失败，请重试"); }
        }
    }
}
