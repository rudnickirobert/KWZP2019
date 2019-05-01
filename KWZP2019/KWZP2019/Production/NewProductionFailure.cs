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
        int idFailure, idNewFailure;
        public NewProductionFailure(RoofingCompanyEntities db, int id, int newId)
        {
            InitializeComponent();
            this.db = db;
            idFailure = id;
            idNewFailure = newId;
        }
        private void NewProductionFailure_Load(object sender, EventArgs e)
        {
            comboBox_idproces.DataSource = db.ProductionProcesses.ToList();
            if (idFailure > 0)
            {
                Failure failure = db.Failures.First(f => f.IdFailure == idFailure);
                comboBox_idproces.Text = Convert.ToString(failure.IdFailure);
                dateTimePicker_Failure.Value = failure.FailureDate;
                textBox_description.Text = failure.Specification;
            }
            
        }
        private void button_abort_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button_save_Click(object sender, EventArgs e)
        {
            Failure failure = new Failure();
            if (failure != null)
            {
                failure.IdProces = Convert.ToInt32(comboBox_idproces.Text);
                failure.FailureDate = dateTimePicker_Failure.Value;
                failure.Specification = textBox_description.Text;
            }
            else
            {
                MessageBox.Show("Wprowadź wszystkie dane");
            }
        }


    }
}
