namespace pwm_v1
{
    partial class WEB_ADDACCOUNT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WEB_ADDACCOUNT));
            this.panelComment = new System.Windows.Forms.Panel();
            this.lblComment = new System.Windows.Forms.Label();
            this.Rtxt_Comment = new System.Windows.Forms.RichTextBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.Txt_LOGIN = new System.Windows.Forms.TextBox();
            this.Txt_WEBSITE_ADDRESS = new System.Windows.Forms.TextBox();
            this.lbl_LOGIN = new System.Windows.Forms.Label();
            this.lblWEBSITE_ADDRESS = new System.Windows.Forms.Label();
            this.Txt_PASSWORD = new System.Windows.Forms.TextBox();
            this.lblPASSWORD = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.IbtnBack = new FontAwesome.Sharp.IconButton();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelComment.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelComment
            // 
            this.panelComment.BackColor = System.Drawing.Color.RosyBrown;
            this.panelComment.Controls.Add(this.lblComment);
            this.panelComment.Controls.Add(this.Rtxt_Comment);
            this.panelComment.Location = new System.Drawing.Point(300, 348);
            this.panelComment.Name = "panelComment";
            this.panelComment.Size = new System.Drawing.Size(777, 182);
            this.panelComment.TabIndex = 51;
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
            // Rtxt_Comment
            // 
            this.Rtxt_Comment.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rtxt_Comment.ForeColor = System.Drawing.Color.Silver;
            this.Rtxt_Comment.Location = new System.Drawing.Point(32, 37);
            this.Rtxt_Comment.Name = "Rtxt_Comment";
            this.Rtxt_Comment.Size = new System.Drawing.Size(730, 131);
            this.Rtxt_Comment.TabIndex = 43;
            this.Rtxt_Comment.Text = "Add Your Comment Here";
            this.Rtxt_Comment.Enter += new System.EventHandler(this.RtxtComment_Enter);
            this.Rtxt_Comment.Leave += new System.EventHandler(this.RtxtComment_Leave);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(136)))), ((int)(((byte)(174)))));
            this.BtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.ForeColor = System.Drawing.Color.White;
            this.BtnClear.Location = new System.Drawing.Point(774, 578);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(196, 88);
            this.BtnClear.TabIndex = 50;
            this.BtnClear.Text = "CLEAR";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(136)))), ((int)(((byte)(174)))));
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(320, 578);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(187, 88);
            this.BtnAdd.TabIndex = 49;
            this.BtnAdd.Text = "ADD";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // Txt_LOGIN
            // 
            this.Txt_LOGIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_LOGIN.Location = new System.Drawing.Point(419, 170);
            this.Txt_LOGIN.Multiline = true;
            this.Txt_LOGIN.Name = "Txt_LOGIN";
            this.Txt_LOGIN.Size = new System.Drawing.Size(645, 51);
            this.Txt_LOGIN.TabIndex = 48;
            // 
            // Txt_WEBSITE_ADDRESS
            // 
            this.Txt_WEBSITE_ADDRESS.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_WEBSITE_ADDRESS.Location = new System.Drawing.Point(419, 68);
            this.Txt_WEBSITE_ADDRESS.Multiline = true;
            this.Txt_WEBSITE_ADDRESS.Name = "Txt_WEBSITE_ADDRESS";
            this.Txt_WEBSITE_ADDRESS.Size = new System.Drawing.Size(645, 51);
            this.Txt_WEBSITE_ADDRESS.TabIndex = 47;
            // 
            // lbl_LOGIN
            // 
            this.lbl_LOGIN.AutoSize = true;
            this.lbl_LOGIN.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LOGIN.Location = new System.Drawing.Point(59, 170);
            this.lbl_LOGIN.Name = "lbl_LOGIN";
            this.lbl_LOGIN.Size = new System.Drawing.Size(112, 50);
            this.lbl_LOGIN.TabIndex = 46;
            this.lbl_LOGIN.Text = "LOG IN";
            // 
            // lblWEBSITE_ADDRESS
            // 
            this.lblWEBSITE_ADDRESS.AutoSize = true;
            this.lblWEBSITE_ADDRESS.Font = new System.Drawing.Font("Agency FB", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWEBSITE_ADDRESS.Location = new System.Drawing.Point(60, 75);
            this.lblWEBSITE_ADDRESS.Name = "lblWEBSITE_ADDRESS";
            this.lblWEBSITE_ADDRESS.Size = new System.Drawing.Size(248, 44);
            this.lblWEBSITE_ADDRESS.TabIndex = 45;
            this.lblWEBSITE_ADDRESS.Text = "WEBSITE ADDRESS";
            // 
            // Txt_PASSWORD
            // 
            this.Txt_PASSWORD.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_PASSWORD.Location = new System.Drawing.Point(419, 254);
            this.Txt_PASSWORD.Multiline = true;
            this.Txt_PASSWORD.Name = "Txt_PASSWORD";
            this.Txt_PASSWORD.Size = new System.Drawing.Size(645, 51);
            this.Txt_PASSWORD.TabIndex = 53;
            // 
            // lblPASSWORD
            // 
            this.lblPASSWORD.AutoSize = true;
            this.lblPASSWORD.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPASSWORD.Location = new System.Drawing.Point(73, 255);
            this.lblPASSWORD.Name = "lblPASSWORD";
            this.lblPASSWORD.Size = new System.Drawing.Size(184, 50);
            this.lblPASSWORD.TabIndex = 52;
            this.lblPASSWORD.Text = "PASSWORD";
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelBottom.Controls.Add(this.IbtnBack);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 693);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1182, 60);
            this.panelBottom.TabIndex = 54;
            // 
            // IbtnBack
            // 
            this.IbtnBack.BackColor = System.Drawing.Color.DarkSlateGray;
            this.IbtnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.IbtnBack.IconColor = System.Drawing.Color.White;
            this.IbtnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbtnBack.IconSize = 35;
            this.IbtnBack.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.IbtnBack.Location = new System.Drawing.Point(0, 0);
            this.IbtnBack.Name = "IbtnBack";
            this.IbtnBack.Size = new System.Drawing.Size(121, 60);
            this.IbtnBack.TabIndex = 42;
            this.IbtnBack.UseVisualStyleBackColor = false;
            this.IbtnBack.Click += new System.EventHandler(this.IbtnBack_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.MediumVioletRed;
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1182, 37);
            this.panelTop.TabIndex = 55;
            // 
            // WEB_ADDACCOUNT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.Txt_PASSWORD);
            this.Controls.Add(this.lblPASSWORD);
            this.Controls.Add(this.panelComment);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.Txt_LOGIN);
            this.Controls.Add(this.Txt_WEBSITE_ADDRESS);
            this.Controls.Add(this.lbl_LOGIN);
            this.Controls.Add(this.lblWEBSITE_ADDRESS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "WEB_ADDACCOUNT";
            this.Text = "Add Website";
            this.panelComment.ResumeLayout(false);
            this.panelComment.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelComment;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.RichTextBox Rtxt_Comment;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox Txt_LOGIN;
        private System.Windows.Forms.TextBox Txt_WEBSITE_ADDRESS;
        private System.Windows.Forms.Label lbl_LOGIN;
        private System.Windows.Forms.Label lblWEBSITE_ADDRESS;
        private System.Windows.Forms.TextBox Txt_PASSWORD;
        private System.Windows.Forms.Label lblPASSWORD;
        private System.Windows.Forms.Panel panelBottom;
        private FontAwesome.Sharp.IconButton IbtnBack;
        private System.Windows.Forms.Panel panelTop;
    }
}