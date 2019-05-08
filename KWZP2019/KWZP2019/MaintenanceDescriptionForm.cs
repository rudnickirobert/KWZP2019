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
        MaintDescription maintDescription;
        int nMode = 0;


        public MaintenanceDescriptionForm(RoofingCompanyEntities db, int tnIdMaintDescription, int tnMode)
        {
            try
            {
                this.db = db;
                this.nMode = tnMode;
                InitializeComponent();
                switch (tnMode)
                {
                    case 1:
                        {

                        }
                        break;
                    case 2:
                        {
                            btnAccept.Text = "Aktualizuj";
                        }
                        break;
                    default:
                        {
                            txtShortDescription.ReadOnly = true;
                            txtDetailDescription.ReadOnly = true;
                            btnAccept.Visible = false;
                            btnAccept.Enabled = false;
                        }
                        break;
                }
                if (tnIdMaintDescription > 0)
                {
                    //using (db)
                    //{
                        this.maintDescription = db.MaintDescriptions.Where(x => x.IdMaintDesc == tnIdMaintDescription).First();
                        this.txtShortDescription.Text = maintDescription.MaintDescName;
                        this.txtDetailDescription.Text = maintDescription.MaintDescription1;
                        tnIdMaintDescription = 0;
                    //}
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
