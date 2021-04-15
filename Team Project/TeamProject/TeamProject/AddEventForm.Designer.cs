
namespace TeamProject
{
    partial class AddEventForm
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
            this.AddEventFormContainerTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.FormNavigationButtonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PreviousPageButton = new System.Windows.Forms.Button();
            this.NextPageButton = new System.Windows.Forms.Button();
            this.AddEventFormContainerTableLayoutPanel.SuspendLayout();
            this.FormNavigationButtonsTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddEventFormContainerTableLayoutPanel
            // 
            this.AddEventFormContainerTableLayoutPanel.ColumnCount = 1;
            this.AddEventFormContainerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AddEventFormContainerTableLayoutPanel.Controls.Add(this.FormNavigationButtonsTableLayoutPanel, 0, 1);
            this.AddEventFormContainerTableLayoutPanel.Location = new System.Drawing.Point(13, 13);
            this.AddEventFormContainerTableLayoutPanel.Name = "AddEventFormContainerTableLayoutPanel";
            this.AddEventFormContainerTableLayoutPanel.RowCount = 2;
            this.AddEventFormContainerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.AddEventFormContainerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.AddEventFormContainerTableLayoutPanel.Size = new System.Drawing.Size(1205, 1045);
            this.AddEventFormContainerTableLayoutPanel.TabIndex = 0;
            // 
            // FormNavigationButtonsTableLayoutPanel
            // 
            this.FormNavigationButtonsTableLayoutPanel.ColumnCount = 3;
            this.FormNavigationButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.FormNavigationButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.FormNavigationButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.FormNavigationButtonsTableLayoutPanel.Controls.Add(this.PreviousPageButton, 0, 0);
            this.FormNavigationButtonsTableLayoutPanel.Controls.Add(this.NextPageButton, 2, 0);
            this.FormNavigationButtonsTableLayoutPanel.Location = new System.Drawing.Point(3, 891);
            this.FormNavigationButtonsTableLayoutPanel.Name = "FormNavigationButtonsTableLayoutPanel";
            this.FormNavigationButtonsTableLayoutPanel.RowCount = 1;
            this.FormNavigationButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FormNavigationButtonsTableLayoutPanel.Size = new System.Drawing.Size(1199, 151);
            this.FormNavigationButtonsTableLayoutPanel.TabIndex = 0;
            // 
            // PreviousPageButton
            // 
            this.PreviousPageButton.Location = new System.Drawing.Point(3, 3);
            this.PreviousPageButton.Name = "PreviousPageButton";
            this.PreviousPageButton.Size = new System.Drawing.Size(233, 145);
            this.PreviousPageButton.TabIndex = 0;
            this.PreviousPageButton.Text = "Previous";
            this.PreviousPageButton.UseVisualStyleBackColor = true;
            this.PreviousPageButton.Click += new System.EventHandler(this.PreviousPageButton_Click);
            // 
            // NextPageButton
            // 
            this.NextPageButton.Location = new System.Drawing.Point(961, 3);
            this.NextPageButton.Name = "NextPageButton";
            this.NextPageButton.Size = new System.Drawing.Size(235, 145);
            this.NextPageButton.TabIndex = 1;
            this.NextPageButton.Text = "Next";
            this.NextPageButton.UseVisualStyleBackColor = true;
            this.NextPageButton.Click += new System.EventHandler(this.NextPageButton_Click);
            // 
            // AddEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 1070);
            this.Controls.Add(this.AddEventFormContainerTableLayoutPanel);
            this.Name = "AddEventForm";
            this.Text = "AddEventForm";
            this.AddEventFormContainerTableLayoutPanel.ResumeLayout(false);
            this.FormNavigationButtonsTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel AddEventFormContainerTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel FormNavigationButtonsTableLayoutPanel;
        private System.Windows.Forms.Button PreviousPageButton;
        private System.Windows.Forms.Button NextPageButton;
    }
}