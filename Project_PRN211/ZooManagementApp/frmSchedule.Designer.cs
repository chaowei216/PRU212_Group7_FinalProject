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
            label1=new Label();
            label2=new Label();
            label3=new Label();
            dgv=new DataGridView();
            btnDelete=new Button();
            btnSave=new Button();
            label5=new Label();
            txtScheduleId=new TextBox();
            txtScheduleName=new TextBox();
            btnUpdate=new Button();
            btnExit=new Button();
            label4=new Label();
            txtStatus=new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location=new Point(37, 195);
            label1.Name="label1";
            label1.Size=new Size(108, 25);
            label1.TabIndex=0;
            label1.Text="Schedule Id";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location=new Point(37, 357);
            label2.Name="label2";
            label2.Size=new Size(141, 25);
            label2.TabIndex=0;
            label2.Text="Schedule Name";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(20, 183);
            label3.Name="label3";
            label3.Size=new Size(0, 20);
            label3.TabIndex=0;
            // 
            // dgv
            // 
            dgv.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;
            dgv.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location=new Point(538, 65);
            dgv.Name="dgv";
            dgv.RowHeadersWidth=51;
            dgv.RowTemplate.Height=29;
            dgv.Size=new Size(664, 483);
            dgv.TabIndex=1;
            // 
            // btnDelete
            // 
            btnDelete.Location=new Point(205, 519);
            btnDelete.Name="btnDelete";
            btnDelete.Size=new Size(94, 29);
            btnDelete.TabIndex=2;
            btnDelete.Text="Delete";
            btnDelete.UseVisualStyleBackColor=true;
            btnDelete.Click+=btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location=new Point(20, 519);
            btnSave.Name="btnSave";
            btnSave.Size=new Size(94, 29);
            btnSave.TabIndex=3;
            btnSave.Text="Save";
            btnSave.UseVisualStyleBackColor=true;
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.Font=new Font("Segoe UI Symbol", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location=new Point(20, 9);
            label5.Name="label5";
            label5.Size=new Size(178, 50);
            label5.TabIndex=5;
            label5.Text="Schedule";
            // 
            // txtScheduleId
            // 
            txtScheduleId.Location=new Point(195, 193);
            txtScheduleId.Name="txtScheduleId";
            txtScheduleId.Size=new Size(199, 27);
            txtScheduleId.TabIndex=6;
            txtScheduleId.TextChanged+=txtScheduleId_TextChanged;
            // 
            // txtScheduleName
            // 
            txtScheduleName.Location=new Point(195, 357);
            txtScheduleName.Name="txtScheduleName";
            txtScheduleName.Size=new Size(199, 27);
            txtScheduleName.TabIndex=6;
            // 
            // btnUpdate
            // 
            btnUpdate.Location=new Point(386, 519);
            btnUpdate.Name="btnUpdate";
            btnUpdate.Size=new Size(94, 29);
            btnUpdate.TabIndex=7;
            btnUpdate.Text="Update";
            btnUpdate.UseVisualStyleBackColor=true;
            // 
            // btnExit
            // 
            btnExit.Location=new Point(515, 595);
            btnExit.Name="btnExit";
            btnExit.Size=new Size(94, 29);
            btnExit.TabIndex=8;
            btnExit.Text="Exit";
            btnExit.UseVisualStyleBackColor=true;
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Font=new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location=new Point(37, 442);
            label4.Name="label4";
            label4.Size=new Size(63, 25);
            label4.TabIndex=9;
            label4.Text="Status";
            // 
            // txtStatus
            // 
            txtStatus.Location=new Point(195, 440);
            txtStatus.Name="txtStatus";
            txtStatus.Size=new Size(125, 27);
            txtStatus.TabIndex=10;
            // 
            // frmSchedule
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(1214, 636);
            ControlBox=false;
            Controls.Add(txtStatus);
            Controls.Add(label4);
            Controls.Add(btnExit);
            Controls.Add(btnUpdate);
            Controls.Add(txtScheduleName);
            Controls.Add(txtScheduleId);
            Controls.Add(label5);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(dgv);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle=FormBorderStyle.None;
            MaximumSize=new Size(1214, 636);
            Name="frmSchedule";
            Text="frmSchedule";
            Load+=frmSchedule_Load;
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
        private Label label5;
        private TextBox txtScheduleId;
        private TextBox txtScheduleName;
        private Button btnUpdate;
        private Button btnExit;
        private Label label4;
        private TextBox txtStatus;
    }
}