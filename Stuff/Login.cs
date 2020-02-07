using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Credintials
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private int attempts;
        private void button1_Click(object sender, EventArgs e)
        {
            string user = "admin";
            string pass = user;
            if (textBox1.Text == user && textBox2.Text == pass)
            {
                attempts = 0;
                MessageBox.Show("Login Success");
                Main f2 = new Main();
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Credintials");
                attempts++;
                return;
            }
            if (attempts == 3)
            {
                MessageBox.Show("fuck");
                Close();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
