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
        public User User { get; set; }
        public frmFood()
        {
            InitializeComponent();
        }

        private void ClearText()
        {
            txtFoodId.Text = string.Empty;
            txtFoodName.Text = string.Empty;
            nudQuantity.Text = string.Empty;
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
                BindingSource source = new BindingSource();
                source.DataSource = foodList;

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
                dgvFoodList.DataSource = foodList;
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Food Management");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Are you sure you wanna close it?", "Food Management", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button1);
            if(d == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmFood_Load(object sender, EventArgs e)
        {
            EnableText(false);
            LoadFoodList();
        }
    }
}
