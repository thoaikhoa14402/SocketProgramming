using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPClient
{
    public partial class UserLoginForm : Form
    {
        public UserLoginForm()
        {
            InitializeComponent();
        }
        private TCP_Clients client = null;

        private Form connect = null;
        public TCP_Clients cli
        {
            set { client = value; }
        }
        
        public Form connectForm // ClientConnectForm
        {
            set { connect = value; }
        }
        private bool IsUsername()
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Username cannot be empty !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtUsername.Text.Length < 6 || txtUsername.Text.Length > 20)
            {
                MessageBox.Show("Username must between [6-20] characters!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            Match res = Regex.Match(txtUsername.Text, @"^[A-Za-z0-9]+(?:[_-][A-Za-z0-9]+)*$");
            if (res.Value.Length <= 0)
            {
                MessageBox.Show("Invalid Username!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        // check invalid password
        private bool IsPassWord()
        {

            Match res2 = Regex.Match(txtPassword.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&_])[A-Za-z\d@$!%*?&_]{8,20}$");
            if (res2.Value.Length <= 0 || txtPassword.Text.ToLower() == txtUsername.Text.ToLower())
            {
                MessageBox.Show("Weak password!\nAt least 1 upper letter, 1 lower letter, 1 special letter \n(@, $, !, %, *, ?, &, _) and 1 number [0-9]\n\nPassword must be between [8-20] characters!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = (!ShowPassword.Checked);
        }
        private void Login_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (client != null)
                {
                    if (!IsUsername() || !IsPassWord()) return;
                    // process send login string
                    byte[] temp = Encoding.UTF8.GetBytes(txtPassword.Text); // ma hoa mat khau
                    byte[] haspass = new MD5CryptoServiceProvider().ComputeHash(temp);
                    string HASPASS = "";
                    foreach (byte item in haspass) HASPASS += item;
                    client.RequestLogin(txtUsername.Text, HASPASS);
                    client.ReceiveResponse();
                    if (client.Session != null)
                    {
                        SearchForm searchForm = new SearchForm();
                        searchForm.cli = client;
                        searchForm.connectForm = connect;
                        searchForm.Show();
                        Close();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void Clear_button_Click(object sender, EventArgs e)
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            ShowPassword.Checked = false;
        }

        private void Register_button_Click(object sender, EventArgs e)
        {
            RegisterForm Register = new RegisterForm();
            Register.cli = client;
            Register.ShowDialog();
        }

        private void UserLoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (client.Session == null) connect.Show();
            }
            catch
            {

            }
        }

        private void Clear_button_Click_1(object sender, EventArgs e)
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            ShowPassword.Checked = false;
        }
    }
}
