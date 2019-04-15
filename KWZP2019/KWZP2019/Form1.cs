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
    public partial class StartForm : Form
    {
      private RoofingCompanyEntities db;

        public StartForm()
        {
            InitializeComponent();
            db = new RoofingCompanyEntities();

        }

        private void btnProduction_Click(object sender, EventArgs e)
        {
            Production productionForm = new Production(db);
            productionForm.Show();
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            MaintenanceManagement maintenanceManagement = new MaintenanceManagement(db);
            maintenanceManagement.Show();
        }
        
    }
}
