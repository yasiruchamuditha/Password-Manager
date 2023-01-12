namespace pwm_v1
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.LblSignUp = new System.Windows.Forms.Label();
            this.LblForgottonPassword = new System.Windows.Forms.Label();
            this.BtnSignIn = new System.Windows.Forms.Button();
            this.Txt_UserName = new System.Windows.Forms.TextBox();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.MbtnLogo = new MetroFramework.Controls.MetroButton();
            this.LblLogIn = new System.Windows.Forms.Label();
            this.PictureBoxPassword = new System.Windows.Forms.PictureBox();
            this.PictureBoxUserName = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxUserName)).BeginInit();
            this.SuspendLayout();
            // 
            // LblSignUp
            // 
            this.LblSignUp.AutoSize = true;
            this.LblSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(41)))), ((int)(((byte)(119)))));
            this.LblSignUp.Font = new System.Drawing.Font("Agency FB", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSignUp.ForeColor = System.Drawing.Color.White;
            this.LblSignUp.Location = new System.Drawing.Point(595, 609);
            this.LblSignUp.Name = "LblSignUp";
            this.LblSignUp.Size = new System.Drawing.Size(109, 44);
            this.LblSignUp.TabIndex = 1;
            this.LblSignUp.Text = "Sign Up";
            this.LblSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblSignUp.Click += new System.EventHandler(this.LblSignUp_Click);
            // 
            // LblForgottonPassword
            // 
            this.LblForgottonPassword.AutoSize = true;
            this.LblForgottonPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(41)))), ((int)(((byte)(116)))));
            this.LblForgottonPassword.Font = new System.Drawing.Font("Agency FB", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblForgottonPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblForgottonPassword.Location = new System.Drawing.Point(536, 554);
            this.LblForgottonPassword.Name = "LblForgottonPassword";
            this.LblForgottonPassword.Size = new System.Drawing.Size(280, 44);
            this.LblForgottonPassword.TabIndex = 2;
            this.LblForgottonPassword.Text = "Forgotten Password ?";
            this.LblForgottonPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblForgottonPassword.Click += new System.EventHandler(this.LblForgottonPassword_Click);
            // 
            // BtnSignIn
            // 
            this.BtnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(40)))), ((int)(((byte)(115)))));
            this.BtnSignIn.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSignIn.ForeColor = System.Drawing.Color.White;
            this.BtnSignIn.Location = new System.Drawing.Point(266, 463);
            this.BtnSignIn.Name = "BtnSignIn";
            this.BtnSignIn.Size = new System.Drawing.Size(792, 67);
            this.BtnSignIn.TabIndex = 3;
            this.BtnSignIn.Text = "Sign In";
            this.BtnSignIn.UseVisualStyleBackColor = false;
            this.BtnSignIn.Click += new System.EventHandler(this.BtnSignIn_Click);
            // 
            // Txt_UserName
            // 
            this.Txt_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_UserName.ForeColor = System.Drawing.Color.Thistle;
            this.Txt_UserName.Location = new System.Drawing.Point(279, 290);
            this.Txt_UserName.Multiline = true;
            this.Txt_UserName.Name = "Txt_UserName";
            this.Txt_UserName.Size = new System.Drawing.Size(779, 51);
            this.Txt_UserName.TabIndex = 6;
            this.Txt_UserName.Text = "User Name";
            this.Txt_UserName.Enter += new System.EventHandler(this.Txt_UserName_Enter);
            this.Txt_UserName.Leave += new System.EventHandler(this.Txt_UserName_Leave);
            // 
            // Txt_Password
            // 
            this.Txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Password.ForeColor = System.Drawing.Color.Thistle;
            this.Txt_Password.Location = new System.Drawing.Point(279, 373);
            this.Txt_Password.Multiline = true;
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.Size = new System.Drawing.Size(779, 51);
            this.Txt_Password.TabIndex = 7;
            this.Txt_Password.Text = "Password";
            this.Txt_Password.Enter += new System.EventHandler(this.Txt_Password_Enter);
            this.Txt_Password.Leave += new System.EventHandler(this.Txt_Password_Leave);
            // 
            // MbtnLogo
            // 
            this.MbtnLogo.BackColor = System.Drawing.Color.Indigo;
            this.MbtnLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MbtnLogo.BackgroundImage")));
            this.MbtnLogo.Location = new System.Drawing.Point(544, 12);
            this.MbtnLogo.Name = "MbtnLogo";
            this.MbtnLogo.Size = new System.Drawing.Size(202, 191);
            this.MbtnLogo.TabIndex = 9;
            this.MbtnLogo.UseCustomBackColor = true;
            this.MbtnLogo.UseCustomForeColor = true;
            this.MbtnLogo.UseSelectable = true;
            // 
            // LblLogIn
            // 
            this.LblLogIn.AutoSize = true;
            this.LblLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(38)))), ((int)(((byte)(112)))));
            this.LblLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLogIn.ForeColor = System.Drawing.Color.White;
            this.LblLogIn.Location = new System.Drawing.Point(565, 219);
            this.LblLogIn.Name = "LblLogIn";
            this.LblLogIn.Size = new System.Drawing.Size(160, 46);
            this.LblLogIn.TabIndex = 14;
            this.LblLogIn.Text = "LOG IN";
            // 
            // PictureBoxPassword
            // 
            this.PictureBoxPassword.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxPassword.Image")));
            this.PictureBoxPassword.Location = new System.Drawing.Point(192, 373);
            this.PictureBoxPassword.Name = "PictureBoxPassword";
            this.PictureBoxPassword.Size = new System.Drawing.Size(57, 52);
            this.PictureBoxPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBoxPassword.TabIndex = 16;
            this.PictureBoxPassword.TabStop = false;
            // 
            // PictureBoxUserName
            // 
            this.PictureBoxUserName.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxUserName.Image")));
            this.PictureBoxUserName.Location = new System.Drawing.Point(192, 290);
            this.PictureBoxUserName.Name = "PictureBoxUserName";
            this.PictureBoxUserName.Size = new System.Drawing.Size(57, 52);
            this.PictureBoxUserName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBoxUserName.TabIndex = 15;
            this.PictureBoxUserName.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.PictureBoxPassword);
            this.Controls.Add(this.PictureBoxUserName);
            this.Controls.Add(this.LblLogIn);
            this.Controls.Add(this.MbtnLogo);
            this.Controls.Add(this.Txt_Password);
            this.Controls.Add(this.Txt_UserName);
            this.Controls.Add(this.BtnSignIn);
            this.Controls.Add(this.LblForgottonPassword);
            this.Controls.Add(this.LblSignUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Login";
            this.Text = "LOGIN";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxUserName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblSignUp;
        private System.Windows.Forms.Label LblForgottonPassword;
        private System.Windows.Forms.Button BtnSignIn;
        private System.Windows.Forms.TextBox Txt_UserName;
        private System.Windows.Forms.TextBox Txt_Password;
        private MetroFramework.Controls.MetroButton MbtnLogo;
        private System.Windows.Forms.Label LblLogIn;
        private System.Windows.Forms.PictureBox PictureBoxPassword;
        private System.Windows.Forms.PictureBox PictureBoxUserName;
    }
}

