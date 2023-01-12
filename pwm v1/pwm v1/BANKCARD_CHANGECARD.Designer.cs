namespace pwm_v1
{
    partial class BANKCARD_CHANGECARD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BANKCARD_CHANGECARD));
            this.Txt_CARD_HOLDER = new System.Windows.Forms.TextBox();
            this.Txt_CARD_NUMBER = new System.Windows.Forms.TextBox();
            this.lbl_CARD_HOLDER = new System.Windows.Forms.Label();
            this.lbl_CARD_NUMBER = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.IbtnBack = new FontAwesome.Sharp.IconButton();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txt_CARD_HOLDER
            // 
            this.Txt_CARD_HOLDER.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CARD_HOLDER.Location = new System.Drawing.Point(371, 270);
            this.Txt_CARD_HOLDER.Multiline = true;
            this.Txt_CARD_HOLDER.Name = "Txt_CARD_HOLDER";
            this.Txt_CARD_HOLDER.Size = new System.Drawing.Size(590, 37);
            this.Txt_CARD_HOLDER.TabIndex = 55;
            // 
            // Txt_CARD_NUMBER
            // 
            this.Txt_CARD_NUMBER.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CARD_NUMBER.Location = new System.Drawing.Point(371, 151);
            this.Txt_CARD_NUMBER.Multiline = true;
            this.Txt_CARD_NUMBER.Name = "Txt_CARD_NUMBER";
            this.Txt_CARD_NUMBER.Size = new System.Drawing.Size(590, 37);
            this.Txt_CARD_NUMBER.TabIndex = 54;
            // 
            // lbl_CARD_HOLDER
            // 
            this.lbl_CARD_HOLDER.AutoSize = true;
            this.lbl_CARD_HOLDER.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CARD_HOLDER.Location = new System.Drawing.Point(161, 270);
            this.lbl_CARD_HOLDER.Name = "lbl_CARD_HOLDER";
            this.lbl_CARD_HOLDER.Size = new System.Drawing.Size(142, 36);
            this.lbl_CARD_HOLDER.TabIndex = 53;
            this.lbl_CARD_HOLDER.Text = "CARD HOLDER";
            // 
            // lbl_CARD_NUMBER
            // 
            this.lbl_CARD_NUMBER.AutoSize = true;
            this.lbl_CARD_NUMBER.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CARD_NUMBER.Location = new System.Drawing.Point(161, 152);
            this.lbl_CARD_NUMBER.Name = "lbl_CARD_NUMBER";
            this.lbl_CARD_NUMBER.Size = new System.Drawing.Size(148, 36);
            this.lbl_CARD_NUMBER.TabIndex = 52;
            this.lbl_CARD_NUMBER.Text = "CARD NUMBER";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Purple;
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1182, 52);
            this.panelTop.TabIndex = 56;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(92)))), ((int)(((byte)(151)))));
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(467, 442);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(239, 86);
            this.BtnDelete.TabIndex = 57;
            this.BtnDelete.Text = "DELETE";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelBottom.Controls.Add(this.IbtnBack);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 693);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1182, 60);
            this.panelBottom.TabIndex = 58;
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
            // BANKCARD_CHANGECARD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.Txt_CARD_HOLDER);
            this.Controls.Add(this.Txt_CARD_NUMBER);
            this.Controls.Add(this.lbl_CARD_HOLDER);
            this.Controls.Add(this.lbl_CARD_NUMBER);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "BANKCARD_CHANGECARD";
            this.Text = "Change Bank Cards";
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_CARD_HOLDER;
        private System.Windows.Forms.TextBox Txt_CARD_NUMBER;
        private System.Windows.Forms.Label lbl_CARD_HOLDER;
        private System.Windows.Forms.Label lbl_CARD_NUMBER;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Panel panelBottom;
        private FontAwesome.Sharp.IconButton IbtnBack;
    }
}