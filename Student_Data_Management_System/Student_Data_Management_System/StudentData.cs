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
    public partial class frmStudentData : Form
    {
        public frmStudentData()
        {
            InitializeComponent();
        }
        DataTable dt;
        DataRow dr;
        string Gender, StudentID;
        DialogResult Result;

        public void clear()
        {
            txtStudentID.Clear();
            cmbBatchNo.Text = "";
            txtStudentName.Clear();
            rtbAddress.Clear();
            txtTPNo.Clear();
            txtMobileNo.Clear();
            txtNICNo.Clear();
            dtpDOB.Text = "";
            txtParentsTPNo.Clear();
            radMale.Checked = false;
            radFemale.Checked = false;
            this.ActiveControl = txtStudentID;
            txtStudentID.Text = "KUR/A-";

        }

        private void frmStudentData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student_Data_Management_System_DatabaseDataSet.StudentData' table. You can move, or remove it, as needed.
            this.studentDataTableAdapter.Fill(this.student_Data_Management_System_DatabaseDataSet.StudentData);           

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                this.studentDataTableAdapter.Fill(this.student_Data_Management_System_DatabaseDataSet.StudentData);
                dt = student_Data_Management_System_DatabaseDataSet.StudentData;
                dr = dt.NewRow();
                dr["StudentID"] = txtStudentID.Text;
                dr["BatchNo"] = cmbBatchNo.Text;
                dr["StudentName"] = txtStudentName.Text;
                dr["Address"] = rtbAddress.Text;
                dr["TPNo"] = txtTPNo.Text;
                dr["MobileNo"] = txtMobileNo.Text;
                dr["NICNo"] = txtNICNo.Text;
                dr["DOB"] = dtpDOB.Text;
                dr["ParentsTPNo"] = txtParentsTPNo.Text;

                if (radMale.Checked == true)
                {
                    Gender = "Male";
                }
                else if (radFemale.Checked == true)
                {
                    Gender = "Female";
                }
                dr["Gender"] = Gender;
                dt.Rows.Add(dr);
                studentDataTableAdapter.Update(student_Data_Management_System_DatabaseDataSet);
                MessageBox.Show("Record Added Successfully", "Record Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.clear();
            }//end of try
            catch 
            {
                MessageBox.Show("Invalid Student Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.clear();
            }

           



        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                this.studentDataTableAdapter.Fill(this.student_Data_Management_System_DatabaseDataSet.StudentData);
                dt = student_Data_Management_System_DatabaseDataSet.StudentData;
                StudentID = txtStudentID.Text;
                dr = dt.Rows.Find(StudentID);
                cmbBatchNo.Text = dr["BatchNo"].ToString();
                txtStudentName.Text = dr["StudentName"].ToString();
                rtbAddress.Text = dr["Address"].ToString();
                txtTPNo.Text = dr["TPNo"].ToString();
                txtMobileNo.Text = dr["MobileNo"].ToString();
                txtNICNo.Text = dr["NICNo"].ToString();
                dtpDOB.Text = dr["DOB"].ToString();
                txtParentsTPNo.Text = dr["ParentsTPNo"].ToString();
                Gender = dr["Gender"].ToString();
                if (Gender == "Male")
                {
                    radMale.Checked = true;
                }
                else if (Gender == "Female")
                {
                    radFemale.Checked = true;
                }
                
                
               
            }
            catch
            {
                MessageBox.Show("Invalid Student Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.clear();
            }



            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.studentDataTableAdapter.Fill(this.student_Data_Management_System_DatabaseDataSet.StudentData);
            dt = student_Data_Management_System_DatabaseDataSet.StudentData;
            StudentID = txtStudentID.Text;
            dr = dt.Rows.Find(StudentID);
            dr.BeginEdit();
            dr["StudentID"] = txtStudentID.Text;
            dr["BatchNo"] = cmbBatchNo.Text;
            dr["StudentName"] = txtStudentName.Text;
            dr["Address"] = rtbAddress.Text;
            dr["TPNo"] = txtTPNo.Text;
            dr["MobileNo"] = txtMobileNo.Text;
            dr["NICNo"] = txtNICNo.Text;
            dr["DOB"] = dtpDOB.Text;
            dr["ParentsTPNo"] = txtParentsTPNo.Text;

            if (radMale.Checked == true)
            {
                Gender = "Male";
            }
            else if (radFemale.Checked == true)
            {
                Gender = "Female";
            }
            dr["Gender"] = Gender;
            dr.EndEdit();
            studentDataTableAdapter.Update(student_Data_Management_System_DatabaseDataSet);
            MessageBox.Show("Record Updated Successfully", "Record Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.clear();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.studentDataTableAdapter.Fill(this.student_Data_Management_System_DatabaseDataSet.StudentData);
            dt = student_Data_Management_System_DatabaseDataSet.StudentData;
            StudentID = txtStudentID.Text;
            dr = dt.Rows.Find(StudentID);
            
            Result = MessageBox.Show("Are You Sure You Want to Delete This Record", "Record Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(Result==DialogResult.Yes)
            {
                dr.Delete();
                studentDataTableAdapter.Update(student_Data_Management_System_DatabaseDataSet);
                MessageBox.Show("Record Deleted Successfully", "Record Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.clear();

            }




        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {
            txtStudentID.BackColor = System.Drawing.Color.LightGoldenrodYellow;
        }

        private void cmbBatchNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBatchNo.BackColor = System.Drawing.Color.LightGoldenrodYellow;
        }

        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {
            txtStudentName.BackColor = System.Drawing.Color.LightGoldenrodYellow;
        }

        private void rtbAddress_TextChanged(object sender, EventArgs e)
        {
            rtbAddress.BackColor = System.Drawing.Color.LightGoldenrodYellow;
        }

        private void txtTPNo_TextChanged(object sender, EventArgs e)
        {
            txtTPNo.BackColor = System.Drawing.Color.LightGoldenrodYellow;
        }

        private void txtMobileNo_TextChanged(object sender, EventArgs e)
        {
            txtMobileNo.BackColor = System.Drawing.Color.LightGoldenrodYellow;
        }

        private void txtNICNo_TextChanged(object sender, EventArgs e)
        {
            txtNICNo.BackColor = System.Drawing.Color.LightGoldenrodYellow;
        }

        private void txtParentsTPNo_TextChanged(object sender, EventArgs e)
        {
            txtParentsTPNo.BackColor = System.Drawing.Color.LightYellow;
        }
    }
}
