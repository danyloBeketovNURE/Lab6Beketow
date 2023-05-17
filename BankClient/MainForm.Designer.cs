namespace BankClient
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.PhoneNumberLable = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MoneyLabel = new System.Windows.Forms.Label();
            this.AddMoneyBtn = new System.Windows.Forms.Button();
            this.WithdrawMoneyBtn = new System.Windows.Forms.Button();
            this.SendMoneyBtn = new System.Windows.Forms.Button();
            this.addMoneyBox = new System.Windows.Forms.TextBox();
            this.withdrawMoneyBox = new System.Windows.Forms.TextBox();
            this.SumForTransactionBox = new System.Windows.Forms.TextBox();
            this.NumberToTransactionBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(294, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Card number:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(295, 36);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(64, 20);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "LogOut";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // PhoneNumberLable
            // 
            this.PhoneNumberLable.AutoSize = true;
            this.PhoneNumberLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneNumberLable.Location = new System.Drawing.Point(440, 104);
            this.PhoneNumberLable.Name = "PhoneNumberLable";
            this.PhoneNumberLable.Size = new System.Drawing.Size(0, 25);
            this.PhoneNumberLable.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(294, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Money balance";
            // 
            // MoneyLabel
            // 
            this.MoneyLabel.AutoSize = true;
            this.MoneyLabel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.MoneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MoneyLabel.Location = new System.Drawing.Point(446, 69);
            this.MoneyLabel.Name = "MoneyLabel";
            this.MoneyLabel.Size = new System.Drawing.Size(39, 25);
            this.MoneyLabel.TabIndex = 0;
            this.MoneyLabel.Text = "0 $";
            // 
            // AddMoneyBtn
            // 
            this.AddMoneyBtn.Location = new System.Drawing.Point(161, 12);
            this.AddMoneyBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddMoneyBtn.Name = "AddMoneyBtn";
            this.AddMoneyBtn.Size = new System.Drawing.Size(115, 44);
            this.AddMoneyBtn.TabIndex = 2;
            this.AddMoneyBtn.Text = "replenish balance";
            this.AddMoneyBtn.UseVisualStyleBackColor = true;
            this.AddMoneyBtn.Click += new System.EventHandler(this.AddMoneyBtn_Click);
            // 
            // WithdrawMoneyBtn
            // 
            this.WithdrawMoneyBtn.Location = new System.Drawing.Point(161, 69);
            this.WithdrawMoneyBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WithdrawMoneyBtn.Name = "WithdrawMoneyBtn";
            this.WithdrawMoneyBtn.Size = new System.Drawing.Size(115, 38);
            this.WithdrawMoneyBtn.TabIndex = 4;
            this.WithdrawMoneyBtn.Text = "take money";
            this.WithdrawMoneyBtn.UseVisualStyleBackColor = true;
            this.WithdrawMoneyBtn.Click += new System.EventHandler(this.WithdrawMoneyBtn_Click);
            // 
            // SendMoneyBtn
            // 
            this.SendMoneyBtn.Location = new System.Drawing.Point(196, 144);
            this.SendMoneyBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SendMoneyBtn.Name = "SendMoneyBtn";
            this.SendMoneyBtn.Size = new System.Drawing.Size(115, 83);
            this.SendMoneyBtn.TabIndex = 7;
            this.SendMoneyBtn.Text = "SEND";
            this.SendMoneyBtn.UseVisualStyleBackColor = true;
            this.SendMoneyBtn.Click += new System.EventHandler(this.SendMoneyBtn_Click);
            // 
            // addMoneyBox
            // 
            this.addMoneyBox.Location = new System.Drawing.Point(12, 23);
            this.addMoneyBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addMoneyBox.Name = "addMoneyBox";
            this.addMoneyBox.Size = new System.Drawing.Size(143, 22);
            this.addMoneyBox.TabIndex = 1;
            // 
            // withdrawMoneyBox
            // 
            this.withdrawMoneyBox.Location = new System.Drawing.Point(12, 77);
            this.withdrawMoneyBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.withdrawMoneyBox.Name = "withdrawMoneyBox";
            this.withdrawMoneyBox.Size = new System.Drawing.Size(143, 22);
            this.withdrawMoneyBox.TabIndex = 3;
            // 
            // SumForTransactionBox
            // 
            this.SumForTransactionBox.Location = new System.Drawing.Point(12, 195);
            this.SumForTransactionBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SumForTransactionBox.Name = "SumForTransactionBox";
            this.SumForTransactionBox.Size = new System.Drawing.Size(178, 22);
            this.SumForTransactionBox.TabIndex = 6;
            // 
            // NumberToTransactionBox
            // 
            this.NumberToTransactionBox.Location = new System.Drawing.Point(12, 153);
            this.NumberToTransactionBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NumberToTransactionBox.Name = "NumberToTransactionBox";
            this.NumberToTransactionBox.Size = new System.Drawing.Size(178, 22);
            this.NumberToTransactionBox.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(9, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(9, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "recipient`s card number";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 266);
            this.Controls.Add(this.addMoneyBox);
            this.Controls.Add(this.withdrawMoneyBox);
            this.Controls.Add(this.AddMoneyBtn);
            this.Controls.Add(this.SumForTransactionBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.WithdrawMoneyBtn);
            this.Controls.Add(this.NumberToTransactionBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.SendMoneyBtn);
            this.Controls.Add(this.MoneyLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PhoneNumberLable);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserInterface";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label PhoneNumberLable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label MoneyLabel;
        private System.Windows.Forms.Button AddMoneyBtn;
        private System.Windows.Forms.Button WithdrawMoneyBtn;
        private System.Windows.Forms.Button SendMoneyBtn;
        private System.Windows.Forms.TextBox addMoneyBox;
        private System.Windows.Forms.TextBox withdrawMoneyBox;
        private System.Windows.Forms.TextBox SumForTransactionBox;
        private System.Windows.Forms.TextBox NumberToTransactionBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}