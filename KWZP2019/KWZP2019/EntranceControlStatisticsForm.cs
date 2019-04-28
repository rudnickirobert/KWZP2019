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
        private int selectedSemiFinishedId;

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

        private void DataGridViewSemiFinished_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridViewSemiFinished.SelectedRows[0];
            selectedSemiFinishedId = (int)selectedRow.Cells["ID"].Value;
        }
    }
}
