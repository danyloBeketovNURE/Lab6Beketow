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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.PhoneNumberLable = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MoneyLabel = new System.Windows.Forms.Label();
            this.AddMoneyBtn = new System.Windows.Forms.Button();
            this.WithdrawMoneyBtn = new System.Windows.Forms.Button();
            this.SendMoneyBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addMoneyBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.withdrawMoneyBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SumForTransactionBox = new System.Windows.Forms.TextBox();
            this.NumberToTransactionBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Мій номер:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(456, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(514, 384);
            this.listBox1.TabIndex = 2;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.Location = new System.Drawing.Point(11, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(69, 25);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Вийти";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // PhoneNumberLable
            // 
            this.PhoneNumberLable.AutoSize = true;
            this.PhoneNumberLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneNumberLable.Location = new System.Drawing.Point(158, 418);
            this.PhoneNumberLable.Name = "PhoneNumberLable";
            this.PhoneNumberLable.Size = new System.Drawing.Size(0, 29);
            this.PhoneNumberLable.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(451, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Баланс:";
            // 
            // MoneyLabel
            // 
            this.MoneyLabel.AutoSize = true;
            this.MoneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MoneyLabel.Location = new System.Drawing.Point(559, 418);
            this.MoneyLabel.Name = "MoneyLabel";
            this.MoneyLabel.Size = new System.Drawing.Size(72, 29);
            this.MoneyLabel.TabIndex = 0;
            this.MoneyLabel.Text = "0 грн";
            // 
            // AddMoneyBtn
            // 
            this.AddMoneyBtn.Location = new System.Drawing.Point(295, 8);
            this.AddMoneyBtn.Name = "AddMoneyBtn";
            this.AddMoneyBtn.Size = new System.Drawing.Size(129, 55);
            this.AddMoneyBtn.TabIndex = 2;
            this.AddMoneyBtn.Text = "Поповнити рахунок";
            this.AddMoneyBtn.UseVisualStyleBackColor = true;
            this.AddMoneyBtn.Click += new System.EventHandler(this.AddMoneyBtn_Click);
            // 
            // WithdrawMoneyBtn
            // 
            this.WithdrawMoneyBtn.Location = new System.Drawing.Point(295, 9);
            this.WithdrawMoneyBtn.Name = "WithdrawMoneyBtn";
            this.WithdrawMoneyBtn.Size = new System.Drawing.Size(129, 48);
            this.WithdrawMoneyBtn.TabIndex = 4;
            this.WithdrawMoneyBtn.Text = "Зняти кошти";
            this.WithdrawMoneyBtn.UseVisualStyleBackColor = true;
            this.WithdrawMoneyBtn.Click += new System.EventHandler(this.WithdrawMoneyBtn_Click);
            // 
            // SendMoneyBtn
            // 
            this.SendMoneyBtn.Location = new System.Drawing.Point(295, 6);
            this.SendMoneyBtn.Name = "SendMoneyBtn";
            this.SendMoneyBtn.Size = new System.Drawing.Size(129, 104);
            this.SendMoneyBtn.TabIndex = 7;
            this.SendMoneyBtn.Text = "Перевести кошти";
            this.SendMoneyBtn.UseVisualStyleBackColor = true;
            this.SendMoneyBtn.Click += new System.EventHandler(this.SendMoneyBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.addMoneyBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.AddMoneyBtn);
            this.panel1.Location = new System.Drawing.Point(12, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 74);
            this.panel1.TabIndex = 5;
            // 
            // addMoneyBox
            // 
            this.addMoneyBox.Location = new System.Drawing.Point(7, 29);
            this.addMoneyBox.Name = "addMoneyBox";
            this.addMoneyBox.Size = new System.Drawing.Size(263, 26);
            this.addMoneyBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Сума для поповнення рахунку:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.withdrawMoneyBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.WithdrawMoneyBtn);
            this.panel2.Location = new System.Drawing.Point(12, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(438, 69);
            this.panel2.TabIndex = 5;
            // 
            // withdrawMoneyBox
            // 
            this.withdrawMoneyBox.Location = new System.Drawing.Point(7, 29);
            this.withdrawMoneyBox.Name = "withdrawMoneyBox";
            this.withdrawMoneyBox.Size = new System.Drawing.Size(263, 26);
            this.withdrawMoneyBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Сума для зняття коштів:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.SumForTransactionBox);
            this.panel3.Controls.Add(this.NumberToTransactionBox);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.SendMoneyBtn);
            this.panel3.Location = new System.Drawing.Point(12, 197);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(438, 120);
            this.panel3.TabIndex = 5;
            // 
            // SumForTransactionBox
            // 
            this.SumForTransactionBox.Location = new System.Drawing.Point(7, 84);
            this.SumForTransactionBox.Name = "SumForTransactionBox";
            this.SumForTransactionBox.Size = new System.Drawing.Size(263, 26);
            this.SumForTransactionBox.TabIndex = 6;
            // 
            // NumberToTransactionBox
            // 
            this.NumberToTransactionBox.Location = new System.Drawing.Point(7, 29);
            this.NumberToTransactionBox.Name = "NumberToTransactionBox";
            this.NumberToTransactionBox.Size = new System.Drawing.Size(263, 26);
            this.NumberToTransactionBox.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Сумма для переведення:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(267, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Перевести кошти за номером:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 456);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.MoneyLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PhoneNumberLable);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label PhoneNumberLable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label MoneyLabel;
        private System.Windows.Forms.Button AddMoneyBtn;
        private System.Windows.Forms.Button WithdrawMoneyBtn;
        private System.Windows.Forms.Button SendMoneyBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox addMoneyBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox withdrawMoneyBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox SumForTransactionBox;
        private System.Windows.Forms.TextBox NumberToTransactionBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}