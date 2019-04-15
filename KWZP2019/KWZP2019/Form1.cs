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


        private void btnQA_Click(object sender, EventArgs e)
        {
            QualityControl qualityControlForm = new QualityControl(db, this);
            qualityControlForm.Show();
            this.Hide();
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            MaintenanceManagement maintenanceManagement = new MaintenanceManagement(db);
            maintenanceManagement.Show();
        }
    }
}
