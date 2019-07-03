namespace _06Demo01.Frame.BusinessForm
{
    partial class AddCourse
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
            this.bt_cancel = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.tb_CourseTime = new System.Windows.Forms.TextBox();
            this.lb_ClassTime = new System.Windows.Forms.Label();
            this.tb_className = new System.Windows.Forms.TextBox();
            this.cb_classType = new System.Windows.Forms.ComboBox();
            this.lb_classType = new System.Windows.Forms.Label();
            this.cb_classTeacher = new System.Windows.Forms.ComboBox();
            this.lb_classTeacher = new System.Windows.Forms.Label();
            this.lb_className = new System.Windows.Forms.Label();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.SuspendLayout();
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(479, 435);
            this.bt_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 22);
            this.bt_cancel.TabIndex = 38;
            this.bt_cancel.Text = "取  消";
            this.bt_cancel.UseVisualStyleBackColor = true;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(305, 435);
            this.add_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 22);
            this.add_button.TabIndex = 37;
            this.add_button.Text = "添  加";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // tb_CourseTime
            // 
            this.tb_CourseTime.Location = new System.Drawing.Point(396, 241);
            this.tb_CourseTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_CourseTime.Name = "tb_CourseTime";
            this.tb_CourseTime.Size = new System.Drawing.Size(255, 25);
            this.tb_CourseTime.TabIndex = 36;
            // 
            // lb_ClassTime
            // 
            this.lb_ClassTime.AutoSize = true;
            this.lb_ClassTime.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lb_ClassTime.Location = new System.Drawing.Point(240, 244);
            this.lb_ClassTime.Name = "lb_ClassTime";
            this.lb_ClassTime.Size = new System.Drawing.Size(67, 15);
            this.lb_ClassTime.TabIndex = 35;
            this.lb_ClassTime.Text = "课程时长";
            // 
            // tb_className
            // 
            this.tb_className.Location = new System.Drawing.Point(396, 121);
            this.tb_className.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_className.Name = "tb_className";
            this.tb_className.Size = new System.Drawing.Size(255, 25);
            this.tb_className.TabIndex = 34;
            // 
            // cb_classType
            // 
            this.cb_classType.FormattingEnabled = true;
            this.cb_classType.Items.AddRange(new object[] {
            "必修课",
            "选修课"});
            this.cb_classType.Location = new System.Drawing.Point(396, 182);
            this.cb_classType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_classType.Name = "cb_classType";
            this.cb_classType.Size = new System.Drawing.Size(255, 23);
            this.cb_classType.TabIndex = 33;
            // 
            // lb_classType
            // 
            this.lb_classType.AutoSize = true;
            this.lb_classType.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lb_classType.Location = new System.Drawing.Point(240, 185);
            this.lb_classType.Name = "lb_classType";
            this.lb_classType.Size = new System.Drawing.Size(67, 15);
            this.lb_classType.TabIndex = 32;
            this.lb_classType.Text = "课程类型";
            // 
            // cb_classTeacher
            // 
            this.cb_classTeacher.FormattingEnabled = true;
            this.cb_classTeacher.Location = new System.Drawing.Point(396, 306);
            this.cb_classTeacher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_classTeacher.Name = "cb_classTeacher";
            this.cb_classTeacher.Size = new System.Drawing.Size(255, 23);
            this.cb_classTeacher.TabIndex = 31;
            // 
            // lb_classTeacher
            // 
            this.lb_classTeacher.AutoSize = true;
            this.lb_classTeacher.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lb_classTeacher.ForeColor = System.Drawing.Color.Black;
            this.lb_classTeacher.Location = new System.Drawing.Point(240, 309);
            this.lb_classTeacher.Name = "lb_classTeacher";
            this.lb_classTeacher.Size = new System.Drawing.Size(67, 15);
            this.lb_classTeacher.TabIndex = 30;
            this.lb_classTeacher.Text = "授课老师";
            // 
            // lb_className
            // 
            this.lb_className.AutoSize = true;
            this.lb_className.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lb_className.Location = new System.Drawing.Point(240, 124);
            this.lb_className.Name = "lb_className";
            this.lb_className.Size = new System.Drawing.Size(67, 15);
            this.lb_className.TabIndex = 29;
            this.lb_className.Text = "课程名称";
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // AddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(947, 568);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.tb_CourseTime);
            this.Controls.Add(this.lb_ClassTime);
            this.Controls.Add(this.tb_className);
            this.Controls.Add(this.cb_classType);
            this.Controls.Add(this.lb_classType);
            this.Controls.Add(this.cb_classTeacher);
            this.Controls.Add(this.lb_classTeacher);
            this.Controls.Add(this.lb_className);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddCourse";
            this.Text = "addCourse";
            this.Load += new System.EventHandler(this.AddCourse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.TextBox tb_CourseTime;
        private System.Windows.Forms.Label lb_ClassTime;
        private System.Windows.Forms.TextBox tb_className;
        private System.Windows.Forms.ComboBox cb_classType;
        private System.Windows.Forms.Label lb_classType;
        private System.Windows.Forms.ComboBox cb_classTeacher;
        private System.Windows.Forms.Label lb_classTeacher;
        private System.Windows.Forms.Label lb_className;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}