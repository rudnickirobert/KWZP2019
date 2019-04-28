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
    public partial class AddProduct : Form
    {
        RoofingCompanyEntities db;
        public AddProduct(RoofingCompanyEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void btCloseAddProduct_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAddConfirm_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.IdSemiFinished = Convert.ToInt32(cBSemiFinished.SelectedValue);
            product.ProductCode = tBProductCode.Text;
            product.IdTechnology = Convert.ToInt32(cBTechnology.SelectedValue);
            product.InputDate = dTPAddTime.Value;
            db.Products.Add(product);
            db.SaveChanges();
            MessageBox.Show("Dodano nowy produkt!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            cBSemiFinished.ValueMember = "IdSemiFinished";
            cBSemiFinished.DisplayMember = "SfCode";
            cBSemiFinished.DataSource = db.SemiFinisheds.Distinct().ToList();
            cBSemiFinished.Invalidate();

            cBTechnology.ValueMember = "IdTechnology";
            cBTechnology.DisplayMember = "TechnologyName";
            cBTechnology.DataSource = db.Technologies.Distinct().ToList();
            cBTechnology.Invalidate();
        }
    }
}
