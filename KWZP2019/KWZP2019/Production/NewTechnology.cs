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
    public partial class NewTechnology : Form
    {
        private RoofingCompanyEntities db;
        private ProductionTechnology productionTechnology;
        public NewTechnology(RoofingCompanyEntities db, ProductionTechnology productionTechnology)
        {
            InitializeComponent();
            this.db = db;
            this.productionTechnology = productionTechnology;
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            productionTechnology.Show();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textBoxSpeedFactor.Text == "" || textBoxTechnologyName.Text == "" || textBoxTimePerMeter.Text == "")
            {
                MessageBox.Show("Proszę uzupełnić wszystkie pola!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Technology technology = new Technology();
                technology.TechnologyName = textBoxTechnologyName.Text;

                bool ifTimePerMeter = int.TryParse(textBoxTimePerMeter.Text, out int timePerMeter);
                if (ifTimePerMeter)
                {
                    // TimePermeter nazywa się pole w tabeli Technology
                    if (timePerMeter > 0)
                    {
                        technology.TimePermeter = timePerMeter;
                    }
                    else
                    {
                        textBoxTimePerMeter.Text = "Wpisz liczbę > 0";
                    }
                }
                else
                {
                    textBoxTimePerMeter.Text = "Wpisz liczbę całkowitą";
                }

                bool ifSpeedFactor = int.TryParse(textBoxSpeedFactor.Text, out int speedFactor);
                if (ifSpeedFactor)
                {
                    if (speedFactor > 0)
                    {
                        technology.SpeedFactor = speedFactor;
                    }
                    else
                    {
                        textBoxSpeedFactor.Text = "Wpisz liczbę > 0";
                    }
                }
                else
                {
                    textBoxSpeedFactor.Text = "Wpisz liczbę całkowitą";
                }

                if(technology.TimePermeter > 0 && technology.SpeedFactor > 0)
                {
                    db.Technologies.Add(technology);
                    db.SaveChanges();
                    productionTechnology.refreshDataGridView();
                    productionTechnology.selectRow(technology.IdTechnology);
                    productionTechnology.Show();
                    this.Close();
                }
            }
        }
    }
}
