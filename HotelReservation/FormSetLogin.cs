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
    public partial class FormSetLogin : Form
    {
        //UserLogin myLogin = new UserLogin();
        public FormSetLogin()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string message = "Please re-enter confirmed password!";
            string caption = "Incorrect confirmed password";
            MessageBoxButtons button = MessageBoxButtons.OK;
            DialogResult result;

            UserLogin.username = txtNewUsername.Text;
            UserLogin.password = txtNewPassword.Text;
            
            if (txtNewPassword.Text == txtConfirmNewPass.Text)
            {
                MessageBox.Show(UserLogin.AddUser());
               // myLogin.AddUser();
            }
            else
            {
                result = MessageBox.Show(message, caption, button);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    txtConfirmNewPass.Focus();
                }
            }

        }

        private void txtNewUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                txtNewPassword.Focus();
            }
        }

        private void txtNewPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                txtConfirmNewPass.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                txtNewUsername.Focus();
            }
        }

        private void txtConfirmNewPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                btnCreate.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                txtNewPassword.Focus();
            }
            
        }
    }
}
