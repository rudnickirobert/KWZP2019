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

        public OutMeasures(RoofingCompanyEntities db, StartForm startForm, QualityControl qualityControlForm, OutControlForm outControlForm)
        {
            this.db = db;
            this.startForm = startForm;
            this.qualityControlForm = qualityControlForm;
            this.outControlForm = outControlForm;
            InitializeComponent();
        }
    
     
    }
}
