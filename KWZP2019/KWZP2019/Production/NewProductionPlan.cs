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
        int idPlan, employeesQuantity;
        public NewProductionPlan(RoofingCompanyEntities db, int id)
        {
            InitializeComponent();
            this.db = db;
            idPlan = id;
        }
        private void NewProductionPlan_Load(object sender, EventArgs e)
        {
            if (idPlan > 0)
            {
                PlannedProduction plan = db.PlannedProductions.First(f => f.IdPlan == idPlan);
                vUnhandledOrderDetail order = new vUnhandledOrderDetail();
                OrderDetail orderDetail = db.OrderDetails.First(f => f.IdDetail == plan.IdDetail);
                Product product = db.Products.First(f => f.IdProduct == orderDetail.IdProduct);
                if (plan != null)
                {
                    tBoxPlanNr.Text = Convert.ToString(plan.IdPlan);
                    cBoxMachine.Text = Convert.ToString(plan.IdMachine);
                    order.IdDetail = plan.IdDetail;
                    order.Quantity = orderDetail.Quantity;
                    order.ProductCode = product.ProductCode;
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
            dateTimeStart.CustomFormat = "yyyy-MM-dd HH:mm";
            dateTimeEnd.CustomFormat = "yyyy-MM-dd HH:mm";
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
            int idMachine = Convert.ToInt32(cBoxMachine.Text.Trim());
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
                dateTimeEnd.Value = dateEnd;
                btnSave.Enabled = true;
            }
        }
        private bool editPlan()
        {
            int currentPlanId = Convert.ToInt32(tBoxPlanNr.Text.Trim());
            return db.PlannedProductions.Count() >= currentPlanId;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (editPlan())
            {
                PlannedProduction existingPlan = db.PlannedProductions.First(f => f.IdPlan == idPlan);
                existingPlan.IdDetail = Convert.ToInt32(this.viewOrderDetail.CurrentRow.Cells[0].Value);
                existingPlan.IdMachine = Convert.ToInt32(cBoxMachine.Text.Trim());
                existingPlan.PlannedStartd = dateTimeStart.Value;
                existingPlan.PlannedEndd = dateTimeEnd.Value;
                existingPlan.Inproduction = Convert.ToBoolean(cBoxIntoProduction.CheckState);
                db.SaveChanges();
                MessageBox.Show("Dokonano edycji planu!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {           
                if (employeesQuantity == 0)
                {
                    MessageBox.Show("Nie przydzielono pracownika!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    PlannedProduction newPlan = new PlannedProduction();
                    newPlan.IdDetail = Convert.ToInt32(this.viewOrderDetail.CurrentRow.Cells[0].Value);
                    newPlan.IdMachine = Convert.ToInt32(cBoxMachine.Text.Trim());
                    newPlan.PlannedStartd = dateTimeStart.Value;
                    newPlan.PlannedEndd = dateTimeEnd.Value;
                    newPlan.Inproduction = Convert.ToBoolean(cBoxIntoProduction.CheckState);
                    db.PlannedProductions.Add(newPlan);
                    db.SaveChanges();
                    MessageBox.Show("Dodano nowy plan!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnSave.Enabled = false;
                }
            }
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
            }
            else
            {
                MessageBox.Show("Zaplanowano wszystkie zlecenia!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
