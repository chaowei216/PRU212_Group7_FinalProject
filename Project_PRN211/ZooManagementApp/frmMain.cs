using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class frmMain : Form
    {

        private readonly string _role;
        private readonly string _email;
        public User User { get; set; }
        public frmMain()
        {
            InitializeComponent();
        }

        public frmMain(string role, string email) : this()
        {
            _role = role;
            Role.Text = _role;
            _email = email;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            frmLogin f = new frmLogin();
            f.ShowDialog();
        }

        private void mnuUser_Click(object sender, EventArgs e)
        {
            if (Role.Text == "Admin" && Role.Text == "Staff")
            {
                frmUser frmUser = new frmUser();
                frmUser.MdiParent = this;
                frmUser.Show();
            }
            else
            {
                MessageBox.Show("You Dont Have permission","Menu");
            }
        }

        private void frmMain_Load_1(object sender, EventArgs e)
        {

            IsMdiContainer = true;

        }

        private void mnuAnimals_Click(object sender, EventArgs e)
        {
            if (Role.Text is /*"Admin" or */"User")
            {
                frmAnimals frmAnimals = new frmAnimals("User", _email);
                frmAnimals.MdiParent = this;
                frmAnimals.Show();
            }

            else
            {
                mnuAnimals.Enabled=false; ;
                MessageBox.Show("You Dont Have permission", "Menu");
            }
        }

        private void mnuFood_Click(object sender, EventArgs e)
        {
            if (Role.Text == "Admin")
            {
                frmFood frmFood = new frmFood("Admin", _email);
                frmFood.MdiParent = this;
                frmFood.Show();
            }
            else if (Role.Text == "")
            {
                frmFood frmFood = new frmFood("User", _email);
                frmFood.MdiParent = this;
                frmFood.Show();
            }
        }

        private void mnuCage_Click(object sender, EventArgs e)
        {
            if (Role.Text == "Admin")
            {
                frmCage frmCage = new frmCage("Admin", _email);
                frmCage.MdiParent = this;
                frmCage.Show();
            }
            else
            {
                frmCage frmFood = new frmCage("User", _email);
                frmFood.MdiParent = this;
                frmFood.Show();
            }
        }

        private void mnuSchedule_Click(object sender, EventArgs e)
        {
            if (Role.Text == "Admin")
            {
                frmSchedule frmSchedule = new frmSchedule("Admin", _email);
                frmSchedule.MdiParent = this;
                frmSchedule.Show();
            }
            else
            {
                frmSchedule frmSchedule = new frmSchedule("User", _email);
                frmSchedule.MdiParent = this;
                frmSchedule.Show();
            }
        }
    }
}
