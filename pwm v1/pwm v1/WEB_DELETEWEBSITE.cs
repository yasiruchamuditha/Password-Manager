using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace pwm_v1
{
    public partial class WEB_DELETEWEBSITE : Form
    {
        public WEB_DELETEWEBSITE()
        {
            InitializeComponent();
        }

        //Delete Button Click Event
        //Delete Web Sites Details
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //Create ConnectionString
                string ConnectionString = @"Data Source=DESKTOP-5JC6HTG\SQLEXPRESS;Initial Catalog=THIRDEYE_PASSWORD_MANAGER;User Id=yasiru;password=123456789";

                //Create SqlConnection with Connection class
                SqlConnection Con = new SqlConnection(ConnectionString);

                //Open the Connection
                Con.Open();

                //SQL Steatement
                string sql = "DELETE FROM WEBSITES WHERE WEBSITE_ADDRESS = '"+ Txt_WEBSITE_ADDRESS.Text + "' AND WEBSITE_PASSWORD ='" + Txt_PASSWORD.Text + "' ";

                //create Command class Object
                SqlCommand command = new SqlCommand(sql, Con);

                //Execute the Sql Steatement
                command.ExecuteNonQuery();

                //Output
                MessageBox.Show("Succesfully Deleted Your Web Sites Details");

                //Close the Connection
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Button Back Click Event
        //Go Back to Web page
        private void IbtnBack_Click(object sender, EventArgs e)
        {
            try
            {
                Web WEB = new Web();
                WEB.Show();
                this.Visible = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }
    }
}
