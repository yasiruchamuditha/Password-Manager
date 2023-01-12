namespace pwm_v1
{
    partial class EMAIL_ADDACCOUNT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EMAIL_ADDACCOUNT));
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.TxtAccountName = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.IbtnBack = new FontAwesome.Sharp.IconButton();
            this.BtnClear = new System.Windows.Forms.Button();
            this.RtxtComment = new System.Windows.Forms.RichTextBox();
            this.panelComment = new System.Windows.Forms.Panel();
            this.lblComment = new System.Windows.Forms.Label();
            this.panelComment.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(78, 186);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(184, 50);
            this.lblPassword.TabIndex = 34;
            this.lblPassword.Text = "PASSWORD";
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Font = new System.Drawing.Font("Agency FB", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountName.Location = new System.Drawing.Point(52, 84);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(210, 44);
            this.lblAccountName.TabIndex = 32;
            this.lblAccountName.Text = "ACCOUNT NAME";
            // 
            // TxtAccountName
            // 
            this.TxtAccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAccountName.Location = new System.Drawing.Point(352, 84);
            this.TxtAccountName.Multiline = true;
            this.TxtAccountName.Name = "TxtAccountName";
            this.TxtAccountName.Size = new System.Drawing.Size(645, 51);
            this.TxtAccountName.TabIndex = 35;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Location = new System.Drawing.Point(352, 186);
            this.TxtPassword.Multiline = true;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(645, 51);
            this.TxtPassword.TabIndex = 37;
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(368, 552);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(187, 88);
            this.BtnAdd.TabIndex = 38;
            this.BtnAdd.Text = "ADD";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.MediumVioletRed;
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1182, 37);
            this.panelTop.TabIndex = 39;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 693);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1182, 60);
            this.panelBottom.TabIndex = 40;
            // 
            // IbtnBack
            // 
            this.IbtnBack.BackColor = System.Drawing.Color.DarkSlateGray;
            this.IbtnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.IbtnBack.IconColor = System.Drawing.Color.White;
            this.IbtnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnBack.IconSize = 35;
            this.IbtnBack.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.IbtnBack.Location = new System.Drawing.Point(0, 693);
            this.IbtnBack.Name = "IbtnBack";
            this.IbtnBack.Size = new System.Drawing.Size(121, 60);
            this.IbtnBack.TabIndex = 41;
            this.IbtnBack.UseVisualStyleBackColor = false;
            this.IbtnBack.Click += new System.EventHandler(this.IbtnBack_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Location = new System.Drawing.Point(718, 552);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(196, 88);
            this.BtnClear.TabIndex = 42;
            this.BtnClear.Text = "CLEAR";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // RtxtComment
            // 
            this.RtxtComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtxtComment.ForeColor = System.Drawing.Color.Silver;
            this.RtxtComment.Location = new System.Drawing.Point(29, 37);
            this.RtxtComment.Name = "RtxtComment";
            this.RtxtComment.Size = new System.Drawing.Size(730, 131);
            this.RtxtComment.TabIndex = 43;
            this.RtxtComment.Text = "Add Your Comment Here";
            this.RtxtComment.Enter += new System.EventHandler(this.RtxtComment_Enter);
            this.RtxtComment.Leave += new System.EventHandler(this.RtxtComment_Leave);
            // 
            // panelComment
            // 
            this.panelComment.BackColor = System.Drawing.Color.RosyBrown;
            this.panelComment.Controls.Add(this.lblComment);
            this.panelComment.Controls.Add(this.RtxtComment);
            this.panelComment.Location = new System.Drawing.Point(220, 323);
            this.panelComment.Name = "panelComment";
            this.panelComment.Size = new System.Drawing.Size(777, 182);
            this.panelComment.TabIndex = 44;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComment.Location = new System.Drawing.Point(16, 5);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(117, 29);
            this.lblComment.TabIndex = 44;
            this.lblComment.Text = "Comment";
            // 
            // EMAIL_ADDACCOUNT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.panelComment);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.IbtnBack);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtAccountName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblAccountName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EMAIL_ADDACCOUNT";
            this.Text = "Add E-Mail Account";
            this.panelComment.ResumeLayout(false);
            this.panelComment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.TextBox TxtAccountName;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private FontAwesome.Sharp.IconButton IbtnBack;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.RichTextBox RtxtComment;
        private System.Windows.Forms.Panel panelComment;
        private System.Windows.Forms.Label lblComment;
    }
}