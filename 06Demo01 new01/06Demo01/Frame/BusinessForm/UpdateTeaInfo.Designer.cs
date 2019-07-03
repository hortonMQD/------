namespace _06Demo01.Frame.BusinessForm
{
    partial class updateTeaInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updateTeaInfo));
            this.bt_cancel = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.cb_TeaSex = new System.Windows.Forms.ComboBox();
            this.cb_TeaDuties = new System.Windows.Forms.ComboBox();
            this.tb_TeaTelephone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_teaName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_stuId = new System.Windows.Forms.TextBox();
            this.lb_teaId = new System.Windows.Forms.Label();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.SuspendLayout();
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(412, 348);
            this.bt_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 22);
            this.bt_cancel.TabIndex = 46;
            this.bt_cancel.Text = "取  消";
            this.bt_cancel.UseVisualStyleBackColor = true;
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(296, 348);
            this.update_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(75, 22);
            this.update_button.TabIndex = 45;
            this.update_button.Text = "确  定";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // cb_TeaSex
            // 
            this.cb_TeaSex.FormattingEnabled = true;
            this.cb_TeaSex.Items.AddRange(new object[] {
            " ",
            "男",
            "女"});
            this.cb_TeaSex.Location = new System.Drawing.Point(309, 152);
            this.cb_TeaSex.Margin = new System.Windows.Forms.Padding(4);
            this.cb_TeaSex.Name = "cb_TeaSex";
            this.cb_TeaSex.Size = new System.Drawing.Size(216, 23);
            this.cb_TeaSex.TabIndex = 44;
            // 
            // cb_TeaDuties
            // 
            this.cb_TeaDuties.FormattingEnabled = true;
            this.cb_TeaDuties.Items.AddRange(new object[] {
            "  ",
            "教授",
            "副教授",
            "讲师"});
            this.cb_TeaDuties.Location = new System.Drawing.Point(309, 240);
            this.cb_TeaDuties.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_TeaDuties.Name = "cb_TeaDuties";
            this.cb_TeaDuties.Size = new System.Drawing.Size(216, 23);
            this.cb_TeaDuties.TabIndex = 43;
            // 
            // tb_TeaTelephone
            // 
            this.tb_TeaTelephone.Location = new System.Drawing.Point(309, 195);
            this.tb_TeaTelephone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_TeaTelephone.Name = "tb_TeaTelephone";
            this.tb_TeaTelephone.Size = new System.Drawing.Size(216, 25);
            this.tb_TeaTelephone.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 41;
            this.label4.Text = "性   别";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 40;
            this.label3.Text = "职   务";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 39;
            this.label1.Text = "电   话";
            // 
            // tb_teaName
            // 
            this.tb_teaName.Location = new System.Drawing.Point(309, 108);
            this.tb_teaName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_teaName.Name = "tb_teaName";
            this.tb_teaName.Size = new System.Drawing.Size(216, 25);
            this.tb_teaName.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 37;
            this.label2.Text = "姓   名";
            // 
            // tb_stuId
            // 
            this.tb_stuId.Location = new System.Drawing.Point(309, 51);
            this.tb_stuId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_stuId.Name = "tb_stuId";
            this.tb_stuId.ReadOnly = true;
            this.tb_stuId.Size = new System.Drawing.Size(216, 25);
            this.tb_stuId.TabIndex = 36;
            // 
            // lb_teaId
            // 
            this.lb_teaId.AutoSize = true;
            this.lb_teaId.Location = new System.Drawing.Point(221, 54);
            this.lb_teaId.Name = "lb_teaId";
            this.lb_teaId.Size = new System.Drawing.Size(67, 15);
            this.lb_teaId.TabIndex = 35;
            this.lb_teaId.Text = "教师编号";
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // updateTeaInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.cb_TeaSex);
            this.Controls.Add(this.cb_TeaDuties);
            this.Controls.Add(this.tb_TeaTelephone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_teaName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_stuId);
            this.Controls.Add(this.lb_teaId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "updateTeaInfo";
            this.Text = "教师信息修改";
            this.Load += new System.EventHandler(this.UpdateTeaInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.ComboBox cb_TeaSex;
        private System.Windows.Forms.ComboBox cb_TeaDuties;
        private System.Windows.Forms.TextBox tb_TeaTelephone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_teaName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_stuId;
        private System.Windows.Forms.Label lb_teaId;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}