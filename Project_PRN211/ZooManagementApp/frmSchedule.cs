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
        public User User { get; set; }

        public frmSchedule()
        {
            InitializeComponent();
        }

        public void ClearText()
        {
            txtScheduleId.Text = string.Empty;
            txtScheduleName.Text = string.Empty;
            txtStatus.Text = string.Empty;
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
            btnSave.Enabled = false;
            txtScheduleId.Enabled = false;
            txtScheduleName.Enabled = false;
            txtStatus.Enabled = false;
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (btnNew.Text == "New")
            {
                btnNew.Text = "Cancel";
                btnSave.Enabled = true;
                btnDelete.Enabled = false;
                txtScheduleName.Enabled = true;
                txtScheduleId.Enabled = false;
                txtStatus.Enabled = false;
                ClearText();
                dgv.ClearSelection();
            }
            else
            {
                btnNew.Text = "New";
                btnSave.Enabled = false;
                btnDelete.Enabled = true;
                LoadSchedule();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtScheduleName.Text == "")
            {
                MessageBox.Show("All fields are required!!", "Schedule Management", MessageBoxButtons.OK,
                                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            }
            else
            {
                try
                {
                    Schedule sc = new Schedule
                    {
                        ScheduleName = txtScheduleName.Text,
                    };

                    if (repo.AddNewSchedule(sc))
                    {
                        MessageBox.Show("Add Successfully", "Schedule Management");
                        btnSave.Enabled = false;
                        btnNew.Text = "New";
                        btnDelete.Enabled = true;
                        txtScheduleName.Enabled = false;
                        LoadSchedule();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Schedule Management");
                }

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
