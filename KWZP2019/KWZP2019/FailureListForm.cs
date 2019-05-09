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
        Maintenance maintenance = new Maintenance();
        FailureMaintenance failureMaintenance = new FailureMaintenance();
        bool isLoading = true;

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
            this.dgvMaintenances.AutoGenerateColumns = false;
            this.dgvMaintenances.DataSource = db.Maintenances.Where(maintenance => maintenance.IdMaintType == 1).ToList();
            
        }

        void clear()
        {
            this.failureMaintenance.IdFailureMaint = 0;
            this.maintenance.IdMaintenance = 0;
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
            clear();
            populateDataGridView();
            List<Machine> listMachines = db.Machines.ToList<Machine>();
            Machine recordMachine = new Machine();
            recordMachine.IdMachine = -1;
            recordMachine.MachineName = "Wszystkie";
            listMachines.Add(recordMachine);
            comMachine.DataSource = listMachines;
            comMachine.ValueMember = "IdMachine";
            comMachine.DisplayMember = "MachineName";
            comMachine.SelectedValue = -1;
            this.isLoading = false;
            this.machineFilter();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            clear();
            populateDataGridView();
        }

        private void comMachine_SelectedIndexChanged(object sender, EventArgs e)
        {           
            if (isLoading)
                return;
            this.machineFilter();           
        }

        void machineFilter()
        {
            int selectedMachine = Convert.ToInt32(this.comMachine.SelectedValue);
            if (selectedMachine == -1)
            {
                populateDataGridView();
            }
            else
            {
                this.dgvMaintenances.DataSource = db.Maintenances
                    .Where(maintenance => maintenance.IdMachine == selectedMachine)
                    .Where(maintenance => maintenance.IdMaintType == 1).ToList();
            }
        }

        private void btnFilterDate_Click(object sender, EventArgs e)
        {
            if (this.dtpFromDate.Value > this.dtpToDate.Value)
            {
                MessageBox.Show("'Data od' musi być mniejsza od 'Data do'!");
                return;
            }
            else
            {
                this.dgvMaintenances.DataSource = db.Maintenances
                .Where(maintenance => maintenance.StartDatePlan >= this.dtpFromDate.Value)
                .Where(maintenance => maintenance.StartDatePlan <= this.dtpToDate.Value)
                .Where(maintenance => maintenance.IdMaintType == 1).ToList();
            }
        }
    }
}