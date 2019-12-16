using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Login
{
    public partial class Form2 : Form
    {
        connection con = new connection();
        string  username;

        private void buttonRegister_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtUname.Text))
            {
                MessageBox.Show("You have left required feilds empty!");
            }
            else if (string.IsNullOrWhiteSpace(txtFname.Text))
            {
                MessageBox.Show("You have left required feilds empty!");
            }
            else if (string.IsNullOrWhiteSpace(txtLname.Text))
            {
                MessageBox.Show("You have left required feilds empty!");
            }
            else if (string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("You have left required feilds empty!");
            }
            else if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("You have left required feilds empty!");
            }else try
            {
              
                int rand;
                Random rnd = new Random();
                rand = rnd.Next(1, 10000);
                con.Open();
          
                string query = "INSERT INTO `users`.`userstable` (`username`,`first_name`,`last_name`,`password`,`email`,`user_id`,`title`) Values ('" + txtUname.Text + "', '" + txtFname.Text + "', '" + txtLname.Text + "', '" + txtPass.Text + "', '" + txtEmail.Text + "', '" + rand + "','SickBeats');";
                username = txtUname.Text;
    
                MySqlDataReader row;
                row = con.ExecuteReader(query);
               
                   
                    this.Hide();
                    var form3 = new Form3(username);
                    form3.Closed += (s, args) => this.Close();
                    form3.Show();
                
            }
            catch
            {
                    MessageBox.Show("Connection Error", "Information");
                }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public Form2()
        {
            InitializeComponent();
        }

    }
}
