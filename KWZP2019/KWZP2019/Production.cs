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
        public Production(RoofingCompanyEntities db)
        {
            InitializeComponent();
        }

        private void btnTechnology_Click(object sender, EventArgs e)
        {
            ProductionTechnology ProductionTechnologyform = new ProductionTechnology();
            ProductionTechnologyform.Show();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductionProducts ProductionProductsform = new ProductionProducts();
            ProductionProductsform.Show();
        }

        private void btnFailures_Click(object sender, EventArgs e)
        {
            ProductionFailures ProductionFailuresform = new ProductionFailures();
            ProductionFailuresform.Show();
        }

        private void btnProductionProcess_Click(object sender, EventArgs e)
        {
            ProductionProcess ProductionProcessform = new ProductionProcess();
            ProductionProcessform.Show();
        }

        private void btnProductionPlanned_Click(object sender, EventArgs e)
        {
            ProductionPlanned ProductionPlannedform = new ProductionPlanned();
            ProductionPlannedform.Show();
        }
    }
}
