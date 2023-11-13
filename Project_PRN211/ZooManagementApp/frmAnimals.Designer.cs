namespace ZooManagementApp
{
    partial class frmAnimals
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
            this.lbAnimal = new System.Windows.Forms.Label();
            this.dgvAnimalList = new System.Windows.Forms.DataGridView();
            this.animalIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.regionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.healthCheckDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rarityDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.speciesNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lbAnimalId = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbSex = new System.Windows.Forms.Label();
            this.lbRegion = new System.Windows.Forms.Label();
            this.lbHealthCheck = new System.Windows.Forms.Label();
            this.lbRarity = new System.Windows.Forms.Label();
            this.lbSpecies = new System.Windows.Forms.Label();
            this.txtAnimalId = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.txtSpecies = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.txtRarity = new System.Windows.Forms.TextBox();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cboFilter = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.gbAction = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.cboHealthCheck = new System.Windows.Forms.ComboBox();
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtBirthday = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimalList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource1)).BeginInit();
            this.gbAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAnimal
            // 
            this.lbAnimal.AutoSize = true;
            this.lbAnimal.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbAnimal.Location = new System.Drawing.Point(450, 9);
            this.lbAnimal.Name = "lbAnimal";
            this.lbAnimal.Size = new System.Drawing.Size(294, 38);
            this.lbAnimal.TabIndex = 0;
            this.lbAnimal.Text = "Animal Management";
            // 
            // dgvAnimalList
            // 
            this.dgvAnimalList.AutoGenerateColumns = false;
            this.dgvAnimalList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimalList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.animalIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.sexDataGridViewCheckBoxColumn,
            this.regionDataGridViewTextBoxColumn,
            this.healthCheckDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.rarityDataGridViewCheckBoxColumn,
            this.speciesNameDataGridViewTextBoxColumn});
            this.dgvAnimalList.DataSource = this.animalBindingSource1;
            this.dgvAnimalList.Location = new System.Drawing.Point(34, 293);
            this.dgvAnimalList.MultiSelect = false;
            this.dgvAnimalList.Name = "dgvAnimalList";
            this.dgvAnimalList.ReadOnly = true;
            this.dgvAnimalList.RowHeadersVisible = false;
            this.dgvAnimalList.RowHeadersWidth = 51;
            this.dgvAnimalList.RowTemplate.Height = 29;
            this.dgvAnimalList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAnimalList.Size = new System.Drawing.Size(1128, 260);
            this.dgvAnimalList.TabIndex = 1;
            // 
            // animalIdDataGridViewTextBoxColumn
            // 
            this.animalIdDataGridViewTextBoxColumn.DataPropertyName = "AnimalId";
            this.animalIdDataGridViewTextBoxColumn.HeaderText = "AnimalId";
            this.animalIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.animalIdDataGridViewTextBoxColumn.Name = "animalIdDataGridViewTextBoxColumn";
            this.animalIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.animalIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // sexDataGridViewCheckBoxColumn
            // 
            this.sexDataGridViewCheckBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewCheckBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.sexDataGridViewCheckBoxColumn.Name = "sexDataGridViewCheckBoxColumn";
            this.sexDataGridViewCheckBoxColumn.ReadOnly = true;
            this.sexDataGridViewCheckBoxColumn.Width = 125;
            // 
            // regionDataGridViewTextBoxColumn
            // 
            this.regionDataGridViewTextBoxColumn.DataPropertyName = "Region";
            this.regionDataGridViewTextBoxColumn.HeaderText = "Region";
            this.regionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.regionDataGridViewTextBoxColumn.Name = "regionDataGridViewTextBoxColumn";
            this.regionDataGridViewTextBoxColumn.ReadOnly = true;
            this.regionDataGridViewTextBoxColumn.Width = 125;
            // 
            // healthCheckDataGridViewTextBoxColumn
            // 
            this.healthCheckDataGridViewTextBoxColumn.DataPropertyName = "HealthCheck";
            this.healthCheckDataGridViewTextBoxColumn.HeaderText = "HealthCheck";
            this.healthCheckDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.healthCheckDataGridViewTextBoxColumn.Name = "healthCheckDataGridViewTextBoxColumn";
            this.healthCheckDataGridViewTextBoxColumn.ReadOnly = true;
            this.healthCheckDataGridViewTextBoxColumn.Width = 125;
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            this.birthdayDataGridViewTextBoxColumn.ReadOnly = true;
            this.birthdayDataGridViewTextBoxColumn.Width = 125;
            // 
            // rarityDataGridViewCheckBoxColumn
            // 
            this.rarityDataGridViewCheckBoxColumn.DataPropertyName = "Rarity";
            this.rarityDataGridViewCheckBoxColumn.HeaderText = "Rarity";
            this.rarityDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.rarityDataGridViewCheckBoxColumn.Name = "rarityDataGridViewCheckBoxColumn";
            this.rarityDataGridViewCheckBoxColumn.ReadOnly = true;
            this.rarityDataGridViewCheckBoxColumn.Width = 125;
            // 
            // speciesNameDataGridViewTextBoxColumn
            // 
            this.speciesNameDataGridViewTextBoxColumn.DataPropertyName = "SpeciesName";
            this.speciesNameDataGridViewTextBoxColumn.HeaderText = "SpeciesName";
            this.speciesNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.speciesNameDataGridViewTextBoxColumn.Name = "speciesNameDataGridViewTextBoxColumn";
            this.speciesNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.speciesNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // animalBindingSource1
            // 
            this.animalBindingSource1.DataSource = typeof(BussinessObject.Models.Animal);
            // 
            // lbAnimalId
            // 
            this.lbAnimalId.AutoSize = true;
            this.lbAnimalId.Location = new System.Drawing.Point(34, 70);
            this.lbAnimalId.Name = "lbAnimalId";
            this.lbAnimalId.Size = new System.Drawing.Size(75, 20);
            this.lbAnimalId.TabIndex = 2;
            this.lbAnimalId.Text = "Animal ID";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(306, 70);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(49, 20);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "Name";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(34, 211);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(85, 20);
            this.lbDescription.TabIndex = 4;
            this.lbDescription.Text = "Description";
            // 
            // lbSex
            // 
            this.lbSex.AutoSize = true;
            this.lbSex.Location = new System.Drawing.Point(34, 120);
            this.lbSex.Name = "lbSex";
            this.lbSex.Size = new System.Drawing.Size(32, 20);
            this.lbSex.TabIndex = 5;
            this.lbSex.Text = "Sex";
            // 
            // lbRegion
            // 
            this.lbRegion.AutoSize = true;
            this.lbRegion.Location = new System.Drawing.Point(306, 120);
            this.lbRegion.Name = "lbRegion";
            this.lbRegion.Size = new System.Drawing.Size(56, 20);
            this.lbRegion.TabIndex = 6;
            this.lbRegion.Text = "Region";
            // 
            // lbHealthCheck
            // 
            this.lbHealthCheck.AutoSize = true;
            this.lbHealthCheck.Location = new System.Drawing.Point(552, 120);
            this.lbHealthCheck.Name = "lbHealthCheck";
            this.lbHealthCheck.Size = new System.Drawing.Size(96, 20);
            this.lbHealthCheck.TabIndex = 7;
            this.lbHealthCheck.Text = "Health Check";
            // 
            // lbRarity
            // 
            this.lbRarity.AutoSize = true;
            this.lbRarity.Location = new System.Drawing.Point(306, 168);
            this.lbRarity.Name = "lbRarity";
            this.lbRarity.Size = new System.Drawing.Size(47, 20);
            this.lbRarity.TabIndex = 10;
            this.lbRarity.Text = "Rarity";
            // 
            // lbSpecies
            // 
            this.lbSpecies.AutoSize = true;
            this.lbSpecies.Location = new System.Drawing.Point(34, 168);
            this.lbSpecies.Name = "lbSpecies";
            this.lbSpecies.Size = new System.Drawing.Size(59, 20);
            this.lbSpecies.TabIndex = 11;
            this.lbSpecies.Text = "Species";
            // 
            // txtAnimalId
            // 
            this.txtAnimalId.Location = new System.Drawing.Point(131, 63);
            this.txtAnimalId.Name = "txtAnimalId";
            this.txtAnimalId.Size = new System.Drawing.Size(148, 27);
            this.txtAnimalId.TabIndex = 12;
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(131, 113);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(148, 27);
            this.txtSex.TabIndex = 12;
            // 
            // txtSpecies
            // 
            this.txtSpecies.Location = new System.Drawing.Point(131, 161);
            this.txtSpecies.Name = "txtSpecies";
            this.txtSpecies.Size = new System.Drawing.Size(148, 27);
            this.txtSpecies.TabIndex = 12;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(374, 63);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(151, 27);
            this.txtName.TabIndex = 12;
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(374, 113);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(151, 27);
            this.txtRegion.TabIndex = 12;
            // 
            // txtRarity
            // 
            this.txtRarity.Location = new System.Drawing.Point(374, 161);
            this.txtRarity.Name = "txtRarity";
            this.txtRarity.Size = new System.Drawing.Size(151, 27);
            this.txtRarity.TabIndex = 12;
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(131, 208);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(394, 73);
            this.rtbDescription.TabIndex = 13;
            this.rtbDescription.Text = "";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(6, 33);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(94, 36);
            this.btnNew.TabIndex = 16;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(120, 33);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 36);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(236, 33);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 36);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cboFilter
            // 
            this.cboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilter.FormattingEnabled = true;
            this.cboFilter.Items.AddRange(new object[] {
            "All",
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
            this.cboFilter.Location = new System.Drawing.Point(798, 253);
            this.cboFilter.Name = "cboFilter";
            this.cboFilter.Size = new System.Drawing.Size(114, 28);
            this.cboFilter.TabIndex = 20;
            this.cboFilter.SelectedValueChanged += new System.EventHandler(this.cboFilter_SelectedValueChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(918, 254);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(244, 27);
            this.txtSearch.TabIndex = 21;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // gbAction
            // 
            this.gbAction.Controls.Add(this.btnNew);
            this.gbAction.Controls.Add(this.btnUpdate);
            this.gbAction.Controls.Add(this.btnDelete);
            this.gbAction.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.gbAction.Location = new System.Drawing.Point(798, 63);
            this.gbAction.Name = "gbAction";
            this.gbAction.Size = new System.Drawing.Size(364, 125);
            this.gbAction.TabIndex = 22;
            this.gbAction.TabStop = false;
            this.gbAction.Text = "Action";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(554, 559);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 47);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cboHealthCheck
            // 
            this.cboHealthCheck.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHealthCheck.FormattingEnabled = true;
            this.cboHealthCheck.Items.AddRange(new object[] {
            "Normal",
            "Sickness",
            "Be in treatment"});
            this.cboHealthCheck.Location = new System.Drawing.Point(552, 160);
            this.cboHealthCheck.Name = "cboHealthCheck";
            this.cboHealthCheck.Size = new System.Drawing.Size(215, 28);
            this.cboHealthCheck.TabIndex = 24;
            // 
            // animalBindingSource
            // 
            this.animalBindingSource.DataSource = typeof(BussinessObject.Models.Animal);
            // 
            // txtBirthday
            // 
            this.txtBirthday.Location = new System.Drawing.Point(554, 63);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(213, 27);
            this.txtBirthday.TabIndex = 25;
            // 
            // frmAnimals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 618);
            this.Controls.Add(this.txtBirthday);
            this.Controls.Add(this.cboHealthCheck);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gbAction);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cboFilter);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.txtSpecies);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.txtRarity);
            this.Controls.Add(this.txtRegion);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAnimalId);
            this.Controls.Add(this.lbSpecies);
            this.Controls.Add(this.lbRarity);
            this.Controls.Add(this.lbHealthCheck);
            this.Controls.Add(this.lbRegion);
            this.Controls.Add(this.lbSex);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbAnimalId);
            this.Controls.Add(this.dgvAnimalList);
            this.Controls.Add(this.lbAnimal);
            this.Name = "frmAnimals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmAnimals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimalList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource1)).EndInit();
            this.gbAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbAnimal;
        private DataGridView dgvAnimalList;
        private Label lbAnimalId;
        private Label lbName;
        private Label lbDescription;
        private Label lbSex;
        private Label lbRegion;
        private Label lbHealthCheck;
        private Label lbRarity;
        private Label lbSpecies;
        private TextBox txtAnimalId;
        private TextBox txtSex;
        private TextBox txtSpecies;
        private TextBox txtName;
        private TextBox txtRegion;
        private TextBox txtRarity;
        private RichTextBox rtbDescription;
        private Button btnNew;
        private Button btnUpdate;
        private Button btnDelete;
        private ComboBox cboFilter;
        private TextBox txtSearch;
        private GroupBox gbAction;
        private Button btnExit;
        private ComboBox cboHealthCheck;
        private BindingSource animalBindingSource;
        private TextBox txtBirthday;
        private BindingSource animalBindingSource1;
        private DataGridViewTextBoxColumn animalIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn sexDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn regionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn healthCheckDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn rarityDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn speciesNameDataGridViewTextBoxColumn;
    }
}