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
    public partial class BANKCARD_ADDCARD : Form
    {
        public BANKCARD_ADDCARD()
        {
            InitializeComponent();
        }

        //Button Add Click Event
        //Go to Add BankCard Page
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
                string sql = "INSERT INTO BANKCARDS(CARD_NUMBER,CARD_HOLDER,EXPIRE_DATE,CVV,PIN_NUMBER,CARD_ISSUER,COMMENT)" +
                "VALUES('"+ Txt_CARD_NUMBER.Text +"','"+ Txt_CARD_HOLDER.Text +"','"+ Txt_EXPIRE_DATE.Text +"','"+ Txt_CVV.Text +"','"+ Txt_PIN_NUMBER.Text +"','"+Txt_CARD_ISSUER.Text +"','"+ Txt_Comment.Text +"')";
                
                //create Command class Object
                SqlCommand command = new SqlCommand(sql, Con);

                //Execute the Sql Steatement
                command.ExecuteNonQuery();

                //Output
                MessageBox.Show("Succesfully Added Your BankCard Details");

                //Clear the Buttons
                Txt_CARD_NUMBER.Text = "";
                Txt_CARD_HOLDER.Text = "";
                Txt_EXPIRE_DATE.Text = "";
                Txt_CVV.Text = "";
                Txt_PIN_NUMBER.Text = "";
                Txt_CARD_ISSUER.Text = "";
                Txt_Comment.Text = "";

                //Close the Connection
                Con.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Clear Button Click Event
        private void BtnClear_Click(object sender, EventArgs e)
        {
            try
            {
                Txt_CARD_NUMBER.Text = "";
                Txt_CARD_HOLDER.Text = "";
                Txt_EXPIRE_DATE.Text = "";
                Txt_CVV.Text = "";
                Txt_PIN_NUMBER.Text = "";
                Txt_CARD_ISSUER.Text = "";
                Txt_Comment.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Back to BankCard Page
        private void IbtnBack_Click(object sender, EventArgs e)
        {
            try
            {
                BankCards Bankcards = new BankCards();
                Bankcards.Show();
                this.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }    
        }

        //Button Update Click Event
        //Update the BANK CARDS Details
        private void BtnUpdate_Click(object sender, EventArgs e)
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
                string sql = "UPDATE BANKCARDS SET CARD_HOLDER='"+Txt_CARD_HOLDER.Text+"',EXPIRE_DATE='"+ Txt_EXPIRE_DATE.Text + "',CVV='"+Txt_CVV.Text+"',PIN_NUMBER='"+Txt_PIN_NUMBER.Text+"',CARD_ISSUER='"+Txt_CARD_ISSUER.Text+"',COMMENT='"+Txt_Comment.Text+"' " +
                    "WHERE CARD_NUMBER ='" + Txt_CARD_NUMBER.Text + "' ";

                //create Command class Object
                SqlCommand command = new SqlCommand(sql, Con);

                //Execute the Sql Steatement
                command.ExecuteNonQuery();

                //Output
                MessageBox.Show("Succesfully Updated Your BankCard Details");

                //Clear the Buttons
                Txt_CARD_NUMBER.Text = "";
                Txt_CARD_HOLDER.Text = "";
                Txt_EXPIRE_DATE.Text = "";
                Txt_CVV.Text = "";
                Txt_PIN_NUMBER.Text = "";
                Txt_CARD_ISSUER.Text = "";
                Txt_Comment.Text = "";

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
