using BussinessObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooManagementApp
{
    public partial class frmAnimals : Form
    {
        IAnimalRepository animalRepo = new AnimalRepository();
        BindingSource source = new BindingSource();
        public User User { get; set; }
        public frmAnimals()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ClearText()
        {
            txtAnimalId.Text = string.Empty;
            txtName.Text = string.Empty;
            txtRarity.Text = string.Empty;
            txtRegion.Text = string.Empty;
            txtSex.Text = string.Empty;
            txtSpecies.Text = string.Empty;
            rtbDescription.Text = string.Empty;
            cboHealthCheck.Text = string.Empty;
            txtBirthday.Text = string.Empty;
        }

        private void EnableText(bool status)
        {
            txtAnimalId.Enabled = status;
            txtName.Enabled = status;
            txtRarity.Enabled = status;
            txtRegion.Enabled = status;
            txtSex.Enabled = status;
            txtSpecies.Enabled = status;
            rtbDescription.Enabled = status;
            cboHealthCheck.Enabled = status;
            txtBirthday.Enabled = status;
        }

        private Animal GetAnimal()
        {
            Animal animal = new Animal()
            {
                AnimalId = txtAnimalId.Text,
                Name = txtName.Text,
                Rarity = txtRarity.Text == "True",
                Region = txtRegion.Text,
                Sex = txtSex.Text == "True",
                SpeciesName = txtSpecies.Text,
                Description = rtbDescription.Text,
                HealthCheck = cboHealthCheck.Text,
                Birthday = DateTime.Parse(txtBirthday.Text)
            };
            return animal;
        }

        public void LoadAnimalList()
        {
            try
            {
                var animals = animalRepo.SearchAndFilterAnimalBySpecies(cboFilter.Text, txtSearch.Text).ToList();

                source.DataSource = animals;
                txtAnimalId.DataBindings.Clear();
                txtName.DataBindings.Clear();
                txtRarity.DataBindings.Clear();
                txtRegion.DataBindings.Clear();
                txtSex.DataBindings.Clear();
                txtSpecies.DataBindings.Clear();
                rtbDescription.DataBindings.Clear();
                cboHealthCheck.DataBindings.Clear();
                txtBirthday.DataBindings.Clear();

                txtAnimalId.DataBindings.Add("Text", source, "AnimalId");
                txtName.DataBindings.Add("Text", source, "Name");
                txtRarity.DataBindings.Add("Text", source, "Rarity");
                txtRegion.DataBindings.Add("Text", source, "Region");
                txtSex.DataBindings.Add("Text", source, "Sex");
                txtSpecies.DataBindings.Add("Text", source, "SpeciesName");
                rtbDescription.DataBindings.Add("Text", source, "Description");
                cboHealthCheck.DataBindings.Add("Text", source, "HealthCheck");
                txtBirthday.DataBindings.Add("Text", source, "Birthday");

                dgvAnimalList.DataSource = null;
                dgvAnimalList.DataSource = source;

                if (source == null || animals.Count == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                }
                else
                {
                    if (User.Role != 2) btnDelete.Enabled = false;
                    else btnDelete.Enabled = true;
                    btnUpdate.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load animal");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmAnimalDetail frmAnimalDetail = new frmAnimalDetail()
            {
                InsertOrUpdate = false,
                AnimalRepository = animalRepo,
            };
            if (frmAnimalDetail.ShowDialog() == DialogResult.OK)
            {
                LoadAnimalList();
                source.Position = source.Count - 1;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmAnimalDetail frmAnimalDetail = new frmAnimalDetail()
            {
                InsertOrUpdate = true,
                AnimalRepository = animalRepo,
                AnimalInfo = GetAnimal(),
                User = User
            };
            if (frmAnimalDetail.ShowDialog() == DialogResult.OK)
            {
                LoadAnimalList();
                source.Position = source.Count - 1;
            }
        }

        private void frmAnimals_Load(object sender, EventArgs e)
        {
            if (User.Role == 2)
            {
                EnableText(false);
                cboHealthCheck.SelectedIndex = 0;
                cboFilter.SelectedIndex = 0;
                LoadAnimalList();
            }
            else
            {
                btnNew.Enabled = false;
                EnableText(false);
                cboHealthCheck.SelectedIndex = 0;
                cboFilter.SelectedIndex = 0;
                btnDelete.Enabled = false;
                LoadAnimalList();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtAnimalId.Text;
            if (MessageBox.Show("Are you sure about delete this animal?", "Delete animal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    animalRepo.DeleteAnimal(id);
                    LoadAnimalList();
                    source.Position = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Delete animal");
                }
            }
            else
            {
                MessageBox.Show("Deny to delete", "Delete animal");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadAnimalList();
            source.Position = 0;
        }

        private void cboFilter_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadAnimalList();
            source.Position = 0;
        }
    }
}
