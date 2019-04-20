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
        RoofingCompanyEntities db;
        static int idPlan, idNewPlan;
        public NewProductionPlan(RoofingCompanyEntities db, int id, int NewId)
        {
            InitializeComponent();
            this.db = db;
            idPlan = id;
            idNewPlan = NewId;
        }

        private void NewProductionPlan_Load(object sender, EventArgs e)
        {

            viewProcessEmpl.DataSource = (from PlannedProductionEmployeeDetail in db.PlannedProductionEmployeeDetails
                                          where PlannedProductionEmployeeDetail.IdProces == idPlan
                                          select PlannedProductionEmployeeDetail).ToList();
            if (idPlan > 0)
            {
                PlannedProduction Plan = db.PlannedProductions.FirstOrDefault(f => f.IdPlan == idPlan);
                if (Plan != null)
                {
                    tBoxPlanNr.Text = Convert.ToString(Plan.IdPlan);
                    cBoxMachine.Text = Convert.ToString(Plan.IdMachine);
                }
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNewPlan_Click(object sender, EventArgs e)
        {
            tBoxPlanNr.Text = Convert.ToString(idNewPlan);
            viewProcessEmpl.DataSource = null;
        }
    }
}
