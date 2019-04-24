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
            ProductionProcessGridView.DataSource = db.ProductionProces.
                Where(ProdProc => ProdProc.EndDate > DateTime.Now).ToList();
        }
    }
}
