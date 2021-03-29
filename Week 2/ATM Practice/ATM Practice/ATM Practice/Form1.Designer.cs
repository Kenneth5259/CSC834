
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
            this.MainMenuFormTable = new System.Windows.Forms.TableLayoutPanel();
            this.CheckBalanceButton = new System.Windows.Forms.Button();
            this.WithdrawMoneyButton = new System.Windows.Forms.Button();
            this.DepositMoneyButton = new System.Windows.Forms.Button();
            this.TransferMoneyButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.CheckBalanceFormTable = new System.Windows.Forms.TableLayoutPanel();
            this.AccountsListFormTable = new System.Windows.Forms.TableLayoutPanel();
            this.AccountListItem6 = new System.Windows.Forms.Button();
            this.AccountListItem5 = new System.Windows.Forms.Button();
            this.AccountListItem4 = new System.Windows.Forms.Button();
            this.AccountListItem3 = new System.Windows.Forms.Button();
            this.AccountListItem2 = new System.Windows.Forms.Button();
            this.AccountListItem1 = new System.Windows.Forms.Button();
            this.AccountsListLabel = new System.Windows.Forms.Label();
            this.MainMenuButton = new System.Windows.Forms.Button();
            this.AccountBalanceFormTable = new System.Windows.Forms.TableLayoutPanel();
            this.AccBalanceReturnButton = new System.Windows.Forms.Button();
            this.AccBalanceMainMenuButton = new System.Windows.Forms.Button();
            this.AccBalanceSplitContainer = new System.Windows.Forms.SplitContainer();
            this.BalanceStaticLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MainMenuFormTable.SuspendLayout();
            this.CheckBalanceFormTable.SuspendLayout();
            this.AccountsListFormTable.SuspendLayout();
            this.AccountBalanceFormTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccBalanceSplitContainer)).BeginInit();
            this.AccBalanceSplitContainer.Panel1.SuspendLayout();
            this.AccBalanceSplitContainer.Panel2.SuspendLayout();
            this.AccBalanceSplitContainer.SuspendLayout();
            this.SuspendLayout();
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
            this.MainMenuFormTable.Paint += new System.Windows.Forms.PaintEventHandler(this.MainMenuFormTable_Paint);
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
            this.WithdrawMoneyButton.Click += new System.EventHandler(this.WithdrawMoneyButton_Click);
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
            // CheckBalanceFormTable
            // 
            this.CheckBalanceFormTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckBalanceFormTable.ColumnCount = 1;
            this.CheckBalanceFormTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CheckBalanceFormTable.Controls.Add(this.AccountsListFormTable, 0, 1);
            this.CheckBalanceFormTable.Controls.Add(this.AccountsListLabel, 0, 0);
            this.CheckBalanceFormTable.Controls.Add(this.MainMenuButton, 0, 2);
            this.CheckBalanceFormTable.Location = new System.Drawing.Point(30, 78);
            this.CheckBalanceFormTable.Name = "CheckBalanceFormTable";
            this.CheckBalanceFormTable.RowCount = 3;
            this.CheckBalanceFormTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.CheckBalanceFormTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.CheckBalanceFormTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CheckBalanceFormTable.Size = new System.Drawing.Size(818, 520);
            this.CheckBalanceFormTable.TabIndex = 3;
            this.CheckBalanceFormTable.Visible = false;
            // 
            // AccountsListFormTable
            // 
            this.AccountsListFormTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccountsListFormTable.ColumnCount = 1;
            this.AccountsListFormTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AccountsListFormTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.AccountsListFormTable.Controls.Add(this.AccountListItem6, 0, 5);
            this.AccountsListFormTable.Controls.Add(this.AccountListItem5, 0, 4);
            this.AccountsListFormTable.Controls.Add(this.AccountListItem4, 0, 3);
            this.AccountsListFormTable.Controls.Add(this.AccountListItem3, 0, 2);
            this.AccountsListFormTable.Controls.Add(this.AccountListItem2, 0, 1);
            this.AccountsListFormTable.Controls.Add(this.AccountListItem1, 0, 0);
            this.AccountsListFormTable.Location = new System.Drawing.Point(3, 55);
            this.AccountsListFormTable.Name = "AccountsListFormTable";
            this.AccountsListFormTable.RowCount = 6;
            this.AccountsListFormTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.AccountsListFormTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.AccountsListFormTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.AccountsListFormTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.AccountsListFormTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.AccountsListFormTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.AccountsListFormTable.Size = new System.Drawing.Size(812, 332);
            this.AccountsListFormTable.TabIndex = 6;
            // 
            // AccountListItem6
            // 
            this.AccountListItem6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccountListItem6.Location = new System.Drawing.Point(3, 278);
            this.AccountListItem6.Name = "AccountListItem6";
            this.AccountListItem6.Size = new System.Drawing.Size(806, 51);
            this.AccountListItem6.TabIndex = 5;
            this.AccountListItem6.Text = "Account 000111227";
            this.AccountListItem6.UseVisualStyleBackColor = true;
            this.AccountListItem6.Click += new System.EventHandler(this.AccountListItem6_Click);
            // 
            // AccountListItem5
            // 
            this.AccountListItem5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccountListItem5.Location = new System.Drawing.Point(3, 223);
            this.AccountListItem5.Name = "AccountListItem5";
            this.AccountListItem5.Size = new System.Drawing.Size(806, 49);
            this.AccountListItem5.TabIndex = 4;
            this.AccountListItem5.Text = "Account 000111226";
            this.AccountListItem5.UseVisualStyleBackColor = true;
            this.AccountListItem5.Click += new System.EventHandler(this.AccountListItem5_Click);
            // 
            // AccountListItem4
            // 
            this.AccountListItem4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccountListItem4.Location = new System.Drawing.Point(3, 168);
            this.AccountListItem4.Name = "AccountListItem4";
            this.AccountListItem4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AccountListItem4.Size = new System.Drawing.Size(806, 49);
            this.AccountListItem4.TabIndex = 3;
            this.AccountListItem4.Text = "Account 000111225";
            this.AccountListItem4.UseVisualStyleBackColor = true;
            this.AccountListItem4.Click += new System.EventHandler(this.AccountListItem4_Click);
            // 
            // AccountListItem3
            // 
            this.AccountListItem3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccountListItem3.Location = new System.Drawing.Point(3, 113);
            this.AccountListItem3.Name = "AccountListItem3";
            this.AccountListItem3.Size = new System.Drawing.Size(806, 49);
            this.AccountListItem3.TabIndex = 2;
            this.AccountListItem3.Text = "Account 000111224";
            this.AccountListItem3.UseVisualStyleBackColor = true;
            this.AccountListItem3.Click += new System.EventHandler(this.AccountListItem3_Click);
            // 
            // AccountListItem2
            // 
            this.AccountListItem2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccountListItem2.Location = new System.Drawing.Point(3, 58);
            this.AccountListItem2.Name = "AccountListItem2";
            this.AccountListItem2.Size = new System.Drawing.Size(806, 49);
            this.AccountListItem2.TabIndex = 1;
            this.AccountListItem2.Text = "Account 000111223";
            this.AccountListItem2.UseVisualStyleBackColor = true;
            this.AccountListItem2.Click += new System.EventHandler(this.AccountListItem2_Click);
            // 
            // AccountListItem1
            // 
            this.AccountListItem1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccountListItem1.Location = new System.Drawing.Point(3, 3);
            this.AccountListItem1.Name = "AccountListItem1";
            this.AccountListItem1.Size = new System.Drawing.Size(806, 49);
            this.AccountListItem1.TabIndex = 0;
            this.AccountListItem1.Text = "Account 000111222";
            this.AccountListItem1.UseVisualStyleBackColor = true;
            this.AccountListItem1.Click += new System.EventHandler(this.AccountListItem1_Click);
            // 
            // AccountsListLabel
            // 
            this.AccountsListLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AccountsListLabel.AutoSize = true;
            this.AccountsListLabel.Location = new System.Drawing.Point(3, 11);
            this.AccountsListLabel.Name = "AccountsListLabel";
            this.AccountsListLabel.Size = new System.Drawing.Size(307, 30);
            this.AccountsListLabel.TabIndex = 0;
            this.AccountsListLabel.Text = "Accounts Held with ZZZ Bank: ";
            this.AccountsListLabel.Click += new System.EventHandler(this.AccountsListLabel_Click);
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainMenuButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuButton.Location = new System.Drawing.Point(5, 396);
            this.MainMenuButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MainMenuButton.Name = "MainMenuButton";
            this.MainMenuButton.Size = new System.Drawing.Size(808, 118);
            this.MainMenuButton.TabIndex = 5;
            this.MainMenuButton.Text = "Main Menu";
            this.MainMenuButton.UseVisualStyleBackColor = true;
            this.MainMenuButton.Click += new System.EventHandler(this.CheckBalanceFormMainMenuButton_Click);
            // 
            // AccountBalanceFormTable
            // 
            this.AccountBalanceFormTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccountBalanceFormTable.ColumnCount = 1;
            this.AccountBalanceFormTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AccountBalanceFormTable.Controls.Add(this.AccBalanceReturnButton, 0, 1);
            this.AccountBalanceFormTable.Controls.Add(this.AccBalanceMainMenuButton, 0, 2);
            this.AccountBalanceFormTable.Controls.Add(this.AccBalanceSplitContainer, 0, 0);
            this.AccountBalanceFormTable.Location = new System.Drawing.Point(30, 78);
            this.AccountBalanceFormTable.Name = "AccountBalanceFormTable";
            this.AccountBalanceFormTable.RowCount = 3;
            this.AccountBalanceFormTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.AccountBalanceFormTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.AccountBalanceFormTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.AccountBalanceFormTable.Size = new System.Drawing.Size(818, 520);
            this.AccountBalanceFormTable.TabIndex = 4;
            // 
            // AccBalanceReturnButton
            // 
            this.AccBalanceReturnButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccBalanceReturnButton.Location = new System.Drawing.Point(3, 107);
            this.AccBalanceReturnButton.Name = "AccBalanceReturnButton";
            this.AccBalanceReturnButton.Size = new System.Drawing.Size(812, 202);
            this.AccBalanceReturnButton.TabIndex = 5;
            this.AccBalanceReturnButton.Text = "Check Another Balance";
            this.AccBalanceReturnButton.UseVisualStyleBackColor = true;
            this.AccBalanceReturnButton.Click += new System.EventHandler(this.AccBalanceReturnButton_Click);
            // 
            // AccBalanceMainMenuButton
            // 
            this.AccBalanceMainMenuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccBalanceMainMenuButton.Location = new System.Drawing.Point(3, 315);
            this.AccBalanceMainMenuButton.Name = "AccBalanceMainMenuButton";
            this.AccBalanceMainMenuButton.Size = new System.Drawing.Size(812, 202);
            this.AccBalanceMainMenuButton.TabIndex = 0;
            this.AccBalanceMainMenuButton.Text = "Main Menu";
            this.AccBalanceMainMenuButton.UseVisualStyleBackColor = true;
            this.AccBalanceMainMenuButton.Click += new System.EventHandler(this.AccBalanceFormMainMenuButton_Click);
            // 
            // AccBalanceSplitContainer
            // 
            this.AccBalanceSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccBalanceSplitContainer.Location = new System.Drawing.Point(3, 3);
            this.AccBalanceSplitContainer.Name = "AccBalanceSplitContainer";
            // 
            // AccBalanceSplitContainer.Panel1
            // 
            this.AccBalanceSplitContainer.Panel1.Controls.Add(this.BalanceStaticLabel);
            this.AccBalanceSplitContainer.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.AccBalanceSplitContainer_Panel1_Paint);
            // 
            // AccBalanceSplitContainer.Panel2
            // 
            this.AccBalanceSplitContainer.Panel2.Controls.Add(this.label2);
            this.AccBalanceSplitContainer.Size = new System.Drawing.Size(812, 98);
            this.AccBalanceSplitContainer.SplitterDistance = 270;
            this.AccBalanceSplitContainer.TabIndex = 6;
            // 
            // BalanceStaticLabel
            // 
            this.BalanceStaticLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BalanceStaticLabel.AutoSize = true;
            this.BalanceStaticLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BalanceStaticLabel.Location = new System.Drawing.Point(0, 22);
            this.BalanceStaticLabel.Name = "BalanceStaticLabel";
            this.BalanceStaticLabel.Size = new System.Drawing.Size(135, 45);
            this.BalanceStaticLabel.TabIndex = 0;
            this.BalanceStaticLabel.Text = "Balance:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(191, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 45);
            this.label2.TabIndex = 0;
            this.label2.Text = "$1234.56";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(885, 644);
            this.Controls.Add(this.AccountBalanceFormTable);
            this.Controls.Add(this.CheckBalanceFormTable);
            this.Controls.Add(this.MainMenuFormTable);
            this.Controls.Add(this.WelcomeLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "MainMenuForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.MainMenuFormTable.ResumeLayout(false);
            this.CheckBalanceFormTable.ResumeLayout(false);
            this.CheckBalanceFormTable.PerformLayout();
            this.AccountsListFormTable.ResumeLayout(false);
            this.AccountBalanceFormTable.ResumeLayout(false);
            this.AccBalanceSplitContainer.Panel1.ResumeLayout(false);
            this.AccBalanceSplitContainer.Panel1.PerformLayout();
            this.AccBalanceSplitContainer.Panel2.ResumeLayout(false);
            this.AccBalanceSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccBalanceSplitContainer)).EndInit();
            this.AccBalanceSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainMenuFormTable;
        private System.Windows.Forms.Button CheckBalanceButton;
        private System.Windows.Forms.Button WithdrawMoneyButton;
        private System.Windows.Forms.Button TransferMoneyButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button DepositMoneyButton;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.TableLayoutPanel CheckBalanceFormTable;
        private System.Windows.Forms.Label AccountsListLabel;
        private System.Windows.Forms.Button MainMenuButton;
        private System.Windows.Forms.TableLayoutPanel AccountsListFormTable;
        private System.Windows.Forms.Button AccountListItem6;
        private System.Windows.Forms.Button AccountListItem5;
        private System.Windows.Forms.Button AccountListItem4;
        private System.Windows.Forms.Button AccountListItem3;
        private System.Windows.Forms.Button AccountListItem2;
        private System.Windows.Forms.Button AccountListItem1;
        private System.Windows.Forms.TableLayoutPanel AccountBalanceFormTable;
        private System.Windows.Forms.Button AccBalanceMainMenuButton;
        private System.Windows.Forms.Button AccBalanceReturnButton;
        private System.Windows.Forms.SplitContainer AccBalanceSplitContainer;
        private System.Windows.Forms.Label BalanceStaticLabel;
        private System.Windows.Forms.Label label2;
    }
}

