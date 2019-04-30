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
    public partial class NewProductionPlan : Form
    {
        RoofingCompanyEntities db;
        int idPlan, idNewPlan;
        public NewProductionPlan(RoofingCompanyEntities db, int id, int newId)
        {
            InitializeComponent();
            this.db = db;
            idPlan = id;
            idNewPlan = newId;
        }
        private void NewProductionPlan_Load(object sender, EventArgs e)
        {
            comboBoxMachine.DataSource = (from maintenanceForComboBox in db.Maintenances
                                      join machineForComboBox in db.Machines
                                      on maintenanceForComboBox.IdMachine equals machineForComboBox.IdMachine
                                      select new
                                      {
                                          machineIdForComboBox = maintenanceForComboBox.IdMachine,
                                          fullMachineNameForComboBox = machineForComboBox.MachineName + " " + machineForComboBox.CatalogMachineNr
                                      }).Distinct().ToList();
            comboBoxMachine.ValueMember = "machineIdForComboBox";
            comboBoxMachine.DisplayMember = "fullMachineNameForComboBox";
            comboBoxMachine.Invalidate();

            comboBoxEmployee.DataSource = (from allocationForComboBox in db.Allocations
                                           join employeeForComboBox in db.Employees
                                           on allocationForComboBox.IdEmployee equals employeeForComboBox.IdEmployee
                                           where allocationForComboBox.IdDepartment == 1
                                           select new
                                           {
                                               employeeIdForComboBox = employeeForComboBox.IdEmployee,
                                               employeeFullNameForComboBox = employeeForComboBox.EmployeeName + " " + employeeForComboBox.EmployeeSurname
                                           }).ToList();
            comboBoxEmployee.ValueMember = "employeeIdForComboBox";
            comboBoxEmployee.DisplayMember = "employeeFullNameForComboBox";
            comboBoxEmployee.Invalidate();

            if (idPlan > 0)
            {
                PlannedProduction plan = db.PlannedProductions.First(f => f.IdPlan == idPlan);
                vUnhandledOrderDetails order = new vUnhandledOrderDetails();
                OrderDetail orderDetail = db.OrderDetails.First(f => f.IdDetail == plan.IdDetail);
                Product product = db.Products.First(f => f.IdProduct == orderDetail.IdProduct);
                if (plan != null)
                {
                    tBoxPlanNr.Text = Convert.ToString(plan.IdPlan);
                    comboBoxMachine.Text = Convert.ToString(plan.IdMachine);
                    order.IdDetail= plan.IdDetail;
                    order.Quantity = orderDetail.Quantity;
                    order.ProductCode = product.ProductCode;
                }
                else
                {
                    MessageBox.Show("Brak planu!","Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                List<vUnhandledOrderDetails> handledOrder = new List<vUnhandledOrderDetails>();
                handledOrder.Add(order);
                viewOrderDetail.DataSource = handledOrder;                      
            }
            viewProcessEmpl.DataSource = (from PlannedProductionEmployeeDetail in db.PlannedProductionEmployeeDetails
                                          where PlannedProductionEmployeeDetail.IdProces == idPlan
                                          select PlannedProductionEmployeeDetail).ToList();
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
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
            double timeInterval;
            OrderDetail orderDetail = db.OrderDetails.First(f => f.IdDetail == idDetail);
            Product product = db.Products.First(f => f.IdProduct == orderDetail.IdProduct);
            Technology technology = db.Technologies.First(f => f.IdTechnology == product.IdTechnology);
            Maintenance maintenance = db.Maintenances.First(f => f.IdMaintenance == idMachine);
            Machine machine = db.Machines.First(f => f.IdMachine == maintenance.IdMachine);
            timeInterval = orderDetail.Quantity * machine.MetersPerHour * 0.5 * technology.TimePermeter * 0.2;
            DateTime dateEnd = dateTimeStart.Value.AddMinutes(timeInterval);
            dateTimeEnd.Value = dateEnd;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PlannedProduction newPlan = new PlannedProduction();
            newPlan.IdDetail = Convert.ToInt32(this.viewOrderDetail.CurrentRow.Cells[0].Value);
            newPlan.IdMachine = Convert.ToInt32(comboBoxMachine.SelectedValue);
            newPlan.PlannedStartd = dateTimeStart.Value;
            newPlan.PlannedEndd = dateTimeEnd.Value;
            newPlan.Inproduction = Convert.ToBoolean(cBoxIntoProduction.CheckState);
            db.PlannedProductions.Add(newPlan);
            db.SaveChanges();
            MessageBox.Show("Dodano nowy plan!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnNewPlan_Click(object sender, EventArgs e)
        {
            viewOrderDetail.DataSource = db.vUnhandledOrderDetails.ToList();
            tBoxPlanNr.Text = Convert.ToString(idNewPlan);
            viewProcessEmpl.DataSource = null;
            dateTimeStart.Format = DateTimePickerFormat.Custom;
            dateTimeEnd.Format = DateTimePickerFormat.Custom;
            dateTimeStart.CustomFormat = "yyyy-MM-dd HH:mm";
            dateTimeEnd.CustomFormat = "yyyy-MM-dd HH:mm";
        }
    }
}
