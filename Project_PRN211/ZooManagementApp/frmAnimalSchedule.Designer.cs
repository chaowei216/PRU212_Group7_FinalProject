namespace ZooManagementApp
{
    partial class frmAnimalSchedule
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
            lbAnimalSchedule = new Label();
            lbAnimalId = new Label();
            lbScheduleName = new Label();
            lbTime = new Label();
            lbDescription = new Label();
            dgvAnimalSchedule = new DataGridView();
            btnSave = new Button();
            btnNew = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            txtAnimalId = new TextBox();
            cboScheduleName = new ComboBox();
            dtpTime = new DateTimePicker();
            rtbDescription = new RichTextBox();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAnimalSchedule).BeginInit();
            SuspendLayout();
            // 
            // lbAnimalSchedule
            // 
            lbAnimalSchedule.AutoSize = true;
            lbAnimalSchedule.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbAnimalSchedule.Location = new Point(327, 27);
            lbAnimalSchedule.Name = "lbAnimalSchedule";
            lbAnimalSchedule.Size = new Size(178, 30);
            lbAnimalSchedule.TabIndex = 0;
            lbAnimalSchedule.Text = "Animal Schedule";
            // 
            // lbAnimalId
            // 
            lbAnimalId.AutoSize = true;
            lbAnimalId.Location = new Point(27, 110);
            lbAnimalId.Name = "lbAnimalId";
            lbAnimalId.Size = new Size(59, 15);
            lbAnimalId.TabIndex = 1;
            lbAnimalId.Text = "Animal ID";
            // 
            // lbScheduleName
            // 
            lbScheduleName.AutoSize = true;
            lbScheduleName.Location = new Point(27, 158);
            lbScheduleName.Name = "lbScheduleName";
            lbScheduleName.Size = new Size(90, 15);
            lbScheduleName.TabIndex = 2;
            lbScheduleName.Text = "Schedule Name";
            // 
            // lbTime
            // 
            lbTime.AutoSize = true;
            lbTime.Location = new Point(27, 208);
            lbTime.Name = "lbTime";
            lbTime.Size = new Size(33, 15);
            lbTime.TabIndex = 3;
            lbTime.Text = "Time";
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Location = new Point(27, 251);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(67, 15);
            lbDescription.TabIndex = 4;
            lbDescription.Text = "Description";
            // 
            // dgvAnimalSchedule
            // 
            dgvAnimalSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnimalSchedule.Location = new Point(406, 102);
            dgvAnimalSchedule.MultiSelect = false;
            dgvAnimalSchedule.Name = "dgvAnimalSchedule";
            dgvAnimalSchedule.ReadOnly = true;
            dgvAnimalSchedule.RowTemplate.Height = 25;
            dgvAnimalSchedule.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAnimalSchedule.Size = new Size(380, 258);
            dgvAnimalSchedule.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(175, 388);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(284, 388);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 23);
            btnNew.TabIndex = 7;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(397, 388);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(507, 388);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtAnimalId
            // 
            txtAnimalId.Location = new Point(142, 102);
            txtAnimalId.Name = "txtAnimalId";
            txtAnimalId.Size = new Size(234, 23);
            txtAnimalId.TabIndex = 10;
            // 
            // cboScheduleName
            // 
            cboScheduleName.DropDownStyle = ComboBoxStyle.DropDownList;
            cboScheduleName.FormattingEnabled = true;
            cboScheduleName.Location = new Point(142, 150);
            cboScheduleName.Name = "cboScheduleName";
            cboScheduleName.Size = new Size(164, 23);
            cboScheduleName.TabIndex = 11;
            // 
            // dtpTime
            // 
            dtpTime.Format = DateTimePickerFormat.Time;
            dtpTime.Location = new Point(142, 200);
            dtpTime.Name = "dtpTime";
            dtpTime.Size = new Size(94, 23);
            dtpTime.TabIndex = 12;
            dtpTime.Value = new DateTime(2023, 11, 16, 10, 1, 0, 0);
            // 
            // rtbDescription
            // 
            rtbDescription.Location = new Point(142, 251);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(234, 105);
            rtbDescription.TabIndex = 13;
            rtbDescription.Text = "";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(617, 388);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 14;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmAnimalSchedule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 432);
            Controls.Add(btnExit);
            Controls.Add(rtbDescription);
            Controls.Add(dtpTime);
            Controls.Add(cboScheduleName);
            Controls.Add(txtAnimalId);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnNew);
            Controls.Add(btnSave);
            Controls.Add(dgvAnimalSchedule);
            Controls.Add(lbDescription);
            Controls.Add(lbTime);
            Controls.Add(lbScheduleName);
            Controls.Add(lbAnimalId);
            Controls.Add(lbAnimalSchedule);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAnimalSchedule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAnimalSchedule";
            Load += frmAnimalSchedule_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAnimalSchedule).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbAnimalSchedule;
        private Label lbAnimalId;
        private Label lbScheduleName;
        private Label lbTime;
        private Label lbDescription;
        private DataGridView dgvAnimalSchedule;
        private Button btnSave;
        private Button btnNew;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox txtAnimalId;
        private ComboBox cboScheduleName;
        private DateTimePicker dtpTime;
        private RichTextBox rtbDescription;
        private Button btnExit;
    }
}