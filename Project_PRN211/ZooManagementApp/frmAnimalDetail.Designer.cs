namespace ZooManagementApp
{
    partial class frmAnimalDetail
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
            components = new System.ComponentModel.Container();
            lbAnimalDetail = new Label();
            gbAnimalInfo = new GroupBox();
            cboSpecies = new ComboBox();
            cboHealth = new ComboBox();
            lbHealth = new Label();
            cboTrainer = new ComboBox();
            lbTrainer = new Label();
            cboCageList = new ComboBox();
            lbCage = new Label();
            cboRegion = new ComboBox();
            cbRarity = new CheckBox();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            dtpBirthday = new DateTimePicker();
            rtbDescription = new RichTextBox();
            txtName = new TextBox();
            lbRarity = new Label();
            lbDescription = new Label();
            lbRegion = new Label();
            lbSex = new Label();
            lbSpecies = new Label();
            label1 = new Label();
            lbAnimalName = new Label();
            btnAddSchedule = new Button();
            btnAddFood = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            lbAnimalId = new Label();
            txtAnimalId = new TextBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            errorProvider1 = new ErrorProvider(components);
            gbAnimalInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lbAnimalDetail
            // 
            lbAnimalDetail.AutoSize = true;
            lbAnimalDetail.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbAnimalDetail.Location = new Point(262, 21);
            lbAnimalDetail.Name = "lbAnimalDetail";
            lbAnimalDetail.Size = new Size(152, 30);
            lbAnimalDetail.TabIndex = 0;
            lbAnimalDetail.Text = "Animal Detail";
            // 
            // gbAnimalInfo
            // 
            gbAnimalInfo.Controls.Add(cboSpecies);
            gbAnimalInfo.Controls.Add(cboHealth);
            gbAnimalInfo.Controls.Add(lbHealth);
            gbAnimalInfo.Controls.Add(cboTrainer);
            gbAnimalInfo.Controls.Add(lbTrainer);
            gbAnimalInfo.Controls.Add(cboCageList);
            gbAnimalInfo.Controls.Add(lbCage);
            gbAnimalInfo.Controls.Add(cboRegion);
            gbAnimalInfo.Controls.Add(cbRarity);
            gbAnimalInfo.Controls.Add(rbFemale);
            gbAnimalInfo.Controls.Add(rbMale);
            gbAnimalInfo.Controls.Add(dtpBirthday);
            gbAnimalInfo.Controls.Add(rtbDescription);
            gbAnimalInfo.Controls.Add(txtName);
            gbAnimalInfo.Controls.Add(lbRarity);
            gbAnimalInfo.Controls.Add(lbDescription);
            gbAnimalInfo.Controls.Add(lbRegion);
            gbAnimalInfo.Controls.Add(lbSex);
            gbAnimalInfo.Controls.Add(lbSpecies);
            gbAnimalInfo.Controls.Add(label1);
            gbAnimalInfo.Controls.Add(lbAnimalName);
            gbAnimalInfo.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            gbAnimalInfo.Location = new Point(37, 62);
            gbAnimalInfo.Margin = new Padding(3, 2, 3, 2);
            gbAnimalInfo.Name = "gbAnimalInfo";
            gbAnimalInfo.Padding = new Padding(3, 2, 3, 2);
            gbAnimalInfo.Size = new Size(603, 343);
            gbAnimalInfo.TabIndex = 1;
            gbAnimalInfo.TabStop = false;
            gbAnimalInfo.Text = "Animal Infomation";
            // 
            // cboSpecies
            // 
            cboSpecies.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSpecies.FormattingEnabled = true;
            cboSpecies.Items.AddRange(new object[] { "Lion", "Tiger", "Rabbit", "Monkey", "Koala", "Bird", "Leopard", "Elephant", "Crocodile", "Butterfly", "Snake", "Turtle", "Dog" });
            cboSpecies.Location = new Point(134, 62);
            cboSpecies.Margin = new Padding(3, 2, 3, 2);
            cboSpecies.Name = "cboSpecies";
            cboSpecies.Size = new Size(177, 27);
            cboSpecies.TabIndex = 16;
            cboSpecies.SelectedIndexChanged += cboSpecies_SelectedIndexChanged;
            // 
            // cboHealth
            // 
            cboHealth.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHealth.FormattingEnabled = true;
            cboHealth.Items.AddRange(new object[] { "Normal", "Sickness", "Be in treatment" });
            cboHealth.Location = new Point(424, 148);
            cboHealth.Margin = new Padding(3, 2, 3, 2);
            cboHealth.Name = "cboHealth";
            cboHealth.Size = new Size(162, 27);
            cboHealth.TabIndex = 15;
            cboHealth.TextChanged += cboHealth_TextChanged;
            // 
            // lbHealth
            // 
            lbHealth.AutoSize = true;
            lbHealth.Location = new Point(336, 154);
            lbHealth.Name = "lbHealth";
            lbHealth.Size = new Size(54, 20);
            lbHealth.TabIndex = 14;
            lbHealth.Text = "Health";
            // 
            // cboTrainer
            // 
            cboTrainer.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrainer.FormattingEnabled = true;
            cboTrainer.Location = new Point(75, 298);
            cboTrainer.Margin = new Padding(3, 2, 3, 2);
            cboTrainer.Name = "cboTrainer";
            cboTrainer.Size = new Size(236, 27);
            cboTrainer.TabIndex = 12;
            // 
            // lbTrainer
            // 
            lbTrainer.AutoSize = true;
            lbTrainer.Location = new Point(5, 304);
            lbTrainer.Name = "lbTrainer";
            lbTrainer.Size = new Size(57, 20);
            lbTrainer.TabIndex = 11;
            lbTrainer.Text = "Trainer";
            // 
            // cboCageList
            // 
            cboCageList.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCageList.FormattingEnabled = true;
            cboCageList.Location = new Point(75, 261);
            cboCageList.Margin = new Padding(3, 2, 3, 2);
            cboCageList.Name = "cboCageList";
            cboCageList.Size = new Size(236, 27);
            cboCageList.TabIndex = 10;
            // 
            // lbCage
            // 
            lbCage.AutoSize = true;
            lbCage.Location = new Point(5, 267);
            lbCage.Name = "lbCage";
            lbCage.Size = new Size(43, 20);
            lbCage.TabIndex = 9;
            lbCage.Text = "Cage";
            // 
            // cboRegion
            // 
            cboRegion.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRegion.FormattingEnabled = true;
            cboRegion.Items.AddRange(new object[] { "Africa", "Asia", "Europe", "Oceania", "Americas", "Middle East", "East Asia", "Caribean", "South Pole" });
            cboRegion.Location = new Point(134, 105);
            cboRegion.Margin = new Padding(3, 2, 3, 2);
            cboRegion.Name = "cboRegion";
            cboRegion.Size = new Size(177, 27);
            cboRegion.TabIndex = 8;
            cboRegion.TextChanged += cboRegion_TextChanged;
            // 
            // cbRarity
            // 
            cbRarity.AutoSize = true;
            cbRarity.Location = new Point(424, 108);
            cbRarity.Margin = new Padding(3, 2, 3, 2);
            cbRarity.Name = "cbRarity";
            cbRarity.Size = new Size(78, 24);
            cbRarity.TabIndex = 7;
            cbRarity.Text = "isRarity";
            cbRarity.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(505, 63);
            rbFemale.Margin = new Padding(3, 2, 3, 2);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(76, 24);
            rbFemale.TabIndex = 5;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(424, 63);
            rbMale.Margin = new Padding(3, 2, 3, 2);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(61, 24);
            rbMale.TabIndex = 4;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // dtpBirthday
            // 
            dtpBirthday.Format = DateTimePickerFormat.Custom;
            dtpBirthday.Location = new Point(424, 22);
            dtpBirthday.Margin = new Padding(3, 2, 3, 2);
            dtpBirthday.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtpBirthday.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(162, 27);
            dtpBirthday.TabIndex = 3;
            dtpBirthday.Value = new DateTime(2023, 11, 5, 11, 27, 40, 0);
            dtpBirthday.ValueChanged += dtpBirthday_ValueChanged;
            // 
            // rtbDescription
            // 
            rtbDescription.Location = new Point(5, 183);
            rtbDescription.Margin = new Padding(3, 2, 3, 2);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(581, 72);
            rtbDescription.TabIndex = 2;
            rtbDescription.Text = "";
            rtbDescription.TextChanged += rtbDescription_TextChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(134, 22);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(177, 27);
            txtName.TabIndex = 1;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // lbRarity
            // 
            lbRarity.AutoSize = true;
            lbRarity.Location = new Point(336, 111);
            lbRarity.Name = "lbRarity";
            lbRarity.Size = new Size(49, 20);
            lbRarity.TabIndex = 0;
            lbRarity.Text = "Rarity";
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Location = new Point(5, 154);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(87, 20);
            lbDescription.TabIndex = 0;
            lbDescription.Text = "Description";
            // 
            // lbRegion
            // 
            lbRegion.AutoSize = true;
            lbRegion.Location = new Point(5, 111);
            lbRegion.Name = "lbRegion";
            lbRegion.Size = new Size(57, 20);
            lbRegion.TabIndex = 0;
            lbRegion.Text = "Region";
            // 
            // lbSex
            // 
            lbSex.AutoSize = true;
            lbSex.Location = new Point(336, 68);
            lbSex.Name = "lbSex";
            lbSex.Size = new Size(33, 20);
            lbSex.TabIndex = 0;
            lbSex.Text = "Sex";
            // 
            // lbSpecies
            // 
            lbSpecies.AutoSize = true;
            lbSpecies.Location = new Point(5, 68);
            lbSpecies.Name = "lbSpecies";
            lbSpecies.Size = new Size(59, 20);
            lbSpecies.TabIndex = 0;
            lbSpecies.Text = "Species";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(336, 28);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Birthday";
            // 
            // lbAnimalName
            // 
            lbAnimalName.AutoSize = true;
            lbAnimalName.Location = new Point(5, 28);
            lbAnimalName.Name = "lbAnimalName";
            lbAnimalName.Size = new Size(102, 20);
            lbAnimalName.TabIndex = 0;
            lbAnimalName.Text = "Animal Name";
            // 
            // btnAddSchedule
            // 
            btnAddSchedule.Location = new Point(133, 409);
            btnAddSchedule.Margin = new Padding(3, 2, 3, 2);
            btnAddSchedule.Name = "btnAddSchedule";
            btnAddSchedule.Size = new Size(117, 29);
            btnAddSchedule.TabIndex = 2;
            btnAddSchedule.Text = "Add Schedule";
            btnAddSchedule.UseVisualStyleBackColor = true;
            // 
            // btnAddFood
            // 
            btnAddFood.Location = new Point(37, 409);
            btnAddFood.Margin = new Padding(3, 2, 3, 2);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(91, 29);
            btnAddFood.TabIndex = 3;
            btnAddFood.Text = "Add Food";
            btnAddFood.UseVisualStyleBackColor = true;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(231, 454);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(88, 30);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(357, 454);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(88, 30);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lbAnimalId
            // 
            lbAnimalId.AutoSize = true;
            lbAnimalId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbAnimalId.Location = new Point(37, 32);
            lbAnimalId.Name = "lbAnimalId";
            lbAnimalId.Size = new Size(61, 15);
            lbAnimalId.TabIndex = 6;
            lbAnimalId.Text = "Animal ID";
            // 
            // txtAnimalId
            // 
            txtAnimalId.Location = new Point(112, 26);
            txtAnimalId.Margin = new Padding(3, 2, 3, 2);
            txtAnimalId.Name = "txtAnimalId";
            txtAnimalId.Size = new Size(97, 23);
            txtAnimalId.TabIndex = 7;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmAnimalDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 511);
            Controls.Add(txtAnimalId);
            Controls.Add(lbAnimalId);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnAddFood);
            Controls.Add(btnAddSchedule);
            Controls.Add(gbAnimalInfo);
            Controls.Add(lbAnimalDetail);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmAnimalDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += frmAnimalDetail_Load;
            gbAnimalInfo.ResumeLayout(false);
            gbAnimalInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbAnimalDetail;
        private GroupBox gbAnimalInfo;
        private Label label1;
        private Label lbAnimalName;
        private Label lbRarity;
        private Label lbDescription;
        private Label lbRegion;
        private Label lbSex;
        private Label lbSpecies;
        private TextBox txtName;
        private RichTextBox rtbDescription;
        private ComboBox cboRegion;
        private CheckBox cbRarity;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private DateTimePicker dtpBirthday;
        private Button btnAddSchedule;
        private Button btnAddFood;
        private Button btnSave;
        private Button btnCancel;
        private ComboBox cboTrainer;
        private Label lbTrainer;
        private ComboBox cboCageList;
        private Label lbCage;
        private Label lbAnimalId;
        private TextBox txtAnimalId;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private ComboBox cboHealth;
        private Label lbHealth;
        private ErrorProvider errorProvider1;
        private ComboBox cboSpecies;
    }
}