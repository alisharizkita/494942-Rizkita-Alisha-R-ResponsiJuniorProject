namespace WinFormsApp1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtName = new TextBox();
            txtTelephone = new TextBox();
            txtAddress = new TextBox();
            txtDep = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dgvData = new DataGridView();
            btnLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(317, 28);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 0;
            label1.Text = "Employee Data";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 75);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 112);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 2;
            label3.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 148);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 3;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 184);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 4;
            label5.Text = "Department";
            // 
            // txtName
            // 
            txtName.Location = new Point(156, 72);
            txtName.Name = "txtName";
            txtName.Size = new Size(315, 23);
            txtName.TabIndex = 5;
            // 
            // txtTelephone
            // 
            txtTelephone.Location = new Point(156, 109);
            txtTelephone.Name = "txtTelephone";
            txtTelephone.Size = new Size(315, 23);
            txtTelephone.TabIndex = 6;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(156, 145);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(315, 23);
            txtAddress.TabIndex = 7;
            // 
            // txtDep
            // 
            txtDep.Location = new Point(156, 181);
            txtDep.Name = "txtDep";
            txtDep.Size = new Size(315, 23);
            txtDep.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(572, 72);
            label6.Name = "label6";
            label6.Size = new Size(90, 15);
            label6.TabIndex = 9;
            label6.Text = "ID Department :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(529, 97);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 10;
            label7.Text = "HR : HR";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(529, 117);
            label8.Name = "label8";
            label8.Size = new Size(85, 15);
            label8.TabIndex = 11;
            label8.Text = "ENG : Engineer";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(529, 137);
            label9.Name = "label9";
            label9.Size = new Size(90, 15);
            label9.TabIndex = 12;
            label9.Text = "DEV : Developer";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(529, 156);
            label10.Name = "label10";
            label10.Size = new Size(126, 15);
            label10.TabIndex = 13;
            label10.Text = "PM : Product Manager";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(529, 175);
            label11.Name = "label11";
            label11.Size = new Size(75, 15);
            label11.TabIndex = 14;
            label11.Text = "FIN : Finance";
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.FromArgb(192, 255, 192);
            btnInsert.Location = new Point(156, 220);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(112, 33);
            btnInsert.TabIndex = 15;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 255, 192);
            btnUpdate.Location = new Point(291, 220);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 33);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.AutoEllipsis = true;
            btnDelete.BackColor = Color.FromArgb(255, 192, 192);
            btnDelete.Location = new Point(423, 220);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 33);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(45, 259);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(705, 164);
            dgvData.TabIndex = 18;
            dgvData.CellClick += dgvData_CellClick;
            // 
            // btnLoad
            // 
            btnLoad.AutoEllipsis = true;
            btnLoad.BackColor = Color.FromArgb(192, 255, 255);
            btnLoad.Location = new Point(550, 220);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(112, 33);
            btnLoad.TabIndex = 19;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLoad);
            Controls.Add(dgvData);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtDep);
            Controls.Add(txtAddress);
            Controls.Add(txtTelephone);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtName;
        private TextBox txtTelephone;
        private TextBox txtAddress;
        private TextBox txtDep;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dgvData;
        private Button btnLoad;
    }
}
