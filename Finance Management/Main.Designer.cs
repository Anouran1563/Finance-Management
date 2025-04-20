namespace Finance_Management
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            panel1 = new Panel();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnLogout = new Button();
            btnExpenses = new Button();
            btnIncome = new Button();
            btnAdd = new Button();
            btnDash = new Button();
            pictureBox1 = new PictureBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            formDashboard1 = new FormDashboard();
            formCategory1 = new FormCategory();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnExpenses);
            panel1.Controls.Add(btnIncome);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnDash);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(255, 529);
            panel1.TabIndex = 0;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(36, 476);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(16, 16);
            pictureBox6.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox6.TabIndex = 3;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(3, 387);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(53, 51);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 3;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(3, 320);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(53, 51);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 253);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(53, 51);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 179);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(53, 51);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.SeaGreen;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = SystemColors.ButtonFace;
            btnLogout.Location = new Point(62, 464);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(181, 30);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += button5_Click;
            // 
            // btnExpenses
            // 
            btnExpenses.BackColor = Color.SeaGreen;
            btnExpenses.FlatStyle = FlatStyle.Flat;
            btnExpenses.ForeColor = SystemColors.ButtonFace;
            btnExpenses.Location = new Point(62, 387);
            btnExpenses.Name = "btnExpenses";
            btnExpenses.Size = new Size(181, 51);
            btnExpenses.TabIndex = 1;
            btnExpenses.Text = "Expenses";
            btnExpenses.UseVisualStyleBackColor = false;
            btnExpenses.Click += btnExpenses_Click;
            // 
            // btnIncome
            // 
            btnIncome.BackColor = Color.SeaGreen;
            btnIncome.FlatStyle = FlatStyle.Flat;
            btnIncome.ForeColor = SystemColors.ButtonFace;
            btnIncome.Location = new Point(62, 320);
            btnIncome.Name = "btnIncome";
            btnIncome.Size = new Size(181, 51);
            btnIncome.TabIndex = 1;
            btnIncome.Text = "Income";
            btnIncome.UseVisualStyleBackColor = false;
            btnIncome.Click += btnIncome_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.SeaGreen;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = SystemColors.ButtonFace;
            btnAdd.Location = new Point(62, 253);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(181, 51);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add Category";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDash
            // 
            btnDash.BackColor = Color.SeaGreen;
            btnDash.FlatStyle = FlatStyle.Flat;
            btnDash.ForeColor = SystemColors.ButtonFace;
            btnDash.Location = new Point(62, 179);
            btnDash.Name = "btnDash";
            btnDash.Size = new Size(181, 51);
            btnDash.TabIndex = 1;
            btnDash.Text = "Dashborad";
            btnDash.UseVisualStyleBackColor = false;
            btnDash.Click += btnDash_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.eyes_office_women_glasses_icon;
            pictureBox1.Location = new Point(62, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(129, 129);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // formDashboard1
            // 
            formDashboard1.Location = new Point(249, 0);
            formDashboard1.Name = "formDashboard1";
            formDashboard1.Size = new Size(907, 526);
            formDashboard1.TabIndex = 1;
            // 
            // formCategory1
            // 
            formCategory1.BackColor = SystemColors.InactiveCaption;
            formCategory1.Location = new Point(249, 1);
            formCategory1.Name = "formCategory1";
            formCategory1.Size = new Size(923, 529);
            formCategory1.TabIndex = 2;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 523);
            Controls.Add(formCategory1);
            Controls.Add(formDashboard1);
            Controls.Add(panel1);
            Name = "Main";
            Text = "Main";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnExpenses;
        private Button btnIncome;
        private Button btnAdd;
        private Button btnDash;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Button btnLogout;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox6;
        private FormDashboard formDashboard1;
        private FormCategory formCategory1;
    }
}