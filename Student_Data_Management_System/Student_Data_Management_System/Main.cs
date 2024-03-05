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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnStudentData_Click(object sender, EventArgs e)
        {
            frmStudentData StudentData = new frmStudentData();
            StudentData.Show();
        }

        private void btnModuleMarks_Click(object sender, EventArgs e)
        {
            frmModuleMarks ModuleMarks = new frmModuleMarks();
            ModuleMarks.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
