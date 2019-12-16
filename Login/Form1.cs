using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Login
{
    public partial class Form1 : Form
    {
        connection con = new connection();
        string username, password, firstname, lastname, address;

    

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

         try
            {

                if (user.Text != "" && pass.Text != "")
                {

                    con.Open();
                   
                    string query = "select username,password,first_name,last_name,email from userstable WHERE username ='" + user.Text + "' AND password ='" + pass.Text + "'";
                    MySqlDataReader row;
                    row = con.ExecuteReader(query);
                    if (row.HasRows)
                    {
                        while (row.Read())
                        {

                            username = row["username"].ToString();
                            password = row["password"].ToString();
                            firstname = row["first_name"].ToString();
                            lastname = row["last_name"].ToString();
                            address = row["email"].ToString();
                       
                        }

                        MessageBox.Show("You have logged in as " + username + " Welcome back " + firstname + " " + lastname);
                      
                        this.Hide();
                        var form3 = new Form3(username);
                        form3.Closed += (s, args) => this.Close();
                        form3.Show(); 
                        con.Close();
                    }
                   
                    else
                    {
                        MessageBox.Show("Data not found", "Information");
                    }
                }
                else
                {
                    MessageBox.Show("Username or Password is empty", "Information");
                }
            }
            catch
            {
                MessageBox.Show("Connection Error", "Information");
            }
        }

   
        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Form2();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
       
    }
}
