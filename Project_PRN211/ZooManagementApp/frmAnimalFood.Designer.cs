namespace ZooManagementApp
{
    partial class frmAnimalFood
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
            lbAnimalFood = new Label();
            lbAnimalId = new Label();
            lbFoodId = new Label();
            cboFoodList = new ComboBox();
            dgvAnimalFoodList = new DataGridView();
            btnAdd = new Button();
            txtAnimalId = new TextBox();
            btnExit = new Button();
            btnDelete = new Button();
            dtpStartEat = new DateTimePicker();
            dtpEndEat = new DateTimePicker();
            nudAmount = new NumericUpDown();
            btnSave = new Button();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAnimalFoodList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAmount).BeginInit();
            SuspendLayout();
            // 
            // lbAnimalFood
            // 
            lbAnimalFood.AutoSize = true;
            lbAnimalFood.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbAnimalFood.Location = new Point(274, 28);
            lbAnimalFood.Name = "lbAnimalFood";
            lbAnimalFood.Size = new Size(139, 30);
            lbAnimalFood.TabIndex = 0;
            lbAnimalFood.Text = "Animal Food";
            // 
            // lbAnimalId
            // 
            lbAnimalId.AutoSize = true;
            lbAnimalId.Location = new Point(48, 93);
            lbAnimalId.Name = "lbAnimalId";
            lbAnimalId.Size = new Size(59, 15);
            lbAnimalId.TabIndex = 1;
            lbAnimalId.Text = "Animal ID";
            // 
            // lbFoodId
            // 
            lbFoodId.AutoSize = true;
            lbFoodId.Location = new Point(48, 150);
            lbFoodId.Name = "lbFoodId";
            lbFoodId.Size = new Size(34, 15);
            lbFoodId.TabIndex = 3;
            lbFoodId.Text = "Food";
            // 
            // cboFoodList
            // 
            cboFoodList.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFoodList.FormattingEnabled = true;
            cboFoodList.Location = new Point(118, 142);
            cboFoodList.Name = "cboFoodList";
            cboFoodList.Size = new Size(189, 23);
            cboFoodList.TabIndex = 4;
            // 
            // dgvAnimalFoodList
            // 
            dgvAnimalFoodList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnimalFoodList.Location = new Point(48, 217);
            dgvAnimalFoodList.MultiSelect = false;
            dgvAnimalFoodList.Name = "dgvAnimalFoodList";
            dgvAnimalFoodList.ReadOnly = true;
            dgvAnimalFoodList.RowTemplate.Height = 25;
            dgvAnimalFoodList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAnimalFoodList.Size = new Size(577, 213);
            dgvAnimalFoodList.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(333, 142);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(83, 23);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtAnimalId
            // 
            txtAnimalId.Location = new Point(118, 85);
            txtAnimalId.Name = "txtAnimalId";
            txtAnimalId.Size = new Size(100, 23);
            txtAnimalId.TabIndex = 7;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(550, 445);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(469, 445);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dtpStartEat
            // 
            dtpStartEat.Location = new Point(48, 188);
            dtpStartEat.Name = "dtpStartEat";
            dtpStartEat.Size = new Size(200, 23);
            dtpStartEat.TabIndex = 10;
            // 
            // dtpEndEat
            // 
            dtpEndEat.Location = new Point(274, 188);
            dtpEndEat.Name = "dtpEndEat";
            dtpEndEat.Size = new Size(200, 23);
            dtpEndEat.TabIndex = 11;
            // 
            // nudAmount
            // 
            nudAmount.Location = new Point(505, 188);
            nudAmount.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudAmount.Name = "nudAmount";
            nudAmount.Size = new Size(120, 23);
            nudAmount.TabIndex = 12;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(550, 141);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(446, 141);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // frmAnimalFood
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 480);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(nudAmount);
            Controls.Add(dtpEndEat);
            Controls.Add(dtpStartEat);
            Controls.Add(btnDelete);
            Controls.Add(btnExit);
            Controls.Add(txtAnimalId);
            Controls.Add(btnAdd);
            Controls.Add(dgvAnimalFoodList);
            Controls.Add(cboFoodList);
            Controls.Add(lbFoodId);
            Controls.Add(lbAnimalId);
            Controls.Add(lbAnimalFood);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAnimalFood";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAnimalFood";
            Load += frmAnimalFood_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAnimalFoodList).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbAnimalFood;
        private Label lbAnimalId;
        private Label lbFoodId;
        private ComboBox cboFoodList;
        private DataGridView dgvAnimalFoodList;
        private Button btnAdd;
        private TextBox txtAnimalId;
        private Button btnExit;
        private Button btnDelete;
        private DateTimePicker dtpStartEat;
        private DateTimePicker dtpEndEat;
        private NumericUpDown nudAmount;
        private Button btnSave;
        private Button btnUpdate;
    }
}