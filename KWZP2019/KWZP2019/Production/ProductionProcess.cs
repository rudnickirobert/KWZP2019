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
    public partial class ProductionProcess : Form
    {
        RoofingCompanyEntities db;
        public ProductionProcess(RoofingCompanyEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void ProductionProcess_Load(object sender, EventArgs e)
        {
            List<PlannedProduction> plansAddedToProduction = db.PlannedProductions.
               Where(plannedProductionPlan => !db.ProductionProcess.
               Select(productionProcessPlan => productionProcessPlan.IdPlan).
               Contains(plannedProductionPlan.IdPlan) && plannedProductionPlan.Inproduction.Value).ToList();

            foreach (PlannedProduction plannedProduction in plansAddedToProduction)
            {   
                    ProductionProcess newProductionProces = new ProductionProcess();
                    newProductionProces.IdPlan = plannedProduction.IdPlan;
                    newProductionProces.StartDate = plannedProduction.PlannedStartd;
                    newProductionProces.EndDate = plannedProduction.PlannedEndd;
                    db.ProductionProcess.Add(newProductionProces);
            }
            db.SaveChanges();
            ProductionProcessGridView.DataSource = db.ProductionProcess.
                Where(ProdProc => ProdProc.EndDate >= DateTime.Now).ToList();
        }
    }
}
