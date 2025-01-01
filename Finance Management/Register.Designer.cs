namespace Finance_Management
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            panel1 = new Panel();
            btnLoginForm = new Button();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            btnRegister = new Button();
            cBoxPassShow = new CheckBox();
            txtPass = new TextBox();
            txtUpUser = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtConfirm = new TextBox();
            label1 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(btnLoginForm);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 332);
            panel1.TabIndex = 0;
            // 
            // btnLoginForm
            // 
            btnLoginForm.BackColor = Color.SeaGreen;
            btnLoginForm.ForeColor = SystemColors.ButtonFace;
            btnLoginForm.Location = new Point(13, 291);
            btnLoginForm.Name = "btnLoginForm";
            btnLoginForm.Size = new Size(173, 27);
            btnLoginForm.TabIndex = 7;
            btnLoginForm.Text = "Sign in";
            btnLoginForm.UseVisualStyleBackColor = false;
            btnLoginForm.Click += btnLoginForm_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(16, 263);
            label3.Name = "label3";
            label3.Size = new Size(170, 25);
            label3.TabIndex = 6;
            label3.Text = "Already logged in?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(1, 118);
            label2.Name = "label2";
            label2.Size = new Size(198, 25);
            label2.TabIndex = 5;
            label2.Text = "Finance Management";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(64, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.SeaGreen;
            btnRegister.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = SystemColors.ButtonFace;
            btnRegister.Location = new Point(206, 295);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(90, 37);
            btnRegister.TabIndex = 13;
            btnRegister.Text = "Sign Up";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // cBoxPassShow
            // 
            cBoxPassShow.AutoSize = true;
            cBoxPassShow.Location = new Point(377, 286);
            cBoxPassShow.Name = "cBoxPassShow";
            cBoxPassShow.Size = new Size(118, 21);
            cBoxPassShow.TabIndex = 12;
            cBoxPassShow.Text = "Show Password";
            cBoxPassShow.UseVisualStyleBackColor = true;
            cBoxPassShow.CheckedChanged += cBoxPassShow_CheckedChanged;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(222, 174);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(237, 25);
            txtPass.TabIndex = 10;
            // 
            // txtUpUser
            // 
            txtUpUser.Location = new Point(222, 122);
            txtUpUser.Name = "txtUpUser";
            txtUpUser.Size = new Size(237, 25);
            txtUpUser.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(222, 150);
            label5.Name = "label5";
            label5.Size = new Size(76, 21);
            label5.TabIndex = 8;
            label5.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(222, 98);
            label4.Name = "label4";
            label4.Size = new Size(42, 21);
            label4.TabIndex = 9;
            label4.Text = "User";
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new Point(222, 230);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.PasswordChar = '*';
            txtConfirm.Size = new Size(237, 25);
            txtConfirm.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(222, 206);
            label1.Name = "label1";
            label1.Size = new Size(134, 21);
            label1.TabIndex = 14;
            label1.Text = "confirm Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(206, 39);
            label6.Name = "label6";
            label6.Size = new Size(78, 25);
            label6.TabIndex = 16;
            label6.Text = "Sign Up";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 332);
            Controls.Add(label6);
            Controls.Add(txtConfirm);
            Controls.Add(label1);
            Controls.Add(btnRegister);
            Controls.Add(panel1);
            Controls.Add(cBoxPassShow);
            Controls.Add(txtPass);
            Controls.Add(label4);
            Controls.Add(txtUpUser);
            Controls.Add(label5);
            Name = "Register";
            Text = "Register";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnLoginForm;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private Button btnRegister;
        private CheckBox cBoxPassShow;
        private TextBox txtPass;
        private TextBox txtUpUser;
        private Label label5;
        private Label label4;
        private TextBox txtConfirm;
        private Label label1;
        private Label label6;
    }
}