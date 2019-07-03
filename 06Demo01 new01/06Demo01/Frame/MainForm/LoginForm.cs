using _06Demo01.DAO;
using _06Demo01.pojo;
using Sunisoft.IrisSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06Demo01.Frame.MainForm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        
        
        private void button1_Click(object sender, EventArgs e)
        {
            string id = tb_Id.Text;
            string passwd = tb_passwd.Text;
            string qx = cb_qx.SelectedItem.ToString();
            if (qx.Equals("学生"))
            {
                student stu = new student();
                stu.StuId = id;
                stu.Passwd = passwd;
                DataSet dataSet = DAO_Student.SelectStuDataForLogin(stu);
                int count = dataSet.Tables["student"].Rows.Count;
                if (count > 0)
                {
                    StuForm stuForm = new StuForm();
                    stuForm.Show();
                    this.Hide();
                }

            }
            else if (qx.Equals("教师"))
            {
                string teaName = "";
                DataSet dataSet = DAO_Teacher.getTeacherDataForLogin(id, qx, passwd);
                int count = dataSet.Tables["teacher"].Rows.Count;
                if (count > 0)
                {
                    AdminForm adminForm = new AdminForm(false);
                    adminForm.Show();
                    this.Hide();
                }
            }
            else if (qx.Equals("管理员"))
            {
                string teaName = "";
                DataSet dataSet = DAO_Teacher.getTeacherDataForLogin(id, qx, passwd);
                int count = dataSet.Tables["teacher"].Rows.Count;
                if (count > 0)
                {
                    AdminForm adminForm = new AdminForm(true);
                    adminForm.Show();
                    this.Hide();
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            skinEngine1.SkinFile = "Steel\\SteelBlue.ssk";
        }
    }
}
