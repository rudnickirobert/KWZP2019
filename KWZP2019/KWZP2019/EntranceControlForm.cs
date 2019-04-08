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
    public partial class EntranceControlForm : Form
    {
        RoofingCompanyEntities db;
        public EntranceControlForm(RoofingCompanyEntities db)
        {
            this.db = db;
            InitializeComponent();
        }
    }
}
