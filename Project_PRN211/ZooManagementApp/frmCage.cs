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
    public partial class frmCage : Form
    {
        ICageRepository cageRepository = new CageRepository();
        BindingSource source = new BindingSource();
        private readonly string _role;
        private readonly string _email;
        public frmCage()
        {
            InitializeComponent();
        }
        public frmCage(string role, string email): this()
        {
            _email = email;
            _role = role;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadCage();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmCageDetail frmCageDetail = new frmCageDetail
            {
                Text = "Create Cage",
                Update = false,
                cageRepository = cageRepository,
            };
            if (frmCageDetail.ShowDialog() == DialogResult.OK)
            {
                LoadCage();
                source.Position = source.Position - 1;
            }
        }
        private Cage GetCageNow()
        {
            var cage = new Cage
            {
                Cid = txtID.Text,
                AreaId = txtAreaID.Text,
                Name = txtName.Text,
                AnimalQuantity = Convert.ToInt16(txtQuantity.Text),
                MaxCapacity = int.Parse(txtCapacity.Text),
            };
            return cage;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text;
            if (!string.IsNullOrEmpty(searchText))
            {
                var matchingMembers = cageRepository.GetAllCages()
                                        .Where(member => member.Name.Contains(searchText)).ToList();
                var matchingMembersById = cageRepository.GetAllCages()
                                        .Where(member => member.Cid.ToString().Contains(searchText)).ToList();
                if (matchingMembers.Count > 0)
                {
                    dataGridView1.DataSource = new BindingSource(matchingMembers, null);
                }
                else if (matchingMembersById.Count > 0)
                {
                    dataGridView1.DataSource = new BindingSource(matchingMembersById, null);
                }
                if (matchingMembers.Count > 0)
                {
                    dataGridView1.Rows[0].Selected = true;
                }
                else if (matchingMembersById.Count > 0)
                {
                    dataGridView1.Rows[0].Selected = true;
                }
                else
                {
                    MessageBox.Show("No matching members found");
                    dataGridView1.DataSource = null; // Clear the data grid view
                }
            }
            else
            {
                MessageBox.Show("Please enter a search term.");
            }
        }

        private void frmCage_Load(object sender, EventArgs e)
        {
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            txtID.Enabled = false;
            txtName.Enabled = false;
            txtCapacity.Enabled = false;
            txtAreaID.Enabled = false;
            txtQuantity.Enabled = false;
            txtSearch.Enabled = false;
            btnDelete.Enabled = false;
            btnNew.Enabled = false;
            dataGridView1.CellDoubleClick += PopUpMemberList;
        }
        private void ClearText()
        {
            txtAreaID.Text = string.Empty;
            txtCapacity.Text = string.Empty;
            txtID.Text = string.Empty;
            txtName.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtSearch.Text = string.Empty;
        }
        private void LoadCage()
        {
            var cage = cageRepository.GetAllCages().ToList();
            try
            {
                txtSearch.Enabled = true;
                source.DataSource = cage;
                btnNew.Enabled = true;
                txtAreaID.DataBindings.Clear();
                txtCapacity.DataBindings.Clear();
                txtID.DataBindings.Clear();
                txtName.DataBindings.Clear();
                txtQuantity.DataBindings.Clear();

                txtAreaID.DataBindings.Add("Text", source, "AreaID");
                txtCapacity.DataBindings.Add("Text", source, "MaxCapacity");
                txtID.DataBindings.Add("Text", source, "Cid");
                txtName.DataBindings.Add("Text", source, "Name");
                txtQuantity.DataBindings.Add("Text", source, "AnimalQuantity");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = source;
                dataGridView1.Columns["Name"].Width = 160;
                dataGridView1.Columns["AnimalQuantity"].Width = 145;
                dataGridView1.Columns["MaxCapacity"].Width = 145;
                dataGridView1.Columns["Area"].Visible = false;
                dataGridView1.Columns["AnimalCages"].Visible = false;

                if (cage.Count == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void PopUpMemberList(object? sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
            Cage selectedCage = (Cage)selectedRow.DataBoundItem;
            frmCageDetail frmCageDetail = new frmCageDetail
            {
                Text = "Update Product",
                Update = true,
                Cage = selectedCage,
                cageRepository = cageRepository,
            };
            if (frmCageDetail.ShowDialog() == DialogResult.OK)
            {
                LoadCage();
                source.Position = source.Position - 1;
            }
        }
    }
}
