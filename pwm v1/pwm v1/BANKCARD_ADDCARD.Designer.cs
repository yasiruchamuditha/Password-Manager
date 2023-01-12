namespace pwm_v1
{
    partial class BANKCARD_ADDCARD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BANKCARD_ADDCARD));
            this.lbl_CARD_NUMBER = new System.Windows.Forms.Label();
            this.lbl_CARD_HOLDER = new System.Windows.Forms.Label();
            this.lbl_PIN_NUMBER = new System.Windows.Forms.Label();
            this.lbl_EXPIRE_DATE = new System.Windows.Forms.Label();
            this.lbl_CVV = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.IbtnBack = new FontAwesome.Sharp.IconButton();
            this.BtnClear = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lbl_Comment = new System.Windows.Forms.Label();
            this.Txt_CARD_NUMBER = new System.Windows.Forms.TextBox();
            this.Txt_CARD_HOLDER = new System.Windows.Forms.TextBox();
            this.Txt_EXPIRE_DATE = new System.Windows.Forms.TextBox();
            this.Txt_CVV = new System.Windows.Forms.TextBox();
            this.Txt_PIN_NUMBER = new System.Windows.Forms.TextBox();
            this.Txt_Comment = new System.Windows.Forms.TextBox();
            this.Txt_CARD_ISSUER = new System.Windows.Forms.TextBox();
            this.lbl_CARD_ISSUER = new System.Windows.Forms.Label();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_CARD_NUMBER
            // 
            this.lbl_CARD_NUMBER.AutoSize = true;
            this.lbl_CARD_NUMBER.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CARD_NUMBER.Location = new System.Drawing.Point(208, 99);
            this.lbl_CARD_NUMBER.Name = "lbl_CARD_NUMBER";
            this.lbl_CARD_NUMBER.Size = new System.Drawing.Size(148, 36);
            this.lbl_CARD_NUMBER.TabIndex = 40;
            this.lbl_CARD_NUMBER.Text = "CARD NUMBER";
            // 
            // lbl_CARD_HOLDER
            // 
            this.lbl_CARD_HOLDER.AutoSize = true;
            this.lbl_CARD_HOLDER.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CARD_HOLDER.Location = new System.Drawing.Point(208, 165);
            this.lbl_CARD_HOLDER.Name = "lbl_CARD_HOLDER";
            this.lbl_CARD_HOLDER.Size = new System.Drawing.Size(142, 36);
            this.lbl_CARD_HOLDER.TabIndex = 41;
            this.lbl_CARD_HOLDER.Text = "CARD HOLDER";
            // 
            // lbl_PIN_NUMBER
            // 
            this.lbl_PIN_NUMBER.AutoSize = true;
            this.lbl_PIN_NUMBER.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PIN_NUMBER.Location = new System.Drawing.Point(208, 375);
            this.lbl_PIN_NUMBER.Name = "lbl_PIN_NUMBER";
            this.lbl_PIN_NUMBER.Size = new System.Drawing.Size(129, 36);
            this.lbl_PIN_NUMBER.TabIndex = 42;
            this.lbl_PIN_NUMBER.Text = "PIN NUMBER";
            // 
            // lbl_EXPIRE_DATE
            // 
            this.lbl_EXPIRE_DATE.AutoSize = true;
            this.lbl_EXPIRE_DATE.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EXPIRE_DATE.Location = new System.Drawing.Point(208, 239);
            this.lbl_EXPIRE_DATE.Name = "lbl_EXPIRE_DATE";
            this.lbl_EXPIRE_DATE.Size = new System.Drawing.Size(110, 36);
            this.lbl_EXPIRE_DATE.TabIndex = 43;
            this.lbl_EXPIRE_DATE.Text = "MM/YYYY";
            // 
            // lbl_CVV
            // 
            this.lbl_CVV.AutoSize = true;
            this.lbl_CVV.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CVV.Location = new System.Drawing.Point(208, 303);
            this.lbl_CVV.Name = "lbl_CVV";
            this.lbl_CVV.Size = new System.Drawing.Size(50, 36);
            this.lbl_CVV.TabIndex = 44;
            this.lbl_CVV.Text = "CVV";
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(144)))), ((int)(((byte)(177)))));
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(156, 590);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(248, 70);
            this.BtnAdd.TabIndex = 45;
            this.BtnAdd.Text = "ADD";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelBottom.Controls.Add(this.IbtnBack);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 695);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1182, 58);
            this.panelBottom.TabIndex = 46;
            // 
            // IbtnBack
            // 
            this.IbtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
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
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(144)))), ((int)(((byte)(177)))));
            this.BtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.ForeColor = System.Drawing.Color.White;
            this.BtnClear.Location = new System.Drawing.Point(831, 590);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(233, 70);
            this.BtnClear.TabIndex = 47;
            this.BtnClear.Text = "CLEAR";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1182, 52);
            this.panelTop.TabIndex = 48;
            // 
            // lbl_Comment
            // 
            this.lbl_Comment.AutoSize = true;
            this.lbl_Comment.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Comment.Location = new System.Drawing.Point(208, 512);
            this.lbl_Comment.Name = "lbl_Comment";
            this.lbl_Comment.Size = new System.Drawing.Size(105, 36);
            this.lbl_Comment.TabIndex = 49;
            this.lbl_Comment.Text = "COMMENT";
            // 
            // Txt_CARD_NUMBER
            // 
            this.Txt_CARD_NUMBER.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CARD_NUMBER.Location = new System.Drawing.Point(418, 98);
            this.Txt_CARD_NUMBER.Multiline = true;
            this.Txt_CARD_NUMBER.Name = "Txt_CARD_NUMBER";
            this.Txt_CARD_NUMBER.Size = new System.Drawing.Size(590, 37);
            this.Txt_CARD_NUMBER.TabIndex = 50;
            // 
            // Txt_CARD_HOLDER
            // 
            this.Txt_CARD_HOLDER.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CARD_HOLDER.Location = new System.Drawing.Point(418, 165);
            this.Txt_CARD_HOLDER.Multiline = true;
            this.Txt_CARD_HOLDER.Name = "Txt_CARD_HOLDER";
            this.Txt_CARD_HOLDER.Size = new System.Drawing.Size(590, 37);
            this.Txt_CARD_HOLDER.TabIndex = 51;
            // 
            // Txt_EXPIRE_DATE
            // 
            this.Txt_EXPIRE_DATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_EXPIRE_DATE.Location = new System.Drawing.Point(418, 239);
            this.Txt_EXPIRE_DATE.Multiline = true;
            this.Txt_EXPIRE_DATE.Name = "Txt_EXPIRE_DATE";
            this.Txt_EXPIRE_DATE.Size = new System.Drawing.Size(590, 37);
            this.Txt_EXPIRE_DATE.TabIndex = 52;
            // 
            // Txt_CVV
            // 
            this.Txt_CVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CVV.Location = new System.Drawing.Point(418, 302);
            this.Txt_CVV.Multiline = true;
            this.Txt_CVV.Name = "Txt_CVV";
            this.Txt_CVV.Size = new System.Drawing.Size(590, 37);
            this.Txt_CVV.TabIndex = 53;
            // 
            // Txt_PIN_NUMBER
            // 
            this.Txt_PIN_NUMBER.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_PIN_NUMBER.Location = new System.Drawing.Point(418, 375);
            this.Txt_PIN_NUMBER.Multiline = true;
            this.Txt_PIN_NUMBER.Name = "Txt_PIN_NUMBER";
            this.Txt_PIN_NUMBER.Size = new System.Drawing.Size(590, 37);
            this.Txt_PIN_NUMBER.TabIndex = 54;
            // 
            // Txt_Comment
            // 
            this.Txt_Comment.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Comment.Location = new System.Drawing.Point(418, 508);
            this.Txt_Comment.Multiline = true;
            this.Txt_Comment.Name = "Txt_Comment";
            this.Txt_Comment.Size = new System.Drawing.Size(590, 37);
            this.Txt_Comment.TabIndex = 55;
            // 
            // Txt_CARD_ISSUER
            // 
            this.Txt_CARD_ISSUER.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CARD_ISSUER.Location = new System.Drawing.Point(418, 435);
            this.Txt_CARD_ISSUER.Multiline = true;
            this.Txt_CARD_ISSUER.Name = "Txt_CARD_ISSUER";
            this.Txt_CARD_ISSUER.Size = new System.Drawing.Size(590, 37);
            this.Txt_CARD_ISSUER.TabIndex = 57;
            // 
            // lbl_CARD_ISSUER
            // 
            this.lbl_CARD_ISSUER.AutoSize = true;
            this.lbl_CARD_ISSUER.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CARD_ISSUER.Location = new System.Drawing.Point(208, 439);
            this.lbl_CARD_ISSUER.Name = "lbl_CARD_ISSUER";
            this.lbl_CARD_ISSUER.Size = new System.Drawing.Size(138, 36);
            this.lbl_CARD_ISSUER.TabIndex = 56;
            this.lbl_CARD_ISSUER.Text = "CARD ISSUER";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(144)))), ((int)(((byte)(177)))));
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnUpdate.Location = new System.Drawing.Point(487, 590);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(263, 70);
            this.BtnUpdate.TabIndex = 58;
            this.BtnUpdate.Text = "UPDATE";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BANKCARD_ADDCARD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.Txt_CARD_ISSUER);
            this.Controls.Add(this.lbl_CARD_ISSUER);
            this.Controls.Add(this.Txt_Comment);
            this.Controls.Add(this.Txt_PIN_NUMBER);
            this.Controls.Add(this.Txt_CVV);
            this.Controls.Add(this.Txt_EXPIRE_DATE);
            this.Controls.Add(this.Txt_CARD_HOLDER);
            this.Controls.Add(this.Txt_CARD_NUMBER);
            this.Controls.Add(this.lbl_Comment);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.lbl_CVV);
            this.Controls.Add(this.lbl_EXPIRE_DATE);
            this.Controls.Add(this.lbl_PIN_NUMBER);
            this.Controls.Add(this.lbl_CARD_HOLDER);
            this.Controls.Add(this.lbl_CARD_NUMBER);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "BANKCARD_ADDCARD";
            this.Text = "Bank Cards";
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_CARD_NUMBER;
        private System.Windows.Forms.Label lbl_CARD_HOLDER;
        private System.Windows.Forms.Label lbl_PIN_NUMBER;
        private System.Windows.Forms.Label lbl_EXPIRE_DATE;
        private System.Windows.Forms.Label lbl_CVV;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lbl_Comment;
        private System.Windows.Forms.TextBox Txt_CARD_NUMBER;
        private System.Windows.Forms.TextBox Txt_CARD_HOLDER;
        private System.Windows.Forms.TextBox Txt_EXPIRE_DATE;
        private System.Windows.Forms.TextBox Txt_CVV;
        private System.Windows.Forms.TextBox Txt_PIN_NUMBER;
        private System.Windows.Forms.TextBox Txt_Comment;
        private System.Windows.Forms.TextBox Txt_CARD_ISSUER;
        private System.Windows.Forms.Label lbl_CARD_ISSUER;
        private FontAwesome.Sharp.IconButton IbtnBack;
        private System.Windows.Forms.Button BtnUpdate;
    }
}