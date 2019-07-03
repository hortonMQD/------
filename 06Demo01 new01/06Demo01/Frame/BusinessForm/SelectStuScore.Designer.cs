namespace _06Demo01.Frame.BusinessForm
{
    partial class SelectStuScore
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
            this.tb_stuName = new System.Windows.Forms.TextBox();
            this.lb_stuName = new System.Windows.Forms.Label();
            this.cb_className = new System.Windows.Forms.ComboBox();
            this.lb_className = new System.Windows.Forms.Label();
            this.bt_select = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
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
            // tb_stuName
            // 
            this.tb_stuName.Location = new System.Drawing.Point(214, 59);
            this.tb_stuName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_stuName.Name = "tb_stuName";
            this.tb_stuName.Size = new System.Drawing.Size(100, 25);
            this.tb_stuName.TabIndex = 20;
            // 
            // lb_stuName
            // 
            this.lb_stuName.AutoSize = true;
            this.lb_stuName.Location = new System.Drawing.Point(83, 62);
            this.lb_stuName.Name = "lb_stuName";
            this.lb_stuName.Size = new System.Drawing.Size(67, 15);
            this.lb_stuName.TabIndex = 19;
            this.lb_stuName.Text = "学生姓名";
            // 
            // cb_className
            // 
            this.cb_className.FormattingEnabled = true;
            this.cb_className.Location = new System.Drawing.Point(471, 59);
            this.cb_className.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_className.Name = "cb_className";
            this.cb_className.Size = new System.Drawing.Size(121, 23);
            this.cb_className.TabIndex = 18;
            // 
            // lb_className
            // 
            this.lb_className.AutoSize = true;
            this.lb_className.Location = new System.Drawing.Point(371, 62);
            this.lb_className.Name = "lb_className";
            this.lb_className.Size = new System.Drawing.Size(67, 15);
            this.lb_className.TabIndex = 17;
            this.lb_className.Text = "课程名称";
            // 
            // bt_select
            // 
            this.bt_select.Location = new System.Drawing.Point(674, 60);
            this.bt_select.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_select.Name = "bt_select";
            this.bt_select.Size = new System.Drawing.Size(75, 22);
            this.bt_select.TabIndex = 14;
            this.bt_select.Text = "查 询";
            this.bt_select.UseVisualStyleBackColor = true;
            this.bt_select.Click += new System.EventHandler(this.bt_select_Click);
            // 
            // bt_update
            // 
            this.bt_update.Location = new System.Drawing.Point(788, 60);
            this.bt_update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(75, 22);
            this.bt_update.TabIndex = 21;
            this.bt_update.Text = "修 改";
            this.bt_update.UseVisualStyleBackColor = true;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.dataGridView1.Location = new System.Drawing.Point(16, 127);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(887, 349);
            this.dataGridView1.TabIndex = 22;
            // 
            // stuIdDataGridViewTextBoxColumn
            // 
            this.stuIdDataGridViewTextBoxColumn.DataPropertyName = "stuId";
            this.stuIdDataGridViewTextBoxColumn.HeaderText = "学号";
            this.stuIdDataGridViewTextBoxColumn.Name = "stuIdDataGridViewTextBoxColumn";
            // 
            // stuNameDataGridViewTextBoxColumn
            // 
            this.stuNameDataGridViewTextBoxColumn.DataPropertyName = "stuName";
            this.stuNameDataGridViewTextBoxColumn.HeaderText = "学生姓名";
            this.stuNameDataGridViewTextBoxColumn.Name = "stuNameDataGridViewTextBoxColumn";
            // 
            // courseNameDataGridViewTextBoxColumn
            // 
            this.courseNameDataGridViewTextBoxColumn.DataPropertyName = "courseName";
            this.courseNameDataGridViewTextBoxColumn.HeaderText = "课程名称";
            this.courseNameDataGridViewTextBoxColumn.Name = "courseNameDataGridViewTextBoxColumn";
            // 
            // courseTypeDataGridViewTextBoxColumn
            // 
            this.courseTypeDataGridViewTextBoxColumn.DataPropertyName = "courseType";
            this.courseTypeDataGridViewTextBoxColumn.HeaderText = "课程类型";
            this.courseTypeDataGridViewTextBoxColumn.Name = "courseTypeDataGridViewTextBoxColumn";
            // 
            // teaNameDataGridViewTextBoxColumn
            // 
            this.teaNameDataGridViewTextBoxColumn.DataPropertyName = "teaName";
            this.teaNameDataGridViewTextBoxColumn.HeaderText = "授课老师";
            this.teaNameDataGridViewTextBoxColumn.Name = "teaNameDataGridViewTextBoxColumn";
            // 
            // teaDutiesDataGridViewTextBoxColumn
            // 
            this.teaDutiesDataGridViewTextBoxColumn.DataPropertyName = "teaDuties";
            this.teaDutiesDataGridViewTextBoxColumn.HeaderText = "老师职务";
            this.teaDutiesDataGridViewTextBoxColumn.Name = "teaDutiesDataGridViewTextBoxColumn";
            // 
            // teaTelephoneDataGridViewTextBoxColumn
            // 
            this.teaTelephoneDataGridViewTextBoxColumn.DataPropertyName = "teaTelephone";
            this.teaTelephoneDataGridViewTextBoxColumn.HeaderText = "老师电话";
            this.teaTelephoneDataGridViewTextBoxColumn.Name = "teaTelephoneDataGridViewTextBoxColumn";
            // 
            // resultDataGridViewTextBoxColumn
            // 
            this.resultDataGridViewTextBoxColumn.DataPropertyName = "result";
            this.resultDataGridViewTextBoxColumn.HeaderText = "分数";
            this.resultDataGridViewTextBoxColumn.Name = "resultDataGridViewTextBoxColumn";
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
            // SelectStuScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(919, 491);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_update);
            this.Controls.Add(this.tb_stuName);
            this.Controls.Add(this.lb_stuName);
            this.Controls.Add(this.cb_className);
            this.Controls.Add(this.lb_className);
            this.Controls.Add(this.bt_select);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SelectStuScore";
            this.Text = "selectStuScore";
            this.Load += new System.EventHandler(this.selectStuScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuCourBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stu_Course_New)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_stuName;
        private System.Windows.Forms.Label lb_stuName;
        private System.Windows.Forms.ComboBox cb_className;
        private System.Windows.Forms.Label lb_className;
        private System.Windows.Forms.Button bt_select;
        private System.Windows.Forms.Button bt_update;
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