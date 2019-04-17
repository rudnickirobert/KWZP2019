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
    public partial class Production : Form
    {
        RoofingCompanyEntities db = new RoofingCompanyEntities();
        public Production(RoofingCompanyEntities db)
        {
            InitializeComponent();
            this.db = db; 
        }

        private void btnTechnology_Click(object sender, EventArgs e)
        {
            ProductionTechnology ProductionTechnologyForm = new ProductionTechnology();
            ProductionTechnologyForm.Show();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductionProducts ProductionProductsForm = new ProductionProducts();
            ProductionProductsForm.Show();
        }

        private void btnFailures_Click(object sender, EventArgs e)
        {
            ProductionFailures ProductionFailuresForm = new ProductionFailures();
            ProductionFailuresForm.Show();
        }

        private void btnProductionProcess_Click(object sender, EventArgs e)
        {
            ProductionProcess ProductionProcessForm = new ProductionProcess();
            ProductionProcessForm.Show();
        }

        private void btnProductionPlanned_Click(object sender, EventArgs e)
        {
            ProductionPlanned ProductionPlannedForm = new ProductionPlanned();
            ProductionPlannedForm.Show();
        }
    }
}
