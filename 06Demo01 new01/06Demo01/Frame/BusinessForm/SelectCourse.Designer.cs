namespace _06Demo01.Frame.BusinessForm
{
    partial class SelectCourse
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
            this.cb_classTeacher = new System.Windows.Forms.ComboBox();
            this.lb_classTeacher = new System.Windows.Forms.Label();
            this.bt_select = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.courseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teaNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teaDutiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teaTelephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teaCourBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tea_Course_New = new _06Demo01.Tea_Course_New();
            this.tea_Cour_View = new _06Demo01.Tea_Cour_View();
            this.bt_update = new System.Windows.Forms.Button();
            this.tea_CourTableAdapter = new _06Demo01.Tea_Cour_ViewTableAdapters.Tea_CourTableAdapter();
            this.cb_courseType = new System.Windows.Forms.ComboBox();
            this.lb_courseType = new System.Windows.Forms.Label();
            this.tea_CourTableAdapter1 = new _06Demo01.Tea_Course_NewTableAdapters.Tea_CourTableAdapter();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine2 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teaCourBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tea_Course_New)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tea_Cour_View)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_classTeacher
            // 
            this.cb_classTeacher.FormattingEnabled = true;
            this.cb_classTeacher.Location = new System.Drawing.Point(131, 40);
            this.cb_classTeacher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_classTeacher.Name = "cb_classTeacher";
            this.cb_classTeacher.Size = new System.Drawing.Size(121, 23);
            this.cb_classTeacher.TabIndex = 12;
            // 
            // lb_classTeacher
            // 
            this.lb_classTeacher.AutoSize = true;
            this.lb_classTeacher.Location = new System.Drawing.Point(31, 43);
            this.lb_classTeacher.Name = "lb_classTeacher";
            this.lb_classTeacher.Size = new System.Drawing.Size(67, 15);
            this.lb_classTeacher.TabIndex = 9;
            this.lb_classTeacher.Text = "授课老师";
            // 
            // bt_select
            // 
            this.bt_select.Location = new System.Drawing.Point(577, 41);
            this.bt_select.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_select.Name = "bt_select";
            this.bt_select.Size = new System.Drawing.Size(75, 22);
            this.bt_select.TabIndex = 8;
            this.bt_select.Text = "查 询";
            this.bt_select.UseVisualStyleBackColor = true;
            this.bt_select.Click += new System.EventHandler(this.bt_select_Click);
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
            this.courseNameDataGridViewTextBoxColumn,
            this.courseTypeDataGridViewTextBoxColumn,
            this.teaNameDataGridViewTextBoxColumn,
            this.teaDutiesDataGridViewTextBoxColumn,
            this.teaTelephoneDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.teaCourBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(17, 119);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(799, 311);
            this.dataGridView1.TabIndex = 7;
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
            this.teaNameDataGridViewTextBoxColumn.HeaderText = "老师姓名";
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
            // teaCourBindingSource
            // 
            this.teaCourBindingSource.DataMember = "Tea_Cour";
            this.teaCourBindingSource.DataSource = this.tea_Course_New;
            // 
            // tea_Course_New
            // 
            this.tea_Course_New.DataSetName = "Tea_Course_New";
            this.tea_Course_New.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tea_Cour_View
            // 
            this.tea_Cour_View.DataSetName = "Tea_Cour_View";
            this.tea_Cour_View.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bt_update
            // 
            this.bt_update.Location = new System.Drawing.Point(696, 41);
            this.bt_update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(75, 22);
            this.bt_update.TabIndex = 13;
            this.bt_update.Text = "修 改";
            this.bt_update.UseVisualStyleBackColor = true;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // tea_CourTableAdapter
            // 
            this.tea_CourTableAdapter.ClearBeforeFill = true;
            // 
            // cb_courseType
            // 
            this.cb_courseType.FormattingEnabled = true;
            this.cb_courseType.Items.AddRange(new object[] {
            "必修课",
            "选修课"});
            this.cb_courseType.Location = new System.Drawing.Point(394, 40);
            this.cb_courseType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_courseType.Name = "cb_courseType";
            this.cb_courseType.Size = new System.Drawing.Size(121, 23);
            this.cb_courseType.TabIndex = 15;
            // 
            // lb_courseType
            // 
            this.lb_courseType.AutoSize = true;
            this.lb_courseType.Location = new System.Drawing.Point(291, 43);
            this.lb_courseType.Name = "lb_courseType";
            this.lb_courseType.Size = new System.Drawing.Size(67, 15);
            this.lb_courseType.TabIndex = 14;
            this.lb_courseType.Text = "课程类型";
            // 
            // tea_CourTableAdapter1
            // 
            this.tea_CourTableAdapter1.ClearBeforeFill = true;
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // skinEngine2
            // 
            this.skinEngine2.SerialNumber = "";
            this.skinEngine2.SkinFile = null;
            // 
            // SelectCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(828, 472);
            this.Controls.Add(this.cb_courseType);
            this.Controls.Add(this.lb_courseType);
            this.Controls.Add(this.bt_update);
            this.Controls.Add(this.cb_classTeacher);
            this.Controls.Add(this.lb_classTeacher);
            this.Controls.Add(this.bt_select);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SelectCourse";
            this.Text = "selectCourse";
            this.Load += new System.EventHandler(this.selectCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teaCourBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tea_Course_New)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tea_Cour_View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_classTeacher;
        private System.Windows.Forms.Label lb_classTeacher;
        private System.Windows.Forms.Button bt_select;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_update;
        private Tea_Cour_View tea_Cour_View;
        private Tea_Cour_ViewTableAdapters.Tea_CourTableAdapter tea_CourTableAdapter;
        private System.Windows.Forms.ComboBox cb_courseType;
        private System.Windows.Forms.Label lb_courseType;
        private Tea_Course_New tea_Course_New;
        private Tea_Course_NewTableAdapters.Tea_CourTableAdapter tea_CourTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teaNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teaDutiesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teaTelephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource teaCourBindingSource;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private Sunisoft.IrisSkin.SkinEngine skinEngine2;
    }
}