using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.VisualBasic;

namespace Bolanos_GUI_Winforms_Activity
{
    public partial class Form2_GroceryListPage : Form
    {
        private readonly string connString =
            "Server=localhost;Port=3306;Database=grocerydb;Uid=root;Pwd=ms1q_ywn1_123;";

        private int selectedId = 0;

        public Form2_GroceryListPage()
        {
            InitializeComponent();

            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void Form2_GroceryListPage_Load(object sender, EventArgs e)
        {
            LoadGrocery();
        }

        private void LoadGrocery()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();

                    string query = "SELECT ProductId, ProdName, Price FROM groceryitemt";

                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                }

                selectedId = 0; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            selectedId = Convert.ToInt32(row.Cells[0].Value); 

            MessageBox.Show("Selected ID: " + selectedId);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = Interaction.InputBox("Product Name:", "Add Item");
                if (string.IsNullOrWhiteSpace(name)) return;

                string price = Interaction.InputBox("Price:", "Add Item");

                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();

                    string query = "INSERT INTO groceryitemt (ProdName, Price) VALUES (@name, @price)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@price", price);

                    cmd.ExecuteNonQuery();
                }

                LoadGrocery();
                MessageBox.Show("Item added!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Select an item first!");
                return;
            }

            try
            {
                string name = Interaction.InputBox("New Product Name:", "Update Item");
                string price = Interaction.InputBox("New Price:", "Update Item");

                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();

                    string query = @"
                        UPDATE groceryitemt
                        SET ProdName=@name, Price=@price
                        WHERE ProductId=@id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", selectedId);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@price", price);

                    cmd.ExecuteNonQuery();
                }

                LoadGrocery();
                MessageBox.Show("Item updated!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update error: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Select an item first!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Delete this item?",
                "Confirm",
                MessageBoxButtons.YesNo
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connString))
                    {
                        conn.Open();

                        string query = "DELETE FROM groceryitemt WHERE ProductId=@id";

                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", selectedId);

                        cmd.ExecuteNonQuery();
                    }

                    selectedId = 0;
                    LoadGrocery();

                    MessageBox.Show("Deleted!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Delete error: " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label12_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void pictureBox2_Click(object sender, EventArgs e) { }
    }
}