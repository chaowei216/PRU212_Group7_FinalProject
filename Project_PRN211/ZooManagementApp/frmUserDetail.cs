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
    public partial class frmUserDetail : Form
    {
        public IUserRepository userRepository { get; set; }
        public bool Update { get; set; }
        public User user { get; set; }
        public frmUserDetail()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            /* 
           string pattern = "^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$";
           if (Regex.IsMatch(txtEmail.Text, pattern) == false)
           {
               MessageBox.Show("Invalid Email");
               return;
           }
           if (Regex.IsMatch(txtFirstName.Text, "^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$") == false)
           {
               MessageBox.Show("Invalid First Name");
               return;
           }
           if (Regex.IsMatch(txtLastName.Text, "^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$") == false)
           {
               MessageBox.Show("Invalid Last Name");
               return;
           }

           if (Regex.IsMatch(txtPhone.Text, "^[+]*[(]{0,1}[0-9]{1,4}[)]{0,1}[-\\s\\./0-9]*$") == false)
           {
               MessageBox.Show("Phone start with 0");
               return;
           }
           */
            try
            {
                if (Update)
                {
                    var userObject = new User
                    {
                        UserId = user.UserId,
                        Email = txtEmail.Text,
                        Firstname = txtFirstName.Text,
                        Lastname = txtLastName.Text,
                        Address = txtAddress.Text,
                        Phone = user.Phone,
                        Sex = user.Sex,
                        Status = true,
                        Role = user.Role,
                        CountAnimal = user.CountAnimal,
                        StartDate = user.StartDate,
                        EndDate = null,
                        Password = "123456"
                    };
                    userRepository.UpdateUser(userObject);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    string userId = "";
                    using var db = new ZooManagementFormContext();
                    Boolean gender = true;
                    if (cboGender.SelectedItem == "Female")
                    {
                        gender = false;
                    }
                    int role = 2;
                    if (cboRole.SelectedItem == "Zoo Trainer")
                    {
                        role = 3;
                    }
                    List<User> uList = db.Users.Where(u => u.Role == role).ToList();
                    int count = uList.Count() + 1;
                    if (cboRole.SelectedItem == "Staff")
                        userId = "ST" + count.ToString().PadLeft(4, '0');
                    else if (cboRole.SelectedItem == "Zoo Trainer")
                        userId = "ZT" + count.ToString().PadLeft(4, '0');

                    var userAdd = new User
                    {
                        UserId = userId,
                        Email = txtEmail.Text,
                        Firstname = txtFirstName.Text,
                        Lastname = txtLastName.Text,
                        Address = txtAddress.Text,
                        Phone = txtPhone.Text,
                        Sex = gender,
                        Status = true,
                        Role = role,
                        CountAnimal = 0,
                        StartDate = DateTime.Now,
                        EndDate = null,
                        Password = "123456"
                    };
                    userRepository.AddUser(userAdd);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUserDetail_Load(object sender, EventArgs e)
        {
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.ActiveControl = txtID;
            txtID.Enabled = !Update;
            if (Update)
            {
                string gender = user.Sex == true ? "Male" : "Female";
                string role = user.Role == 2 ? "Staff" : "Zoo Trainer";
                txtID.Enabled = false;
                txtEmail.Enabled = false;
                txtCountAnimal.Enabled = false;
                txtStartDate.Enabled = false;
                cboGender.Enabled = false;
                txtPhone.Enabled = false;
                cboRole.Enabled = false;

                txtAddress.Text = user.Address;
                txtCountAnimal.Text = user.CountAnimal.ToString();
                txtEmail.Text = user.Email;
                txtFirstName.Text = user.Firstname;
                cboGender.Text = gender;
                txtID.Text = user.UserId;
                txtLastName.Text = user.Lastname;
                txtPhone.Text = user.Phone;
                cboRole.Text = role;
                txtStartDate.Text = user.StartDate.ToString();
            }
            else
            {
                txtStartDate.Enabled = false;
                txtCountAnimal.Enabled = false;
                txtID.Enabled = false;
                string roleStaff = "Staff";
                string roleZooTrainer = "Zoo Trainer";
                cboRole.Items.Add(roleStaff);
                cboRole.Items.Add(roleZooTrainer);
            }
        }
    }
}
