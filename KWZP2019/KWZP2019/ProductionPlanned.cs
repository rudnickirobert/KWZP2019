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
    public partial class ProductionPlanned : Form
    {
        RoofingCompanyEntities db; 

        public ProductionPlanned(RoofingCompanyEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void ProductionPlanned_Load(object sender, EventArgs e)
        {
            PlannedProductionGridView.DataSource = db.PlannedProductions.ToList();
        }


        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
        private bool isTxtBoxEmpty(TextBox tBox)
        {
            return tBox.Text.Trim().Length < 1;
        }
        private void txtBoxPlanSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(isTxtBoxEmpty(txtBoxPlanSearch)) 
            {
                PlannedProductionGridView.DataSource = db.PlannedProductions.ToList();
            }
        }
        private void btnAddPlan_Click(object sender, EventArgs e)
        {
            NewProductionPlan NewProductionPlanForm = new NewProductionPlan(db);
            NewProductionPlanForm.Show();
        }
        



    }
}
