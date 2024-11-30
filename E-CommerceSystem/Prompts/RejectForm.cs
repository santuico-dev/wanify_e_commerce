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
using ComponentFactory.Krypton.Toolkit;

namespace E_CommerceSystem
{
    public partial class RejectForm : KryptonForm
    {
        Config dbConfig;
        MySqlConnection conn;
        public RejectForm()
        {
            InitializeComponent();
        }

        public RejectForm(string userID, string productID)
        {
            InitializeComponent();
            dbConfig = new Config();
            this.UserID = userID;
            this.ProductID = productID;
        }

        public string UserID { get; set; }
        public string ProductID { get; set; }


        private void RejectForm_Load(object sender, EventArgs e)
        {
            string[] reasons = { "The photo is blurry", "The photo is fake" };
            foreach (string reason in reasons)
            {
                cmbReasons.Items.Add(reason);
            }

        }

 

        private void btnProceed_Click_1(object sender, EventArgs e)
        {
            conn = dbConfig.getConnection();

            try
            {
                conn.Open();

                DialogResult rejectConfirmation = MessageBox.Show("Are you sure you want to reject this request?", "Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (rejectConfirmation == DialogResult.Yes)
                {
                    MySqlCommand updateDefectiveReport = new MySqlCommand("UPDATE defective_products SET status = 'REJECTED' WHERE userID = '" + UserID + "' AND productID = '" + ProductID + "'", conn);
                    updateDefectiveReport.ExecuteNonQuery();


                    //email code here

                    MessageBox.Show("Rejected Successfully");

                    this.Hide();

                }
                else
                {
                    // do nothing
                }

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
