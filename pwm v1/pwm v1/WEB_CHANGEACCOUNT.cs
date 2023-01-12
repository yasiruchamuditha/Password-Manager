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
    public partial class WEB_CHANGEACCOUNT : Form
    {
        public WEB_CHANGEACCOUNT()
        {
            InitializeComponent();
        }

      
        //Button Back Click Event
        //Go Back To Web Page
        private void IbtnBack_Click(object sender, EventArgs e)
        {
            try
            {
                Web web = new Web();
                web.Show();
                this.Visible = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        //Button Update Click Event
        //Update the WebSites Details
        private void BtnUpdate_Click(object sender, EventArgs e)
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
                string sql = "UPDATE WEBSITES SET WEBSITE_LOGIN='" + Txt_LOGIN.Text +"',WEBSITE_PASSWORD='" + Txt_PASSWORD.Text + "' " +
                    "WHERE WEBSITE_ADDRESS ='" + Txt_WEBSITE_ADDRESS.Text + "' ";

                //create Command class Object
                SqlCommand command = new SqlCommand(sql, Con);

                //Execute the Sql Steatement
                command.ExecuteNonQuery();

                //Output
                MessageBox.Show("Succesfully Updated Your Web Sites Details");

                //Clear the Buttons
                Txt_WEBSITE_ADDRESS.Text = "";
                Txt_LOGIN.Text = "";
                Txt_PASSWORD.Text = "";
               
                //Close the Connection
                Con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
