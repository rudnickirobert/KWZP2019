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
    public partial class EditTechnology : Form
    {
        private RoofingCompanyEntities db;
        private Technology technology;
        private ProductionTechnology productionTechnology;
        public EditTechnology(RoofingCompanyEntities db, Technology technology, ProductionTechnology productionTechnology)
        {
            InitializeComponent();
            this.db = db;
            this.technology = technology;
            this.productionTechnology = productionTechnology;
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            productionTechnology.Show();
            this.Close();
        }

        private void EditTechnology_Load(object sender, EventArgs e)
        {
            textBoxTechnologyName.Text = technology.TechnologyName;
            textBoxTimePerMeter.Text = technology.TimePermeter.ToString();
            textBoxSpeedFactor.Text = technology.SpeedFactor.ToString();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (textBoxTechnologyName.Text.Trim() != "")
            {
                technology.TechnologyName = textBoxTechnologyName.Text;
                textBoxTechnologyName.Text = "";
            }

            if (textBoxTimePerMeter.Text.Trim() != "")
            {
                // TimePermeter nazywa się pole w tabeli Technology
                technology.TimePermeter = int.Parse(textBoxTimePerMeter.Text);
                textBoxTimePerMeter.Text = "";
            }

            if (textBoxSpeedFactor.Text.Trim() != "")
            {
                technology.SpeedFactor = int.Parse(textBoxSpeedFactor.Text);
                textBoxSpeedFactor.Text = "";
            }

            db.SaveChanges();
            productionTechnology.refreshDataGridView();
            productionTechnology.selectRow(technology.IdTechnology);
            productionTechnology.Show();
            this.Close();
        }
    }
}
