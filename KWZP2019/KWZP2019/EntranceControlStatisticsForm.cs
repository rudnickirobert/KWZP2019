using LiveCharts;
using LiveCharts.Wpf;
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
            dataGridViewSemiFinished.DataSource = db.ViewSemiFinishedCodes.ToList();
            dataGridViewSemiFinished.Rows[0].Selected = true;
            selectedSemiFinishedCode = dataGridViewSemiFinished.Rows[0].Cells[0].Value.ToString();
            datePickerDateFrom.Value = DateTime.Now.AddMonths(-1);
            datePickerDateTo.Value = DateTime.Now;
            ShowPieChart(this.selectedSemiFinishedCode, datePickerDateFrom.Value.Date, datePickerDateTo.Value);
            ShowHistogramThickness(this.selectedSemiFinishedCode, datePickerDateFrom.Value.Date, datePickerDateTo.Value);
            ShowHistogramWidth(this.selectedSemiFinishedCode, datePickerDateFrom.Value.Date, datePickerDateTo.Value);
            ShowHistogramWeight(this.selectedSemiFinishedCode, datePickerDateFrom.Value.Date, datePickerDateTo.Value);
        }
        // ==================================================
        private void BtnAllTime_Click(object sender, EventArgs e)
        {
            ViewMinAndMaxEntranceControlDate minAndMaxControlDate = db.ViewMinAndMaxEntranceControlDates
                    .Where(check => check.SfCode == selectedSemiFinishedCode).FirstOrDefault();

            if (minAndMaxControlDate == null)
            {
                MessageBox.Show("Brak kontroli wybranego półfabrykatu w bazie.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                datePickerDateFrom.Value = (DateTime)minAndMaxControlDate.MinControlDate;
                datePickerDateTo.Value = (DateTime)minAndMaxControlDate.MaxControlDate;
            }
        }
        // ==================================================
        private void DataGridViewSemiFinished_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridViewSemiFinished.SelectedRows[0];
            selectedSemiFinishedCode = selectedRow.Cells["Kod_półfabrykatu"].Value.ToString();
        }
        // ==================================================
        private Dictionary<decimal, decimal> Counter(string semiFinishedCode, DateTime dateFrom, DateTime dateTo, string parameter)
        {
            List<ViewEntranceControlResultsBySfCode> entranceControlResult = db.ViewEntranceControlResultsBySfCodes
                .Where(check => check.SfCode == semiFinishedCode
                && check.ControlDate >= dateFrom
                && check.ControlDate <= dateTo).ToList();
            Dictionary<decimal, decimal> result = new Dictionary<decimal, decimal>();
            switch (parameter)
            {
                case "thickness":
                    foreach (ViewEntranceControlResultsBySfCode row in entranceControlResult.OrderBy(orderBy => orderBy.RealThickness))
                    {
                        if(result.ContainsKey(row.RealThickness))
                        {
                            result[row.RealThickness] += 1;
                        }
                        else
                        {
                            result.Add(row.RealThickness, 1);
                        }
                    }
                    break;
                case "width":
                    foreach (ViewEntranceControlResultsBySfCode row in entranceControlResult.OrderBy(orderBy => orderBy.RealWidth))
                    {
                        if (result.ContainsKey(row.RealWidth))
                        {
                            result[row.RealWidth] += 1;
                        }
                        else
                        {
                            result.Add(row.RealWidth, 1);
                        }
                    }
                    break;
                case "weight":
                    foreach (ViewEntranceControlResultsBySfCode row in entranceControlResult.OrderBy(orderBy => orderBy.RealWeight))
                    {
                        if (result.ContainsKey(row.RealWeight))
                        {
                            result[row.RealWeight] += 1;
                        }
                        else
                        {
                            result.Add(row.RealWeight, 1);
                        }
                    }
                    break;
            }
            return ChangeQuantityToFrequency(result);
        }
        // ==================================================
        private Dictionary<decimal, decimal> ChangeQuantityToFrequency(Dictionary<decimal, decimal> toChange)
        {
            Dictionary<decimal, decimal> result = new Dictionary<decimal, decimal>();
            foreach (decimal key in toChange.Keys)
            {
                result.Add(key, toChange[key] / toChange.Values.Sum());
            }
            return result;
        }
        // ==================================================
        private void ShowHistogramThickness(string semiFinishedCode, DateTime dateFrom, DateTime dateTo)
        {
            Dictionary<decimal, decimal> realThickness = Counter(semiFinishedCode, dateFrom, dateTo, "thickness");
            ColumnSeries colSeries = new ColumnSeries()
            {
                DataLabels = false,
                Values = new ChartValues<decimal>(),
                LabelPoint = point => point.Y.ToString(),
                ColumnPadding = 1,
                MaxColumnWidth = 100,
                Fill = System.Windows.Media.Brushes.Blue
            };
            Axis axisX = new Axis()
            {
                Title = "Grubość",
                Separator = new Separator() { Step = 1, IsEnabled = false},
                LabelsRotation = -45,
                Foreground = System.Windows.Media.Brushes.White
            };
            axisX.Labels = new List<string>();
            foreach(decimal key in realThickness.Keys)
            {
                colSeries.Values.Add(realThickness[key]);
                axisX.Labels.Add(key.ToString());
            }
            histogramThickness.Series.Add(colSeries);
            histogramThickness.AxisX.Add(axisX);
            histogramThickness.AxisY.Add(new Axis
            {
                Title = "Prawdopodobieństwo",
                LabelFormatter = value => value.ToString(),
                Separator = new Separator(),
                MinValue = 0,
                MaxValue = (double)realThickness.Values.Max() + 0.05,
                Foreground = System.Windows.Media.Brushes.White
            });
            histogramThickness.DataTooltip.Visibility = System.Windows.Visibility.Hidden;
        }
        // ==================================================
        private void ShowHistogramWidth(string semiFinishedCode, DateTime dateFrom, DateTime dateTo)
        {
            Dictionary<decimal, decimal> realWidth = Counter(semiFinishedCode, dateFrom, dateTo, "width");
            ColumnSeries colSeries = new ColumnSeries()
            {
                DataLabels = false,
                Values = new ChartValues<decimal>(),
                LabelPoint = point => point.Y.ToString(),
                ColumnPadding = 1,
                MaxColumnWidth = 100,
                Fill = System.Windows.Media.Brushes.Blue
            };
            Axis axisX = new Axis()
            {
                Title = "Szerokość",
                Separator = new Separator() { Step = 2, IsEnabled = false },
                LabelsRotation = -45,
                Foreground = System.Windows.Media.Brushes.White
            };
            axisX.Labels = new List<string>();
            foreach (decimal key in realWidth.Keys)
            {
                colSeries.Values.Add(realWidth[key]);
                axisX.Labels.Add(key.ToString());
            }
            histogramWidth.Series.Add(colSeries);
            histogramWidth.AxisX.Add(axisX);
            histogramWidth.AxisY.Add(new Axis
            {
                Title = "Prawdopodobieństwo",
                LabelFormatter = value => value.ToString(),
                Separator = new Separator(),
                MinValue = 0,
                MaxValue = (double)realWidth.Values.Max() + 0.05,
                Foreground = System.Windows.Media.Brushes.White
            });
            histogramWidth.DataTooltip.Visibility = System.Windows.Visibility.Hidden;
        }
        // ==================================================
        private void ShowHistogramWeight(string semiFinishedCode, DateTime dateFrom, DateTime dateTo)
        {
            Dictionary<decimal, decimal> realWeight = Counter(semiFinishedCode, dateFrom, dateTo, "weight");
            ColumnSeries colSeries = new ColumnSeries()
            {
                DataLabels = false,
                Values = new ChartValues<decimal>(),
                LabelPoint = point => point.Y.ToString(),
                ColumnPadding = 1,
                MaxColumnWidth = 100,
                Fill = System.Windows.Media.Brushes.Blue
            };
            Axis axisX = new Axis()
            {
                Title = "Masa",
                Separator = new Separator() { Step = 2, IsEnabled = false },
                LabelsRotation = -45,
                Foreground = System.Windows.Media.Brushes.White
            };
            axisX.Labels = new List<string>();
            foreach (decimal key in realWeight.Keys)
            {
                colSeries.Values.Add(realWeight[key]);
                axisX.Labels.Add(key.ToString());
            }
            histogramWeight.Series.Add(colSeries);
            histogramWeight.AxisX.Add(axisX);
            histogramWeight.AxisY.Add(new Axis
            {
                Title = "Prawdopodobieństwo",
                LabelFormatter = value => value.ToString(),
                Separator = new Separator(),
                MinValue = 0,
                MaxValue = (double)realWeight.Values.Max() + 0.05,
                Foreground = System.Windows.Media.Brushes.White
            });
            histogramWeight.DataTooltip.Visibility = System.Windows.Visibility.Hidden;
        }
        // ==================================================
        private void ShowPieChart(string semiFinishedCode, DateTime dateFrom, DateTime dateTo)
        {
            int numberOfPositiveControl = db.ViewEntranceControlResultsBySfCodes
                .Where(check => check.SfCode == semiFinishedCode
                && check.ControlStatus == true
                && check.ControlDate >= dateFrom
                && check.ControlDate <= dateTo).ToList().Count();

            int numberOfNegativeControl = db.ViewEntranceControlResultsBySfCodes
                .Where(check => check.SfCode == semiFinishedCode
                && check.ControlStatus == false
                && check.ControlDate >= dateFrom
                && check.ControlDate <= dateTo).ToList().Count();

            SeriesCollection series = new SeriesCollection();
            series.Add(new PieSeries()
            {
                Title = $"Pozytywne kontrole: {numberOfPositiveControl}",
                Values = new ChartValues<int> { numberOfPositiveControl },
                DataLabels = true,
                LabelPoint = labelPoint,
                PushOut = 1,
                Fill = System.Windows.Media.Brushes.Green
            });
            series.Add(new PieSeries()
            {
                Title = $"Negatywne kontrole: {numberOfNegativeControl}",
                Values = new ChartValues<int> { numberOfNegativeControl },
                DataLabels = true,
                LabelPoint = labelPoint,
                PushOut = 1,
                Fill = System.Windows.Media.Brushes.Red
            });

            pieChartNumberOfPositiveAndNegativeControl.Series = series;
            pieChartNumberOfPositiveAndNegativeControl.HoverPushOut = 0;
            pieChartNumberOfPositiveAndNegativeControl.LegendLocation = LegendLocation.Bottom;
            pieChartNumberOfPositiveAndNegativeControl.DefaultLegend.Foreground = System.Windows.Media.Brushes.White;
            pieChartNumberOfPositiveAndNegativeControl.DataTooltip.Visibility = System.Windows.Visibility.Hidden;
        }
        // ==================================================
        Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0:P}", chartPoint.Participation);
        // ==================================================
        private void DatePickerDateFrom_ValueChanged(object sender, EventArgs e)
        {
            if (datePickerDateFrom.Value.Date >= datePickerDateTo.Value.Date)
            {
                MessageBox.Show("Data \"od\" musi być większa od daty \"do\".", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                datePickerDateFrom.Value = DateTime.Now.AddMonths(-1);
            }
        }
        // ==================================================
        private void DatePickerDateTo_ValueChanged(object sender, EventArgs e)
        {
            if (datePickerDateFrom.Value.Date >= datePickerDateTo.Value.Date)
            {
                MessageBox.Show("Data \"od\" musi być większa od daty \"do\".", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                datePickerDateTo.Value = DateTime.Now;
            }
        }
        // ==================================================
        private void BtnRefreshCharts_Click(object sender, EventArgs e)
        {
            ShowPieChart(this.selectedSemiFinishedCode, datePickerDateFrom.Value.Date, datePickerDateTo.Value);
            histogramThickness.Series.RemoveAt(0);
            histogramThickness.AxisX.RemoveAt(0);
            histogramThickness.AxisY.RemoveAt(0);
            histogramWidth.Series.RemoveAt(0);
            histogramWidth.AxisX.RemoveAt(0);
            histogramWidth.AxisY.RemoveAt(0);
            histogramWeight.Series.RemoveAt(0);
            histogramWeight.AxisX.RemoveAt(0);
            histogramWeight.AxisY.RemoveAt(0);
            ShowHistogramThickness(this.selectedSemiFinishedCode, datePickerDateFrom.Value.Date, datePickerDateTo.Value);
            ShowHistogramWidth(this.selectedSemiFinishedCode, datePickerDateFrom.Value.Date, datePickerDateTo.Value);
            ShowHistogramWeight(this.selectedSemiFinishedCode, datePickerDateFrom.Value.Date, datePickerDateTo.Value);
        }
    }
}
