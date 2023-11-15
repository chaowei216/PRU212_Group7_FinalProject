namespace ZooManagementApp
{
    partial class frmFood
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
            lbFoodManagement = new Label();
            lbFoodId = new Label();
            lbFoodName = new Label();
            lbQuantity = new Label();
            lbImportDate = new Label();
            lbExpiredDate = new Label();
            lbCategoryName = new Label();
            dgvFoodList = new DataGridView();
            txtFoodId = new TextBox();
            txtFoodName = new TextBox();
            txtSearch = new TextBox();
            lbSearch = new Label();
            btnNew = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            btnSave = new Button();
            nudQuantity = new NumericUpDown();
            dtpImportDate = new DateTimePicker();
            dtpExpiredDate = new DateTimePicker();
            cboCategoryName = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvFoodList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            SuspendLayout();
            // 
            // lbFoodManagement
            // 
            lbFoodManagement.AutoSize = true;
            lbFoodManagement.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbFoodManagement.Location = new Point(392, 19);
            lbFoodManagement.Name = "lbFoodManagement";
            lbFoodManagement.Size = new Size(208, 30);
            lbFoodManagement.TabIndex = 0;
            lbFoodManagement.Text = "Food Management";
            // 
            // lbFoodId
            // 
            lbFoodId.AutoSize = true;
            lbFoodId.Location = new Point(40, 99);
            lbFoodId.Name = "lbFoodId";
            lbFoodId.Size = new Size(48, 15);
            lbFoodId.TabIndex = 1;
            lbFoodId.Text = "Food ID";
            // 
            // lbFoodName
            // 
            lbFoodName.AutoSize = true;
            lbFoodName.Location = new Point(40, 140);
            lbFoodName.Name = "lbFoodName";
            lbFoodName.Size = new Size(69, 15);
            lbFoodName.TabIndex = 2;
            lbFoodName.Text = "Food Name";
            // 
            // lbQuantity
            // 
            lbQuantity.AutoSize = true;
            lbQuantity.Location = new Point(40, 181);
            lbQuantity.Name = "lbQuantity";
            lbQuantity.Size = new Size(53, 15);
            lbQuantity.TabIndex = 3;
            lbQuantity.Text = "Quantity";
            // 
            // lbImportDate
            // 
            lbImportDate.AutoSize = true;
            lbImportDate.Location = new Point(40, 222);
            lbImportDate.Name = "lbImportDate";
            lbImportDate.Size = new Size(70, 15);
            lbImportDate.TabIndex = 4;
            lbImportDate.Text = "Import Date";
            // 
            // lbExpiredDate
            // 
            lbExpiredDate.AutoSize = true;
            lbExpiredDate.Location = new Point(40, 261);
            lbExpiredDate.Name = "lbExpiredDate";
            lbExpiredDate.Size = new Size(70, 15);
            lbExpiredDate.TabIndex = 5;
            lbExpiredDate.Text = "ExpiredDate";
            // 
            // lbCategoryName
            // 
            lbCategoryName.AutoSize = true;
            lbCategoryName.Location = new Point(40, 298);
            lbCategoryName.Name = "lbCategoryName";
            lbCategoryName.Size = new Size(90, 15);
            lbCategoryName.TabIndex = 6;
            lbCategoryName.Text = "Category Name";
            // 
            // dgvFoodList
            // 
            dgvFoodList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFoodList.Location = new Point(392, 95);
            dgvFoodList.Margin = new Padding(3, 2, 3, 2);
            dgvFoodList.MultiSelect = false;
            dgvFoodList.Name = "dgvFoodList";
            dgvFoodList.ReadOnly = true;
            dgvFoodList.RowHeadersWidth = 51;
            dgvFoodList.RowTemplate.Height = 29;
            dgvFoodList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFoodList.Size = new Size(640, 313);
            dgvFoodList.TabIndex = 7;
            // 
            // txtFoodId
            // 
            txtFoodId.Location = new Point(145, 97);
            txtFoodId.Margin = new Padding(3, 2, 3, 2);
            txtFoodId.Name = "txtFoodId";
            txtFoodId.Size = new Size(187, 23);
            txtFoodId.TabIndex = 8;
            // 
            // txtFoodName
            // 
            txtFoodName.Location = new Point(145, 135);
            txtFoodName.Margin = new Padding(3, 2, 3, 2);
            txtFoodName.Name = "txtFoodName";
            txtFoodName.Size = new Size(187, 23);
            txtFoodName.TabIndex = 9;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(452, 66);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(199, 23);
            txtSearch.TabIndex = 14;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Location = new Point(392, 71);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(42, 15);
            lbSearch.TabIndex = 15;
            lbSearch.Text = "Search";
            // 
            // btnNew
            // 
            btnNew.Location = new Point(391, 423);
            btnNew.Margin = new Padding(3, 2, 3, 2);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(82, 22);
            btnNew.TabIndex = 16;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(497, 423);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(82, 22);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(605, 423);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 22);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(715, 423);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(82, 22);
            btnExit.TabIndex = 19;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(145, 328);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 22);
            btnSave.TabIndex = 20;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(145, 176);
            nudQuantity.Margin = new Padding(3, 2, 3, 2);
            nudQuantity.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(186, 23);
            nudQuantity.TabIndex = 21;
            // 
            // dtpImportDate
            // 
            dtpImportDate.Location = new Point(145, 216);
            dtpImportDate.Margin = new Padding(3, 2, 3, 2);
            dtpImportDate.Name = "dtpImportDate";
            dtpImportDate.Size = new Size(187, 23);
            dtpImportDate.TabIndex = 22;
            // 
            // dtpExpiredDate
            // 
            dtpExpiredDate.Location = new Point(145, 256);
            dtpExpiredDate.Margin = new Padding(3, 2, 3, 2);
            dtpExpiredDate.Name = "dtpExpiredDate";
            dtpExpiredDate.Size = new Size(187, 23);
            dtpExpiredDate.TabIndex = 23;
            // 
            // cboCategoryName
            // 
            cboCategoryName.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoryName.FormattingEnabled = true;
            cboCategoryName.Items.AddRange(new object[] { "Raw Meat", "Vegetable", "Fruit", "Water", "Sea food" });
            cboCategoryName.Location = new Point(145, 291);
            cboCategoryName.Margin = new Padding(3, 2, 3, 2);
            cboCategoryName.Name = "cboCategoryName";
            cboCategoryName.Size = new Size(187, 23);
            cboCategoryName.TabIndex = 24;
            // 
            // frmFood
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 480);
            ControlBox = false;
            Controls.Add(cboCategoryName);
            Controls.Add(dtpExpiredDate);
            Controls.Add(dtpImportDate);
            Controls.Add(nudQuantity);
            Controls.Add(btnSave);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnNew);
            Controls.Add(lbSearch);
            Controls.Add(txtSearch);
            Controls.Add(txtFoodName);
            Controls.Add(txtFoodId);
            Controls.Add(dgvFoodList);
            Controls.Add(lbCategoryName);
            Controls.Add(lbExpiredDate);
            Controls.Add(lbImportDate);
            Controls.Add(lbQuantity);
            Controls.Add(lbFoodName);
            Controls.Add(lbFoodId);
            Controls.Add(lbFoodManagement);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmFood";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmFood";
            Load += frmFood_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFoodList).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbFoodManagement;
        private Label lbFoodId;
        private Label lbFoodName;
        private Label lbQuantity;
        private Label lbImportDate;
        private Label lbExpiredDate;
        private Label lbCategoryName;
        private DataGridView dgvFoodList;
        private TextBox txtFoodId;
        private TextBox txtFoodName;
        private TextBox txtSearch;
        private Label lbSearch;
        private Button btnNew;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnExit;
        private Button btnSave;
        private NumericUpDown nudQuantity;
        private DateTimePicker dtpImportDate;
        private DateTimePicker dtpExpiredDate;
        private ComboBox cboCategoryName;
    }
}