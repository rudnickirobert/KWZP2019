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
    public partial class NewProductionPlan : Form
    {
        RoofingCompanyEntities db = new RoofingCompanyEntities();
        public NewProductionPlan(RoofingCompanyEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void NewProductionPlan_Load(object sender, EventArgs e)
        {
            viewProcessEmpl.DataSource = db.PlannedProductionEmployeeDetails.ToList();
        }



        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
