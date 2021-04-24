
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
            this.tableLayoutPanel25 = new System.Windows.Forms.TableLayoutPanel();
            this.AccountTransferChangeAmountButton = new System.Windows.Forms.Button();
            this.AccountTransferAmountDynamicLabel = new System.Windows.Forms.Label();
            this.AccountTransferFinalizeButto = new System.Windows.Forms.Button();
            this.AccountTransferWelcomeLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel25.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel25
            // 
            this.tableLayoutPanel25.ColumnCount = 1;
            this.tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel25.Controls.Add(this.AccountTransferChangeAmountButton, 0, 1);
            this.tableLayoutPanel25.Controls.Add(this.AccountTransferAmountDynamicLabel, 0, 0);
            this.tableLayoutPanel25.Controls.Add(this.AccountTransferFinalizeButto, 0, 2);
            this.tableLayoutPanel25.Location = new System.Drawing.Point(29, 98);
            this.tableLayoutPanel25.Name = "tableLayoutPanel25";
            this.tableLayoutPanel25.RowCount = 3;
            this.tableLayoutPanel25.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel25.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel25.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel25.Size = new System.Drawing.Size(824, 534);
            this.tableLayoutPanel25.TabIndex = 19;
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
            // AccountTransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 644);
            this.Controls.Add(this.AccountTransferWelcomeLabel);
            this.Controls.Add(this.tableLayoutPanel25);
            this.Name = "AccountTransferForm";
            this.Text = "AccountTransferForm";
            this.tableLayoutPanel25.ResumeLayout(false);
            this.tableLayoutPanel25.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel25;
        private System.Windows.Forms.Button AccountTransferChangeAmountButton;
        private System.Windows.Forms.Button AccountTransferFinalizeButto;
        private System.Windows.Forms.Label Accou;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button AccountTransferFinalizeButton;
        private System.Windows.Forms.Label AccountTransferWelcomeLabel;
        private System.Windows.Forms.Label A;
        private System.Windows.Forms.Label AccountTransferAmountDynamicLabel;
    }
}