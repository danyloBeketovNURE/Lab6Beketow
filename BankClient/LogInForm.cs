using BankClient.ServiceBank;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankClient
{
    public partial class LogInForm : Form
    {
        ServiceBankClient client;
        public ServerUser user { get; set; }
        public LogInForm(ServiceBankClient Client)
        {
            InitializeComponent();
            client = Client;
            PasswordTextbox.UseSystemPasswordChar = false;
        }


        private void enterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                user = client.LogIn(LoginTextbox.Text, PasswordTextbox.Text);
            }
            catch { user = null; }

            if (user == null)
            {
                MessageBox.Show("Невірно введений логін або пароль!"); 
                return;
            }
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                PasswordTextbox.UseSystemPasswordChar = true;
            }
            else
            {
                PasswordTextbox.UseSystemPasswordChar = false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUpForm signUpForm = new SignUpForm(client);
            signUpForm.ShowDialog();
            this.Visible = true; 
        }

        private void LogInForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
