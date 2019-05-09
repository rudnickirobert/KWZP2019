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
    public partial class SfOrdersForm : Form
    {
        private RoofingCompanyEntities db;
        private SalesDepartmentForm salesForm;
        public SfOrdersForm(RoofingCompanyEntities db, SalesDepartmentForm salesForm)
        {
            InitializeComponent();
            this.db = db;
            this.salesForm = salesForm;
        }
        private void SfOrdersForm_Load(object sender, EventArgs e)
        {
            sfOrdersDgv.DataSource = db.vSFOrders.ToList();
            sfOrderDetailsDgv.DataSource = db.vSFOrderDetails.ToList();
            sfOrderDetailsDgv.Columns["Nr_zamówienia"].Visible = false;
        }
        private void deleteOrderDetailBtn_Click(object sender, EventArgs e)
        {
            int idDetailToRemove = Convert.ToInt32(this.sfOrderDetailsDgv.CurrentRow.Cells["Nr_szczegółu"].Value);
            string messageDuringRemovingDetail = "Usunięto szczegół o numerze: " + Convert.ToString(idDetailToRemove);
            MessageBox.Show(messageDuringRemovingDetail, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SfOrderDetail detailToRemove = db.SfOrderDetails.First(f => f.IdSfDetail == idDetailToRemove);
            db.SfOrderDetails.Remove(detailToRemove);
            db.SaveChanges();
            int id = Convert.ToInt32(this.sfOrdersDgv.CurrentRow.Cells["Nr_zamówienia"].Value);
            sfOrderDetailsDgv.DataSource = (from sfOrders in db.vSFOrderDetails
                                            where sfOrders.Nr_zamówienia == id
                                            select sfOrders).ToList();
            sfOrderDetailsDgv.Columns["Nr_zamówienia"].Visible = false;
            sfOrderDetailsLbl.Text = "Szczegół zamówienia nr: " + sfOrdersDgv.CurrentRow.Cells["Nr_zamówienia"].Value.ToString();
            salesForm.Show();
        }
        private void sfOrderDetailBtn_Click(object sender, EventArgs e)
        {
            //EXCEPTION PROTECTION
            if (sfOrdersDgv.SelectedCells.Count == 0)
            {
                MessageBox.Show("Wybierz zamówienie");
            }
            else
            {
                this.Hide();
                OrderNewSemiProductForm OrderNewSemiProductForm = new OrderNewSemiProductForm(db, sfOrdersDgv.CurrentRow.Cells["Nr_zamówienia"].Value, salesForm);
                OrderNewSemiProductForm.ShowDialog();
            }
        }
        private void sfOrderBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderSfForm newOrderSfForm = new OrderSfForm(db, salesForm);
            newOrderSfForm.ShowDialog();
        }
        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            salesForm.Show();
            this.Close();
        }
        private void sfOrdersDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(this.sfOrdersDgv.CurrentRow.Cells["Nr_zamówienia"].Value);
            sfOrderDetailsDgv.DataSource = (from sfOrders in db.vSFOrderDetails
                                    where sfOrders.Nr_zamówienia == id
                                    select sfOrders).ToList();
            sfOrderDetailsDgv.Columns["Nr_zamówienia"].Visible = false;
            sfOrderDetailsLbl.Text = "Szczegół zamówienia nr: " + sfOrdersDgv.CurrentRow.Cells["Nr_zamówienia"].Value.ToString();
        }
    }
}
