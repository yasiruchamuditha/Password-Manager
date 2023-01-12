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
    public partial class Web : Form
    {
        public Web()
        {
            InitializeComponent();
        }

        //ADD Button Click Event
        //Go to WebSites Adding Page
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                WEB_ADDACCOUNT ADDACCOUNT = new WEB_ADDACCOUNT();
                ADDACCOUNT.Show();
                this.Visible = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Button Back Click Event
        //Go Back To Home Page
        private void IbtnBack_Click(object sender, EventArgs e)
        {
            try
            {
                Home HOME = new Home();
                HOME.Show();
                this.Visible = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Button Change Click Event
        //Go to Web Details Changing Page
        private void BtnChange_Click(object sender, EventArgs e)
        {
            try
            {
                WEB_CHANGEACCOUNT CHANGEACCOUNT = new WEB_CHANGEACCOUNT();
                CHANGEACCOUNT.Show();
                this.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        //Button View Click Event
        //Display Saved Web Sites Details
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
                string sql = "SELECT * FROM WEBSITES";

                //Create Sqlcommand class Object
                SqlCommand command = new SqlCommand(sql, Con);

                //Create SqlDataAdapter class Object
                SqlDataAdapter adaobj = new SqlDataAdapter(command);

                //creating a datatble Object
                DataTable dataTable = new DataTable();

                //filling the data table with data
                adaobj.Fill(dataTable);

                //set the data in grid view
                GRID_WEB.DataSource = dataTable;

                //Close the Connection
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Button Change Click Event
        //Go to Web Details Changing Page
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                WEB_DELETEWEBSITE WEB_DELETEWEBSITE = new WEB_DELETEWEBSITE();
                WEB_DELETEWEBSITE.Show();
                this.Visible = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
