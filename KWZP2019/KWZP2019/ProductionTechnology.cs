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
            if(textBoxSpeedFactor.Text==""||textBoxTechnologyName.Text==""||textBoxTimePermeter.Text=="")
            {
                MessageBox.Show("Proszę uzupełnić wszystkie pola!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Technology technology = new Technology();
                technology.TechnologyName = textBoxTechnologyName.Text;

                bool ifTimePermeter = int.TryParse(textBoxTimePermeter.Text, out int timePermeter);
                if(ifTimePermeter)
                {
                    technology.TimePermeter = timePermeter;
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

    }
}
