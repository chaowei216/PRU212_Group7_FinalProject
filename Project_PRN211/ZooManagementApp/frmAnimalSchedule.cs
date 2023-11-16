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
    public partial class frmAnimalSchedule : Form
    {
        public Animal Animal { get; set; }
        IScheduleRepository repo = new ScheduleRepository();
        bool CreateOrUpdate = false;
        public frmAnimalSchedule()
        {
            InitializeComponent();
        }

        private void ClearText()
        {
            txtAnimalId.Text = Animal.AnimalId;
            cboScheduleName.SelectedIndex = 0;
            dtpTime.Text = string.Empty;
            rtbDescription.Text = string.Empty;
        }

        private void EnableText(bool status)
        {
            txtAnimalId.Enabled = status;
            cboScheduleName.Enabled = status;
            rtbDescription.Enabled = status;
            dtpTime.Enabled = status;
        }

        public void LoadSchedules()
        {
            try
            {
                var schedules = repo.GetSchedules();
                cboScheduleName.DataSource = schedules;
                cboScheduleName.DisplayMember = "ScheduleName";
                cboScheduleName.ValueMember = "ScheduleId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on load list of schedules", "Animal Schedule");
            }
        }

        public void LoadAnimalSchedules()
        {
            try
            {
                var schedules = repo.GetScheduleOfAnimal(txtAnimalId.Text);
                BindingSource source = new BindingSource();
                source.DataSource = schedules.Select(a => new
                {
                    a.AnimalId,
                    a.Schedule.ScheduleName,
                    a.Time,
                    a.Description
                }).ToList();

                txtAnimalId.DataBindings.Clear();
                cboScheduleName.DataBindings.Clear();
                dtpTime.DataBindings.Clear();
                rtbDescription.DataBindings.Clear();

                txtAnimalId.DataBindings.Add("Text", source, "AnimalId");
                cboScheduleName.DataBindings.Add("Text", source, "ScheduleName");
                dtpTime.DataBindings.Add("Text", source, "Time");
                rtbDescription.DataBindings.Add("Text", source, "Description");

                dgvAnimalSchedule.DataSource = null;
                dgvAnimalSchedule.DataSource = source;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on load list of animal schechules", "Animal Schedule");
            }
        }

        private void frmAnimalSchedule_Load(object sender, EventArgs e)
        {
            txtAnimalId.Text = Animal.AnimalId;
            btnSave.Enabled = false;
            EnableText(false);
            LoadSchedules();
            LoadAnimalSchedules();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (btnNew.Text == "New")
            {
                btnNew.Text = "Cancel";
                btnSave.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                ClearText();
                EnableText(true);
                txtAnimalId.Enabled = false;
                CreateOrUpdate = true;
                dgvAnimalSchedule.ClearSelection();
            }
            else
            {
                btnNew.Text = "New";
                btnSave.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                CreateOrUpdate = false;
                EnableText(false);
                LoadAnimalSchedules();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Text == "Update")
            {
                btnUpdate.Text = "Cancel";
                btnSave.Enabled = true;
                btnNew.Enabled = false;
                btnDelete.Enabled = false;
                EnableText(true);
                txtAnimalId.Enabled = false;
                cboScheduleName.Enabled = false;
            }
            else
            {
                btnUpdate.Text = "Update";
                btnSave.Enabled = false;
                btnNew.Enabled = true;
                btnDelete.Enabled = true;
                EnableText(false);
                LoadAnimalSchedules();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d;
                d = MessageBox.Show("Are you sure you wanna delete it?", "Delete Schedule",
                                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (d == DialogResult.OK)
                {
                    AnimalSchedule a = new AnimalSchedule
                    {
                        AnimalId = txtAnimalId.Text,
                        ScheduleId = cboScheduleName.SelectedValue.ToString()
                    };
                    if(repo.DeleteAnimalSchedule(a))
                    {
                        MessageBox.Show("Delete Successfully");
                        LoadAnimalSchedules();
                    } else
                    {
                        MessageBox.Show("Delete Fail");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Schedule");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtAnimalId.Text == "" || cboScheduleName.Text == "" ||
                dtpTime.Value == null || rtbDescription.Text == "")
            {
                MessageBox.Show("All fields are required!", "Animal Schedule",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            } else
            {
                AnimalSchedule a = new AnimalSchedule
                {
                    AnimalId = txtAnimalId.Text,
                    ScheduleId = cboScheduleName.SelectedValue.ToString(),
                    Time = dtpTime.Value.ToString(),
                    Description = rtbDescription.Text
                };
                if (CreateOrUpdate)
                {
                    if (repo.AddAnimalSchedule(a))
                    {
                        btnNew.Text = "New";
                        btnUpdate.Enabled = true;
                        btnDelete.Enabled = true;
                        CreateOrUpdate = false;
                        EnableText(false);
                        btnSave.Enabled = false;
                        LoadAnimalSchedules();
                        MessageBox.Show("Add successfully", "Add Schedule For Animal");
                    }
                    else
                    {
                        MessageBox.Show("Existed!!", "Add Schedule For Animal");
                    }

                }
                else
                {
                    if (repo.UpdateAnimalSchedule(a))
                    {
                        btnUpdate.Text = "Update";
                        btnNew.Enabled = true;
                        btnDelete.Enabled = true;
                        EnableText(false);
                        btnSave.Enabled = false;
                        LoadAnimalSchedules();
                        MessageBox.Show("Update successfully", "Update Food For Animal");
                    }
                    else
                    {
                        MessageBox.Show("Fail to update food", "Update Food For Animal");
                    }
                }
            }
        }
    }
}
