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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        String UserName, Password;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserName = txtUserName.Text;
            Password = txtPassword.Text;

            if (UserName == "sachinthadilshan335@gmail.com" && Password == "*60517790*")
            {
                frmMain Main = new frmMain();
                Main.Show();
            }
            else
            {
                MessageBox.Show("Invalid User Name Or Password.Please Try Again", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUserName_MouseClick(object sender, MouseEventArgs e)
        {
            txtUserName.Clear();
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            txtPassword.Clear();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
    }
}
