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

            DisplayList();
        }

        public void DisplayList()
        {
            catData cData = new catData();
            List<catData> listData = cData.CatListData;
            dgvCat.DataSource = listData;
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

                    string insertData = "INSERT INTO CATEGORY(category, type, status, DoC)" +
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
            DisplayList();
        }

        private int getID;
        private void dgvCat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvCat.Rows[e.RowIndex];

            getID = Convert.ToInt32(row.Cells[0].Value);
            txtName.Text = row.Cells[1].Value.ToString();
            cbBoxType.SelectedItem = row.Cells[2].Value.ToString();
            cbBoxStatus.SelectedItem = row.Cells[3].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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
                    string updateData = "UPDATE category SET category @category, type = @type, status = @status WHERE id = @Id";

                    using (SqlCommand cmd = new SqlCommand(updateData, connect))
                    {
                        cmd.Parameters.AddWithValue("@category", txtName.Text.Trim());
                        cmd.Parameters.AddWithValue("@type", cbBoxType.SelectedItem);
                        cmd.Parameters.AddWithValue("@status", cbBoxStatus.SelectedItem);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Updated successfully");
                    }

                    connect.Close();
                }
            }
            DisplayList();
        }

        private void btnDel_Click(object sender, EventArgs e)
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
                    string updateData = "DELETE category WHERE id = @Id";

                    using (SqlCommand cmd = new SqlCommand(updateData, connect))
                    {
                        cmd.Parameters.AddWithValue("@Id", getID);
                        cmd.ExecuteNonQuery();
                        clearFields();
                        MessageBox.Show("Deleted successfully");
                    }

                    connect.Close();
                }
            }
            DisplayList();
        }

        private void clearFields()
        {
            txtName.Clear();
            cbBoxType.SelectedIndex = -1;
            cbBoxStatus.SelectedIndex = -1;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}
