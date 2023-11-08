namespace ZooManagementApp
{
    partial class frmUserDetail
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
            btnSave = new Button();
            btnCancel = new Button();
            cboGender = new ComboBox();
            cboRole = new ComboBox();
            txtCountAnimal = new TextBox();
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
            a = new Label();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(387, 389);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 31);
            btnSave.TabIndex = 52;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(564, 389);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 31);
            btnCancel.TabIndex = 53;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // cboGender
            // 
            cboGender.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cboGender.FormattingEnabled = true;
            cboGender.Items.AddRange(new object[] { "Male", "Female" });
            cboGender.Location = new Point(500, 174);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(174, 28);
            cboGender.TabIndex = 51;
            // 
            // cboRole
            // 
            cboRole.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cboRole.FormattingEnabled = true;
            cboRole.Location = new Point(115, 323);
            cboRole.Name = "cboRole";
            cboRole.Size = new Size(174, 28);
            cboRole.TabIndex = 50;
            // 
            // txtCountAnimal
            // 
            txtCountAnimal.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCountAnimal.Location = new Point(500, 319);
            txtCountAnimal.Name = "txtCountAnimal";
            txtCountAnimal.Size = new Size(174, 27);
            txtCountAnimal.TabIndex = 43;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(115, 178);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(174, 27);
            txtPhone.TabIndex = 42;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.Location = new Point(500, 96);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(174, 27);
            txtLastName.TabIndex = 47;
            // 
            // txtStartDate
            // 
            txtStartDate.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtStartDate.Location = new Point(500, 247);
            txtStartDate.Name = "txtStartDate";
            txtStartDate.Size = new Size(174, 27);
            txtStartDate.TabIndex = 46;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(115, 247);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(174, 27);
            txtAddress.TabIndex = 45;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(115, 100);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(174, 27);
            txtEmail.TabIndex = 44;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstName.Location = new Point(500, 18);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(174, 27);
            txtFirstName.TabIndex = 48;
            // 
            // txtID
            // 
            txtID.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtID.Location = new Point(115, 21);
            txtID.Name = "txtID";
            txtID.Size = new Size(174, 27);
            txtID.TabIndex = 49;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(366, 321);
            label9.Name = "label9";
            label9.Size = new Size(92, 20);
            label9.TabIndex = 35;
            label9.Text = "Train Animal";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(366, 177);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 34;
            label5.Text = "Gender";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(22, 322);
            label7.Name = "label7";
            label7.Size = new Size(39, 20);
            label7.TabIndex = 33;
            label7.Text = "Role";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(366, 249);
            label8.Name = "label8";
            label8.Size = new Size(76, 20);
            label8.TabIndex = 39;
            label8.Text = "Start Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(366, 99);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 38;
            label4.Text = "Last Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(22, 250);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 37;
            label6.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(22, 181);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 32;
            label3.Text = "Phone";
            // 
            // lable2
            // 
            lable2.AutoSize = true;
            lable2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lable2.Location = new Point(22, 103);
            lable2.Name = "lable2";
            lable2.Size = new Size(46, 20);
            lable2.TabIndex = 36;
            lable2.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(366, 20);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 41;
            label2.Text = "First Name";
            // 
            // a
            // 
            a.AutoSize = true;
            a.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            a.Location = new Point(22, 24);
            a.Name = "a";
            a.Size = new Size(24, 20);
            a.TabIndex = 40;
            a.Text = "ID";
            // 
            // frmUserDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 438);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(cboGender);
            Controls.Add(cboRole);
            Controls.Add(txtCountAnimal);
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
            Controls.Add(a);
            Name = "frmUserDetail";
            Text = "frmUserDetail";
            Load += frmUserDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnCancel;
        private ComboBox cboGender;
        private ComboBox cboRole;
        private TextBox txtCountAnimal;
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
        private Label a;
    }
}