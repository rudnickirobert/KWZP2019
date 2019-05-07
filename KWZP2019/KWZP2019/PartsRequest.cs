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
    public partial class PartsRequest : Form
    {
        RoofingCompanyEntities db;
        PartsForm partsManagmentForm;
        int numberRow;
        private bool selectedRow;
        private bool showHistory;
        private bool acceptAvailable;

        public PartsRequest(RoofingCompanyEntities db, PartsForm partsManagmentForm)
        {
            this.db = db;
            this.partsManagmentForm = partsManagmentForm;
            InitializeComponent();
        }

        // ==========================================

        private void btnReturnPartsForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ==========================================

        private void PartsRequest_Load(object sender, EventArgs e)
        {
            // DateTimePicker Date From
            dpsRequestDateFrom.Value = DateTime.Now.Date;
            dpsRequestDateFrom.Format = DateTimePickerFormat.Short;

            // DateTimePicker Date TO
            dpsRequestDateTo.Value = DateTime.Now.Date;
            dpsRequestDateTo.Format = DateTimePickerFormat.Short;

            ReloadData();
            selectedRow = false;
            showHistory = false;
            acceptAvailable = false;

            tbRequestSearch.Text = "";
        }

        // ==========================================

        public void ReloadData()
        {
            if (tbRequestSearch.Text != "")
            {
                tbRequestSearch.Text = "";
            }

            if (showHistory)
            {
                dataPartRequestView.DataSource = db.vPartsRequestViews
                    .Where(request => request.StatusPart >= 2).ToList();
            }
            
            else
            {
                dataPartRequestView.DataSource = db.vPartsRequestViews
                    .Where(request => request.StatusPart < 2).ToList();
            }
        }
        // ==========================================

        private void pbDateBefore_Click(object sender, EventArgs e)
        {
            if(showHistory)
            {
                dataPartRequestView.DataSource = db.vPartsRequestViews
                      .Where(request => request.RequestDate < dpsRequestDateFrom.Value)
                      .Where(request => request.StatusPart >= 2).OrderBy(request => request.RequestDate).ToList();
            }

            else
            {
                dataPartRequestView.DataSource = db.vPartsRequestViews
                      .Where(request => request.RequestDate < dpsRequestDateFrom.Value)
                      .Where(request => request.StatusPart < 2).OrderBy(request => request.RequestDate).ToList();
            }

            if (dataPartRequestView.RowCount == 0)
            {
                MessageBox.Show("Nie znaleziono wyników przed zadaną datą", "Wynik wyszukiwania",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                ReloadData();
            }
        }

        // ==========================================

        private void pbDateRange_Click(object sender, EventArgs e)
        {
            if (showHistory)
            {
                dataPartRequestView.DataSource = db.vPartsRequestViews
                      .Where(request => request.RequestDate >= dpsRequestDateFrom.Value &&
                      request.RequestDate <= dpsRequestDateTo.Value).Where(request => request.StatusPart >= 2)
                      .OrderBy(request => request.RequestDate).ToList();
            }

            else
            {
                dataPartRequestView.DataSource = db.vPartsRequestViews
                      .Where(request => request.RequestDate >= dpsRequestDateFrom.Value &&
                      request.RequestDate <= dpsRequestDateTo.Value).Where(request => request.StatusPart < 2)
                      .OrderBy(request => request.RequestDate).ToList();
            }

            if (dataPartRequestView.RowCount == 0)
            {
                 MessageBox.Show("Nie znaleziono wyników w podanym zakresie dat", "Wynik wyszukiwania",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                ReloadData();
            }
        }

        // ==========================================

        private void pbDateEqual_Click(object sender, EventArgs e)
        {
            if (showHistory)
            {
                dataPartRequestView.DataSource = db.vPartsRequestViews
                      .Where(request => request.RequestDate.Day == dpsRequestDateFrom.Value.Day &&
                      request.RequestDate.Month == dpsRequestDateFrom.Value.Month &&
                      request.RequestDate.Year == dpsRequestDateFrom.Value.Year)
                      .Where(request => request.StatusPart >= 2).OrderBy(request => request.RequestDate).ToList();
            }
            
            else
            {
                dataPartRequestView.DataSource = db.vPartsRequestViews
                      .Where(request => request.RequestDate.Day == dpsRequestDateFrom.Value.Day &&
                      request.RequestDate.Month == dpsRequestDateFrom.Value.Month &&
                      request.RequestDate.Year == dpsRequestDateFrom.Value.Year)
                      .Where(request => request.StatusPart < 2).OrderBy(request => request.RequestDate).ToList();
            }

            if (dataPartRequestView.RowCount == 0)
            {
                MessageBox.Show("Nie znaleziono wyników dla podanej daty", "Wynik wyszukiwania",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                ReloadData();
            }
        }

        // ==========================================

        private void pbDateAfter_Click(object sender, EventArgs e)
        {
            DateTime afterDate = dpsRequestDateFrom.Value.AddDays(1);

            if (showHistory)
            {
                dataPartRequestView.DataSource = db.vPartsRequestViews
                      .Where(request => request.RequestDate > afterDate)
                      .Where(request => request.StatusPart >= 2).OrderBy(request => request.RequestDate).ToList();
            }

            else
            {
                dataPartRequestView.DataSource = db.vPartsRequestViews
                      .Where(request => request.RequestDate > afterDate)
                      .Where(request => request.StatusPart < 2).OrderBy(request => request.RequestDate).ToList();
            }

            if (dataPartRequestView.RowCount == 0)
            {
                MessageBox.Show("Nie znaleziono wyników po zadanej dacie", "Wynik wyszukiwania",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                ReloadData();
            }
        }

        // ==========================================

        private void pbDateAll_Click(object sender, EventArgs e)
        {
            ReloadData();
        }

        // ==========================================

        private void dpsRequestDateFrom_ValueChanged(object sender, EventArgs e)
        {
            if (dpsRequestDateFrom.Value > dpsRequestDateTo.Value)
            {
                dpsRequestDateFrom.Value = dpsRequestDateTo.Value;
                MessageBox.Show("Podana data musi być mniejsza od 'DATY DO'", "Ostrzeżenie",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ==========================================

        private void dpsRequestDateTo_ValueChanged(object sender, EventArgs e)
        {
            if (dpsRequestDateFrom.Value > dpsRequestDateTo.Value)
            {
                dpsRequestDateTo.Value = dpsRequestDateFrom.Value.Date;
                MessageBox.Show("Podana data musi być większa od 'DATY OD'", "Ostrzeżenie",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ==========================================

        private void btnRequestPart_Search_Click(object sender, EventArgs e)
        {
            if (tbRequestSearch.Text == "")
            {
                MessageBox.Show("Pole wyszukiwania nie może być puste!", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                if(showHistory)
                {
                    dataPartRequestView.DataSource = db.vPartsRequestViews
                    .Where(request => request.PartName.Contains(tbRequestSearch.Text))
                    .Where(request => request.StatusPart >= 2).ToList();
                }

                else
                {
                    dataPartRequestView.DataSource = db.vPartsRequestViews
                    .Where(request => request.PartName.Contains(tbRequestSearch.Text))
                    .Where(request => request.StatusPart < 2).ToList();
                }

                if (dataPartRequestView.RowCount == 0)
                {
                    MessageBox.Show("Nie znaleziono pasujących wyników", "Wynik wyszukiwania",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    ReloadData();
                }
            }
        }

        // ==========================================

        private void btnRequestPart_History_Click(object sender, EventArgs e)
        {
            if(!showHistory)
            {
                btnRequestPart_Accept.Enabled = false;
                btnRequestPart_Add.Enabled = false;
                btnRequestPart_Delete.Enabled = false;
                showHistory = true;
                btnRequestPart_History.Text = "Aktualne zapotrzebowania";

                ReloadData();

                if (dataPartRequestView.RowCount == 0)
                {
                    MessageBox.Show("Historia jest pusta", "Historia",
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            else
            {
                btnRequestPart_Accept.Enabled = true;
                btnRequestPart_Add.Enabled = true;
                btnRequestPart_Delete.Enabled = true;
                showHistory = false;
                btnRequestPart_History.Text = "Historia";

                ReloadData();

            }

        }

        // ==========================================

        private void btnRequestPart_Add_Click(object sender, EventArgs e)
        {
            PartsRequest_Add partsRequestAddForm = new PartsRequest_Add(db, this);
            partsRequestAddForm.ShowDialog();
        }

        // ==========================================

        private void btnRequestPart_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedRow)
                {
                    DataGridViewRow row = dataPartRequestView.Rows[numberRow];

                    if (int.Parse(row.Cells[4].Value.ToString()) != 0)
                    {
                        MessageBox.Show("Nie można usunąć zrealizowanego zapotrzebowania", "Błąd",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (MessageBox.Show("Czy na pewno chcesz usunąć tę pozycję?", "Usuwanie części",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        int selectedID = int.Parse(row.Cells[0].Value.ToString());

                        PartRequest partrequest = new PartRequest();
                        partrequest = db.PartRequests.Where(request => request.IdPartRequest == selectedID).First();

                        db.PartRequests.Remove(partrequest);

                        db.SaveChanges();
                        ReloadData();

                        MessageBox.Show("Usunięto prawidłowo", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                else
                {
                    MessageBox.Show("Proszę wybrać zapotrzebowanie do usunięcia!", "Ostrzeżenie",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            catch(Exception)
            {
                MessageBox.Show("Wybrane zapotrzebowanie jest w trakcie realizacji i nie może zostać usunięte!", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                selectedRow = false;
            }
        }

        // ==========================================

        private void btnRequestPart_Accept_Click(object sender, EventArgs e)
        {
            if (selectedRow)
            {
                if (!acceptAvailable)
                {
                    MessageBox.Show("Akceptacja niemożliwa!\nWybrane zapotrzebowanie nie zostało zrealizowanie!", "Błąd",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else
                {
                    DialogResult result = MessageBox.Show("Czy na pewno chcesz zaakceptować wybrane zapotrzebowanie?", "Informacja",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        DataGridViewRow row = dataPartRequestView.Rows[numberRow];
                        int selectedID = int.Parse(row.Cells[0].Value.ToString());
                        string selectedName = row.Cells[1].Value.ToString();

                        PartRequest partrequest = new PartRequest();
                        partrequest = db.PartRequests.Where(request => request.IdPartRequest == selectedID).First();
                        partrequest.StatusPart = 2;

                        Part part = new Part();
                        part = db.Parts.Where(selectedpart => selectedpart.PartName == selectedName).First();
                        part.QuantityWarehouse += partrequest.Quantity;

                        db.SaveChanges();
                        ReloadData();
                        partsManagmentForm.ReloadData();

                        MessageBox.Show("Edytowano prawidłowo", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            else
            {
                MessageBox.Show("Proszę wybrać zapotrzebowanie do akceptacji!", "Ostrzeżenie",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        // ==========================================

        private void dataPartRequestView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            numberRow = e.RowIndex;
            int val = Convert.ToInt32(dataPartRequestView.Rows[numberRow].Cells[4].Value);

            if (e.ColumnIndex == 4)
            {
                if (val == 0)
                {
                    e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.SelectionBackColor = Color.Red;
                    e.CellStyle.SelectionForeColor = Color.Red;
                }

                else if (val == 1)
                {
                    e.CellStyle.BackColor = Color.Green;
                    e.CellStyle.ForeColor = Color.Green;
                    e.CellStyle.SelectionBackColor = Color.Green;
                    e.CellStyle.SelectionForeColor = Color.Green;
                }

                else
                {
                    e.CellStyle.BackColor = Color.Black;
                    e.CellStyle.ForeColor = Color.Black;
                    e.CellStyle.SelectionBackColor = Color.Black;
                    e.CellStyle.SelectionForeColor = Color.Black;
                }
            }

            if (numberRow >= 0)
            {
                selectedRow = true;

                if (val != 0)
                {
                    acceptAvailable = true;
                }

                else if (val == 0)
                {
                    acceptAvailable = false;
                }

            }

            else
            {
                selectedRow = false;
            }
        }

        // ==========================================

    }
}
