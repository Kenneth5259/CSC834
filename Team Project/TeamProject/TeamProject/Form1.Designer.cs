
namespace TeamProject
{
    partial class CalendarBaseForm
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
            this.CalendarLayoutPanelContainer = new System.Windows.Forms.TableLayoutPanel();
            this.MonthYearHeaderTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CalendGridTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CalendarMonthLabel = new System.Windows.Forms.Label();
            this.YearCalendarLabel = new System.Windows.Forms.Label();
            this.CalendarLayoutPanelContainer.SuspendLayout();
            this.MonthYearHeaderTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalendarLayoutPanelContainer
            // 
            this.CalendarLayoutPanelContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CalendarLayoutPanelContainer.ColumnCount = 1;
            this.CalendarLayoutPanelContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CalendarLayoutPanelContainer.Controls.Add(this.MonthYearHeaderTableLayoutPanel, 0, 0);
            this.CalendarLayoutPanelContainer.Controls.Add(this.CalendGridTableLayoutPanel, 0, 1);
            this.CalendarLayoutPanelContainer.Location = new System.Drawing.Point(0, 1);
            this.CalendarLayoutPanelContainer.Name = "CalendarLayoutPanelContainer";
            this.CalendarLayoutPanelContainer.RowCount = 2;
            this.CalendarLayoutPanelContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.CalendarLayoutPanelContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.CalendarLayoutPanelContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CalendarLayoutPanelContainer.Size = new System.Drawing.Size(1013, 884);
            this.CalendarLayoutPanelContainer.TabIndex = 0;
            // 
            // MonthYearHeaderTableLayoutPanel
            // 
            this.MonthYearHeaderTableLayoutPanel.ColumnCount = 2;
            this.MonthYearHeaderTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.MonthYearHeaderTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MonthYearHeaderTableLayoutPanel.Controls.Add(this.CalendarMonthLabel, 0, 0);
            this.MonthYearHeaderTableLayoutPanel.Controls.Add(this.YearCalendarLabel, 1, 0);
            this.MonthYearHeaderTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.MonthYearHeaderTableLayoutPanel.Name = "MonthYearHeaderTableLayoutPanel";
            this.MonthYearHeaderTableLayoutPanel.RowCount = 1;
            this.MonthYearHeaderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MonthYearHeaderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MonthYearHeaderTableLayoutPanel.Size = new System.Drawing.Size(1007, 82);
            this.MonthYearHeaderTableLayoutPanel.TabIndex = 0;
            // 
            // CalendGridTableLayoutPanel
            // 
            this.CalendGridTableLayoutPanel.ColumnCount = 7;
            this.CalendGridTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.CalendGridTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.CalendGridTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.CalendGridTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.CalendGridTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.CalendGridTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.CalendGridTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.CalendGridTableLayoutPanel.Location = new System.Drawing.Point(3, 91);
            this.CalendGridTableLayoutPanel.Name = "CalendGridTableLayoutPanel";
            this.CalendGridTableLayoutPanel.RowCount = 7;
            this.CalendGridTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.CalendGridTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.CalendGridTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.CalendGridTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.CalendGridTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.CalendGridTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.CalendGridTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.CalendGridTableLayoutPanel.Size = new System.Drawing.Size(1007, 790);
            this.CalendGridTableLayoutPanel.TabIndex = 1;
            // 
            // CalendarMonthLabel
            // 
            this.CalendarMonthLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CalendarMonthLabel.AutoSize = true;
            this.CalendarMonthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.CalendarMonthLabel.Location = new System.Drawing.Point(343, 13);
            this.CalendarMonthLabel.Name = "CalendarMonthLabel";
            this.CalendarMonthLabel.Size = new System.Drawing.Size(119, 55);
            this.CalendarMonthLabel.TabIndex = 0;
            this.CalendarMonthLabel.Text = "April";
            // 
            // YearCalendarLabel
            // 
            this.YearCalendarLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.YearCalendarLabel.AutoSize = true;
            this.YearCalendarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearCalendarLabel.Location = new System.Drawing.Point(840, 13);
            this.YearCalendarLabel.Name = "YearCalendarLabel";
            this.YearCalendarLabel.Size = new System.Drawing.Size(132, 55);
            this.YearCalendarLabel.TabIndex = 1;
            this.YearCalendarLabel.Text = "2021";
            // 
            // CalendarBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 885);
            this.Controls.Add(this.CalendarLayoutPanelContainer);
            this.Name = "CalendarBaseForm";
            this.Text = "Form1";
            this.CalendarLayoutPanelContainer.ResumeLayout(false);
            this.MonthYearHeaderTableLayoutPanel.ResumeLayout(false);
            this.MonthYearHeaderTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel CalendarLayoutPanelContainer;
        private System.Windows.Forms.TableLayoutPanel MonthYearHeaderTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel CalendGridTableLayoutPanel;
        private System.Windows.Forms.Label CalendarMonthLabel;
        private System.Windows.Forms.Label YearCalendarLabel;
    }
}

