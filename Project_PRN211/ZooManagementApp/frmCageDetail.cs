using BussinessObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooManagementApp
{
    public partial class frmCageDetail : Form
    {
        public ICageRepository cageRepository { get; set; }
        public bool Update { get; set; }
        public Cage Cage { get; set; }
        public frmCageDetail()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtName.Text, "^[a-zA-Z\\s-.']+(\\d*)$") == false)
            {
                MessageBox.Show("Invalid ProductName");
                return;
            }
            if (Regex.IsMatch(txtCapacity.Text, "^\\d+$") == false)
            {
                MessageBox.Show("Invalid Capacity " + txtCapacity.Text);
                return;
            }
            if (int.Parse(txtCapacity.Text) < 0)
            {
                MessageBox.Show("Max animal must be > 0");
                return;
            }
            try
            {
                if (Update)
                {
                    var cageUpdate = new Cage
                    {
                        Cid = txtID.Text,
                        Name = txtName.Text,
                        AnimalQuantity = int.Parse(txtQuantity.Text),
                        AreaId = cboAreaID.Text.ToString(),
                        MaxCapacity = int.Parse(txtCapacity.Text),
                    };
                    cageRepository.UpdateCage(cageUpdate);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {

                    using var db = new ZooManagementFormContext();
                    var id = cboAreaID.SelectedValue.ToString();
                    var area = db.Areas.Where(a => a.AreaId == id).FirstOrDefault();

                    int count = cageRepository.GetCagesByAreaName(area.AreaName).Count() + 1;
                    var cageId = area.AreaName + count.ToString().PadLeft(4, '0');
                    var cageAdd = new Cage
                    {
                        Cid = cageId,
                        Name = txtName.Text,
                        AnimalQuantity = 0,
                        AreaId = cboAreaID.Text.ToString(),
                        MaxCapacity = int.Parse(txtCapacity.Text),
                    };
                    cageRepository.AddCage(cageAdd);
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmCageDetail_Load(object sender, EventArgs e)
        {
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.ActiveControl = txtID;
            txtID.Enabled = !Update;
            if (Update)
            {
                txtID.Enabled = false;
                txtQuantity.Enabled = false;
                cboAreaID.Enabled = false;
                txtID.Text = Cage.Cid;
                txtName.Text = Cage.Name;
                txtQuantity.Text = Cage.AnimalQuantity.ToString();
                txtCapacity.Text = Cage.MaxCapacity.ToString();
                cboAreaID.Text = Cage.AreaId;
            }
            else
            {
                using var db = new ZooManagementFormContext();
                var areas = db.Areas.ToList();
                txtID.Enabled = false;
                txtQuantity.Enabled = false;
                cboAreaID.DataSource = areas;
                cboAreaID.DisplayMember = "AreaId";
                cboAreaID.ValueMember = "AreaId";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
