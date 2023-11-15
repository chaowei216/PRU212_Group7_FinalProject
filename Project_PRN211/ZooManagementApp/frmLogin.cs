using DataAccess.Repository;
using System.Diagnostics.Metrics;
using BussinessObject;
using System.Diagnostics.Eventing.Reader;

namespace ZooManagementApp
{
    public partial class frmLogin : Form
    {
        IUserRepository member = new UserRepository();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            var tmp = member.CheckLogin(txtEmail.Text, txtPassword.Text);
            if ( tmp != null && tmp.Role == 1)
            {
                frmMain f = new frmMain
                {
                    User = tmp,
                };
                this.Hide();
                f.ShowDialog();
         
            }
            else if (tmp != null && tmp.Role == 2)
            {
                frmMain f = new frmMain
                {
                    User = tmp,
                };
                this.Hide();
                f.ShowDialog();
            
            }
            else if (tmp != null && tmp.Role == 3) 
            {
                frmMain f = new frmMain{ User = tmp };
                this.Hide();
                f.ShowDialog();
            }
            else {
                MessageBox.Show("Failed to Login", "Login");
            }
        }
    }
}