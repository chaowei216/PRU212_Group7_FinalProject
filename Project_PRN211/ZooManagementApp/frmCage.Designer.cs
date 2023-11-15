namespace ZooManagementApp
{
    partial class frmCage
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
            dataGridView1 = new DataGridView();
            btnDelete = new Button();
            btnLoad = new Button();
            btnNew = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            txtAreaID = new TextBox();
            txtCapacity = new TextBox();
            txtName = new TextBox();
            txtQuantity = new TextBox();
            txtID = new TextBox();
            las = new Label();
            label3 = new Label();
            label4 = new Label();
            lable2 = new Label();
            label1 = new Label();
            z = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(443, 113);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(574, 285);
            dataGridView1.TabIndex = 20;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(772, 419);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(110, 31);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(443, 419);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(110, 31);
            btnLoad.TabIndex = 18;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(607, 419);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(110, 31);
            btnNew.TabIndex = 19;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(553, 73);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(223, 23);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(443, 70);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(92, 26);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtAreaID
            // 
            txtAreaID.Location = new Point(170, 201);
            txtAreaID.Name = "txtAreaID";
            txtAreaID.Size = new Size(174, 23);
            txtAreaID.TabIndex = 11;
            // 
            // txtCapacity
            // 
            txtCapacity.Location = new Point(170, 289);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(174, 23);
            txtCapacity.TabIndex = 12;
            // 
            // txtName
            // 
            txtName.Location = new Point(170, 158);
            txtName.Name = "txtName";
            txtName.Size = new Size(174, 23);
            txtName.TabIndex = 13;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(170, 246);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(174, 23);
            txtQuantity.TabIndex = 14;
            // 
            // txtID
            // 
            txtID.Location = new Point(170, 113);
            txtID.Name = "txtID";
            txtID.Size = new Size(174, 23);
            txtID.TabIndex = 15;
            // 
            // las
            // 
            las.AutoSize = true;
            las.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            las.Location = new Point(28, 292);
            las.Name = "las";
            las.Size = new Size(98, 20);
            las.TabIndex = 5;
            las.Text = "Max Capacity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(26, 204);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 6;
            label3.Text = "Area ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(28, 249);
            label4.Name = "label4";
            label4.Size = new Size(116, 20);
            label4.TabIndex = 7;
            label4.Text = "Animal Quantity";
            // 
            // lable2
            // 
            lable2.AutoSize = true;
            lable2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lable2.Location = new Point(26, 161);
            lable2.Name = "lable2";
            lable2.Size = new Size(49, 20);
            lable2.TabIndex = 8;
            lable2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(403, 9);
            label1.Name = "label1";
            label1.Size = new Size(246, 37);
            label1.TabIndex = 9;
            label1.Text = "Cage Management";
            // 
            // z
            // 
            z.AutoSize = true;
            z.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            z.Location = new Point(26, 116);
            z.Name = "z";
            z.Size = new Size(24, 20);
            z.TabIndex = 10;
            z.Text = "ID";
            // 
            // frmCage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 480);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Controls.Add(btnLoad);
            Controls.Add(btnNew);
            Controls.Add(txtAreaID);
            Controls.Add(txtCapacity);
            Controls.Add(txtName);
            Controls.Add(txtQuantity);
            Controls.Add(txtID);
            Controls.Add(las);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(lable2);
            Controls.Add(label1);
            Controls.Add(z);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCage";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmCage";
            Load += frmCage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnDelete;
        private Button btnLoad;
        private Button btnNew;
        private TextBox txtSearch;
        private Button btnSearch;
        private TextBox txtAreaID;
        private TextBox txtCapacity;
        private TextBox txtName;
        private TextBox txtQuantity;
        private TextBox txtID;
        private Label las;
        private Label label3;
        private Label label4;
        private Label lable2;
        private Label label1;
        private Label z;
    }
}