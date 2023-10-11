namespace WindowsFormsApp3
{
    partial class frmlogin
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
            this.lblwc = new System.Windows.Forms.Label();
            this.lblun = new System.Windows.Forms.Label();
            this.lblpw = new System.Windows.Forms.Label();
            this.tbun = new System.Windows.Forms.TextBox();
            this.tbpw = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblwc
            // 
            this.lblwc.AutoSize = true;
            this.lblwc.Font = new System.Drawing.Font("Cooper Black", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwc.Location = new System.Drawing.Point(312, 55);
            this.lblwc.Name = "lblwc";
            this.lblwc.Size = new System.Drawing.Size(177, 40);
            this.lblwc.TabIndex = 0;
            this.lblwc.Text = "Welcome";
            // 
            // lblun
            // 
            this.lblun.AutoSize = true;
            this.lblun.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblun.Location = new System.Drawing.Point(184, 141);
            this.lblun.Name = "lblun";
            this.lblun.Size = new System.Drawing.Size(173, 37);
            this.lblun.TabIndex = 1;
            this.lblun.Text = "User name";
            // 
            // lblpw
            // 
            this.lblpw.AutoSize = true;
            this.lblpw.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpw.Location = new System.Drawing.Point(184, 214);
            this.lblpw.Name = "lblpw";
            this.lblpw.Size = new System.Drawing.Size(158, 37);
            this.lblpw.TabIndex = 2;
            this.lblpw.Text = "Password";
            // 
            // tbun
            // 
            this.tbun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbun.Location = new System.Drawing.Point(440, 151);
            this.tbun.Name = "tbun";
            this.tbun.Size = new System.Drawing.Size(149, 26);
            this.tbun.TabIndex = 3;
            // 
            // tbpw
            // 
            this.tbpw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpw.Location = new System.Drawing.Point(440, 224);
            this.tbpw.Name = "tbpw";
            this.tbpw.PasswordChar = '*';
            this.tbpw.Size = new System.Drawing.Size(149, 26);
            this.tbpw.TabIndex = 4;
            this.tbpw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(408, 281);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(81, 36);
            this.btnlogin.TabIndex = 5;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Gray;
            this.btnclear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(276, 281);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(81, 36);
            this.btnclear.TabIndex = 6;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Black;
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Location = new System.Drawing.Point(39, 393);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(81, 36);
            this.btnexit.TabIndex = 7;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(736, 443);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.tbpw);
            this.Controls.Add(this.tbun);
            this.Controls.Add(this.lblpw);
            this.Controls.Add(this.lblun);
            this.Controls.Add(this.lblwc);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmlogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmlogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblwc;
        private System.Windows.Forms.Label lblun;
        private System.Windows.Forms.Label lblpw;
        private System.Windows.Forms.TextBox tbun;
        private System.Windows.Forms.TextBox tbpw;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
    }
}

