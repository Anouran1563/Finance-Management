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
        public Main()
        {
            InitializeComponent();
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            FormDashboard formDashboard = new FormDashboard();
            formDashboard.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormCategory formCategory = new FormCategory();
            formCategory.Show();
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
