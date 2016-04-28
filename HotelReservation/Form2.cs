using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI2
{
    public partial class frmLogIn : Form
    {
       // UserLogin myLogin = new UserLogin();
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            MessageBoxButtons button1 = MessageBoxButtons.OKCancel;
            MessageBoxButtons button2 = MessageBoxButtons.OK;
            string message1 = "You have successfully logged in!";
            string message2 = "Incorrect Password";
            string caption1 = "Login Passed";
            string caption2 = "Login Failed";
            DialogResult result;
            UserLogin.username = txtUserName.Text;
            UserLogin.password = txtPassword.Text;

            if (UserLogin.LoginResult() == true)
            {
                MessageBox.Show(message1, caption1, button2);
                Form1 f1 = new Form1();
                this.Visible = false;
                f1.ShowDialog(this);
                this.Close();
            }
            else
            {
                result = MessageBox.Show(message2 , caption2 , button1);
                if (result == System.Windows.Forms.DialogResult.OK )
                {
                    txtUserName.Focus();
                }
                else
                {
                    this.Close();
                }
            }


        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                btnLogIn.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                txtUserName.Focus();
            }
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }

       
    }
}
