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
            //tBProductCode.Text = dorobic wyswietlanie kodu produktu
        }

        private void btEditConfirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edytowano!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btEditBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditProduct_Load(object sender, EventArgs e)
        {
            cBEditSemiFinished.ValueMember = "IdSemiFinished";
            cBEditSemiFinished.DisplayMember = "SfCode";
            cBEditSemiFinished.DataSource = db.SemiFinisheds.Distinct().ToList();
            cBEditSemiFinished.Invalidate();

            cBEditTechnology.ValueMember = "IdTechnology";
            cBEditTechnology.DisplayMember = "TechnologyName";
            cBEditTechnology.DataSource = db.Technologies.Distinct().ToList();
            cBEditTechnology.Invalidate();
        }
    }
}
