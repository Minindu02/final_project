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

namespace WindowsFormsApp3
{
    public partial class frmlogin : Form
    {
        SqlConnection conn;
        public frmlogin()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=DESKTOP-757VP3F;Initial Catalog=\"Project 1\";Integrated Security=True");
        }
    

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            String username, password;

            username = tbun.Text;
            password = tbpw.Text;

            try
            {
                String querry = "SELECT * FROM Admin WHERE username= '"+tbun.Text+"' AND password='"+tbpw.Text+"'  ";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable=new DataTable();
                sda.Fill(dtable);

                if(dtable.Rows.Count>0)
                {
                    username = tbun.Text;
                    password = tbpw.Text;

                    New product = new New();
                    product.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbun.Clear();
                    tbpw.Clear();

                    tbun.Focus();

                }

            }
           catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            tbun.Clear();
            tbpw.Clear();

            tbun.Focus();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res==DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }
    }
}
