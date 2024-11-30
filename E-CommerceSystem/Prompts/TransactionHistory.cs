using ComponentFactory.Krypton.Toolkit;
using E_CommerceSystem.User_control_components;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_CommerceSystem.Prompts
{
    public partial class TransactionHistory : KryptonForm
    {
        Config dbConfig;
        MySqlConnection conn;

        public TransactionHistory()
        {
            InitializeComponent();
            dbConfig = new Config();
        }

        public TransactionHistory(string userID)
        {
            InitializeComponent();
            dbConfig = new Config();
            this.UserID = userID;
        }

        public string UserID { get; set; }  

        private void TransactionHistory_Load(object sender, EventArgs e)
        {
            conn = dbConfig.getConnection();

            string[] options = { "Gain", "Loss" };
            foreach (string option in options)
            {
                cmbGainsOrLoss.Items.Add(option);
            }

            try
            {

                conn.Open();
                //get the most oldest date on the date ordered
                MySqlCommand getOldestOrderDate = new MySqlCommand("SELECT date_created FROM defective_products ORDER BY date_created ASC", conn);
                MySqlDataReader fetchOldestOrderDate = getOldestOrderDate.ExecuteReader();

                if (fetchOldestOrderDate.HasRows)
                {
                    fetchOldestOrderDate.Read();
                    dtmFrom.Text = fetchOldestOrderDate.GetDateTime("date_created").ToString();
                    fetchOldestOrderDate.Close();
                }

                fetchOldestOrderDate.Close();

                conn.Close();

                fetchByAllData();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void fetchByAllData()
        {
            conn = dbConfig.getConnection();
            transactionFlowLayout.Controls.Clear();

            try
            {
                conn.Open();

                MySqlCommand getTransactionData = new MySqlCommand("SELECT * FROM transaction_history", conn);
                MySqlDataReader fetchTransactionData = getTransactionData.ExecuteReader();

                if (fetchTransactionData.HasRows)
                {
                    while (fetchTransactionData.Read())
                    {
                        TransactionHistoryControl transactionHistoryControl = new TransactionHistoryControl();
                        transactionHistoryControl.Amount = fetchTransactionData.GetInt32("Amount");
                        transactionHistoryControl.Date = fetchTransactionData.GetDateTime("date_created").ToString("yyyy-MM-dd");
                        transactionHistoryControl.Gain = bool.Parse(fetchTransactionData.GetString("isGain"));
                        transactionHistoryControl.ID = fetchTransactionData.GetString("productID");

                        transactionFlowLayout.Controls.Add(transactionHistoryControl);
                    }

                    fetchTransactionData.Close();
                }

                fetchTransactionData.Close();


                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void fetchByStatusAndDates(string status, string from, string to)
        {
            conn = dbConfig.getConnection();
            transactionFlowLayout.Controls.Clear();

            try
            {
                conn.Open();

                MySqlCommand getTransactionData = new MySqlCommand("SELECT * FROM transaction_history WHERE isGain = '" + status + "' AND date_created BETWEEN '" + from + "' AND '" + to + "'", conn);
                MySqlDataReader fetchTransactionData = getTransactionData.ExecuteReader();

                if (fetchTransactionData.HasRows)
                {
                    while (fetchTransactionData.Read())
                    {
                        TransactionHistoryControl transactionHistoryControl = new TransactionHistoryControl();
                        transactionHistoryControl.Amount = fetchTransactionData.GetInt32("Amount");
                        transactionHistoryControl.Date = fetchTransactionData.GetDateTime("date_created").ToString("yyyy-MM-dd");
                        transactionHistoryControl.Gain = bool.Parse(fetchTransactionData.GetString("isGain"));
                        transactionHistoryControl.ID = fetchTransactionData.GetString("productID");

                        transactionFlowLayout.Controls.Add(transactionHistoryControl);
                    }

                    fetchTransactionData.Close();

                }
                else
                {
                    fetchTransactionData.Close();

                    MySqlCommand getTransactionDataIfNone = new MySqlCommand("SELECT * FROM transaction_history WHERE date_created BETWEEN '" + from + "' AND '" + to + "'", conn);
                    MySqlDataReader fetchTransactionDataIfNone = getTransactionDataIfNone.ExecuteReader();

                    while (fetchTransactionDataIfNone.Read())
                    {
                        TransactionHistoryControl transactionHistoryControl = new TransactionHistoryControl();
                        transactionHistoryControl.Amount = fetchTransactionDataIfNone.GetInt32("Amount");
                        transactionHistoryControl.Date = fetchTransactionDataIfNone.GetDateTime("date_created").ToString("yyyy-MM-dd");
                        transactionHistoryControl.Gain = bool.Parse(fetchTransactionDataIfNone.GetString("isGain"));
                        transactionHistoryControl.ID = fetchTransactionDataIfNone.GetString("productID");

                        transactionFlowLayout.Controls.Add(transactionHistoryControl);
                    }

                    fetchTransactionDataIfNone.Close();

                }

                fetchTransactionData.Close();

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtmFrom_ValueChanged(object sender, EventArgs e)
        {
            if (cmbGainsOrLoss.SelectedIndex == -1)
            {
                fetchByStatusAndDates("", dtmFrom.Value.ToString("yyyy-MM-dd"), dtmTo.Value.ToString("yyyy-MM-dd"));

            }
            else
            {
                if (cmbGainsOrLoss.Text.Equals("Gain"))
                {
                    fetchByStatusAndDates("true", dtmFrom.Value.ToString("yyyy-MM-dd"), dtmTo.Value.ToString("yyyy-MM-dd"));

                }
                else
                {
                    fetchByStatusAndDates("false", dtmFrom.Value.ToString("yyyy-MM-dd"), dtmTo.Value.ToString("yyyy-MM-dd"));

                }
            }
        }

        private void dtmTo_ValueChanged(object sender, EventArgs e)
        {
            if (cmbGainsOrLoss.SelectedIndex == -1)
            {
                fetchByStatusAndDates("", dtmFrom.Value.ToString("yyyy-MM-dd"), dtmTo.Value.ToString("yyyy-MM-dd"));

            }
            else
            {
                if (cmbGainsOrLoss.Text.Equals("Gain"))
                {
                    fetchByStatusAndDates("true", dtmFrom.Value.ToString("yyyy-MM-dd"), dtmTo.Value.ToString("yyyy-MM-dd"));

                }
                else
                {
                    fetchByStatusAndDates("false", dtmFrom.Value.ToString("yyyy-MM-dd"), dtmTo.Value.ToString("yyyy-MM-dd"));

                }
            }
        }

        private void cmbGainsOrLoss_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGainsOrLoss.Text.Equals("Gain"))
            {
                fetchByStatusAndDates("true", dtmFrom.Value.ToString("yyyy-MM-dd"), dtmTo.Value.ToString("yyyy-MM-dd"));

            }
            else
            {
                fetchByStatusAndDates("false", dtmFrom.Value.ToString("yyyy-MM-dd"), dtmTo.Value.ToString("yyyy-MM-dd"));

            }
        }

        private void log_in_Click(object sender, EventArgs e)
        {

        }
    }
}
