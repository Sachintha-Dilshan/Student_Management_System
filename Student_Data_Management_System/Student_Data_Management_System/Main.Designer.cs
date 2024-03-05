namespace Student_Data_Management_System
{
    partial class frmMain
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
            this.btnStudentData = new System.Windows.Forms.Button();
            this.btnModuleMarks = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStudentData
            // 
            this.btnStudentData.BackColor = System.Drawing.SystemColors.Control;
            this.btnStudentData.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStudentData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnStudentData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnStudentData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentData.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentData.Location = new System.Drawing.Point(37, 93);
            this.btnStudentData.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.btnStudentData.Name = "btnStudentData";
            this.btnStudentData.Size = new System.Drawing.Size(625, 118);
            this.btnStudentData.TabIndex = 0;
            this.btnStudentData.Text = "Student Data";
            this.btnStudentData.UseVisualStyleBackColor = true;
            this.btnStudentData.Click += new System.EventHandler(this.btnStudentData_Click);
            // 
            // btnModuleMarks
            // 
            this.btnModuleMarks.BackColor = System.Drawing.SystemColors.Control;
            this.btnModuleMarks.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnModuleMarks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnModuleMarks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModuleMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModuleMarks.Location = new System.Drawing.Point(37, 261);
            this.btnModuleMarks.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.btnModuleMarks.Name = "btnModuleMarks";
            this.btnModuleMarks.Size = new System.Drawing.Size(625, 118);
            this.btnModuleMarks.TabIndex = 1;
            this.btnModuleMarks.Text = "Module Marks";
            this.btnModuleMarks.UseVisualStyleBackColor = true;
            this.btnModuleMarks.Click += new System.EventHandler(this.btnModuleMarks_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(37, 429);
            this.btnClose.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(625, 118);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Student_Data_Management_System.Properties.Resources.DiTec_WebBanner;
            this.pictureBox1.Location = new System.Drawing.Point(743, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(722, 286);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::Student_Data_Management_System.Properties.Resources.pang_yuhao_wCi28eq8TF4_unsplash;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1924, 1055);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(35F, 69F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnModuleMarks);
            this.Controls.Add(this.btnStudentData);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(12, 14, 12, 14);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form | Student Data Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStudentData;
        private System.Windows.Forms.Button btnModuleMarks;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}