namespace ZooManagementApp
{
    partial class frmSchedule
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dgv = new DataGridView();
            btnDelete = new Button();
            btnSave = new Button();
            lbSchedule = new Label();
            txtScheduleId = new TextBox();
            txtScheduleName = new TextBox();
            btnNew = new Button();
            btnExit = new Button();
            label4 = new Label();
            txtStatus = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(32, 185);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 0;
            label1.Text = "Schedule Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(32, 241);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 0;
            label2.Text = "Schedule Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 137);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 0;
            // 
            // dgv
            // 
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(471, 137);
            dgv.Margin = new Padding(3, 2, 3, 2);
            dgv.MultiSelect = false;
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersWidth = 51;
            dgv.RowTemplate.Height = 29;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new Size(581, 299);
            dgv.TabIndex = 1;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(264, 414);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 22);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(32, 414);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 22);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lbSchedule
            // 
            lbSchedule.AutoSize = true;
            lbSchedule.Font = new Font("Segoe UI Symbol", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbSchedule.Location = new Point(343, 29);
            lbSchedule.Name = "lbSchedule";
            lbSchedule.Size = new Size(343, 41);
            lbSchedule.TabIndex = 5;
            lbSchedule.Text = "Schedule Management";
            // 
            // txtScheduleId
            // 
            txtScheduleId.Location = new Point(171, 184);
            txtScheduleId.Margin = new Padding(3, 2, 3, 2);
            txtScheduleId.Name = "txtScheduleId";
            txtScheduleId.Size = new Size(175, 23);
            txtScheduleId.TabIndex = 6;
            // 
            // txtScheduleName
            // 
            txtScheduleName.Location = new Point(171, 241);
            txtScheduleName.Margin = new Padding(3, 2, 3, 2);
            txtScheduleName.Name = "txtScheduleName";
            txtScheduleName.Size = new Size(175, 23);
            txtScheduleName.TabIndex = 6;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(147, 414);
            btnNew.Margin = new Padding(3, 2, 3, 2);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(82, 22);
            btnNew.TabIndex = 7;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(383, 414);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(82, 22);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(32, 305);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 9;
            label4.Text = "Status";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(171, 303);
            txtStatus.Margin = new Padding(3, 2, 3, 2);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(110, 23);
            txtStatus.TabIndex = 10;
            // 
            // frmSchedule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 480);
            ControlBox = false;
            Controls.Add(txtStatus);
            Controls.Add(label4);
            Controls.Add(btnExit);
            Controls.Add(btnNew);
            Controls.Add(txtScheduleName);
            Controls.Add(txtScheduleId);
            Controls.Add(lbSchedule);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(dgv);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(1062, 480);
            Name = "frmSchedule";
            Text = "frmSchedule";
            Load += frmSchedule_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dgv;
        private Button btnDelete;
        private Button btnSave;
        private Label lbSchedule;
        private TextBox txtScheduleId;
        private TextBox txtScheduleName;
        private Button btnNew;
        private Button btnExit;
        private Label label4;
        private TextBox txtStatus;
    }
}