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
            
            if (idPlan > 0)
            {
                PlannedProduction plan = db.PlannedProductions.FirstOrDefault(f => f.IdPlan == idPlan);
                vUnhandledOrderDetails order = new vUnhandledOrderDetails();
                OrderDetail orderDetail = db.OrderDetails.FirstOrDefault(f => f.IdDetail == plan.IdDetail);
                Product product = db.Products.FirstOrDefault(f=>f.IdProduct==orderDetail.IdProduct);
               
                if (plan != null)
                {
                    tBoxPlanNr.Text = Convert.ToString(plan.IdPlan);
                    cBoxMachine.Text = Convert.ToString(plan.IdMachine);
                    order.IdDetail= plan.IdDetail;
                    order.Quantity = orderDetail.Quantity;
                    order.ProductCode = product.ProductCode;
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
            OrderDetail orderDetail = db.OrderDetails.FirstOrDefault(f => f.IdDetail == idDetail);
            OrderCustomer orderCustomer = db.OrderCustomers.FirstOrDefault(f => f.IdOrderCustomer == orderDetail.IdOrderCustomer);
            dateTimeStart.Value = orderCustomer.OrderDate;
        }

        private void btnEndDateCalculate_Click(object sender, EventArgs e)
        {
            int idMachine = Convert.ToInt32(cBoxMachine.Text.Trim());
            int idDetail = Convert.ToInt32(this.viewOrderDetail.CurrentRow.Cells[0].Value);
            double timeInterval;
            OrderDetail orderDetail = db.OrderDetails.FirstOrDefault(f => f.IdDetail == idDetail);
            Product product = db.Products.FirstOrDefault(f => f.IdProduct == orderDetail.IdProduct);
            Technology technology = db.Technologies.FirstOrDefault(f => f.IdTechnology == product.IdTechnology);
            Maintenance maintenance = db.Maintenances.FirstOrDefault(f => f.IdMaintenance == idMachine);
            Machine machine = db.Machines.FirstOrDefault(f => f.IdMachine == maintenance.IdMachine);
            timeInterval = orderDetail.Quantity * machine.MetersPerHour * technology.TimePermeter * 0.2;
        }

        private void btnNewPlan_Click(object sender, EventArgs e)
        {
            viewOrderDetail.DataSource = db.vUnhandledOrderDetails.ToList();
            tBoxPlanNr.Text = Convert.ToString(idNewPlan);
            viewProcessEmpl.DataSource = null;
            dateTimeStart.Format = DateTimePickerFormat.Custom;
            dateTimeStart.CustomFormat = "yyyy-MM-dd HH:mm";
            dateTimeEnd.CustomFormat = "yyyy-MM-dd HH:mm";


        }

    }
}
