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
    public partial class AddTeaInfo : Form
    {
        public AddTeaInfo()
        {
            InitializeComponent();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            string teaId = tb_teaId.Text;
            string teaPasswd = tb_passwd.Text;
            string teaName = tb_teaName.Text;
            string teaSex = tb_TeaSex.Text;
            string teaDuties = cb_TeaDuties.Text;
            string teaTelephone = tb_TeaTelephone.Text;
            bool result = DAO_Teacher.AddTeacher(teaId,teaName,teaPasswd,teaSex,teaDuties,teaTelephone);
            if (result) { MessageBox.Show("添加成功"); }
            else { MessageBox.Show("添加失败，请重试"); }
        }

        private void AddTeaInfo_Load(object sender, EventArgs e)
        {
            skinEngine1.SkinFile = "Steel\\SteelBlue.ssk";
        }
    }
}
