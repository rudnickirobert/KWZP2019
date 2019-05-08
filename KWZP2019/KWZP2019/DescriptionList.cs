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
        MaintDescription maintDescription = new MaintDescription();
        int nIdSelectedDescription = 0;


        public DescriptionList(RoofingCompanyEntities db, StartForm startForm, MaintenanceManagement maintenanceManagementForm)
        {
            this.db = db;
            this.startForm = startForm;
            this.maintenanceManagementForm = maintenanceManagementForm;
            InitializeComponent();
        }

        void PopulateDataGridView()
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
                this.maintDescription.MaintDescName = this.txtShortDescription.Text.TrimEnd();
                this.maintDescription.MaintDescription1 = this.txtLongDescription.Text.TrimEnd();

                if (maintDescription.IdMaintDesc == 0) //Instert
                {
                    this.db.MaintDescriptions.Add(maintDescription);
                }
                else //update
                    this.db.Entry(maintDescription).State = EntityState.Modified;

                this.db.SaveChanges();
                
                PopulateDataGridView();
                Clear();
                MessageBox.Show("Opis został dodany!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void Clear()
        {
            this.txtShortDescription.Text = this.txtLongDescription.Text =  "";
            this.maintDescription = new MaintDescription();
        }

        private void dgvDescription_DoubleClick(object sender, EventArgs e)
        {
            if (dgvDescription.CurrentRow.Index != -1)
            {
                this.nIdSelectedDescription = Convert.ToInt32(dgvDescription.CurrentRow.Cells["IdMaintDesc"].Value);
                maintDescription = this.db.MaintDescriptions.Where(x => x.IdMaintDesc == this.nIdSelectedDescription).First();
                if (this.maintDescription.MaintDescription1 == null)
                    this.txtLongDescription.Text = "";
                else
                    this.txtLongDescription.Text = this.maintDescription.MaintDescription1.ToString();
                if (this.maintDescription.MaintDescName == null)
                    this.txtShortDescription.Text = "";
                else
                    this.txtShortDescription.Text = this.maintDescription.MaintDescName.ToString();
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
                    var entry = this.db.Entry(maintDescription);
                    if (entry.State == EntityState.Detached)
                        this.db.MaintDescriptions.Attach(maintDescription);
                    this.db.MaintDescriptions.Remove(maintDescription);
                    this.db.SaveChanges();
                    PopulateDataGridView();
                    Clear();
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
            Clear();
            PopulateDataGridView();
        }
    }
}
