using System.Windows.Forms;

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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.ReportDataGridView = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.InsertNewTradesButton = new System.Windows.Forms.Button();
            this.PnLlabel = new System.Windows.Forms.Label();
            this.DailyValuesTableButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataGridView)).BeginInit();
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
            this.DailyValuesTableButtonPanel.Location = new System.Drawing.Point(52, 19);
            this.DailyValuesTableButtonPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DailyValuesTableButtonPanel.Name = "DailyValuesTableButtonPanel";
            this.DailyValuesTableButtonPanel.Size = new System.Drawing.Size(1377, 97);
            this.DailyValuesTableButtonPanel.TabIndex = 4;
            // 
            // reportTypeCombo
            // 
            this.reportTypeCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportTypeCombo.FormattingEnabled = true;
            this.reportTypeCombo.Items.AddRange(new object[] {
            "Transaction",
            "PnL",
            "Portfolio",
            "Daily Yield"});
            this.reportTypeCombo.Location = new System.Drawing.Point(184, 26);
            this.reportTypeCombo.Margin = new System.Windows.Forms.Padding(2);
            this.reportTypeCombo.Name = "reportTypeCombo";
            this.reportTypeCombo.Size = new System.Drawing.Size(158, 40);
            this.reportTypeCombo.TabIndex = 19;
            this.reportTypeCombo.SelectedIndexChanged += new System.EventHandler(this.reportTypeCombo_SelectedIndexChanged);
            // 
            // ReportTypeLabel
            // 
            this.ReportTypeLabel.AutoSize = true;
            this.ReportTypeLabel.BackColor = System.Drawing.Color.White;
            this.ReportTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportTypeLabel.Location = new System.Drawing.Point(8, 27);
            this.ReportTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ReportTypeLabel.Name = "ReportTypeLabel";
            this.ReportTypeLabel.Size = new System.Drawing.Size(175, 33);
            this.ReportTypeLabel.TabIndex = 18;
            this.ReportTypeLabel.Text = "Report Type";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.BackColor = System.Drawing.SystemColors.Control;
            this.endDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateLabel.Location = new System.Drawing.Point(927, 27);
            this.endDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(135, 33);
            this.endDateLabel.TabIndex = 17;
            this.endDateLabel.Text = "End Date";
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDateTimePicker.Location = new System.Drawing.Point(1064, 25);
            this.endDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(165, 39);
            this.endDateTimePicker.TabIndex = 16;
            this.endDateTimePicker.Value = new System.DateTime(2020, 12, 24, 0, 0, 0, 0);
            // 
            // TransactionsButton
            // 
            this.TransactionsButton.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionsButton.Location = new System.Drawing.Point(1240, 14);
            this.TransactionsButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TransactionsButton.Name = "TransactionsButton";
            this.TransactionsButton.Size = new System.Drawing.Size(125, 69);
            this.TransactionsButton.TabIndex = 13;
            this.TransactionsButton.Text = "Get";
            this.TransactionsButton.UseVisualStyleBackColor = true;
            this.TransactionsButton.Click += new System.EventHandler(this.TransactionsButton_Click);
            // 
            // StartDate
            // 
            this.StartDate.AutoSize = true;
            this.StartDate.BackColor = System.Drawing.SystemColors.Control;
            this.StartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDate.Location = new System.Drawing.Point(595, 27);
            this.StartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(145, 33);
            this.StartDate.TabIndex = 12;
            this.StartDate.Text = "Start Date";
            // 
            // TickerLabel
            // 
            this.TickerLabel.AutoSize = true;
            this.TickerLabel.BackColor = System.Drawing.SystemColors.Control;
            this.TickerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TickerLabel.Location = new System.Drawing.Point(350, 30);
            this.TickerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TickerLabel.Name = "TickerLabel";
            this.TickerLabel.Size = new System.Drawing.Size(96, 33);
            this.TickerLabel.TabIndex = 11;
            this.TickerLabel.Text = "Ticker";
            // 
            // TransactionsStartDatePicker
            // 
            this.TransactionsStartDatePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionsStartDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionsStartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TransactionsStartDatePicker.Location = new System.Drawing.Point(741, 25);
            this.TransactionsStartDatePicker.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TransactionsStartDatePicker.Name = "TransactionsStartDatePicker";
            this.TransactionsStartDatePicker.Size = new System.Drawing.Size(168, 39);
            this.TransactionsStartDatePicker.TabIndex = 10;
            this.TransactionsStartDatePicker.Value = new System.DateTime(2019, 7, 1, 14, 47, 0, 0);
            this.TransactionsStartDatePicker.ValueChanged += new System.EventHandler(this.TransactionsStartDatePicker_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(445, 27);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 40);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // ReportDataGridView
            // 
            this.ReportDataGridView.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.ReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReportDataGridView.Location = new System.Drawing.Point(52, 189);
            this.ReportDataGridView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ReportDataGridView.Name = "PnLReportDataGridView";
            this.ReportDataGridView.RowHeadersVisible = false;
            this.ReportDataGridView.RowHeadersWidth = 102;
            this.ReportDataGridView.RowTemplate.Height = 40;
            this.ReportDataGridView.Size = new System.Drawing.Size(525, 846);
            this.ReportDataGridView.TabIndex = 6;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            this.chart1.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            this.chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.FrameThin6;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(708, 189);
            this.chart1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(721, 846);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chartPrices";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // InsertNewTradesButton
            // 
            this.InsertNewTradesButton.BackColor = System.Drawing.Color.Tan;
            this.InsertNewTradesButton.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertNewTradesButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.InsertNewTradesButton.Location = new System.Drawing.Point(378, 1075);
            this.InsertNewTradesButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.InsertNewTradesButton.Name = "InsertNewTradesButton";
            this.InsertNewTradesButton.Size = new System.Drawing.Size(741, 25);
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
            this.PnLlabel.Location = new System.Drawing.Point(186, 127);
            this.PnLlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PnLlabel.Name = "PnLlabel";
            this.PnLlabel.Size = new System.Drawing.Size(273, 43);
            this.PnLlabel.TabIndex = 9;
            this.PnLlabel.Text = "Current Report";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::FinanceProject.Properties.Resources.vs_money2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1108, 703);
            this.Controls.Add(this.PnLlabel);
            this.Controls.Add(this.InsertNewTradesButton);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.ReportDataGridView);
            this.Controls.Add(this.DailyValuesTableButtonPanel);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Trade Reports";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DailyValuesTableButtonPanel.ResumeLayout(false);
            this.DailyValuesTableButtonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel DailyValuesTableButtonPanel;
        private System.Windows.Forms.DataGridView ReportDataGridView;
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

