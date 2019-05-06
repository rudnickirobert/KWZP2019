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
        EmployeePlan employeePlan = new EmployeePlan();
        MaintPart maintPart = new MaintPart();
        int nIdSelectedEmployee = 0;
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

        void PopulateDataGridView()
        {
            using (RoofingCompanyEntities db = new RoofingCompanyEntities())
            {
                this.dgvEmployees.DataSource = db.vMaintenanceEmployees.ToList<vMaintenanceEmployees>();
                this.dgvMaintenanceEmployees.DataSource = (from employeeview in db.vMaintenanceAssignEmployees
                                                           where employeeview.IdMaintenance == this.maintenance.IdMaintenance
                                                           select new
                                                           {
                                                               employeeview.IdEmployeePlan,
                                                               employeeview.IdMaintenance,
                                                               employeeview.IdEmployee,
                                                               employeeview.EmployeeName,
                                                               employeeview.EmployeeSurname,
                                                               employeeview.StartDate,
                                                               employeeview.EndDate
                                                           }).ToList();
                this.dgvPart.DataSource = (from partview in db.vMaintenanceAssignParts
                                           where partview.IdMaintenance == this.maintenance.IdMaintenance
                                           select new
                                           {
                                               partview.IdMaintenance,
                                               partview.IdPart,
                                               partview.PartName,
                                               partview.PartQuantity,
                                               partview.QuantityWarehouse,
                                               partview.UnitName
                                           }).ToList();                            
            }
        }

        void PopulateListBox()
        {
            using (RoofingCompanyEntities db = new RoofingCompanyEntities())
            {
                List<Part> Result = db.Parts.ToList<Part>();
                this.lbxParts.DataSource = Result;
                this.lbxParts.DisplayMember = "PartName";
                this.lbxParts.ValueMember = "IdPart";
            }
        }

        void PopulateComboBox()
        {
            using (RoofingCompanyEntities db = new RoofingCompanyEntities())
            {
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
        }

        void Clear()
        {
            this.txtMaintenanceNr.Text = string.Empty;
            this.dtpStartDate.Value = this.dtpEndDate.Value = DateTime.Now;
            this.tpStartDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 0, 0);
            this.tpEndDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 16, 0, 0);
            this.maintenance.IdMaintenance = 0;
            this.failureMaintenance.IdMaintenance = 0;
        }

        void ClearEmployee()
        {
            this.dtpEmployeeStartDate.Value = this.dtpEmployeeEndDate.Value = DateTime.Now;
            this.tpEmployeeStartDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 0, 0);
            this.tpEmployeeEndDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 16, 0, 0);
            this.employeePlan.IdEmployeePlan = 0;
            this.employeePlan.IdEmployee = 0;
            this.nIdSelectedEmployee = 0;
        }

        void ClearPart()
        {
            this.maintPart.IdMaintPart = 0;
            this.maintPart.IdPart = 0;
            this.txtQuantity.Text = String.Empty;
        }

        void LoadWindow()
        {
            Clear();
            ClearEmployee();
            ClearPart();
            PopulateComboBox();
            PopulateDataGridView();
            PopulateListBox();
            this.tpEndDate.Format = DateTimePickerFormat.Time;
            this.tpEndDate.ShowUpDown = true;
            this.tpStartDate.Format = DateTimePickerFormat.Time;
            this.tpStartDate.ShowUpDown = true;
            this.tpEmployeeEndDate.Format = DateTimePickerFormat.Time;
            this.tpEmployeeEndDate.ShowUpDown = true;
            this.tpEmployeeStartDate.Format = DateTimePickerFormat.Time;
            this.tpEmployeeStartDate.ShowUpDown = true;
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
                MessageBox.Show("Obsługa została dodana!");
                this.btnSave.Text = "Aktualizuj";
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

        private void btnEmloyeeCalendar_Click(object sender, EventArgs e)
        {
            MaintenanceEmployeeCalendarForm maintenanceEmployeeCalendarForm = new MaintenanceEmployeeCalendarForm(this.db);
            maintenanceEmployeeCalendarForm.Show();
        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvEmployees.CurrentRow.Index != -1)
            {               
                try
                {
                    this.nIdSelectedEmployee = Convert.ToInt32(this.dgvEmployees.CurrentRow.Cells["IdEmployee"].Value);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            
            if (this.maintenance.IdMaintenance == 0)
            {
                MessageBox.Show("Najpierw wprowadź zlecenie!");
                return;
            }
            if (this.nIdSelectedEmployee == 0)
            {
                MessageBox.Show("Najpierw wybierz pracownika!");
                return;
            }
            foreach (DataGridViewRow row in this.dgvMaintenanceEmployees.Rows)
            {
                if (int.Parse(row.Cells[2].Value.ToString()) == nIdSelectedEmployee)
                {
                    MessageBox.Show("Ten pracownik juz został dodany!");
                    return;
                }

            }
            try
            {
                this.employeePlan.IdEmployee = nIdSelectedEmployee;
                this.employeePlan.IdMaintenance = this.maintenance.IdMaintenance;
                this.employeePlan.StartDate = this.dtpEmployeeStartDate.Value.Date + this.tpEmployeeStartDate.Value.TimeOfDay;
                this.employeePlan.EndDate = this.dtpEmployeeEndDate.Value.Date + this.tpEmployeeEndDate.Value.TimeOfDay;
                using (RoofingCompanyEntities db = new RoofingCompanyEntities())
                {
                    if (this.employeePlan.IdEmployeePlan == 0)//Instert
                        db.EmployeePlans.Add(employeePlan);
                    else //update
                        db.Entry(employeePlan).State = EntityState.Modified;
                    db.SaveChanges();
                }
                ClearEmployee();
                MessageBox.Show("Pracownik został dodany!");
                PopulateDataGridView();
                this.btnSaveEmployee.Text = "Zapisz";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            int lnIdPart = Convert.ToInt32(this.lbxParts.SelectedValue);
            if (this.txtQuantity.Text.Trim().Length == 0)
            {
                MessageBox.Show("Wprowadź ilość!");
                return;
            }
            if (this.maintenance.IdMaintenance == 0)
            {
                MessageBox.Show("Najpierw wprowadź zlecenie!");
                return;
            }
            if (Convert.ToInt32(this.lbxParts.SelectedValue) == 0)
            {
                MessageBox.Show("Najpierw wybierz część!");
                return;
            }

            foreach (DataGridViewRow row in this.dgvPart.Rows)
            {
                if (int.Parse(row.Cells[1].Value.ToString()) == lnIdPart)
                {
                    MessageBox.Show("Ta część już została dodana!");
                    return;
                }
                    
            }

            try
            {
                this.maintPart.IdPart = lnIdPart;
                this.maintPart.IdMaintenance = this.maintenance.IdMaintenance;               
                this.maintPart.PartQuantity = Convert.ToInt32(this.txtQuantity.Text.Trim());
                using (RoofingCompanyEntities db = new RoofingCompanyEntities())
                {
                    if (this.maintPart.IdMaintPart == 0)//Instert
                        db.MaintParts.Add(maintPart);
                    else //update
                        db.Entry(maintPart).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            ClearPart();
            MessageBox.Show("Część została dodana!");
            PopulateDataGridView();
        }

        private void checkDate(System.Windows.Forms.DateTimePicker dtPicker)
        {
            DateTime dt = dtPicker.Value;
            if (dt.DayOfWeek == DayOfWeek.Saturday)
            {
                MessageBox.Show("Nie pracujemy w weekendy!");
                dtPicker.Value = dtPicker.Value.AddDays(2);
            }
            if (dtPicker.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("Nie pracujemy w weekendy!");
                dtPicker.Value = dtpStartDate.Value.AddDays(1);
            }
        }

        private void checkTime(System.Windows.Forms.DateTimePicker timePicker)
        {
            DateTime dateTime = timePicker.Value;
            TimeSpan minTime = new TimeSpan(8, 0, 0);
            TimeSpan maxTime = new TimeSpan(16, 0, 0);
            if (dateTime.TimeOfDay < minTime || dateTime.TimeOfDay > maxTime)
            {
                MessageBox.Show("Pracujemy w godzinach 8-16!");
                timePicker.Value = new DateTime(dateTime.Year,dateTime.Month,dateTime.Day,8,0,0);
            }           
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.DateTimePicker dateTimePicker = (System.Windows.Forms.DateTimePicker)sender;
            this.checkDate(dateTimePicker);
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.DateTimePicker dateTimePicker = (System.Windows.Forms.DateTimePicker)sender;
            this.checkDate(dateTimePicker);
        }

        private void dtpEmployeeStartDate_ValueChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.DateTimePicker dateTimePicker = (System.Windows.Forms.DateTimePicker)sender;
            this.checkDate(dateTimePicker);
        }

        private void dtpEmployeeEndDate_ValueChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.DateTimePicker dateTimePicker = (System.Windows.Forms.DateTimePicker)sender;
            this.checkDate(dateTimePicker);
        }


        private void tpStartDate_Leave(object sender, EventArgs e)
        {
            System.Windows.Forms.DateTimePicker dateTimePicker = (System.Windows.Forms.DateTimePicker)sender;
            this.checkTime(dateTimePicker);
        }

        private void tpEndDate_Leave(object sender, EventArgs e)
        {
            System.Windows.Forms.DateTimePicker dateTimePicker = (System.Windows.Forms.DateTimePicker)sender;
            this.checkTime(dateTimePicker);
        }

        private void tpEmployeeStartDate_Leave(object sender, EventArgs e)
        {
            System.Windows.Forms.DateTimePicker dateTimePicker = (System.Windows.Forms.DateTimePicker)sender;
            this.checkTime(dateTimePicker);
        }

        private void tpEmployeeEndDate_Leave(object sender, EventArgs e)
        {
            System.Windows.Forms.DateTimePicker dateTimePicker = (System.Windows.Forms.DateTimePicker)sender;
            this.checkTime(dateTimePicker);
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz usunąć tę pozycję?", "Usuwanie pracownika", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (RoofingCompanyEntities db = new RoofingCompanyEntities())
                {
                    var entry = db.Entry(employeePlan);
                    if (entry.State == EntityState.Detached)
                        db.EmployeePlans.Attach(employeePlan);
                    db.EmployeePlans.Remove(employeePlan);
                    db.SaveChanges();
                    PopulateDataGridView();
                    ClearEmployee();
                    MessageBox.Show("Usunięto prawidłowo");
                }
            }
        }

        private void btnCancelEmployee_Click(object sender, EventArgs e)
        {
            ClearEmployee();
        }

        private void dgvMaintenanceEmployees_DoubleClick(object sender, EventArgs e)
        {
            if (this.dgvMaintenanceEmployees.CurrentRow.Index != -1)
            {
                this.employeePlan.IdEmployeePlan = Convert.ToInt32(this.dgvMaintenanceEmployees.CurrentRow.Cells["IdEmployeePlan"].Value);
                using (RoofingCompanyEntities db = new RoofingCompanyEntities())
                {
                    this.employeePlan = db.EmployeePlans.Where(x => x.IdEmployeePlan == employeePlan.IdEmployeePlan).First();
                    this.dtpEmployeeStartDate.Value = new DateTime(
                        employeePlan.StartDate.Year,
                        employeePlan.StartDate.Month,
                        employeePlan.StartDate.Day, 0, 0, 0);
                    this.tpEmployeeStartDate.Value = new DateTime(
                        employeePlan.StartDate.Year,
                        employeePlan.StartDate.Month,
                        employeePlan.StartDate.Day,
                        employeePlan.StartDate.Hour, 
                        employeePlan.StartDate.Minute, 
                        employeePlan.StartDate.Second);
                    this.dtpEmployeeEndDate.Value = new DateTime(
                        employeePlan.EndDate.Year,
                        employeePlan.EndDate.Month,
                        employeePlan.EndDate.Day, 0, 0, 0);
                    this.tpEmployeeEndDate.Value = new DateTime(
                        employeePlan.EndDate.Year,
                        employeePlan.EndDate.Month,
                        employeePlan.EndDate.Day,
                        employeePlan.EndDate.Hour,
                        employeePlan.EndDate.Minute,
                        employeePlan.EndDate.Second);
                }
                this.btnSaveEmployee.Text = "Aktualizuj";
                this.btnDeleteEmployee.Enabled = true;
            }
        }
    }
}
