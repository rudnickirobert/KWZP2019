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
    public partial class OutMeasures : Form
    {
        RoofingCompanyEntities db;
        StartForm startForm;
        QualityControl qualityControlForm;
        OutControlForm outControlForm;
        int procesNumber;

        public OutMeasures(RoofingCompanyEntities db, StartForm startForm, QualityControl qualityControlForm, OutControlForm outControlForm, int procesNumber)
        {
            this.db = db;
            this.startForm = startForm;
            this.qualityControlForm = qualityControlForm;
            this.outControlForm = outControlForm;
            this.procesNumber = procesNumber;
            InitializeComponent();
            ComponentsDataInitialize();
        }

        private void ComponentsDataInitialize()
        {
            txtbProductCode.Text = db.vTechnicalProductDataPerProcesses.First(e => e.IdProcess == procesNumber).ProductCode.ToString();
            txtbLenghtNominal.Text = db.vTechnicalProductDataPerProcesses.First(e => e.IdProcess == procesNumber).Lenght.ToString();
            txtbWidthNominal.Text = db.vTechnicalProductDataPerProcesses.First(e => e.IdProcess == procesNumber).Width.ToString();
        }


    }
}
