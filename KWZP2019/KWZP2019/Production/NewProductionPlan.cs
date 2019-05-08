using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Extensions.DateTime;

namespace KWZP2019
{
    public partial class NewProductionPlan : Form
    {
        RoofingCompanyEntities db;
        int idPlan, employeesQuantity;
        bool flagEditPlan = true;
        bool flagExitPermission = true;
        PlannedProduction newPlan = new PlannedProduction();
        public NewProductionPlan(RoofingCompanyEntities db, int id)
        {
            InitializeComponent();
            this.db = db;
            idPlan = id;
        }
        private void NewProductionPlan_Load(object sender, EventArgs e)
        {
            comboBoxMachine.DataSource = db.vComboBoxMachines.ToList();
            comboBoxMachine.ValueMember = "idMachine";
            comboBoxMachine.DisplayMember = "machineFullName";
            comboBoxMachine.Invalidate();
            comboBoxEmployee.DataSource = db.vComboBoxEmployees.ToList();
            comboBoxEmployee.ValueMember = "idEmployee";
            comboBoxEmployee.DisplayMember = "employeeFullName";
            comboBoxEmployee.Invalidate();
            if (idPlan > 0)
            {
                PlannedProduction plan = db.PlannedProductions.First(f => f.IdPlan == idPlan);
                vUnhandledOrderDetail order = new vUnhandledOrderDetail();
                OrderDetail orderDetail = db.OrderDetails.First(f => f.IdDetail == plan.IdDetail);
                Product product = db.Products.First(f => f.IdProduct == orderDetail.IdProduct);
                if (plan != null)
                {
                    vComboBoxMachine selectedMachine = db.vComboBoxMachines.First(f => f.IdMachine == plan.IdMachine);
                    tBoxPlanNr.Text = Convert.ToString(plan.IdPlan);
                    comboBoxMachine.Text = Convert.ToString(selectedMachine.machineFullName);
                    order.IdDetail = plan.IdDetail;
                    order.Quantity = orderDetail.Quantity;
                    order.ProductCode = product.ProductCode;
                    cBoxIntoProduction.Checked = (bool)plan.Inproduction;
                }
                else
                {
                    MessageBox.Show("Brak planu!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                List<vUnhandledOrderDetail> handledOrder = new List<vUnhandledOrderDetail>();
                handledOrder.Add(order);
                viewOrderDetail.DataSource = handledOrder;
            }
            else
            {
                MessageBox.Show("Nieprawidłowy numer planu!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            viewProcessEmpl.DataSource = (from PlannedProductionEmployeeDetail in db.PlannedProductionEmployeeDetails
                                          where PlannedProductionEmployeeDetail.IdProces == idPlan
                                          select PlannedProductionEmployeeDetail).ToList();
            dateTimeStart.Format = DateTimePickerFormat.Custom;
            dateTimeEnd.Format = DateTimePickerFormat.Custom;
            dateTimeEmployeeStart.Format = DateTimePickerFormat.Custom;
            dateTimeEmployeeEnd.Format = DateTimePickerFormat.Custom;
            dateTimeStart.CustomFormat = "yyyy-MM-dd HH:mm";
            dateTimeEnd.CustomFormat = "yyyy-MM-dd HH:mm";
            dateTimeEmployeeStart.CustomFormat = "yyyy-MM-dd HH:mm";
            dateTimeEmployeeEnd.CustomFormat = "yyyy-MM-dd HH:mm";
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (editPlan() & flagEditPlan)
            {
                Close();
            }
            else
            {

                if (viewProcessEmpl.RowCount == 0)
                {
                    db.PlannedProductions.Remove(newPlan);
                    db.SaveChanges();
                    Close();
                }
                else if(viewProcessEmpl.DataSource == null)
                {
                    Close();
                }
                else
                {
                    if (flagExitPermission)
                    {
                        MessageBox.Show("Usuń wszystkich pracowników jeśli nie chcesz zapisać tego planu", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        Close();
                    }
                }
            }
        }
        private void viewOrderDetail_SelectionChanged(object sender, EventArgs e)
        {
            int idDetail = Convert.ToInt32(this.viewOrderDetail.CurrentRow.Cells[0].Value);
            OrderDetail orderDetail = db.OrderDetails.First(f => f.IdDetail == idDetail);
            OrderCustomer orderCustomer = db.OrderCustomers.First(f => f.IdOrderCustomer == orderDetail.IdOrderCustomer);
            dateTimeStart.Value = orderCustomer.OrderDate;
        }
        private void btnEndDateCalculate_Click(object sender, EventArgs e)
        {
            int idMachine = Convert.ToInt32(comboBoxMachine.SelectedValue);
            int idDetail = Convert.ToInt32(this.viewOrderDetail.CurrentRow.Cells[0].Value);
            int idPlan = Convert.ToInt32(tBoxPlanNr.Text.Trim());
            double timeInterval;
            List<PlannedProductionEmployeeDetail> productionEmployess = (from PlannedProductionEmployeeDetail in db.PlannedProductionEmployeeDetails
                                                                         where PlannedProductionEmployeeDetail.IdProces == idPlan
                                                                         select PlannedProductionEmployeeDetail).ToList();
            OrderDetail orderDetail = db.OrderDetails.First(f => f.IdDetail == idDetail);
            Product product = db.Products.First(f => f.IdProduct == orderDetail.IdProduct);
            Technology technology = db.Technologies.First(f => f.IdTechnology == product.IdTechnology);
            Maintenance maintenance = db.Maintenances.First(f => f.IdMaintenance == idMachine);
            Machine machine = db.Machines.First(f => f.IdMachine == maintenance.IdMachine);
            employeesQuantity = productionEmployess.Count();
            if (employeesQuantity == 0)
            {
                MessageBox.Show("Nie przydzielono żadnego pracownika!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
            }
            else
            {
                timeInterval = orderDetail.Quantity * machine.MetersPerHour * 0.3 * technology.TimePermeter * 0.2
                                / employeesQuantity + orderDetail.Quantity * 0.7;
                DateTime dateEnd = dateTimeStart.Value.AddMinutes(timeInterval);
                DateTime dateStart = dateTimeStart.Value;
                double totalDays = (dateEnd - dateStart).TotalDays;
                string messageAboutProductionDuration = "Produkcja zajmie: " + Convert.ToString(Math.Round(totalDays, 2)) + " dni roboczych.";
                MessageBox.Show(messageAboutProductionDuration, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateTimeEnd.Value = dateStart.AddBusinessDays(totalDays);
                btnSave.Enabled = true;
            }
        }
        private bool editPlan()
        {
            int currentPlanId = Convert.ToInt32(tBoxPlanNr.Text.Trim());
            return db.PlannedProductions.Count() > currentPlanId;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (editPlan() || flagEditPlan)
            {
                PlannedProduction existingPlan = db.PlannedProductions.First(f => f.IdPlan == idPlan);
                existingPlan.IdDetail = Convert.ToInt32(this.viewOrderDetail.CurrentRow.Cells[0].Value);
                existingPlan.IdMachine = Convert.ToInt32(comboBoxMachine.SelectedValue);
                existingPlan.PlannedStartd = dateTimeStart.Value;
                existingPlan.PlannedEndd = dateTimeEnd.Value;
                existingPlan.Inproduction = Convert.ToBoolean(cBoxIntoProduction.CheckState);
                db.SaveChanges();
                MessageBox.Show("Dokonano edycji planu!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                employeesQuantity = viewProcessEmpl.RowCount;
                if (employeesQuantity == 0)
                {
                    MessageBox.Show("Nie przydzielono pracownika!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    newPlan.IdDetail = Convert.ToInt32(this.viewOrderDetail.CurrentRow.Cells[0].Value);
                    newPlan.IdMachine = Convert.ToInt32(comboBoxMachine.SelectedValue);
                    newPlan.PlannedStartd = dateTimeStart.Value;
                    newPlan.PlannedEndd = dateTimeEnd.Value;
                    newPlan.Inproduction = Convert.ToBoolean(cBoxIntoProduction.CheckState);
                    db.SaveChanges();
                    MessageBox.Show("Dodano nowy plan!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnSave.Enabled = false;
                }
            }
            flagExitPermission = false;
        }
        private bool isEmptyDataGridViewEmployee()
        {
            return viewProcessEmpl.DataSource == null;
        }
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            int currentPlanNumber = Convert.ToInt32(tBoxPlanNr.Text.Trim());
            PlannedProductionEmployeeDetail newEmployee = new PlannedProductionEmployeeDetail();
            newPlan.IdDetail = 1;
            newPlan.IdMachine = 1;
            newPlan.PlannedStartd = DateTime.Now;
            newPlan.PlannedEndd = DateTime.Now;
            newPlan.Inproduction = false;
            newEmployee.IdProces = currentPlanNumber;
            newEmployee.IdEmployee = Convert.ToInt32(comboBoxEmployee.SelectedValue);
            newEmployee.StartDate = dateTimeEmployeeStart.Value;
            newEmployee.EndDate = dateTimeEmployeeEnd.Value;
            if (isEmptyDataGridViewEmployee())
            {
                db.PlannedProductions.Add(newPlan);
                db.PlannedProductionEmployeeDetails.Add(newEmployee);
                db.SaveChanges();
                viewProcessEmpl.DataSource = (from PlannedProductionEmployeeDetail in db.PlannedProductionEmployeeDetails
                                              where PlannedProductionEmployeeDetail.IdProces == currentPlanNumber
                                              select PlannedProductionEmployeeDetail).ToList();
            }
            else
            {
                db.PlannedProductionEmployeeDetails.Add(newEmployee);
                db.SaveChanges();
                viewProcessEmpl.DataSource = (from PlannedProductionEmployeeDetail in db.PlannedProductionEmployeeDetails
                                              where PlannedProductionEmployeeDetail.IdProces == currentPlanNumber
                                              select PlannedProductionEmployeeDetail).ToList();
            }
        }
        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {
            int currentPlanNumber = Convert.ToInt32(tBoxPlanNr.Text.Trim());
            int idEmployeeToRemove = Convert.ToInt32(this.viewProcessEmpl.CurrentRow.Cells["idDetail"].Value);
            string messageDuringRemovingEmployee = "Usunięto plan pracownika o numerze: " + Convert.ToString(idEmployeeToRemove + ".");
            MessageBox.Show(messageDuringRemovingEmployee, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PlannedProductionEmployeeDetail employeeToRemove = db.PlannedProductionEmployeeDetails.First(f => f.IdDetail == idEmployeeToRemove);
            db.PlannedProductionEmployeeDetails.Remove(employeeToRemove);
            db.SaveChanges();
            viewProcessEmpl.DataSource = (from PlannedProductionEmployeeDetail in db.PlannedProductionEmployeeDetails
                                          where PlannedProductionEmployeeDetail.IdProces == currentPlanNumber
                                          select PlannedProductionEmployeeDetail).ToList();
        }

        private void viewProcessEmpl_SelectionChanged(object sender, EventArgs e)
        {
            int idEmployeeToShow = Convert.ToInt32(this.viewProcessEmpl.CurrentRow.Cells["dataGridViewTextBoxColumnEmployeeId"].Value);
            Employee showEmployee = db.Employees.First(f => f.IdEmployee == idEmployeeToShow);
            string infoAboutEmployee = Convert.ToString(showEmployee.EmployeeName) + " " + Convert.ToString(showEmployee.EmployeeSurname);
            labelSelectedEmployee.Text = infoAboutEmployee;
        }

        private void btnNewPlan_Click(object sender, EventArgs e)
        {
            if (db.vUnhandledOrderDetails.Any())
            {
                int newPlanId = db.PlannedProductions.Count() + 1;
                viewOrderDetail.DataSource = db.vUnhandledOrderDetails.ToList();
                tBoxPlanNr.Text = Convert.ToString(newPlanId);
                viewProcessEmpl.DataSource = null;
                btnSave.Enabled = true;
                flagEditPlan = false;
            }
            else
            {
                MessageBox.Show("Zaplanowano wszystkie zlecenia!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
