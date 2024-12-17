using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using ClosedXML.Excel;
using iText.Kernel.Exceptions;
namespace University_Library
{

    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=LAPTOP-GMCQ5HDK;Initial Catalog=libraryx;Integrated Security=True;TrustServerCertificate=True";

        public Form1()
        {
            InitializeComponent();
        }


        private void btnInsertAdmin_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                InsertAdmin(connection, int.Parse(txtAdminID.Text), txtAdminUsername.Text, txtAdminPassword.Text,
                            txtAdminFirstName.Text, txtAdminLastName.Text, txtAdminEmail.Text, txtAdminPhone.Text);
            }
        }

        private void InsertAdmin(SqlConnection connection, int id, string username, string password, string firstName, string lastName, string email, string phone)
        {
            string query = "INSERT INTO ADMIN (ADMIN_ID, ADMIN_USERNAME, PASSWORD, FIRST_NAME, LAST_NAME, EMAIL, PHONE) VALUES (@ID, @Username, @Password, @FirstName, @LastName, @Email, @Phone)";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ID", id);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Phone", phone);
                command.ExecuteNonQuery();
            }
        }

        private void InsertBook(SqlConnection connection, int id, string author, string title, DateTime publicationYear, int adminId, int publisherId)
        {
            string query = "INSERT INTO BOOK (BOOK_ID, AUTHOR_NAME, TITLE, PUBLICATION_YEAR, ADMIN_ID, PUBLISHER_ID) VALUES (@ID, @Author, @Title, @PublicationYear, @AdminId, @PublisherId)";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ID", id);
                command.Parameters.AddWithValue("@Author", author);
                command.Parameters.AddWithValue("@Title", title);
                command.Parameters.AddWithValue("@PublicationYear", publicationYear);
                command.Parameters.AddWithValue("@AdminId", adminId);
                command.Parameters.AddWithValue("@PublisherId", publisherId);
                command.ExecuteNonQuery();
            }
        }

        private void DeleteAdmin(SqlConnection connection, int id)
        {
            string query = "DELETE FROM ADMIN WHERE ADMIN_ID = @ID";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ID", id);
                command.ExecuteNonQuery();
            }
        }

        private void DeleteBook(SqlConnection connection, int id)
        {
            string query = "DELETE FROM BOOK WHERE BOOK_ID = @ID";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ID", id);
                command.ExecuteNonQuery();
            }
        }

        private void UpdateAdminEmail(SqlConnection connection, int id, string newEmail)
        {
            string query = "UPDATE ADMIN SET EMAIL = @NewEmail WHERE ADMIN_ID = @ID";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ID", id);
                command.Parameters.AddWithValue("@NewEmail", newEmail);
                command.ExecuteNonQuery();
            }
        }

        private void UpdateBookTitle(SqlConnection connection, int id, string newTitle)
        {
            string query = "UPDATE BOOK SET TITLE = @NewTitle WHERE BOOK_ID = @ID";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ID", id);
                command.Parameters.AddWithValue("@NewTitle", newTitle);
                command.ExecuteNonQuery();
            }
        }

        private DataTable SelectAdmins(SqlConnection connection)
        {
            string query = "SELECT * FROM ADMIN";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    listBoxAdmins.Items.Clear();
                    foreach (DataRow row in dataTable.Rows)
                    {
                        listBoxAdmins.Items.Add($"{row["ADMIN_ID"]}, {row["ADMIN_USERNAME"]}, {row["FIRST_NAME"]}, {row["LAST_NAME"]}, {row["EMAIL"]}, {row["PHONE"]}");
                    }
                    return dataTable;
                }
            }
        }

        private void SelectBooksByPublisher(SqlConnection connection, int publisherId)
        {
            string query = "SELECT * FROM BOOK WHERE PUBLISHER_ID = @PublisherId";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@PublisherId", publisherId);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    listBoxBooks.Items.Clear();
                    while (reader.Read())
                    {
                        listBoxBooks.Items.Add($"{reader["BOOK_ID"]}, {reader["AUTHOR_NAME"]}, {reader["TITLE"]}, {reader["PUBLICATION_YEAR"]}");
                    }
                }
            }
        }

        private void SelectBooksAndAdmins(SqlConnection connection)
        {
            string query = @"
                SELECT BOOK.BOOK_ID, BOOK.TITLE, ADMIN.ADMIN_USERNAME
                FROM BOOK
                JOIN ADMIN ON BOOK.ADMIN_ID = ADMIN.ADMIN_ID";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    listBoxBooksAndAdmins.Items.Clear();
                    while (reader.Read())
                    {
                        listBoxBooksAndAdmins.Items.Add($"{reader["BOOK_ID"]}, {reader["TITLE"]}, {reader["ADMIN_USERNAME"]}");
                    }
                }
            }
        }
        private void btnGenerateAdminExcelReport_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var adminData = SelectAdmins(connection);
                GenerateAdminExcelReport(adminData);
                MessageBox.Show("Admin Excel report generated successfully.");
            }
        }


        private void GenerateAdminExcelReport(DataTable data)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Admins");

                // Add table headers
                for (int col = 0; col < data.Columns.Count; col++)
                {
                    worksheet.Cell(1, col + 1).Value = data.Columns[col].ColumnName;
                }

                // Add data rows
                for (int row = 0; row < data.Rows.Count; row++)
                {
                    for (int col = 0; col < data.Columns.Count; col++)
                    {
                        worksheet.Cell(row + 2, col + 1).Value = data.Rows[row][col].ToString();
                    }
                }

                workbook.SaveAs("AdminReport.xlsx");
            }
        }

        private void btnInsertBook_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                InsertBook(connection, int.Parse(txtBookID.Text), txtBookAuthor.Text, txtBookTitle.Text,
                           DateTime.Parse(txtBookPublicationYear.Text), int.Parse(txtBookAdminId.Text), int.Parse(txtBookPublisherId.Text));
            }
        }

        private void btnDeleteAdmin_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                DeleteAdmin(connection, int.Parse(txtDeleteAdminID.Text));
            }
        }

        private void btnDeleteBook_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    int bookId = int.Parse(txtDeleteBookID.Text);
                    DeleteBook(connection, bookId);
                    MessageBox.Show("Book deleted successfully.");
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter a valid Book ID.");
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show($"An error occurred while deleting the book: {sqlEx.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An unexpected error occurred: {ex.Message}");
                }
            }
        }

        private void btnUpdateAdminEmail_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                UpdateAdminEmail(connection, int.Parse(txtUpdateAdminID.Text), txtUpdateAdminEmail.Text);
            }
        }

        private void btnUpdateBookTitle_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                UpdateBookTitle(connection, int.Parse(txtUpdateBookID.Text), txtUpdateBookTitle.Text);
            }
        }

        private void btnSelectBooksAndAdmins_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SelectBooksAndAdmins(connection);
            }
        }

        private void btnSelectBooksByPublisher_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SelectBooksByPublisher(connection, int.Parse(txtPublisherId.Text));
            }
        }

        private void btnSelectAdmins_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SelectAdmins(connection);
            }
        }

        private void btnGenerateExcel_Click_1(object sender, EventArgs e)
        {
            // Retrieve the data from the form inputs
            DataTable userData = GetUserData();

            if (userData == null || userData.Rows.Count == 0)
            {
                MessageBox.Show("No data to generate the report.");
                return;
            }

            // Create a new Excel workbook
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("UserActivity");

                // Add table headers
                for (int col = 0; col < userData.Columns.Count; col++)
                {
                    worksheet.Cell(1, col + 1).Value = userData.Columns[col].ColumnName;
                }

                // Add data rows
                for (int row = 0; row < userData.Rows.Count; row++)
                {
                    for (int col = 0; col < userData.Columns.Count; col++)
                    {
                        worksheet.Cell(row + 2, col + 1).Value = userData.Rows[row][col].ToString();
                    }
                }

                // Save the Excel file
                workbook.SaveAs("UserActivityReport.xlsx");
            }

            MessageBox.Show("Excel report generated successfully.");
        }

        private DataTable GetUserData()
        {
            DataTable dataTable = new DataTable();

            // Add columns to the DataTable corresponding to the form fields
            dataTable.Columns.Add("AdminID");
            dataTable.Columns.Add("AdminUsername");
            dataTable.Columns.Add("AdminFirstName");
            dataTable.Columns.Add("AdminLastName");
            dataTable.Columns.Add("AdminEmail");
            dataTable.Columns.Add("AdminPhone");
            dataTable.Columns.Add("BookID");
            dataTable.Columns.Add("BookAuthor");
            dataTable.Columns.Add("BookTitle");
            dataTable.Columns.Add("BookPublicationYear");
            dataTable.Columns.Add("BookAdminID");
            dataTable.Columns.Add("BookPublisherID");

            // Capture the form data
            DataRow row = dataTable.NewRow();
            row["AdminID"] = txtAdminID.Text;
            row["AdminUsername"] = txtAdminUsername.Text;
            row["AdminFirstName"] = txtAdminFirstName.Text;
            row["AdminLastName"] = txtAdminLastName.Text;
            row["AdminEmail"] = txtAdminEmail.Text;
            row["AdminPhone"] = txtAdminPhone.Text;
            row["BookID"] = txtBookID.Text;
            row["BookAuthor"] = txtBookAuthor.Text;
            row["BookTitle"] = txtBookTitle.Text;
            row["BookPublicationYear"] = txtBookPublicationYear.Text;
            row["BookAdminID"] = txtBookAdminId.Text;
            row["BookPublisherID"] = txtBookPublisherId.Text;

            dataTable.Rows.Add(row);

            return dataTable;
        }

        private void btnShowUsers_Click(object sender, EventArgs e)
        {
            {
                string query = "Select * FROM ADDS";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        SqlDataAdapter da = new SqlDataAdapter(query, conn);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        Show_All_Books_Grid.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }

        private void Show_Users_Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_to_Dashboard_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
