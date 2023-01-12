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
    public partial class EMAIL_ADDACCOUNT : Form
    {
        public EMAIL_ADDACCOUNT()
        {
            InitializeComponent();
        }

        //Button Add Click Event
        //Add Emails Details
        private void BtnAdd_Click(object sender, EventArgs e)
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
                string sql = "INSERT INTO EMAILS(EMAIL_ACCOUNTNAME,EMAIL_PASSWORD,COMMENT)" + 
                "VALUES('"+ TxtAccountName.Text +"','"+ TxtPassword.Text +"','"+ RtxtComment.Text + "')";

                //create Command class Object
                SqlCommand command = new SqlCommand(sql, Con);

                //Execute the Sql Steatement
                command.ExecuteNonQuery();

                //Output
                MessageBox.Show("Succesfully Add Email Details");

                //Close the Connection
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //IconButton Back Click Event
        //Go to Email Page
        private void IbtnBack_Click(object sender, EventArgs e)
        {
            try
            {
                Email E13 = new Email();
                E13.Show();
                this.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Clear the Textboxes
        private void BtnClear_Click(object sender, EventArgs e)
        {
            try
            {
                TxtAccountName.Text = "";
                TxtPassword.Text = "";
                RtxtComment.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //RichTextbox Enter Event
        private void RtxtComment_Enter(object sender, EventArgs e)
        {
            try
            {
                if (RtxtComment.Text == "Add Your Comment Here")
                {
                    RtxtComment.Text = "";
                    RtxtComment.ForeColor = Color.Purple;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //RichTextbox Leave Event
        private void RtxtComment_Leave(object sender, EventArgs e)
        {
            try
            {
                if (RtxtComment.Text == "")
                {
                    RtxtComment.Text = "Add Your Comment Here";
                    RtxtComment.ForeColor = Color.Silver;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
