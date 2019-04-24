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

        private void btnNewPlan_Click(object sender, EventArgs e)
        {
            tBoxPlanNr.Text = Convert.ToString(idNewPlan);
            viewProcessEmpl.DataSource = null;
            viewOrderDetail.DataSource = db.vUnhandledOrderDetails.ToList();
            //OrderCustomer orderCustomer = db.OrderCustomers.FirstOrDefault(f => f.IdOrderCustomer == orderDetail.IdOrderCustomer);


        }
    }
}
