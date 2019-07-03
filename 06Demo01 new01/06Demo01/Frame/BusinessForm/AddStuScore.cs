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
    public partial class AddStuScore : Form
    {
        public AddStuScore()
        {
            InitializeComponent();
        }

        private void setStu_CourData()
        {
            string stuName = null;
            string courseName = null;
            DataSet dataSet = DAO_S_C.selectS_CData(stuName,courseName);
            dataGridView1.DataSource = dataSet.Tables["s_c"];
        }

        private void addStuScore_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“stu_Cour_View.Stu_Cour”中。您可以根据需要移动或删除它。
            //this.stu_CourTableAdapter.Fill(this.stu_Cour_View.Stu_Cour);
            // TODO: 这行代码将数据加载到表“stu_Cour_View.Stu_Cour”中。您可以根据需要移动或删除它。
            //this.stu_CourTableAdapter.Fill(this.stu_Cour_View.Stu_Cour);
            setStu_CourData();
            skinEngine1.SkinFile = "Steel\\SteelBlue.ssk";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_stuId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tb_stuName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            tb_ClassName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            tb_stuScore.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void change_button_Click(object sender, EventArgs e)
        {
            
            bool result = DAO_S_C.updateS_C(tb_stuId.Text, tb_ClassName.Text, tb_stuScore.Text);
            if (result)
            {
                MessageBox.Show("录入成功");
                setStu_CourData();
            }
            else { MessageBox.Show("录入失败，请重试"); }
        }
    }
}
