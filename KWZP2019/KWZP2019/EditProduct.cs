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
    public partial class EditProduct : Form
    {
        RoofingCompanyEntities db;
        int IDProd;
        Product product = new Product();
        public EditProduct(RoofingCompanyEntities db , int IDprod)
        {
            this.IDProd = IDprod;
            this.db = db;
            InitializeComponent();
            tBNumberProd.Text = Convert.ToString(IDProd);
            product = db.Products.Where(t => t.IdProduct == IDProd).First();
            tBProductCode.Text = (string)product.ProductCode;
         }

        private void btEditConfirm_Click(object sender, EventArgs e)
        {
            product.IdSemiFinished = Convert.ToInt32(cBEditSemiFinished.SelectedValue);
            product.IdTechnology = Convert.ToInt32(cBEditTechnology.SelectedValue);
            product.ProductCode = Convert.ToString(tBProductCode.Text);
            db.SaveChanges();

            MessageBox.Show("Edytowano!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btEditBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditProduct_Load(object sender, EventArgs e)
        {
            cBEditSemiFinished.ValueMember = "IdSemiFinished";
            cBEditSemiFinished.DisplayMember = "SfCode";
            cBEditSemiFinished.DataSource = db.SemiFinisheds.Distinct().ToList();
            cBEditSemiFinished.Invalidate();
            cBEditSemiFinished.SelectedValue = (int)product.IdSemiFinished;

            cBEditTechnology.ValueMember = "IdTechnology";
            cBEditTechnology.DisplayMember = "TechnologyName";
            cBEditTechnology.DataSource = db.Technologies.Distinct().ToList();
            cBEditTechnology.Invalidate();
            cBEditTechnology.SelectedValue = (int)product.IdTechnology;
        }
    }
}
