using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KWZP2019
{
    public partial class DescriptionList : Form
    {
        RoofingCompanyEntities db;
        StartForm startForm;
        MaintenanceManagement maintenanceManagementForm;
        MaintDescription maintenanceDescription = new MaintDescription();
        int idSelectedDescription = 0;


        public DescriptionList(RoofingCompanyEntities db, StartForm startForm, MaintenanceManagement maintenanceManagementForm)
        {
            this.db = db;
            this.startForm = startForm;
            this.maintenanceManagementForm = maintenanceManagementForm;
            InitializeComponent();
        }

        void populateDataGridView()
        {
            dgvDescription.AutoGenerateColumns = false;
            dgvDescription.DataSource = this.db.MaintDescriptions.ToList<MaintDescription>();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.txtLongDescription.TextLength == 0 || this.txtShortDescription.TextLength == 0)
            {
                MessageBox.Show("Nie wpisano opisu!");
                return;
            }
            try
            {
                this.maintenanceDescription.MaintDescName = this.txtShortDescription.Text.TrimEnd();
                this.maintenanceDescription.MaintDescription1 = this.txtLongDescription.Text.TrimEnd();

                if (maintenanceDescription.IdMaintDesc == 0) //Instert
                {
                    this.db.MaintDescriptions.Add(maintenanceDescription);
                }
                else //update
                    this.db.Entry(maintenanceDescription).State = EntityState.Modified;

                this.db.SaveChanges();
                
                populateDataGridView();
                clear();
                MessageBox.Show("Opis został dodany!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void clear()
        {
            this.txtShortDescription.Text = this.txtLongDescription.Text =  "";
            this.maintenanceDescription = new MaintDescription();
        }

        private void dgvDescription_DoubleClick(object sender, EventArgs e)
        {
            if (dgvDescription.CurrentRow.Index != -1)
            {
                this.idSelectedDescription = Convert.ToInt32(dgvDescription.CurrentRow.Cells["IdMaintDesc"].Value);
                maintenanceDescription = this.db.MaintDescriptions.Where(maintenanceDescription => maintenanceDescription.IdMaintDesc == this.idSelectedDescription).First();
                if (this.maintenanceDescription.MaintDescription1 == null)
                    this.txtLongDescription.Text = "";
                else
                    this.txtLongDescription.Text = this.maintenanceDescription.MaintDescription1.ToString();
                if (this.maintenanceDescription.MaintDescName == null)
                    this.txtShortDescription.Text = "";
                else
                    this.txtShortDescription.Text = this.maintenanceDescription.MaintDescName.ToString();
                btnSave.Text = "Aktualizuj";
                btnDelete.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Czy na pewno chcesz usunąć tę pozycję?", "Usuwanie opisu", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var entry = this.db.Entry(maintenanceDescription);
                    if (entry.State == EntityState.Detached)
                        this.db.MaintDescriptions.Attach(maintenanceDescription);
                    this.db.MaintDescriptions.Remove(maintenanceDescription);
                    this.db.SaveChanges();
                    populateDataGridView();
                    clear();
                    MessageBox.Show("Usunięto prawidłowo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }           
        }

        private void btnReturnMain_Click(object sender, EventArgs e)
        {
            this.maintenanceManagementForm.Show();
            this.Hide();
        }

        private void DescriptionList_Load(object sender, EventArgs e)
        {
            clear();
            populateDataGridView();
        }
    }
}
