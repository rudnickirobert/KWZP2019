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
    public partial class MaintenanceCalendarForm : Form
    {
        RoofingCompanyEntities db;
        StartForm startForm;
        MaintenanceManagement maintenanceManagementForm;
        Maintenance maintenance = new Maintenance();
        MaintType maintenanceType = new MaintType();
        int idSelectedMaintenance = 0;
        bool isLoading = true;

        public MaintenanceCalendarForm(RoofingCompanyEntities db, StartForm startForm, MaintenanceManagement maintenanceManagementForm)
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

        void populateDataGridView()
        {
            this.dgvMaintenance.AutoGenerateColumns = false;  
            this.dgvMaintenance.DataSource = this.db.Maintenances.ToList<Maintenance>(); 
        }

        void populateEmployeesPartsGridView()
        {
            this.dgvMaintenanceEmployees.DataSource = this.db.vMaintenanceAssignEmployees
                .Where(employee => employee.IdMaintenance == idSelectedMaintenance).ToList<vMaintenanceAssignEmployee>();
            this.dgvPart.DataSource = this.db.vMaintenanceAssignParts
                .Where(part => part.IdMaintenance == idSelectedMaintenance).ToList<vMaintenanceAssignPart>();                  
        }

        void clear()
        {
            this.maintenance.IdMaintenance = 0;
        }

        private void MaintenanceCalendarForm_Load(object sender, EventArgs e)
        {
            clear();
            populateDataGridView();          
            List <MaintType> listType = db.MaintTypes.ToList<MaintType>();
            MaintType recordType = new MaintType();
            recordType.IdMaintenanceType = -1;
            recordType.MaintenanceType = "Wszystkie";
            listType.Add(recordType);
            comType.DataSource = listType;
            comType.ValueMember = "IdMaintenanceType";
            comType.DisplayMember = "MaintenanceType";
            comType.SelectedValue = -1;
            List <Machine> listMachines = db.Machines.ToList<Machine>();
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

        private void dgvMaintenance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvMaintenance.CurrentRow.Index != -1)
            {
                try
                {
                    this.idSelectedMaintenance = Convert.ToInt32(this.dgvMaintenance.CurrentRow.Cells["IdMaintenance"].Value);
                    populateEmployeesPartsGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnDescription_Click(object sender, EventArgs e)
        {
            if (this.idSelectedMaintenance == 0)
                return;
            try
            {               
                maintenance = db.Maintenances.Where(maintenance => maintenance.IdMaintenance == this.idSelectedMaintenance).First();
                MaintenanceDescriptionForm maintDescriptionForm = new MaintenanceDescriptionForm(this.db, Convert.ToInt32(maintenance.IdMaintDesc));
                maintDescriptionForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
                this.dgvMaintenance.DataSource = db.Maintenances.Where(maintenance => maintenance.IdMachine == selectedMachine).ToList();
            }
        }

        private void comType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading)
                return;
            this.TypeFilter();
        }

        private void TypeFilter()
        {
            int selectedType = Convert.ToInt32(this.comType.SelectedValue);
            if (selectedType == -1)
            {
                populateDataGridView();
            }
            else
            {
                this.dgvMaintenance.DataSource = db.Maintenances.Where(maintenance => maintenance.IdMaintType == selectedType).ToList();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            clear();
            populateDataGridView();
        }
    }
}