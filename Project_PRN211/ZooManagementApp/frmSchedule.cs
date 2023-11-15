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
    public partial class frmSchedule : Form
    {
        IScheduleRepository repo = new ScheduleRepository();

        public frmSchedule(string v, string _email)
        {
            InitializeComponent();
        }

        public frmSchedule()
        {
            InitializeComponent();
        }

        private void txtScheduleId_TextChanged(object sender, EventArgs e)
        {

        }

        public void LoadSchedule()
        {
            try
            {
                var s = repo.GetSchedules();
                BindingSource source = new BindingSource();
                source.DataSource = s.Select(a => new
                {
                    a.ScheduleId,
                    a.ScheduleName,
                    a.Status
                }).ToList();
                txtScheduleId.DataBindings.Clear();
                txtScheduleName.DataBindings.Clear();
                txtStatus.DataBindings.Clear();

                txtScheduleId.DataBindings.Add("Text", source, "ScheduleId");
                txtScheduleName.DataBindings.Add("Text", source, "ScheduleName");
                txtStatus.DataBindings.Add("Text", source, "Status");

                dgv.DataSource = null;
                dgv.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void frmSchedule_Load(object sender, EventArgs e)
        {
            LoadSchedule();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d;

            d = MessageBox.Show("Do you really want to delete this ?", "Menu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (d == DialogResult.OK)
            {
                var a = new Schedule
                {
                   ScheduleId = (txtScheduleId.Text),
                };
                repo.DeleteSchedule(a);
                LoadSchedule();
            }
        }
    }
    }
