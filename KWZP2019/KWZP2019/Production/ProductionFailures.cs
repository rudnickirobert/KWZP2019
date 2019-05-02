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
    public partial class ProductionFailures : Form
    {
        RoofingCompanyEntities db;
        public ProductionFailures(RoofingCompanyEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void refreshFailures()
        {
            gridViewFailures.DataSource = db.Failures.ToList();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            NewProductionFailure newProductionFailureForm = new NewProductionFailure(db);
            newProductionFailureForm.Show();
        }

        private void ProductionFailures_Load(object sender, EventArgs e)
        {
            refreshFailures();
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            refreshFailures();
        }
    }
}
