namespace _06Demo01.Frame.BusinessForm
{
    partial class SelectTeaInfo
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
            this.tb_teaName = new System.Windows.Forms.TextBox();
            this.lb_stuName = new System.Windows.Forms.Label();
            this.tb_teaId = new System.Windows.Forms.TextBox();
            this.lb_Id = new System.Windows.Forms.Label();
            this.bt_select = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.dgv_teaInfo = new System.Windows.Forms.DataGridView();
            this.teaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teaNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teaSexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teaDutiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teaTelephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.teacher_New = new _06Demo01.teacher_New();
            this.teacher = new _06Demo01.Teacher();
            this.teacherTableAdapter = new _06Demo01.TeacherTableAdapters.teacherTableAdapter();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherTableAdapter1 = new _06Demo01.teacher_NewTableAdapters.teacherTableAdapter();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            ((System.ComponentModel.ISupportInitialize)(this.dgv_teaInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacher_New)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_change
            // 
            this.bt_change.Location = new System.Drawing.Point(677, 54);
            this.bt_change.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_change.Name = "bt_change";
            this.bt_change.Size = new System.Drawing.Size(75, 22);
            this.bt_change.TabIndex = 52;
            this.bt_change.Text = "修 改";
            this.bt_change.UseVisualStyleBackColor = true;
            this.bt_change.Click += new System.EventHandler(this.bt_change_Click);
            // 
            // tb_teaName
            // 
            this.tb_teaName.Location = new System.Drawing.Point(378, 51);
            this.tb_teaName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_teaName.Name = "tb_teaName";
            this.tb_teaName.Size = new System.Drawing.Size(100, 25);
            this.tb_teaName.TabIndex = 47;
            // 
            // lb_stuName
            // 
            this.lb_stuName.AutoSize = true;
            this.lb_stuName.Location = new System.Drawing.Point(317, 54);
            this.lb_stuName.Name = "lb_stuName";
            this.lb_stuName.Size = new System.Drawing.Size(37, 15);
            this.lb_stuName.TabIndex = 46;
            this.lb_stuName.Text = "姓名";
            // 
            // tb_teaId
            // 
            this.tb_teaId.Location = new System.Drawing.Point(183, 51);
            this.tb_teaId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_teaId.Name = "tb_teaId";
            this.tb_teaId.Size = new System.Drawing.Size(100, 25);
            this.tb_teaId.TabIndex = 43;
            // 
            // lb_Id
            // 
            this.lb_Id.AutoSize = true;
            this.lb_Id.Location = new System.Drawing.Point(90, 54);
            this.lb_Id.Name = "lb_Id";
            this.lb_Id.Size = new System.Drawing.Size(67, 15);
            this.lb_Id.TabIndex = 42;
            this.lb_Id.Text = "教师编号";
            // 
            // bt_select
            // 
            this.bt_select.Location = new System.Drawing.Point(565, 54);
            this.bt_select.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_select.Name = "bt_select";
            this.bt_select.Size = new System.Drawing.Size(75, 22);
            this.bt_select.TabIndex = 41;
            this.bt_select.Text = "查 询";
            this.bt_select.UseVisualStyleBackColor = true;
            this.bt_select.Click += new System.EventHandler(this.bt_select_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(787, 54);
            this.bt_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(75, 22);
            this.bt_delete.TabIndex = 40;
            this.bt_delete.Text = "删 除";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // dgv_teaInfo
            // 
            this.dgv_teaInfo.AllowUserToAddRows = false;
            this.dgv_teaInfo.AllowUserToDeleteRows = false;
            this.dgv_teaInfo.AutoGenerateColumns = false;
            this.dgv_teaInfo.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_teaInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_teaInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_teaInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teaIdDataGridViewTextBoxColumn,
            this.teaNameDataGridViewTextBoxColumn,
            this.teaSexDataGridViewTextBoxColumn,
            this.teaDutiesDataGridViewTextBoxColumn,
            this.teaTelephoneDataGridViewTextBoxColumn});
            this.dgv_teaInfo.DataSource = this.teacherBindingSource1;
            this.dgv_teaInfo.Location = new System.Drawing.Point(21, 116);
            this.dgv_teaInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_teaInfo.Name = "dgv_teaInfo";
            this.dgv_teaInfo.ReadOnly = true;
            this.dgv_teaInfo.RowTemplate.Height = 27;
            this.dgv_teaInfo.Size = new System.Drawing.Size(941, 398);
            this.dgv_teaInfo.TabIndex = 39;
            this.dgv_teaInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_teaInfo_CellContentClick);
            // 
            // teaIdDataGridViewTextBoxColumn
            // 
            this.teaIdDataGridViewTextBoxColumn.DataPropertyName = "teaId";
            this.teaIdDataGridViewTextBoxColumn.HeaderText = "教师编号";
            this.teaIdDataGridViewTextBoxColumn.Name = "teaIdDataGridViewTextBoxColumn";
            this.teaIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // teaNameDataGridViewTextBoxColumn
            // 
            this.teaNameDataGridViewTextBoxColumn.DataPropertyName = "teaName";
            this.teaNameDataGridViewTextBoxColumn.HeaderText = "姓名";
            this.teaNameDataGridViewTextBoxColumn.Name = "teaNameDataGridViewTextBoxColumn";
            this.teaNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // teaSexDataGridViewTextBoxColumn
            // 
            this.teaSexDataGridViewTextBoxColumn.DataPropertyName = "teaSex";
            this.teaSexDataGridViewTextBoxColumn.HeaderText = "性别";
            this.teaSexDataGridViewTextBoxColumn.Name = "teaSexDataGridViewTextBoxColumn";
            this.teaSexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // teaDutiesDataGridViewTextBoxColumn
            // 
            this.teaDutiesDataGridViewTextBoxColumn.DataPropertyName = "teaDuties";
            this.teaDutiesDataGridViewTextBoxColumn.HeaderText = "职务";
            this.teaDutiesDataGridViewTextBoxColumn.Name = "teaDutiesDataGridViewTextBoxColumn";
            this.teaDutiesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // teaTelephoneDataGridViewTextBoxColumn
            // 
            this.teaTelephoneDataGridViewTextBoxColumn.DataPropertyName = "teaTelephone";
            this.teaTelephoneDataGridViewTextBoxColumn.HeaderText = "电话";
            this.teaTelephoneDataGridViewTextBoxColumn.Name = "teaTelephoneDataGridViewTextBoxColumn";
            this.teaTelephoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // teacherBindingSource1
            // 
            this.teacherBindingSource1.DataMember = "teacher";
            this.teacherBindingSource1.DataSource = this.teacher_New;
            // 
            // teacher_New
            // 
            this.teacher_New.DataSetName = "teacher_New";
            this.teacher_New.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teacher
            // 
            this.teacher.DataSetName = "Teacher";
            this.teacher.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teacherTableAdapter
            // 
            this.teacherTableAdapter.ClearBeforeFill = true;
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataMember = "teacher";
            this.teacherBindingSource.DataSource = this.teacher;
            // 
            // teacherTableAdapter1
            // 
            this.teacherTableAdapter1.ClearBeforeFill = true;
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // SelectTeaInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(981, 548);
            this.Controls.Add(this.bt_change);
            this.Controls.Add(this.tb_teaName);
            this.Controls.Add(this.lb_stuName);
            this.Controls.Add(this.tb_teaId);
            this.Controls.Add(this.lb_Id);
            this.Controls.Add(this.bt_select);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.dgv_teaInfo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SelectTeaInfo";
            this.Text = "selectTeaInfo";
            this.Load += new System.EventHandler(this.selectTeaInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_teaInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacher_New)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_change;
        private System.Windows.Forms.TextBox tb_teaName;
        private System.Windows.Forms.Label lb_stuName;
        private System.Windows.Forms.TextBox tb_teaId;
        private System.Windows.Forms.Label lb_Id;
        private System.Windows.Forms.Button bt_select;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.DataGridView dgv_teaInfo;
        private Teacher teacher;
        private TeacherTableAdapters.teacherTableAdapter teacherTableAdapter;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private teacher_New teacher_New;
        private teacher_NewTableAdapters.teacherTableAdapter teacherTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn teaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teaNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teaSexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teaDutiesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teaTelephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource teacherBindingSource1;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}