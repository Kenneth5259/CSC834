
namespace ATM_Practice
{
    partial class AccountTransferForm
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
            this.AccountTransferConfirmationTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AccountTransferChangeAmountButton = new System.Windows.Forms.Button();
            this.AccountTransferAmountDynamicLabel = new System.Windows.Forms.Label();
            this.AccountTransferFinalizeButto = new System.Windows.Forms.Button();
            this.AccountTransferWelcomeLabel = new System.Windows.Forms.Label();
            this.AccountTransferLimitErrorTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AccountTransferLimitErrorChangeButton = new System.Windows.Forms.Button();
            this.AccountTransferLimitMainMenuButton = new System.Windows.Forms.Button();
            this.AccountTransferLimitErrorStaticLabel = new System.Windows.Forms.Label();
            this.AccountTransferConfirmationTableLayoutPanel.SuspendLayout();
            this.AccountTransferLimitErrorTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AccountTransferConfirmationTableLayoutPanel
            // 
            this.AccountTransferConfirmationTableLayoutPanel.ColumnCount = 1;
            this.AccountTransferConfirmationTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AccountTransferConfirmationTableLayoutPanel.Controls.Add(this.AccountTransferChangeAmountButton, 0, 1);
            this.AccountTransferConfirmationTableLayoutPanel.Controls.Add(this.AccountTransferAmountDynamicLabel, 0, 0);
            this.AccountTransferConfirmationTableLayoutPanel.Controls.Add(this.AccountTransferFinalizeButto, 0, 2);
            this.AccountTransferConfirmationTableLayoutPanel.Location = new System.Drawing.Point(29, 98);
            this.AccountTransferConfirmationTableLayoutPanel.Name = "AccountTransferConfirmationTableLayoutPanel";
            this.AccountTransferConfirmationTableLayoutPanel.RowCount = 3;
            this.AccountTransferConfirmationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.AccountTransferConfirmationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.AccountTransferConfirmationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.AccountTransferConfirmationTableLayoutPanel.Size = new System.Drawing.Size(824, 534);
            this.AccountTransferConfirmationTableLayoutPanel.TabIndex = 19;
            this.AccountTransferConfirmationTableLayoutPanel.Visible = false;
            // 
            // AccountTransferChangeAmountButton
            // 
            this.AccountTransferChangeAmountButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AccountTransferChangeAmountButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccountTransferChangeAmountButton.Location = new System.Drawing.Point(26, 122);
            this.AccountTransferChangeAmountButton.Name = "AccountTransferChangeAmountButton";
            this.AccountTransferChangeAmountButton.Size = new System.Drawing.Size(772, 180);
            this.AccountTransferChangeAmountButton.TabIndex = 1;
            this.AccountTransferChangeAmountButton.Text = "Change Transfer Amount";
            this.AccountTransferChangeAmountButton.UseVisualStyleBackColor = true;
            // 
            // AccountTransferAmountDynamicLabel
            // 
            this.AccountTransferAmountDynamicLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AccountTransferAmountDynamicLabel.AutoSize = true;
            this.AccountTransferAmountDynamicLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccountTransferAmountDynamicLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.AccountTransferAmountDynamicLabel.Location = new System.Drawing.Point(424, 30);
            this.AccountTransferAmountDynamicLabel.Name = "AccountTransferAmountDynamicLabel";
            this.AccountTransferAmountDynamicLabel.Size = new System.Drawing.Size(397, 45);
            this.AccountTransferAmountDynamicLabel.TabIndex = 11;
            this.AccountTransferAmountDynamicLabel.Text = "Transfer Amount: $1234.56";
            // 
            // AccountTransferFinalizeButto
            // 
            this.AccountTransferFinalizeButto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AccountTransferFinalizeButto.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccountTransferFinalizeButto.Location = new System.Drawing.Point(26, 336);
            this.AccountTransferFinalizeButto.Name = "AccountTransferFinalizeButto";
            this.AccountTransferFinalizeButto.Size = new System.Drawing.Size(772, 180);
            this.AccountTransferFinalizeButto.TabIndex = 2;
            this.AccountTransferFinalizeButto.Text = "Finalize";
            this.AccountTransferFinalizeButto.UseVisualStyleBackColor = true;
            // 
            // AccountTransferWelcomeLabel
            // 
            this.AccountTransferWelcomeLabel.AutoSize = true;
            this.AccountTransferWelcomeLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccountTransferWelcomeLabel.Location = new System.Drawing.Point(29, 34);
            this.AccountTransferWelcomeLabel.Name = "AccountTransferWelcomeLabel";
            this.AccountTransferWelcomeLabel.Size = new System.Drawing.Size(332, 45);
            this.AccountTransferWelcomeLabel.TabIndex = 20;
            this.AccountTransferWelcomeLabel.Text = "Welcome to ZZZ Bank";
            // 
            // AccountTransferLimitErrorTableLayoutPanel
            // 
            this.AccountTransferLimitErrorTableLayoutPanel.ColumnCount = 1;
            this.AccountTransferLimitErrorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AccountTransferLimitErrorTableLayoutPanel.Controls.Add(this.AccountTransferLimitErrorChangeButton, 0, 1);
            this.AccountTransferLimitErrorTableLayoutPanel.Controls.Add(this.AccountTransferLimitMainMenuButton, 0, 2);
            this.AccountTransferLimitErrorTableLayoutPanel.Controls.Add(this.AccountTransferLimitErrorStaticLabel, 0, 0);
            this.AccountTransferLimitErrorTableLayoutPanel.Location = new System.Drawing.Point(29, 82);
            this.AccountTransferLimitErrorTableLayoutPanel.Name = "AccountTransferLimitErrorTableLayoutPanel";
            this.AccountTransferLimitErrorTableLayoutPanel.RowCount = 3;
            this.AccountTransferLimitErrorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.AccountTransferLimitErrorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.AccountTransferLimitErrorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.AccountTransferLimitErrorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.AccountTransferLimitErrorTableLayoutPanel.Size = new System.Drawing.Size(824, 550);
            this.AccountTransferLimitErrorTableLayoutPanel.TabIndex = 21;
            this.AccountTransferLimitErrorTableLayoutPanel.Visible = false;
            // 
            // AccountTransferLimitErrorChangeButton
            // 
            this.AccountTransferLimitErrorChangeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AccountTransferLimitErrorChangeButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccountTransferLimitErrorChangeButton.Location = new System.Drawing.Point(14, 139);
            this.AccountTransferLimitErrorChangeButton.Name = "AccountTransferLimitErrorChangeButton";
            this.AccountTransferLimitErrorChangeButton.Size = new System.Drawing.Size(795, 162);
            this.AccountTransferLimitErrorChangeButton.TabIndex = 1;
            this.AccountTransferLimitErrorChangeButton.Text = "Change Transfer Amount";
            this.AccountTransferLimitErrorChangeButton.UseVisualStyleBackColor = true;
            // 
            // AccountTransferLimitMainMenuButton
            // 
            this.AccountTransferLimitMainMenuButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AccountTransferLimitMainMenuButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccountTransferLimitMainMenuButton.Location = new System.Drawing.Point(14, 359);
            this.AccountTransferLimitMainMenuButton.Name = "AccountTransferLimitMainMenuButton";
            this.AccountTransferLimitMainMenuButton.Size = new System.Drawing.Size(795, 162);
            this.AccountTransferLimitMainMenuButton.TabIndex = 2;
            this.AccountTransferLimitMainMenuButton.Text = "Main Menu";
            this.AccountTransferLimitMainMenuButton.UseVisualStyleBackColor = true;
            // 
            // AccountTransferLimitErrorStaticLabel
            // 
            this.AccountTransferLimitErrorStaticLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AccountTransferLimitErrorStaticLabel.AutoSize = true;
            this.AccountTransferLimitErrorStaticLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccountTransferLimitErrorStaticLabel.ForeColor = System.Drawing.Color.Red;
            this.AccountTransferLimitErrorStaticLabel.Location = new System.Drawing.Point(36, 10);
            this.AccountTransferLimitErrorStaticLabel.Name = "AccountTransferLimitErrorStaticLabel";
            this.AccountTransferLimitErrorStaticLabel.Size = new System.Drawing.Size(751, 90);
            this.AccountTransferLimitErrorStaticLabel.TabIndex = 11;
            this.AccountTransferLimitErrorStaticLabel.Text = "Transfer Amount Requested Will Place One or Both Accounts Above Daily $3000 Limit" +
    ".";
            // 
            // AccountTransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 644);
            this.Controls.Add(this.AccountTransferLimitErrorTableLayoutPanel);
            this.Controls.Add(this.AccountTransferWelcomeLabel);
            this.Controls.Add(this.AccountTransferConfirmationTableLayoutPanel);
            this.Name = "AccountTransferForm";
            this.Text = "AccountTransferForm";
            this.AccountTransferConfirmationTableLayoutPanel.ResumeLayout(false);
            this.AccountTransferConfirmationTableLayoutPanel.PerformLayout();
            this.AccountTransferLimitErrorTableLayoutPanel.ResumeLayout(false);
            this.AccountTransferLimitErrorTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel AccountTransferConfirmationTableLayoutPanel;
        private System.Windows.Forms.Button AccountTransferChangeAmountButton;
        private System.Windows.Forms.Button AccountTransferFinalizeButto;
        private System.Windows.Forms.Label Accou;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button AccountTransferFinalizeButton;
        private System.Windows.Forms.Label AccountTransferWelcomeLabel;
        private System.Windows.Forms.Label A;
        private System.Windows.Forms.Label AccountTransferAmountDynamicLabel;
        private System.Windows.Forms.TableLayoutPanel AccountTransferLimitErrorTableLayoutPanel;
        private System.Windows.Forms.Button AccountTransferLimitErrorChangeButton;
        private System.Windows.Forms.Button AccountTransferLimitMainMenuButton;
        private System.Windows.Forms.Label AccountTransferLimitErrorStaticLabel;
    }
}