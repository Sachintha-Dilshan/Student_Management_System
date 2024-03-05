namespace Student_Data_Management_System
{
    partial class frmModuleMarks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModuleMarks));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lblM1 = new System.Windows.Forms.Label();
            this.txtM1 = new System.Windows.Forms.TextBox();
            this.lblM2 = new System.Windows.Forms.Label();
            this.txtM2 = new System.Windows.Forms.TextBox();
            this.lblM3 = new System.Windows.Forms.Label();
            this.lblM4 = new System.Windows.Forms.Label();
            this.txtM3 = new System.Windows.Forms.TextBox();
            this.txtM4 = new System.Windows.Forms.TextBox();
            this.lblM5 = new System.Windows.Forms.Label();
            this.txtM5 = new System.Windows.Forms.TextBox();
            this.lblM6 = new System.Windows.Forms.Label();
            this.lblM8 = new System.Windows.Forms.Label();
            this.lblM7 = new System.Windows.Forms.Label();
            this.txtM6 = new System.Windows.Forms.TextBox();
            this.lblM9 = new System.Windows.Forms.Label();
            this.txtM7 = new System.Windows.Forms.TextBox();
            this.lblProject = new System.Windows.Forms.Label();
            this.txtM8 = new System.Windows.Forms.TextBox();
            this.txtM9 = new System.Windows.Forms.TextBox();
            this.txtProject = new System.Windows.Forms.TextBox();
            this.btnAddMarks = new System.Windows.Forms.Button();
            this.btnFindMarks = new System.Windows.Forms.Button();
            this.btnupdateMarks = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.student_Data_Management_System_DatabaseDataSet = new Student_Data_Management_System.Student_Data_Management_System_DatabaseDataSet();
            this.moduleMarksTableAdapter = new Student_Data_Management_System.Student_Data_Management_System_DatabaseDataSetTableAdapters.ModuleMarksTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pnpPrint = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ModuleMarksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Data_Management_System_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnpPrint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ModuleMarksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudentID
            // 
            this.lblStudentID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(213, 50);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(115, 25);
            this.lblStudentID.TabIndex = 0;
            this.lblStudentID.Text = "Student ID :";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtStudentID.Location = new System.Drawing.Point(344, 47);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(169, 30);
            this.txtStudentID.TabIndex = 0;
            this.txtStudentID.Text = "KUR/A-";
            this.txtStudentID.TextChanged += new System.EventHandler(this.txtStudentID_TextChanged);
            // 
            // lblM1
            // 
            this.lblM1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblM1.AutoSize = true;
            this.lblM1.Location = new System.Drawing.Point(65, 139);
            this.lblM1.Name = "lblM1";
            this.lblM1.Size = new System.Drawing.Size(115, 25);
            this.lblM1.TabIndex = 0;
            this.lblM1.Text = "Module 01 :";
            // 
            // txtM1
            // 
            this.txtM1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtM1.Location = new System.Drawing.Point(201, 136);
            this.txtM1.MaxLength = 3;
            this.txtM1.Name = "txtM1";
            this.txtM1.Size = new System.Drawing.Size(76, 30);
            this.txtM1.TabIndex = 1;
            this.txtM1.TextChanged += new System.EventHandler(this.txtM1_TextChanged);
            // 
            // lblM2
            // 
            this.lblM2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblM2.AutoSize = true;
            this.lblM2.Location = new System.Drawing.Point(65, 196);
            this.lblM2.Name = "lblM2";
            this.lblM2.Size = new System.Drawing.Size(115, 25);
            this.lblM2.TabIndex = 0;
            this.lblM2.Text = "Module 02 :";
            // 
            // txtM2
            // 
            this.txtM2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtM2.Location = new System.Drawing.Point(201, 193);
            this.txtM2.MaxLength = 3;
            this.txtM2.Name = "txtM2";
            this.txtM2.Size = new System.Drawing.Size(76, 30);
            this.txtM2.TabIndex = 2;
            this.txtM2.TextChanged += new System.EventHandler(this.txtM2_TextChanged);
            // 
            // lblM3
            // 
            this.lblM3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblM3.AutoSize = true;
            this.lblM3.Location = new System.Drawing.Point(65, 253);
            this.lblM3.Name = "lblM3";
            this.lblM3.Size = new System.Drawing.Size(115, 25);
            this.lblM3.TabIndex = 0;
            this.lblM3.Text = "Module 03 :";
            // 
            // lblM4
            // 
            this.lblM4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblM4.AutoSize = true;
            this.lblM4.Location = new System.Drawing.Point(65, 310);
            this.lblM4.Name = "lblM4";
            this.lblM4.Size = new System.Drawing.Size(115, 25);
            this.lblM4.TabIndex = 0;
            this.lblM4.Text = "Module 04 :";
            // 
            // txtM3
            // 
            this.txtM3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtM3.Location = new System.Drawing.Point(201, 250);
            this.txtM3.MaxLength = 3;
            this.txtM3.Name = "txtM3";
            this.txtM3.Size = new System.Drawing.Size(76, 30);
            this.txtM3.TabIndex = 3;
            this.txtM3.TextChanged += new System.EventHandler(this.txtM3_TextChanged);
            // 
            // txtM4
            // 
            this.txtM4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtM4.Location = new System.Drawing.Point(201, 307);
            this.txtM4.MaxLength = 3;
            this.txtM4.Name = "txtM4";
            this.txtM4.Size = new System.Drawing.Size(76, 30);
            this.txtM4.TabIndex = 4;
            this.txtM4.TextChanged += new System.EventHandler(this.txtM4_TextChanged);
            // 
            // lblM5
            // 
            this.lblM5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblM5.AutoSize = true;
            this.lblM5.Location = new System.Drawing.Point(65, 367);
            this.lblM5.Name = "lblM5";
            this.lblM5.Size = new System.Drawing.Size(115, 25);
            this.lblM5.TabIndex = 0;
            this.lblM5.Text = "Module 05 :";
            // 
            // txtM5
            // 
            this.txtM5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtM5.Location = new System.Drawing.Point(201, 364);
            this.txtM5.MaxLength = 3;
            this.txtM5.Name = "txtM5";
            this.txtM5.Size = new System.Drawing.Size(76, 30);
            this.txtM5.TabIndex = 5;
            this.txtM5.TextChanged += new System.EventHandler(this.txtM5_TextChanged);
            // 
            // lblM6
            // 
            this.lblM6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblM6.AutoSize = true;
            this.lblM6.Location = new System.Drawing.Point(413, 137);
            this.lblM6.Name = "lblM6";
            this.lblM6.Size = new System.Drawing.Size(115, 25);
            this.lblM6.TabIndex = 0;
            this.lblM6.Text = "Module 06 :";
            // 
            // lblM8
            // 
            this.lblM8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblM8.AutoSize = true;
            this.lblM8.Location = new System.Drawing.Point(413, 251);
            this.lblM8.Name = "lblM8";
            this.lblM8.Size = new System.Drawing.Size(115, 25);
            this.lblM8.TabIndex = 0;
            this.lblM8.Text = "Module 08 :";
            // 
            // lblM7
            // 
            this.lblM7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblM7.AutoSize = true;
            this.lblM7.Location = new System.Drawing.Point(413, 194);
            this.lblM7.Name = "lblM7";
            this.lblM7.Size = new System.Drawing.Size(115, 25);
            this.lblM7.TabIndex = 0;
            this.lblM7.Text = "Module 07 :";
            // 
            // txtM6
            // 
            this.txtM6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtM6.Location = new System.Drawing.Point(550, 134);
            this.txtM6.MaxLength = 3;
            this.txtM6.Name = "txtM6";
            this.txtM6.Size = new System.Drawing.Size(76, 30);
            this.txtM6.TabIndex = 6;
            this.txtM6.TextChanged += new System.EventHandler(this.txtM6_TextChanged);
            // 
            // lblM9
            // 
            this.lblM9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblM9.AutoSize = true;
            this.lblM9.Location = new System.Drawing.Point(413, 308);
            this.lblM9.Name = "lblM9";
            this.lblM9.Size = new System.Drawing.Size(115, 25);
            this.lblM9.TabIndex = 0;
            this.lblM9.Text = "Module 09 :";
            // 
            // txtM7
            // 
            this.txtM7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtM7.Location = new System.Drawing.Point(550, 191);
            this.txtM7.MaxLength = 3;
            this.txtM7.Name = "txtM7";
            this.txtM7.Size = new System.Drawing.Size(76, 30);
            this.txtM7.TabIndex = 7;
            this.txtM7.TextChanged += new System.EventHandler(this.txtM7_TextChanged);
            // 
            // lblProject
            // 
            this.lblProject.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblProject.AutoSize = true;
            this.lblProject.Location = new System.Drawing.Point(413, 365);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(83, 25);
            this.lblProject.TabIndex = 0;
            this.lblProject.Text = "Project :";
            // 
            // txtM8
            // 
            this.txtM8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtM8.Location = new System.Drawing.Point(550, 248);
            this.txtM8.MaxLength = 3;
            this.txtM8.Name = "txtM8";
            this.txtM8.Size = new System.Drawing.Size(76, 30);
            this.txtM8.TabIndex = 8;
            this.txtM8.TextChanged += new System.EventHandler(this.txtM8_TextChanged);
            // 
            // txtM9
            // 
            this.txtM9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtM9.Location = new System.Drawing.Point(550, 305);
            this.txtM9.MaxLength = 3;
            this.txtM9.Name = "txtM9";
            this.txtM9.Size = new System.Drawing.Size(76, 30);
            this.txtM9.TabIndex = 9;
            this.txtM9.TextChanged += new System.EventHandler(this.txtM9_TextChanged);
            // 
            // txtProject
            // 
            this.txtProject.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtProject.Location = new System.Drawing.Point(550, 362);
            this.txtProject.MaxLength = 3;
            this.txtProject.Name = "txtProject";
            this.txtProject.Size = new System.Drawing.Size(76, 30);
            this.txtProject.TabIndex = 10;
            this.txtProject.TextChanged += new System.EventHandler(this.txtProject_TextChanged);
            // 
            // btnAddMarks
            // 
            this.btnAddMarks.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddMarks.Location = new System.Drawing.Point(690, 130);
            this.btnAddMarks.Name = "btnAddMarks";
            this.btnAddMarks.Size = new System.Drawing.Size(185, 42);
            this.btnAddMarks.TabIndex = 11;
            this.btnAddMarks.Text = "Add Marks";
            this.btnAddMarks.UseVisualStyleBackColor = true;
            this.btnAddMarks.Click += new System.EventHandler(this.btnAddMarks_Click);
            // 
            // btnFindMarks
            // 
            this.btnFindMarks.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFindMarks.Location = new System.Drawing.Point(690, 204);
            this.btnFindMarks.Name = "btnFindMarks";
            this.btnFindMarks.Size = new System.Drawing.Size(185, 42);
            this.btnFindMarks.TabIndex = 12;
            this.btnFindMarks.Text = "Find Marks";
            this.btnFindMarks.UseVisualStyleBackColor = true;
            this.btnFindMarks.Click += new System.EventHandler(this.btnFindMarks_Click);
            // 
            // btnupdateMarks
            // 
            this.btnupdateMarks.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnupdateMarks.Location = new System.Drawing.Point(690, 278);
            this.btnupdateMarks.Name = "btnupdateMarks";
            this.btnupdateMarks.Size = new System.Drawing.Size(185, 42);
            this.btnupdateMarks.TabIndex = 13;
            this.btnupdateMarks.Text = "Update Marks";
            this.btnupdateMarks.UseVisualStyleBackColor = true;
            this.btnupdateMarks.Click += new System.EventHandler(this.btnupdateMarks_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClear.Location = new System.Drawing.Point(690, 352);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(185, 42);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "ModuleMarks";
            this.bindingSource1.DataSource = this.student_Data_Management_System_DatabaseDataSet;
            // 
            // student_Data_Management_System_DatabaseDataSet
            // 
            this.student_Data_Management_System_DatabaseDataSet.DataSetName = "Student_Data_Management_System_DatabaseDataSet";
            this.student_Data_Management_System_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // moduleMarksTableAdapter
            // 
            this.moduleMarksTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(764, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(690, 416);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(187, 43);
            this.btnPrint.TabIndex = 16;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // pnpPrint
            // 
            this.pnpPrint.Controls.Add(this.btnClose);
            this.pnpPrint.Controls.Add(this.reportViewer1);
            this.pnpPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnpPrint.Location = new System.Drawing.Point(0, 0);
            this.pnpPrint.Name = "pnpPrint";
            this.pnpPrint.Size = new System.Drawing.Size(941, 471);
            this.pnpPrint.TabIndex = 17;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ModuleMarksBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Student_Data_Management_System.Reciept.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(941, 471);
            this.reportViewer1.TabIndex = 0;
            // 
            // ModuleMarksBindingSource
            // 
            this.ModuleMarksBindingSource.DataMember = "ModuleMarks";
            this.ModuleMarksBindingSource.DataSource = this.student_Data_Management_System_DatabaseDataSet;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(756, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 32);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmModuleMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 471);
            this.Controls.Add(this.pnpPrint);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnupdateMarks);
            this.Controls.Add(this.btnFindMarks);
            this.Controls.Add(this.btnAddMarks);
            this.Controls.Add(this.txtProject);
            this.Controls.Add(this.txtM9);
            this.Controls.Add(this.txtM5);
            this.Controls.Add(this.txtM8);
            this.Controls.Add(this.txtM4);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.txtM3);
            this.Controls.Add(this.txtM7);
            this.Controls.Add(this.lblM5);
            this.Controls.Add(this.lblM9);
            this.Controls.Add(this.txtM2);
            this.Controls.Add(this.txtM6);
            this.Controls.Add(this.lblM4);
            this.Controls.Add(this.lblM7);
            this.Controls.Add(this.txtM1);
            this.Controls.Add(this.lblM8);
            this.Controls.Add(this.lblM2);
            this.Controls.Add(this.lblM3);
            this.Controls.Add(this.lblM6);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.lblM1);
            this.Controls.Add(this.lblStudentID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmModuleMarks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Module Marks";
            this.Load += new System.EventHandler(this.frmModuleMarks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Data_Management_System_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnpPrint.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ModuleMarksBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label lblM1;
        private System.Windows.Forms.TextBox txtM1;
        private System.Windows.Forms.Label lblM2;
        private System.Windows.Forms.TextBox txtM2;
        private System.Windows.Forms.Label lblM3;
        private System.Windows.Forms.Label lblM4;
        private System.Windows.Forms.TextBox txtM3;
        private System.Windows.Forms.TextBox txtM4;
        private System.Windows.Forms.Label lblM5;
        private System.Windows.Forms.TextBox txtM5;
        private System.Windows.Forms.Label lblM6;
        private System.Windows.Forms.Label lblM8;
        private System.Windows.Forms.Label lblM7;
        private System.Windows.Forms.TextBox txtM6;
        private System.Windows.Forms.Label lblM9;
        private System.Windows.Forms.TextBox txtM7;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.TextBox txtM8;
        private System.Windows.Forms.TextBox txtM9;
        private System.Windows.Forms.TextBox txtProject;
        private System.Windows.Forms.Button btnAddMarks;
        private System.Windows.Forms.Button btnFindMarks;
        private System.Windows.Forms.Button btnupdateMarks;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Student_Data_Management_System_DatabaseDataSet student_Data_Management_System_DatabaseDataSet;
        private Student_Data_Management_System_DatabaseDataSetTableAdapters.ModuleMarksTableAdapter moduleMarksTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel pnpPrint;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ModuleMarksBindingSource;
        private System.Windows.Forms.Button btnClose;
    }
}