using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _06Demo01.DAO;
using System.Windows.Forms;
using _06Demo01.pojo;

namespace _06Demo01.Frame.BusinessForm
{
    public partial class UpdateStuInfo : Form
    {
        public UpdateStuInfo(string id)
        {
            InitializeComponent();
            setMajorData();
            student stu = new student();
            stu.StuId = id;
            DataSet ds = DAO_Student.SelectStuData(stu);
            DataTable dataTable = ds.Tables["student"];
            tb_stuId.Text = id;
            tb_stuName.Text = dataTable.Rows[0][1].ToString();
            cb_stuGrade.Text = dataTable.Rows[0][3].ToString();
            cb_stuMajor.Text = dataTable.Rows[0][4].ToString();
            tb_stuHome.Text = dataTable.Rows[0][6].ToString();
            tb_stuClass.Text = dataTable.Rows[0][5].ToString();
            if (dataTable.Rows[0][2].ToString() == "女")
             {
                 this.sex_gird.Checked = true;
             }
            else
             {
                this.sex_boy.Checked = true;
             }
            
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

        private void change_button_Click(object sender, EventArgs e)
        {
            student stu = new student();
            stu.StuMajor = cb_stuMajor.Text;
            stu.StuGrade = cb_stuGrade.Text;
            stu.StuSex = sex_boy.Checked ? "男" : "女";
            stu.StuId = tb_stuId.Text;
            stu.StuName = tb_stuName.Text;
            stu.StuClassName = tb_stuClass.Text;
            stu.StuHome = tb_stuHome.Text;
            bool result = DAO_Student.UpdataStudent(stu);
            if (result)
            {
                MessageBox.Show("修改成功");
            }
        }

        private void UpdateStuInfo_Load(object sender, EventArgs e)
        {
            skinEngine1.SkinFile = "Steel\\SteelBlue.ssk";
        }
    }
}
