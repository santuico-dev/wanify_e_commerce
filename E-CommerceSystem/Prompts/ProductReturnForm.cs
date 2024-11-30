using ComponentFactory.Krypton.Toolkit;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_CommerceSystem
{
    public partial class ProductReturnForm : KryptonForm
    {
        Config dbConfig;
        MySqlConnection conn;


        public ProductReturnForm()
        {
            InitializeComponent();
        }

        public ProductReturnForm(string userID, string productID)
        {
            InitializeComponent();
            dbConfig = new Config();
            this.UserID = userID;
            this.ProductID = productID;
        }

        private string UserID { get; set; }
        private string ProductID { get; set; }

        private void ProductReturnForm_Load(object sender, EventArgs e)
        {
            //lblPhoneNumber.Visible = false;
            txtPhoneNumber.Visible = false;
            btnChangeNumber.Visible = false;
            cmbAccDetails.Visible = false;

            cmbAccDetails.Items.Add("Gcash");
            cmbAccDetails.SelectedIndex = 0;

            //combo box contents
            ArrayList mainConcernList = new ArrayList();
            mainConcernList.Add("The product is broken.");
            mainConcernList.Add("The product that I received is not the correct variety");
            mainConcernList.Add("I did not order this product");
            mainConcernList.Add("The product that I received is wrong");

            for(int i = 0; i < mainConcernList.Count; i++)
            {
                cmbMainConcern.Items.Add(mainConcernList[i]);
            }


            string[] actions = { "Refund", "Replacement of the same product" };
            foreach(string action in actions) 
            {
                cmbAction.Items.Add(action);
            }
            
            cmbMainConcern.SelectedIndex = 0;

            conn = dbConfig.getConnection();

            try
            {
                conn.Open();

                MySqlCommand getProductInfo = new MySqlCommand("SELECT * FROM products WHERE productID = '"+ProductID+"'", conn);
                MySqlDataReader fetchProduct = getProductInfo.ExecuteReader();
                
                if(fetchProduct.HasRows)
                {
                    fetchProduct.Read();
                    lblProduct.Text = fetchProduct.GetString("product_name");
                    fetchProduct.Close();

                }
                else 
                { 

                    fetchProduct.Close();
                
                // do nothing
                }

                fetchProduct.Close();

                conn.Close();

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void proofPictureBox_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "Images Files (*.jpg; *.jpeg; *.png)| *.jpg; *.jpeg; *.png;";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                proofPictureBox.Image = new Bitmap(openFileDialog1.FileName);
            }
            else
            {
                // do nothing
            }
        }

        private void cmbAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbAction.Text.Equals("Refund"))
            {
                //lblPhoneNumber.Visible = true;
                txtPhoneNumber.Visible = true;
                btnChangeNumber.Visible = true;
                cmbAccDetails.Visible = true;

                cmbAccDetails.Enabled = false;
                txtPhoneNumber.Enabled = false;
                fetchPhoneNumber();

            }else
            {
               // lblPhoneNumber.Visible = false;
                txtPhoneNumber.Visible = false;
                btnChangeNumber.Visible = false;
            }
        }

        public void fetchPhoneNumber()
        {
            conn = dbConfig.getConnection();

            try
            {
                conn.Open();

                MySqlCommand getPhoneNumber = new MySqlCommand("SELECT Phone FROM users WHERE userID = '"+UserID+"'", conn);   
                MySqlDataReader fetchPhone = getPhoneNumber.ExecuteReader();
                
                if (fetchPhone.HasRows)
                {
                    fetchPhone.Read();

                    txtPhoneNumber.Text = fetchPhone.GetString("Phone");

                    fetchPhone.Close();
                }

                fetchPhone.Close();


                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnChangeNumber_Click(object sender, EventArgs e)
        {
            if(txtPhoneNumber.Enabled == false)
            {
                txtPhoneNumber.Enabled = true;
                btnChangeNumber.Text = "Cancel";
                btnChangeNumber.BackColor = Color.Red;
            }
            else
            {
                txtPhoneNumber.Enabled = false;
                btnChangeNumber.BackColor = Color.Blue;

            }
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            conn = dbConfig.getConnection();

            try
            {
                if (proofPictureBox.Image != null)
                {
                    DialogResult confirmation = MessageBox.Show("Make sure the photo is valid and it is your own ordered product, kindly double check your images and information before proceeding. Failure in following the requirements will be automatically rejected.", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (confirmation == DialogResult.OK)
                    {
                        DialogResult anotherConfirmation = MessageBox.Show("Are you sure all the details are correct?", "Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (anotherConfirmation == DialogResult.Yes)
                        {
                            //submit
                            conn.Open();

                            MemoryStream ms = new MemoryStream();
                            proofPictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                            byte[] arrImage = ms.GetBuffer();

                            DateTime currentDateTime = DateTime.Now;
                            string formatDate = currentDateTime.ToString("yyyy-MM-dd");

                            MySqlCommand insertDefectiveProduct = new MySqlCommand("INSERT INTO defective_products (proof_image, main_concern, action_request, additional_info, changed_phone_number, status , date_created, userID, productID) VALUES (@proof_image, @main_concern, @action_request, @additional_info, @changed_phone_number, @status ,@date_created, @userID, @productID) ", conn);
                            insertDefectiveProduct.Parameters.AddWithValue("@proof_image", arrImage);
                            insertDefectiveProduct.Parameters.AddWithValue("@main_concern", cmbMainConcern.Text);
                            insertDefectiveProduct.Parameters.AddWithValue("@action_request", cmbAction.Text);
                            insertDefectiveProduct.Parameters.AddWithValue("@additional_info", txtAdditional.Text);
                            insertDefectiveProduct.Parameters.AddWithValue("@changed_phone_number", txtPhoneNumber.Text);
                            insertDefectiveProduct.Parameters.AddWithValue("@status", "PENDING");
                            insertDefectiveProduct.Parameters.AddWithValue("@date_created", formatDate);
                            insertDefectiveProduct.Parameters.AddWithValue("@userID", UserID);
                            insertDefectiveProduct.Parameters.AddWithValue("@productID", ProductID);

                            insertDefectiveProduct.ExecuteNonQuery();

                            MessageBox.Show("Request submitted, the request will be processed within 7 days. Kindly always check your gmail.");

                            //send email code here

                            conn.Close();
                        }
                        else
                        {
                            // do nothing
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Note: The proof image is essential and if you submit without a photo, your request will be rejected.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
