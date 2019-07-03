namespace _06Demo01.Frame.BusinessForm
{
    partial class UpdateTeaCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateTeaCourse));
            this.bt_cancel = new System.Windows.Forms.Button();
            this.change_button = new System.Windows.Forms.Button();
            this.cb_courseTea = new System.Windows.Forms.ComboBox();
            this.lb_major = new System.Windows.Forms.Label();
            this.tb_courseName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.SuspendLayout();
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(218, 190);
            this.bt_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 22);
            this.bt_cancel.TabIndex = 31;
            this.bt_cancel.Text = "取  消";
            this.bt_cancel.UseVisualStyleBackColor = true;
            // 
            // change_button
            // 
            this.change_button.Location = new System.Drawing.Point(92, 190);
            this.change_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.change_button.Name = "change_button";
            this.change_button.Size = new System.Drawing.Size(75, 22);
            this.change_button.TabIndex = 30;
            this.change_button.Text = "确 定";
            this.change_button.UseVisualStyleBackColor = true;
            this.change_button.Click += new System.EventHandler(this.change_button_Click);
            // 
            // cb_courseTea
            // 
            this.cb_courseTea.FormattingEnabled = true;
            this.cb_courseTea.Location = new System.Drawing.Point(129, 117);
            this.cb_courseTea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_courseTea.Name = "cb_courseTea";
            this.cb_courseTea.Size = new System.Drawing.Size(216, 23);
            this.cb_courseTea.TabIndex = 29;
            // 
            // lb_major
            // 
            this.lb_major.AutoSize = true;
            this.lb_major.Location = new System.Drawing.Point(56, 120);
            this.lb_major.Name = "lb_major";
            this.lb_major.Size = new System.Drawing.Size(67, 15);
            this.lb_major.TabIndex = 28;
            this.lb_major.Text = "授课老师";
            // 
            // tb_courseName
            // 
            this.tb_courseName.Location = new System.Drawing.Point(129, 70);
            this.tb_courseName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_courseName.Name = "tb_courseName";
            this.tb_courseName.Size = new System.Drawing.Size(216, 25);
            this.tb_courseName.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "课程名称";
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // UpdateTeaCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(403, 282);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.change_button);
            this.Controls.Add(this.cb_courseTea);
            this.Controls.Add(this.lb_major);
            this.Controls.Add(this.tb_courseName);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UpdateTeaCourse";
            this.Text = "课程修改";
            this.Load += new System.EventHandler(this.UpdateTeaCourse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button change_button;
        private System.Windows.Forms.ComboBox cb_courseTea;
        private System.Windows.Forms.Label lb_major;
        private System.Windows.Forms.TextBox tb_courseName;
        private System.Windows.Forms.Label label5;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}