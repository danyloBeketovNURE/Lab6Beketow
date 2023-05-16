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
            listBox1.Items.Clear();
            PhoneNumberLable.Text = User.Telephone;
            MoneyLabel.Text = User.Money.ToString() + " грн";
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
                MessageBox.Show("Сума не може бути від'ємним числом!");
                return;
            }

            if (sum > 10000)
            {
                MessageBox.Show("За 1 раз рахунок можна поповнити не більше ніж на суму 10.000 грн!\nОперація відмінена");
                return;
            }

            string msg = Client.AddMoney(User.Id, sum);
            User.Money += sum;
            listBox1.Items.Add(msg);
            MoneyLabel.Text = User.Money.ToString() + " грн";
        }

        private void WithdrawMoneyBtn_Click(object sender, EventArgs e)
        {
            bool parse = double.TryParse(withdrawMoneyBox.Text, out double sum);

            if (!parse)
                return;

            if (sum <= 0)
            {
                MessageBox.Show("Сума не може бути від'ємним числом!");
                return;
            }

            if (sum > User.Money)
            {
                MessageBox.Show("Ви намагаєтесь зняти більше коштів ніж у вас є на рахунку!\nОперація відмінена");
                return;
            }

            string msg = Client.WithdrawMoney(User.Id, sum);
            User.Money -= sum;
            listBox1.Items.Add(msg);
            MoneyLabel.Text = User.Money.ToString() + " грн";
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
                MessageBox.Show("Сума не може бути від'ємним числом!");
                return;
            }

            if (sum > User.Money)
            {
                MessageBox.Show("Ви намагаєтесь перевести більше коштів ніж у вас є на рахунку!\nОперація відмінена");
                return;
            }
            string msg = Client.MoneyTransfer(User.Id, numberToTrans, sum);
            if (msg == null)
            {
                MessageBox.Show("Помилка! Номер, на який ви намагаєтесь перевести кошти не зареєстровано.");
                return;
            }
            
            listBox1.Items.Add(msg);
            User.Money -= sum;
            MoneyLabel.Text = User.Money.ToString() + " грн";
        }

        public void GettingMoney(Transaction transaction)
        {
            listBox1.Items.Add($"Отримання коштів від {transaction.TelephoneFrom} в розмірі {transaction.Money} грн.");
            User.Money += transaction.Money;
            MoneyLabel.Text = User.Money.ToString() + " грн";
        }
    }
}
