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
    public partial class Applications : Form
    {
        public Applications()
        {
            InitializeComponent();
        }

        //Button Back Click Event
        //Back To Home Page
        private void IbtnBack_Click(object sender, EventArgs e)
        {
            try
            {
                Home Home = new Home();
                Home.Show();
                this.Visible = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Button ADD Click Event
        //Go to Application Adding Page
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                APPLICATION_ADDACCOUNT s11 = new APPLICATION_ADDACCOUNT();
                s11.Show();
                this.Visible = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }

        //Button Change Click Event
        //Go to Application Change Page
        private void BtnChange_Click(object sender, EventArgs e)
        {
            try
            {
                APPLICATION_CHANGEACCOUNT S10 = new APPLICATION_CHANGEACCOUNT();
                S10.Show();
                this.Visible = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Button Delete Click Event
        //Delete Saved Application Details
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                APPLICATION_DELETEAPPLICATION APPLICATION = new APPLICATION_DELETEAPPLICATION();
                APPLICATION.Show();
                this.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //View the Application Details
        private void BtnView_Click(object sender, EventArgs e)
        {
            try
            {
                //Create ConnectionString
                string ConnectionString = @"Data Source=DESKTOP-5JC6HTG\SQLEXPRESS;Initial Catalog=THIRDEYE_PASSWORD_MANAGER;User Id=yasiru;password=123456789";

                //Create SqlConnection with Connection class
                SqlConnection Con = new SqlConnection(ConnectionString);

                //Open the Connection
                Con.Open();

                //SQL Statement
                string sql = "SELECT * FROM APPLICATIONS";

                //Create Sqlcommand class Object
                SqlCommand command = new SqlCommand(sql, Con);

                //Create SqlDataAdapter class Object
                SqlDataAdapter adaobj = new SqlDataAdapter(command);

                //creating a datatble Object
                DataTable dataTable = new DataTable();

                //filling the data table with data
                adaobj.Fill(dataTable);

                //set the data in grid view
                GRID_APPLICATION.DataSource = dataTable;

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
