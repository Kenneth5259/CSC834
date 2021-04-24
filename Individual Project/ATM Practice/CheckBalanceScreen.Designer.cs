
namespace ATM_Practice
{
    partial class CheckBalanceScreen
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
            this.AccountBalanceFormTable = new System.Windows.Forms.TableLayoutPanel();
            this.AccBalanceMainMenuButton = new System.Windows.Forms.Button();
            this.AccBalanceSplitContainer = new System.Windows.Forms.SplitContainer();
            this.BalanceStaticLabel = new System.Windows.Forms.Label();
            this.CheckBalanceDynamicLabel = new System.Windows.Forms.Label();
            this.AccBalanceReturnButton = new System.Windows.Forms.Button();
            this.AccountBalanceFormTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccBalanceSplitContainer)).BeginInit();
            this.AccBalanceSplitContainer.Panel1.SuspendLayout();
            this.AccBalanceSplitContainer.Panel2.SuspendLayout();
            this.AccBalanceSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // AccountBalanceFormTable
            // 
            this.AccountBalanceFormTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccountBalanceFormTable.ColumnCount = 1;
            this.AccountBalanceFormTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AccountBalanceFormTable.Controls.Add(this.AccBalanceMainMenuButton, 0, 2);
            this.AccountBalanceFormTable.Controls.Add(this.AccBalanceSplitContainer, 0, 0);
            this.AccountBalanceFormTable.Controls.Add(this.AccBalanceReturnButton, 0, 1);
            this.AccountBalanceFormTable.Location = new System.Drawing.Point(12, 12);
            this.AccountBalanceFormTable.Name = "AccountBalanceFormTable";
            this.AccountBalanceFormTable.RowCount = 3;
            this.AccountBalanceFormTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.AccountBalanceFormTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.AccountBalanceFormTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.AccountBalanceFormTable.Size = new System.Drawing.Size(861, 620);
            this.AccountBalanceFormTable.TabIndex = 5;
            // 
            // AccBalanceMainMenuButton
            // 
            this.AccBalanceMainMenuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccBalanceMainMenuButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccBalanceMainMenuButton.Location = new System.Drawing.Point(3, 375);
            this.AccBalanceMainMenuButton.Name = "AccBalanceMainMenuButton";
            this.AccBalanceMainMenuButton.Size = new System.Drawing.Size(855, 242);
            this.AccBalanceMainMenuButton.TabIndex = 0;
            this.AccBalanceMainMenuButton.Text = "Main Menu";
            this.AccBalanceMainMenuButton.UseVisualStyleBackColor = true;
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
            // 
            // AccBalanceSplitContainer.Panel2
            // 
            this.AccBalanceSplitContainer.Panel2.Controls.Add(this.CheckBalanceDynamicLabel);
            this.AccBalanceSplitContainer.Size = new System.Drawing.Size(855, 118);
            this.AccBalanceSplitContainer.SplitterDistance = 283;
            this.AccBalanceSplitContainer.TabIndex = 6;
            // 
            // BalanceStaticLabel
            // 
            this.BalanceStaticLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BalanceStaticLabel.AutoSize = true;
            this.BalanceStaticLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BalanceStaticLabel.Location = new System.Drawing.Point(118, 32);
            this.BalanceStaticLabel.Name = "BalanceStaticLabel";
            this.BalanceStaticLabel.Size = new System.Drawing.Size(135, 45);
            this.BalanceStaticLabel.TabIndex = 0;
            this.BalanceStaticLabel.Text = "Balance:";
            // 
            // CheckBalanceDynamicLabel
            // 
            this.CheckBalanceDynamicLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CheckBalanceDynamicLabel.AutoSize = true;
            this.CheckBalanceDynamicLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckBalanceDynamicLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CheckBalanceDynamicLabel.Location = new System.Drawing.Point(396, 32);
            this.CheckBalanceDynamicLabel.Name = "CheckBalanceDynamicLabel";
            this.CheckBalanceDynamicLabel.Size = new System.Drawing.Size(146, 45);
            this.CheckBalanceDynamicLabel.TabIndex = 0;
            this.CheckBalanceDynamicLabel.Text = "$1234.56";
            // 
            // AccBalanceReturnButton
            // 
            this.AccBalanceReturnButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccBalanceReturnButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccBalanceReturnButton.Location = new System.Drawing.Point(3, 127);
            this.AccBalanceReturnButton.Name = "AccBalanceReturnButton";
            this.AccBalanceReturnButton.Size = new System.Drawing.Size(855, 242);
            this.AccBalanceReturnButton.TabIndex = 5;
            this.AccBalanceReturnButton.Text = "Check Another Balance";
            this.AccBalanceReturnButton.UseVisualStyleBackColor = true;
            // 
            // CheckBalanceScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 644);
            this.Controls.Add(this.AccountBalanceFormTable);
            this.Name = "CheckBalanceScreen";
            this.Text = "CheckBalanceScreen";
            this.AccountBalanceFormTable.ResumeLayout(false);
            this.AccBalanceSplitContainer.Panel1.ResumeLayout(false);
            this.AccBalanceSplitContainer.Panel1.PerformLayout();
            this.AccBalanceSplitContainer.Panel2.ResumeLayout(false);
            this.AccBalanceSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccBalanceSplitContainer)).EndInit();
            this.AccBalanceSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel AccountBalanceFormTable;
        private System.Windows.Forms.Button AccBalanceMainMenuButton;
        private System.Windows.Forms.SplitContainer AccBalanceSplitContainer;
        private System.Windows.Forms.Label BalanceStaticLabel;
        private System.Windows.Forms.Label CheckBalanceDynamicLabel;
        private System.Windows.Forms.Button AccBalanceReturnButton;
    }
}