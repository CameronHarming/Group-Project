namespace Login
{
    partial class Form1
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.lblU = new System.Windows.Forms.Label();
            this.lblP = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblRegister = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btnLogin.Location = new System.Drawing.Point(198, 123);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(142, 41);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(198, 30);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(243, 20);
            this.user.TabIndex = 1;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(198, 83);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(243, 20);
            this.pass.TabIndex = 2;
            // 
            // lblU
            // 
            this.lblU.AutoSize = true;
            this.lblU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblU.Location = new System.Drawing.Point(49, 30);
            this.lblU.Name = "lblU";
            this.lblU.Size = new System.Drawing.Size(86, 20);
            this.lblU.TabIndex = 3;
            this.lblU.Text = "Username";
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblP.Location = new System.Drawing.Point(49, 83);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(83, 20);
            this.lblP.TabIndex = 4;
            this.lblP.Text = "Password";
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnRegister.Location = new System.Drawing.Point(198, 206);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(160, 25);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblRegister.Location = new System.Drawing.Point(164, 178);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(214, 13);
            this.lblRegister.TabIndex = 6;
            this.lblRegister.Text = "Haven\'t created an account? Register now!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(763, 426);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.lblU);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.user);
            this.Controls.Add(this.btnLogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label lblU;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblRegister;
    }
}

