namespace carsales
{
    partial class frmDash
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDash));
            this.label4 = new System.Windows.Forms.Label();
            this.pMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pLogin = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ckShowpass = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.pMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(230, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 42);
            this.label4.TabIndex = 9;
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.Color.Teal;
            this.pMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pMain.BackgroundImage")));
            this.pMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pMain.Controls.Add(this.panel1);
            this.pMain.Controls.Add(this.pLogin);
            this.pMain.Location = new System.Drawing.Point(2, 12);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(500, 469);
            this.pMain.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 43);
            this.panel1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(108, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(292, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "CAR SALES MANAGEMENT  SYSTEM";
            // 
            // pLogin
            // 
            this.pLogin.BackColor = System.Drawing.Color.Black;
            this.pLogin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pLogin.Controls.Add(this.button1);
            this.pLogin.Controls.Add(this.pictureBox1);
            this.pLogin.Controls.Add(this.label3);
            this.pLogin.Controls.Add(this.label2);
            this.pLogin.Controls.Add(this.ckShowpass);
            this.pLogin.Controls.Add(this.btnClear);
            this.pLogin.Controls.Add(this.btnLogin);
            this.pLogin.Controls.Add(this.txtPass);
            this.pLogin.Controls.Add(this.txtUsername);
            this.pLogin.Controls.Add(this.label1);
            this.pLogin.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.pLogin.Location = new System.Drawing.Point(129, 54);
            this.pLogin.Name = "pLogin";
            this.pLogin.Size = new System.Drawing.Size(257, 402);
            this.pLogin.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(146, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 25);
            this.button1.TabIndex = 9;
            this.button1.Text = "Sign Up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(92, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(82, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Username*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(82, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password*";
            // 
            // ckShowpass
            // 
            this.ckShowpass.AutoSize = true;
            this.ckShowpass.BackColor = System.Drawing.Color.Black;
            this.ckShowpass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckShowpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckShowpass.ForeColor = System.Drawing.Color.White;
            this.ckShowpass.Location = new System.Drawing.Point(65, 326);
            this.ckShowpass.Name = "ckShowpass";
            this.ckShowpass.Size = new System.Drawing.Size(117, 20);
            this.ckShowpass.TabIndex = 5;
            this.ckShowpass.Text = "show password";
            this.ckShowpass.UseVisualStyleBackColor = false;
            this.ckShowpass.CheckedChanged += new System.EventHandler(this.ckShowpass_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClear.Location = new System.Drawing.Point(13, 352);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(57, 25);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogin.Location = new System.Drawing.Point(4, 286);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Padding = new System.Windows.Forms.Padding(1, 0, 0, 1);
            this.btnLogin.Size = new System.Drawing.Size(247, 34);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnLogin_MouseClick);
            // 
            // txtPass
            // 
            this.txtPass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtPass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtPass.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.Black;
            this.txtPass.Location = new System.Drawing.Point(4, 244);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(247, 27);
            this.txtPass.TabIndex = 2;
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUsername
            // 
            this.txtUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtUsername.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.Location = new System.Drawing.Point(4, 174);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(247, 27);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(90, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(148, 484);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Powered by Encoders Unlimited DevsTeam(2020)";
            // 
            // frmDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(505, 506);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.label4);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.frmDash_Load);
            this.pMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pLogin.ResumeLayout(false);
            this.pLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckShowpass;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
    }
}

