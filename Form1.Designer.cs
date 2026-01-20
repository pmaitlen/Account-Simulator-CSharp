namespace Account_Simulator
{
    partial class Form1
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
            this.TotalsButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.WithdrawalButton = new System.Windows.Forms.Button();
            this.DepositButton = new System.Windows.Forms.Button();
            this.WithdrawalTextbox = new System.Windows.Forms.TextBox();
            this.DepositTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TotalsButton
            // 
            this.TotalsButton.Location = new System.Drawing.Point(111, 239);
            this.TotalsButton.Name = "TotalsButton";
            this.TotalsButton.Size = new System.Drawing.Size(75, 23);
            this.TotalsButton.TabIndex = 23;
            this.TotalsButton.Text = "Totals";
            this.TotalsButton.UseVisualStyleBackColor = true;
            this.TotalsButton.Click += new System.EventHandler(this.TotalsButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WithdrawalButton
            // 
            this.WithdrawalButton.Location = new System.Drawing.Point(208, 144);
            this.WithdrawalButton.Name = "WithdrawalButton";
            this.WithdrawalButton.Size = new System.Drawing.Size(75, 23);
            this.WithdrawalButton.TabIndex = 21;
            this.WithdrawalButton.Text = "Withdraw";
            this.WithdrawalButton.UseVisualStyleBackColor = true;
            this.WithdrawalButton.Click += new System.EventHandler(this.WithdrawalButton_Click);
            // 
            // DepositButton
            // 
            this.DepositButton.Location = new System.Drawing.Point(59, 144);
            this.DepositButton.Name = "DepositButton";
            this.DepositButton.Size = new System.Drawing.Size(75, 23);
            this.DepositButton.TabIndex = 20;
            this.DepositButton.Text = "Deposit";
            this.DepositButton.UseVisualStyleBackColor = true;
            this.DepositButton.Click += new System.EventHandler(this.DepositButton_Click);
            // 
            // WithdrawalTextbox
            // 
            this.WithdrawalTextbox.Location = new System.Drawing.Point(208, 109);
            this.WithdrawalTextbox.Name = "WithdrawalTextbox";
            this.WithdrawalTextbox.Size = new System.Drawing.Size(75, 20);
            this.WithdrawalTextbox.TabIndex = 19;
            // 
            // DepositTextbox
            // 
            this.DepositTextbox.Location = new System.Drawing.Point(77, 110);
            this.DepositTextbox.Name = "DepositTextbox";
            this.DepositTextbox.Size = new System.Drawing.Size(72, 20);
            this.DepositTextbox.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(155, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Amount:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Withdraw:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Deposit:";
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BalanceLabel.Location = new System.Drawing.Point(111, 20);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(100, 23);
            this.BalanceLabel.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Balance:";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(223, 263);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 24;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 298);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.TotalsButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.WithdrawalButton);
            this.Controls.Add(this.DepositButton);
            this.Controls.Add(this.WithdrawalTextbox);
            this.Controls.Add(this.DepositTextbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BalanceLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bank Account Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TotalsButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button WithdrawalButton;
        private System.Windows.Forms.Button DepositButton;
        private System.Windows.Forms.TextBox WithdrawalTextbox;
        private System.Windows.Forms.TextBox DepositTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label BalanceLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ClearButton;
    }
}

