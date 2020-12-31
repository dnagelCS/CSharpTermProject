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
        }

        private void InsertNewTradesButton_Click(object sender, EventArgs e)
        {
            TradeForm tradeForm = new TradeForm();
            tradeForm.Show();
        }

<<<<<<< HEAD
        private void Form1_Load(object sender, EventArgs e)
        {

        }
=======
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
            string ticker = comboBox1.ValueMember;
            DateTime startDate = TransactionsStartDatePicker.Value;
            DateTime endDate = endDateTimePicker.Value;
            generatePnL(sqlCon, ticker, startDate, endDate);
            generatePortfolio(sqlCon, startDate, endDate);
            generateTransaction(sqlCon);
            getDailyYield(sqlCon, ticker, startDate, endDate);
        }


        private void generatePnL(SqlConnection sqlCon, String ticker, DateTime startDate, DateTime endDate)
        {
            //set up call to stored procedure
            SqlCommand sqlCmd = new SqlCommand("ticker_daily_pl_report", sqlCon);
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
            //PnLReportDataGridView.AutoGenerateColumns = true;
            //PnLReportDataGridView.DataSource = dataset.Tables["table1"];
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

>>>>>>> 2d71054fc9c24e0ad61aaf6054015870e774db75
    }
}
