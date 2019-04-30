using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace KWZP2019
{
    public partial class SalariesSummary : Form
    {
        private RoofingCompanyEntities db;
        private StartForm startForm;
        private Finances Finances;
        public SalariesSummary(RoofingCompanyEntities db, StartForm startForm, Finances Finances)
        {
            this.db = db;
            this.startForm = startForm;
            this.Finances = Finances;
            InitializeComponent();
        }
    }
}
