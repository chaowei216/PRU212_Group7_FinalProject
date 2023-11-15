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
    public partial class frmFood : Form
    {
        IFoodRepository foodRepository = new FoodRepository();
        BindingSource source = new BindingSource();
        bool CreateOrUpdate = false;
        public User User { get; set; }
        public frmFood()
        {
            InitializeComponent();
        }

        private void ClearText()
        {
            txtFoodId.Text = string.Empty;
            txtFoodName.Text = string.Empty;
            nudQuantity.Value = 0;
            dtpImportDate.Text = string.Empty;
            dtpExpiredDate.Text = string.Empty;
            cboCategoryName.SelectedIndex = 0;
        }

        private void EnableText(bool status)
        {
            txtFoodId.Enabled = status;
            txtFoodName.Enabled = status;
            nudQuantity.Enabled = status;
            dtpImportDate.Enabled = status;
            dtpExpiredDate.Enabled = status;
            cboCategoryName.Enabled = status;
        }

        public void LoadFoodList()
        {
            try
            {
                var foodList = foodRepository.GetFoods();
                source.DataSource = foodList.Select(a => new
                {
                    a.FoodId,
                    a.Fname,
                    a.Quantity,
                    a.ImportDate,
                    a.ExpiredDate,
                    a.CategoryName
                }).ToList();

                txtFoodId.DataBindings.Clear();
                txtFoodName.DataBindings.Clear();
                nudQuantity.DataBindings.Clear();
                dtpImportDate.DataBindings.Clear();
                dtpExpiredDate.DataBindings.Clear();
                cboCategoryName.DataBindings.Clear();

                txtFoodId.DataBindings.Add("Text", source, "FoodId");
                txtFoodName.DataBindings.Add("Text", source, "FName");
                nudQuantity.DataBindings.Add("Value", source, "Quantity");
                dtpImportDate.DataBindings.Add("Text", source, "ImportDate");
                dtpExpiredDate.DataBindings.Add("Text", source, "ExpiredDate");
                cboCategoryName.DataBindings.Add("Text", source, "CategoryName");

                dgvFoodList.DataSource = null;
                dgvFoodList.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Food Management");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Are you sure you wanna close it?", "Food Management", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button1);
            if (d == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void frmFood_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            EnableText(false);
            LoadFoodList();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (btnNew.Text == "New")
            {
                btnNew.Text = "Cancel";
                btnSave.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                ClearText();
                EnableText(true);
                txtFoodId.Enabled = false;
                CreateOrUpdate = true;
                dgvFoodList.ClearSelection();
            }
            else
            {
                btnNew.Text = "New";
                btnSave.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                CreateOrUpdate = false;
                EnableText(false);
                LoadFoodList();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Text == "Update")
            {
                btnUpdate.Text = "Cancel";
                btnSave.Enabled = true;
                btnNew.Enabled = false;
                btnDelete.Enabled = false;
                EnableText(true);
                txtFoodId.Enabled = false;
                txtFoodName.Enabled = false;
                cboCategoryName.Enabled = false;
            }
            else
            {
                btnUpdate.Text = "Update";
                btnSave.Enabled = false;
                btnNew.Enabled = true;
                btnDelete.Enabled = true;
                EnableText(false);
                LoadFoodList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d;
                d = MessageBox.Show("Are you sure you wanna delete it?", "Delete Food",
                                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (d == DialogResult.OK)
                {
                    foodRepository.DeleteFood(txtFoodId.Text);
                    LoadFoodList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Food");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var foodList = foodRepository.SearchFoodByName(txtSearch.Text);
                source.DataSource = foodList.Select(a => new
                {
                    a.FoodId,
                    a.Fname,
                    a.Quantity,
                    a.ImportDate,
                    a.ExpiredDate,
                    a.CategoryName
                }).ToList();

                txtFoodId.DataBindings.Clear();
                txtFoodName.DataBindings.Clear();
                nudQuantity.DataBindings.Clear();
                dtpImportDate.DataBindings.Clear();
                dtpExpiredDate.DataBindings.Clear();
                cboCategoryName.DataBindings.Clear();

                txtFoodId.DataBindings.Add("Text", source, "FoodId");
                txtFoodName.DataBindings.Add("Text", source, "FName");
                nudQuantity.DataBindings.Add("Value", source, "Quantity");
                dtpImportDate.DataBindings.Add("Text", source, "ImportDate");
                dtpExpiredDate.DataBindings.Add("Text", source, "ExpiredDate");
                cboCategoryName.DataBindings.Add("Text", source, "CategoryName");

                dgvFoodList.DataSource = null;
                dgvFoodList.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Food Management");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFoodName.Text == "" || nudQuantity.Text == "" || dtpExpiredDate.Value == null ||
                dtpImportDate.Value == null || cboCategoryName.Text == "")
            {
                MessageBox.Show("All field are required!", "Food Management", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            }
            else if (txtFoodName.TextLength < 3 || txtFoodName.TextLength > 50)
            {
                MessageBox.Show("Food Name must be in range 3 - 50 characters", "Food Management", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            }
            else if (dtpImportDate.Value > dtpExpiredDate.Value)
            {
                MessageBox.Show("Import date must be less than expired date", "Food Management", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            }
            else if (nudQuantity.Value < 1)
            {
                MessageBox.Show("Quantity must be greater than 0", "Food Management", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            }
            else
            {
                try
                {
                    Food f = new Food
                    {
                        Fname = txtFoodName.Text,
                        Quantity = int.Parse(nudQuantity.Text),
                        ImportDate = dtpImportDate.Value.Date,
                        ExpiredDate = dtpExpiredDate.Value.Date,
                        CategoryName = cboCategoryName.Text,
                    };
                    DialogResult d;
                    d = MessageBox.Show("Are you sure you wanna create/change it?", "Food Management",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (d == DialogResult.OK)
                    {
                        if (CreateOrUpdate)
                        {
                            foodRepository.AddNewFood(f);
                            CreateOrUpdate = false;
                            btnNew.Text = "New";
                            btnUpdate.Enabled = true;
                            btnDelete.Enabled = true;

                        }
                        else
                        {
                            f.FoodId = txtFoodId.Text;
                            foodRepository.UpdateFood(f);
                            btnUpdate.Text = "Update";
                            btnNew.Enabled = true;
                            btnDelete.Enabled = true;

                        }
                        btnSave.Enabled = false;
                        EnableText(false);
                        LoadFoodList();
                    } 

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Food Management");
                }
            }
        }
    }
}
