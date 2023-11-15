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

<<<<<<< HEAD




=======
>>>>>>> e1bd7665b499fc8caff0ab5b619fd84b215926a2
        private void mnuUser_Click(object sender, EventArgs e)
        {
            frmUserr.TopLevel = false;
            panel.Controls.Add(frmUserr);
            frmUserr.Activate();
            frmUserr.Show();
            frmUserr.BringToFront();
            frmUserr.Refresh();

<<<<<<< HEAD

                frmUser.Show();
            }
            else
            {

                MessageBox.Show("You Don't Have permission", "Menu");
            }
=======
            frmAnimalss.Hide();
            frmCagee.Hide();
            frmFoodd.Hide();
            frmSchedulee.Hide();
>>>>>>> e1bd7665b499fc8caff0ab5b619fd84b215926a2
        }

        private void frmMain_Load_1(object sender, EventArgs e)
        {

            IsMdiContainer = true;
<<<<<<< HEAD



            frmLoginn = new frmLogin();
            frmMainn = new frmMain();
            frmCagee = new frmCage("User", _email);
            frmSchedulee = new frmSchedule("User", _email);
            frmFoodd = new frmFood("User", _email);
            frmAnimalss = new frmAnimals("User", _email);
            if (User.Role == 2 || User.Role == 3)
=======
            panel.Enabled = true;

            frmUserr = new frmUser();
            frmCagee = new frmCage();
            frmSchedulee = new frmSchedule();
            frmFoodd = new frmFood
>>>>>>> e1bd7665b499fc8caff0ab5b619fd84b215926a2
            {
                User = User
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
                mnuSchedule.Enabled = true;
                mnuCage.Enabled = true;
                mnuUser.Enabled = false;
            }
            else if (User.Role == 1)
            {
                mnuAnimals.Enabled = false;
                mnuFood.Enabled = false;
                mnuSchedule.Enabled = false;
                mnuCage.Enabled = false;
                Role.Text = "Admin";
            }
        }

        private void mnuAnimals_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (Role.Text is "Staff" or "Zoo Trainer")
            {
=======
            frmAnimalss.TopLevel = false;
            panel.Controls.Add(frmAnimalss);
            frmAnimalss.Activate();
            frmAnimalss.Show();
            frmAnimalss.BringToFront();
>>>>>>> e1bd7665b499fc8caff0ab5b619fd84b215926a2

            frmUserr.Hide();
            frmCagee.Hide();
            frmFoodd.Hide();
            frmSchedulee.Hide();
            this.Refresh();

<<<<<<< HEAD

                frmAnimalss.TopLevel = false;
                panel.Controls.Add(frmAnimalss);
                frmAnimalss.BringToFront();
                frmAnimalss.MdiParent = null;
                frmAnimalss.Show();
                frmCagee.Hide();
                frmFoodd.Hide();



            }

            else
            {

                MessageBox.Show("You Don't Have permission", "Menu");
            }

=======
>>>>>>> e1bd7665b499fc8caff0ab5b619fd84b215926a2
        }

        private void mnuFood_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (Role.Text == "Staff")
            {


                frmFoodd.TopLevel = false;
                panel.Controls.Add(frmFoodd);
                frmFoodd.BringToFront();

                frmFoodd.Show();
                frmAnimalss.Hide();
                frmCagee.Hide();
                frmSchedulee.Hide();
            }
            else if (Role.Text == "Zoo Trainer")
            {


                frmFoodd.TopLevel = false;
                panel.Controls.Add(frmFoodd);
                frmFoodd.BringToFront();

                frmFoodd.Show();
                frmAnimalss.Hide();
                frmCagee.Hide();
                frmSchedulee.Hide();
            }
            else
            {
                mnuFood.Enabled=false;
                MessageBox.Show("You Don't Have permission", "Menu");

            }
=======
            frmFoodd.TopLevel = false;
            panel.Controls.Add(frmFoodd);
            frmFoodd.BringToFront();

            frmUserr.Hide();
            frmAnimalss.Hide();
            frmCagee.Hide();
            frmFoodd.Show();
            frmSchedulee.Hide();
>>>>>>> e1bd7665b499fc8caff0ab5b619fd84b215926a2
        }

        private void mnuCage_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (Role.Text == "Staff")
            {


                frmCagee.TopLevel = false;
                panel.Controls.Add(frmCagee);
                frmCagee.BringToFront();

                frmCagee.Show();
                frmAnimalss.Hide();
                frmSchedulee.Hide();
                frmFoodd.Hide();
            }
            else if (Role.Text == "Zoo Trainer")
            {
                frmCagee.TopLevel = false;
                panel.Controls.Add(frmCagee);
                frmCagee.BringToFront();

                frmCagee.Show();
                frmAnimalss.Hide();
                frmSchedulee.Hide();
                frmFoodd.Hide();
            }
            else
            {
                mnuCage.Checked=false;
                MessageBox.Show("You Don't Have permission", "Menu");
=======
            frmCagee.TopLevel = false;
            panel.Controls.Add(frmCagee);
            frmCagee.BringToFront();
>>>>>>> e1bd7665b499fc8caff0ab5b619fd84b215926a2

            frmUserr.Hide();
            frmAnimalss.Hide();
            frmCagee.Show();
            frmFoodd.Hide();
            frmSchedulee.Hide();
        }

        private void mnuSchedule_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (Role.Text == "Staff")
            {
                frmSchedulee.MdiParent = null;
                frmSchedulee.TopLevel = false;
                panel.Controls.Add(frmSchedulee);

                frmSchedulee.Activate();

                frmSchedulee.Show();
                frmSchedulee.BringToFront();
                //frmSchedulee.Refresh();
                frmAnimalss.Hide();
                frmCagee.Hide();
                frmFoodd.Hide();
            }
            else if (Role.Text == "Zoo Trainer")
            {
                frmSchedulee.TopLevel = false;
                panel.Controls.Add(frmSchedulee);

                frmSchedulee.Show();
                frmSchedulee.BringToFront();
                frmAnimalss.Hide();
                frmCagee.Hide();
                frmFoodd.Hide();
            }
            else
            {
                mnuFood.Enabled=false;
                MessageBox.Show("You Don't Have permission", "Menu");

            }
=======
            frmSchedulee.TopLevel = false;
            panel.Controls.Add(frmSchedulee);
            frmSchedulee.BringToFront();
            frmUserr.Hide();
            frmAnimalss.Hide();
            frmCagee.Hide();
            frmFoodd.Hide();
            frmSchedulee.Show();
>>>>>>> e1bd7665b499fc8caff0ab5b619fd84b215926a2
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Menu", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {

                this.Hide();
<<<<<<< HEAD
                frmLoginn.ShowDialog();
=======
>>>>>>> e1bd7665b499fc8caff0ab5b619fd84b215926a2
            }

        }
    }
}
