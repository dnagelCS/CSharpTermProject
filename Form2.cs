using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace FinanceProject
{
    public partial class TradeForm : Form
    {
        public TradeForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //TODO make a check that a trade is inserted before closing and adding it to the trades table/PnL chart
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
            string ticker = tickerComboBox.ValueMember;
            double quantity = Convert.ToDouble(quantityTextBox.Text);
            double price = Convert.ToDouble(priceTextBox.Text);
            //set up call to stored procedure
            SqlCommand sqlCmd = new SqlCommand("insert_trade", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@Ticker", System.Data.SqlDbType.VarChar).Value = ticker;
            sqlCmd.Parameters.Add("@Quantity", System.Data.SqlDbType.Float).Value = quantity;
            sqlCmd.Parameters.Add("@Price", System.Data.SqlDbType.Float).Value = price;
            sqlCmd.Parameters.Add("@Date", System.Data.SqlDbType.DateTime).Value = DateTime.Today;
            //execute stored procedure
            sqlCmd.ExecuteNonQuery();

            this.Close();
        }

        private void tickerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
