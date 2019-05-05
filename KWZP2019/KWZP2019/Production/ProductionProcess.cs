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
        private StartForm startForm;
        public ProductionProcess(RoofingCompanyEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void ProductionProcess_Load(object sender, EventArgs e)
        {
            dTPickerProductionActualFilterUpper.Value = DateTime.Today;
            dTPickerProductionActualFilterLower.Value = DateTime.Today.AddDays(-30);

            List<PlannedProduction> plansAddedToProduction = db.PlannedProductions.
               Where(plannedProductionPlan => !db.ProductionProcesses.
               Select(productionProcessPlan => productionProcessPlan.IdPlan).
               Contains(plannedProductionPlan.IdPlan) && plannedProductionPlan.Inproduction.Value).ToList();

            foreach (PlannedProduction plannedProduction in plansAddedToProduction)
            {
                ProductionProcess newProductionProces = new ProductionProcess();
                newProductionProces.IdPlan = plannedProduction.IdPlan;
                newProductionProces.StartDate = plannedProduction.PlannedStartd;
                newProductionProces.EndDate = plannedProduction.PlannedEndd;
                db.ProductionProcesses.Add(newProductionProces);
            }

            List<PlannedProduction> plansToUpdate = db.PlannedProductions.
              Where(plannedProductionPlanToUpdate => db.ProductionProcesses.
              Select(productionProcessPlanToUpdate => productionProcessPlanToUpdate.IdPlan).
              Contains(plannedProductionPlanToUpdate.IdPlan) && plannedProductionPlanToUpdate.Inproduction.Value).ToList();

            foreach (PlannedProduction plannedProductionToUpdate in plansToUpdate)
            {
                ProductionProcess updateProcess = db.ProductionProcesses.Find(plannedProductionToUpdate.IdPlan);
                updateProcess.StartDate = plannedProductionToUpdate.PlannedStartd;
                updateProcess.EndDate = plannedProductionToUpdate.PlannedEndd;
            }
            db.SaveChanges();
            ProductionProcessGridView.DataSource = db.vProductionProcessFullDatas.
                Where(ProdProc => ProdProc.EndDate >= DateTime.Now).ToList();
        }

        private void btnProductionActualFilter_Click(object sender, EventArgs e)
        {
            if (radioBtnActualProductionFilterEnd.Checked)
            {
                if (dTPickerProductionActualFilterLower.Value < dTPickerProductionActualFilterUpper.Value)
                {
                    ProductionProcessGridView.DataSource = db.vProductionProcessFullDatas.
                        Where(ProdProc => ProdProc.EndDate >= DateTime.Now && ProdProc.EndDate >= dTPickerProductionActualFilterLower.Value && ProdProc.EndDate <= dTPickerProductionActualFilterUpper.Value).ToList();
                }
                else
                {
                    MessageBox.Show("Błędnie wybrane daty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (dTPickerProductionActualFilterLower.Value < dTPickerProductionActualFilterUpper.Value)
                {
                    ProductionProcessGridView.DataSource = db.vProductionProcessFullDatas.
                        Where(ProdProc => ProdProc.EndDate >= DateTime.Now && ProdProc.StartDate >= dTPickerProductionActualFilterLower.Value && ProdProc.StartDate <= dTPickerProductionActualFilterUpper.Value).ToList();
                }
                else
                {
                    MessageBox.Show("Błędnie wybrane daty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnProductionActualResetFilter_Click(object sender, EventArgs e)
        {
            ProductionProcessGridView.DataSource = db.vProductionProcessFullDatas.
                Where(ProdProc => ProdProc.EndDate >= DateTime.Now).ToList();
        }

        private void btnActualProductionBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
