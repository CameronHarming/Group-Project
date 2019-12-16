namespace Login
{
    partial class Form2
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
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtUname = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.lblFname = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblUName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(243, 12);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(153, 20);
            this.txtFname.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(243, 90);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(153, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // txtUname
            // 
            this.txtUname.Location = new System.Drawing.Point(243, 64);
            this.txtUname.Name = "txtUname";
            this.txtUname.Size = new System.Drawing.Size(153, 20);
            this.txtUname.TabIndex = 2;
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(243, 38);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(153, 20);
            this.txtLname.TabIndex = 3;
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblFname.Location = new System.Drawing.Point(67, 12);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(92, 20);
            this.lblFname.TabIndex = 4;
            this.lblFname.Text = "First Name";
            this.lblFname.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblLName.Location = new System.Drawing.Point(67, 38);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(91, 20);
            this.lblLName.TabIndex = 5;
            this.lblLName.Text = "Last Name";
            // 
            // lblUName
            // 
            this.lblUName.AutoSize = true;
            this.lblUName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblUName.Location = new System.Drawing.Point(67, 64);
            this.lblUName.Name = "lblUName";
            this.lblUName.Size = new System.Drawing.Size(86, 20);
            this.lblUName.TabIndex = 6;
            this.lblUName.Text = "Username";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblEmail.Location = new System.Drawing.Point(67, 90);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 20);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblPass.Location = new System.Drawing.Point(67, 116);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(83, 20);
            this.lblPass.TabIndex = 8;
            this.lblPass.Text = "Password";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(243, 118);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(153, 20);
            this.txtPass.TabIndex = 9;
            // 
            // buttonRegister
            // 
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.buttonRegister.Location = new System.Drawing.Point(243, 160);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(153, 41);
            this.buttonRegister.TabIndex = 10;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(560, 226);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblUName);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.lblFname);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtUname);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFname);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtUname;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblUName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button buttonRegister;
    }
}