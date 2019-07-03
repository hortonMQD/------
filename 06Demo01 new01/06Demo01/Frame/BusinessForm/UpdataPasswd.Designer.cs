namespace _06Demo01.Frame.BusinessForm
{
    partial class UpdataPasswd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdataPasswd));
            this.cb_qx = new System.Windows.Forms.ComboBox();
            this.bt_ok = new System.Windows.Forms.Button();
            this.tb_passwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.tb_Id = new System.Windows.Forms.TextBox();
            this.lb_Id = new System.Windows.Forms.Label();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.SuspendLayout();
            // 
            // cb_qx
            // 
            this.cb_qx.FormattingEnabled = true;
            this.cb_qx.Items.AddRange(new object[] {
            "学生",
            "教师"});
            this.cb_qx.Location = new System.Drawing.Point(191, 208);
            this.cb_qx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_qx.Name = "cb_qx";
            this.cb_qx.Size = new System.Drawing.Size(100, 23);
            this.cb_qx.TabIndex = 18;
            // 
            // bt_ok
            // 
            this.bt_ok.Location = new System.Drawing.Point(349, 312);
            this.bt_ok.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(75, 22);
            this.bt_ok.TabIndex = 17;
            this.bt_ok.Text = "确  定";
            this.bt_ok.UseVisualStyleBackColor = true;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // tb_passwd
            // 
            this.tb_passwd.Location = new System.Drawing.Point(509, 211);
            this.tb_passwd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_passwd.Name = "tb_passwd";
            this.tb_passwd.Size = new System.Drawing.Size(100, 25);
            this.tb_passwd.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(459, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "权限";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(509, 138);
            this.tb_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(100, 25);
            this.tb_name.TabIndex = 13;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(459, 141);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(37, 15);
            this.lb_name.TabIndex = 12;
            this.lb_name.Text = "姓名";
            // 
            // tb_Id
            // 
            this.tb_Id.Location = new System.Drawing.Point(191, 138);
            this.tb_Id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Id.Name = "tb_Id";
            this.tb_Id.Size = new System.Drawing.Size(100, 25);
            this.tb_Id.TabIndex = 11;
            // 
            // lb_Id
            // 
            this.lb_Id.AutoSize = true;
            this.lb_Id.Location = new System.Drawing.Point(140, 141);
            this.lb_Id.Name = "lb_Id";
            this.lb_Id.Size = new System.Drawing.Size(23, 15);
            this.lb_Id.TabIndex = 10;
            this.lb_Id.Text = "ID";
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // UpdataPasswd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb_qx);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.tb_passwd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.tb_Id);
            this.Controls.Add(this.lb_Id);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UpdataPasswd";
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.UpdataPasswd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_qx;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.TextBox tb_passwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.TextBox tb_Id;
        private System.Windows.Forms.Label lb_Id;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}