using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
    {
        public partial class New : Form
        {
            public New()
            {
                InitializeComponent();
                textBox4.Enabled = false;
                BindData();
        }

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-757VP3F;Initial Catalog=\"Project 1\";Integrated Security=True");

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            
            SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Product WHERE ProductID = @ID", con);
            checkCmd.Parameters.AddWithValue("@ID", textBox1.Text);

            int existingProductCount = (int)checkCmd.ExecuteScalar();

            if (existingProductCount > 0)
            {
                SqlCommand updateCmd = new SqlCommand("UPDATE Product SET ProductAmount = ProductAmount + @NewAmount WHERE ProductID = @ID", con);
                updateCmd.Parameters.AddWithValue("@ID", textBox1.Text);
                updateCmd.Parameters.AddWithValue("@NewAmount", int.Parse(textBox3.Text));
                updateCmd.ExecuteNonQuery();
            }
            else
            {
                SqlCommand insertCmd = new SqlCommand("INSERT INTO Product (ProductID, ProductType, ProductName, ProductAmount) VALUES (@ID, @ProductType, @Name, @Amount)", con);
                insertCmd.Parameters.AddWithValue("@ProductType", comboBox1.Text);
                insertCmd.Parameters.AddWithValue("@ID", textBox1.Text);
                insertCmd.Parameters.AddWithValue("@Name", textBox2.Text);
                insertCmd.Parameters.AddWithValue("@Amount", textBox3.Text);
                insertCmd.ExecuteNonQuery();
            }

            MessageBox.Show("Successfully Inserted ");
            BindData();

            con.Close();
        }

        void BindData()
            {
                SqlCommand command = new SqlCommand("select *from Product", con);
                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;

            }


        private void button2_Click(object sender, EventArgs e)
        {
            int updatedAmount;

            if (int.TryParse(textBox4.Text, out updatedAmount))
            {
                con.Open();
                SqlCommand command = new SqlCommand("UPDATE Product SET ProductName = @ProductName, ProductAmount = ProductAmount - @UpdatedAmount WHERE ProductID = @ProductID", con);
                command.Parameters.AddWithValue("@ProductName", textBox2.Text);
                command.Parameters.AddWithValue("@UpdatedAmount", updatedAmount);
                command.Parameters.AddWithValue("@ProductID", textBox1.Text);
                command.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Successfully Updated");
                BindData();
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric value for Updated Amount.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (MessageBox.Show("Are you Sure to delete?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Delete  Product where ProductID='" + textBox1.Text + "' ", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfully deleted");
                    BindData();
                }
            }
            else
            {
                MessageBox.Show("Enter ID");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            string productId = textBox1.Text;
            string productName = textBox2.Text;

            if (!string.IsNullOrEmpty(productId))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Product WHERE ProductId LIKE '%' + @SearchLetter + '%'", con);
                command.Parameters.AddWithValue("@SearchLetter", textBox1.Text);
                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (!string.IsNullOrEmpty(productName))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Product WHERE ProductName LIKE '%' + @SearchText + '%'", con);
                command.Parameters.AddWithValue("@SearchText", textBox2.Text);
                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else {
                SqlCommand command = new SqlCommand("SELECT * FROM Product WHERE ProductType = @Type", con);
                command.Parameters.AddWithValue("@Type", comboBox1.SelectedItem.ToString());
                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label4.Enabled = true;
                textBox4.Enabled = true;
            }
            else
            {
                label4.Enabled = false;
                textBox4.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
    }
