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
    public partial class UpdateStuScore : Form
    {
        public UpdateStuScore(string stuId,string stuName,string courseName,string Score)
        {
            InitializeComponent();
            tb_courseName.Text = courseName;
            tb_stuId.Text = stuId;
            tb_stuName.Text = stuName;
            tb_stuScore.Text = Score;
        }

        private void change_button_Click(object sender, EventArgs e)
        {
            bool result = DAO_S_C.updateS_C(tb_stuId.Text, tb_courseName.Text, tb_stuScore.Text);
            if (result)
            {
                MessageBox.Show("修改成功");
            }
            else { MessageBox.Show("修改失败，请重试"); }
        }

        private void UpdateStuScore_Load(object sender, EventArgs e)
        {
            skinEngine1.SkinFile = "Steel\\SteelBlue.ssk";
        }
    }
}
