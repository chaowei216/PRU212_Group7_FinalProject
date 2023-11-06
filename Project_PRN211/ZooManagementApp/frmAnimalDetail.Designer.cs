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
            this.components = new System.ComponentModel.Container();
            this.lbAnimalDetail = new System.Windows.Forms.Label();
            this.gbAnimalInfo = new System.Windows.Forms.GroupBox();
            this.cboSpecies = new System.Windows.Forms.ComboBox();
            this.cboHealth = new System.Windows.Forms.ComboBox();
            this.lbHealth = new System.Windows.Forms.Label();
            this.btnAddCage = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lbTrainer = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbCage = new System.Windows.Forms.Label();
            this.cboRegion = new System.Windows.Forms.ComboBox();
            this.cbRarity = new System.Windows.Forms.CheckBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbRarity = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbRegion = new System.Windows.Forms.Label();
            this.lbSex = new System.Windows.Forms.Label();
            this.lbSpecies = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAnimalName = new System.Windows.Forms.Label();
            this.btnAddSchedule = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbAnimalId = new System.Windows.Forms.Label();
            this.txtAnimalId = new System.Windows.Forms.TextBox();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbAnimalInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAnimalDetail
            // 
            this.lbAnimalDetail.AutoSize = true;
            this.lbAnimalDetail.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbAnimalDetail.Location = new System.Drawing.Point(300, 28);
            this.lbAnimalDetail.Name = "lbAnimalDetail";
            this.lbAnimalDetail.Size = new System.Drawing.Size(197, 38);
            this.lbAnimalDetail.TabIndex = 0;
            this.lbAnimalDetail.Text = "Animal Detail";
            // 
            // gbAnimalInfo
            // 
            this.gbAnimalInfo.Controls.Add(this.cboSpecies);
            this.gbAnimalInfo.Controls.Add(this.cboHealth);
            this.gbAnimalInfo.Controls.Add(this.lbHealth);
            this.gbAnimalInfo.Controls.Add(this.btnAddCage);
            this.gbAnimalInfo.Controls.Add(this.comboBox2);
            this.gbAnimalInfo.Controls.Add(this.lbTrainer);
            this.gbAnimalInfo.Controls.Add(this.comboBox1);
            this.gbAnimalInfo.Controls.Add(this.lbCage);
            this.gbAnimalInfo.Controls.Add(this.cboRegion);
            this.gbAnimalInfo.Controls.Add(this.cbRarity);
            this.gbAnimalInfo.Controls.Add(this.rbFemale);
            this.gbAnimalInfo.Controls.Add(this.rbMale);
            this.gbAnimalInfo.Controls.Add(this.dtpBirthday);
            this.gbAnimalInfo.Controls.Add(this.rtbDescription);
            this.gbAnimalInfo.Controls.Add(this.txtName);
            this.gbAnimalInfo.Controls.Add(this.lbRarity);
            this.gbAnimalInfo.Controls.Add(this.lbDescription);
            this.gbAnimalInfo.Controls.Add(this.lbRegion);
            this.gbAnimalInfo.Controls.Add(this.lbSex);
            this.gbAnimalInfo.Controls.Add(this.lbSpecies);
            this.gbAnimalInfo.Controls.Add(this.label1);
            this.gbAnimalInfo.Controls.Add(this.lbAnimalName);
            this.gbAnimalInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbAnimalInfo.Location = new System.Drawing.Point(42, 82);
            this.gbAnimalInfo.Name = "gbAnimalInfo";
            this.gbAnimalInfo.Size = new System.Drawing.Size(689, 457);
            this.gbAnimalInfo.TabIndex = 1;
            this.gbAnimalInfo.TabStop = false;
            this.gbAnimalInfo.Text = "Animal Infomation";
            // 
            // cboSpecies
            // 
            this.cboSpecies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSpecies.FormattingEnabled = true;
            this.cboSpecies.Items.AddRange(new object[] {
            "Lion",
            "Rabbit",
            "Monkey",
            "Koala",
            "Bird",
            "Leopard",
            "Elephant",
            "Crocodile",
            "Butterfly",
            "Snake",
            "Turtle",
            "Dog"});
            this.cboSpecies.Location = new System.Drawing.Point(153, 83);
            this.cboSpecies.Name = "cboSpecies";
            this.cboSpecies.Size = new System.Drawing.Size(202, 33);
            this.cboSpecies.TabIndex = 16;
            // 
            // cboHealth
            // 
            this.cboHealth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHealth.FormattingEnabled = true;
            this.cboHealth.Items.AddRange(new object[] {
            "Normal",
            "Sickness",
            "Be in treatment"});
            this.cboHealth.Location = new System.Drawing.Point(484, 197);
            this.cboHealth.Name = "cboHealth";
            this.cboHealth.Size = new System.Drawing.Size(185, 33);
            this.cboHealth.TabIndex = 15;
            this.cboHealth.TextChanged += new System.EventHandler(this.cboHealth_TextChanged);
            // 
            // lbHealth
            // 
            this.lbHealth.AutoSize = true;
            this.lbHealth.Location = new System.Drawing.Point(384, 205);
            this.lbHealth.Name = "lbHealth";
            this.lbHealth.Size = new System.Drawing.Size(66, 25);
            this.lbHealth.TabIndex = 14;
            this.lbHealth.Text = "Health";
            // 
            // btnAddCage
            // 
            this.btnAddCage.Location = new System.Drawing.Point(384, 349);
            this.btnAddCage.Name = "btnAddCage";
            this.btnAddCage.Size = new System.Drawing.Size(136, 32);
            this.btnAddCage.TabIndex = 13;
            this.btnAddCage.Text = "Add Cage";
            this.btnAddCage.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(86, 398);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(269, 33);
            this.comboBox2.TabIndex = 12;
            // 
            // lbTrainer
            // 
            this.lbTrainer.AutoSize = true;
            this.lbTrainer.Location = new System.Drawing.Point(6, 406);
            this.lbTrainer.Name = "lbTrainer";
            this.lbTrainer.Size = new System.Drawing.Size(70, 25);
            this.lbTrainer.TabIndex = 11;
            this.lbTrainer.Text = "Trainer";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(86, 348);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(269, 33);
            this.comboBox1.TabIndex = 10;
            // 
            // lbCage
            // 
            this.lbCage.AutoSize = true;
            this.lbCage.Location = new System.Drawing.Point(6, 356);
            this.lbCage.Name = "lbCage";
            this.lbCage.Size = new System.Drawing.Size(53, 25);
            this.lbCage.TabIndex = 9;
            this.lbCage.Text = "Cage";
            // 
            // cboRegion
            // 
            this.cboRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRegion.FormattingEnabled = true;
            this.cboRegion.Items.AddRange(new object[] {
            "Africa",
            "Asia",
            "Europe",
            "Oceania",
            "Americas",
            "Middle East",
            "East Asia",
            "Caribean",
            "South Pole"});
            this.cboRegion.Location = new System.Drawing.Point(153, 140);
            this.cboRegion.Name = "cboRegion";
            this.cboRegion.Size = new System.Drawing.Size(202, 33);
            this.cboRegion.TabIndex = 8;
            this.cboRegion.TextChanged += new System.EventHandler(this.cboRegion_TextChanged);
            // 
            // cbRarity
            // 
            this.cbRarity.AutoSize = true;
            this.cbRarity.Location = new System.Drawing.Point(484, 144);
            this.cbRarity.Name = "cbRarity";
            this.cbRarity.Size = new System.Drawing.Size(95, 29);
            this.cbRarity.TabIndex = 7;
            this.cbRarity.Text = "isRarity";
            this.cbRarity.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(577, 84);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(92, 29);
            this.rbFemale.TabIndex = 5;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(484, 84);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(74, 29);
            this.rbMale.TabIndex = 4;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthday.Location = new System.Drawing.Point(484, 30);
            this.dtpBirthday.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpBirthday.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(185, 31);
            this.dtpBirthday.TabIndex = 3;
            this.dtpBirthday.Value = new System.DateTime(2023, 11, 5, 11, 27, 40, 0);
            this.dtpBirthday.ValueChanged += new System.EventHandler(this.dtpBirthday_ValueChanged);
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(6, 244);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(663, 95);
            this.rtbDescription.TabIndex = 2;
            this.rtbDescription.Text = "";
            this.rtbDescription.TextChanged += new System.EventHandler(this.rtbDescription_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(153, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(202, 31);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lbRarity
            // 
            this.lbRarity.AutoSize = true;
            this.lbRarity.Location = new System.Drawing.Point(384, 148);
            this.lbRarity.Name = "lbRarity";
            this.lbRarity.Size = new System.Drawing.Size(60, 25);
            this.lbRarity.TabIndex = 0;
            this.lbRarity.Text = "Rarity";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(6, 205);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(108, 25);
            this.lbDescription.TabIndex = 0;
            this.lbDescription.Text = "Description";
            // 
            // lbRegion
            // 
            this.lbRegion.AutoSize = true;
            this.lbRegion.Location = new System.Drawing.Point(6, 148);
            this.lbRegion.Name = "lbRegion";
            this.lbRegion.Size = new System.Drawing.Size(71, 25);
            this.lbRegion.TabIndex = 0;
            this.lbRegion.Text = "Region";
            // 
            // lbSex
            // 
            this.lbSex.AutoSize = true;
            this.lbSex.Location = new System.Drawing.Point(384, 90);
            this.lbSex.Name = "lbSex";
            this.lbSex.Size = new System.Drawing.Size(41, 25);
            this.lbSex.TabIndex = 0;
            this.lbSex.Text = "Sex";
            // 
            // lbSpecies
            // 
            this.lbSpecies.AutoSize = true;
            this.lbSpecies.Location = new System.Drawing.Point(6, 90);
            this.lbSpecies.Name = "lbSpecies";
            this.lbSpecies.Size = new System.Drawing.Size(74, 25);
            this.lbSpecies.TabIndex = 0;
            this.lbSpecies.Text = "Species";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Birthday";
            // 
            // lbAnimalName
            // 
            this.lbAnimalName.AutoSize = true;
            this.lbAnimalName.Location = new System.Drawing.Point(6, 38);
            this.lbAnimalName.Name = "lbAnimalName";
            this.lbAnimalName.Size = new System.Drawing.Size(124, 25);
            this.lbAnimalName.TabIndex = 0;
            this.lbAnimalName.Text = "Animal Name";
            // 
            // btnAddSchedule
            // 
            this.btnAddSchedule.Location = new System.Drawing.Point(152, 545);
            this.btnAddSchedule.Name = "btnAddSchedule";
            this.btnAddSchedule.Size = new System.Drawing.Size(134, 39);
            this.btnAddSchedule.TabIndex = 2;
            this.btnAddSchedule.Text = "Add Schedule";
            this.btnAddSchedule.UseVisualStyleBackColor = true;
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(42, 545);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(104, 39);
            this.btnAddFood.TabIndex = 3;
            this.btnAddFood.Text = "Add Food";
            this.btnAddFood.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(264, 606);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 40);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(408, 606);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbAnimalId
            // 
            this.lbAnimalId.AutoSize = true;
            this.lbAnimalId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbAnimalId.Location = new System.Drawing.Point(42, 42);
            this.lbAnimalId.Name = "lbAnimalId";
            this.lbAnimalId.Size = new System.Drawing.Size(79, 20);
            this.lbAnimalId.TabIndex = 6;
            this.lbAnimalId.Text = "Animal ID";
            // 
            // txtAnimalId
            // 
            this.txtAnimalId.Location = new System.Drawing.Point(128, 35);
            this.txtAnimalId.Name = "txtAnimalId";
            this.txtAnimalId.Size = new System.Drawing.Size(110, 27);
            this.txtAnimalId.TabIndex = 7;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.Connection = null;
            this.sqlCommand1.Notification = null;
            this.sqlCommand1.Transaction = null;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAnimalDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 681);
            this.Controls.Add(this.txtAnimalId);
            this.Controls.Add(this.lbAnimalId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddFood);
            this.Controls.Add(this.btnAddSchedule);
            this.Controls.Add(this.gbAnimalInfo);
            this.Controls.Add(this.lbAnimalDetail);
            this.Name = "frmAnimalDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmAnimalDetail_Load);
            this.gbAnimalInfo.ResumeLayout(false);
            this.gbAnimalInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private ComboBox comboBox2;
        private Label lbTrainer;
        private ComboBox comboBox1;
        private Label lbCage;
        private Button btnAddCage;
        private Label lbAnimalId;
        private TextBox txtAnimalId;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private ComboBox cboHealth;
        private Label lbHealth;
        private ErrorProvider errorProvider1;
        private ComboBox cboSpecies;
    }
}