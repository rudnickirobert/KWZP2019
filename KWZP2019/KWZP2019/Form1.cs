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
    public partial class startForm : Form
    {
      private RoofingCompanyEntities db;

        public startForm()
        {
            InitializeComponent();
            db = new RoofingCompanyEntities();
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            MaintenanceManagment maintenance_managment = new MaintenanceManagment(db);
            maintenance_managment.Show();
        }
    }
}
