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
    public partial class frmAnimalDetail : Form
    {
        public frmAnimalDetail()
        {
            InitializeComponent();
        }

        public bool InsertOrUpdate { get; set; }
        public IAnimalRepository AnimalRepository { get; set; }
        public Animal AnimalInfo { get; set; }

        private void EnableText(bool status)
        {
            lbAnimalId.Visible = status;
            txtAnimalId.Visible = status;
            lbHealth.Visible = status;
            cboHealth.Visible = status;

            txtAnimalId.Enabled = false;
            txtName.Enabled = true;
            cbRarity.Enabled = true;
            cboRegion.Enabled = !status;
            rbFemale.Enabled = !status;
            rbMale.Enabled = !status;
            rbMale.Checked = !status;
            cboSpecies.Enabled = !status;
            rtbDescription.Enabled = true;
            cboHealth.Enabled = status;
            dtpBirthday.Enabled = !status;
            btnSave.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "" || cboSpecies.Text == ""
                || cboRegion.Text == "" || rtbDescription.Text == "")
            {
                MessageBox.Show("Please enter fullfield before saving", "Add/Update animal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                try
                {
                    Animal animal = new Animal()
                    {
                        Name = txtName.Text,
                        HealthCheck = cboHealth.Text,
                        Birthday = dtpBirthday.Value,
                        Description = rtbDescription.Text,
                        Rarity = cbRarity.Checked,
                        Sex = rbFemale.Checked,
                        SpeciesName = cboSpecies.Text,
                        Region = cboRegion.Text,
                    };

                    if (!InsertOrUpdate)
                    {
                        AnimalRepository.AddNewAnimal(animal);
                        MessageBox.Show("Add Successfully", "Add Animal", MessageBoxButtons.OK);
                    }
                    else
                    {
                        animal.AnimalId = txtAnimalId.Text;
                        AnimalRepository.UpdateAnimal(animal);
                        MessageBox.Show("Update Successfully", "Update Animal", MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Add/Update animal");
                }
            }
        }

        private void frmAnimalDetail_Load(object sender, EventArgs e)
        {
            EnableText(InsertOrUpdate);
            if (InsertOrUpdate)
            {
                txtAnimalId.Text = AnimalInfo.AnimalId;
                txtName.Text = AnimalInfo.Name;
                cbRarity.Checked = AnimalInfo.Rarity;
                cboRegion.Text = AnimalInfo.Region;
                if (AnimalInfo.Status)
                    rbFemale.Checked = true;
                else rbMale.Checked = true;
                cboSpecies.Text = AnimalInfo.SpeciesName;
                rtbDescription.Text = AnimalInfo.Description;
                cboHealth.Text = AnimalInfo.HealthCheck;
                dtpBirthday.Text = AnimalInfo.Birthday.GetDateTimeFormats().First();
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtName.Text) || txtName.Text.Length == 0)
            {
                errorProvider1.SetError(txtName, "Please enter name!");
                btnSave.Enabled = false;
            } else
            {
                errorProvider1.SetError(txtName, "");
                btnSave.Enabled = true;
            }
        }

        private void txtSpecies_TextChanged(object sender, EventArgs e)
        {
            if(!InsertOrUpdate)
            {
                if (string.IsNullOrEmpty(cboSpecies.Text) || cboSpecies.Text.Length == 0)
                {
                    errorProvider1.SetError(cboSpecies, "Please enter species!");
                    btnSave.Enabled = false;
                }
                else
                {
                    errorProvider1.SetError(cboSpecies, "");
                    btnSave.Enabled = true;
                }
            }
        }

        private void cboRegion_TextChanged(object sender, EventArgs e)
        {
            if(!InsertOrUpdate)
            {
                if (string.IsNullOrEmpty(cboRegion.Text) || cboRegion.Text.Length == 0)
                {
                    errorProvider1.SetError(cboRegion, "Please choose region!");
                    btnSave.Enabled = false;
                } else
                {
                    errorProvider1.SetError(cboRegion, "");
                }
            }
        }

        private void cboHealth_TextChanged(object sender, EventArgs e)
        {
            if(!InsertOrUpdate)
            {
                if (string.IsNullOrEmpty(cboHealth.Text) || cboHealth.Text.Length == 0)
                {
                    errorProvider1.SetError(cboHealth, "Please choose health!");
                    btnSave.Enabled = false;
                }
                else
                {
                    errorProvider1.SetError(cboHealth, "");
                    btnSave.Enabled = true;
                }
            }
        }

        private void rtbDescription_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rtbDescription.Text) || rtbDescription.Text.Length == 0)
            {
                errorProvider1.SetError(rtbDescription, "Please enter description!");
                btnSave.Enabled = false;
            }
            else
            {
                errorProvider1.SetError(rtbDescription, "");
                btnSave.Enabled = true;
            }
        }

        private void dtpBirthday_ValueChanged(object sender, EventArgs e)
        {
            if(dtpBirthday.Value > DateTime.Now)
            {
                errorProvider1.SetError(dtpBirthday, "Please enter date before today");
                btnSave.Enabled=false;
            } else
            {
                errorProvider1.SetError(dtpBirthday, "");
            }
        }
    }
}
