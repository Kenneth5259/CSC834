
namespace TeamProject
{
    partial class EventListForm
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
            this.EventListTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.EventListFilterByStaticLabel = new System.Windows.Forms.Label();
            this.EventListFilterTypeButtonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.EventListFilterByDateButton = new System.Windows.Forms.Button();
            this.EventListFilterByMonthButton = new System.Windows.Forms.Button();
            this.EventListFilterByYearButton = new System.Windows.Forms.Button();
            this.EventListFilterDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EventListFilteredListBox = new System.Windows.Forms.ListBox();
            this.EventListFileredViewModeButtons = new System.Windows.Forms.TableLayoutPanel();
            this.EventListFilteredViewModeCloseButton = new System.Windows.Forms.Button();
            this.EventListFilteredViewButton = new System.Windows.Forms.Button();
            this.EventListTableLayoutPanel.SuspendLayout();
            this.EventListFilterTypeButtonsTableLayoutPanel.SuspendLayout();
            this.EventListFileredViewModeButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // EventListTableLayoutPanel
            // 
            this.EventListTableLayoutPanel.ColumnCount = 1;
            this.EventListTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.EventListTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.EventListTableLayoutPanel.Controls.Add(this.EventListFilterDateTimePicker, 0, 2);
            this.EventListTableLayoutPanel.Controls.Add(this.EventListFilterByStaticLabel, 0, 0);
            this.EventListTableLayoutPanel.Controls.Add(this.EventListFilterTypeButtonsTableLayoutPanel, 0, 1);
            this.EventListTableLayoutPanel.Controls.Add(this.EventListFilteredListBox, 0, 3);
            this.EventListTableLayoutPanel.Controls.Add(this.EventListFileredViewModeButtons, 0, 4);
            this.EventListTableLayoutPanel.Location = new System.Drawing.Point(1, -1);
            this.EventListTableLayoutPanel.Name = "EventListTableLayoutPanel";
            this.EventListTableLayoutPanel.RowCount = 5;
            this.EventListTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.EventListTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.EventListTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.EventListTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47F));
            this.EventListTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.EventListTableLayoutPanel.Size = new System.Drawing.Size(893, 812);
            this.EventListTableLayoutPanel.TabIndex = 0;
            // 
            // EventListFilterByStaticLabel
            // 
            this.EventListFilterByStaticLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EventListFilterByStaticLabel.AutoSize = true;
            this.EventListFilterByStaticLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventListFilterByStaticLabel.Location = new System.Drawing.Point(359, 11);
            this.EventListFilterByStaticLabel.Name = "EventListFilterByStaticLabel";
            this.EventListFilterByStaticLabel.Size = new System.Drawing.Size(174, 42);
            this.EventListFilterByStaticLabel.TabIndex = 0;
            this.EventListFilterByStaticLabel.Text = "Filter By: ";
            // 
            // EventListFilterTypeButtonsTableLayoutPanel
            // 
            this.EventListFilterTypeButtonsTableLayoutPanel.ColumnCount = 3;
            this.EventListFilterTypeButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.EventListFilterTypeButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.EventListFilterTypeButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.EventListFilterTypeButtonsTableLayoutPanel.Controls.Add(this.EventListFilterByYearButton, 2, 0);
            this.EventListFilterTypeButtonsTableLayoutPanel.Controls.Add(this.EventListFilterByMonthButton, 1, 0);
            this.EventListFilterTypeButtonsTableLayoutPanel.Controls.Add(this.EventListFilterByDateButton, 0, 0);
            this.EventListFilterTypeButtonsTableLayoutPanel.Location = new System.Drawing.Point(3, 67);
            this.EventListFilterTypeButtonsTableLayoutPanel.Name = "EventListFilterTypeButtonsTableLayoutPanel";
            this.EventListFilterTypeButtonsTableLayoutPanel.RowCount = 1;
            this.EventListFilterTypeButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.EventListFilterTypeButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.EventListFilterTypeButtonsTableLayoutPanel.Size = new System.Drawing.Size(887, 115);
            this.EventListFilterTypeButtonsTableLayoutPanel.TabIndex = 1;
            // 
            // EventListFilterByDateButton
            // 
            this.EventListFilterByDateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventListFilterByDateButton.Location = new System.Drawing.Point(3, 3);
            this.EventListFilterByDateButton.Name = "EventListFilterByDateButton";
            this.EventListFilterByDateButton.Size = new System.Drawing.Size(289, 109);
            this.EventListFilterByDateButton.TabIndex = 0;
            this.EventListFilterByDateButton.Text = "Date";
            this.EventListFilterByDateButton.UseVisualStyleBackColor = true;
            this.EventListFilterByDateButton.Click += new System.EventHandler(this.EventListFilterByDateButton_Click);
            // 
            // EventListFilterByMonthButton
            // 
            this.EventListFilterByMonthButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventListFilterByMonthButton.Location = new System.Drawing.Point(298, 3);
            this.EventListFilterByMonthButton.Name = "EventListFilterByMonthButton";
            this.EventListFilterByMonthButton.Size = new System.Drawing.Size(289, 109);
            this.EventListFilterByMonthButton.TabIndex = 1;
            this.EventListFilterByMonthButton.Text = "Month";
            this.EventListFilterByMonthButton.UseVisualStyleBackColor = true;
            this.EventListFilterByMonthButton.Click += new System.EventHandler(this.EventListFilterByMonthButton_Click);
            // 
            // EventListFilterByYearButton
            // 
            this.EventListFilterByYearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventListFilterByYearButton.Location = new System.Drawing.Point(593, 3);
            this.EventListFilterByYearButton.Name = "EventListFilterByYearButton";
            this.EventListFilterByYearButton.Size = new System.Drawing.Size(289, 109);
            this.EventListFilterByYearButton.TabIndex = 2;
            this.EventListFilterByYearButton.Text = "Year";
            this.EventListFilterByYearButton.UseVisualStyleBackColor = true;
            this.EventListFilterByYearButton.Click += new System.EventHandler(this.EventListFilterByYearButton_Click);
            // 
            // EventListFilterDateTimePicker
            // 
            this.EventListFilterDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EventListFilterDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventListFilterDateTimePicker.Location = new System.Drawing.Point(3, 230);
            this.EventListFilterDateTimePicker.Name = "EventListFilterDateTimePicker";
            this.EventListFilterDateTimePicker.Size = new System.Drawing.Size(887, 31);
            this.EventListFilterDateTimePicker.TabIndex = 4;
            // 
            // EventListFilteredListBox
            // 
            this.EventListFilteredListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventListFilteredListBox.FormattingEnabled = true;
            this.EventListFilteredListBox.ItemHeight = 25;
            this.EventListFilteredListBox.Location = new System.Drawing.Point(3, 309);
            this.EventListFilteredListBox.Name = "EventListFilteredListBox";
            this.EventListFilteredListBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EventListFilteredListBox.Size = new System.Drawing.Size(887, 354);
            this.EventListFilteredListBox.TabIndex = 5;
            // 
            // EventListFileredViewModeButtons
            // 
            this.EventListFileredViewModeButtons.ColumnCount = 2;
            this.EventListFileredViewModeButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EventListFileredViewModeButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EventListFileredViewModeButtons.Controls.Add(this.EventListFilteredViewButton, 1, 0);
            this.EventListFileredViewModeButtons.Controls.Add(this.EventListFilteredViewModeCloseButton, 0, 0);
            this.EventListFileredViewModeButtons.Location = new System.Drawing.Point(3, 690);
            this.EventListFileredViewModeButtons.Name = "EventListFileredViewModeButtons";
            this.EventListFileredViewModeButtons.RowCount = 1;
            this.EventListFileredViewModeButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.EventListFileredViewModeButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.EventListFileredViewModeButtons.Size = new System.Drawing.Size(887, 119);
            this.EventListFileredViewModeButtons.TabIndex = 6;
            // 
            // EventListFilteredViewModeCloseButton
            // 
            this.EventListFilteredViewModeCloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventListFilteredViewModeCloseButton.Location = new System.Drawing.Point(3, 3);
            this.EventListFilteredViewModeCloseButton.Name = "EventListFilteredViewModeCloseButton";
            this.EventListFilteredViewModeCloseButton.Size = new System.Drawing.Size(434, 113);
            this.EventListFilteredViewModeCloseButton.TabIndex = 0;
            this.EventListFilteredViewModeCloseButton.Text = "Close";
            this.EventListFilteredViewModeCloseButton.UseVisualStyleBackColor = true;
            this.EventListFilteredViewModeCloseButton.Click += new System.EventHandler(this.EventListFilteredViewModeCloseButton_Click);
            // 
            // EventListFilteredViewButton
            // 
            this.EventListFilteredViewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventListFilteredViewButton.Location = new System.Drawing.Point(446, 3);
            this.EventListFilteredViewButton.Name = "EventListFilteredViewButton";
            this.EventListFilteredViewButton.Size = new System.Drawing.Size(434, 113);
            this.EventListFilteredViewButton.TabIndex = 1;
            this.EventListFilteredViewButton.Text = "View";
            this.EventListFilteredViewButton.UseVisualStyleBackColor = true;
            this.EventListFilteredViewButton.Click += new System.EventHandler(this.EventListFilteredViewButton_Click);
            // 
            // EventListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 813);
            this.Controls.Add(this.EventListTableLayoutPanel);
            this.Name = "EventListForm";
            this.Text = "EventListForm";
            this.EventListTableLayoutPanel.ResumeLayout(false);
            this.EventListTableLayoutPanel.PerformLayout();
            this.EventListFilterTypeButtonsTableLayoutPanel.ResumeLayout(false);
            this.EventListFileredViewModeButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel EventListTableLayoutPanel;
        private System.Windows.Forms.DateTimePicker EventListFilterDateTimePicker;
        private System.Windows.Forms.Label EventListFilterByStaticLabel;
        private System.Windows.Forms.TableLayoutPanel EventListFilterTypeButtonsTableLayoutPanel;
        private System.Windows.Forms.Button EventListFilterByYearButton;
        private System.Windows.Forms.Button EventListFilterByMonthButton;
        private System.Windows.Forms.Button EventListFilterByDateButton;
        private System.Windows.Forms.ListBox EventListFilteredListBox;
        private System.Windows.Forms.TableLayoutPanel EventListFileredViewModeButtons;
        private System.Windows.Forms.Button EventListFilteredViewModeCloseButton;
        private System.Windows.Forms.Button EventListFilteredViewButton;
    }
}