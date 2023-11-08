namespace ZooManagementApp
{
    partial class frmCageDetail
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
            btnCancel = new Button();
            btnSave = new Button();
            cboAreaID = new ComboBox();
            txtCapacity = new TextBox();
            txtQuantity = new TextBox();
            txtName = new TextBox();
            txtID = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            lable2 = new Label();
            a = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(196, 359);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(91, 30);
            btnCancel.TabIndex = 20;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(29, 359);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(91, 30);
            btnSave.TabIndex = 21;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cboAreaID
            // 
            cboAreaID.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cboAreaID.FormattingEnabled = true;
            cboAreaID.Location = new Point(136, 289);
            cboAreaID.Name = "cboAreaID";
            cboAreaID.Size = new Size(174, 28);
            cboAreaID.TabIndex = 19;
            // 
            // txtCapacity
            // 
            txtCapacity.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCapacity.Location = new Point(136, 219);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(174, 27);
            txtCapacity.TabIndex = 15;
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuantity.Location = new Point(136, 151);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(174, 27);
            txtQuantity.TabIndex = 16;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(136, 86);
            txtName.Name = "txtName";
            txtName.Size = new Size(174, 27);
            txtName.TabIndex = 17;
            // 
            // txtID
            // 
            txtID.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtID.Location = new Point(136, 26);
            txtID.Name = "txtID";
            txtID.Size = new Size(174, 27);
            txtID.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(20, 222);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 11;
            label2.Text = "Max Capacity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(20, 292);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 10;
            label3.Text = "Area ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(20, 154);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 12;
            label1.Text = "Quantity";
            // 
            // lable2
            // 
            lable2.AutoSize = true;
            lable2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lable2.Location = new Point(20, 89);
            lable2.Name = "lable2";
            lable2.Size = new Size(49, 20);
            lable2.TabIndex = 13;
            lable2.Text = "Name";
            // 
            // a
            // 
            a.AutoSize = true;
            a.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            a.Location = new Point(20, 29);
            a.Name = "a";
            a.Size = new Size(24, 20);
            a.TabIndex = 14;
            a.Text = "ID";
            // 
            // frmCageDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 410);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cboAreaID);
            Controls.Add(txtCapacity);
            Controls.Add(txtQuantity);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(lable2);
            Controls.Add(a);
            Name = "frmCageDetail";
            Text = "frmCageDetail";
            Load += frmCageDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private ComboBox cboAreaID;
        private TextBox txtCapacity;
        private TextBox txtQuantity;
        private TextBox txtName;
        private TextBox txtID;
        private Label label2;
        private Label label3;
        private Label label1;
        private Label lable2;
        private Label a;
    }
}