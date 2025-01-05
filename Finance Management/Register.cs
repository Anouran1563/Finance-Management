using System.Data;
using Microsoft.Data.SqlClient;

namespace Finance_Management
{
    public partial class Register : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\OneDrive\Dokumente\Expense.mdf;Integrated Security=True;Connect Timeout=30");

        public Register()
        {
            InitializeComponent();
        }

        public bool CheckConnection()
        {
            return (connect.State == ConnectionState.Closed) ? true : false;
        }

        private void btnLoginForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUpUser.Text == "" || txtPass.Text == "" || txtConfirm.Text == "")
            {
                MessageBox.Show("Please fill all blank fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    connect.Open();
                    //Check if Username already exists
                    string selectUsername = "SELECT * FROM USERS WHERE Username = @usern";

                    using (SqlCommand checkUser = new SqlCommand(selectUsername, connect))
                    {
                        checkUser.Parameters.AddWithValue("@usern", txtUpUser.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        if(table.Rows.Count != 0)
                        {
                            //Capitalize first letter
                            string tempUsern = txtUpUser.Text.Substring(0, 1).ToUpper() + txtUpUser.Text.Substring(1);
                            MessageBox.Show(tempUsern + "is already existing", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (txtPass.Text.Length < 8)
                        {
                            MessageBox.Show("Invalid Password", "Please input at least 8 characters");
                        }
                        else if (txtPass.Text != txtConfirm.Text)
                        {
                            MessageBox.Show("Password doesnt match." + Environment.NewLine + "Please verify your confirmation input.");
                        }
                        else
                        {
                            string insertData = "INSERT INTO USERS (Username, Password, Date_Create) VALUES(@usern, @pass, @Date_Create)";

                            using (SqlCommand insertUser = new SqlCommand(insertData, connect))
                            {
                                insertUser.Parameters.AddWithValue("@usern", txtUpUser.Text.Trim());
                                insertUser.Parameters.AddWithValue("@pass", txtPass.Text.Trim());

                                DateTime today = DateTime.Now; //Get time now
                                insertUser.Parameters.AddWithValue("@Date_Create", today);

                                insertUser.ExecuteNonQuery();

                                MessageBox.Show("Registration successfully!", "Information message");
                                Form1 login = new Form1();
                                this.Hide();
                            }
                        }
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show($"An error occoured: {ex.Message}\n\nStack Trace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (connect.State == ConnectionState.Open)
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void cBoxPassShow_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = cBoxPassShow.Checked ? '\0' : '*';
            txtConfirm.PasswordChar = cBoxPassShow.Checked ? '\0' : '*';
        }
    }
}
