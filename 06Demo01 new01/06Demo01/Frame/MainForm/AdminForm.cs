using _06Demo01.Frame.BusinessForm;
using System.Windows.Forms;

namespace _06Demo01.Frame.MainForm
{
    public partial class AdminForm : Form
    {
        private bool admin = false;
        public AdminForm(bool admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (this.treeView1.SelectedNode.Text)
            {
                case "查看学生信息":
                    SelectStuInfo selectStuInfo = new SelectStuInfo();
                    selectStuInfo.TopLevel = false;
                    selectStuInfo.FormBorderStyle = FormBorderStyle.None;
                    selectStuInfo.WindowState = FormWindowState.Maximized;
                    panel.Controls.Add(selectStuInfo);
                    selectStuInfo.Show();
                    break;
                case "添加学生信息":
                    AddStuInfo addStuInfo = new AddStuInfo();
                    addStuInfo.TopLevel = false;
                    addStuInfo.FormBorderStyle = FormBorderStyle.None;
                    addStuInfo.WindowState = FormWindowState.Maximized;
                    panel.Controls.Add(addStuInfo);
                    addStuInfo.Show();
                    break;
                case "查看教师信息":
                    if (admin)
                    {
                        SelectTeaInfo selectTeaInfo = new SelectTeaInfo();
                        selectTeaInfo.TopLevel = false;
                        selectTeaInfo.FormBorderStyle = FormBorderStyle.None;
                        selectTeaInfo.WindowState = FormWindowState.Maximized;
                        panel.Controls.Add(selectTeaInfo);
                        selectTeaInfo.Show();
                    }
                    else
                    {
                        MessageBox.Show("你不是管理员，无法使用本模块");
                    }
                    break;
                case "添加教师信息":
                    if (admin)
                    {
                        AddTeaInfo addTeaInfo = new AddTeaInfo();
                        addTeaInfo.TopLevel = false;
                        addTeaInfo.FormBorderStyle = FormBorderStyle.None;
                        addTeaInfo.WindowState = FormWindowState.Maximized;
                        panel.Controls.Add(addTeaInfo);
                        addTeaInfo.Show();
                    }
                    else
                    {
                        MessageBox.Show("你不是管理员，无法使用本模块");
                    }
                    break;
                case "开设课程":
                    AddCourse addClass = new AddCourse();
                    addClass.TopLevel = false;
                    addClass.FormBorderStyle = FormBorderStyle.None;
                    addClass.WindowState = FormWindowState.Maximized;
                    panel.Controls.Add(addClass);
                    addClass.Show();
                    break;
                case "查询课程":
                    SelectCourse selectClass = new SelectCourse();
                    selectClass.TopLevel = false;
                    selectClass.FormBorderStyle = FormBorderStyle.None;
                    selectClass.WindowState = FormWindowState.Maximized;
                    panel.Controls.Add(selectClass);
                    selectClass.Show();
                    break;
                case "查询成绩":
                    SelectStuScore selectStuScore = new SelectStuScore();
                    selectStuScore.TopLevel = false;
                    selectStuScore.FormBorderStyle = FormBorderStyle.None;
                    selectStuScore.WindowState = FormWindowState.Maximized;
                    panel.Controls.Add(selectStuScore);
                    selectStuScore.Show();
                    break;
                case "添加修改成绩":
                    AddStuScore addStuScore = new AddStuScore();
                    addStuScore.TopLevel = false;
                    addStuScore.FormBorderStyle = FormBorderStyle.None;
                    addStuScore.WindowState = FormWindowState.Maximized;
                    panel.Controls.Add(addStuScore);
                    addStuScore.Show();
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

        private void AdminForm_Load(object sender, System.EventArgs e)
        {
            skinEngine1.SkinFile = "Steel\\SteelBlue.ssk";
        }
    }
}
