
namespace ATM_Practice
{
    partial class MainMenuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.TransferMoneyButton = new System.Windows.Forms.Button();
            this.DepositMoneyButton = new System.Windows.Forms.Button();
            this.WithdrawMoneyButton = new System.Windows.Forms.Button();
            this.CheckBalanceButton = new System.Windows.Forms.Button();
            this.MainMenuFormTable = new System.Windows.Forms.TableLayoutPanel();
            this.MainMenuFormTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WelcomeLabel.Location = new System.Drawing.Point(30, 24);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(332, 45);
            this.WelcomeLabel.TabIndex = 2;
            this.WelcomeLabel.Text = "Welcome to ZZZ Bank";
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.Location = new System.Drawing.Point(5, 422);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(808, 92);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // TransferMoneyButton
            // 
            this.TransferMoneyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TransferMoneyButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TransferMoneyButton.Location = new System.Drawing.Point(5, 318);
            this.TransferMoneyButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TransferMoneyButton.Name = "TransferMoneyButton";
            this.TransferMoneyButton.Size = new System.Drawing.Size(808, 92);
            this.TransferMoneyButton.TabIndex = 3;
            this.TransferMoneyButton.Text = "Transfer Money";
            this.TransferMoneyButton.UseVisualStyleBackColor = true;
            this.TransferMoneyButton.Click += new System.EventHandler(this.TransferMoneyButton_Click);
            // 
            // DepositMoneyButton
            // 
            this.DepositMoneyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DepositMoneyButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DepositMoneyButton.Location = new System.Drawing.Point(5, 214);
            this.DepositMoneyButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.DepositMoneyButton.Name = "DepositMoneyButton";
            this.DepositMoneyButton.Size = new System.Drawing.Size(808, 92);
            this.DepositMoneyButton.TabIndex = 2;
            this.DepositMoneyButton.Text = "Deposit Money";
            this.DepositMoneyButton.UseVisualStyleBackColor = true;
            this.DepositMoneyButton.Click += new System.EventHandler(this.DepositMoneyButton_Click);
            // 
            // WithdrawMoneyButton
            // 
            this.WithdrawMoneyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WithdrawMoneyButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WithdrawMoneyButton.Location = new System.Drawing.Point(5, 110);
            this.WithdrawMoneyButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.WithdrawMoneyButton.Name = "WithdrawMoneyButton";
            this.WithdrawMoneyButton.Size = new System.Drawing.Size(808, 92);
            this.WithdrawMoneyButton.TabIndex = 1;
            this.WithdrawMoneyButton.Text = "Withdraw Money";
            this.WithdrawMoneyButton.UseVisualStyleBackColor = true;
            // 
            // CheckBalanceButton
            // 
            this.CheckBalanceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckBalanceButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckBalanceButton.Location = new System.Drawing.Point(5, 6);
            this.CheckBalanceButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.CheckBalanceButton.Name = "CheckBalanceButton";
            this.CheckBalanceButton.Size = new System.Drawing.Size(808, 92);
            this.CheckBalanceButton.TabIndex = 0;
            this.CheckBalanceButton.Text = "Check Balance";
            this.CheckBalanceButton.UseVisualStyleBackColor = true;
            this.CheckBalanceButton.Click += new System.EventHandler(this.CheckBalanceButton_Click);
            // 
            // MainMenuFormTable
            // 
            this.MainMenuFormTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainMenuFormTable.ColumnCount = 1;
            this.MainMenuFormTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainMenuFormTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.MainMenuFormTable.Controls.Add(this.CheckBalanceButton, 0, 0);
            this.MainMenuFormTable.Controls.Add(this.WithdrawMoneyButton, 0, 1);
            this.MainMenuFormTable.Controls.Add(this.DepositMoneyButton, 0, 2);
            this.MainMenuFormTable.Controls.Add(this.TransferMoneyButton, 0, 3);
            this.MainMenuFormTable.Controls.Add(this.ExitButton, 0, 4);
            this.MainMenuFormTable.Location = new System.Drawing.Point(30, 78);
            this.MainMenuFormTable.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MainMenuFormTable.Name = "MainMenuFormTable";
            this.MainMenuFormTable.RowCount = 5;
            this.MainMenuFormTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainMenuFormTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainMenuFormTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainMenuFormTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainMenuFormTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainMenuFormTable.Size = new System.Drawing.Size(818, 520);
            this.MainMenuFormTable.TabIndex = 0;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(885, 644);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.MainMenuFormTable);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "MainMenuForm";
            this.Text = "Form1";
            this.MainMenuFormTable.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button TransferMoneyButton;
        private System.Windows.Forms.Button DepositMoneyButton;
        private System.Windows.Forms.Button WithdrawMoneyButton;
        private System.Windows.Forms.Button CheckBalanceButton;
        private System.Windows.Forms.TableLayoutPanel MainMenuFormTable;
    }
}

