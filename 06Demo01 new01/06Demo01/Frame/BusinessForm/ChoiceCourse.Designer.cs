namespace _06Demo01.Frame.BusinessForm
{
    partial class ChoiceCourse
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
            this.cb_className = new System.Windows.Forms.ComboBox();
            this.lb_className = new System.Windows.Forms.Label();
            this.tb_stuId = new System.Windows.Forms.TextBox();
            this.lb_stuId = new System.Windows.Forms.Label();
            this.bt_add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stuIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teaNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teaDutiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teaTelephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuCourBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stu_Course_New = new _06Demo01.Stu_Course_New();
            this.stu_CourTableAdapter = new _06Demo01.Stu_Course_NewTableAdapters.Stu_CourTableAdapter();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuCourBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stu_Course_New)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_className
            // 
            this.cb_className.FormattingEnabled = true;
            this.cb_className.Location = new System.Drawing.Point(428, 75);
            this.cb_className.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_className.Name = "cb_className";
            this.cb_className.Size = new System.Drawing.Size(121, 23);
            this.cb_className.TabIndex = 24;
            // 
            // lb_className
            // 
            this.lb_className.AutoSize = true;
            this.lb_className.Location = new System.Drawing.Point(318, 80);
            this.lb_className.Name = "lb_className";
            this.lb_className.Size = new System.Drawing.Size(67, 15);
            this.lb_className.TabIndex = 23;
            this.lb_className.Text = "课程名称";
            // 
            // tb_stuId
            // 
            this.tb_stuId.Location = new System.Drawing.Point(145, 73);
            this.tb_stuId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_stuId.Name = "tb_stuId";
            this.tb_stuId.Size = new System.Drawing.Size(126, 25);
            this.tb_stuId.TabIndex = 22;
            // 
            // lb_stuId
            // 
            this.lb_stuId.AutoSize = true;
            this.lb_stuId.Location = new System.Drawing.Point(33, 80);
            this.lb_stuId.Name = "lb_stuId";
            this.lb_stuId.Size = new System.Drawing.Size(67, 15);
            this.lb_stuId.TabIndex = 21;
            this.lb_stuId.Text = "学生学号";
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(648, 76);
            this.bt_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(75, 22);
            this.bt_add.TabIndex = 20;
            this.bt_add.Text = "添 加";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stuIdDataGridViewTextBoxColumn,
            this.stuNameDataGridViewTextBoxColumn,
            this.courseNameDataGridViewTextBoxColumn,
            this.courseTypeDataGridViewTextBoxColumn,
            this.teaNameDataGridViewTextBoxColumn,
            this.teaDutiesDataGridViewTextBoxColumn,
            this.teaTelephoneDataGridViewTextBoxColumn,
            this.resultDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stuCourBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(36, 143);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(749, 304);
            this.dataGridView1.TabIndex = 19;
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
            // courseTypeDataGridViewTextBoxColumn
            // 
            this.courseTypeDataGridViewTextBoxColumn.DataPropertyName = "courseType";
            this.courseTypeDataGridViewTextBoxColumn.HeaderText = "课程类型";
            this.courseTypeDataGridViewTextBoxColumn.Name = "courseTypeDataGridViewTextBoxColumn";
            this.courseTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // teaNameDataGridViewTextBoxColumn
            // 
            this.teaNameDataGridViewTextBoxColumn.DataPropertyName = "teaName";
            this.teaNameDataGridViewTextBoxColumn.HeaderText = "授课老师";
            this.teaNameDataGridViewTextBoxColumn.Name = "teaNameDataGridViewTextBoxColumn";
            this.teaNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // teaDutiesDataGridViewTextBoxColumn
            // 
            this.teaDutiesDataGridViewTextBoxColumn.DataPropertyName = "teaDuties";
            this.teaDutiesDataGridViewTextBoxColumn.HeaderText = "老师职务";
            this.teaDutiesDataGridViewTextBoxColumn.Name = "teaDutiesDataGridViewTextBoxColumn";
            this.teaDutiesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // teaTelephoneDataGridViewTextBoxColumn
            // 
            this.teaTelephoneDataGridViewTextBoxColumn.DataPropertyName = "teaTelephone";
            this.teaTelephoneDataGridViewTextBoxColumn.HeaderText = "老师电话";
            this.teaTelephoneDataGridViewTextBoxColumn.Name = "teaTelephoneDataGridViewTextBoxColumn";
            this.teaTelephoneDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.stuCourBindingSource.DataSource = this.stu_Course_New;
            // 
            // stu_Course_New
            // 
            this.stu_Course_New.DataSetName = "Stu_Course_New";
            this.stu_Course_New.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stu_CourTableAdapter
            // 
            this.stu_CourTableAdapter.ClearBeforeFill = true;
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // ChoiceCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(819, 484);
            this.Controls.Add(this.cb_className);
            this.Controls.Add(this.lb_className);
            this.Controls.Add(this.tb_stuId);
            this.Controls.Add(this.lb_stuId);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ChoiceCourse";
            this.Text = "choiceCourse";
            this.Load += new System.EventHandler(this.choiceCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuCourBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stu_Course_New)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_className;
        private System.Windows.Forms.Label lb_className;
        private System.Windows.Forms.TextBox tb_stuId;
        private System.Windows.Forms.Label lb_stuId;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Stu_Course_New stu_Course_New;
        private System.Windows.Forms.BindingSource stuCourBindingSource;
        private Stu_Course_NewTableAdapters.Stu_CourTableAdapter stu_CourTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teaNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teaDutiesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teaTelephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultDataGridViewTextBoxColumn;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}