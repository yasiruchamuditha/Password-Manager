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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        //New registration account
        private void BtnRegister_Click(object sender, EventArgs e)
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
                string sql = "INSERT INTO REGISTRATIONS(USER_USERNAME,USER_EMAIL,USER_PASSWORD,USER_CONFIRMPASSWORD)" + "VALUES('" + Txt_UserName.Text + "','" + Txt_UserEmail.Text + "','" + Txt_Password.Text + "','" + Txt_Confirm_Password.Text + "')";
                
                //create Command class Object
                SqlCommand command = new SqlCommand(sql, Con);
                
                //Execute the Sql Steatement
                command.ExecuteNonQuery();

                //Output
                MessageBox.Show("Your are Succesfully Registred in the Application" +
                    "Please Sign In");
                
                //Close the Connection
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Back to login page
        private void BtnBack_Click(object sender, EventArgs e)
        {
            try
            {
                Login L1 = new Login();
                L1.Show();
                this.Visible = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        //Clear button click Event
        private void BtnClear_Click(object sender, EventArgs e)
        {
            try
            {
                Txt_UserName.Text = "";
                Txt_UserEmail.Text = "";
                Txt_Password.Text = "";
                Txt_Confirm_Password.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }

        //Textbox Username Enter Event
        private void Txt_UserName_Enter(object sender, EventArgs e)
        {
            try
            {
                if (Txt_UserName.Text == "Ex:User Name")
                {
                    Txt_UserName.Text = "";
                    Txt_UserName.ForeColor = Color.Purple;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }

        //Textbox Username Leave Event
        private void Txt_UserName_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Txt_UserName.Text == "")
                {
                    Txt_UserName.Text = "Ex:User Name";
                    Txt_UserName.ForeColor = Color.Silver;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        //Textbox UserEmail Enter Event
        private void Txt_UserEmail_Enter(object sender, EventArgs e)
        {
            try
            {
                if (Txt_UserEmail.Text == "Ex:Someone@Company.Com")
                {
                    Txt_UserEmail.Text = "";
                    Txt_UserEmail.ForeColor = Color.Purple;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        //Textbox UserEmail Leave Event
        private void Txt_UserEmail_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Txt_UserEmail.Text == "")
                {
                    Txt_UserEmail.Text = "Ex:Someone@Company.Com";
                    Txt_UserEmail.ForeColor = Color.Silver;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }

        //Textbox Password Enter Event
        private void Txt_Password_Enter(object sender, EventArgs e)
        {
            try
            {
                if (Txt_Password.Text == "Ex:**********Password")
                {
                    Txt_Password.Text = "";
                    Txt_Password.ForeColor = Color.Purple;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Textbox Password Leave Event
        private void Txt_Password_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Txt_Password.Text == "")
                {
                    Txt_Password.Text = "Ex:**********Password";
                    Txt_Password.ForeColor = Color.Silver;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        //Textbox Confirm_Password Enter Event
        private void Txt_Confirm_Password_Enter(object sender, EventArgs e)
        {
            try
            {
                if (Txt_Confirm_Password.Text == "Ex:**********Confirm Password")
                {
                    Txt_Confirm_Password.Text = "";
                    Txt_Confirm_Password.ForeColor = Color.Purple;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }
        //Textbox Confirm_Password Leave Event
        private void Txt_Confirm_Password_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Txt_Confirm_Password.Text == "")
                {
                    Txt_Confirm_Password.Text = "Ex:**********Confirm Password";
                    Txt_Confirm_Password.ForeColor = Color.Silver;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
