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
    public partial class ProductionFailures : Form
    {
        RoofingCompanyEntities db;
        int id, newId;
        public ProductionFailures(RoofingCompanyEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {

        }

        private void ProductionFailures_Load(object sender, EventArgs e)
        {
            dgv_failures.DataSource = db.Failures.ToList();
            newId = dgv_failures.RowCount + 1;
        }
    }
}
