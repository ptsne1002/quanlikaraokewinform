
using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GUI
{
    public partial class fmLogin : Form
    {
        private Account_BUS controllerAccount = new Account_BUS();
        private Employee_BUS controllerEmployee = new Employee_BUS();
        private Employee employee = new Employee();
        public fmLogin()
        {
            InitializeComponent();

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Account acc = new Account();
            acc.UserName = txtUserName.Text;
            acc.Password = txtPassword.Text;
            if (string.IsNullOrWhiteSpace(txtUserName.Text) == true || string.IsNullOrWhiteSpace(txtPassword.Text) == true)
            {
                MessageBox.Show("Please Check Your UserName Or Password", "Notification");
            }
            else
            {
                int employeeid = controllerAccount.CheckAccount(acc);
                if (employeeid > -1)
                {
                    acc.EmployeeId = employeeid;
                    employee = controllerEmployee.GetEmployee(acc.EmployeeId);
                    Thread threadOpenFmMain = new Thread(OpenFmMain);
                    threadOpenFmMain.Start();
                }
                else
                {
                    MessageBox.Show("UserName Or Password Fail", "Notification");
                }
            }
        }

        private void OpenFmMain()
        {
            this.Close();
            Application.Run(new fmMain(employee));
            
        }

        private void cksUnhidePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cksUnhidePassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if(cksUnhidePassword.Checked == false)
                txtPassword.UseSystemPasswordChar = true;
        }

        private void txtUserName_TextChange(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            cksUnhidePassword.Checked = false;
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.facebook.com/pts1002");
        }
    }
        

        
}
