using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql;
using MySql.Data;
using System.Collections;
namespace Login
{

    public partial class Form3 : Form
    {
        connection con = new connection();
        
        DataSet Lists = new DataSet();
        private static ArrayList ListID = new ArrayList();
        private static ArrayList ListTitle = new ArrayList();
        private static ArrayList ListUser = new ArrayList();





   
        public Form3(string Username)
        {
            InitializeComponent();
            MenuUser.Text = Username;

        }
            private void button1_Click_1(object sender, EventArgs e)
            {
                /*      string query = "INSERT INTO `users`.`playlist` (`idplaylist`, `title`, `username`) VALUES ('1', 'Rock', 'Charming');";
                      try
                      {

                          con.Open();
                          con.ExecuteNonQuery(query);
                      }
                      catch (Exception err)
                      {
                          MessageBox.Show(err.ToString());
                      }
                  }
                  */
                GetData();
                if (ListUser.Count > 0)
                {
                    updateDatagrid();
                }
                else
                {
                    MessageBox.Show("Data not found");
                }
            }
            private void GetData()
            {
                try
                {
    
              
                con.Open();
                string query = "select username,password,first_name,last_name,email,title from userstable";

                //MySqlDataReader row;

                MySqlDataReader row;
                    row = con.ExecuteReader(query);
                    if (row.HasRows)
                    {
                        while (row.Read())
                    {

                            ListUser.Add(row["username"].ToString());
                            ListTitle.Add(row["title"].ToString());
                    
                        }
                    }
                    else
                    {
                        MessageBox.Show("Data not found");
                    }

                    con.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString());
                }

            }
        
    
        private void updateDatagrid()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < ListUser.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(dataGridView1);
         
                newRow.Cells[0].Value = ListTitle[i];
                newRow.Cells[1].Value = ListUser[i];
               
                dataGridView1.Rows.Add(newRow);
            }
        }



        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void playlistsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void MenuProfile_Click(object sender, EventArgs e)
        {
          
        }
    }
}
