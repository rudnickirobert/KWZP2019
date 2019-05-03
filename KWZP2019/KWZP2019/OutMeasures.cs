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
    public partial class OutMeasures : Form
    {
        private RoofingCompanyEntities db;
        private StartForm startForm;
        private QualityControl qualityControlForm;
        private OutControlForm outControlForm;
        private int succesfullMeasures = 0;
        private int totalMeasures = 1;

        public OutMeasures(RoofingCompanyEntities db, StartForm startForm, QualityControl qualityControlForm, OutControlForm outControlForm)
        {
            this.db = db;
            this.startForm = startForm;
            this.qualityControlForm = qualityControlForm;
            this.outControlForm = outControlForm;
            InitializeComponent();
            ComponentsDataInitialize();
        }

        private void ComponentsDataInitialize()
        {
            txtbProductCode.Text = db.vTechnicalProductDataPerProcesses.First(e => e.IdProcess == outControlForm.procesNumber).ProductCode.ToString();
            txtbLenghtNominal.Text = db.vTechnicalProductDataPerProcesses.First(e => e.IdProcess == outControlForm.procesNumber).Lenght.ToString();
            txtbWidthNominal.Text = db.vTechnicalProductDataPerProcesses.First(e => e.IdProcess == outControlForm.procesNumber).Width.ToString();
            foreach (vTotalNumberOfMeasuresPerProcess totalCount in db.vTotalNumberOfMeasuresPerProcesses.ToList())
            {
                if (totalCount.IdProcess == outControlForm.procesNumber) { totalMeasures = Int16.Parse(totalCount.Produced.ToString()) + 1; }
            }
            refreshMeasuresStatus();
        }

        private void refreshMeasuresStatus()
        {
            foreach (vSuccesfullyProducedPerProcess succesfullCount in db.vSuccesfullyProducedPerProcesses.ToList())
            {
                if (succesfullCount.IdProcess == outControlForm.procesNumber) { succesfullMeasures = Int16.Parse(succesfullCount.SuccesfullProduced.ToString()); }
            }
            txtbSuccesful.Text = succesfullMeasures.ToString();
            txtbMeasureNumber.Text = totalMeasures.ToString();
        }

        private void dbContextRefreshingForChangesInViews()
        { 
            db = new RoofingCompanyEntities();
        }

        private void MeasureGenereting()
        {
            int toProduce = db.vTechnicalProductDataPerProcesses.First(i => i.IdProcess == outControlForm.procesNumber).Quantity;
            
            MessageBox.Show("Uruchomiono pomiary, rozpoczeto od pomiaru " + txtbMeasureNumber.Text + " dla wybranego procesu wytwórczego.");
           while (succesfullMeasures < toProduce)
           {
                Random random = new Random();
                txtbSuccesful.Text = succesfullMeasures.ToString();
                txtbMeasureNumber.Text = totalMeasures.ToString();
                OutputProductMeasurement outputProductMeasurement = new OutputProductMeasurement();
                outputProductMeasurement.IdProcess = outControlForm.procesNumber;
                double measuredLenght = Math.Round((random.NextDouble() * Int16.Parse(txtbLenghtNominal.Text) * 0.0203 * (db.OutControls.First(e => e.IdProcess == outControlForm.procesNumber).LenghtAcceptableDeviation)) + (Int16.Parse(txtbLenghtNominal.Text) * (100.01 - (db.OutControls.First(e => e.IdProcess == outControlForm.procesNumber).LenghtAcceptableDeviation))/100), 2);
                txtbLenghtMeasure.Text = measuredLenght.ToString();
                outputProductMeasurement.MeasuredLenght = measuredLenght;
                double measuredWidth = Math.Round((random.NextDouble() * Int16.Parse(txtbWidthNominal.Text) * 0.0203 * (db.OutControls.First(e => e.IdProcess == outControlForm.procesNumber).WidthAcceptableDeviation)) + (Int16.Parse(txtbWidthNominal.Text) * (100.01 - (db.OutControls.First(e => e.IdProcess == outControlForm.procesNumber).WidthAcceptableDeviation))/ 100),2);
                outputProductMeasurement.MeasuredWidth = measuredWidth;
                outputProductMeasurement.IdMeasurement = db.OutputProductMeasurements.Max(e => e.IdMeasurement) + 1;
                txtbWidthMeasure.Text = measuredWidth.ToString();
                db.OutputProductMeasurements.Add(outputProductMeasurement);
                db.SaveChanges();
                totalMeasures++;
                dbContextRefreshingForChangesInViews();
                refreshMeasuresStatus();
                txtbLenghtMeasure.Refresh();
                txtbMeasureNumber.Refresh();
                txtbWidthMeasure.Refresh();
                txtbSuccesful.Refresh();
           }
            MessageBox.Show("Zakończono pomiary, wyprodukowano " + toProduce + " sztuk produktu zgodnych z wymaganiami oraz "  + (Int16.Parse(txtbMeasureNumber.Text) - succesfullMeasures) + " sztuk nie spełniajacych wymagań. ");
            this.Close();
        }

        private void btnSMeasures_Click(object sender, EventArgs e)
        {
            MeasureGenereting();
        }
    }
}
