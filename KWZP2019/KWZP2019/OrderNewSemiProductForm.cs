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
        public OrderNewSemiProductForm(RoofingCompanyEntities db, SalesDepartmentForm salesForm)
        {
            InitializeComponent();
            this.db = db;
            this.salesForm = salesForm;
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
            SfOrderDetail newsfOrderDetail = new SfOrderDetail();
            foreach (SemiFinished sf in db.SemiFinisheds.Where(sf => sf.SfCode == semiProductCodeCb.SelectedValue.ToString()))
            {
                newsfOrderDetail.IdSemiFinished = sf.IdSemiFinished;
            }

            newsfOrderDetail.IdSfOrder = 1;
            newsfOrderDetail.Quantity = Convert.ToInt32(quantityTb.Text.Trim());
        }
        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            salesForm.Show();
            this.Close();
        }
    }
}
