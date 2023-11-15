namespace ZooManagementApp
{
    partial class frmUser
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
            btnDelete = new Button();
            btnLoad = new Button();
            btnNew = new Button();
            dataGridView1 = new DataGridView();
            txtSearch = new TextBox();
            btnSearch = new Button();
            txtGender = new TextBox();
            txtCountAnimal = new TextBox();
            txtRole = new TextBox();
            txtPhone = new TextBox();
            txtLastName = new TextBox();
            txtStartDate = new TextBox();
            txtAddress = new TextBox();
            txtEmail = new TextBox();
            txtFirstName = new TextBox();
            txtID = new TextBox();
            label9 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            label4 = new Label();
            label6 = new Label();
            label3 = new Label();
            lable2 = new Label();
            label2 = new Label();
            label1 = new Label();
            a = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(650, 432);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(110, 31);
            btnDelete.TabIndex = 39;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLoad
            // 
            btnLoad.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLoad.Location = new Point(367, 432);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(110, 31);
            btnLoad.TabIndex = 40;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnNew.Location = new Point(510, 432);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(110, 31);
            btnNew.TabIndex = 41;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(367, 118);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(652, 287);
            dataGridView1.TabIndex = 38;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(476, 77);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(284, 23);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(367, 77);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(92, 26);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtGender
            // 
            txtGender.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtGender.Location = new Point(740, 223);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(174, 27);
            txtGender.TabIndex = 28;
            // 
            // txtCountAnimal
            // 
            txtCountAnimal.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCountAnimal.Location = new Point(133, 389);
            txtCountAnimal.Name = "txtCountAnimal";
            txtCountAnimal.Size = new Size(174, 27);
            txtCountAnimal.TabIndex = 26;
            // 
            // txtRole
            // 
            txtRole.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtRole.Location = new Point(133, 344);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(174, 27);
            txtRole.TabIndex = 30;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(133, 256);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(174, 27);
            txtPhone.TabIndex = 29;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.Location = new Point(133, 212);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(174, 27);
            txtLastName.TabIndex = 34;
            // 
            // txtStartDate
            // 
            txtStartDate.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtStartDate.Location = new Point(133, 436);
            txtStartDate.Name = "txtStartDate";
            txtStartDate.Size = new Size(174, 27);
            txtStartDate.TabIndex = 33;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(133, 301);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(174, 27);
            txtAddress.TabIndex = 32;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(133, 120);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(174, 27);
            txtEmail.TabIndex = 31;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstName.Location = new Point(133, 166);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(174, 27);
            txtFirstName.TabIndex = 35;
            // 
            // txtID
            // 
            txtID.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtID.Location = new Point(133, 77);
            txtID.Name = "txtID";
            txtID.Size = new Size(174, 27);
            txtID.TabIndex = 36;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(40, 396);
            label9.Name = "label9";
            label9.Size = new Size(92, 20);
            label9.TabIndex = 14;
            label9.Text = "Train Animal";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(606, 225);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 15;
            label5.Text = "Gender";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(40, 347);
            label7.Name = "label7";
            label7.Size = new Size(39, 20);
            label7.TabIndex = 17;
            label7.Text = "Role";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(40, 439);
            label8.Name = "label8";
            label8.Size = new Size(76, 20);
            label8.TabIndex = 21;
            label8.Text = "Start Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(40, 215);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 22;
            label4.Text = "Last Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(40, 304);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 20;
            label6.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(40, 259);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 16;
            label3.Text = "Phone";
            // 
            // lable2
            // 
            lable2.AutoSize = true;
            lable2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lable2.Location = new Point(40, 123);
            lable2.Name = "lable2";
            lable2.Size = new Size(46, 20);
            lable2.TabIndex = 19;
            lable2.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(40, 168);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 25;
            label2.Text = "First Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(381, 9);
            label1.Name = "label1";
            label1.Size = new Size(239, 37);
            label1.TabIndex = 23;
            label1.Text = "User Management";
            // 
            // a
            // 
            a.AutoSize = true;
            a.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            a.Location = new Point(40, 80);
            a.Name = "a";
            a.Size = new Size(24, 20);
            a.TabIndex = 24;
            a.Text = "ID";
            // 
            // frmUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 480);
            ControlBox = false;
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnLoad);
            Controls.Add(btnNew);
            Controls.Add(dataGridView1);
            Controls.Add(txtGender);
            Controls.Add(txtCountAnimal);
            Controls.Add(txtRole);
            Controls.Add(txtPhone);
            Controls.Add(txtLastName);
            Controls.Add(txtStartDate);
            Controls.Add(txtAddress);
            Controls.Add(txtEmail);
            Controls.Add(txtFirstName);
            Controls.Add(txtID);
            Controls.Add(label9);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(lable2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(a);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmUser";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmUser";
            Load += frmUser_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private Button btnLoad;
        private Button btnNew;
        private DataGridView dataGridView1;
        private TextBox txtSearch;
        private Button btnSearch;
        private TextBox txtGender;
        private TextBox txtCountAnimal;
        private TextBox txtRole;
        private TextBox txtPhone;
        private TextBox txtLastName;
        private TextBox txtStartDate;
        private TextBox txtAddress;
        private TextBox txtEmail;
        private TextBox txtFirstName;
        private TextBox txtID;
        private Label label9;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label4;
        private Label label6;
        private Label label3;
        private Label lable2;
        private Label label2;
        private Label label1;
        private Label a;
    }
}