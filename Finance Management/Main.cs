using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finance_Management
{
    public partial class Main : Form
    {
        private FormDashboard dashboard; // Class-level instance
        private FormCategory cat; // Class-level instance

        public Main()
        {
            InitializeComponent();

            // Remove local declarations, use the class-level variables instead
            dashboard = new FormDashboard(); // Assign to class-level variable
            dashboard.Visible = false; // Initially set to not visible
            this.Controls.Add(dashboard); // Add it to the form

            cat = new FormCategory(); // Assign to class-level variable
            cat.Visible = false; // Initially set to not visible
            this.Controls.Add(cat); // Add it to the form
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            dashboard.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cat.Visible = false;
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 logout = new Form1();
            if (MessageBox.Show ("Are you sure to log out?", "ConfirmationMessage", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                ==DialogResult.Yes)
            {
                this.Close();
                logout.Show();
            }
            
            
        }
    }
}
