using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pwm_v1
{
    public partial class Password_Genarator : Form
    {
        public Password_Genarator()
        {
            InitializeComponent();
        }

        //Button Generate Click Event
        //Generate the Password
        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                //When prefered length is select from checkbox
                if (CHECKBOX_PWG_8C.Checked)
                {
                    PassGenarator(8);
                }
                else if (CHECKBOX_PWG_10C.Checked)
                {
                    PassGenarator(10);
                }
                else if (CHECKBOX_PWG_12C.Checked)
                {
                    PassGenarator(12);
                }
                else
                {
                    //When prefered length is typed to textbox
                    int length = Convert.ToInt32(Txt_Length.Text);
                    if (length <= 100)
                    {
                        PassGenarator(length);
                    }
                    else
                    {
                        //Set Maximum length warning to user
                        MessageBox.Show("Maximum Charactor Length is 100");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Password Generator method
        public void PassGenarator(int len)
            {
              const string ValidChar = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%&*";

              StringBuilder result = new StringBuilder();

              Random rand = new Random();

              while (0 < len--)
              {
                    result.Append(ValidChar[rand.Next(ValidChar.Length)]);
              }

                Txt_Password_Window.Text = result.ToString();     
            }

        //Copy generated Password to clipboard 
        private void BtnCopyPassword_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(Txt_Password_Window.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Clear button
        private void BtnClear_Click(object sender, EventArgs e)
        {
            try
            {
                CHECKBOX_PWG_8C.Checked = false;
                CHECKBOX_PWG_10C.Checked = false;
                CHECKBOX_PWG_12C.Checked = false;
                Txt_Length.Text = "";
                Txt_Password_Window.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

        private void TxtLength_Enter(object sender, EventArgs e)
        {
            try
            {
                if (Txt_Length.Text == "Size")
                {
                    Txt_Length.Text = "";
                    Txt_Length.ForeColor = Color.Purple;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void TxtLength_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Txt_Length.Text == "")
                {
                    Txt_Length.Text = "Size";
                    Txt_Length.ForeColor = Color.Silver;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        //Back to Home Page
        private void IbtnBack_Click(object sender, EventArgs e)
        {
            try
            {
                Home Home = new Home();
                Home.Show();
                this.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
