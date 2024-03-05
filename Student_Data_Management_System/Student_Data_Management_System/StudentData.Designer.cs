namespace Student_Data_Management_System
{
    partial class frmStudentData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentData));
            this.lblStudentID = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lblBatchNo = new System.Windows.Forms.Label();
            this.cmbBatchNo = new System.Windows.Forms.ComboBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.rtbAddress = new System.Windows.Forms.RichTextBox();
            this.lblTPNo = new System.Windows.Forms.Label();
            this.txtTPNo = new System.Windows.Forms.TextBox();
            this.lblMobileNo = new System.Windows.Forms.Label();
            this.txtMobileNo = new System.Windows.Forms.TextBox();
            this.lblNICNo = new System.Windows.Forms.Label();
            this.txtNICNo = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.lblDOB = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtParentsTPNo = new System.Windows.Forms.TextBox();
            this.lblParentsTPNo = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.student_Data_Management_System_DatabaseDataSet = new Student_Data_Management_System.Student_Data_Management_System_DatabaseDataSet();
            this.studentDataTableAdapter = new Student_Data_Management_System.Student_Data_Management_System_DatabaseDataSetTableAdapters.StudentDataTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tPNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nICNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentsTPNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Data_Management_System_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudentID
            // 
            this.lblStudentID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(14, 29);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(115, 25);
            this.lblStudentID.TabIndex = 0;
            this.lblStudentID.Text = "Student ID :";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtStudentID.BackColor = System.Drawing.SystemColors.Window;
            this.txtStudentID.Location = new System.Drawing.Point(186, 26);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(185, 30);
            this.txtStudentID.TabIndex = 0;
            this.txtStudentID.Text = "KUR/A-";
            this.txtStudentID.TextChanged += new System.EventHandler(this.txtStudentID_TextChanged);
            // 
            // lblBatchNo
            // 
            this.lblBatchNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBatchNo.AutoSize = true;
            this.lblBatchNo.Location = new System.Drawing.Point(14, 91);
            this.lblBatchNo.Name = "lblBatchNo";
            this.lblBatchNo.Size = new System.Drawing.Size(108, 25);
            this.lblBatchNo.TabIndex = 0;
            this.lblBatchNo.Text = "Batch No : ";
            // 
            // cmbBatchNo
            // 
            this.cmbBatchNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbBatchNo.FormattingEnabled = true;
            this.cmbBatchNo.Items.AddRange(new object[] {
            "DITEC 130",
            "DITEC 131",
            "DITEC 132",
            "DITEC 133",
            "DITEC 134",
            "DITEC 135",
            "DITEC 136",
            "DITEC 137",
            "DITEC 138",
            "DITEC 139",
            "DITEC 140"});
            this.cmbBatchNo.Location = new System.Drawing.Point(186, 88);
            this.cmbBatchNo.Name = "cmbBatchNo";
            this.cmbBatchNo.Size = new System.Drawing.Size(185, 33);
            this.cmbBatchNo.TabIndex = 1;
            this.cmbBatchNo.SelectedIndexChanged += new System.EventHandler(this.cmbBatchNo_SelectedIndexChanged);
            // 
            // lblStudentName
            // 
            this.lblStudentName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(14, 153);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(153, 25);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "Student Name : ";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtStudentName.Location = new System.Drawing.Point(186, 150);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(426, 30);
            this.txtStudentName.TabIndex = 2;
            this.txtStudentName.TextChanged += new System.EventHandler(this.txtStudentName_TextChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(14, 215);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(96, 25);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Address :";
            // 
            // rtbAddress
            // 
            this.rtbAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rtbAddress.BackColor = System.Drawing.SystemColors.Window;
            this.rtbAddress.Location = new System.Drawing.Point(186, 212);
            this.rtbAddress.Name = "rtbAddress";
            this.rtbAddress.Size = new System.Drawing.Size(426, 96);
            this.rtbAddress.TabIndex = 3;
            this.rtbAddress.Text = "";
            this.rtbAddress.TextChanged += new System.EventHandler(this.rtbAddress_TextChanged);
            // 
            // lblTPNo
            // 
            this.lblTPNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTPNo.AutoSize = true;
            this.lblTPNo.Location = new System.Drawing.Point(14, 343);
            this.lblTPNo.Name = "lblTPNo";
            this.lblTPNo.Size = new System.Drawing.Size(79, 25);
            this.lblTPNo.TabIndex = 0;
            this.lblTPNo.Text = "TP No :";
            // 
            // txtTPNo
            // 
            this.txtTPNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTPNo.Location = new System.Drawing.Point(186, 340);
            this.txtTPNo.Name = "txtTPNo";
            this.txtTPNo.Size = new System.Drawing.Size(185, 30);
            this.txtTPNo.TabIndex = 4;
            this.txtTPNo.TextChanged += new System.EventHandler(this.txtTPNo_TextChanged);
            // 
            // lblMobileNo
            // 
            this.lblMobileNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMobileNo.AutoSize = true;
            this.lblMobileNo.Location = new System.Drawing.Point(14, 405);
            this.lblMobileNo.Name = "lblMobileNo";
            this.lblMobileNo.Size = new System.Drawing.Size(116, 25);
            this.lblMobileNo.TabIndex = 0;
            this.lblMobileNo.Text = "Mobile No : ";
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMobileNo.Location = new System.Drawing.Point(186, 402);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(185, 30);
            this.txtMobileNo.TabIndex = 5;
            this.txtMobileNo.TextChanged += new System.EventHandler(this.txtMobileNo_TextChanged);
            // 
            // lblNICNo
            // 
            this.lblNICNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNICNo.AutoSize = true;
            this.lblNICNo.Location = new System.Drawing.Point(14, 467);
            this.lblNICNo.Name = "lblNICNo";
            this.lblNICNo.Size = new System.Drawing.Size(87, 25);
            this.lblNICNo.TabIndex = 0;
            this.lblNICNo.Text = "NIC No :";
            // 
            // txtNICNo
            // 
            this.txtNICNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNICNo.Location = new System.Drawing.Point(186, 464);
            this.txtNICNo.Name = "txtNICNo";
            this.txtNICNo.Size = new System.Drawing.Size(185, 30);
            this.txtNICNo.TabIndex = 6;
            this.txtNICNo.TextChanged += new System.EventHandler(this.txtNICNo_TextChanged);
            // 
            // lblGender
            // 
            this.lblGender.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(14, 529);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(88, 25);
            this.lblGender.TabIndex = 0;
            this.lblGender.Text = "Gender :";
            // 
            // radMale
            // 
            this.radMale.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radMale.AutoSize = true;
            this.radMale.Location = new System.Drawing.Point(186, 527);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(81, 29);
            this.radMale.TabIndex = 7;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male ";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // radFemale
            // 
            this.radFemale.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radFemale.AutoSize = true;
            this.radFemale.Location = new System.Drawing.Point(347, 527);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(98, 29);
            this.radFemale.TabIndex = 8;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // lblDOB
            // 
            this.lblDOB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(14, 591);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(134, 25);
            this.lblDOB.TabIndex = 0;
            this.lblDOB.Text = "Date Of Birth :";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(186, 586);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(185, 30);
            this.dtpDOB.TabIndex = 9;
            // 
            // txtParentsTPNo
            // 
            this.txtParentsTPNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtParentsTPNo.Location = new System.Drawing.Point(186, 648);
            this.txtParentsTPNo.Name = "txtParentsTPNo";
            this.txtParentsTPNo.Size = new System.Drawing.Size(185, 30);
            this.txtParentsTPNo.TabIndex = 10;
            this.txtParentsTPNo.TextChanged += new System.EventHandler(this.txtParentsTPNo_TextChanged);
            // 
            // lblParentsTPNo
            // 
            this.lblParentsTPNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblParentsTPNo.AutoSize = true;
            this.lblParentsTPNo.Location = new System.Drawing.Point(14, 653);
            this.lblParentsTPNo.Name = "lblParentsTPNo";
            this.lblParentsTPNo.Size = new System.Drawing.Size(151, 25);
            this.lblParentsTPNo.TabIndex = 0;
            this.lblParentsTPNo.Text = "Parents TP No :";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdd.Location = new System.Drawing.Point(9, 708);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(131, 44);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnFind
            // 
            this.btnFind.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFind.Location = new System.Drawing.Point(160, 708);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(131, 44);
            this.btnFind.TabIndex = 12;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUpdate.Location = new System.Drawing.Point(311, 708);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(131, 44);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClear.Location = new System.Drawing.Point(462, 708);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(131, 44);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(613, 708);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(131, 44);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "StudentData";
            this.bindingSource1.DataSource = this.student_Data_Management_System_DatabaseDataSet;
            // 
            // student_Data_Management_System_DatabaseDataSet
            // 
            this.student_Data_Management_System_DatabaseDataSet.DataSetName = "Student_Data_Management_System_DatabaseDataSet";
            this.student_Data_Management_System_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentDataTableAdapter
            // 
            this.studentDataTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1247, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.batchNoDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.tPNoDataGridViewTextBoxColumn,
            this.mobileNoDataGridViewTextBoxColumn,
            this.nICNoDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.parentsTPNoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(635, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(739, 563);
            this.dataGridView1.TabIndex = 17;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // batchNoDataGridViewTextBoxColumn
            // 
            this.batchNoDataGridViewTextBoxColumn.DataPropertyName = "BatchNo";
            this.batchNoDataGridViewTextBoxColumn.HeaderText = "BatchNo";
            this.batchNoDataGridViewTextBoxColumn.Name = "batchNoDataGridViewTextBoxColumn";
            this.batchNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            this.studentNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tPNoDataGridViewTextBoxColumn
            // 
            this.tPNoDataGridViewTextBoxColumn.DataPropertyName = "TPNo";
            this.tPNoDataGridViewTextBoxColumn.HeaderText = "TPNo";
            this.tPNoDataGridViewTextBoxColumn.Name = "tPNoDataGridViewTextBoxColumn";
            this.tPNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobileNoDataGridViewTextBoxColumn
            // 
            this.mobileNoDataGridViewTextBoxColumn.DataPropertyName = "MobileNo";
            this.mobileNoDataGridViewTextBoxColumn.HeaderText = "MobileNo";
            this.mobileNoDataGridViewTextBoxColumn.Name = "mobileNoDataGridViewTextBoxColumn";
            this.mobileNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nICNoDataGridViewTextBoxColumn
            // 
            this.nICNoDataGridViewTextBoxColumn.DataPropertyName = "NICNo";
            this.nICNoDataGridViewTextBoxColumn.HeaderText = "NICNo";
            this.nICNoDataGridViewTextBoxColumn.Name = "nICNoDataGridViewTextBoxColumn";
            this.nICNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // parentsTPNoDataGridViewTextBoxColumn
            // 
            this.parentsTPNoDataGridViewTextBoxColumn.DataPropertyName = "ParentsTPNo";
            this.parentsTPNoDataGridViewTextBoxColumn.HeaderText = "ParentsTPNo";
            this.parentsTPNoDataGridViewTextBoxColumn.Name = "parentsTPNoDataGridViewTextBoxColumn";
            this.parentsTPNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmStudentData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1431, 777);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.radFemale);
            this.Controls.Add(this.radMale);
            this.Controls.Add(this.rtbAddress);
            this.Controls.Add(this.cmbBatchNo);
            this.Controls.Add(this.txtParentsTPNo);
            this.Controls.Add(this.txtNICNo);
            this.Controls.Add(this.txtMobileNo);
            this.Controls.Add(this.txtTPNo);
            this.Controls.Add(this.lblParentsTPNo);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblNICNo);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.lblMobileNo);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.lblTPNo);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.lblBatchNo);
            this.Controls.Add(this.lblStudentID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmStudentData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Data Form";
            this.Load += new System.EventHandler(this.frmStudentData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Data_Management_System_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label lblBatchNo;
        private System.Windows.Forms.ComboBox cmbBatchNo;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.RichTextBox rtbAddress;
        private System.Windows.Forms.Label lblTPNo;
        private System.Windows.Forms.TextBox txtTPNo;
        private System.Windows.Forms.Label lblMobileNo;
        private System.Windows.Forms.TextBox txtMobileNo;
        private System.Windows.Forms.Label lblNICNo;
        private System.Windows.Forms.TextBox txtNICNo;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txtParentsTPNo;
        private System.Windows.Forms.Label lblParentsTPNo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Student_Data_Management_System_DatabaseDataSet student_Data_Management_System_DatabaseDataSet;
        private Student_Data_Management_System_DatabaseDataSetTableAdapters.StudentDataTableAdapter studentDataTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tPNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nICNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentsTPNoDataGridViewTextBoxColumn;
    }
}