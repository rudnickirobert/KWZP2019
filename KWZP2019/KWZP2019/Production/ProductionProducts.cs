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
    public partial class ProductionProducts : Form
    {
        RoofingCompanyEntities db;
        private int idSelected;
        public ProductionProducts(RoofingCompanyEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void deleteProduct()
        {
            Product produkt = db.Products.First(f => f.IdProduct == idSelected);
            db.Products.Remove(produkt);
            db.SaveChanges();
        }

        private void refreshProducts()
        {
            dataGridProducts.DataSource = db.vProductionProducts.ToList();
        }

        private void btAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct(db);
            addProduct.Show();
        }

        private void ProductionProducts_Load(object sender, EventArgs e)
        {
            dataGridProducts.DataSource = db.vProductionProducts.ToList();
        }

        private void btEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btDeleteProduct_Click(object sender, EventArgs e)
        {
            deleteProduct();
            refreshProducts();
        }

        private void dataGridProducts_SelectionChanged(object sender, EventArgs e)
        {
            idSelected = Convert.ToInt32(this.dataGridProducts.CurrentRow.Cells[0].Value);
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            refreshProducts();
        }

        private void btEditProduct_Click(object sender, EventArgs e)
        {
            EditProduct editProduct = new EditProduct(db, idSelected);
            editProduct.Show();
        }
    }
}
