namespace AGFitness
{
    partial class ForgotPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPass));
            this.txtusername = new System.Windows.Forms.TextBox();
            this.lblusername = new System.Windows.Forms.Label();
            this.retrievepassbtn = new System.Windows.Forms.Button();
            this.lblForgotpass = new System.Windows.Forms.Label();
            this.txtsanswer = new System.Windows.Forms.TextBox();
            this.lblsanswer = new System.Windows.Forms.Label();
            this.txtsquestion = new System.Windows.Forms.ComboBox();
            this.lblsquestion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(33, 274);
            this.txtusername.Margin = new System.Windows.Forms.Padding(4);
            this.txtusername.Multiline = true;
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(425, 40);
            this.txtusername.TabIndex = 32;
            this.txtusername.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.BackColor = System.Drawing.Color.Transparent;
            this.lblusername.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(26, 235);
            this.lblusername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(141, 31);
            this.lblusername.TabIndex = 31;
            this.lblusername.Text = "UserName";
            this.lblusername.Click += new System.EventHandler(this.lblusername_Click);
            // 
            // retrievepassbtn
            // 
            this.retrievepassbtn.BackColor = System.Drawing.Color.Gold;
            this.retrievepassbtn.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.retrievepassbtn.FlatAppearance.BorderSize = 0;
            this.retrievepassbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retrievepassbtn.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retrievepassbtn.Location = new System.Drawing.Point(167, 529);
            this.retrievepassbtn.Margin = new System.Windows.Forms.Padding(4);
            this.retrievepassbtn.Name = "retrievepassbtn";
            this.retrievepassbtn.Size = new System.Drawing.Size(345, 54);
            this.retrievepassbtn.TabIndex = 30;
            this.retrievepassbtn.Text = "Retrieve Password";
            this.retrievepassbtn.UseVisualStyleBackColor = false;
            this.retrievepassbtn.Click += new System.EventHandler(this.forgot_login_Click);
            // 
            // lblForgotpass
            // 
            this.lblForgotpass.BackColor = System.Drawing.Color.Transparent;
            this.lblForgotpass.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotpass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblForgotpass.Location = new System.Drawing.Point(24, 157);
            this.lblForgotpass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblForgotpass.Name = "lblForgotpass";
            this.lblForgotpass.Size = new System.Drawing.Size(412, 57);
            this.lblForgotpass.TabIndex = 29;
            this.lblForgotpass.Text = "Forgot Password";
            this.lblForgotpass.Click += new System.EventHandler(this.lblForgotpass_Click);
            // 
            // txtsanswer
            // 
            this.txtsanswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsanswer.Location = new System.Drawing.Point(33, 449);
            this.txtsanswer.Margin = new System.Windows.Forms.Padding(4);
            this.txtsanswer.Multiline = true;
            this.txtsanswer.Name = "txtsanswer";
            this.txtsanswer.Size = new System.Drawing.Size(425, 40);
            this.txtsanswer.TabIndex = 28;
            this.txtsanswer.TextChanged += new System.EventHandler(this.txtsanswer_TextChanged);
            // 
            // lblsanswer
            // 
            this.lblsanswer.AutoSize = true;
            this.lblsanswer.BackColor = System.Drawing.Color.Transparent;
            this.lblsanswer.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsanswer.Location = new System.Drawing.Point(26, 413);
            this.lblsanswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsanswer.Name = "lblsanswer";
            this.lblsanswer.Size = new System.Drawing.Size(322, 31);
            this.lblsanswer.TabIndex = 27;
            this.lblsanswer.Text = "Security Question answer";
            // 
            // txtsquestion
            // 
            this.txtsquestion.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsquestion.FormattingEnabled = true;
            this.txtsquestion.Items.AddRange(new object[] {
            "What is the name of your first pet?",
            "What is your favourite color?",
            "What is your childhood bestfriend name?"});
            this.txtsquestion.Location = new System.Drawing.Point(33, 358);
            this.txtsquestion.Margin = new System.Windows.Forms.Padding(4);
            this.txtsquestion.Name = "txtsquestion";
            this.txtsquestion.Size = new System.Drawing.Size(425, 39);
            this.txtsquestion.TabIndex = 26;
            this.txtsquestion.SelectedIndexChanged += new System.EventHandler(this.txtsquestion_SelectedIndexChanged);
            // 
            // lblsquestion
            // 
            this.lblsquestion.AutoSize = true;
            this.lblsquestion.BackColor = System.Drawing.Color.Transparent;
            this.lblsquestion.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsquestion.Location = new System.Drawing.Point(26, 322);
            this.lblsquestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsquestion.Name = "lblsquestion";
            this.lblsquestion.Size = new System.Drawing.Size(229, 31);
            this.lblsquestion.TabIndex = 25;
            this.lblsquestion.Text = "Security Question";
            this.lblsquestion.Click += new System.EventHandler(this.lblsquestion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(672, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // ForgotPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(833, 611);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.retrievepassbtn);
            this.Controls.Add(this.lblForgotpass);
            this.Controls.Add(this.txtsanswer);
            this.Controls.Add(this.lblsanswer);
            this.Controls.Add(this.txtsquestion);
            this.Controls.Add(this.lblsquestion);
            this.Name = "ForgotPass";
            this.Text = "ForgotPass";
            this.Load += new System.EventHandler(this.ForgotPass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Button retrievepassbtn;
        private System.Windows.Forms.Label lblForgotpass;
        private System.Windows.Forms.TextBox txtsanswer;
        private System.Windows.Forms.Label lblsanswer;
        private System.Windows.Forms.ComboBox txtsquestion;
        private System.Windows.Forms.Label lblsquestion;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}