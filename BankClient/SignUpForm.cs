using BankClient.ServiceBank;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankClient
{
    public partial class SignUpForm : Form
    {
        ServiceBankClient Client;
        public SignUpForm(ServiceBankClient client)
        {
            InitializeComponent();
            PasswordTextbox.UseSystemPasswordChar = false;
            Client = client;
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            if(LoginTextbox.Text.Length != 10)
            {
                MessageBox.Show("Номер телефону введено неправильно.");
                return;
            }
            
            if(PasswordTextbox.Text.Length <= 5)
            {
                MessageBox.Show("Пароль має бути більше 5 символів");
                return;
            }

            bool state = Client.SignUp(LoginTextbox.Text, PasswordTextbox.Text);
            
            if (!state)
            {
                MessageBox.Show("Такий акаунт вже зареєстровано");
                return;
            }

            MessageBox.Show("Акаунт успішно створено. Увійдіть у нього");
            
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

        private void SignUpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }
    }
}
