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
    public partial class AddStuInfo : Form
    {
        public AddStuInfo()
        {
            InitializeComponent();
            setMajorData();
        }

        //设置选择专业下拉框数据
        private void setMajorData()
        {
            DataSet ds = DAO_Major.getMajorData();
            DataTable dtGroup = ds.Tables["major"];
            cb_stuMajor.DataSource = dtGroup;
            cb_stuMajor.DisplayMember = "majorName";
            cb_stuMajor.ValueMember = "majorName";
        }

        private void setNull()
        {
            tb_stuClass.Text = "";
            tb_stuHome.Text = "";
            tb_stuId.Text = "";
            tb_stuName.Text = "";
            tb_stuPasswd.Text = "";
            sex_boy.Checked = false;
            sex_gird.Checked = false;
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            setNull();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (tb_stuName.Text.Trim().Length == 0 || tb_stuId.Text.Trim().Length == 0 || tb_stuPasswd.Text.Trim().Length == 0
               || tb_stuHome.Text.Trim().Length == 0 || tb_stuClass.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入完整数据");
            }
            else
            {
                student stu = new student();
                stu.StuClassName = tb_stuClass.Text;
                stu.StuMajor = cb_stuMajor.SelectedValue.ToString();
                stu.StuGrade = cb_stuGrade.SelectedItem.ToString();
                stu.StuSex = sex_boy.Checked ? "男" : "女";
                stu.StuId = tb_stuId.Text;
                stu.StuName = tb_stuName.Text;
                stu.Passwd = tb_stuPasswd.Text;
                stu.StuHome = tb_stuHome.Text;
                bool result = DAO_Student.AddStudent(stu);
                if (result)
                {
                    MessageBox.Show("添加成功");
                    setNull();
                }
                else
                {
                    MessageBox.Show("添加失败");
                }
            }
        }

        private void AddStuInfo_Load(object sender, EventArgs e)
        {
            skinEngine1.SkinFile = "Steel\\SteelBlue.ssk";
        }
    }
}