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
        private int selectedSemiFinishedId;

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
            var semiFinishedList = db.SemiFinisheds
                .Select(semiFinished => new
                {
                    Id = semiFinished.IdSemiFinished,
                    Kod_Produktu = semiFinished.SfCode
                }).ToList();

            dataGridViewSemiFinished.DataSource = semiFinishedList;
        }

        // ==================================================

        private void BtnShowHistograms_Click(object sender, EventArgs e)
        {
            if(selectedSemiFinishedId <= 0)
            {
                MessageBox.Show("Wybierz półfabrykat.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //ShowHistograms(this.selectedSemiFinishedId, datePickerDateFrom.Value, datePickerDateTo.Value);
        }

        // ==================================================

        private void DataGridViewSemiFinished_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridViewSemiFinished.SelectedRows[0];
            selectedSemiFinishedId = (int)selectedRow.Cells["ID"].Value;
        }

        // ==================================================

        private void ShowHistograms(int idSemiFinished, DateTime dateFrom, DateTime dateTo)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo();
            processStartInfo.FileName = @"C:\Users\bartl\AppData\Local\Programs\Python\Python37-32\python.exe";

            String script = @"D:\entranceControlHistograms.py";
            processStartInfo.Arguments = $"\"{script}\" \"{idSemiFinished}\" \"{dateFrom}\" \"{dateTo}\"";

            processStartInfo.UseShellExecute = false;
            processStartInfo.CreateNoWindow = true;
            processStartInfo.RedirectStandardOutput = true;
            processStartInfo.RedirectStandardError = true;

            String errors = "";

            using (Process process = Process.Start(processStartInfo))
            {
                errors = process.StandardError.ReadToEnd();
            }

            if(errors != "")
            {
                MessageBox.Show(errors, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
