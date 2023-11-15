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
            this.lbFoodManagement = new System.Windows.Forms.Label();
            this.lbFoodId = new System.Windows.Forms.Label();
            this.lbFoodName = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lbImportDate = new System.Windows.Forms.Label();
            this.lbExpiredDate = new System.Windows.Forms.Label();
            this.lbCategoryName = new System.Windows.Forms.Label();
            this.dgvFoodList = new System.Windows.Forms.DataGridView();
            this.txtFoodId = new System.Windows.Forms.TextBox();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.dtpImportDate = new System.Windows.Forms.DateTimePicker();
            this.dtpExpiredDate = new System.Windows.Forms.DateTimePicker();
            this.cboCategoryName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFoodManagement
            // 
            this.lbFoodManagement.AutoSize = true;
            this.lbFoodManagement.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbFoodManagement.Location = new System.Drawing.Point(357, 26);
            this.lbFoodManagement.Name = "lbFoodManagement";
            this.lbFoodManagement.Size = new System.Drawing.Size(266, 38);
            this.lbFoodManagement.TabIndex = 0;
            this.lbFoodManagement.Text = "Food Management";
            // 
            // lbFoodId
            // 
            this.lbFoodId.AutoSize = true;
            this.lbFoodId.Location = new System.Drawing.Point(44, 95);
            this.lbFoodId.Name = "lbFoodId";
            this.lbFoodId.Size = new System.Drawing.Size(62, 20);
            this.lbFoodId.TabIndex = 1;
            this.lbFoodId.Text = "Food ID";
            // 
            // lbFoodName
            // 
            this.lbFoodName.AutoSize = true;
            this.lbFoodName.Location = new System.Drawing.Point(44, 150);
            this.lbFoodName.Name = "lbFoodName";
            this.lbFoodName.Size = new System.Drawing.Size(87, 20);
            this.lbFoodName.TabIndex = 2;
            this.lbFoodName.Text = "Food Name";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(44, 204);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(65, 20);
            this.lbQuantity.TabIndex = 3;
            this.lbQuantity.Text = "Quantity";
            // 
            // lbImportDate
            // 
            this.lbImportDate.AutoSize = true;
            this.lbImportDate.Location = new System.Drawing.Point(44, 258);
            this.lbImportDate.Name = "lbImportDate";
            this.lbImportDate.Size = new System.Drawing.Size(90, 20);
            this.lbImportDate.TabIndex = 4;
            this.lbImportDate.Text = "Import Date";
            // 
            // lbExpiredDate
            // 
            this.lbExpiredDate.AutoSize = true;
            this.lbExpiredDate.Location = new System.Drawing.Point(44, 311);
            this.lbExpiredDate.Name = "lbExpiredDate";
            this.lbExpiredDate.Size = new System.Drawing.Size(91, 20);
            this.lbExpiredDate.TabIndex = 5;
            this.lbExpiredDate.Text = "ExpiredDate";
            // 
            // lbCategoryName
            // 
            this.lbCategoryName.AutoSize = true;
            this.lbCategoryName.Location = new System.Drawing.Point(44, 360);
            this.lbCategoryName.Name = "lbCategoryName";
            this.lbCategoryName.Size = new System.Drawing.Size(113, 20);
            this.lbCategoryName.TabIndex = 6;
            this.lbCategoryName.Text = "Category Name";
            // 
            // dgvFoodList
            // 
            this.dgvFoodList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodList.Location = new System.Drawing.Point(448, 127);
            this.dgvFoodList.Name = "dgvFoodList";
            this.dgvFoodList.RowHeadersWidth = 51;
            this.dgvFoodList.RowTemplate.Height = 29;
            this.dgvFoodList.Size = new System.Drawing.Size(464, 252);
            this.dgvFoodList.TabIndex = 7;
            // 
            // txtFoodId
            // 
            this.txtFoodId.Location = new System.Drawing.Point(163, 92);
            this.txtFoodId.Name = "txtFoodId";
            this.txtFoodId.Size = new System.Drawing.Size(213, 27);
            this.txtFoodId.TabIndex = 8;
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(163, 143);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(213, 27);
            this.txtFoodName.TabIndex = 9;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(517, 88);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(227, 27);
            this.txtSearch.TabIndex = 14;
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(448, 95);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(53, 20);
            this.lbSearch.TabIndex = 15;
            this.lbSearch.Text = "Search";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(448, 400);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(94, 29);
            this.btnNew.TabIndex = 16;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(569, 400);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(693, 400);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(818, 400);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 29);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(163, 400);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(163, 197);
            this.nudQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(213, 27);
            this.nudQuantity.TabIndex = 21;
            // 
            // dtpImportDate
            // 
            this.dtpImportDate.Location = new System.Drawing.Point(163, 251);
            this.dtpImportDate.Name = "dtpImportDate";
            this.dtpImportDate.Size = new System.Drawing.Size(213, 27);
            this.dtpImportDate.TabIndex = 22;
            // 
            // dtpExpiredDate
            // 
            this.dtpExpiredDate.Location = new System.Drawing.Point(163, 304);
            this.dtpExpiredDate.Name = "dtpExpiredDate";
            this.dtpExpiredDate.Size = new System.Drawing.Size(213, 27);
            this.dtpExpiredDate.TabIndex = 23;
            // 
            // cboCategoryName
            // 
            this.cboCategoryName.FormattingEnabled = true;
            this.cboCategoryName.Items.AddRange(new object[] {
            "Raw Meat",
            "Vegetable",
            "Fruit",
            "Water",
            "Sea food"});
            this.cboCategoryName.Location = new System.Drawing.Point(163, 351);
            this.cboCategoryName.Name = "cboCategoryName";
            this.cboCategoryName.Size = new System.Drawing.Size(213, 28);
            this.cboCategoryName.TabIndex = 24;
            // 
            // frmFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 454);
            this.ControlBox = false;
            this.Controls.Add(this.cboCategoryName);
            this.Controls.Add(this.dtpExpiredDate);
            this.Controls.Add(this.dtpImportDate);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtFoodName);
            this.Controls.Add(this.txtFoodId);
            this.Controls.Add(this.dgvFoodList);
            this.Controls.Add(this.lbCategoryName);
            this.Controls.Add(this.lbExpiredDate);
            this.Controls.Add(this.lbImportDate);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.lbFoodName);
            this.Controls.Add(this.lbFoodId);
            this.Controls.Add(this.lbFoodManagement);
            this.Name = "frmFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFood";
            this.Load += new System.EventHandler(this.frmFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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