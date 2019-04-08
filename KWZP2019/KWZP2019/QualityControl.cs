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
    public partial class QualityControl : Form
    {
        public QualityControl()
        {
            InitializeComponent();
        }

        public QualityControl(RoofingCompanyEntities db)
        {
            InitializeComponent();
            var record = db.Accidents.Where(acc => acc.IdAccident == 1);
            label1.Text = record.ToString();
        }
    }
}
