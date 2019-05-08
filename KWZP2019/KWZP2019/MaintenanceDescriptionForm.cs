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
    public partial class MaintenanceDescriptionForm : Form
    {
        RoofingCompanyEntities db;
        MaintenanceDescription maintenanceDescription;

        public MaintenanceDescriptionForm(RoofingCompanyEntities db, int tIdMaintDescription)
        {
            this.db = db;
            InitializeComponent();
            txtShortDescription.ReadOnly = true;
            txtDetailDescription.ReadOnly = true;
            try
            {
                if (tIdMaintDescription > 0)
                {
                    this.maintenanceDescription = db.MaintenanceDescriptions.Where(maintenanceDescription => maintenanceDescription.IdMaintDesc == tIdMaintDescription).First();
                    this.txtShortDescription.Text = maintenanceDescription.DescriptionShort;
                    this.txtDetailDescription.Text = maintenanceDescription.DescriptionLong;
                    tIdMaintDescription = 0;
                }
            }                     
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
}

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
