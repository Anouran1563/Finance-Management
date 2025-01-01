namespace Finance_Management
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            panel1 = new Panel();
            btnRegisterForm = new Button();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            txtInUser = new TextBox();
            txtPass = new TextBox();
            cBoxPassShow = new CheckBox();
            btnLogin = new Button();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(492, 9);
            label1.Name = "label1";
            label1.Size = new Size(19, 21);
            label1.TabIndex = 1;
            label1.Text = "X";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(btnRegisterForm);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 332);
            panel1.TabIndex = 0;
            // 
            // btnRegisterForm
            // 
            btnRegisterForm.BackColor = Color.SeaGreen;
            btnRegisterForm.ForeColor = SystemColors.ButtonFace;
            btnRegisterForm.Location = new Point(12, 293);
            btnRegisterForm.Name = "btnRegisterForm";
            btnRegisterForm.Size = new Size(173, 27);
            btnRegisterForm.TabIndex = 3;
            btnRegisterForm.Text = "Sign up";
            btnRegisterForm.UseVisualStyleBackColor = false;
            btnRegisterForm.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(37, 265);
            label3.Name = "label3";
            label3.Size = new Size(122, 25);
            label3.TabIndex = 2;
            label3.Text = "Register here";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(0, 120);
            label2.Name = "label2";
            label2.Size = new Size(198, 25);
            label2.TabIndex = 1;
            label2.Text = "Finance Management";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(63, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(222, 102);
            label4.Name = "label4";
            label4.Size = new Size(42, 21);
            label4.TabIndex = 2;
            label4.Text = "User";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(222, 154);
            label5.Name = "label5";
            label5.Size = new Size(76, 21);
            label5.TabIndex = 2;
            label5.Text = "Password";
            // 
            // txtInUser
            // 
            txtInUser.Location = new Point(222, 126);
            txtInUser.Name = "txtInUser";
            txtInUser.Size = new Size(237, 25);
            txtInUser.TabIndex = 3;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Dubai", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPass.Location = new Point(222, 178);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(237, 29);
            txtPass.TabIndex = 3;
            // 
            // cBoxPassShow
            // 
            cBoxPassShow.AutoSize = true;
            cBoxPassShow.Location = new Point(393, 220);
            cBoxPassShow.Name = "cBoxPassShow";
            cBoxPassShow.Size = new Size(118, 21);
            cBoxPassShow.TabIndex = 4;
            cBoxPassShow.Text = "Show Password";
            cBoxPassShow.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.SeaGreen;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.ButtonFace;
            btnLogin.Location = new Point(222, 241);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(90, 37);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(222, 41);
            label6.Name = "label6";
            label6.Size = new Size(59, 25);
            label6.TabIndex = 6;
            label6.Text = "Login";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 332);
            Controls.Add(label6);
            Controls.Add(btnLogin);
            Controls.Add(cBoxPassShow);
            Controls.Add(txtPass);
            Controls.Add(txtInUser);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Button btnRegisterForm;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtInUser;
        private TextBox txtPass;
        private CheckBox cBoxPassShow;
        private Button btnLogin;
        private Label label6;
    }
}
