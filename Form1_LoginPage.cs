using System;
using System.Linq;
using System.Numerics;
using System.Windows.Forms;

namespace Bolanos_GUI_Winforms_Activity
{
    public partial class Form1_LoginPage : Form
    {
        public Form1_LoginPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox1.ReadOnly = false;

            textBox2.Enabled = true;
            textBox2.ReadOnly = false;

            textBox2.UseSystemPasswordChar = true;

            textBox1.PlaceholderText = "Username";
            textBox2.PlaceholderText = "Password";

            textBox1.Text = "";
            textBox2.Text = "";

            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your username and password.");
                return;
            }

            try
            {
                using (var db = new GrocerydbContext())
                {
                    var user = db.Usersts.FirstOrDefault(u => u.UserName == username);

                    if (user == null)
                    {
                        MessageBox.Show("No user found!");
                    }
                    else if (user.Password != password)
                    {
                        MessageBox.Show("Incorrect password!");
                    }
                    else
                    {
                        Form2_GroceryListPage form = new Form2_GroceryListPage();
                        form.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !textBox2.UseSystemPasswordChar;
        }

        private void label3_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
    }
}