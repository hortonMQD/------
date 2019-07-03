namespace _06Demo01.Frame.BusinessForm
{
    partial class AddStuScore
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stuIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuCourBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stu_Cour_View = new _06Demo01.Stu_Cour_View();
            this.stu_CourTableAdapter = new _06Demo01.Stu_Cour_ViewTableAdapters.Stu_CourTableAdapter();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.change_button = new System.Windows.Forms.Button();
            this.tb_ClassName = new System.Windows.Forms.TextBox();
            this.lb_className = new System.Windows.Forms.Label();
            this.tb_stuScore = new System.Windows.Forms.TextBox();
            this.lb_StuScore = new System.Windows.Forms.Label();
            this.tb_stuName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_stuId = new System.Windows.Forms.TextBox();
            this.lb_stuId = new System.Windows.Forms.Label();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuCourBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stu_Cour_View)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stuIdDataGridViewTextBoxColumn,
            this.stuNameDataGridViewTextBoxColumn,
            this.courseNameDataGridViewTextBoxColumn,
            this.resultDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stuCourBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(94, 26);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(633, 160);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // stuIdDataGridViewTextBoxColumn
            // 
            this.stuIdDataGridViewTextBoxColumn.DataPropertyName = "stuId";
            this.stuIdDataGridViewTextBoxColumn.HeaderText = "学号";
            this.stuIdDataGridViewTextBoxColumn.Name = "stuIdDataGridViewTextBoxColumn";
            this.stuIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stuNameDataGridViewTextBoxColumn
            // 
            this.stuNameDataGridViewTextBoxColumn.DataPropertyName = "stuName";
            this.stuNameDataGridViewTextBoxColumn.HeaderText = "姓名";
            this.stuNameDataGridViewTextBoxColumn.Name = "stuNameDataGridViewTextBoxColumn";
            this.stuNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseNameDataGridViewTextBoxColumn
            // 
            this.courseNameDataGridViewTextBoxColumn.DataPropertyName = "courseName";
            this.courseNameDataGridViewTextBoxColumn.HeaderText = "课程名称";
            this.courseNameDataGridViewTextBoxColumn.Name = "courseNameDataGridViewTextBoxColumn";
            this.courseNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resultDataGridViewTextBoxColumn
            // 
            this.resultDataGridViewTextBoxColumn.DataPropertyName = "result";
            this.resultDataGridViewTextBoxColumn.HeaderText = "分数";
            this.resultDataGridViewTextBoxColumn.Name = "resultDataGridViewTextBoxColumn";
            this.resultDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stuCourBindingSource
            // 
            this.stuCourBindingSource.DataMember = "Stu_Cour";
            this.stuCourBindingSource.DataSource = this.stu_Cour_View;
            // 
            // stu_Cour_View
            // 
            this.stu_Cour_View.DataSetName = "Stu_Cour_View";
            this.stu_Cour_View.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stu_CourTableAdapter
            // 
            this.stu_CourTableAdapter.ClearBeforeFill = true;
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(433, 395);
            this.bt_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 22);
            this.bt_cancel.TabIndex = 28;
            this.bt_cancel.Text = "取  消";
            this.bt_cancel.UseVisualStyleBackColor = true;
            // 
            // change_button
            // 
            this.change_button.Location = new System.Drawing.Point(280, 395);
            this.change_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.change_button.Name = "change_button";
            this.change_button.Size = new System.Drawing.Size(75, 22);
            this.change_button.TabIndex = 27;
            this.change_button.Text = "确 定";
            this.change_button.UseVisualStyleBackColor = true;
            this.change_button.Click += new System.EventHandler(this.change_button_Click);
            // 
            // tb_ClassName
            // 
            this.tb_ClassName.Location = new System.Drawing.Point(137, 322);
            this.tb_ClassName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_ClassName.Name = "tb_ClassName";
            this.tb_ClassName.Size = new System.Drawing.Size(216, 25);
            this.tb_ClassName.TabIndex = 26;
            // 
            // lb_className
            // 
            this.lb_className.AutoSize = true;
            this.lb_className.Location = new System.Drawing.Point(64, 326);
            this.lb_className.Name = "lb_className";
            this.lb_className.Size = new System.Drawing.Size(67, 15);
            this.lb_className.TabIndex = 25;
            this.lb_className.Text = "课程名称";
            // 
            // tb_stuScore
            // 
            this.tb_stuScore.Location = new System.Drawing.Point(499, 322);
            this.tb_stuScore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_stuScore.Name = "tb_stuScore";
            this.tb_stuScore.Size = new System.Drawing.Size(216, 25);
            this.tb_stuScore.TabIndex = 24;
            // 
            // lb_StuScore
            // 
            this.lb_StuScore.AutoSize = true;
            this.lb_StuScore.Location = new System.Drawing.Point(448, 326);
            this.lb_StuScore.Name = "lb_StuScore";
            this.lb_StuScore.Size = new System.Drawing.Size(45, 15);
            this.lb_StuScore.TabIndex = 23;
            this.lb_StuScore.Text = "分 数";
            // 
            // tb_stuName
            // 
            this.tb_stuName.Location = new System.Drawing.Point(499, 245);
            this.tb_stuName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_stuName.Name = "tb_stuName";
            this.tb_stuName.Size = new System.Drawing.Size(216, 25);
            this.tb_stuName.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(448, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "姓 名";
            // 
            // tb_stuId
            // 
            this.tb_stuId.Location = new System.Drawing.Point(139, 245);
            this.tb_stuId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_stuId.Name = "tb_stuId";
            this.tb_stuId.Size = new System.Drawing.Size(216, 25);
            this.tb_stuId.TabIndex = 20;
            // 
            // lb_stuId
            // 
            this.lb_stuId.AutoSize = true;
            this.lb_stuId.Location = new System.Drawing.Point(75, 255);
            this.lb_stuId.Name = "lb_stuId";
            this.lb_stuId.Size = new System.Drawing.Size(45, 15);
            this.lb_stuId.TabIndex = 19;
            this.lb_stuId.Text = "学 号";
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // AddStuScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.change_button);
            this.Controls.Add(this.tb_ClassName);
            this.Controls.Add(this.lb_className);
            this.Controls.Add(this.tb_stuScore);
            this.Controls.Add(this.lb_StuScore);
            this.Controls.Add(this.tb_stuName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_stuId);
            this.Controls.Add(this.lb_stuId);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddStuScore";
            this.Text = "addStuScore";
            this.Load += new System.EventHandler(this.addStuScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuCourBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stu_Cour_View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private Stu_Cour_View stu_Cour_View;
        private System.Windows.Forms.BindingSource stuCourBindingSource;
        private Stu_Cour_ViewTableAdapters.Stu_CourTableAdapter stu_CourTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button change_button;
        private System.Windows.Forms.TextBox tb_ClassName;
        private System.Windows.Forms.Label lb_className;
        private System.Windows.Forms.TextBox tb_stuScore;
        private System.Windows.Forms.Label lb_StuScore;
        private System.Windows.Forms.TextBox tb_stuName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_stuId;
        private System.Windows.Forms.Label lb_stuId;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}