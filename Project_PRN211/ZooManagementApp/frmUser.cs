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
    public partial class frmUser : Form
    {
        IUserRepository userRepository = new UserRepository();
        BindingSource source = new BindingSource();
        public User User { get; set; }
        public frmUser()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadUser();
        }
        private void LoadUser()
        {
            try
            {
                txtSearch.Enabled = true;
                List<User> users = new List<User>();
                if (User.Role == 2)
                {
                    users = userRepository.GetTrainers().ToList();
                } else users = userRepository.GetUsers().Where(u => u.Status == true).ToList();
                btnNew.Enabled = true;
                source = new BindingSource();
                source.DataSource = users.OrderBy(m => m.UserId);

                txtAddress.DataBindings.Clear();
                txtCountAnimal.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtFirstName.DataBindings.Clear();
                txtGender.DataBindings.Clear();
                txtID.DataBindings.Clear();
                txtLastName.DataBindings.Clear();
                txtPhone.DataBindings.Clear();
                txtRole.DataBindings.Clear();
                txtStartDate.DataBindings.Clear();

                txtAddress.DataBindings.Add("Text", source, "Address");
                txtCountAnimal.DataBindings.Add("Text", source, "CountAnimal");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtFirstName.DataBindings.Add("Text", source, "Firstname");
                txtGender.DataBindings.Add("Text", source, "Sex");
                txtID.DataBindings.Add("Text", source, "UserId");
                txtLastName.DataBindings.Add("Text", source, "Lastname");
                txtPhone.DataBindings.Add("Text", source, "Phone");
                txtRole.DataBindings.Add("Text", source, "Role");
                txtStartDate.DataBindings.Add("Text", source, "StartDate");

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = source;
                dataGridView1.Columns["EndDate"].Visible = false;
                dataGridView1.Columns["AnimalTrainers"].Visible = false;
                if (users.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ClearText()
        {
            txtAddress.Text = string.Empty;
            txtCountAnimal.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtGender.Text = string.Empty;
            txtID.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtRole.Text = string.Empty;
            txtSearch.Text = string.Empty;
            txtStartDate.Text = string.Empty;
            btnDelete.Text = string.Empty;
            btnNew.Text = string.Empty;
        }
        private User GetUserNow()
        {
            var user = new User
            {
                UserId = txtID.Text,
                Email = txtEmail.Text,
                Firstname = txtFirstName.Text,
                Lastname = txtLastName.Text,
                Address = txtAddress.Text,
                Phone = txtPhone.Text,
                Sex = Convert.ToBoolean(txtGender.Text),
                Status = false,
                Role = int.Parse(txtRole.Text),
                CountAnimal = int.Parse(txtCountAnimal.Text),
                StartDate = Convert.ToDateTime(txtStartDate.Text),
                //Password = txtPassword.Text,
                EndDate = null,
            };
            return user;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmUserDetail frmUserDetail = new frmUserDetail
            {
                Text = "Create Cage",
                Update = false,
                userRepository = userRepository,
            };
            if (frmUserDetail.ShowDialog() == DialogResult.OK)
            {
                LoadUser();
                source.Position = source.Position - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var user = GetUserNow();
            DialogResult result = MessageBox.Show("Do you wanna delete this user ?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                userRepository.UpdateUser(user);
                LoadUser();
            }
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            txtAddress.Enabled = false;
            txtCountAnimal.Enabled = false;
            txtEmail.Enabled = false;
            txtFirstName.Enabled = false;
            txtGender.Enabled = false;
            txtID.Enabled = false;
            txtLastName.Enabled = false;
            txtPhone.Enabled = false;
            txtRole.Enabled = false;
            txtSearch.Enabled = false;
            txtStartDate.Enabled = false;
            btnDelete.Enabled = false;
            btnNew.Enabled = false;
            dataGridView1.CellDoubleClick += PopUpMemberList;
        }

        private void PopUpMemberList(object? sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
            User selectedUser = (User)selectedRow.DataBoundItem;
            frmUserDetail frmUserDetail = new frmUserDetail
            {
                Text = "Update Product",
                Update = true,
                user = selectedUser,
                userRepository = userRepository,
            };
            if (frmUserDetail.ShowDialog() == DialogResult.OK)
            {
                LoadUser();
                source.Position = source.Position - 1;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text;
            if (!string.IsNullOrEmpty(searchText))
            {
                var matchingMembers = userRepository.GetUsers()
                                        .Where(member => member.Lastname.Contains(searchText)).ToList();
                var matchingMembersById = userRepository.GetUsers()
                                        .Where(member => member.UserId.ToString().Contains(searchText)).ToList();
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
    }
}
