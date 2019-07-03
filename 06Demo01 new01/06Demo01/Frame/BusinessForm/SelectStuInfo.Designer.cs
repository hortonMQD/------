namespace _06Demo01.Frame.BusinessForm
{
    partial class SelectStuInfo
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
            this.bt_change = new System.Windows.Forms.Button();
            this.cb_stuSex = new System.Windows.Forms.ComboBox();
            this.lb_stuSex = new System.Windows.Forms.Label();
            this.cb_major = new System.Windows.Forms.ComboBox();
            this.lb_major = new System.Windows.Forms.Label();
            this.tb_stuName = new System.Windows.Forms.TextBox();
            this.lb_stuName = new System.Windows.Forms.Label();
            this.cb_className = new System.Windows.Forms.ComboBox();
            this.lb_className = new System.Windows.Forms.Label();
            this.tb_stuId = new System.Windows.Forms.TextBox();
            this.lb_stuId = new System.Windows.Forms.Label();
            this.bt_select = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.dgv_stuInfo = new System.Windows.Forms.DataGridView();
            this.stuIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuSexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuGradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuMajorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuClassNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuHomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentInfo = new _06Demo01.StudentInfo();
            this.studentTableAdapter = new _06Demo01.StudentInfoTableAdapters.studentTableAdapter();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stuInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_change
            // 
            this.bt_change.Location = new System.Drawing.Point(691, 511);
            this.bt_change.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_change.Name = "bt_change";
            this.bt_change.Size = new System.Drawing.Size(75, 22);
            this.bt_change.TabIndex = 38;
            this.bt_change.Text = "修 改";
            this.bt_change.UseVisualStyleBackColor = true;
            this.bt_change.Click += new System.EventHandler(this.bt_change_Click);
            // 
            // cb_stuSex
            // 
            this.cb_stuSex.FormattingEnabled = true;
            this.cb_stuSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cb_stuSex.Location = new System.Drawing.Point(377, 15);
            this.cb_stuSex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_stuSex.Name = "cb_stuSex";
            this.cb_stuSex.Size = new System.Drawing.Size(121, 23);
            this.cb_stuSex.TabIndex = 37;
            // 
            // lb_stuSex
            // 
            this.lb_stuSex.AutoSize = true;
            this.lb_stuSex.Location = new System.Drawing.Point(333, 20);
            this.lb_stuSex.Name = "lb_stuSex";
            this.lb_stuSex.Size = new System.Drawing.Size(37, 15);
            this.lb_stuSex.TabIndex = 36;
            this.lb_stuSex.Text = "性别";
            // 
            // cb_major
            // 
            this.cb_major.FormattingEnabled = true;
            this.cb_major.Location = new System.Drawing.Point(736, 16);
            this.cb_major.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_major.Name = "cb_major";
            this.cb_major.Size = new System.Drawing.Size(121, 23);
            this.cb_major.TabIndex = 35;
            // 
            // lb_major
            // 
            this.lb_major.AutoSize = true;
            this.lb_major.Location = new System.Drawing.Point(693, 18);
            this.lb_major.Name = "lb_major";
            this.lb_major.Size = new System.Drawing.Size(37, 15);
            this.lb_major.TabIndex = 34;
            this.lb_major.Text = "专业";
            // 
            // tb_stuName
            // 
            this.tb_stuName.Location = new System.Drawing.Point(219, 15);
            this.tb_stuName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_stuName.Name = "tb_stuName";
            this.tb_stuName.Size = new System.Drawing.Size(100, 25);
            this.tb_stuName.TabIndex = 33;
            // 
            // lb_stuName
            // 
            this.lb_stuName.AutoSize = true;
            this.lb_stuName.Location = new System.Drawing.Point(175, 21);
            this.lb_stuName.Name = "lb_stuName";
            this.lb_stuName.Size = new System.Drawing.Size(37, 15);
            this.lb_stuName.TabIndex = 32;
            this.lb_stuName.Text = "姓名";
            // 
            // cb_className
            // 
            this.cb_className.FormattingEnabled = true;
            this.cb_className.Location = new System.Drawing.Point(557, 15);
            this.cb_className.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_className.Name = "cb_className";
            this.cb_className.Size = new System.Drawing.Size(121, 23);
            this.cb_className.TabIndex = 31;
            // 
            // lb_className
            // 
            this.lb_className.AutoSize = true;
            this.lb_className.Location = new System.Drawing.Point(515, 20);
            this.lb_className.Name = "lb_className";
            this.lb_className.Size = new System.Drawing.Size(37, 15);
            this.lb_className.TabIndex = 30;
            this.lb_className.Text = "班级";
            // 
            // tb_stuId
            // 
            this.tb_stuId.Location = new System.Drawing.Point(52, 15);
            this.tb_stuId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_stuId.Name = "tb_stuId";
            this.tb_stuId.Size = new System.Drawing.Size(100, 25);
            this.tb_stuId.TabIndex = 29;
            // 
            // lb_stuId
            // 
            this.lb_stuId.AutoSize = true;
            this.lb_stuId.Location = new System.Drawing.Point(9, 21);
            this.lb_stuId.Name = "lb_stuId";
            this.lb_stuId.Size = new System.Drawing.Size(37, 15);
            this.lb_stuId.TabIndex = 28;
            this.lb_stuId.Text = "学号";
            // 
            // bt_select
            // 
            this.bt_select.Location = new System.Drawing.Point(877, 18);
            this.bt_select.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_select.Name = "bt_select";
            this.bt_select.Size = new System.Drawing.Size(75, 22);
            this.bt_select.TabIndex = 27;
            this.bt_select.Text = "查 询";
            this.bt_select.UseVisualStyleBackColor = true;
            this.bt_select.Click += new System.EventHandler(this.bt_select_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(787, 511);
            this.bt_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(75, 22);
            this.bt_delete.TabIndex = 26;
            this.bt_delete.Text = "删 除";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // dgv_stuInfo
            // 
            this.dgv_stuInfo.AllowUserToAddRows = false;
            this.dgv_stuInfo.AllowUserToDeleteRows = false;
            this.dgv_stuInfo.AutoGenerateColumns = false;
            this.dgv_stuInfo.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_stuInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_stuInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_stuInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stuIdDataGridViewTextBoxColumn,
            this.stuNameDataGridViewTextBoxColumn,
            this.stuSexDataGridViewTextBoxColumn,
            this.stuGradeDataGridViewTextBoxColumn,
            this.stuMajorDataGridViewTextBoxColumn,
            this.stuClassNameDataGridViewTextBoxColumn,
            this.stuHomeDataGridViewTextBoxColumn});
            this.dgv_stuInfo.DataSource = this.studentBindingSource;
            this.dgv_stuInfo.Location = new System.Drawing.Point(12, 59);
            this.dgv_stuInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_stuInfo.Name = "dgv_stuInfo";
            this.dgv_stuInfo.ReadOnly = true;
            this.dgv_stuInfo.RowTemplate.Height = 27;
            this.dgv_stuInfo.Size = new System.Drawing.Size(941, 446);
            this.dgv_stuInfo.TabIndex = 25;
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
            // stuSexDataGridViewTextBoxColumn
            // 
            this.stuSexDataGridViewTextBoxColumn.DataPropertyName = "stuSex";
            this.stuSexDataGridViewTextBoxColumn.HeaderText = "性别";
            this.stuSexDataGridViewTextBoxColumn.Name = "stuSexDataGridViewTextBoxColumn";
            this.stuSexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stuGradeDataGridViewTextBoxColumn
            // 
            this.stuGradeDataGridViewTextBoxColumn.DataPropertyName = "stuGrade";
            this.stuGradeDataGridViewTextBoxColumn.HeaderText = "年级";
            this.stuGradeDataGridViewTextBoxColumn.Name = "stuGradeDataGridViewTextBoxColumn";
            this.stuGradeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stuMajorDataGridViewTextBoxColumn
            // 
            this.stuMajorDataGridViewTextBoxColumn.DataPropertyName = "stuMajor";
            this.stuMajorDataGridViewTextBoxColumn.HeaderText = "专业";
            this.stuMajorDataGridViewTextBoxColumn.Name = "stuMajorDataGridViewTextBoxColumn";
            this.stuMajorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stuClassNameDataGridViewTextBoxColumn
            // 
            this.stuClassNameDataGridViewTextBoxColumn.DataPropertyName = "stuClassName";
            this.stuClassNameDataGridViewTextBoxColumn.HeaderText = "班级";
            this.stuClassNameDataGridViewTextBoxColumn.Name = "stuClassNameDataGridViewTextBoxColumn";
            this.stuClassNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stuHomeDataGridViewTextBoxColumn
            // 
            this.stuHomeDataGridViewTextBoxColumn.DataPropertyName = "stuHome";
            this.stuHomeDataGridViewTextBoxColumn.HeaderText = "籍贯";
            this.stuHomeDataGridViewTextBoxColumn.Name = "stuHomeDataGridViewTextBoxColumn";
            this.stuHomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "student";
            this.studentBindingSource.DataSource = this.studentInfo;
            // 
            // studentInfo
            // 
            this.studentInfo.DataSetName = "StudentInfo";
            this.studentInfo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // SelectStuInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(980, 552);
            this.Controls.Add(this.bt_change);
            this.Controls.Add(this.cb_stuSex);
            this.Controls.Add(this.lb_stuSex);
            this.Controls.Add(this.cb_major);
            this.Controls.Add(this.lb_major);
            this.Controls.Add(this.tb_stuName);
            this.Controls.Add(this.lb_stuName);
            this.Controls.Add(this.cb_className);
            this.Controls.Add(this.lb_className);
            this.Controls.Add(this.tb_stuId);
            this.Controls.Add(this.lb_stuId);
            this.Controls.Add(this.bt_select);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.dgv_stuInfo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SelectStuInfo";
            this.Text = "selectStuInfo";
            this.Load += new System.EventHandler(this.selectStuInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stuInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_change;
        private System.Windows.Forms.ComboBox cb_stuSex;
        private System.Windows.Forms.Label lb_stuSex;
        private System.Windows.Forms.ComboBox cb_major;
        private System.Windows.Forms.Label lb_major;
        private System.Windows.Forms.TextBox tb_stuName;
        private System.Windows.Forms.Label lb_stuName;
        private System.Windows.Forms.ComboBox cb_className;
        private System.Windows.Forms.Label lb_className;
        private System.Windows.Forms.TextBox tb_stuId;
        private System.Windows.Forms.Label lb_stuId;
        private System.Windows.Forms.Button bt_select;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.DataGridView dgv_stuInfo;
        private StudentInfo studentInfo;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private StudentInfoTableAdapters.studentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuSexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuGradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuMajorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuClassNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuHomeDataGridViewTextBoxColumn;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}