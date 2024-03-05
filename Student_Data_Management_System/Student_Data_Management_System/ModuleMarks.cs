using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Data_Management_System
{
    public partial class frmModuleMarks : Form
    {
        public frmModuleMarks()
        {
            InitializeComponent();
        }
        DataTable dt;
        DataRow dr;
        string StudentID;

        public void clear()
        {
            txtStudentID.Clear();
            txtM1.Clear();
            txtM2.Clear();
            txtM3.Clear();
            txtM4.Clear();
            txtM5.Clear();
            txtM6.Clear();
            txtM7.Clear();
            txtM8.Clear();
            txtM9.Clear();
            txtProject.Clear();
            this.ActiveControl = txtStudentID;
            txtStudentID.Text = "KUR/A-";


        }

        private void frmModuleMarks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student_Data_Management_System_DatabaseDataSet.ModuleMarks' table. You can move, or remove it, as needed.
            this.moduleMarksTableAdapter.Fill(this.student_Data_Management_System_DatabaseDataSet.ModuleMarks);
            pnpPrint.Hide();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void btnAddMarks_Click(object sender, EventArgs e)
        {
            try
            {
                this.moduleMarksTableAdapter.Fill(this.student_Data_Management_System_DatabaseDataSet.ModuleMarks);
                dt = student_Data_Management_System_DatabaseDataSet.ModuleMarks;
                dr = dt.NewRow();
                dr["StudentID"] = txtStudentID.Text;
                dr["M1"] = txtM1.Text;
                dr["M2"] = txtM2.Text;
                dr["M3"] = txtM3.Text;
                dr["M4"] = txtM4.Text;
                dr["M5"] = txtM5.Text;
                dr["M6"] = txtM6.Text;
                dr["M7"] = txtM7.Text;
                dr["M8"] = txtM8.Text;
                dr["M9"] = txtM9.Text;
                dr["Project"] = txtProject.Text;
                dt.Rows.Add(dr);
                moduleMarksTableAdapter.Update(student_Data_Management_System_DatabaseDataSet);
                MessageBox.Show("Marks Added successfully", "Add Marks", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.clear();
            }
            catch 
            {
                MessageBox.Show("Invalid Student Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.clear();
            }


        }

        private void btnFindMarks_Click(object sender, EventArgs e)
        {
            try
            {
                this.moduleMarksTableAdapter.Fill(this.student_Data_Management_System_DatabaseDataSet.ModuleMarks);
                dt = student_Data_Management_System_DatabaseDataSet.ModuleMarks;
                StudentID = txtStudentID.Text;
                dr = dt.Rows.Find(StudentID);
                txtM1.Text = dr["M1"].ToString();
                txtM2.Text = dr["M2"].ToString();
                txtM3.Text = dr["M3"].ToString();
                txtM4.Text = dr["M4"].ToString();
                txtM5.Text = dr["M5"].ToString();
                txtM6.Text = dr["M6"].ToString();
                txtM7.Text = dr["M7"].ToString();
                txtM8.Text = dr["M8"].ToString();
                txtM9.Text = dr["M9"].ToString();
                txtProject.Text = dr["Project"].ToString();
            }
            catch
            {
                MessageBox.Show("Invalid Student Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.clear();
            }

        }

        private void btnupdateMarks_Click(object sender, EventArgs e)
        {
            this.moduleMarksTableAdapter.Fill(this.student_Data_Management_System_DatabaseDataSet.ModuleMarks);
            dt = student_Data_Management_System_DatabaseDataSet.ModuleMarks;
            StudentID = txtStudentID.Text;
            dr = dt.Rows.Find(StudentID);
            dr.BeginEdit();
            dr["StudentID"] = txtStudentID.Text;
            dr["M1"] = txtM1.Text;
            dr["M2"] = txtM2.Text;
            dr["M3"] = txtM3.Text;
            dr["M4"] = txtM4.Text;
            dr["M5"] = txtM5.Text;
            dr["M6"] = txtM6.Text;
            dr["M7"] = txtM7.Text;
            dr["M8"] = txtM8.Text;
            dr["M9"] = txtM9.Text;
            dr["Project"] = txtProject.Text;
            dr.EndEdit();
            moduleMarksTableAdapter.Update(student_Data_Management_System_DatabaseDataSet);
            MessageBox.Show("Marks Updated Succesfully", "Marks Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.clear();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.clear();
        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {
            txtStudentID.BackColor = System.Drawing.Color.LightGoldenrodYellow;
        }

        private void txtM1_TextChanged(object sender, EventArgs e)
        {
            txtM1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
        }

        private void txtM2_TextChanged(object sender, EventArgs e)
        {
            txtM2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
        }

        private void txtM3_TextChanged(object sender, EventArgs e)
        {
            txtM3.BackColor = System.Drawing.Color.LightGoldenrodYellow;
        }

        private void txtM4_TextChanged(object sender, EventArgs e)
        {
            txtM4.BackColor = System.Drawing.Color.LightGoldenrodYellow;
        }

        private void txtM5_TextChanged(object sender, EventArgs e)
        {
            txtM5.BackColor = System.Drawing.Color.LightGoldenrodYellow;
        }

        private void txtM6_TextChanged(object sender, EventArgs e)
        {
            txtM6.BackColor = System.Drawing.Color.LightGoldenrodYellow;
        }

        private void txtM7_TextChanged(object sender, EventArgs e)
        {
            txtM7.BackColor = System.Drawing.Color.LightGoldenrodYellow;
        }

        private void txtM8_TextChanged(object sender, EventArgs e)
        {
            txtM8.BackColor = System.Drawing.Color.LightGoldenrodYellow;
        }

        private void txtM9_TextChanged(object sender, EventArgs e)
        {
            txtM9.BackColor = System.Drawing.Color.LightGoldenrodYellow;
        }

        private void txtProject_TextChanged(object sender, EventArgs e)
        {
            txtProject.BackColor = System.Drawing.Color.LightGoldenrodYellow;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            pnpPrint.Show();
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            pnpPrint.Hide();
        }
    }
}
