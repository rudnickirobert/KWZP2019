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
    public partial class ProductionHistory : Form
    {
        RoofingCompanyEntities db;
        public ProductionHistory(RoofingCompanyEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void ProductionHistory_Load(object sender, EventArgs e)
        {
            dTPickerProductionHistoryFilterUpper.Value = DateTime.Today;
            dTPickerProductionHistoryFilterLower.Value = DateTime.Today.AddDays(-30);

            productionHistoryGridView.DataSource = db.vProductionProcessFullDatas.
                Where(ProdHist => ProdHist.EndDate < DateTime.Now).ToList();
        }

        private void btnProdutionHistoryFilter_Click(object sender, EventArgs e)
        {
            if (radioBtnProductionHistoryFilterEnd.Checked)
            {
                if (dTPickerProductionHistoryFilterLower.Value < dTPickerProductionHistoryFilterUpper.Value)
                {
                    productionHistoryGridView.DataSource = db.vProductionProcessFullDatas.
                    Where(ProdHist => ProdHist.EndDate < DateTime.Now && ProdHist.EndDate >= dTPickerProductionHistoryFilterLower.Value && ProdHist.EndDate <= dTPickerProductionHistoryFilterUpper.Value).ToList();
                }
                else
                {
                    MessageBox.Show("Błędnie wybrane daty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (dTPickerProductionHistoryFilterLower.Value < dTPickerProductionHistoryFilterUpper.Value)
                {
                    productionHistoryGridView.DataSource = db.vProductionProcessFullDatas.
                        Where(ProdProc => ProdProc.EndDate < DateTime.Now && ProdProc.StartDate >= dTPickerProductionHistoryFilterLower.Value && ProdProc.StartDate <= dTPickerProductionHistoryFilterUpper.Value).ToList();
                }
                else
                {
                    MessageBox.Show("Błędnie wybrane daty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnProductionHistoryFilterReset_Click(object sender, EventArgs e)
        {
                productionHistoryGridView.DataSource = db.vProductionProcessFullDatas.
                Where(ProdHist => ProdHist.EndDate < DateTime.Now).ToList();
        }

        private void btnHistoryProductionBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
