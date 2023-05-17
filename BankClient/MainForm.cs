using BankClient.ServiceBank;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankClient
{
    public partial class MainForm : Form, IServiceBankCallback
    {
        ServerUser User;
        ServiceBankClient Client;
        public MainForm()
        {
            InitializeComponent();
            Client = new ServiceBankClient(new System.ServiceModel.InstanceContext(this));
            Authorization();
        }

        private void Authorization()
        {
            LogInForm logInForm = new LogInForm(Client);
            logInForm.ShowDialog();
            User = GetUserFromLogIn(logInForm);
            logInForm.Close();
            PhoneNumberLable.Text = User.Telephone;
            MoneyLabel.Text = User.Money.ToString() + " $";
        }


        private ServerUser GetUserFromLogIn(LogInForm f)
        {
            return f.user;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Client.LogOut(User.Id);
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Client.LogOut(User.Id);

            this.Hide();
            Authorization();
            this.Visible = true;
        }

        private void AddMoneyBtn_Click(object sender, EventArgs e)
        {
            bool parse = double.TryParse(addMoneyBox.Text, out double sum);

            if (!parse)
                return;

            if (sum <= 0)
            {
                MessageBox.Show("MUST BE POSITIVE");
                return;
            }

            if (sum > 10000)
            {
                MessageBox.Show("MUST BE NOT MORE THAN 10000\nCANCELED");
                return;
            }

            string msg = Client.AddMoney(User.Id, sum);
            User.Money += sum;
            MoneyLabel.Text = User.Money.ToString() + " $";
        }

        private void WithdrawMoneyBtn_Click(object sender, EventArgs e)
        {
            bool parse = double.TryParse(withdrawMoneyBox.Text, out double sum);

            if (!parse)
                return;

            if (sum <= 0)
            {
                MessageBox.Show("MUST BE POSITIVE");
                return;
            }

            if (sum > User.Money)
            {
                MessageBox.Show("CANCELED!\nNOT EBOUNG MONEY");
                return;
            }

            string msg = Client.WithdrawMoney(User.Id, sum);
            User.Money -= sum;
            MoneyLabel.Text = User.Money.ToString() + " $";
        }

        private void SendMoneyBtn_Click(object sender, EventArgs e)
        {
            bool parse = double.TryParse(SumForTransactionBox.Text, out double sum);
            string numberToTrans = NumberToTransactionBox.Text.Trim();

            if (numberToTrans == User.Telephone)
                return;

            if (!parse)
                return;

            if (sum <= 0)
            {
                MessageBox.Show("MUST BE POSITIVE");
                return;
            }

            if (sum > User.Money)
            {
                MessageBox.Show("CANCELED!\nNOT EBOUNG MONEY");
                return;
            }
            string msg = Client.MoneyTransfer(User.Id, numberToTrans, sum);
            if (msg == null)
            {
                MessageBox.Show("CARD NUMBER NOT FOUNF");
                return;
            }
            
            User.Money -= sum;
            MoneyLabel.Text = User.Money.ToString() + " $";
        }

        public void GettingMoney(Transaction transaction)
        {
            User.Money += transaction.Money;
            MoneyLabel.Text = User.Money.ToString() + " $";
        }
    }
}
