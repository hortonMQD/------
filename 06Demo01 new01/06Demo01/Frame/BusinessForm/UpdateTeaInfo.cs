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
    public partial class updateTeaInfo : Form
    {
        public updateTeaInfo(string teaId,string teaName,string teaSex,string teaDuties,string teaTelephone)
        {
            InitializeComponent();
            tb_stuId.Text = teaId;
            tb_teaName.Text = teaName;
            cb_TeaDuties.Text = teaDuties;
            cb_TeaSex.Text = teaSex;
            tb_TeaTelephone.Text = teaTelephone;
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            string teaId = tb_stuId.Text;
            string teaName = tb_teaName.Text;
            string teaSex = cb_TeaSex.Text;
            string teaTelephone = tb_TeaTelephone.Text;
            string teaDuties = cb_TeaDuties.Text;
            string passwd = "";
            bool result = DAO_Teacher.UpdataTeaInfo(teaId.Trim(), teaName.Trim(),teaSex.Trim(), teaDuties.Trim(), teaTelephone.Trim(), passwd);
            if (result) { MessageBox.Show("修改成功"); }
            else { MessageBox.Show("修改失败，请重试"); }
        }

        private void UpdateTeaInfo_Load(object sender, EventArgs e)
        {
            skinEngine1.SkinFile = "Steel\\SteelBlue.ssk";
        }
    }
}
