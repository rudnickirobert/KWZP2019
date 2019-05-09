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
    public partial class OrderSfForm : Form
    {
        private RoofingCompanyEntities db;
        private SalesDepartmentForm salesForm;
        private int idSfOrder;
        public OrderSfForm(RoofingCompanyEntities db, SalesDepartmentForm salesForm)
        {
            InitializeComponent();
            this.db = db;
            this.salesForm = salesForm;
        }
        private void OrderSfForm_Load(object sender, EventArgs e)
        {
            List<Supplier> supplierList = db.Suppliers.ToList();
            typeCb.BeginUpdate();
            foreach (Supplier supplier in supplierList)
            {
                typeCb.Items.Add(supplier.SupplierName);
            }
            typeCb.EndUpdate();
        }
        private void acceptBtn_Click(object sender, EventArgs e)
        {
            SemiFinishedOrder newSemiFinishedOrder = new SemiFinishedOrder();
            foreach(Supplier supplier in db.Suppliers.Where(s => s.SupplierName== typeCb.Text.ToString()))
            {
                newSemiFinishedOrder.IdSupplier = supplier.IdSupplier;
            }
            newSemiFinishedOrder.Cost = Convert.ToInt32(costTb.Text.Trim());
            newSemiFinishedOrder.SfOrderDate = orderDateDtp.Value;
            newSemiFinishedOrder.SfDeliveryDate = deliveryDateDtp.Value;
            db.SemiFinishedOrders.Add(newSemiFinishedOrder);
            db.SaveChanges();
            MessageBox.Show("Dodano zamówienie");
            this.Hide();
            salesForm.Show();
            this.Close();
        }
        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            salesForm.Show();
            this.Close();
        }
    }
}
