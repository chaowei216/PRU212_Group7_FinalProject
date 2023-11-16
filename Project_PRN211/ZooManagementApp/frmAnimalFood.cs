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
    public partial class frmAnimalFood : Form
    {
        public Animal Animal { get; set; }
        IFoodRepository foodRepository = new FoodRepository();
        bool CreateOrUpdate = false;
        public frmAnimalFood()
        {
            InitializeComponent();
        }

        public void ClearText()
        {
            cboFoodList.SelectedIndex = 0;
            dtpStartEat.Text = string.Empty;
            dtpEndEat.Text = string.Empty;
            nudAmount.Value = 0;
        }

        public void EnableText(bool status)
        {
            cboFoodList.Enabled = status;
            dtpStartEat.Enabled = status;
            dtpEndEat.Enabled = status;
            nudAmount.Enabled = status;
        }

        public void LoadFoodList()
        {
            try
            {
                var foodList = foodRepository.GetFoods();
                cboFoodList.DataSource = foodList;
                cboFoodList.DisplayMember = "Fname";
                cboFoodList.ValueMember = "FoodId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on load list of foods", "Animal Food");
            }
        }

        public void LoadAnimalFoodList()
        {
            try
            {
                var foods = foodRepository.GetFoodOfAnimal(txtAnimalId.Text);
                BindingSource source = new BindingSource();
                source.DataSource = foods.Select(a => new
                {
                    a.Food.Fname,
                    a.StartEat,
                    a.EndEat,
                    a.Amount
                }).ToList();

                cboFoodList.DataBindings.Clear();
                dtpStartEat.DataBindings.Clear();
                dtpEndEat.DataBindings.Clear();
                nudAmount.DataBindings.Clear();

                cboFoodList.DataBindings.Add("Text", source, "FName");
                dtpStartEat.DataBindings.Add("Text", source, "StartEat");
                dtpEndEat.DataBindings.Add("Text", source, "EndEat");
                nudAmount.DataBindings.Add("Value", source, "Amount");

                dgvAnimalFoodList.DataSource = null;
                dgvAnimalFoodList.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on load list food of animal", "Animal Food");
            }
        }

        private void frmAnimalFood_Load(object sender, EventArgs e)
        {
            txtAnimalId.Text = Animal.AnimalId.ToString();
            txtAnimalId.Enabled = false;
            btnSave.Enabled = false;
            EnableText(false);
            LoadFoodList();
            LoadAnimalFoodList();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Add")
            {
                btnAdd.Text = "Cancel";
                EnableText(true);
                ClearText();
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                CreateOrUpdate = true;
                dgvAnimalFoodList.ClearSelection();
                btnSave.Enabled = true;
            }
            else
            {
                btnAdd.Text = "Add";
                EnableText(false);
                btnUpdate.Enabled = true;
                CreateOrUpdate = false;
                btnDelete.Enabled = true;
                btnSave.Enabled = false;
                LoadAnimalFoodList();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Text == "Update")
            {
                btnUpdate.Text = "Cancel";
                EnableText(true);
                cboFoodList.Enabled = false;
                dtpStartEat.Enabled = false;
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
                btnSave.Enabled = true;
            }
            else
            {
                btnUpdate.Text = "Update";
                EnableText(false);
                btnAdd.Enabled = true;
                btnDelete.Enabled = true;
                btnSave.Enabled = false;
                LoadAnimalFoodList();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dtpStartEat.Value.Date > dtpEndEat.Value.Date)
            {
                MessageBox.Show("Start date must be less than End Date", "Animal Food", MessageBoxButtons.OK, MessageBoxIcon.Information,
                                MessageBoxDefaultButton.Button1);
            }
            else if (nudAmount.Value == null || nudAmount.Value < 1)
            {
                MessageBox.Show("Amount must be greater than 0", "Animal Food", MessageBoxButtons.OK, MessageBoxIcon.Information,
                                MessageBoxDefaultButton.Button1);
            }
            else
            {
                AnimalFood af = new AnimalFood
                {
                    AnimalId = txtAnimalId.Text,
                    FoodId = cboFoodList.SelectedValue.ToString(),
                    StartEat = dtpStartEat.Value.Date,
                    EndEat = dtpEndEat.Value.Date,
                    Amount = int.Parse(nudAmount.Text),
                };

                if (CreateOrUpdate)
                {
                    if (foodRepository.AddFoodForAnimal(af))
                    {
                        btnAdd.Text = "Add";
                        btnUpdate.Enabled = true;
                        btnDelete.Enabled = true;
                        CreateOrUpdate = false;
                        EnableText(false);
                        btnSave.Enabled = false;
                        LoadAnimalFoodList();
                        MessageBox.Show("Add successfully", "Update Food For Animal");
                    }
                    else
                    {
                        MessageBox.Show("Fail to add food", "Add Food For Animal");
                    }

                }
                else
                {
                    if (foodRepository.UpdateFoodForAnimal(af))
                    {
                        btnUpdate.Text = "Update";
                        btnAdd.Enabled = true;
                        btnDelete.Enabled = true;
                        EnableText(false);
                        btnSave.Enabled = false;
                        LoadAnimalFoodList();
                        MessageBox.Show("Update successfully", "Update Food For Animal");
                    }
                    else
                    {
                        MessageBox.Show("Fail to update food", "Update Food For Animal");
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Are you sure you wanna delete it?", "Animal Food",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button1);
            if (d == DialogResult.Yes)
            {
                var af = new AnimalFood
                {
                    AnimalId = txtAnimalId.Text,
                    FoodId = cboFoodList.SelectedValue.ToString()
                };
                if (foodRepository.DeleteFoodForAnimal(af))
                {
                    LoadAnimalFoodList();
                    MessageBox.Show("Delete successfully", "Delete Food");
                }
                else
                {
                    MessageBox.Show("Animal didnt eat it anymore!", "Delete Food");
                }
            }
        }
    }
}
