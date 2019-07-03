namespace _06Demo01.Frame.MainForm
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("查看教师信息");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("添加教师信息");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("教师信息管理", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("开设课程");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("查询课程");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("课程管理", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("查询成绩");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("添加修改成绩");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("成绩管理", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("查看学生信息");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("添加学生信息");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("学生信息管理", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("修改密码");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("退出系统");
            this.panel = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel.BackgroundImage")));
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel.Location = new System.Drawing.Point(213, 12);
            this.panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(951, 542);
            this.panel.TabIndex = 3;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.treeView1.Location = new System.Drawing.Point(1, 14);
            this.treeView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点1";
            treeNode1.Text = "查看教师信息";
            treeNode2.Name = "节点2";
            treeNode2.Text = "添加教师信息";
            treeNode3.Name = "节点0";
            treeNode3.Text = "教师信息管理";
            treeNode4.Name = "add_class";
            treeNode4.Text = "开设课程";
            treeNode5.Name = "select_class";
            treeNode5.Text = "查询课程";
            treeNode6.Name = "classManager";
            treeNode6.Text = "课程管理";
            treeNode7.Name = "selectStuScore";
            treeNode7.Text = "查询成绩";
            treeNode8.Name = "add_score";
            treeNode8.Text = "添加修改成绩";
            treeNode9.Name = "scoreManager";
            treeNode9.Text = "成绩管理";
            treeNode10.Name = "Select_StuInfo";
            treeNode10.Text = "查看学生信息";
            treeNode11.Name = "add_stuInfo";
            treeNode11.Text = "添加学生信息";
            treeNode12.Name = "stuInfo_Manage";
            treeNode12.Text = "学生信息管理";
            treeNode13.Name = "changePW";
            treeNode13.Text = "修改密码";
            treeNode14.Name = "Exit";
            treeNode14.Text = "退出系统";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6,
            treeNode9,
            treeNode12,
            treeNode13,
            treeNode14});
            this.treeView1.Size = new System.Drawing.Size(180, 542);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 561);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.treeView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminForm";
            this.Text = "学生选课管理系统(老师)";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TreeView treeView1;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}