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
    public partial class EntranceControlStatisticsForm : Form
    {
        private RoofingCompanyEntities db;
        private StartForm startForm;
        private EntranceControlForm entranceControlForm;

        public EntranceControlStatisticsForm(RoofingCompanyEntities db, StartForm startForm, EntranceControlForm entranceControlForm)
        {
            InitializeComponent();
            this.db = db;
            this.startForm = startForm;
            this.entranceControlForm = entranceControlForm;
        }

        private void BtnReturnMain_Click(object sender, EventArgs e)
        {
            this.startForm.Show();
            this.entranceControlForm.Close();
            this.Close();
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.entranceControlForm.Show();
            this.Close();
        }

        private void EntranceControlStatisticsForm_Load(object sender, EventArgs e)
        {
            var semiFinishedList = db.SemiFinisheds
                .Select(semiFinished => new
                {
                    Id = semiFinished.IdSemiFinished,
                    Kod_Produktu = semiFinished.SfCode
                }).ToList();

            dataGridViewSemiFinished.DataSource = semiFinishedList;
        }
    }
}
