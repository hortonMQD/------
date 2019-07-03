using _06Demo01.DAO;
using _06Demo01.pojo;
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
    public partial class SelectStuInfo : Form
    {
        public SelectStuInfo()
        {
            InitializeComponent();
            setClassData();
            setMajorData();
        }


        public SelectStuInfo(String limit)
        {
            InitializeComponent();
            setClassData();
            setMajorData();

            if (limit.Equals("学生"))
            {
                bt_change.Visible = false;
                bt_delete.Visible = false;
            }
        }

        //设置学生表格数据
        private void selectStuData()
        {
            student student = new student();
            DataSet dataSet = DAO_Student.SelectStuData(student);
            dgv_stuInfo.DataSource = dataSet.Tables["student"];
        }

        //设置选择班级下拉框数据
        private void setClassData()
        {
            student student = new student();

            DataSet ds = DAO_Student.SelectStuData(student);
            DataTable dtGroup = ds.Tables["student"];
            cb_className.DataSource = dtGroup;
            cb_className.DisplayMember = "stuClassName";
            cb_className.ValueMember = "stuClassName";
        }

        //设置选择专业下拉框数据
        private void setMajorData()
        {
            DataSet ds = DAO_Major.getMajorData();
            DataTable dtGroup = ds.Tables["major"];
            cb_major.DataSource = dtGroup;
            cb_major.DisplayMember = "majorName";
            cb_major.ValueMember = "majorName";
        }


        private void selectStuInfo_Load(object sender, EventArgs e)
        {
            skinEngine1.SkinFile = "Steel\\SteelBlue.ssk";
            selectStuData();
            // TODO: 这行代码将数据加载到表“studentInfo.student”中。您可以根据需要移动或删除它。
            //this.studentTableAdapter.Fill(this.studentInfo.student);

        }

        //查询按钮点击事件
        private void bt_select_Click(object sender, EventArgs e)
        {
            student stu = new student();
            if (tb_stuId.Text.Trim().Length != 0)
            {
                stu.StuId = tb_stuId.Text;
            }
            if (tb_stuName.Text.Trim().Length != 0)
            {
                stu.StuName = tb_stuName.Text;
            }
            if (cb_stuSex.SelectedIndex != -1)
            {
                stu.StuSex = cb_stuSex.SelectedItem.ToString();
            }
            stu.StuMajor = cb_major.SelectedValue.ToString();
            stu.StuClassName = cb_className.SelectedValue.ToString();
            DataSet ds = DAO_Student.SelectStuData(stu);
            DataTable dtGroup = ds.Tables["student"];
            dgv_stuInfo.DataSource = dtGroup;
        }

        //修改学生按钮点击事件
        private void bt_change_Click(object sender, EventArgs e)
        {
            student stu = new student();
            string id = dgv_stuInfo.SelectedRows[0].Cells[0].Value.ToString();
            UpdateStuInfo changeStuInfo = new UpdateStuInfo(id);
            changeStuInfo.ShowDialog();
            DataSet ds = DAO_Student.SelectStuData(stu);
            DataTable dtGroup = ds.Tables["student"];
            dgv_stuInfo.DataSource = dtGroup;
        }

        //删除学生按钮点击事件
        private void bt_delete_Click(object sender, EventArgs e)
        {
            string stuId = dgv_stuInfo.SelectedRows[0].Cells[0].Value.ToString();
            bool result = DAO_Student.DeleteStudent(stuId);
            if (result)
            {
                MessageBox.Show("删除成功");
                selectStuData();
            }
            else
            {
                MessageBox.Show("删除失败");
            }
        }
    }
}
