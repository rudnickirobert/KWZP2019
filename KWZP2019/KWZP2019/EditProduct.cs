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
    public partial class EditProduct : Form
    {
        RoofingCompanyEntities db;
        int IDProd;
        public EditProduct(RoofingCompanyEntities db , int IDprod)
        {
            this.IDProd = IDprod;
            this.db = db;
            InitializeComponent();
            tBNumberProd.Text = Convert.ToString(IDProd);
        }
    }
}
