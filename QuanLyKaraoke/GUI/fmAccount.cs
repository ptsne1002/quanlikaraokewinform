using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fmAccount : Form
    {
        private Account currentAcc = new Account();
        private Account_BUS controllerAcc =  new Account_BUS();
        public fmAccount(Account currentAcc, Employee currentEmp)
        {
            InitializeComponent();
            txtOldPwd.UseSystemPasswordChar = true;
            txtNewPwd.UseSystemPasswordChar = true;
            txtRetypePwd.UseSystemPasswordChar = true;
            lbName.Text = String.Format("Hello : {0}", currentEmp.EmployeeName);
            this.currentAcc = currentAcc;
        }

        private void btnChangePwd_Click(object sender, EventArgs e)
        {
            if(txtOldPwd.Text == currentAcc.Password)
            {
                if(txtRetypePwd.Text == txtNewPwd.Text)
                {
                    currentAcc.Password = txtNewPwd.Text;
                    string rs = controllerAcc.ChangePwd(currentAcc);
                    MessageBox.Show(rs, "Notification");
                    txtNewPwd.Text = txtOldPwd.Text = txtRetypePwd.Text = "";
                }
                else {
                    MessageBox.Show("Password Don't Match!", "Notification");
                }
            }
            else
            {
                
                MessageBox.Show("Old Password Isn't Correct!", "Notification");
            }
        }

        private void cksShowPwd_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if(cksShowPwd.Checked == true)
            {
                txtOldPwd.UseSystemPasswordChar = false;
                txtNewPwd.UseSystemPasswordChar = false;
                txtRetypePwd.UseSystemPasswordChar = false;
            }
            else
            {
                txtOldPwd.UseSystemPasswordChar = true;
                txtNewPwd.UseSystemPasswordChar = true;
                txtRetypePwd.UseSystemPasswordChar = true;
            }
        }
    }
}
