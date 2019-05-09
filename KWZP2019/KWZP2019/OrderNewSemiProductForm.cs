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
    public partial class OrderNewSemiProductForm : Form
    {
        private RoofingCompanyEntities db;
        private SalesDepartmentForm salesForm;
        private int idSfOrder;
        public OrderNewSemiProductForm(RoofingCompanyEntities db, object idSfOrder, SalesDepartmentForm salesForm)
        {
            InitializeComponent();
            this.db = db;
            this.salesForm = salesForm;
            this.idSfOrder = Convert.ToInt32(idSfOrder);
            idSfOrderTb.Text = idSfOrder.ToString();
        }
        private void OrderNewSemiProductForm_Load(object sender, EventArgs e)
        {
            List<SemiFinished> sfList = db.SemiFinisheds.ToList();
            semiProductCodeCb.BeginUpdate();
            foreach (SemiFinished sf in sfList)
            {
                semiProductCodeCb.Items.Add(sf.SfCode);
            }
            semiProductCodeCb.EndUpdate();
        }
        private void acceptBtn_Click(object sender, EventArgs e)
        {
            SfOrderDetail newSfOrderDetail = new SfOrderDetail();
            newSfOrderDetail.IdSfOrder = idSfOrder;
            foreach (SemiFinished sf in db.SemiFinisheds.Where(sf => sf.SfCode.Contains(semiProductCodeCb.Text.ToString())))
            {
                    newSfOrderDetail.IdSemiFinished = sf.IdSemiFinished;
            }
            newSfOrderDetail.Quantity = Convert.ToInt32(quantityTb.Text.Trim());
            db.SfOrderDetails.Add(newSfOrderDetail);
            db.SaveChanges();
            MessageBox.Show("Dodano szczegół zamówienia");
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
