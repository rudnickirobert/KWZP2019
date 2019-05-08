using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KWZP2019
{
    public partial class FailureListForm : Form
    {
        RoofingCompanyEntities db;
        StartForm startForm;
        MaintenanceManagement maintenanceManagementForm;

        public FailureListForm(RoofingCompanyEntities db, StartForm startForm, MaintenanceManagement maintenanceManagementForm)
        {
            this.db = db;
            this.startForm = startForm;
            this.maintenanceManagementForm = maintenanceManagementForm;
            InitializeComponent();
        }

        void populateDataGridView()
        {
            this.dgvNewFailures.AutoGenerateColumns = false;
            this.dgvNewFailures.DataSource = db.vNewFailures.ToList<vNewFailure>();
        }

        private void btnNewMaintenance_Click_1(object sender, EventArgs e)
        {
            NewMaintenanceForm newMaintenanceForm = new NewMaintenanceForm(this.db, startForm, this);
            this.Hide();
            newMaintenanceForm.Show();
        }

        private void btnReturnMain_Click_1(object sender, EventArgs e)
        {
            this.maintenanceManagementForm.Show();
            this.Hide();
        }

        private void FailureListForm_Load_1(object sender, EventArgs e)
        {
            populateDataGridView();
        }
    }
}