﻿using System;
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
    public partial class ProductionSelection : Form
    {

        RoofingCompanyEntities db;
        public ProductionSelection(RoofingCompanyEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void btnCurrentProduction_Click(object sender, EventArgs e)
        {
            ProductionProcess productionProcessForm = new ProductionProcess(db);
            productionProcessForm.Show();
        }

        private void btnPlannedProduction_Click(object sender, EventArgs e)
        {
            ProductionPlanned productionPlannedForm = new ProductionPlanned(db);
            productionPlannedForm.Show();
        }

        private void btnProductionHistory_Click(object sender, EventArgs e)
        {
            ProductionHistory productionHistoryForm = new ProductionHistory(db);
            productionHistoryForm.Show();
        }

        private void btnProductionSelectionReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
