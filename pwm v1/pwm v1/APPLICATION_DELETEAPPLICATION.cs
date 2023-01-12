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
    public partial class APPLICATION_DELETEAPPLICATION : Form
    {
        public APPLICATION_DELETEAPPLICATION()
        {
            InitializeComponent();
        }

        //Button Delete Click Event
        //Delete Application Details
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
                string sql = "DELETE FROM APPLICATIONS WHERE APPLICATION_NAME = '" + txtApplication_Name.Text + "' AND APPLICATION_PASSWORD='" + txtPassword.Text + "' ";

                //create Command class Object
                SqlCommand command = new SqlCommand(sql, Con);

                //Execute the Sql Steatement
                command.ExecuteNonQuery();

                //Output
                MessageBox.Show("Succesfully Deleted Your Application Details");

                //Close the Connection
                Con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Back to application Page
        private void IbtnBack_Click(object sender, EventArgs e)
        {
            Applications applications = new Applications();
            applications.Show();
            this.Visible=false;
        }
    }
}
