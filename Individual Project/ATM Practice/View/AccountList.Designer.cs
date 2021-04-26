
namespace ATM_Practice
{
    partial class AccountList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.WithdrawAccountsTableForm = new System.Windows.Forms.TableLayoutPanel();
            this.AccountListAccountsHeldStaticLabel = new System.Windows.Forms.Label();
            this.AccountListMainMenuButton = new System.Windows.Forms.Button();
            this.AccountListDataGridView = new System.Windows.Forms.DataGridView();
            this.AccountListWelcomeLabel = new System.Windows.Forms.Label();
            this.WithdrawAccountsTableForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // WithdrawAccountsTableForm
            // 
            this.WithdrawAccountsTableForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WithdrawAccountsTableForm.ColumnCount = 1;
            this.WithdrawAccountsTableForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.WithdrawAccountsTableForm.Controls.Add(this.AccountListAccountsHeldStaticLabel, 0, 0);
            this.WithdrawAccountsTableForm.Controls.Add(this.AccountListMainMenuButton, 0, 2);
            this.WithdrawAccountsTableForm.Controls.Add(this.AccountListDataGridView, 0, 1);
            this.WithdrawAccountsTableForm.Location = new System.Drawing.Point(32, 89);
            this.WithdrawAccountsTableForm.Name = "WithdrawAccountsTableForm";
            this.WithdrawAccountsTableForm.RowCount = 3;
            this.WithdrawAccountsTableForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.WithdrawAccountsTableForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.WithdrawAccountsTableForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.WithdrawAccountsTableForm.Size = new System.Drawing.Size(818, 520);
            this.WithdrawAccountsTableForm.TabIndex = 10;
            // 
            // AccountListAccountsHeldStaticLabel
            // 
            this.AccountListAccountsHeldStaticLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AccountListAccountsHeldStaticLabel.AutoSize = true;
            this.AccountListAccountsHeldStaticLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccountListAccountsHeldStaticLabel.Location = new System.Drawing.Point(3, 11);
            this.AccountListAccountsHeldStaticLabel.Name = "AccountListAccountsHeldStaticLabel";
            this.AccountListAccountsHeldStaticLabel.Size = new System.Drawing.Size(307, 30);
            this.AccountListAccountsHeldStaticLabel.TabIndex = 0;
            this.AccountListAccountsHeldStaticLabel.Text = "Accounts Held with ZZZ Bank: ";
            // 
            // AccountListMainMenuButton
            // 
            this.AccountListMainMenuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccountListMainMenuButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccountListMainMenuButton.Location = new System.Drawing.Point(5, 396);
            this.AccountListMainMenuButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.AccountListMainMenuButton.Name = "AccountListMainMenuButton";
            this.AccountListMainMenuButton.Size = new System.Drawing.Size(808, 118);
            this.AccountListMainMenuButton.TabIndex = 5;
            this.AccountListMainMenuButton.Text = "Main Menu";
            this.AccountListMainMenuButton.UseVisualStyleBackColor = true;
            this.AccountListMainMenuButton.Click += new System.EventHandler(this.AccountListMainMenuButton_Click);
            // 
            // AccountListDataGridView
            // 
            this.AccountListDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AccountListDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.AccountListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountListDataGridView.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AccountListDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.AccountListDataGridView.Location = new System.Drawing.Point(4, 55);
            this.AccountListDataGridView.Name = "AccountListDataGridView";
            this.AccountListDataGridView.RowHeadersVisible = false;
            this.AccountListDataGridView.RowTemplate.Height = 40;
            this.AccountListDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AccountListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.AccountListDataGridView.Size = new System.Drawing.Size(810, 332);
            this.AccountListDataGridView.TabIndex = 6;
            this.AccountListDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AccountListDataGridView_CellContentClick);
            // 
            // AccountListWelcomeLabel
            // 
            this.AccountListWelcomeLabel.AutoSize = true;
            this.AccountListWelcomeLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccountListWelcomeLabel.Location = new System.Drawing.Point(35, 35);
            this.AccountListWelcomeLabel.Name = "AccountListWelcomeLabel";
            this.AccountListWelcomeLabel.Size = new System.Drawing.Size(332, 45);
            this.AccountListWelcomeLabel.TabIndex = 7;
            this.AccountListWelcomeLabel.Text = "Welcome to ZZZ Bank";
            // 
            // AccountList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 644);
            this.Controls.Add(this.WithdrawAccountsTableForm);
            this.Controls.Add(this.AccountListWelcomeLabel);
            this.Name = "AccountList";
            this.Text = "AccountList";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AccountList_FormClosing);
            this.WithdrawAccountsTableForm.ResumeLayout(false);
            this.WithdrawAccountsTableForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel WithdrawAccountsTableForm;
        private System.Windows.Forms.Label AccountListAccountsHeldStaticLabel;
        private System.Windows.Forms.Button AccountListMainMenuButton;
        private System.Windows.Forms.Label AccountListWelcomeLabel;
        private System.Windows.Forms.DataGridView AccountListDataGridView;
    }
}