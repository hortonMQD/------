namespace _06Demo01.Frame.BusinessForm
{
    partial class UpdateStuScore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateStuScore));
            this.bt_cancel = new System.Windows.Forms.Button();
            this.change_button = new System.Windows.Forms.Button();
            this.tb_courseName = new System.Windows.Forms.TextBox();
            this.tb_stuScore = new System.Windows.Forms.TextBox();
            this.lb_stuScore = new System.Windows.Forms.Label();
            this.lb_courseName = new System.Windows.Forms.Label();
            this.tb_stuName = new System.Windows.Forms.TextBox();
            this.lb_stUName = new System.Windows.Forms.Label();
            this.tb_stuId = new System.Windows.Forms.TextBox();
            this.lb_stuId = new System.Windows.Forms.Label();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.SuspendLayout();
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(393, 359);
            this.bt_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 22);
            this.bt_cancel.TabIndex = 33;
            this.bt_cancel.Text = "取  消";
            this.bt_cancel.UseVisualStyleBackColor = true;
            // 
            // change_button
            // 
            this.change_button.Location = new System.Drawing.Point(277, 359);
            this.change_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.change_button.Name = "change_button";
            this.change_button.Size = new System.Drawing.Size(75, 22);
            this.change_button.TabIndex = 32;
            this.change_button.Text = "确 定";
            this.change_button.UseVisualStyleBackColor = true;
            this.change_button.Click += new System.EventHandler(this.change_button_Click);
            // 
            // tb_courseName
            // 
            this.tb_courseName.Location = new System.Drawing.Point(295, 199);
            this.tb_courseName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_courseName.Name = "tb_courseName";
            this.tb_courseName.ReadOnly = true;
            this.tb_courseName.Size = new System.Drawing.Size(216, 25);
            this.tb_courseName.TabIndex = 31;
            // 
            // tb_stuScore
            // 
            this.tb_stuScore.Location = new System.Drawing.Point(295, 256);
            this.tb_stuScore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_stuScore.Name = "tb_stuScore";
            this.tb_stuScore.Size = new System.Drawing.Size(216, 25);
            this.tb_stuScore.TabIndex = 30;
            // 
            // lb_stuScore
            // 
            this.lb_stuScore.AutoSize = true;
            this.lb_stuScore.Location = new System.Drawing.Point(244, 259);
            this.lb_stuScore.Name = "lb_stuScore";
            this.lb_stuScore.Size = new System.Drawing.Size(45, 15);
            this.lb_stuScore.TabIndex = 29;
            this.lb_stuScore.Text = "分 数";
            // 
            // lb_courseName
            // 
            this.lb_courseName.AutoSize = true;
            this.lb_courseName.Location = new System.Drawing.Point(221, 201);
            this.lb_courseName.Name = "lb_courseName";
            this.lb_courseName.Size = new System.Drawing.Size(67, 15);
            this.lb_courseName.TabIndex = 28;
            this.lb_courseName.Text = "课程名称";
            // 
            // tb_stuName
            // 
            this.tb_stuName.Location = new System.Drawing.Point(295, 135);
            this.tb_stuName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_stuName.Name = "tb_stuName";
            this.tb_stuName.ReadOnly = true;
            this.tb_stuName.Size = new System.Drawing.Size(216, 25);
            this.tb_stuName.TabIndex = 27;
            // 
            // lb_stUName
            // 
            this.lb_stUName.AutoSize = true;
            this.lb_stUName.Location = new System.Drawing.Point(244, 138);
            this.lb_stUName.Name = "lb_stUName";
            this.lb_stUName.Size = new System.Drawing.Size(45, 15);
            this.lb_stUName.TabIndex = 26;
            this.lb_stUName.Text = "姓 名";
            // 
            // tb_stuId
            // 
            this.tb_stuId.Location = new System.Drawing.Point(295, 76);
            this.tb_stuId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_stuId.Name = "tb_stuId";
            this.tb_stuId.ReadOnly = true;
            this.tb_stuId.Size = new System.Drawing.Size(216, 25);
            this.tb_stuId.TabIndex = 25;
            // 
            // lb_stuId
            // 
            this.lb_stuId.AutoSize = true;
            this.lb_stuId.Location = new System.Drawing.Point(244, 80);
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
            // UpdateStuScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.change_button);
            this.Controls.Add(this.tb_courseName);
            this.Controls.Add(this.tb_stuScore);
            this.Controls.Add(this.lb_stuScore);
            this.Controls.Add(this.lb_courseName);
            this.Controls.Add(this.tb_stuName);
            this.Controls.Add(this.lb_stUName);
            this.Controls.Add(this.tb_stuId);
            this.Controls.Add(this.lb_stuId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UpdateStuScore";
            this.Text = "学生分数修改";
            this.Load += new System.EventHandler(this.UpdateStuScore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button change_button;
        private System.Windows.Forms.TextBox tb_courseName;
        private System.Windows.Forms.TextBox tb_stuScore;
        private System.Windows.Forms.Label lb_stuScore;
        private System.Windows.Forms.Label lb_courseName;
        private System.Windows.Forms.TextBox tb_stuName;
        private System.Windows.Forms.Label lb_stUName;
        private System.Windows.Forms.TextBox tb_stuId;
        private System.Windows.Forms.Label lb_stuId;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}