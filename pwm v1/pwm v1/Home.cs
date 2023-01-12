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
    public partial class Home : Form
    {
        //variable for timer (sidebar)
        bool sidebarexpand;

        public Home()
        {
            InitializeComponent();
        }

        //IconButton sidebar click
        private void IbtnSidebar_Click(object sender, EventArgs e)
        {
            try
            {
                //set timer interval to lowest to make it fast
                timerSidebar.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //Sidebar Timer Event
        private void TimerSidebar_Tick(object sender, EventArgs e)
        {
            try 
            {
                //set minimum and maximum size of side bar panel
                if (sidebarexpand)
                {
                    //if sidebar expand,to minimize
                    panelsidebar.Width -= 100;
                    if (panelsidebar.Width == panelsidebar.MinimumSize.Width)
                    {
                        sidebarexpand = false;
                        timerSidebar.Stop();
                    }
                }
                else
                {
                    //if sidebar is close,to maximize
                    panelsidebar.Width += 100;
                    if (panelsidebar.Width == panelsidebar.MaximumSize.Width)
                    {
                        sidebarexpand = true;
                        timerSidebar.Stop();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }     
        }
    
         //Go to email page
        private void MbtnEmail_Click(object sender, EventArgs e)
        {
            try
            {
                Email Email = new Email();
                Email.Show();
                this.Visible = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Go to application page
        private void MbtnApplication_Click(object sender, EventArgs e)
        {
            try
            {
                Applications applications = new Applications();
                applications.Show();
                this.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Go to Bank Cards page
        private void MbtnBankCards_Click(object sender, EventArgs e)
        {
            try
            {
                BankCards bankCards = new BankCards();
                bankCards.Show();
                this.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Go to websites page
        private void MbtnWebsite_Click(object sender, EventArgs e)
        {
            try
            {
                Web web = new Web();
                web.Show();
                this.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       
        //Home page load through Sidebar Button
        private void IbtnHome_Click(object sender, EventArgs e)
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

        //Password Generator page load through Sidebar Button 
        private void IbtnPasswordGenerator_Click(object sender, EventArgs e)
        {
            try
            {
                Password_Genarator password_Genarator = new Password_Genarator();
                password_Genarator.Show();
                this.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Setting page load through Sidebar Button 
        private void IbtnSettings_Click(object sender, EventArgs e)
        {
            try
            {
                Setting setting = new Setting();
                setting.Show();
                this.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Tips page load through Sidebar Button
        private void IbtnTips_Click(object sender, EventArgs e)
        {
            try
            {
                Tips tips = new Tips();
                tips.Show();
                this.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }

        //About page load through Sidebar Button 
        private void IbtnAbout_Click(object sender, EventArgs e)
        {
            try
            {
                About about = new About();
                about.Show();
                this.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }
    }
    }

