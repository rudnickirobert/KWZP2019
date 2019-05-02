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
            datePickerDateFrom.Value = DateTime.Now.AddMonths(-1);
            datePickerDateTo.Value = DateTime.Now;

            List<string> semiFinishedList = new List<string>();

            List<SemiFinished> semiFinisheds = db.SemiFinisheds.ToList();

            foreach(SemiFinished semiFinished in semiFinisheds)
            {
                semiFinishedList.Add(semiFinished.SfCode);
            }

            dataGridViewSemiFinished.DataSource = semiFinishedList;
        }

        // ==================================================

        private void BtnAllTime_Click(object sender, EventArgs e)
        {
            if(selectedSemiFinishedId <= 0)
            {
                MessageBox.Show("Wybierz półfabrykat.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var controlDates = db.EntranceControls
                    .Join(db.SfOrderDetails,
                    entranceControl => entranceControl.IdSfDetail,
                    sfOrderDetail => sfOrderDetail.IdSfDetail,
                    (entranceControl, sfOrderDetail) => new
                    {
                        entranceControl.ControlDate,
                        sfOrderDetail.IdSemiFinished
                    })
                    .Join(db.SemiFinisheds,
                    controlJoinDetail => controlJoinDetail.IdSemiFinished,
                    semiFinished => semiFinished.IdSemiFinished,
                    (controlJoinDetail, semiFinished) => new
                    {
                        Data_Kontroli = controlJoinDetail.ControlDate,
                        controlJoinDetail.IdSemiFinished
                    })
                    .Where(check =>
                    check.IdSemiFinished == selectedSemiFinishedId)
                    .Select(select =>
                    select.Data_Kontroli)
                    .ToList();

                if(controlDates.Count == 0)
                {
                    MessageBox.Show("Brak kontroli wybranego półfabrykatu w bazie.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if(controlDates.Count == 1)
                {
                    datePickerDateFrom.Value = controlDates[0];
                    datePickerDateTo.Value = controlDates[0];
                }
                else
                {
                    datePickerDateFrom.Value = controlDates.Min();
                    datePickerDateTo.Value = controlDates.Max();
                }
                
            }
        }

        // ==================================================

        private void BtnShowHistograms_Click(object sender, EventArgs e)
        {
            if(selectedSemiFinishedId <= 0)
            {
                MessageBox.Show("Wybierz półfabrykat.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(datePickerDateFrom.Value > datePickerDateTo.Value)
            {
                MessageBox.Show("Data \"od\" musi być większa od daty \"do\".", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ShowHistograms(this.selectedSemiFinishedId, datePickerDateFrom.Value, datePickerDateTo.Value);
            }
        }

        // ==================================================

        private void BtnShowPieChart_Click(object sender, EventArgs e)
        {
            if (selectedSemiFinishedId <= 0)
            {
                MessageBox.Show("Wybierz półfabrykat.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (datePickerDateFrom.Value > datePickerDateTo.Value)
            {
                MessageBox.Show("Data \"od\" musi być większa od daty \"do\".", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ShowPieChart(this.selectedSemiFinishedId, datePickerDateFrom.Value, datePickerDateTo.Value);
            }
        }

        // ==================================================

        private void DataGridViewSemiFinished_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridViewSemiFinished.SelectedRows[0];
            selectedSemiFinishedId = (int)selectedRow.Cells["Id"].Value;
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

        // ==================================================

        private void ShowPieChart(int idSemiFinished, DateTime dateFrom, DateTime dateTo)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo();
            processStartInfo.FileName = @"C:\Users\bartl\AppData\Local\Programs\Python\Python37-32\python.exe";

            String script = @"D:\entranceControlPieChart.py";
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

            if (errors != "")
            {
                MessageBox.Show(errors, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
