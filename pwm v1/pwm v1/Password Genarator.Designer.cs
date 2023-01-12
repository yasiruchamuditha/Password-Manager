namespace pwm_v1
{
    partial class Password_Genarator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Password_Genarator));
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.CHECKBOX_PWG_12C = new System.Windows.Forms.CheckBox();
            this.CHECKBOX_PWG_10C = new System.Windows.Forms.CheckBox();
            this.CHECKBOX_PWG_8C = new System.Windows.Forms.CheckBox();
            this.Txt_Password_Window = new System.Windows.Forms.TextBox();
            this.IbtnBack = new FontAwesome.Sharp.IconButton();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.Txt_Length = new System.Windows.Forms.TextBox();
            this.lblDiscription = new System.Windows.Forms.Label();
            this.lblOr = new System.Windows.Forms.Label();
            this.BtnCopyPassword = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(0)))), ((int)(((byte)(89)))));
            this.BtnGenerate.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerate.ForeColor = System.Drawing.Color.White;
            this.BtnGenerate.Location = new System.Drawing.Point(152, 590);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(291, 71);
            this.BtnGenerate.TabIndex = 11;
            this.BtnGenerate.Text = "Genarate";
            this.BtnGenerate.UseVisualStyleBackColor = false;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // CHECKBOX_PWG_12C
            // 
            this.CHECKBOX_PWG_12C.AutoSize = true;
            this.CHECKBOX_PWG_12C.BackColor = System.Drawing.SystemColors.HotTrack;
            this.CHECKBOX_PWG_12C.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHECKBOX_PWG_12C.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CHECKBOX_PWG_12C.Location = new System.Drawing.Point(641, 104);
            this.CHECKBOX_PWG_12C.Name = "CHECKBOX_PWG_12C";
            this.CHECKBOX_PWG_12C.Size = new System.Drawing.Size(172, 40);
            this.CHECKBOX_PWG_12C.TabIndex = 9;
            this.CHECKBOX_PWG_12C.Text = " 12 Charactors";
            this.CHECKBOX_PWG_12C.UseVisualStyleBackColor = false;
            // 
            // CHECKBOX_PWG_10C
            // 
            this.CHECKBOX_PWG_10C.AutoSize = true;
            this.CHECKBOX_PWG_10C.BackColor = System.Drawing.SystemColors.HotTrack;
            this.CHECKBOX_PWG_10C.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHECKBOX_PWG_10C.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CHECKBOX_PWG_10C.Location = new System.Drawing.Point(393, 104);
            this.CHECKBOX_PWG_10C.Name = "CHECKBOX_PWG_10C";
            this.CHECKBOX_PWG_10C.Size = new System.Drawing.Size(165, 40);
            this.CHECKBOX_PWG_10C.TabIndex = 8;
            this.CHECKBOX_PWG_10C.Text = "10 Charactors";
            this.CHECKBOX_PWG_10C.UseVisualStyleBackColor = false;
            // 
            // CHECKBOX_PWG_8C
            // 
            this.CHECKBOX_PWG_8C.AutoSize = true;
            this.CHECKBOX_PWG_8C.BackColor = System.Drawing.SystemColors.HotTrack;
            this.CHECKBOX_PWG_8C.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHECKBOX_PWG_8C.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CHECKBOX_PWG_8C.Location = new System.Drawing.Point(161, 104);
            this.CHECKBOX_PWG_8C.Name = "CHECKBOX_PWG_8C";
            this.CHECKBOX_PWG_8C.Size = new System.Drawing.Size(160, 40);
            this.CHECKBOX_PWG_8C.TabIndex = 7;
            this.CHECKBOX_PWG_8C.Text = "8 Charactors";
            this.CHECKBOX_PWG_8C.UseVisualStyleBackColor = false;
            // 
            // Txt_Password_Window
            // 
            this.Txt_Password_Window.Font = new System.Drawing.Font("Agency FB", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Password_Window.Location = new System.Drawing.Point(152, 375);
            this.Txt_Password_Window.Multiline = true;
            this.Txt_Password_Window.Name = "Txt_Password_Window";
            this.Txt_Password_Window.Size = new System.Drawing.Size(886, 151);
            this.Txt_Password_Window.TabIndex = 6;
            // 
            // IbtnBack
            // 
            this.IbtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.IbtnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.IbtnBack.IconColor = System.Drawing.Color.White;
            this.IbtnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnBack.IconSize = 35;
            this.IbtnBack.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.IbtnBack.Location = new System.Drawing.Point(0, 0);
            this.IbtnBack.Name = "IbtnBack";
            this.IbtnBack.Size = new System.Drawing.Size(113, 60);
            this.IbtnBack.TabIndex = 12;
            this.IbtnBack.UseVisualStyleBackColor = false;
            this.IbtnBack.Click += new System.EventHandler(this.IbtnBack_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
            this.lblDisplay.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.ForeColor = System.Drawing.Color.White;
            this.lblDisplay.Location = new System.Drawing.Point(152, 23);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(547, 50);
            this.lblDisplay.TabIndex = 13;
            this.lblDisplay.Text = "Please Select Prefered Charactor Size";
            // 
            // Txt_Length
            // 
            this.Txt_Length.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Length.ForeColor = System.Drawing.Color.Silver;
            this.Txt_Length.Location = new System.Drawing.Point(573, 287);
            this.Txt_Length.Multiline = true;
            this.Txt_Length.Name = "Txt_Length";
            this.Txt_Length.Size = new System.Drawing.Size(111, 42);
            this.Txt_Length.TabIndex = 14;
            this.Txt_Length.Text = "Size";
            this.Txt_Length.Enter += new System.EventHandler(this.TxtLength_Enter);
            this.Txt_Length.Leave += new System.EventHandler(this.TxtLength_Leave);
            // 
            // lblDiscription
            // 
            this.lblDiscription.AutoSize = true;
            this.lblDiscription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(0)))), ((int)(((byte)(130)))));
            this.lblDiscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscription.ForeColor = System.Drawing.Color.White;
            this.lblDiscription.Location = new System.Drawing.Point(155, 287);
            this.lblDiscription.Name = "lblDiscription";
            this.lblDiscription.Size = new System.Drawing.Size(280, 32);
            this.lblDiscription.TabIndex = 15;
            this.lblDiscription.Text = "Enter Prefered Size";
            // 
            // lblOr
            // 
            this.lblOr.AutoSize = true;
            this.lblOr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
            this.lblOr.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOr.ForeColor = System.Drawing.Color.White;
            this.lblOr.Location = new System.Drawing.Point(418, 186);
            this.lblOr.Name = "lblOr";
            this.lblOr.Size = new System.Drawing.Size(88, 51);
            this.lblOr.TabIndex = 16;
            this.lblOr.Text = "OR";
            // 
            // BtnCopyPassword
            // 
            this.BtnCopyPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(0)))), ((int)(((byte)(89)))));
            this.BtnCopyPassword.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCopyPassword.ForeColor = System.Drawing.Color.White;
            this.BtnCopyPassword.Location = new System.Drawing.Point(550, 590);
            this.BtnCopyPassword.Name = "BtnCopyPassword";
            this.BtnCopyPassword.Size = new System.Drawing.Size(263, 71);
            this.BtnCopyPassword.TabIndex = 17;
            this.BtnCopyPassword.Text = "Copy Password";
            this.BtnCopyPassword.UseVisualStyleBackColor = false;
            this.BtnCopyPassword.Click += new System.EventHandler(this.BtnCopyPassword_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(0)))), ((int)(((byte)(89)))));
            this.BtnClear.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.ForeColor = System.Drawing.Color.White;
            this.BtnClear.Location = new System.Drawing.Point(882, 590);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(263, 71);
            this.BtnClear.TabIndex = 18;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.panelBottom.Controls.Add(this.IbtnBack);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 693);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1182, 60);
            this.panelBottom.TabIndex = 19;
            // 
            // Password_Genarator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnCopyPassword);
            this.Controls.Add(this.lblOr);
            this.Controls.Add(this.lblDiscription);
            this.Controls.Add(this.Txt_Length);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.BtnGenerate);
            this.Controls.Add(this.CHECKBOX_PWG_12C);
            this.Controls.Add(this.CHECKBOX_PWG_10C);
            this.Controls.Add(this.CHECKBOX_PWG_8C);
            this.Controls.Add(this.Txt_Password_Window);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Password_Genarator";
            this.Text = "Password Genarator";
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGenerate;
        private System.Windows.Forms.CheckBox CHECKBOX_PWG_12C;
        private System.Windows.Forms.CheckBox CHECKBOX_PWG_10C;
        private System.Windows.Forms.CheckBox CHECKBOX_PWG_8C;
        private System.Windows.Forms.TextBox Txt_Password_Window;
        private FontAwesome.Sharp.IconButton IbtnBack;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.TextBox Txt_Length;
        private System.Windows.Forms.Label lblDiscription;
        private System.Windows.Forms.Label lblOr;
        private System.Windows.Forms.Button BtnCopyPassword;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Panel panelBottom;
    }
}