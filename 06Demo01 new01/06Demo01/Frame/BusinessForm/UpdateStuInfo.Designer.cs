namespace _06Demo01.Frame.BusinessForm
{
    partial class UpdateStuInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateStuInfo));
            this.bt_cancel = new System.Windows.Forms.Button();
            this.change_button = new System.Windows.Forms.Button();
            this.cb_stuMajor = new System.Windows.Forms.ComboBox();
            this.cb_stuGrade = new System.Windows.Forms.TextBox();
            this.tb_stuClass = new System.Windows.Forms.TextBox();
            this.lb_className = new System.Windows.Forms.Label();
            this.lb_sex = new System.Windows.Forms.Label();
            this.sex_gird = new System.Windows.Forms.RadioButton();
            this.sex_boy = new System.Windows.Forms.RadioButton();
            this.tb_stuHome = new System.Windows.Forms.TextBox();
            this.lb_home = new System.Windows.Forms.Label();
            this.lb_major = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_stuName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_stuId = new System.Windows.Forms.TextBox();
            this.lb_stuId = new System.Windows.Forms.Label();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.SuspendLayout();
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(403, 385);
            this.bt_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 22);
            this.bt_cancel.TabIndex = 40;
            this.bt_cancel.Text = "取  消";
            this.bt_cancel.UseVisualStyleBackColor = true;
            // 
            // change_button
            // 
            this.change_button.Location = new System.Drawing.Point(287, 385);
            this.change_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.change_button.Name = "change_button";
            this.change_button.Size = new System.Drawing.Size(75, 22);
            this.change_button.TabIndex = 39;
            this.change_button.Text = "确 定";
            this.change_button.UseVisualStyleBackColor = true;
            this.change_button.Click += new System.EventHandler(this.change_button_Click);
            // 
            // cb_stuMajor
            // 
            this.cb_stuMajor.FormattingEnabled = true;
            this.cb_stuMajor.Location = new System.Drawing.Point(303, 279);
            this.cb_stuMajor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_stuMajor.Name = "cb_stuMajor";
            this.cb_stuMajor.Size = new System.Drawing.Size(216, 23);
            this.cb_stuMajor.TabIndex = 38;
            // 
            // cb_stuGrade
            // 
            this.cb_stuGrade.Location = new System.Drawing.Point(303, 96);
            this.cb_stuGrade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_stuGrade.Name = "cb_stuGrade";
            this.cb_stuGrade.Size = new System.Drawing.Size(216, 25);
            this.cb_stuGrade.TabIndex = 37;
            // 
            // tb_stuClass
            // 
            this.tb_stuClass.Location = new System.Drawing.Point(299, 139);
            this.tb_stuClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_stuClass.Name = "tb_stuClass";
            this.tb_stuClass.Size = new System.Drawing.Size(216, 25);
            this.tb_stuClass.TabIndex = 36;
            // 
            // lb_className
            // 
            this.lb_className.AutoSize = true;
            this.lb_className.Location = new System.Drawing.Point(247, 141);
            this.lb_className.Name = "lb_className";
            this.lb_className.Size = new System.Drawing.Size(45, 15);
            this.lb_className.TabIndex = 35;
            this.lb_className.Text = "班 级";
            // 
            // lb_sex
            // 
            this.lb_sex.AutoSize = true;
            this.lb_sex.Location = new System.Drawing.Point(248, 191);
            this.lb_sex.Name = "lb_sex";
            this.lb_sex.Size = new System.Drawing.Size(45, 15);
            this.lb_sex.TabIndex = 34;
            this.lb_sex.Text = "性 别";
            // 
            // sex_gird
            // 
            this.sex_gird.AutoSize = true;
            this.sex_gird.Location = new System.Drawing.Point(456, 191);
            this.sex_gird.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sex_gird.Name = "sex_gird";
            this.sex_gird.Size = new System.Drawing.Size(43, 19);
            this.sex_gird.TabIndex = 33;
            this.sex_gird.TabStop = true;
            this.sex_gird.Text = "女";
            this.sex_gird.UseVisualStyleBackColor = true;
            // 
            // sex_boy
            // 
            this.sex_boy.AutoSize = true;
            this.sex_boy.Location = new System.Drawing.Point(369, 191);
            this.sex_boy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sex_boy.Name = "sex_boy";
            this.sex_boy.Size = new System.Drawing.Size(43, 19);
            this.sex_boy.TabIndex = 32;
            this.sex_boy.TabStop = true;
            this.sex_boy.Text = "男";
            this.sex_boy.UseVisualStyleBackColor = true;
            // 
            // tb_stuHome
            // 
            this.tb_stuHome.Location = new System.Drawing.Point(303, 320);
            this.tb_stuHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_stuHome.Name = "tb_stuHome";
            this.tb_stuHome.Size = new System.Drawing.Size(216, 25);
            this.tb_stuHome.TabIndex = 31;
            // 
            // lb_home
            // 
            this.lb_home.AutoSize = true;
            this.lb_home.Location = new System.Drawing.Point(251, 324);
            this.lb_home.Name = "lb_home";
            this.lb_home.Size = new System.Drawing.Size(45, 15);
            this.lb_home.TabIndex = 30;
            this.lb_home.Text = "籍 贯";
            // 
            // lb_major
            // 
            this.lb_major.AutoSize = true;
            this.lb_major.Location = new System.Drawing.Point(249, 281);
            this.lb_major.Name = "lb_major";
            this.lb_major.Size = new System.Drawing.Size(45, 15);
            this.lb_major.TabIndex = 29;
            this.lb_major.Text = "专 业";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "年 级";
            // 
            // tb_stuName
            // 
            this.tb_stuName.Location = new System.Drawing.Point(300, 231);
            this.tb_stuName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_stuName.Name = "tb_stuName";
            this.tb_stuName.Size = new System.Drawing.Size(216, 25);
            this.tb_stuName.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "姓 名";
            // 
            // tb_stuId
            // 
            this.tb_stuId.Location = new System.Drawing.Point(297, 49);
            this.tb_stuId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_stuId.Name = "tb_stuId";
            this.tb_stuId.ReadOnly = true;
            this.tb_stuId.Size = new System.Drawing.Size(216, 25);
            this.tb_stuId.TabIndex = 25;
            // 
            // lb_stuId
            // 
            this.lb_stuId.AutoSize = true;
            this.lb_stuId.Location = new System.Drawing.Point(247, 52);
            this.lb_stuId.Name = "lb_stuId";
            this.lb_stuId.Size = new System.Drawing.Size(45, 15);
            this.lb_stuId.TabIndex = 24;
            this.lb_stuId.Text = "学 号";
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // UpdateStuInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.change_button);
            this.Controls.Add(this.cb_stuMajor);
            this.Controls.Add(this.cb_stuGrade);
            this.Controls.Add(this.tb_stuClass);
            this.Controls.Add(this.lb_className);
            this.Controls.Add(this.lb_sex);
            this.Controls.Add(this.sex_gird);
            this.Controls.Add(this.sex_boy);
            this.Controls.Add(this.tb_stuHome);
            this.Controls.Add(this.lb_home);
            this.Controls.Add(this.lb_major);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_stuName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_stuId);
            this.Controls.Add(this.lb_stuId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UpdateStuInfo";
            this.Text = "修改学生信息";
            this.Load += new System.EventHandler(this.UpdateStuInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button change_button;
        private System.Windows.Forms.ComboBox cb_stuMajor;
        private System.Windows.Forms.TextBox cb_stuGrade;
        private System.Windows.Forms.TextBox tb_stuClass;
        private System.Windows.Forms.Label lb_className;
        private System.Windows.Forms.Label lb_sex;
        private System.Windows.Forms.RadioButton sex_gird;
        private System.Windows.Forms.RadioButton sex_boy;
        private System.Windows.Forms.TextBox tb_stuHome;
        private System.Windows.Forms.Label lb_home;
        private System.Windows.Forms.Label lb_major;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_stuName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_stuId;
        private System.Windows.Forms.Label lb_stuId;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}