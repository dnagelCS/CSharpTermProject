namespace FinanceProject
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.DailyValuesTableButtonPanel = new System.Windows.Forms.Panel();
            this.reportTypeCombo = new System.Windows.Forms.ComboBox();
            this.ReportTypeLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TransactionsButton = new System.Windows.Forms.Button();
            this.StartDate = new System.Windows.Forms.Label();
            this.TickerLabel = new System.Windows.Forms.Label();
            this.TransactionsStartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.PnLReportDataGridView = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.InsertNewTradesButton = new System.Windows.Forms.Button();
            this.PnLlabel = new System.Windows.Forms.Label();
            this.DailyValuesTableButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PnLReportDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // DailyValuesTableButtonPanel
            // 
            this.DailyValuesTableButtonPanel.BackColor = System.Drawing.Color.Tan;
            this.DailyValuesTableButtonPanel.Controls.Add(this.reportTypeCombo);
            this.DailyValuesTableButtonPanel.Controls.Add(this.ReportTypeLabel);
            this.DailyValuesTableButtonPanel.Controls.Add(this.endDateLabel);
            this.DailyValuesTableButtonPanel.Controls.Add(this.endDateTimePicker);
            this.DailyValuesTableButtonPanel.Controls.Add(this.TransactionsButton);
            this.DailyValuesTableButtonPanel.Controls.Add(this.StartDate);
            this.DailyValuesTableButtonPanel.Controls.Add(this.TickerLabel);
            this.DailyValuesTableButtonPanel.Controls.Add(this.TransactionsStartDatePicker);
            this.DailyValuesTableButtonPanel.Controls.Add(this.comboBox1);
            this.DailyValuesTableButtonPanel.Location = new System.Drawing.Point(92, 29);
            this.DailyValuesTableButtonPanel.Margin = new System.Windows.Forms.Padding(4);
            this.DailyValuesTableButtonPanel.Name = "DailyValuesTableButtonPanel";
            this.DailyValuesTableButtonPanel.Size = new System.Drawing.Size(2465, 151);
            this.DailyValuesTableButtonPanel.TabIndex = 4;
            // 
            // reportTypeCombo
            // 
            this.reportTypeCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportTypeCombo.FormattingEnabled = true;
            this.reportTypeCombo.Items.AddRange(new object[] {
            "Transaction",
            "PnL",
            "Chart"});
            this.reportTypeCombo.Location = new System.Drawing.Point(328, 40);
            this.reportTypeCombo.Name = "reportTypeCombo";
            this.reportTypeCombo.Size = new System.Drawing.Size(278, 62);
            this.reportTypeCombo.TabIndex = 19;
            // 
            // ReportTypeLabel
            // 
            this.ReportTypeLabel.AutoSize = true;
            this.ReportTypeLabel.BackColor = System.Drawing.Color.White;
            this.ReportTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportTypeLabel.Location = new System.Drawing.Point(14, 42);
            this.ReportTypeLabel.Name = "ReportTypeLabel";
            this.ReportTypeLabel.Size = new System.Drawing.Size(289, 55);
            this.ReportTypeLabel.TabIndex = 18;
            this.ReportTypeLabel.Text = "Report Type";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.BackColor = System.Drawing.SystemColors.Control;
            this.endDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateLabel.Location = new System.Drawing.Point(1648, 42);
            this.endDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(225, 55);
            this.endDateLabel.TabIndex = 17;
            this.endDateLabel.Text = "End Date";
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDateTimePicker.Location = new System.Drawing.Point(1891, 38);
            this.endDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(290, 61);
            this.endDateTimePicker.TabIndex = 16;
            this.endDateTimePicker.Value = new System.DateTime(2020, 12, 24, 0, 0, 0, 0);
            // 
            // TransactionsButton
            // 
            this.TransactionsButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionsButton.Location = new System.Drawing.Point(2204, 22);
            this.TransactionsButton.Margin = new System.Windows.Forms.Padding(4);
            this.TransactionsButton.Name = "TransactionsButton";
            this.TransactionsButton.Size = new System.Drawing.Size(244, 107);
            this.TransactionsButton.TabIndex = 13;
            this.TransactionsButton.Text = "Get Data";
            this.TransactionsButton.UseVisualStyleBackColor = true;
            // 
            // StartDate
            // 
            this.StartDate.AutoSize = true;
            this.StartDate.BackColor = System.Drawing.SystemColors.Control;
            this.StartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDate.Location = new System.Drawing.Point(1057, 42);
            this.StartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(240, 55);
            this.StartDate.TabIndex = 12;
            this.StartDate.Text = "Start Date";
            // 
            // TickerLabel
            // 
            this.TickerLabel.AutoSize = true;
            this.TickerLabel.BackColor = System.Drawing.SystemColors.Control;
            this.TickerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TickerLabel.Location = new System.Drawing.Point(623, 46);
            this.TickerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TickerLabel.Name = "TickerLabel";
            this.TickerLabel.Size = new System.Drawing.Size(154, 55);
            this.TickerLabel.TabIndex = 11;
            this.TickerLabel.Text = "Ticker";
            // 
            // TransactionsStartDatePicker
            // 
            this.TransactionsStartDatePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionsStartDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionsStartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TransactionsStartDatePicker.Location = new System.Drawing.Point(1317, 38);
            this.TransactionsStartDatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.TransactionsStartDatePicker.Name = "TransactionsStartDatePicker";
            this.TransactionsStartDatePicker.Size = new System.Drawing.Size(296, 61);
            this.TransactionsStartDatePicker.TabIndex = 10;
            this.TransactionsStartDatePicker.Value = new System.DateTime(2019, 7, 1, 11, 36, 0, 0);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(791, 42);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(240, 62);
            this.comboBox1.TabIndex = 9;
            // 
            // PnLReportDataGridView
            // 
            this.PnLReportDataGridView.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.PnLReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PnLReportDataGridView.Location = new System.Drawing.Point(92, 293);
            this.PnLReportDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.PnLReportDataGridView.Name = "PnLReportDataGridView";
            this.PnLReportDataGridView.RowHeadersWidth = 102;
            this.PnLReportDataGridView.RowTemplate.Height = 40;
            this.PnLReportDataGridView.Size = new System.Drawing.Size(934, 1312);
            this.PnLReportDataGridView.TabIndex = 6;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            this.chart1.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            this.chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.FrameThin6;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Location = new System.Drawing.Point(1275, 293);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Name = "Series1";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1282, 1312);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chartPrices";
            // 
            // InsertNewTradesButton
            // 
            this.InsertNewTradesButton.BackColor = System.Drawing.Color.Tan;
            this.InsertNewTradesButton.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertNewTradesButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.InsertNewTradesButton.Location = new System.Drawing.Point(672, 1667);
            this.InsertNewTradesButton.Margin = new System.Windows.Forms.Padding(4);
            this.InsertNewTradesButton.Name = "InsertNewTradesButton";
            this.InsertNewTradesButton.Size = new System.Drawing.Size(1082, 209);
            this.InsertNewTradesButton.TabIndex = 8;
            this.InsertNewTradesButton.Text = "Insert New Trade";
            this.InsertNewTradesButton.UseVisualStyleBackColor = false;
            this.InsertNewTradesButton.Click += new System.EventHandler(this.InsertNewTradesButton_Click);
            // 
            // PnLlabel
            // 
            this.PnLlabel.AutoSize = true;
            this.PnLlabel.BackColor = System.Drawing.Color.SeaShell;
            this.PnLlabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnLlabel.Location = new System.Drawing.Point(331, 197);
            this.PnLlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PnLlabel.Name = "PnLlabel";
            this.PnLlabel.Size = new System.Drawing.Size(448, 70);
            this.PnLlabel.TabIndex = 9;
            this.PnLlabel.Text = "Current Report";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::FinanceProject.Properties.Resources.vs_money2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2618, 1930);
            this.Controls.Add(this.PnLlabel);
            this.Controls.Add(this.InsertNewTradesButton);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.PnLReportDataGridView);
            this.Controls.Add(this.DailyValuesTableButtonPanel);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Trade Reports";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DailyValuesTableButtonPanel.ResumeLayout(false);
            this.DailyValuesTableButtonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PnLReportDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel DailyValuesTableButtonPanel;
        private System.Windows.Forms.DataGridView PnLReportDataGridView;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button InsertNewTradesButton;
        private System.Windows.Forms.DateTimePicker TransactionsStartDatePicker;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button TransactionsButton;
        private System.Windows.Forms.Label StartDate;
        private System.Windows.Forms.Label TickerLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.Label PnLlabel;
        private System.Windows.Forms.ComboBox reportTypeCombo;
        private System.Windows.Forms.Label ReportTypeLabel;
    }
}

