using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Data.SqlClient;
using System.Configuration;

namespace FinanceProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SqlConnection sqlCon = null;
            //get database parameters from App.config file
            String strServer = ConfigurationManager.AppSettings["server"];
            String strDatabase = ConfigurationManager.AppSettings["database"];
            String strLogin = ConfigurationManager.AppSettings["login"];
            String strPassword = ConfigurationManager.AppSettings["password"];
            //open connection to database
            String strConnect = $"Server={strServer};Database={strDatabase};User Id={strLogin};Password={strPassword};";
            sqlCon = new SqlConnection(strConnect);
            sqlCon.Open();
            //set up call to stored procedure
            SqlCommand sqlCmd = new SqlCommand("get_available_tickers", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            DataSet dataset = new DataSet();
            da.Fill(dataset, "table1");

            foreach (DataTable table in dataset.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    foreach (object item in row.ItemArray)
                    {
                        comboBox1.Items.Add(item.ToString());
                    }
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InsertNewTradesButton_Click(object sender, EventArgs e)
        {
            TradeForm tradeForm = new TradeForm();
            tradeForm.Show();
        }
        private void TransactionsButton_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = null;
            //get database parameters from App.config file
            String strServer = ConfigurationManager.AppSettings["server"];
            String strDatabase = ConfigurationManager.AppSettings["database"];
            String strLogin = ConfigurationManager.AppSettings["login"];
            String strPassword = ConfigurationManager.AppSettings["password"];
            //open connection to database
            String strConnect = $"Server={strServer};Database={strDatabase};User Id={strLogin};Password={strPassword};";
            sqlCon = new SqlConnection(strConnect);
            sqlCon.Open();
            //get values
            String reportType = Convert.ToString(reportTypeCombo.SelectedItem);
            String ticker = Convert.ToString(comboBox1.SelectedItem);
            DateTime startDate = TransactionsStartDatePicker.Value;
            DateTime endDate = endDateTimePicker.Value;

            switch (reportType)
            {
                case "Transaction":
                    generateTransaction(sqlCon);
                    break;
                case "PnL":
                    generatePnL(sqlCon, ticker, startDate, endDate);
                    break;
                case "Portfolio":
                    generatePortfolio(sqlCon, startDate, endDate);
                    break;
                case "Daily Yield":
                    getDailyYield(sqlCon, ticker, startDate, endDate);
                    break;
                default:
                    Console.WriteLine("None Chosen");
                    break;
            }
     }

        private void generatePnL(SqlConnection sqlCon, String ticker, DateTime startDate, DateTime endDate)
        {
            //set up call to stored procedure
            SqlCommand sqlCmd = new SqlCommand("ticker_daily_pl_report", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@Ticker", System.Data.SqlDbType.VarChar).Value = ticker;
            sqlCmd.Parameters.Add("@Start", System.Data.SqlDbType.Date).Value = startDate;
            sqlCmd.Parameters.Add("@End", System.Data.SqlDbType.Date).Value = endDate;
            //execute stored procedure
            sqlCmd.ExecuteNonQuery();
            //get data returned by stored procedure and display it
            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            DataSet dataset = new DataSet();
            da.Fill(dataset, "table1");
            PnLReportDataGridView.AutoGenerateColumns = true;
            PnLReportDataGridView.DataSource = dataset.Tables["table1"];
        }

        private void generatePortfolio(SqlConnection sqlCon, DateTime startDate, DateTime endDate)
        {
            //set up call to stored procedure
            SqlCommand sqlCmd = new SqlCommand("portfolio_daily_pl_report", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@Start Date", System.Data.SqlDbType.DateTime).Value = startDate;
            sqlCmd.Parameters.Add("@End Date", System.Data.SqlDbType.DateTime).Value = endDate;
            //execute stored procedure
            sqlCmd.ExecuteNonQuery();
            //get data returned by stored procedure and display it

            //----not sure what to do here-------
            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            DataSet dataset = new DataSet();
            da.Fill(dataset, "table1");
            //____________.AutoGenerateColumns = true;
            //____________.DataSource = dataset.Tables["table1"];
        }

        private void generateTransaction(SqlConnection sqlCon)
        {
            //set up call to stored procedure
            SqlCommand sqlCmd = new SqlCommand("transaction_report", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            //execute stored procedure
            sqlCmd.ExecuteNonQuery();
            //get data returned by stored procedure and display it

            //----not sure what to do here-------
            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            DataSet dataset = new DataSet();
            da.Fill(dataset, "table1");
            //____________.AutoGenerateColumns = true;
            //____________.DataSource = dataset.Tables["table1"];
        }

        private void getDailyYield(SqlConnection sqlCon, String ticker, DateTime startDate, DateTime endDate)
        {
            //set up call to stored procedure
            SqlCommand sqlCmd = new SqlCommand("get_ticker_daily_yield", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@Ticker", System.Data.SqlDbType.VarChar).Value = ticker;
            sqlCmd.Parameters.Add("@Start Date", System.Data.SqlDbType.DateTime).Value = startDate;
            sqlCmd.Parameters.Add("@End Date", System.Data.SqlDbType.DateTime).Value = endDate;
            //execute stored procedure
            sqlCmd.ExecuteNonQuery();
            //get data returned by stored procedure and display it

            //----not sure what to do here-------
            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            DataSet dataset = new DataSet();
            da.Fill(dataset, "table1");
            //____________.AutoGenerateColumns = true;
            //____________.DataSource = dataset.Tables["table1"];
        }

        private void TransactionsStartDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //Actually do something/get selected value
            string value = comboBox1.SelectedItem.ToString();
            Console.WriteLine(value);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void reportTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
