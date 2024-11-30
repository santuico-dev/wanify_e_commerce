using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace E_CommerceSystem
{
    public partial class PassRecovery : KryptonForm
    {
        Config dbConfig;
        MySqlConnection conn;
        SendEmailVerification sendCode;
        SendSMSNotification sendSMSNotification;
        public PassRecovery()
        {
            InitializeComponent();
        }

        private void PassRecovery_Load(object sender, EventArgs e)
        {

            required_FieldRecEmail.Visible = false;
            continue_btn.Enabled = false;

        }

        private void user_recoveryEmail_TextChanged(object sender, EventArgs e)
        {
            if (user_phoneNumber.Text == string.Empty)
            {

                required_FieldRecEmail.Visible = true;
                continue_btn.Enabled = false;


            }
            else
            {
                required_FieldRecEmail.Text = "";
                continue_btn.Enabled = true;
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            new Login().Show();
        }

        private void continue_btn_Click(object sender, EventArgs e)
        {
            dbConfig = new Config();
            sendSMSNotification = new SendSMSNotification();
            conn = dbConfig.getConnection();

            MySqlCommand checkDBIfUserExists = new MySqlCommand("SELECT * FROM users WHERE Phone = ('" + user_phoneNumber.Text + "')", conn);

            try
            {
                conn.Open();
                MySqlDataReader fetchRecoveryEmail = checkDBIfUserExists.ExecuteReader();
                fetchRecoveryEmail.Read();

                if (fetchRecoveryEmail.HasRows)
                {
                    string phone = fetchRecoveryEmail.GetString("Phone");
                    string name = fetchRecoveryEmail.GetString("Name");

                    fetchRecoveryEmail.Close();

                    string generatedRecoveryCode = sendSMSNotification.sendSMS(phone, name);

                    MySqlCommand insertRecoveryCode = new MySqlCommand("UPDATE users SET recovery_code = ('" + generatedRecoveryCode + "') WHERE Phone = ('" + phone + "')", conn);
                    MySqlDataReader insertCode = insertRecoveryCode.ExecuteReader();
                    insertCode.Close();

                    this.Close();
                    new Verification(phone).Show();

                }
                else
                {
                
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void back_btn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }
    }
}
