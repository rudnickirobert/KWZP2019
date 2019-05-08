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
    public partial class InspectionListForm : Form
    {
        RoofingCompanyEntities db;
        StartForm startForm;
        MaintenanceManagement maintenanceManagementForm;
        Maintenance maintenance = new Maintenance();
        MaintType maintType = new MaintType();
        int nIdSelectedMaintenance = 0;
        bool lIsLoading = true;

        public InspectionListForm(RoofingCompanyEntities db, StartForm startForm, MaintenanceManagement maintenanceManagementForm)
        {
            this.db = db;
            this.startForm = startForm;
            this.maintenanceManagementForm = maintenanceManagementForm;
            InitializeComponent();
        }

        private void btnReturnMain_Click(object sender, EventArgs e)
        {
            this.maintenanceManagementForm.Show();
            this.Hide();
        }

        private void btnNewInspection_Click(object sender, EventArgs e)
        {
            NewInspectionForm newInspectionForm = new NewInspectionForm(db, startForm, this);
            this.Hide();
            newInspectionForm.Show();
        }

        void populateDataGridView()
        {
            this.dgvMaintenance.AutoGenerateColumns = false;
            this.dgvMaintenance.DataSource = db.Maintenances.Where(maintenance => maintenance.IdMaintType == 2).ToList();
        }

        void clear()
        {
            this.maintenance.IdMaintenance = 0;
        }

        private void InspectionListForm_Load(object sender, EventArgs e)
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
            this.lIsLoading = false;
            this.machineFilter();
        }

        private void dgvMaintenance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvMaintenance.CurrentRow.Index != -1)
            {
                try
                {
                    this.nIdSelectedMaintenance = Convert.ToInt32(this.dgvMaintenance.CurrentRow.Cells["IdMaintenance"].Value);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnDescription_Click(object sender, EventArgs e)
        {
            if (this.nIdSelectedMaintenance == 0)
                return;
            try
            {
                maintenance = db.Maintenances.Where(maintenance => maintenance.IdMaintenance == this.nIdSelectedMaintenance).First();
                MaintenanceDescriptionForm maintDescriptionForm = new MaintenanceDescriptionForm(this.db, Convert.ToInt32(maintenance.IdMaintDesc));
                maintDescriptionForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void comMachine_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                if (lIsLoading)
                    return;
                this.machineFilter();
            }
        }

        void machineFilter()
        {
            int lnSelectedMachine = Convert.ToInt32(this.comMachine.SelectedValue);
            if (lnSelectedMachine == -1)
            {
                populateDataGridView();
            }
            else
            {
                this.dgvMaintenance.DataSource = db.Maintenances.Where(maintenance => maintenance.IdMachine == lnSelectedMachine).ToList();
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
                this.dgvMaintenance.DataSource = db.Maintenances
                .Where(maintenance => maintenance.StartDatePlan >= this.dtpFromDate.Value)
                .Where(maintenance => maintenance.StartDatePlan <= this.dtpToDate.Value).ToList();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            clear();
            populateDataGridView();
        }
    }
      
}
