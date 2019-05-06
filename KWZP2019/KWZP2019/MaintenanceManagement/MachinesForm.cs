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

        void PopulateDataGridView()
        {
            dgvMachine.AutoGenerateColumns = false;
            using (RoofingCompanyEntities db = new RoofingCompanyEntities())
            {
                dgvMachine.DataSource = db.Machines.ToList<Machine>();
            }
        }

        void Clear()
        {
            txtMachineName.Text = txtProducerMachine.Text = txtProductionYear.Text = txtPowerMachine.Text =
            txtWorkingArea.Text = txtCatalogMachineNr.Text = txtMetersPerHour.Text = "";
            btnSave.Text = "Zapisz";
            btnDelete.Enabled = false;
            machine.IdMachine = 0;
        }

        private void MachinesForm_Load(object sender, EventArgs e)
        {
            Clear();
            PopulateDataGridView();
            using (RoofingCompanyEntities db = new RoofingCompanyEntities())
            {
                comMachineType.DataSource = db.MachineTypes.ToList<MachineType>();
                comMachineType.ValueMember = "IdMachineType";
                comMachineType.DisplayMember = "MachineTypeName";
            }
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
                using (RoofingCompanyEntities db = new RoofingCompanyEntities())
                {
                    if (machine.IdMachine == 0)//Instert
                        db.Machines.Add(machine);
                    else //update
                        db.Entry(machine).State = EntityState.Modified;
                    db.SaveChanges();
                }
                Clear();
                PopulateDataGridView();
                MessageBox.Show("Maszyna została dodana!");
            }
            catch (Exception)
            {
                MessageBox.Show("Wprowadź poprawną wartość!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz usunąć tę pozycję?", "Usuwanie maszyny", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (RoofingCompanyEntities db = new RoofingCompanyEntities())
                {
                    var entry = db.Entry(machine);
                    if (entry.State == EntityState.Detached)
                        db.Machines.Attach(machine);
                    db.Machines.Remove(machine);
                    db.SaveChanges();
                    PopulateDataGridView();
                    Clear();
                    MessageBox.Show("Usunięto prawidłowo");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dgvMachine_DoubleClick(object sender, EventArgs e)
        {
            if (dgvMachine.CurrentRow.Index != -1)
            {
                machine.IdMachine = Convert.ToInt32(dgvMachine.CurrentRow.Cells["IdMachine"].Value);
                using (RoofingCompanyEntities db = new RoofingCompanyEntities())
                {
                    machine = db.Machines.Where(x => x.IdMachine == machine.IdMachine).First();
                    txtMachineName.Text = machine.MachineName;
                    txtProducerMachine.Text = machine.ProducerMachine;
                    txtWorkingArea.Text = machine.WorkingArea;
                    txtCatalogMachineNr.Text = machine.CatalogMachineNr;
                    txtProductionYear.Text = machine.ProductionYear.ToString();
                    txtPowerMachine.Text = machine.PowerMachine.ToString();
                    txtMetersPerHour.Text = machine.MetersPerHour.ToString();
                }
                btnSave.Text = "Aktualizuj";
                btnDelete.Enabled = true;
            }
        }
    }
}
