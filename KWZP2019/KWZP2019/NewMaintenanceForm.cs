﻿using System;
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
        MaintPart maintenancePart = new MaintPart();
        int idSelectedEmployee = 0;
        int idSelectedEmployeePlan = 0;
        bool isLoading = true;
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

        void populateDataGridView()
        {
            this.dgvEmployees.DataSource = this.db.vMaintenanceEmployees.ToList<vMaintenanceEmployee>();
            this.dgvMaintenanceEmployees.DataSource = (from employeeview in this.db.vMaintenanceAssignEmployees
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
            this.dgvPart.DataSource = (from partview in this.db.vMaintenanceAssignParts
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

        void populateListBox()
        {
            List<Part> Result = this.db.Parts.ToList<Part>();
            this.lbxParts.DataSource = Result;
            this.lbxParts.DisplayMember = "PartName";
            this.lbxParts.ValueMember = "IdPart";
        }

        void populateComboBox()
        {
            List<vComboboxNewFailure> list = this.db.vComboboxNewFailures.ToList<vComboboxNewFailure>();
            vComboboxNewFailure record = new vComboboxNewFailure();
            record.IdFailure = -1;
            record.Specification = "Nie wybrano";
            list.Add(record);
            this.comFailure.DataSource = list;
            this.comFailure.ValueMember = "IdFailure";
            this.comFailure.DisplayMember = "Specification";
            this.comFailure.SelectedValue = -1;       
        }

        void clear()
        {
            this.txtMaintenanceNr.Text = string.Empty;
            this.dtpStartDate.Value = this.dtpEndDate.Value = DateTime.Now;
            this.tpStartDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 0, 0);
            this.tpEndDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 16, 0, 0);
            this.maintenance = new Maintenance();
            this.failureMaintenance = new FailureMaintenance();
        }

        void clearEmployee()
        {
            this.dtpEmployeeStartDate.Value = this.dtpEmployeeEndDate.Value = DateTime.Now;
            this.tpEmployeeStartDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 0, 0);
            this.tpEmployeeEndDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 16, 0, 0);
            this.employeePlan = new EmployeePlan();
            this.idSelectedEmployee = 0;
        }

        void clearPart()
        {
            this.maintenancePart = new MaintPart();
            this.txtQuantity.Text = String.Empty;
        }

        void loadWindow()
        {
            clear();
            clearEmployee();
            clearPart();
            populateComboBox();
            populateDataGridView();
            populateListBox();
            this.tpEndDate.Format = DateTimePickerFormat.Time;
            this.tpEndDate.ShowUpDown = true;
            this.tpStartDate.Format = DateTimePickerFormat.Time;
            this.tpStartDate.ShowUpDown = true;
            this.tpEmployeeEndDate.Format = DateTimePickerFormat.Time;
            this.tpEmployeeEndDate.ShowUpDown = true;
            this.tpEmployeeStartDate.Format = DateTimePickerFormat.Time;
            this.tpEmployeeStartDate.ShowUpDown = true;
            this.isLoading = false;
            this.btnDeleteEmployee.Enabled = false;
        }

        private void NewMaintenanceForm_Load(object sender, EventArgs e)
        {
            loadWindow();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMaintenanceNr.Text.Trim().Length == 0 || Convert.ToInt32(this.comFailure.SelectedValue) == -1)
            {
                MessageBox.Show("Nie wprowadzono wartości!");
                return;
            }
            if ((this.dtpStartDate.Value.Date + this.tpStartDate.Value.TimeOfDay) >
                (this.dtpEndDate.Value.Date + this.tpEndDate.Value.TimeOfDay))
            {
                MessageBox.Show("'Data od' musi być mniejsza od 'Data do'!");
                return;
            }
            try
            {
                failureMaintenance.IdMaintenance = this.maintenance.IdMaintenance;              
                int failureId = Convert.ToInt32(this.comFailure.SelectedValue);
                failureMaintenance.IdFailure = failureId;
                vMachineFailure machineFailureItem = this.db.vMachineFailures.First(machineFailure => machineFailure.IdFailure == failureId);
                maintenance.IdMachine = machineFailureItem.IdMachine;
                this.maintenance.IdMaintType = 1;
                this.maintenance.IdMaintDesc = null;
                this.maintenance.DateAcceptOrder = DateTime.Now;       
                this.maintenance.StartDatePlan = this.dtpStartDate.Value.Date + this.tpStartDate.Value.TimeOfDay;
                this.maintenance.EndDatePlan = this.dtpEndDate.Value.Date + this.tpEndDate.Value.TimeOfDay;
                this.maintenance.MaintenanceNr = "AWR"+this.txtMaintenanceNr.Text.Trim();
                
                if (maintenance.IdMaintenance == 0)//Instert
                    this.db.Maintenances.Add(maintenance);
                else //update
                    this.db.Entry(maintenance).State = EntityState.Modified;
                if (failureMaintenance.IdMaintenance == 0)//Instert
                    this.db.FailureMaintenances.Add(failureMaintenance);
                else //update
                    this.db.Entry(failureMaintenance).State = EntityState.Modified;
                this.db.SaveChanges();    
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
            clear();
        }

        private void comFailure_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading)
                return;
            else
            {
                int failureId = Convert.ToInt32(this.comFailure.SelectedValue);
                if (failureId == -1)
                {
                    this.txtMachine.Text = string.Empty;
                    return;
                }
                vMachineFailure machineFailureItem = this.db.vMachineFailures.First(machineFailure => machineFailure.IdFailure == failureId);
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
                    this.idSelectedEmployee = Convert.ToInt32(this.dgvEmployees.CurrentRow.Cells["IdEmployee"].Value);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            DateTime startDate = this.dtpStartDate.Value.Date + this.tpStartDate.Value.TimeOfDay;
            DateTime endDate = this.dtpEndDate.Value.Date + this.tpEndDate.Value.TimeOfDay;
            DateTime employeeStartDate = this.dtpEmployeeStartDate.Value.Date + this.tpEmployeeStartDate.Value.TimeOfDay;
            DateTime employeeEndDate = this.dtpEmployeeEndDate.Value.Date + this.tpEmployeeEndDate.Value.TimeOfDay;

            if ((employeeStartDate < startDate)||(employeeEndDate > endDate))          
            {
                MessageBox.Show("Pracownik musi mieć przydzielone daty w terminie zlecenia. " +
                    "Popraw daty dla pracownika lub aktualizuj termin zlecenia");
                return;
            }
            if ((this.dtpEmployeeStartDate.Value.Date + this.tpEmployeeStartDate.Value.TimeOfDay) >
                (this.dtpEmployeeEndDate.Value.Date + this.tpEmployeeEndDate.Value.TimeOfDay))
            {
                MessageBox.Show("'Data od' musi być mniejsza od 'Data do'!");
                return;
            }
            if (this.maintenance.IdMaintenance == 0)
            {
                MessageBox.Show("Najpierw wprowadź zlecenie!");
                return;
            }
            if (this.idSelectedEmployee == 0)
            {
                MessageBox.Show("Najpierw wybierz pracownika!");
                return;
            }
            foreach (DataGridViewRow row in this.dgvMaintenanceEmployees.Rows)
            {
                if (int.Parse(row.Cells[2].Value.ToString()) == this.idSelectedEmployee)
                {
                    MessageBox.Show("Ten pracownik juz został dodany!");
                    return;
                }
            }
            try
            {
                this.employeePlan.IdEmployee = this.idSelectedEmployee;
                this.employeePlan.IdMaintenance = this.maintenance.IdMaintenance;
                this.employeePlan.StartDate = this.dtpEmployeeStartDate.Value.Date + this.tpEmployeeStartDate.Value.TimeOfDay;
                this.employeePlan.EndDate = this.dtpEmployeeEndDate.Value.Date + this.tpEmployeeEndDate.Value.TimeOfDay;
         
                if (this.employeePlan.IdEmployeePlan == 0)//Instert
                    this.db.EmployeePlans.Add(this.employeePlan);
                else //update
                    this.db.Entry(this.employeePlan).State = EntityState.Modified;
                this.db.SaveChanges();
                
                clearEmployee();
                MessageBox.Show("Pracownik został dodany!");
                populateDataGridView();
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
                this.maintenancePart.IdPart = lnIdPart;
                this.maintenancePart.IdMaintenance = this.maintenance.IdMaintenance;               
                this.maintenancePart.PartQuantity = Convert.ToInt32(this.txtQuantity.Text.Trim());               
                if (this.maintenancePart.IdMaintPart == 0)//Instert
                    this.db.MaintParts.Add(maintenancePart);
                else //update
                    this.db.Entry(maintenancePart).State = EntityState.Modified;
                this.db.SaveChanges();               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            clearPart();
            MessageBox.Show("Część została dodana!");
            populateDataGridView();
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
                var entry = this.db.Entry(this.employeePlan);
                if (entry.State == EntityState.Detached)
                    this.db.EmployeePlans.Attach(this.employeePlan);
                this.db.EmployeePlans.Remove(this.employeePlan);
                this.db.SaveChanges();
                populateDataGridView();
                clearEmployee();
                MessageBox.Show("Usunięto prawidłowo");     
            }
        }

        private void btnCancelEmployee_Click(object sender, EventArgs e)
        {
            clearEmployee();
        }

        private void dgvMaintenanceEmployees_DoubleClick(object sender, EventArgs e)
        {
            if (this.dgvMaintenanceEmployees.CurrentRow.Index != -1)
            {
                this.employeePlan.IdEmployeePlan = Convert.ToInt32(this.dgvMaintenanceEmployees.CurrentRow.Cells["IdEmployeePlan"].Value);                                
                this.employeePlan = this.db.EmployeePlans.Where(x => x.IdEmployeePlan == this.employeePlan.IdEmployeePlan).First();
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
                
                this.btnDeleteEmployee.Enabled = true;
            }
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            DateTime startDate = this.dtpStartDate.Value.Date + this.tpStartDate.Value.TimeOfDay;
            DateTime endDate = this.dtpEndDate.Value.Date + this.tpEndDate.Value.TimeOfDay;
            DateTime employeeStartDate = this.dtpEmployeeStartDate.Value.Date + this.tpEmployeeStartDate.Value.TimeOfDay;
            DateTime employeeEndDate = this.dtpEmployeeEndDate.Value.Date + this.tpEmployeeEndDate.Value.TimeOfDay;

            if ((employeeStartDate < startDate) || (employeeEndDate > endDate))
            {
                MessageBox.Show("Pracownik musi mieć przydzielone daty w terminie zlecenia. " +
                    "Popraw daty dla pracownika lub aktualizuj termin zlecenia");
                return;
            }
            try
            {
                this.employeePlan.StartDate = this.dtpEmployeeStartDate.Value.Date + this.tpEmployeeStartDate.Value.TimeOfDay;
                this.employeePlan.EndDate = this.dtpEmployeeEndDate.Value.Date + this.tpEmployeeEndDate.Value.TimeOfDay;
                 
                this.db.Entry(this.employeePlan).State = EntityState.Modified;
                this.db.SaveChanges();

                clearEmployee();
                MessageBox.Show("Pracownik został zaktualizowany!");
                populateDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się zaktualizować planu. Błąd: " + ex.Message);
            }          
        }
    }
}
