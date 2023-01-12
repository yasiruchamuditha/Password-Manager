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
    public partial class BankCards : Form
    {
        public BankCards()
        {
            InitializeComponent();
        }

        //Button Add Click Event
        //Go to Add BankCard Page
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                BANKCARD_ADDCARD ADDCARD = new BANKCARD_ADDCARD();
                ADDCARD.Show();
                this.Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Button View Click Event
        //Display the saved Bank card Details
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
                string sql = "SELECT * FROM BANKCARDS";

                //Create Sqlcommand class Object
                SqlCommand command = new SqlCommand(sql, Con);

                //Create SqlDataAdapter class Object
                SqlDataAdapter adaobj = new SqlDataAdapter(command);

                //creating a datatble Object
                DataTable dataTable = new DataTable();

                //filling the data table with data
                adaobj.Fill(dataTable);

                //set the data in grid view
                GRID_BANKCARDS.DataSource = dataTable;

                //Close the Connection
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Button Back Click Event
        //Back to Home Page
        private void IbtnBack_Click(object sender, EventArgs e)
        {
            Home H3 = new Home();
            H3.Show();
            this.Visible = false;
        }

        //Button Update Click Event
        //Go to Update BankCard Page
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                BANKCARD_ADDCARD ADDCARD = new BANKCARD_ADDCARD();
                ADDCARD.Show();
                this.Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Button Delete Click Event
        //Go to Delete BankCard Page
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                BANKCARD_CHANGECARD BANKCARD=new BANKCARD_CHANGECARD();
                BANKCARD.Show();
                this.Visible = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
