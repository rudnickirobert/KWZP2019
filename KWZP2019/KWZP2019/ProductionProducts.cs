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
        RoofingCompanyEntities db = new RoofingCompanyEntities();

        public ProductionProducts(RoofingCompanyEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddProduct AddProductForm = new AddProduct(db);
            AddProductForm.Show();

        }
    }
}
