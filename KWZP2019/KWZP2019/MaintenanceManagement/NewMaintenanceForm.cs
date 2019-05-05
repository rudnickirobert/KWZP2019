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
    public partial class NewMaintenanceForm : Form
    {
        RoofingCompanyEntities db;
        Maintenance maintenance = new Maintenance();
        StartForm startForm;
        FailureListForm failureListForm;
        FailureMaintenance failureMaintenance = new FailureMaintenance();
        bool lLoad = true;
        vMachineFailure machineFailure = new vMachineFailure();

        public NewMaintenanceForm(RoofingCompanyEntities db, StartForm startForm, FailureListForm failureListForm)
        {
            this.db = db;
            this.startForm = startForm;
            this.failureListForm = failureListForm;
            InitializeComponent();
        }

        private void btnReturnMain_Click(object sender, EventArgs e)
        {
            this.failureListForm.Show();
            this.Hide();
        }
        void Clear()
        {
            this.txtMaintenanceNr.Text = string.Empty;
            this.dtpStartDate.Value = this.dtpEndDate.Value = this.tpEndDate.Value = this.tpEndDate.Value = DateTime.Now;
            this.maintenance.IdMaintenance = 0;
            this.failureMaintenance.IdMaintenance = 0;
        }

        void LoadWindow()
        {
            this.tpEndDate.Format = DateTimePickerFormat.Time;
            this.tpEndDate.ShowUpDown = true;
            this.tpStartDate.Format = DateTimePickerFormat.Time;
            this.tpStartDate.ShowUpDown = true;
            using (RoofingCompanyEntities db = new RoofingCompanyEntities())
            {
                this.dgvEmployees.DataSource = db.vMaintenanceEmployees.ToList<vMaintenanceEmployees>();
                this.dgvMaintenanceEmployees.DataSource = db.vMaintenanceAssignEmployees.ToList<vMaintenanceAssignEmployees>();
                List<Part> Result = db.Parts.ToList<Part>();
                this.lbxParts.DataSource = Result;
                this.lbxParts.DisplayMember = "PartName";
                this.lbxParts.ValueMember = "IdPart";
                List<vComboboxNewFailures> lst = db.vComboboxNewFailures.ToList<vComboboxNewFailures>();
                vComboboxNewFailures record = new vComboboxNewFailures();
                record.IdFailure = -1;
                record.Specification = "Nie wybrano";
                lst.Add(record);
                this.comFailure.DataSource = lst;
                this.comFailure.ValueMember = "IdFailure";
                this.comFailure.DisplayMember = "Specification";
                this.comFailure.SelectedValue = -1;
            }
            this.lLoad = false;
        }

        private void NewMaintenanceForm_Load(object sender, EventArgs e)
        {
            LoadWindow();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMaintenanceNr.Text.Trim().Length == 0 || Convert.ToInt32(this.comFailure.SelectedValue) == -1)
            {
                MessageBox.Show("Nie wprowadzono wartości!");
                return;
            }
            try
            {
                failureMaintenance.IdMaintenance = this.maintenance.IdMaintenance;              
                int failureId = Convert.ToInt32(comFailure.SelectedValue);
                failureMaintenance.IdFailure = failureId;
                vMachineFailure machineFailureItem = db.vMachineFailure.First(m => m.IdFailure == failureId);
                maintenance.IdMachine = machineFailureItem.IdMachine;
                this.maintenance.IdMaintType = 1;
                this.maintenance.IdMaintDesc = null;
                this.maintenance.DateAcceptOrder = DateTime.Now;       
                this.maintenance.StartDatePlan = this.dtpStartDate.Value.Date + this.tpStartDate.Value.TimeOfDay;
                this.maintenance.EndDatePlan = this.dtpEndDate.Value.Date + this.tpEndDate.Value.TimeOfDay;
                this.maintenance.MaintenanceNr = this.txtMaintenanceNr.Text.Trim();

                using (RoofingCompanyEntities db = new RoofingCompanyEntities())
                {                 
                    if (maintenance.IdMaintenance == 0)//Instert
                        db.Maintenances.Add(maintenance);
                    else //update
                        db.Entry(maintenance).State = EntityState.Modified;
                    if (failureMaintenance.IdMaintenance == 0)//Instert
                        db.FailureMaintenances.Add(failureMaintenance);
                    else //update
                        db.Entry(failureMaintenance).State = EntityState.Modified;
                    db.SaveChanges();
                }
                Clear();
                MessageBox.Show("Obsługa została dodana!");
                this.Close();
                failureListForm.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Wprowadź poprawną wartość!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void comFailure_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lLoad)
                return;
            else
            {
                int failureId = Convert.ToInt32(comFailure.SelectedValue);
                if (failureId == -1)
                {
                    this.txtMachine.Text = string.Empty;
                    return;
                }
                vMachineFailure machineFailureItem = db.vMachineFailure.FirstOrDefault(m => m.IdFailure == failureId);
                maintenance.IdMachine = machineFailureItem.IdMachine;
                this.txtMachine.Text = machineFailureItem.MachineName;
            }
        }
    }
}
