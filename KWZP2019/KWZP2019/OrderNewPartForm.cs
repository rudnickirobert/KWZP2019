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
    public partial class OrderNewPartForm : Form
    {
        private RoofingCompanyEntities db;
        private SalesDepartmentForm salesForm;
        public OrderNewPartForm(RoofingCompanyEntities db, SalesDepartmentForm salesForm)
        {
            InitializeComponent();
            this.db = db;
            this.salesForm = salesForm;
        }
    }
}
