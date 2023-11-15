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
        ICageRepository _cageRepository = new CageRepository();
        IUserRepository _userRepository = new UserRepository();
        public frmAnimalDetail()
        {
            InitializeComponent();
        }

        public bool InsertOrUpdate { get; set; }
        public IAnimalRepository AnimalRepository { get; set; }
        public Animal AnimalInfo { get; set; }
        public Cage CageInfo { get; set; }
        public User UserInfo { get; set; }

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

        public void LoadCageList()
        {
            try
            {
                var cages = _cageRepository.GetAvailableCagesBySpecies(cboSpecies.Text);
                cboCageList.DataSource = cages;
                cboCageList.DisplayMember = "Name";
                cboCageList.ValueMember = "Cid";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on load list of cages", "Create or Update animal");
            }
        }

        public void LoadTrainerList()
        {
            try
            {
                var trainers = _userRepository.GetUsersByRole(3);
                cboTrainer.DataSource = trainers;
                cboTrainer.DisplayMember = "LastName";
                cboTrainer.ValueMember = "UserId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on load list of trainers", "Animal Management");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || cboSpecies.Text == ""
                || cboRegion.Text == "" || rtbDescription.Text == "")
            {
                MessageBox.Show("Please enter fullfield before saving", "Add/Update animal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
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

                    Cage cage = _cageRepository.GetCageByID(cboCageList.SelectedValue.ToString());
                    User trainer = _userRepository.GetUserByID(cboTrainer.SelectedValue.ToString());

                    if (!InsertOrUpdate)
                    {
                        AnimalRepository.AddNewAnimal(animal, cage, trainer);
                        MessageBox.Show("Add Successfully", "Add Animal", MessageBoxButtons.OK);
                    }
                    else
                    {
                        animal.AnimalId = txtAnimalId.Text;
                        AnimalRepository.UpdateAnimal(animal, cage, trainer);
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
            LoadTrainerList();
            if (InsertOrUpdate)
            {
                try
                {
                    txtAnimalId.Text = AnimalInfo.AnimalId;
                    CageInfo = _cageRepository.GetCageByAnimalId(txtAnimalId.Text);
                    UserInfo = _userRepository.GetTrainerByAnimalId(txtAnimalId.Text);
                    txtName.Text = AnimalInfo.Name;
                    cbRarity.Checked = AnimalInfo.Rarity;
                    cboRegion.Text = AnimalInfo.Region;
                    if (AnimalInfo.Status)
                        rbFemale.Checked = true;
                    else rbMale.Checked = true;
                    cboSpecies.Text = AnimalInfo.SpeciesName;
                    rtbDescription.Text = AnimalInfo.Description;
                    cboHealth.Text = AnimalInfo.HealthCheck;
                    cboCageList.SelectedValue = CageInfo.Cid;
                    cboTrainer.SelectedValue = UserInfo.UserId;
                    dtpBirthday.Text = AnimalInfo.Birthday.GetDateTimeFormats().First();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || txtName.Text.Length == 0)
            {
                errorProvider1.SetError(txtName, "Please enter name!");
                btnSave.Enabled = false;
            }
            else
            {
                errorProvider1.SetError(txtName, "");
                btnSave.Enabled = true;
            }
        }

        private void txtSpecies_TextChanged(object sender, EventArgs e)
        {
            if (!InsertOrUpdate)
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
            if (!InsertOrUpdate)
            {
                if (string.IsNullOrEmpty(cboRegion.Text) || cboRegion.Text.Length == 0)
                {
                    errorProvider1.SetError(cboRegion, "Please choose region!");
                    btnSave.Enabled = false;
                }
                else
                {
                    errorProvider1.SetError(cboRegion, "");
                }
            }
        }

        private void cboHealth_TextChanged(object sender, EventArgs e)
        {
            if (!InsertOrUpdate)
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
            if (dtpBirthday.Value > DateTime.Now)
            {
                errorProvider1.SetError(dtpBirthday, "Please enter date before today");
                btnSave.Enabled = false;
            }
            else
            {
                errorProvider1.SetError(dtpBirthday, "");
            }
        }

        private void cboSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCageList();
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            frmAnimalFood f = new frmAnimalFood
            {
                Animal = AnimalInfo
            };
            f.Show();
        }
    }
}
