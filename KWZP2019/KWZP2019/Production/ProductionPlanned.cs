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
        int id;
        public ProductionPlanned(RoofingCompanyEntities db)
        {
            InitializeComponent();
            this.db = db;
        }
        private void ProductionPlanned_Load(object sender, EventArgs e)
        {          
            PlannedProductionGridView.DataSource = db.PlannedProductions.ToList();
            PlannedProductionGridView.Columns["dataGridViewTextBoxColumnInProduction"].DefaultCellStyle.FormatProvider = new BoolFormatter();
            PlannedProductionGridView.Columns["dataGridViewTextBoxColumnInProduction"].DefaultCellStyle.Format = "TakNie";
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
            if (isTxtBoxEmpty(txtBoxPlanSearch))
            {
                PlannedProductionGridView.DataSource = db.PlannedProductions.ToList();
            }
            else
            {
                if (int.TryParse(txtBoxPlanSearch.Text.Trim(), out int planNumber))
                {
                    planNumber = Convert.ToInt32(txtBoxPlanSearch.Text.Trim());
                    PlannedProductionGridView.DataSource = (from PlannedProduction in db.PlannedProductions
                                                            where PlannedProduction.IdPlan == planNumber
                                                            select PlannedProduction).ToList();
                }
                else
                {
                    MessageBox.Show("Proszę podać poprawny numer planu!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void PlannedProductionGridView_SelectionChanged(object sender, EventArgs e)
        {
            id = Convert.ToInt32(this.PlannedProductionGridView.CurrentRow.Cells[0].Value);
            PlannedProduction selectedPlan = db.PlannedProductions.First(f => f.IdPlan == id);
            Machine planMachine = db.Machines.First(f => f.IdMachine == selectedPlan.IdMachine);
            OrderDetail planDetail = db.OrderDetails.First(f => f.IdDetail == selectedPlan.IdDetail);
            Product planProduct = db.Products.First(f => f.IdProduct == planDetail.IdProduct);
            string infoAboutOrderProduct = Convert.ToString(planProduct.ProductCode);
            string infoAboutOrderProductQuantity= Convert.ToString(planDetail.Quantity);
            string infoAboutMachine = Convert.ToString(planMachine.MachineName) + " " + Convert.ToString(planMachine.CatalogMachineNr);
            labelMachine.Text = infoAboutMachine;
            labelProductCode.Text = infoAboutOrderProduct;
            labelProductQuantity.Text = infoAboutOrderProductQuantity;
        }
        private void btnRefreshPlanList_Click(object sender, EventArgs e)
        {
            PlannedProductionGridView.DataSource = db.PlannedProductions.ToList();
        }
        private void btnAddPlan_Click(object sender, EventArgs e)
        {
            NewProductionPlan NewProductionPlanForm = new NewProductionPlan(db, id);
            NewProductionPlanForm.Show();
        }
        private void PlannedProductionGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.CellStyle.FormatProvider is ICustomFormatter)
            {
                e.Value = (e.CellStyle.FormatProvider.GetFormat(typeof(ICustomFormatter)) as ICustomFormatter).Format(e.CellStyle.Format, e.Value, e.CellStyle.FormatProvider);
                e.FormattingApplied = true;
            }
        }
    }
}
