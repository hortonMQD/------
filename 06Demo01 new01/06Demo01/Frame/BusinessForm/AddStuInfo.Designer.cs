namespace _06Demo01.Frame.BusinessForm
{
    partial class AddStuInfo
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
            this.cb_stuGrade = new System.Windows.Forms.ComboBox();
            this.cb_stuMajor = new System.Windows.Forms.ComboBox();
            this.tb_stuClass = new System.Windows.Forms.TextBox();
            this.lb_className = new System.Windows.Forms.Label();
            this.lb_sex = new System.Windows.Forms.Label();
            this.sex_gird = new System.Windows.Forms.RadioButton();
            this.sex_boy = new System.Windows.Forms.RadioButton();
            this.tb_stuHome = new System.Windows.Forms.TextBox();
            this.lb_home = new System.Windows.Forms.Label();
            this.lb_major = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_stuPasswd = new System.Windows.Forms.TextBox();
            this.lb_passwd = new System.Windows.Forms.Label();
            this.tb_stuName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_stuId = new System.Windows.Forms.TextBox();
            this.lb_stuId = new System.Windows.Forms.Label();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.SuspendLayout();
            // 
            // cb_stuGrade
            // 
            this.cb_stuGrade.FormattingEnabled = true;
            this.cb_stuGrade.Items.AddRange(new object[] {
            "大一",
            "大二",
            "大三",
            "大四"});
            this.cb_stuGrade.Location = new System.Drawing.Point(252, 198);
            this.cb_stuGrade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_stuGrade.Name = "cb_stuGrade";
            this.cb_stuGrade.Size = new System.Drawing.Size(216, 23);
            this.cb_stuGrade.TabIndex = 36;
            // 
            // cb_stuMajor
            // 
            this.cb_stuMajor.FormattingEnabled = true;
            this.cb_stuMajor.Location = new System.Drawing.Point(252, 246);
            this.cb_stuMajor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_stuMajor.Name = "cb_stuMajor";
            this.cb_stuMajor.Size = new System.Drawing.Size(216, 23);
            this.cb_stuMajor.TabIndex = 35;
            // 
            // tb_stuClass
            // 
            this.tb_stuClass.Location = new System.Drawing.Point(252, 300);
            this.tb_stuClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_stuClass.Name = "tb_stuClass";
            this.tb_stuClass.Size = new System.Drawing.Size(216, 25);
            this.tb_stuClass.TabIndex = 34;
            // 
            // lb_className
            // 
            this.lb_className.AutoSize = true;
            this.lb_className.Location = new System.Drawing.Point(164, 302);
            this.lb_className.Name = "lb_className";
            this.lb_className.Size = new System.Drawing.Size(45, 15);
            this.lb_className.TabIndex = 33;
            this.lb_className.Text = "班 级";
            // 
            // lb_sex
            // 
            this.lb_sex.AutoSize = true;
            this.lb_sex.Location = new System.Drawing.Point(167, 348);
            this.lb_sex.Name = "lb_sex";
            this.lb_sex.Size = new System.Drawing.Size(45, 15);
            this.lb_sex.TabIndex = 32;
            this.lb_sex.Text = "性 别";
            // 
            // sex_gird
            // 
            this.sex_gird.AutoSize = true;
            this.sex_gird.Location = new System.Drawing.Point(375, 348);
            this.sex_gird.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sex_gird.Name = "sex_gird";
            this.sex_gird.Size = new System.Drawing.Size(43, 19);
            this.sex_gird.TabIndex = 31;
            this.sex_gird.TabStop = true;
            this.sex_gird.Text = "女";
            this.sex_gird.UseVisualStyleBackColor = true;
            // 
            // sex_boy
            // 
            this.sex_boy.AutoSize = true;
            this.sex_boy.Location = new System.Drawing.Point(288, 348);
            this.sex_boy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sex_boy.Name = "sex_boy";
            this.sex_boy.Size = new System.Drawing.Size(43, 19);
            this.sex_boy.TabIndex = 30;
            this.sex_boy.TabStop = true;
            this.sex_boy.Text = "男";
            this.sex_boy.UseVisualStyleBackColor = true;
            // 
            // tb_stuHome
            // 
            this.tb_stuHome.Location = new System.Drawing.Point(252, 382);
            this.tb_stuHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_stuHome.Name = "tb_stuHome";
            this.tb_stuHome.Size = new System.Drawing.Size(216, 25);
            this.tb_stuHome.TabIndex = 29;
            // 
            // lb_home
            // 
            this.lb_home.AutoSize = true;
            this.lb_home.Location = new System.Drawing.Point(164, 385);
            this.lb_home.Name = "lb_home";
            this.lb_home.Size = new System.Drawing.Size(45, 15);
            this.lb_home.TabIndex = 28;
            this.lb_home.Text = "籍 贯";
            // 
            // lb_major
            // 
            this.lb_major.AutoSize = true;
            this.lb_major.Location = new System.Drawing.Point(164, 254);
            this.lb_major.Name = "lb_major";
            this.lb_major.Size = new System.Drawing.Size(45, 15);
            this.lb_major.TabIndex = 27;
            this.lb_major.Text = "专 业";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 26;
            this.label4.Text = "年 级";
            // 
            // tb_stuPasswd
            // 
            this.tb_stuPasswd.Location = new System.Drawing.Point(252, 142);
            this.tb_stuPasswd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_stuPasswd.Name = "tb_stuPasswd";
            this.tb_stuPasswd.Size = new System.Drawing.Size(216, 25);
            this.tb_stuPasswd.TabIndex = 25;
            // 
            // lb_passwd
            // 
            this.lb_passwd.AutoSize = true;
            this.lb_passwd.Location = new System.Drawing.Point(164, 146);
            this.lb_passwd.Name = "lb_passwd";
            this.lb_passwd.Size = new System.Drawing.Size(45, 15);
            this.lb_passwd.TabIndex = 24;
            this.lb_passwd.Text = "密 码";
            // 
            // tb_stuName
            // 
            this.tb_stuName.Location = new System.Drawing.Point(252, 86);
            this.tb_stuName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_stuName.Name = "tb_stuName";
            this.tb_stuName.Size = new System.Drawing.Size(216, 25);
            this.tb_stuName.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "姓 名";
            // 
            // tb_stuId
            // 
            this.tb_stuId.Location = new System.Drawing.Point(252, 30);
            this.tb_stuId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_stuId.Name = "tb_stuId";
            this.tb_stuId.Size = new System.Drawing.Size(216, 25);
            this.tb_stuId.TabIndex = 21;
            // 
            // lb_stuId
            // 
            this.lb_stuId.AutoSize = true;
            this.lb_stuId.Location = new System.Drawing.Point(164, 32);
            this.lb_stuId.Name = "lb_stuId";
            this.lb_stuId.Size = new System.Drawing.Size(45, 15);
            this.lb_stuId.TabIndex = 20;
            this.lb_stuId.Text = "学 号";
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(680, 386);
            this.bt_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 22);
            this.bt_cancel.TabIndex = 38;
            this.bt_cancel.Text = "取  消";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(564, 386);
            this.add_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 22);
            this.add_button.TabIndex = 37;
            this.add_button.Text = "添  加";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // AddStuInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.cb_stuGrade);
            this.Controls.Add(this.cb_stuMajor);
            this.Controls.Add(this.tb_stuClass);
            this.Controls.Add(this.lb_className);
            this.Controls.Add(this.lb_sex);
            this.Controls.Add(this.sex_gird);
            this.Controls.Add(this.sex_boy);
            this.Controls.Add(this.tb_stuHome);
            this.Controls.Add(this.lb_home);
            this.Controls.Add(this.lb_major);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_stuPasswd);
            this.Controls.Add(this.lb_passwd);
            this.Controls.Add(this.tb_stuName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_stuId);
            this.Controls.Add(this.lb_stuId);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddStuInfo";
            this.Text = "addStuInfo";
            this.Load += new System.EventHandler(this.AddStuInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_stuGrade;
        private System.Windows.Forms.ComboBox cb_stuMajor;
        private System.Windows.Forms.TextBox tb_stuClass;
        private System.Windows.Forms.Label lb_className;
        private System.Windows.Forms.Label lb_sex;
        private System.Windows.Forms.RadioButton sex_gird;
        private System.Windows.Forms.RadioButton sex_boy;
        private System.Windows.Forms.TextBox tb_stuHome;
        private System.Windows.Forms.Label lb_home;
        private System.Windows.Forms.Label lb_major;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_stuPasswd;
        private System.Windows.Forms.Label lb_passwd;
        private System.Windows.Forms.TextBox tb_stuName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_stuId;
        private System.Windows.Forms.Label lb_stuId;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button add_button;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}