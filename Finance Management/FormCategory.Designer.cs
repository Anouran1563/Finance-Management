﻿namespace Finance_Management
{
    partial class FormCategory
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel2 = new Panel();
            dgvCat = new DataGridView();
            label4 = new Label();
            panel1 = new Panel();
            btnDel = new Button();
            btnClear = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            cbBoxType = new ComboBox();
            cbBoxStatus = new ComboBox();
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCat).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Controls.Add(dgvCat);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(271, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(621, 501);
            panel2.TabIndex = 3;
            // 
            // dgvCat
            // 
            dgvCat.AllowUserToAddRows = false;
            dgvCat.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dgvCat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCat.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.SeaGreen;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvCat.DefaultCellStyle = dataGridViewCellStyle3;
            dgvCat.Enabled = false;
            dgvCat.EnableHeadersVisualStyles = false;
            dgvCat.Location = new Point(19, 45);
            dgvCat.Name = "dgvCat";
            dgvCat.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvCat.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvCat.RowHeadersVisible = false;
            dgvCat.Size = new Size(575, 442);
            dgvCat.TabIndex = 6;
            dgvCat.CellClick += dgvCat_CellClick;
            dgvCat.CellContentClick += dgvCat_CellClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonFace;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(19, 0);
            label4.Name = "label4";
            label4.Size = new Size(169, 32);
            label4.TabIndex = 5;
            label4.Text = "Categories List";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(btnDel);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(cbBoxType);
            panel1.Controls.Add(cbBoxStatus);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(8, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(244, 517);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.SeaGreen;
            btnDel.FlatStyle = FlatStyle.Flat;
            btnDel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnDel.ForeColor = SystemColors.ButtonFace;
            btnDel.Location = new Point(139, 327);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(90, 45);
            btnDel.TabIndex = 9;
            btnDel.Text = "Remove";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.SeaGreen;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnClear.ForeColor = SystemColors.ButtonFace;
            btnClear.Location = new Point(15, 327);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(90, 45);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.SeaGreen;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnUpdate.ForeColor = SystemColors.ButtonFace;
            btnUpdate.Location = new Point(139, 246);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 46);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.SeaGreen;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnAdd.ForeColor = SystemColors.ButtonFace;
            btnAdd.Location = new Point(15, 246);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 46);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // cbBoxType
            // 
            cbBoxType.BackColor = SystemColors.ButtonFace;
            cbBoxType.FlatStyle = FlatStyle.Flat;
            cbBoxType.ForeColor = SystemColors.ActiveCaptionText;
            cbBoxType.FormattingEnabled = true;
            cbBoxType.Items.AddRange(new object[] { "income", "expense" });
            cbBoxType.Location = new Point(15, 119);
            cbBoxType.Name = "cbBoxType";
            cbBoxType.Size = new Size(121, 25);
            cbBoxType.TabIndex = 7;
            // 
            // cbBoxStatus
            // 
            cbBoxStatus.BackColor = SystemColors.ButtonFace;
            cbBoxStatus.FlatStyle = FlatStyle.Flat;
            cbBoxStatus.ForeColor = SystemColors.ActiveCaptionText;
            cbBoxStatus.FormattingEnabled = true;
            cbBoxStatus.Items.AddRange(new object[] { "active", "inactive" });
            cbBoxStatus.Location = new Point(15, 182);
            cbBoxStatus.Name = "cbBoxStatus";
            cbBoxStatus.Size = new Size(121, 25);
            cbBoxStatus.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(15, 10);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 5;
            label1.Text = "Name";
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.ButtonFace;
            txtName.ForeColor = SystemColors.ActiveCaptionText;
            txtName.Location = new Point(15, 45);
            txtName.Name = "txtName";
            txtName.Size = new Size(121, 25);
            txtName.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(15, 84);
            label2.Name = "label2";
            label2.Size = new Size(65, 32);
            label2.TabIndex = 4;
            label2.Text = "Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonFace;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(15, 147);
            label3.Name = "label3";
            label3.Size = new Size(78, 32);
            label3.TabIndex = 3;
            label3.Text = "Status";
            // 
            // FormCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormCategory";
            Size = new Size(923, 533);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCat).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Button btnDel;
        private Button btnClear;
        private Button btnUpdate;
        private Button btnAdd;
        private ComboBox cbBoxStatus;
        private Label label1;
        private TextBox txtName;
        private Label label2;
        private Label label3;
        private DataGridView dgvCat;
        private Label label4;
        private ComboBox cbBoxType;
    }
}
