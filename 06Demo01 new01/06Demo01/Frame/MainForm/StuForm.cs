using _06Demo01.Frame.BusinessForm;
using System.Windows.Forms;

namespace _06Demo01.Frame.MainForm
{
    public partial class StuForm : Form
    {
        public StuForm()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (this.treeView1.SelectedNode.Text)
            {
                case "查看学生信息":
                    SelectStuInfo selectStuInfo = new SelectStuInfo("学生");
                    selectStuInfo.TopLevel = false;
                    selectStuInfo.FormBorderStyle = FormBorderStyle.None;
                    selectStuInfo.WindowState = FormWindowState.Maximized;
                    panel.Controls.Add(selectStuInfo);
                    selectStuInfo.Show();
                    break;
                case "选择课程":
                    ChoiceCourse choiceCourse = new ChoiceCourse();
                    choiceCourse.TopLevel = false;
                    choiceCourse.FormBorderStyle = FormBorderStyle.None;
                    choiceCourse.WindowState = FormWindowState.Maximized;
                    panel.Controls.Add(choiceCourse);
                    choiceCourse.Show();
                    break;
                case "查询课程":
                    SelectCourse selectClass = new SelectCourse("学生");
                    selectClass.TopLevel = false;
                    selectClass.FormBorderStyle = FormBorderStyle.None;
                    selectClass.WindowState = FormWindowState.Maximized;
                    panel.Controls.Add(selectClass);
                    selectClass.Show();
                    break;
                case "查询成绩":
                    SelectStuScore selectStuScore = new SelectStuScore("学生");
                    selectStuScore.TopLevel = false;
                    selectStuScore.FormBorderStyle = FormBorderStyle.None;
                    selectStuScore.WindowState = FormWindowState.Maximized;
                    panel.Controls.Add(selectStuScore);
                    selectStuScore.Show();
                    break;
                case "修改密码":
                    UpdataPasswd updatePasswd = new UpdataPasswd();
                    updatePasswd.TopLevel = false;
                    updatePasswd.FormBorderStyle = FormBorderStyle.None;
                    updatePasswd.WindowState = FormWindowState.Maximized;
                    panel.Controls.Add(updatePasswd);
                    updatePasswd.Show();
                    break;
                case "退出系统":
                    Application.Exit();
                    break;
            }
        }

        private void StuForm_Load(object sender, System.EventArgs e)
        {
            skinEngine1.SkinFile = "Steel\\SteelBlue.ssk";
        }
    }
}
