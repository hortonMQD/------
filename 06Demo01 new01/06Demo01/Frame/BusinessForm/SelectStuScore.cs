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
    public partial class SelectStuScore : Form
    {
        public SelectStuScore()
        {
            InitializeComponent();
            setCourData();
            
        }

        public SelectStuScore(String limit)
        {

            InitializeComponent();
            setCourData();
            if (limit.Equals("学生"))
            {
                bt_update.Visible = false;
            }

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

        //设置表格数据调用方法
        private void setStu_CourData()
        {
            string stuName = null;
            string courseName = null;
            DataSet dataSet = DAO_S_C.selectS_CData(stuName, courseName);
            dataGridView1.DataSource = dataSet.Tables["s_c"];
        }

        private void selectStuScore_Load(object sender, EventArgs e)
        {
            skinEngine1.SkinFile = "Steel\\SteelBlue.ssk";
            setStu_CourData();

        }

        //设置搜索按钮点击事件
        private void bt_select_Click(object sender, EventArgs e)
        {
            string stuName = isNull(tb_stuName.Text);
            string courseName = cb_className.SelectedValue.ToString();
            DataSet dataSet = DAO_S_C.selectS_CData(stuName, courseName);
            dataGridView1.DataSource = dataSet.Tables["s_c"];
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

        //设置修改按钮点击事件
        private void bt_update_Click(object sender, EventArgs e)
        {
            string stuId = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string stuName = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            string courseName = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            string courseScore = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            UpdateStuScore updateStuScore = new UpdateStuScore(stuId, stuName, courseName, courseScore);
            updateStuScore.ShowDialog();
            setStu_CourData();
        }
    }
}
