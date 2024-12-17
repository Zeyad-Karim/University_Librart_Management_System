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

namespace University_Library
{
    public partial class Form2 : Form
    {
        private string connectionString = "Data Source=LAPTOP-GMCQ5HDK;Initial Catalog=libraryx;Integrated Security=True;TrustServerCertificate=True";

        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                string query = "Select * FROM PUBLISHER";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        SqlDataAdapter da = new SqlDataAdapter(query, conn);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        Grid_Show_Publishers.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }

        private void btnShowUsers_Click(object sender, EventArgs e)
        {
            {
                string query = "Select * FROM [User]";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        SqlDataAdapter da = new SqlDataAdapter(query, conn);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        Show_Users_Grid.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }

        private void btn_Show_Books_Click(object sender, EventArgs e)
        {
            {
                string query = "Select * FROM BOOK";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        SqlDataAdapter da = new SqlDataAdapter(query, conn);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        Grid_Show_Show_Books.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }

        private void btn_Borrow_Status_Click(object sender, EventArgs e)
        {
            {
                string query = "Select * FROM BORROWS";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        SqlDataAdapter da = new SqlDataAdapter(query, conn);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        Grid_Show_Borrow.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }

        private void btn_Show_Admins_Click(object sender, EventArgs e)
        {
            {
                string query = "Select * FROM ADMIN";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        SqlDataAdapter da = new SqlDataAdapter(query, conn);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        Grid_Show_Admins.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }

        private void btn_Show_Book_Copy_Click(object sender, EventArgs e)
        {
            {
                string query = "Select * FROM BOOK_COPY";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        SqlDataAdapter da = new SqlDataAdapter(query, conn);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        Grid_Show_Copys.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }
    }
}
