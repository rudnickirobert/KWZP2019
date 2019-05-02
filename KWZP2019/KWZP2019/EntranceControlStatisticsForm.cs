using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private string selectedSemiFinishedCode;

        // ==================================================

        public EntranceControlStatisticsForm(RoofingCompanyEntities db, StartForm startForm, EntranceControlForm entranceControlForm)
        {
            InitializeComponent();
            this.db = db;
            this.startForm = startForm;
            this.entranceControlForm = entranceControlForm;
        }

        // ==================================================

        private void BtnReturnMain_Click(object sender, EventArgs e)
        {
            this.startForm.Show();
            this.entranceControlForm.Close();
            this.Close();
        }

        // ==================================================

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.entranceControlForm.Show();
            this.Close();
        }

        // ==================================================

        private void EntranceControlStatisticsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.entranceControlForm.Show();
        }

        // ==================================================

        private void EntranceControlStatisticsForm_Load(object sender, EventArgs e)
        {
            datePickerDateFrom.Value = DateTime.Now.AddMonths(-1);
            datePickerDateTo.Value = DateTime.Now;

            List<string> semiFinishedList = new List<string>();

            List<SemiFinished> semiFinisheds = db.SemiFinisheds.ToList();

            foreach(SemiFinished semiFinished in semiFinisheds)
            {
                semiFinishedList.Add(semiFinished.SfCode);
            }
            
            dataGridViewSemiFinished.DataSource = semiFinishedList;
            dataGridViewSemiFinished.Columns[0].HeaderText = "Kod półfabrykatu";
        }

        // ==================================================

        private void BtnAllTime_Click(object sender, EventArgs e)
        {
            if(selectedSemiFinishedCode == null)
            {
                MessageBox.Show("Wybierz półfabrykat.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ViewMinAndMaxEntranceControlDate minAndMaxControlDate = db.ViewMinAndMaxEntranceControlDates
                    .Where(check => check.SfCode == selectedSemiFinishedCode).FirstOrDefault();

                if(minAndMaxControlDate == null)
                {
                    MessageBox.Show("Brak kontroli wybranego półfabrykatu w bazie.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    datePickerDateFrom.Value = (DateTime)minAndMaxControlDate.MinControlDate;
                    datePickerDateTo.Value = (DateTime)minAndMaxControlDate.MaxControlDate;
                }
            }
        }

        // ==================================================

        private void BtnShowHistograms_Click(object sender, EventArgs e)
        {
            if(selectedSemiFinishedCode == null)
            {
                MessageBox.Show("Wybierz półfabrykat.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(datePickerDateFrom.Value > datePickerDateTo.Value)
            {
                MessageBox.Show("Data \"od\" musi być większa od daty \"do\".", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ShowHistograms(this.selectedSemiFinishedCode, datePickerDateFrom.Value, datePickerDateTo.Value);
            }
        }

        // ==================================================

        private void BtnShowPieChart_Click(object sender, EventArgs e)
        {
            if (selectedSemiFinishedCode == null)
            {
                MessageBox.Show("Wybierz półfabrykat.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (datePickerDateFrom.Value > datePickerDateTo.Value)
            {
                MessageBox.Show("Data \"od\" musi być większa od daty \"do\".", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ShowPieChart(this.selectedSemiFinishedCode, datePickerDateFrom.Value, datePickerDateTo.Value);
            }
        }

        // ==================================================

        private void DataGridViewSemiFinished_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridViewSemiFinished.SelectedRows[0];
            selectedSemiFinishedCode = selectedRow.Cells["Kod półfabrykatu"].Value.ToString();
        }

        // ==================================================

        private void ShowHistograms(string semiFinishedCode, DateTime dateFrom, DateTime dateTo)
        {

        }

        // ==================================================

        private void ShowPieChart(string semiFinishedCode, DateTime dateFrom, DateTime dateTo)
        {

        }
    }
}
