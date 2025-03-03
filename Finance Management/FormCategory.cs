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
using Microsoft.Data.SqlClient;

namespace Finance_Management
{
    public partial class FormCategory : UserControl
    {
        string stringConnect = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\OneDrive\Dokumente\Expense.mdf;Integrated Security=True;Connect Timeout=30");
        public FormCategory()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || cbBoxType.SelectedIndex == -1 || cbBoxStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all blank fields!");
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(stringConnect))
                {
                    connect.Open();

                    string insertData = "INSERT INTO CATEGORY(category, type, status, DoC)"+
                        "VALUES (@cat, @type, @status, @date)";

                    using (SqlCommand cmd = new SqlCommand(insertData, connect))
                    {
                        cmd.Parameters.AddWithValue("@cat", txtName.Text.Trim());
                        cmd.Parameters.AddWithValue("@type", cbBoxType.SelectedItem);
                        cmd.Parameters.AddWithValue("@status", cbBoxStatus.SelectedItem);

                        DateTime today = DateTime.Today;
                        cmd.Parameters.AddWithValue("@date", today);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Added successfully");
                    }
                }
            }
        }
    }
}
