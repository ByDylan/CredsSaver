using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Credintials
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) //Random String
        {
            char[] letters = "qwertyuiopasdfghjklzxcvbnm1234567890!@#$%^&*()".ToCharArray();
            Random rand = new Random();
            string randomstring = "";

            for (int i = 0; i < 20; i++)
            {
                randomstring += letters[rand.Next(20, 30)].ToString();
            }
            textBox4.Text = (randomstring.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
            string query = "INSERT into creds.cool(website, username, password) VALUES('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox4.Text + "')"; //Make sure you change the db and table name to your own

            connection.Open();
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Success Submitted");
                    Close();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection.Close();
        }
    }
}
