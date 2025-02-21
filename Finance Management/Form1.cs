using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Finance_Management
{
    public partial class Form1 : Form
    {
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\OneDrive\Dokumente\Expense.mdf;Integrated Security=True;Connect Timeout=30";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.Show();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                string selectData = "SELECT * FROM USERS WHERE Username = @usern AND Password = @pass";
                SqlCommand cmd = new SqlCommand(selectData, connect);

                cmd.Parameters.AddWithValue("@usern", txtInUser.Text.Trim());
                cmd.Parameters.AddWithValue("@pass", txtPass.Text.Trim());

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();

                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Main main = new Main();
                    this.Hide();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cBoxPassShow_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = cBoxPassShow.Checked ? '\0' : '*';
        }
    }
}
