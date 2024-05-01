namespace AGFitness
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginlbl = new System.Windows.Forms.Label();
            this.usernamelbl = new System.Windows.Forms.Label();
            this.passlbl = new System.Windows.Forms.Label();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblnoacc = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblforgetpass = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(138, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // loginlbl
            // 
            this.loginlbl.AutoSize = true;
            this.loginlbl.BackColor = System.Drawing.Color.Transparent;
            this.loginlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginlbl.Location = new System.Drawing.Point(471, 36);
            this.loginlbl.Name = "loginlbl";
            this.loginlbl.Size = new System.Drawing.Size(96, 38);
            this.loginlbl.TabIndex = 1;
            this.loginlbl.Text = "Login";
            // 
            // usernamelbl
            // 
            this.usernamelbl.AutoSize = true;
            this.usernamelbl.BackColor = System.Drawing.Color.Transparent;
            this.usernamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelbl.Location = new System.Drawing.Point(363, 124);
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.Size = new System.Drawing.Size(86, 20);
            this.usernamelbl.TabIndex = 2;
            this.usernamelbl.Text = "Username";
            // 
            // passlbl
            // 
            this.passlbl.AutoSize = true;
            this.passlbl.BackColor = System.Drawing.Color.Transparent;
            this.passlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passlbl.Location = new System.Drawing.Point(363, 184);
            this.passlbl.Name = "passlbl";
            this.passlbl.Size = new System.Drawing.Size(83, 20);
            this.passlbl.TabIndex = 3;
            this.passlbl.Text = "Password";
            // 
            // passtxt
            // 
            this.passtxt.Location = new System.Drawing.Point(525, 184);
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(139, 22);
            this.passtxt.TabIndex = 5;
            // 
            // usernametxt
            // 
            this.usernametxt.Location = new System.Drawing.Point(525, 122);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(139, 22);
            this.usernametxt.TabIndex = 6;
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.Aqua;
            this.loginbtn.Location = new System.Drawing.Point(435, 330);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(104, 42);
            this.loginbtn.TabIndex = 7;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(582, 226);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(151, 24);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lblnoacc
            // 
            this.lblnoacc.AutoSize = true;
            this.lblnoacc.BackColor = System.Drawing.Color.Transparent;
            this.lblnoacc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnoacc.Location = new System.Drawing.Point(363, 270);
            this.lblnoacc.Name = "lblnoacc";
            this.lblnoacc.Size = new System.Drawing.Size(176, 20);
            this.lblnoacc.TabIndex = 9;
            this.lblnoacc.Text = "Didnt have a account?";
            this.lblnoacc.Click += new System.EventHandler(this.lblRegisterpage_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Aqua;
            this.btnRegister.Location = new System.Drawing.Point(602, 270);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(131, 37);
            this.btnRegister.TabIndex = 10;
            this.btnRegister.Text = "Register Here";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblforgetpass
            // 
            this.lblforgetpass.AutoSize = true;
            this.lblforgetpass.BackColor = System.Drawing.Color.Transparent;
            this.lblforgetpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblforgetpass.ForeColor = System.Drawing.Color.Transparent;
            this.lblforgetpass.Location = new System.Drawing.Point(596, 340);
            this.lblforgetpass.Name = "lblforgetpass";
            this.lblforgetpass.Size = new System.Drawing.Size(240, 32);
            this.lblforgetpass.TabIndex = 11;
            this.lblforgetpass.Text = "Forgot password?";
            this.lblforgetpass.Click += new System.EventHandler(this.lblforgetpass_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 426);
            this.Controls.Add(this.lblforgetpass);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblnoacc);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.usernametxt);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.passlbl);
            this.Controls.Add(this.usernamelbl);
            this.Controls.Add(this.loginlbl);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Label loginlbl;
        internal System.Windows.Forms.Label usernamelbl;
        internal System.Windows.Forms.Label passlbl;
        internal System.Windows.Forms.TextBox passtxt;
        internal System.Windows.Forms.TextBox usernametxt;
        internal System.Windows.Forms.Button loginbtn;
        internal System.Windows.Forms.CheckBox checkBox1;
        internal System.Windows.Forms.Label lblnoacc;
        internal System.Windows.Forms.Button btnRegister;
        internal System.Windows.Forms.Label lblforgetpass;
    }
}