
namespace ATM_Practice
{
    partial class AccountDepositScreen
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
            this.AdditionalDepositTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AddtionalDepositYesButton = new System.Windows.Forms.Button();
            this.AdditionalDepositNoButton = new System.Windows.Forms.Button();
            this.AdditionalDepositStaticLabel = new System.Windows.Forms.Label();
            this.AccountDepositWelcomeLabel = new System.Windows.Forms.Label();
            this.AdditionalDepositTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdditionalDepositTableLayoutPanel
            // 
            this.AdditionalDepositTableLayoutPanel.ColumnCount = 1;
            this.AdditionalDepositTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AdditionalDepositTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.AdditionalDepositTableLayoutPanel.Controls.Add(this.AddtionalDepositYesButton, 0, 1);
            this.AdditionalDepositTableLayoutPanel.Controls.Add(this.AdditionalDepositNoButton, 0, 2);
            this.AdditionalDepositTableLayoutPanel.Controls.Add(this.AdditionalDepositStaticLabel, 0, 0);
            this.AdditionalDepositTableLayoutPanel.Location = new System.Drawing.Point(30, 93);
            this.AdditionalDepositTableLayoutPanel.Name = "AdditionalDepositTableLayoutPanel";
            this.AdditionalDepositTableLayoutPanel.RowCount = 3;
            this.AdditionalDepositTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.AdditionalDepositTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.AdditionalDepositTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.AdditionalDepositTableLayoutPanel.Size = new System.Drawing.Size(824, 526);
            this.AdditionalDepositTableLayoutPanel.TabIndex = 12;
            // 
            // AddtionalDepositYesButton
            // 
            this.AddtionalDepositYesButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddtionalDepositYesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AddtionalDepositYesButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddtionalDepositYesButton.Location = new System.Drawing.Point(31, 197);
            this.AddtionalDepositYesButton.Name = "AddtionalDepositYesButton";
            this.AddtionalDepositYesButton.Size = new System.Drawing.Size(761, 130);
            this.AddtionalDepositYesButton.TabIndex = 1;
            this.AddtionalDepositYesButton.Text = "Yes";
            this.AddtionalDepositYesButton.UseVisualStyleBackColor = false;
            // 
            // AdditionalDepositNoButton
            // 
            this.AdditionalDepositNoButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdditionalDepositNoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AdditionalDepositNoButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AdditionalDepositNoButton.Location = new System.Drawing.Point(31, 373);
            this.AdditionalDepositNoButton.Name = "AdditionalDepositNoButton";
            this.AdditionalDepositNoButton.Size = new System.Drawing.Size(761, 130);
            this.AdditionalDepositNoButton.TabIndex = 2;
            this.AdditionalDepositNoButton.Text = "No";
            this.AdditionalDepositNoButton.UseVisualStyleBackColor = false;
            // 
            // AdditionalDepositStaticLabel
            // 
            this.AdditionalDepositStaticLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdditionalDepositStaticLabel.AutoSize = true;
            this.AdditionalDepositStaticLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AdditionalDepositStaticLabel.ForeColor = System.Drawing.Color.Chocolate;
            this.AdditionalDepositStaticLabel.Location = new System.Drawing.Point(74, 65);
            this.AdditionalDepositStaticLabel.Name = "AdditionalDepositStaticLabel";
            this.AdditionalDepositStaticLabel.Size = new System.Drawing.Size(675, 45);
            this.AdditionalDepositStaticLabel.TabIndex = 3;
            this.AdditionalDepositStaticLabel.Text = "Do you have any additional deposits to make?";
            // 
            // AccountDepositWelcomeLabel
            // 
            this.AccountDepositWelcomeLabel.AutoSize = true;
            this.AccountDepositWelcomeLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccountDepositWelcomeLabel.Location = new System.Drawing.Point(30, 25);
            this.AccountDepositWelcomeLabel.Name = "AccountDepositWelcomeLabel";
            this.AccountDepositWelcomeLabel.Size = new System.Drawing.Size(332, 45);
            this.AccountDepositWelcomeLabel.TabIndex = 13;
            this.AccountDepositWelcomeLabel.Text = "Welcome to ZZZ Bank";
            // 
            // AccountDepositScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 644);
            this.Controls.Add(this.AccountDepositWelcomeLabel);
            this.Controls.Add(this.AdditionalDepositTableLayoutPanel);
            this.Name = "AccountDepositScreen";
            this.Text = "AccountDepositScreen";
            this.AdditionalDepositTableLayoutPanel.ResumeLayout(false);
            this.AdditionalDepositTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel AdditionalDepositTableLayoutPanel;
        private System.Windows.Forms.Button AddtionalDepositYesButton;
        private System.Windows.Forms.Button AdditionalDepositNoButton;
        private System.Windows.Forms.Label AdditionalDepositStaticLabel;
        private System.Windows.Forms.Label AccountDepositWelcomeLabel;
        private System.Windows.Forms.Button t;
    }
}