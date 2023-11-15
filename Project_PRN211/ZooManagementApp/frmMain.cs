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

        private readonly string _role;
        private readonly string _email;
        frmLogin frmLoginn;
        frmMain frmMainn;
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
            if (User.Role == 1)
            {
                frmUser frmUser = new frmUser();
                frmUser.TopLevel = false;
                panel.Controls.Add(frmUser);
                frmUser.BringToFront();


                frmUser.Show();
            }
            else
            {
              
                MessageBox.Show("You Don't Have permission", "Menu");
            }
        }

        private void frmMain_Load_1(object sender, EventArgs e)
        {

            IsMdiContainer = true;
         
            
            
            frmLoginn = new frmLogin();
            frmMainn = new frmMain();
            frmCagee = new frmCage("User", _email);
            frmSchedulee = new frmSchedule("User", _email);
            frmFoodd = new frmFood("User", _email);
            frmAnimalss = new frmAnimals("User", _email);
            if (User.Role == 2 || User.Role == 3)
            {
                if (User.Role == 2) Role.Text = "Staff";
                if (User.Role == 3) Role.Text = "Zoo Trainer";
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
            if (Role.Text is "Staff" or "Zoo Trainer" )
            {


            
                frmAnimalss.TopLevel = false;
                panel.Controls.Add(frmAnimalss);
                frmAnimalss.BringToFront();

                frmAnimalss.Show();
                frmCagee.Hide();
                frmFoodd.Hide();
             
              
                
            }

            else
            {
             
                MessageBox.Show("You Don't Have permission", "Menu");
            }
           
        }

        private void mnuFood_Click(object sender, EventArgs e)
        {
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
        }

        private void mnuCage_Click(object sender, EventArgs e)
        {
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

            }
        }

        private void mnuSchedule_Click(object sender, EventArgs e)
        {
            if (Role.Text == "Staff")
            {
              frmSchedulee.TopLevel = false;
                panel.Controls.Add(frmSchedulee);
                    frmSchedulee.BringToFront();
                frmSchedulee.Show();
                frmAnimalss.Hide();
               frmCagee.Hide();
                frmFoodd.Hide();
            }
            else if (Role.Text == "Zoo Trainer")
            {
                frmSchedulee.TopLevel = false;
                panel.Controls.Add(frmSchedulee);
                frmSchedulee.BringToFront();
                frmSchedulee.Show();
                frmAnimalss.Hide();
              frmCagee.Hide();
                frmFoodd.Hide();
            }
            else
            {
                mnuFood.Enabled=false;
                MessageBox.Show("You Don't Have permission", "Menu");

            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Menu", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {

               this.Hide();
                frmLoginn.ShowDialog();  
            }
            
        }
    }
}
