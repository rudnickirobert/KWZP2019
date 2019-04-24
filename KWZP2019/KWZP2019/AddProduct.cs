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
            product.IdSemiFinished = 5;
            product.ProductCode = "laalelalamanocha";
            product.IdTechnology = 5;
            product.InputDate = DateTime.Now;
            db.Products.Add(product);
            db.SaveChanges();
        }
    }
}
