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
    public partial class WEB_ADDACCOUNT : Form
    {
        public WEB_ADDACCOUNT()
        {
            InitializeComponent();
        }

        //Button Back Click Event
        //Go Back to Web Site Page
        private void IbtnBack_Click(object sender, EventArgs e)
        {
            Web web = new Web();
            web.Show();
            this.Visible = false;
        }

        //Button Add Click Event
        //ADD Websites Details 
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
                string sql = "INSERT INTO WEBSITES(WEBSITE_ADDRESS,WEBSITE_LOGIN,WEBSITE_PASSWORD,COMMENT)" +
                "VALUES('" + Txt_WEBSITE_ADDRESS.Text + "','" + Txt_LOGIN.Text + "','" + Txt_PASSWORD.Text + "','" + Rtxt_Comment.Text + "')";

                //create Command class Object
                SqlCommand command = new SqlCommand(sql, Con);

                //Execute the Sql Steatement
                command.ExecuteNonQuery();

                //Output
                MessageBox.Show("Succesfully Add Web Sites Details");

                //Clear the textboxes
                Txt_WEBSITE_ADDRESS.Text = "";
                Txt_LOGIN.Text = "";
                Txt_PASSWORD.Text = "";
                Rtxt_Comment.Text = "";

                //Close the Connection
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Button Clear Click Event
        //Clear the Textboxes
        private void BtnClear_Click(object sender, EventArgs e)
        {
            try
            {
                Txt_WEBSITE_ADDRESS.Text = "";
                Txt_LOGIN.Text = "";
                Txt_PASSWORD.Text = "";
                Rtxt_Comment.Text = "";
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
                if (Rtxt_Comment.Text == "Add Your Comment Here")
                {
                    Rtxt_Comment.Text = "";
                    Rtxt_Comment.ForeColor = Color.Purple;
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
                if (Rtxt_Comment.Text == "")
                {
                    Rtxt_Comment.Text = "Add Your Comment Here";
                    Rtxt_Comment.ForeColor = Color.Silver;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
