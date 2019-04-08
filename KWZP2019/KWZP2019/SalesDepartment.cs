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
    public partial class SalesDepartment : Form
    {
        RoofingCompanyEntities db;

        public SalesDepartment(RoofingCompanyEntities dbt)
        {
            this.db = dbt;
            InitializeComponent();
        }

        private void SalesDepartment_Load(object sender, EventArgs e)
        {

        }
    }
}
