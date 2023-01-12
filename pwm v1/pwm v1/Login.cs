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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //static string username;
        //public void Display()
        //{
        //    username = txt_UserName.Text;
        //}

        //Sign In Button Click Event
        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                //Login login = new Login();
                //login.Display();

                //connection string
                string connectionString = @"Data Source=DESKTOP-5JC6HTG\SQLEXPRESS; Initial Catalog=THIRDEYE_PASSWORD_MANAGER; user id=yasiru; password=123456789";
                //create sql connection class object
                SqlConnection Con = new SqlConnection(connectionString);
                //Open the connection
                Con.Open();

                //Sql statement
                string sql = "SELECT * FROM REGISTRATIONS WHERE USER_USERNAME='"+ Txt_UserName.Text + "' AND USER_PASSWORD ='"+Txt_Password.Text+"' ";
                //create command class
                SqlCommand command = new SqlCommand(sql,Con);
                //create SqlDataReader  Connection
                SqlDataReader DataReader = command.ExecuteReader();

                if (DataReader.Read() == true)
                {
                    new Home().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid User Name or Password");
                    Txt_UserName.Text = "";
                    Txt_Password.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Forgotton Password Click Event
        //Go to Forgotton Password Page
        private void LblForgottonPassword_Click(object sender, EventArgs e)
        {
            try
            {
                Forgotten_Password forgotten_Password = new Forgotten_Password();
                forgotten_Password.Show();
                this.Visible = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //SignUp lable Click Event
        //Go to SignUp page
        private void LblSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                Registration R1 = new Registration();
                R1.Show();
                this.Visible = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        //Textbox Username Enter Event
        private void Txt_UserName_Enter(object sender, EventArgs e)
        {
            try
            {
                if (Txt_UserName.Text == "User Name")
                {
                    Txt_UserName.Text = "";
                    Txt_UserName.ForeColor = Color.Purple;
                }
            }
            catch(Exception ex)
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
                    Txt_UserName.Text = "User Name";
                    Txt_UserName.ForeColor = Color.Silver;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Textbox Password Enter Event
        private void Txt_Password_Enter(object sender, EventArgs e)
        {
            try
            {
                if (Txt_Password.Text == "Password")
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
                    Txt_Password.Text = "Password";
                    Txt_Password.ForeColor = Color.Silver;
                }
            }
            catch( Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }
    }
}
