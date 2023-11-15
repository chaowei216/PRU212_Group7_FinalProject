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
            components=new System.ComponentModel.Container();
            lbAnimal=new Label();
            dgvAnimalList=new DataGridView();
            animalIdDataGridViewTextBoxColumn=new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn=new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn=new DataGridViewTextBoxColumn();
            sexDataGridViewCheckBoxColumn=new DataGridViewCheckBoxColumn();
            regionDataGridViewTextBoxColumn=new DataGridViewTextBoxColumn();
            healthCheckDataGridViewTextBoxColumn=new DataGridViewTextBoxColumn();
            birthdayDataGridViewTextBoxColumn=new DataGridViewTextBoxColumn();
            rarityDataGridViewCheckBoxColumn=new DataGridViewCheckBoxColumn();
            speciesNameDataGridViewTextBoxColumn=new DataGridViewTextBoxColumn();
            animalBindingSource1=new BindingSource(components);
            lbAnimalId=new Label();
            lbName=new Label();
            lbDescription=new Label();
            lbSex=new Label();
            lbRegion=new Label();
            lbHealthCheck=new Label();
            lbRarity=new Label();
            lbSpecies=new Label();
            txtAnimalId=new TextBox();
            txtSex=new TextBox();
            txtSpecies=new TextBox();
            txtName=new TextBox();
            txtRegion=new TextBox();
            txtRarity=new TextBox();
            rtbDescription=new RichTextBox();
            btnNew=new Button();
            btnUpdate=new Button();
            btnDelete=new Button();
            cboFilter=new ComboBox();
            txtSearch=new TextBox();
            gbAction=new GroupBox();
            btnExit=new Button();
            cboHealthCheck=new ComboBox();
            animalBindingSource=new BindingSource(components);
            txtBirthday=new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvAnimalList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)animalBindingSource1).BeginInit();
            gbAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)animalBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lbAnimal
            // 
            lbAnimal.AutoSize=true;
            lbAnimal.Font=new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbAnimal.Location=new Point(450, 9);
            lbAnimal.Name="lbAnimal";
            lbAnimal.Size=new Size(294, 38);
            lbAnimal.TabIndex=0;
            lbAnimal.Text="Animal Management";
            // 
            // dgvAnimalList
            // 
            dgvAnimalList.AutoGenerateColumns=false;
            dgvAnimalList.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnimalList.Columns.AddRange(new DataGridViewColumn[] { animalIdDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, sexDataGridViewCheckBoxColumn, regionDataGridViewTextBoxColumn, healthCheckDataGridViewTextBoxColumn, birthdayDataGridViewTextBoxColumn, rarityDataGridViewCheckBoxColumn, speciesNameDataGridViewTextBoxColumn });
            dgvAnimalList.DataSource=animalBindingSource1;
            dgvAnimalList.Location=new Point(34, 293);
            dgvAnimalList.MultiSelect=false;
            dgvAnimalList.Name="dgvAnimalList";
            dgvAnimalList.ReadOnly=true;
            dgvAnimalList.RowHeadersVisible=false;
            dgvAnimalList.RowHeadersWidth=51;
            dgvAnimalList.RowTemplate.Height=29;
            dgvAnimalList.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            dgvAnimalList.Size=new Size(1128, 260);
            dgvAnimalList.TabIndex=1;
            // 
            // animalIdDataGridViewTextBoxColumn
            // 
            animalIdDataGridViewTextBoxColumn.DataPropertyName="AnimalId";
            animalIdDataGridViewTextBoxColumn.HeaderText="AnimalId";
            animalIdDataGridViewTextBoxColumn.MinimumWidth=6;
            animalIdDataGridViewTextBoxColumn.Name="animalIdDataGridViewTextBoxColumn";
            animalIdDataGridViewTextBoxColumn.ReadOnly=true;
            animalIdDataGridViewTextBoxColumn.Width=125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName="Name";
            nameDataGridViewTextBoxColumn.HeaderText="Name";
            nameDataGridViewTextBoxColumn.MinimumWidth=6;
            nameDataGridViewTextBoxColumn.Name="nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly=true;
            nameDataGridViewTextBoxColumn.Width=125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName="Description";
            descriptionDataGridViewTextBoxColumn.HeaderText="Description";
            descriptionDataGridViewTextBoxColumn.MinimumWidth=6;
            descriptionDataGridViewTextBoxColumn.Name="descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly=true;
            descriptionDataGridViewTextBoxColumn.Width=125;
            // 
            // sexDataGridViewCheckBoxColumn
            // 
            sexDataGridViewCheckBoxColumn.DataPropertyName="Sex";
            sexDataGridViewCheckBoxColumn.HeaderText="Sex";
            sexDataGridViewCheckBoxColumn.MinimumWidth=6;
            sexDataGridViewCheckBoxColumn.Name="sexDataGridViewCheckBoxColumn";
            sexDataGridViewCheckBoxColumn.ReadOnly=true;
            sexDataGridViewCheckBoxColumn.Width=125;
            // 
            // regionDataGridViewTextBoxColumn
            // 
            regionDataGridViewTextBoxColumn.DataPropertyName="Region";
            regionDataGridViewTextBoxColumn.HeaderText="Region";
            regionDataGridViewTextBoxColumn.MinimumWidth=6;
            regionDataGridViewTextBoxColumn.Name="regionDataGridViewTextBoxColumn";
            regionDataGridViewTextBoxColumn.ReadOnly=true;
            regionDataGridViewTextBoxColumn.Width=125;
            // 
            // healthCheckDataGridViewTextBoxColumn
            // 
            healthCheckDataGridViewTextBoxColumn.DataPropertyName="HealthCheck";
            healthCheckDataGridViewTextBoxColumn.HeaderText="HealthCheck";
            healthCheckDataGridViewTextBoxColumn.MinimumWidth=6;
            healthCheckDataGridViewTextBoxColumn.Name="healthCheckDataGridViewTextBoxColumn";
            healthCheckDataGridViewTextBoxColumn.ReadOnly=true;
            healthCheckDataGridViewTextBoxColumn.Width=125;
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            birthdayDataGridViewTextBoxColumn.DataPropertyName="Birthday";
            birthdayDataGridViewTextBoxColumn.HeaderText="Birthday";
            birthdayDataGridViewTextBoxColumn.MinimumWidth=6;
            birthdayDataGridViewTextBoxColumn.Name="birthdayDataGridViewTextBoxColumn";
            birthdayDataGridViewTextBoxColumn.ReadOnly=true;
            birthdayDataGridViewTextBoxColumn.Width=125;
            // 
            // rarityDataGridViewCheckBoxColumn
            // 
            rarityDataGridViewCheckBoxColumn.DataPropertyName="Rarity";
            rarityDataGridViewCheckBoxColumn.HeaderText="Rarity";
            rarityDataGridViewCheckBoxColumn.MinimumWidth=6;
            rarityDataGridViewCheckBoxColumn.Name="rarityDataGridViewCheckBoxColumn";
            rarityDataGridViewCheckBoxColumn.ReadOnly=true;
            rarityDataGridViewCheckBoxColumn.Width=125;
            // 
            // speciesNameDataGridViewTextBoxColumn
            // 
            speciesNameDataGridViewTextBoxColumn.DataPropertyName="SpeciesName";
            speciesNameDataGridViewTextBoxColumn.HeaderText="SpeciesName";
            speciesNameDataGridViewTextBoxColumn.MinimumWidth=6;
            speciesNameDataGridViewTextBoxColumn.Name="speciesNameDataGridViewTextBoxColumn";
            speciesNameDataGridViewTextBoxColumn.ReadOnly=true;
            speciesNameDataGridViewTextBoxColumn.Width=125;
            // 
            // animalBindingSource1
            // 
            animalBindingSource1.DataSource=typeof(BussinessObject.Models.Animal);
            // 
            // lbAnimalId
            // 
            lbAnimalId.AutoSize=true;
            lbAnimalId.Location=new Point(34, 70);
            lbAnimalId.Name="lbAnimalId";
            lbAnimalId.Size=new Size(75, 20);
            lbAnimalId.TabIndex=2;
            lbAnimalId.Text="Animal ID";
            // 
            // lbName
            // 
            lbName.AutoSize=true;
            lbName.Location=new Point(306, 70);
            lbName.Name="lbName";
            lbName.Size=new Size(49, 20);
            lbName.TabIndex=3;
            lbName.Text="Name";
            // 
            // lbDescription
            // 
            lbDescription.AutoSize=true;
            lbDescription.Location=new Point(34, 211);
            lbDescription.Name="lbDescription";
            lbDescription.Size=new Size(85, 20);
            lbDescription.TabIndex=4;
            lbDescription.Text="Description";
            // 
            // lbSex
            // 
            lbSex.AutoSize=true;
            lbSex.Location=new Point(34, 120);
            lbSex.Name="lbSex";
            lbSex.Size=new Size(32, 20);
            lbSex.TabIndex=5;
            lbSex.Text="Sex";
            // 
            // lbRegion
            // 
            lbRegion.AutoSize=true;
            lbRegion.Location=new Point(306, 120);
            lbRegion.Name="lbRegion";
            lbRegion.Size=new Size(56, 20);
            lbRegion.TabIndex=6;
            lbRegion.Text="Region";
            // 
            // lbHealthCheck
            // 
            lbHealthCheck.AutoSize=true;
            lbHealthCheck.Location=new Point(552, 120);
            lbHealthCheck.Name="lbHealthCheck";
            lbHealthCheck.Size=new Size(96, 20);
            lbHealthCheck.TabIndex=7;
            lbHealthCheck.Text="Health Check";
            // 
            // lbRarity
            // 
            lbRarity.AutoSize=true;
            lbRarity.Location=new Point(306, 168);
            lbRarity.Name="lbRarity";
            lbRarity.Size=new Size(47, 20);
            lbRarity.TabIndex=10;
            lbRarity.Text="Rarity";
            // 
            // lbSpecies
            // 
            lbSpecies.AutoSize=true;
            lbSpecies.Location=new Point(34, 168);
            lbSpecies.Name="lbSpecies";
            lbSpecies.Size=new Size(59, 20);
            lbSpecies.TabIndex=11;
            lbSpecies.Text="Species";
            // 
            // txtAnimalId
            // 
            txtAnimalId.Location=new Point(131, 63);
            txtAnimalId.Name="txtAnimalId";
            txtAnimalId.Size=new Size(148, 27);
            txtAnimalId.TabIndex=12;
            // 
            // txtSex
            // 
            txtSex.Location=new Point(131, 113);
            txtSex.Name="txtSex";
            txtSex.Size=new Size(148, 27);
            txtSex.TabIndex=12;
            // 
            // txtSpecies
            // 
            txtSpecies.Location=new Point(131, 161);
            txtSpecies.Name="txtSpecies";
            txtSpecies.Size=new Size(148, 27);
            txtSpecies.TabIndex=12;
            // 
            // txtName
            // 
            txtName.Location=new Point(374, 63);
            txtName.Name="txtName";
            txtName.Size=new Size(151, 27);
            txtName.TabIndex=12;
            // 
            // txtRegion
            // 
            txtRegion.Location=new Point(374, 113);
            txtRegion.Name="txtRegion";
            txtRegion.Size=new Size(151, 27);
            txtRegion.TabIndex=12;
            // 
            // txtRarity
            // 
            txtRarity.Location=new Point(374, 161);
            txtRarity.Name="txtRarity";
            txtRarity.Size=new Size(151, 27);
            txtRarity.TabIndex=12;
            // 
            // rtbDescription
            // 
            rtbDescription.Location=new Point(131, 208);
            rtbDescription.Name="rtbDescription";
            rtbDescription.Size=new Size(394, 73);
            rtbDescription.TabIndex=13;
            rtbDescription.Text="";
            // 
            // btnNew
            // 
            btnNew.Location=new Point(6, 33);
            btnNew.Name="btnNew";
            btnNew.Size=new Size(94, 36);
            btnNew.TabIndex=16;
            btnNew.Text="New";
            btnNew.UseVisualStyleBackColor=true;
            btnNew.Click+=btnNew_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location=new Point(120, 33);
            btnUpdate.Name="btnUpdate";
            btnUpdate.Size=new Size(94, 36);
            btnUpdate.TabIndex=17;
            btnUpdate.Text="Update";
            btnUpdate.UseVisualStyleBackColor=true;
            btnUpdate.Click+=btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location=new Point(236, 33);
            btnDelete.Name="btnDelete";
            btnDelete.Size=new Size(94, 36);
            btnDelete.TabIndex=18;
            btnDelete.Text="Delete";
            btnDelete.UseVisualStyleBackColor=true;
            btnDelete.Click+=btnDelete_Click;
            // 
            // cboFilter
            // 
            cboFilter.DropDownStyle=ComboBoxStyle.DropDownList;
            cboFilter.FormattingEnabled=true;
            cboFilter.Items.AddRange(new object[] { "All", "Lion", "Rabbit", "Monkey", "Koala", "Bird", "Leopard", "Elephant", "Crocodile", "Butterfly", "Snake", "Turtle", "Dog" });
            cboFilter.Location=new Point(798, 253);
            cboFilter.Name="cboFilter";
            cboFilter.Size=new Size(114, 28);
            cboFilter.TabIndex=20;
            cboFilter.SelectedValueChanged+=cboFilter_SelectedValueChanged;
            // 
            // txtSearch
            // 
            txtSearch.Location=new Point(918, 254);
            txtSearch.Name="txtSearch";
            txtSearch.Size=new Size(244, 27);
            txtSearch.TabIndex=21;
            txtSearch.TextChanged+=txtSearch_TextChanged;
            // 
            // gbAction
            // 
            gbAction.Controls.Add(btnNew);
            gbAction.Controls.Add(btnUpdate);
            gbAction.Controls.Add(btnDelete);
            gbAction.Font=new Font("Segoe UI", 10.2F, FontStyle.Bold|FontStyle.Italic, GraphicsUnit.Point);
            gbAction.Location=new Point(798, 63);
            gbAction.Name="gbAction";
            gbAction.Size=new Size(364, 125);
            gbAction.TabIndex=22;
            gbAction.TabStop=false;
            gbAction.Text="Action";
            // 
            // btnExit
            // 
            btnExit.Font=new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold|FontStyle.Italic, GraphicsUnit.Point);
            btnExit.Location=new Point(554, 559);
            btnExit.Name="btnExit";
            btnExit.Size=new Size(94, 47);
            btnExit.TabIndex=23;
            btnExit.Text="Exit";
            btnExit.UseVisualStyleBackColor=true;
            btnExit.Click+=btnExit_Click;
            // 
            // cboHealthCheck
            // 
            cboHealthCheck.DropDownStyle=ComboBoxStyle.DropDownList;
            cboHealthCheck.FormattingEnabled=true;
            cboHealthCheck.Items.AddRange(new object[] { "Normal", "Sickness", "Be in treatment" });
            cboHealthCheck.Location=new Point(552, 160);
            cboHealthCheck.Name="cboHealthCheck";
            cboHealthCheck.Size=new Size(215, 28);
            cboHealthCheck.TabIndex=24;
            // 
            // animalBindingSource
            // 
            animalBindingSource.DataSource=typeof(BussinessObject.Models.Animal);
            // 
            // txtBirthday
            // 
            txtBirthday.Location=new Point(554, 63);
            txtBirthday.Name="txtBirthday";
            txtBirthday.Size=new Size(213, 27);
            txtBirthday.TabIndex=25;
            // 
            // frmAnimals
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(1196, 618);
            ControlBox=false;
            Controls.Add(txtBirthday);
            Controls.Add(cboHealthCheck);
            Controls.Add(btnExit);
            Controls.Add(gbAction);
            Controls.Add(txtSearch);
            Controls.Add(cboFilter);
            Controls.Add(rtbDescription);
            Controls.Add(txtSpecies);
            Controls.Add(txtSex);
            Controls.Add(txtRarity);
            Controls.Add(txtRegion);
            Controls.Add(txtName);
            Controls.Add(txtAnimalId);
            Controls.Add(lbSpecies);
            Controls.Add(lbRarity);
            Controls.Add(lbHealthCheck);
            Controls.Add(lbRegion);
            Controls.Add(lbSex);
            Controls.Add(lbDescription);
            Controls.Add(lbName);
            Controls.Add(lbAnimalId);
            Controls.Add(dgvAnimalList);
            Controls.Add(lbAnimal);
            Name="frmAnimals";
            StartPosition=FormStartPosition.CenterParent;
            Load+=frmAnimals_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAnimalList).EndInit();
            ((System.ComponentModel.ISupportInitialize)animalBindingSource1).EndInit();
            gbAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)animalBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
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