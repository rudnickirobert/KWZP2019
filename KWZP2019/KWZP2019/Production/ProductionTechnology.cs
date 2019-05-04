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
    public partial class ProductionTechnology : Form
    {
        private RoofingCompanyEntities db;
        private DataGridViewRow selectedRow;
        private int selectedId;
        private Technology technology;

        public ProductionTechnology(RoofingCompanyEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void ProductionTechnology_Load(object sender, EventArgs e)
        {
            dataGVtechnology.DataSource = db.Technologies.ToList();
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
                    technology.TimePermeter = timePerMeter;
                }

                bool ifSpeedFactor = int.TryParse(textBoxSpeedFactor.Text, out int speedFactor);
                if (ifSpeedFactor)
                {
                    technology.SpeedFactor = speedFactor;
                }

                db.Technologies.Add(technology);
                db.SaveChanges();
                dataGVtechnology.DataSource = db.Technologies.ToList();
            }
        }

        //===========================================================

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void dataGVtechnology_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedRow = dataGVtechnology.Rows[dataGVtechnology.SelectedCells[0].RowIndex];
            lblSelectedTechnology.Text = $"Wybrana technologia {selectedRow.Cells["IdTechnology"].Value.ToString()}";
            lblTechnologyNameFrom.Text = $"{ selectedRow.Cells["TechnologyName"].Value} zmień na";
            // TimePermeter nazywa się pole w tabeli Technology
            lblTimePerMeterFrom.Text = $"{selectedRow.Cells["TimePermeter"].Value} zmień na";
            lblSpeedFactorFrom.Text = $"{selectedRow.Cells["SpeedFactor"].Value} zmień na";
            selectedId = (int)selectedRow.Cells["IdTechnology"].Value;
            technology = db.Technologies.Where(t => t.IdTechnology == selectedId).First();
        }
        //===========================================================
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (textBoxTechnologyNameTo.Text.Trim() != "")
            {
                technology.TechnologyName = textBoxTechnologyNameTo.Text;
                textBoxTechnologyNameTo.Text = "";
            }

            if (textBoxTimePerMeterTo.Text.Trim() != "")
            {
                // TimePermeter nazywa się pole w tabeli Technology
                technology.TimePermeter = int.Parse(textBoxTimePerMeterTo.Text);
                textBoxTimePerMeterTo.Text = "";
            }

            if (textBoxSpeedFactorTo.Text.Trim() != "")
            {
                technology.SpeedFactor = int.Parse(textBoxSpeedFactorTo.Text);
                textBoxSpeedFactorTo.Text = "";
            }

            db.SaveChanges();
            dataGVtechnology.DataSource = db.Technologies.ToList();
            lblSelectedTechnology.Text = "Wybrana technologia";
            lblTechnologyNameFrom.Text = "";
            lblTimePerMeterFrom.Text = "";
            lblSpeedFactorFrom.Text = "";
        }

        //===========================================================

        private void btnDelete_Click(object sender, EventArgs e)
        {
            db.Technologies.Remove(technology);
            db.SaveChanges();
            dataGVtechnology.DataSource = db.Technologies.ToList();
            lblSelectedTechnology.Text = "Wybrana technologia";
            lblTechnologyNameFrom.Text = "";
            lblTimePerMeterFrom.Text = "";
            lblSpeedFactorFrom.Text = "";
        }
    }
}
