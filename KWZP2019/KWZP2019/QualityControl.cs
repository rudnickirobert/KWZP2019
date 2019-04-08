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
        RoofingCompanyEntities _db;

        public QualityControl(RoofingCompanyEntities db)
        {
            _db = db;
            InitializeComponent();
            var record = _db.Accidents.Where(acc => acc.IdAccident == 1);
            label1.Text = record.ToString();
        }
    }
}
