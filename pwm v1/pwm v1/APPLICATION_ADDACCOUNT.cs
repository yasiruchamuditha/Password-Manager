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
    public partial class APPLICATION_ADDACCOUNT : Form
    {
        public APPLICATION_ADDACCOUNT()
        {
            InitializeComponent();
        }

        //Button Add Click Event
        //Add Applications Details
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //Create ConnectionString
                string ConnectionString = @"Data Source=DESKTOP\SQLEXPRESS;Initial Catalog=THIRDEYE_PASSWORD_MANAGER;User Id=yasiru;password=123456789";

                //Create SqlConnection with Connection class
                SqlConnection Con = new SqlConnection(ConnectionString);

                //Open the Connection
                Con.Open();

                string sql = "INSERT INTO APPLICATIONS(APPLICATION_NAME,APPLICATION_USERNAME,APPLICATION_PASSWORD,COMMENT)" + "values('"+TxtApplication_Name.Text +"','"+ TxtUserName.Text +"','"+ TxtPassword.Text +"','"+ RtxtComment.Text +"')";
                
                //create Command class Object
                SqlCommand command = new SqlCommand(sql, Con);

                //Execute the Sql Steatement
                command.ExecuteNonQuery();

                //Output
                MessageBox.Show("Succesfully Added Application Details");

                //Clear the TextBoxes
                TxtApplication_Name.Text = "";
                TxtUserName.Text = "";
                TxtPassword.Text = "";
                RtxtComment.Text = "";

                //Close the Connection
                Con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Button Clear Click Event
        //Clear the TextBoxes
        private void BtnClear_Click(object sender, EventArgs e)
        {
            try
            {
                TxtApplication_Name.Text = "";
                TxtUserName.Text = "";
                TxtPassword.Text = "";
                RtxtComment.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Butoon Back Click Event
        //Go Back To Appliacation Page
        private void IbtnBack_Click(object sender, EventArgs e)
        {
            try
            {
                Applications applications = new Applications();
                applications.Show();
                this.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
