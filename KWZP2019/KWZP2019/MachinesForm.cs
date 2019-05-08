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
    public partial class MachinesForm : Form
    {
        RoofingCompanyEntities db;
        StartForm startForm;
        MaintenanceManagement maintenanceManagementForm;
        MachineType machineType = new MachineType();
        Machine machine = new Machine();

        public MachinesForm(RoofingCompanyEntities db, StartForm startForm, MaintenanceManagement maintenanceManagementForm)
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
            dgvMachine.AutoGenerateColumns = false;
            dgvMachine.DataSource = this.db.Machines.ToList<Machine>();
        }

        void clear()
        {
            txtMachineName.Text = txtProducerMachine.Text = txtProductionYear.Text = txtPowerMachine.Text =
            txtWorkingArea.Text = txtCatalogMachineNr.Text = txtMetersPerHour.Text = "";
            btnSave.Text = "Zapisz";
            btnDelete.Enabled = false;
            machine = new Machine();
        }

        private void MachinesForm_Load(object sender, EventArgs e)
        {
            clear();
            populateDataGridView();
            comMachineType.DataSource = this.db.MachineTypes.ToList<MachineType>();
            comMachineType.ValueMember = "IdMachineType";
            comMachineType.DisplayMember = "MachineTypeName";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCatalogMachineNr.Text.Trim().Length == 0 || txtMetersPerHour.Text.Trim().Length == 0)
            {
                MessageBox.Show("Nie wpisano Numeru katalogowego lub Wydajności!");
                return;
            }
            try
            {
                machine.IdMachineType = Convert.ToInt32(comMachineType.SelectedValue);
                machine.MachineName = txtMachineName.Text.Trim();
                machine.ProducerMachine = txtProducerMachine.Text.Trim();
                machine.WorkingArea = txtWorkingArea.Text.Trim();
                machine.CatalogMachineNr = txtCatalogMachineNr.Text.Trim();
                machine.ProductionYear = Int32.Parse(txtProductionYear.Text.Trim());
                machine.PowerMachine = float.Parse(txtPowerMachine.Text.Trim());
                machine.MetersPerHour = float.Parse(txtMetersPerHour.Text.Trim());

                if (machine.IdMachine == 0) //Instert
                {
                    this.db.Machines.Add(machine);
                }
                else //update
                    this.db.Entry(machine).State = EntityState.Modified;
                this.db.SaveChanges();

                var lista = this.db.Machines.ToList();
                
                populateDataGridView();
                clear();
                MessageBox.Show("Maszyna została dodana!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz usunąć tę pozycję?", "Usuwanie maszyny", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var entry = this.db.Entry(machine);
                if (entry.State == EntityState.Detached)
                    this.db.Machines.Attach(machine);
                this.db.Machines.Remove(machine);
                this.db.SaveChanges();
                populateDataGridView();
                clear();
                MessageBox.Show("Usunięto prawidłowo");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void dgvMachine_DoubleClick(object sender, EventArgs e)
        {
            if (dgvMachine.CurrentRow.Index != -1)
            {
                machine.IdMachine = Convert.ToInt32(dgvMachine.CurrentRow.Cells["IdMachine"].Value);
                machine = this.db.Machines.Where(x => x.IdMachine == machine.IdMachine).First();
                txtMachineName.Text = machine.MachineName;
                txtProducerMachine.Text = machine.ProducerMachine;
                txtWorkingArea.Text = machine.WorkingArea;
                txtCatalogMachineNr.Text = machine.CatalogMachineNr;
                txtProductionYear.Text = machine.ProductionYear.ToString();
                txtPowerMachine.Text = machine.PowerMachine.ToString();
                txtMetersPerHour.Text = machine.MetersPerHour.ToString();
                btnSave.Text = "Aktualizuj";
                btnDelete.Enabled = true;
            }
        }
    }
}
