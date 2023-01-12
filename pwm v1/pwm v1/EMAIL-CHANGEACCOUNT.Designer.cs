namespace pwm_v1
{
    partial class EMAIL_CHANGEACCOUNT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EMAIL_CHANGEACCOUNT));
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.TxtAccountName = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.BtnUPDATE = new System.Windows.Forms.Button();
            this.BtnDELETE = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.IbtnBack = new FontAwesome.Sharp.IconButton();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(89, 367);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(208, 50);
            this.lblPassword.TabIndex = 31;
            this.lblPassword.Text = "   PASSWORD";
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Font = new System.Drawing.Font("Agency FB", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountName.Location = new System.Drawing.Point(90, 240);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(210, 44);
            this.lblAccountName.TabIndex = 29;
            this.lblAccountName.Text = "ACCOUNT NAME";
            // 
            // TxtAccountName
            // 
            this.TxtAccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAccountName.Location = new System.Drawing.Point(386, 240);
            this.TxtAccountName.Multiline = true;
            this.TxtAccountName.Name = "TxtAccountName";
            this.TxtAccountName.Size = new System.Drawing.Size(707, 44);
            this.TxtAccountName.TabIndex = 32;
            this.TxtAccountName.Enter += new System.EventHandler(this.TxtAccountName_Enter);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Location = new System.Drawing.Point(387, 373);
            this.TxtPassword.Multiline = true;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(707, 44);
            this.TxtPassword.TabIndex = 34;
            // 
            // BtnUPDATE
            // 
            this.BtnUPDATE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(130)))), ((int)(((byte)(171)))));
            this.BtnUPDATE.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUPDATE.ForeColor = System.Drawing.Color.White;
            this.BtnUPDATE.Location = new System.Drawing.Point(205, 573);
            this.BtnUPDATE.Name = "BtnUPDATE";
            this.BtnUPDATE.Size = new System.Drawing.Size(245, 79);
            this.BtnUPDATE.TabIndex = 35;
            this.BtnUPDATE.Text = "UPDATE";
            this.BtnUPDATE.UseVisualStyleBackColor = false;
            this.BtnUPDATE.Click += new System.EventHandler(this.BtnUPDATE_Click);
            // 
            // BtnDELETE
            // 
            this.BtnDELETE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(130)))), ((int)(((byte)(171)))));
            this.BtnDELETE.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDELETE.ForeColor = System.Drawing.Color.White;
            this.BtnDELETE.Location = new System.Drawing.Point(531, 573);
            this.BtnDELETE.Name = "BtnDELETE";
            this.BtnDELETE.Size = new System.Drawing.Size(232, 79);
            this.BtnDELETE.TabIndex = 36;
            this.BtnDELETE.Text = "DELETE";
            this.BtnDELETE.UseVisualStyleBackColor = false;
            this.BtnDELETE.Click += new System.EventHandler(this.BtnDELETE_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(130)))), ((int)(((byte)(171)))));
            this.BtnClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.ForeColor = System.Drawing.Color.White;
            this.BtnClear.Location = new System.Drawing.Point(861, 573);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(232, 79);
            this.BtnClear.TabIndex = 37;
            this.BtnClear.Text = "CLEAR";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelBottom.Controls.Add(this.IbtnBack);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 695);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1182, 58);
            this.panelBottom.TabIndex = 38;
            // 
            // IbtnBack
            // 
            this.IbtnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.IbtnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.IbtnBack.IconColor = System.Drawing.Color.White;
            this.IbtnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnBack.IconSize = 35;
            this.IbtnBack.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.IbtnBack.Location = new System.Drawing.Point(0, 0);
            this.IbtnBack.Name = "IbtnBack";
            this.IbtnBack.Size = new System.Drawing.Size(114, 55);
            this.IbtnBack.TabIndex = 40;
            this.IbtnBack.UseVisualStyleBackColor = false;
            this.IbtnBack.Click += new System.EventHandler(this.IbtnBack_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Fuchsia;
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1182, 44);
            this.panelTop.TabIndex = 39;
            // 
            // EMAIL_CHANGEACCOUNT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.BtnDELETE);
            this.Controls.Add(this.BtnUPDATE);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtAccountName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblAccountName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EMAIL_CHANGEACCOUNT";
            this.Text = "Change E-Mail Account";
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.TextBox TxtAccountName;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Button BtnUPDATE;
        private System.Windows.Forms.Button BtnDELETE;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelTop;
        private FontAwesome.Sharp.IconButton IbtnBack;
    }
}