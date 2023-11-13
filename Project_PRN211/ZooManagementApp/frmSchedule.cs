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
    public partial class frmSchedule : Form
    {
        private readonly string _role;
        private readonly string _email;
        public frmSchedule()
        {
            InitializeComponent();
        }
        public frmSchedule( string role, string email) :this ()
        {
         
            _role=role;
            _email=email;
        }
    }
}
