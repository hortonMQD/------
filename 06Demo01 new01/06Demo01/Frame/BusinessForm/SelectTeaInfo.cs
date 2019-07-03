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
    public partial class SelectTeaInfo : Form
    {
        public SelectTeaInfo()
        {
            InitializeComponent();
        }

        //设置查询按钮点击事件
        private void bt_select_Click(object sender, EventArgs e)
        {
            string teaId = tb_teaId.Text;
            string teaName = tb_teaName.Text;
            string teaPasswd = "";
            string teaQX = "";
            DataSet dataSet = DAO_Teacher.getTeacherData(teaName.Trim(), teaId.Trim(),teaQX, teaPasswd.Trim());
            dgv_teaInfo.DataSource = dataSet.Tables["teacher"];
        }

        private void setData()
        {
            string teaName = "";
            string teaId = "";
            string teaPasswd = "";
            string teaQX = "";
            DataSet dataSet = DAO_Teacher.getTeacherData(teaName.Trim(), teaId.Trim(),teaQX, teaPasswd.Trim());
            dgv_teaInfo.DataSource = dataSet.Tables["teacher"];
        }

        private void dgv_teaInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            setData();
        }

        //设置修改按钮点击事件
        private void bt_change_Click(object sender, EventArgs e)
        {
            string teaId = dgv_teaInfo.SelectedRows[0].Cells[0].Value.ToString();
            string teaName = dgv_teaInfo.SelectedRows[0].Cells[1].Value.ToString();
            string teaSex = dgv_teaInfo.SelectedRows[0].Cells[2].Value.ToString();
            string teaDuties = dgv_teaInfo.SelectedRows[0].Cells[3].Value.ToString();
            string teaTelephone = dgv_teaInfo.SelectedRows[0].Cells[4].Value.ToString();
            updateTeaInfo updateTeaInfo = new updateTeaInfo(teaId,teaName,teaSex,teaDuties,teaTelephone);
            updateTeaInfo.ShowDialog();
            setData();
        }

        //设置删除按钮点击事件
        private void bt_delete_Click(object sender, EventArgs e)
        {
            string teaId = dgv_teaInfo.SelectedRows[0].Cells[0].Value.ToString();
            bool result = DAO_Teacher.DeleteTeacher(teaId);
            if (result) { MessageBox.Show("删除成功"); }
            else { MessageBox.Show("删除失败，请重试"); }
            setData();
        }

        private void selectTeaInfo_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“teacher_New.teacher”中。您可以根据需要移动或删除它。
            //this.teacherTableAdapter1.Fill(this.teacher_New.teacher);
            // TODO: 这行代码将数据加载到表“teacher.teacher”中。您可以根据需要移动或删除它。
            //this.teacherTableAdapter.Fill(this.teacher.teacher);
            setData();
            skinEngine1.SkinFile = "Steel\\SteelBlue.ssk";
        }
    }
}
