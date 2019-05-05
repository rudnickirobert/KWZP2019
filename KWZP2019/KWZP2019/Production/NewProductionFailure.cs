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
    public partial class NewProductionFailure : Form
    {
        RoofingCompanyEntities db;
        public NewProductionFailure(RoofingCompanyEntities db)
        {
            InitializeComponent();
            this.db = db;
        }
        private void NewProductionFailure_Load(object sender, EventArgs e)
        {
            cBidproces.ValueMember = "IdProces";
            cBidproces.DisplayMember = "IdProces";
            cBidproces.DataSource = db.ProductionProcesses.Distinct().ToList();
            cBidproces.Invalidate();
        }
        private void button_abort_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button_save_Click(object sender, EventArgs e)
        {
            Failure failure = new Failure();
            failure.IdProces = Convert.ToInt32(cBidproces.SelectedValue);
            failure.FailureDate = dateTimePicker_Failure.Value;
            failure.Specification = tBdescription.Text;
            db.Failures.Add(failure);
            db.SaveChanges();
            MessageBox.Show("Dodano awarie!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
