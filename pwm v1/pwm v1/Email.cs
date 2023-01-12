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
    public partial class Email : Form
    {
        public Email()
        {
            InitializeComponent();
        }

        //Button Add Click Event
        //Go to add email account
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                EMAIL_ADDACCOUNT E10 = new EMAIL_ADDACCOUNT();
                E10.Show();
                this.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Button View Click Event
        //Display Emails Details
        private void BtnView_Click(object sender, EventArgs e)
        {
            try
            {
                //connection string
                string connectionString = @"Data Source=DESKTOP-5JC6HTG\SQLEXPRESS; Initial Catalog=THIRDEYE_PASSWORD_MANAGER; user id=yasiru; password=123456789";
                
                //create sql connection class object
                SqlConnection Con = new SqlConnection(connectionString);
                
                //Open the connection
                Con.Open();

                //Sql statement
                string sql = "select * from EMAILS"; 
                
                //Create Sqlcommand class Object
                SqlCommand command = new SqlCommand(sql, Con);

                //Create SqlDataAdapter class Object
                SqlDataAdapter adaobj = new SqlDataAdapter(command);
                
                //creating a datatble Object
                DataTable dataTable = new DataTable();

                //filling the data table with data
                adaobj.Fill(dataTable);

                //set the data in grid view
                DataGrid_Email.DataSource = dataTable;

                //Close the Connection
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Button Back Click Event
        //Back to HOME page
        private void BtnBack_Click(object sender, EventArgs e)
        {
            try
            {
                Home H1 = new Home();
                H1.Show();
                this.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Button Change Click Event
        //Go to Change Email Account Page
        private void BtnChange_Click(object sender, EventArgs e)
        {
            try
            {
                EMAIL_CHANGEACCOUNT E11 = new EMAIL_CHANGEACCOUNT();
                E11.Show();
                this.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
