
namespace ATM_Practice
{
    partial class ErrorScreen
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
            this.ErrorScreenTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ErrorScreenDynamicErrorLabel = new System.Windows.Forms.Label();
            this.ErrorScreenDynamicErrorButton = new System.Windows.Forms.Button();
            this.ErrorScreenTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ErrorScreenTableLayoutPanel
            // 
            this.ErrorScreenTableLayoutPanel.ColumnCount = 1;
            this.ErrorScreenTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ErrorScreenTableLayoutPanel.Controls.Add(this.ErrorScreenDynamicErrorLabel, 0, 0);
            this.ErrorScreenTableLayoutPanel.Controls.Add(this.ErrorScreenDynamicErrorButton, 0, 1);
            this.ErrorScreenTableLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.ErrorScreenTableLayoutPanel.Name = "ErrorScreenTableLayoutPanel";
            this.ErrorScreenTableLayoutPanel.RowCount = 2;
            this.ErrorScreenTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.ErrorScreenTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ErrorScreenTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ErrorScreenTableLayoutPanel.Size = new System.Drawing.Size(861, 620);
            this.ErrorScreenTableLayoutPanel.TabIndex = 22;
            // 
            // ErrorScreenDynamicErrorLabel
            // 
            this.ErrorScreenDynamicErrorLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ErrorScreenDynamicErrorLabel.AutoSize = true;
            this.ErrorScreenDynamicErrorLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ErrorScreenDynamicErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorScreenDynamicErrorLabel.Location = new System.Drawing.Point(858, 210);
            this.ErrorScreenDynamicErrorLabel.Name = "ErrorScreenDynamicErrorLabel";
            this.ErrorScreenDynamicErrorLabel.Size = new System.Drawing.Size(0, 45);
            this.ErrorScreenDynamicErrorLabel.TabIndex = 3;
            // 
            // ErrorScreenDynamicErrorButton
            // 
            this.ErrorScreenDynamicErrorButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ErrorScreenDynamicErrorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ErrorScreenDynamicErrorButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ErrorScreenDynamicErrorButton.Location = new System.Drawing.Point(11, 479);
            this.ErrorScreenDynamicErrorButton.Name = "ErrorScreenDynamicErrorButton";
            this.ErrorScreenDynamicErrorButton.Size = new System.Drawing.Size(839, 126);
            this.ErrorScreenDynamicErrorButton.TabIndex = 2;
            this.ErrorScreenDynamicErrorButton.Text = "PIN Entry Screen";
            this.ErrorScreenDynamicErrorButton.UseVisualStyleBackColor = false;
            this.ErrorScreenDynamicErrorButton.Click += new System.EventHandler(this.ErrorScreenDynamicErrorButton_Click);
            // 
            // ErrorScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 644);
            this.Controls.Add(this.ErrorScreenTableLayoutPanel);
            this.Name = "ErrorScreen";
            this.Text = "ErrorScreen";
            this.ErrorScreenTableLayoutPanel.ResumeLayout(false);
            this.ErrorScreenTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ErrorScreenTableLayoutPanel;
        private System.Windows.Forms.Label ErrorScreenDynamicErrorLabel;
        private System.Windows.Forms.Button ErrorScreenDynamicErrorButton;
    }
}