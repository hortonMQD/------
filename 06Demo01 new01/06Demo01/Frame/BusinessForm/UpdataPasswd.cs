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
    public partial class UpdataPasswd : Form
    {
        public UpdataPasswd()
        {
            InitializeComponent();
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            string sign = cb_qx.SelectedItem.ToString();
            string id = tb_Id.Text;
            string name = tb_name.Text;
            string passwd = tb_passwd.Text;
            if (sign.Equals("学生"))
            {
                bool result = DAO_Student.UpdataStudentPasswd(name, passwd);
                if (result) { MessageBox.Show("修改成功"); }
                else { MessageBox.Show("修改失败，请重试"); }
            }
            else
            {
                string teaSex = "";
                string teaDuties = "";
                string teaTelephone = "";
                bool result = DAO_Teacher.UpdataTeaInfo(id, name,teaSex,teaDuties,teaTelephone, passwd);
                if (result) { MessageBox.Show("修改成功"); }
                else { MessageBox.Show("修改失败，请重试"); }
            }
        }

        private void UpdataPasswd_Load(object sender, EventArgs e)
        {
            skinEngine1.SkinFile = "Steel\\SteelBlue.ssk";
        }
    }
}
