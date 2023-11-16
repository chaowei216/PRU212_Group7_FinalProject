using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ZooManagementApp
{
    public partial class frmMain : Form
    {
        frmUser frmUserr;
        frmCage frmCagee;
        frmSchedule frmSchedulee;
        frmFood frmFoodd;
        frmAnimals frmAnimalss;

        bool click = false;
        public User User { get; set; }
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuUser_Click(object sender, EventArgs e)
        {
            frmUserr.TopLevel = false;
            panel.Controls.Add(frmUserr);
            frmUserr.Activate();
            frmUserr.Show();
            frmUserr.BringToFront();

            frmAnimalss.Hide();
            frmCagee.Hide();
            frmFoodd.Hide();
            frmSchedulee.Hide();
        }

        private void frmMain_Load_1(object sender, EventArgs e)
        {

            IsMdiContainer = true;
            panel.Enabled = true;

            frmUserr = new frmUser
            {
                User = User,
            };
            frmCagee = new frmCage
            {
                User = User,
            };
            frmSchedulee = new frmSchedule
            {
                User = User,
            };
            frmFoodd = new frmFood
            {
                User = User,
            };
            frmAnimalss = new frmAnimals
            {
                User = User
            };
            if (User.Role == 2)
            {
                Role.Text = "Staff";
                mnuAnimals.Enabled = true;
                mnuFood.Enabled = true;
                mnuSchedule.Enabled = true;
                mnuCage.Enabled = true;
                mnuUser.Enabled = true;
            }
            else if (User.Role == 3)
            {
                Role.Text = "Zoo Trainer";
                mnuAnimals.Enabled = true;
                mnuFood.Enabled = true;
                mnuSchedule.Enabled = false;
                mnuCage.Enabled = true;
                mnuUser.Enabled = false;
            }
            else if (User.Role == 1)
            {
                mnuAnimals.Enabled = false;
                mnuFood.Enabled = false;
                mnuSchedule.Enabled = false;
                mnuCage.Enabled = false;
                mnuUser.Enabled = true;
                Role.Text = "Admin";
            }
        }

        private void mnuAnimals_Click(object sender, EventArgs e)
        {
            frmAnimalss.TopLevel = false;
            panel.Controls.Add(frmAnimalss);
            frmAnimalss.Activate();
            frmAnimalss.Show();
            frmAnimalss.BringToFront();

            frmUserr.Hide();
            frmCagee.Hide();
            frmFoodd.Hide();
            frmSchedulee.Hide();
            this.Refresh();

        }

        private void mnuFood_Click(object sender, EventArgs e)
        {
            frmFoodd.TopLevel = false;
            panel.Controls.Add(frmFoodd);
            frmFoodd.BringToFront();

            frmUserr.Hide();
            frmAnimalss.Hide();
            frmCagee.Hide();
            frmFoodd.Show();
            frmSchedulee.Hide();
        }

        private void mnuCage_Click(object sender, EventArgs e)
        {
            frmCagee.TopLevel = false;
            panel.Controls.Add(frmCagee);
            frmCagee.BringToFront();

            frmUserr.Hide();
            frmAnimalss.Hide();
            frmCagee.Show();
            frmFoodd.Hide();
            frmSchedulee.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Menu", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {

                this.Hide();
            }

        }

        private void mnuSchedule_Click_1(object sender, EventArgs e)
        {
            frmSchedulee.TopLevel = false;
            panel.Controls.Add(frmSchedulee);
            frmSchedulee.Show();
            frmSchedulee.BringToFront();
            frmUserr.Hide();
            frmAnimalss.Hide();
            frmCagee.Hide();
            frmFoodd.Hide();
        }
    }
}
