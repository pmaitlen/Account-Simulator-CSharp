namespace Account_Simulator
{
    partial class SummaryForm
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
            this.TotalTransactionsLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.WithdrawalsLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DepositsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TotalTransactionsLabel
            // 
            this.TotalTransactionsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalTransactionsLabel.Location = new System.Drawing.Point(173, 114);
            this.TotalTransactionsLabel.Name = "TotalTransactionsLabel";
            this.TotalTransactionsLabel.Size = new System.Drawing.Size(100, 23);
            this.TotalTransactionsLabel.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Total Transactions:";
            // 
            // WithdrawalsLabel
            // 
            this.WithdrawalsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WithdrawalsLabel.Location = new System.Drawing.Point(173, 70);
            this.WithdrawalsLabel.Name = "WithdrawalsLabel";
            this.WithdrawalsLabel.Size = new System.Drawing.Size(100, 23);
            this.WithdrawalsLabel.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Total Amount Withdrawals";
            // 
            // DepositsLabel
            // 
            this.DepositsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DepositsLabel.Location = new System.Drawing.Point(173, 26);
            this.DepositsLabel.Name = "DepositsLabel";
            this.DepositsLabel.Size = new System.Drawing.Size(100, 23);
            this.DepositsLabel.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Total Amount Deposits";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(110, 154);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 7;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 232);
            this.Controls.Add(this.TotalTransactionsLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.WithdrawalsLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DepositsLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OKButton);
            this.Name = "SummaryForm";
            this.Text = "Summary Info";
            this.Activated += new System.EventHandler(this.SummaryForm_Activated);
            this.Load += new System.EventHandler(this.SummaryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TotalTransactionsLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label WithdrawalsLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DepositsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OKButton;
    }
}