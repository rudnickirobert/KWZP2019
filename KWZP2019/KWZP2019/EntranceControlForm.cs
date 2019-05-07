using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KWZP2019
{
    public partial class EntranceControlForm : Form
    {
        private RoofingCompanyEntities db;
        private StartForm startForm;
        private QualityControl qualityControlForm;
        private bool doResultsApproved;
        private bool doControlExist;
        private bool doResultsChecked;
        private bool wholeControlStatus;
        private Nullable<int> selectedOrderId;
        private int selectedSfId;
        private int idControler;
        DataGridViewRow selectedRow;
        // ==================================================
        public EntranceControlForm(RoofingCompanyEntities db, StartForm startForm, QualityControl qualityControlForm)
        {
            this.db = db;
            this.startForm = startForm;
            this.qualityControlForm = qualityControlForm;
            InitializeComponent();
        }
        // ==================================================
        private void BtnReturnMain_Click(object sender, EventArgs e)
        {
            this.startForm.Show();
            this.qualityControlForm.Close();
            this.Close();
        }
        // ==================================================
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.qualityControlForm.Show();
            this.Hide();
        }
        // ==================================================
        private void BtnStatistics_Click(object sender, EventArgs e)
        {
            EntranceControlStatisticsForm statisticsForm = new EntranceControlStatisticsForm(db, startForm, this);
            statisticsForm.Show();
            this.Hide();
        }
        // ==================================================
        private void EntranceControlForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.startForm.Show();
            this.qualityControlForm.Close();
        }
        // ==================================================
        private void EntranceControlForm_Load(object sender, EventArgs e)
        {
            datePickerSelectedControlsDate.Value = DateTime.Now;
            ShowControlsFromDate(DateTime.Now);
        }
        // ==================================================
        private void BtnShowFromToday_Click(object sender, EventArgs e)
        {
            datePickerSelectedControlsDate.Value = DateTime.Now;
            ShowControlsFromDate(DateTime.Now);
        }
        // ==================================================
        private void BtnShowFromDay_Click(object sender, EventArgs e)
        {
            ShowControlsFromDate(datePickerSelectedControlsDate.Value);
        }
        // ==================================================
        private void BtnShowFromMonth_Click(object sender, EventArgs e)
        {
            ShowControlsFromDate(datePickerSelectedControlsDate.Value.Month, datePickerSelectedControlsDate.Value.Year);
        }
        // ==================================================
        private void BtnShowFromYear_Click(object sender, EventArgs e)
        {
            ShowControlsFromDate(datePickerSelectedControlsDate.Value.Year);
        }
        // ==================================================
        private void BtnShowAll_Click(object sender, EventArgs e)
        {
            List<ViewSemiFinishedOrder> orders = db.ViewSemiFinishedOrders
				.OrderBy(orderBy => orderBy.Dostarczono)
				.ToList();

            dataGridViewEntranceControl.DataSource = orders;
        }
        // ==================================================
        private void DataGVEntranceControl_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
			
            selectedRow = dataGridViewEntranceControl.SelectedRows[0];
            selectedOrderId = (int)selectedRow.Cells["Nr_zamówienia"].Value;
            lblOrderIdShow.Text = selectedOrderId.ToString();
			String selectedSfCode = selectedRow.Cells["Kod_półfabrykatu"].Value.ToString();
			lblSfIdShow.Text = selectedSfCode;
			
			SemiFinished sfBySelectedCode = db.SemiFinisheds.Where(check => check.SfCode == selectedSfCode).First();

            selectedSfId = sfBySelectedCode.IdSemiFinished;

            if ((DateTime)selectedRow.Cells["Dostarczono"].Value < DateTime.Now)
            {
                btnApproval.Enabled = true;
                btnCheck.Enabled = true;
                btnDone.Enabled = true;
                if (ChangeTextBoxesDependingOnExistedSelectedControl())
                {
                    this.doControlExist = true;
                    lblDelayTime.Text = "";
                }
                else
                {
                    this.doResultsChecked = false;
                    this.doResultsApproved = false;
                    this.doControlExist = false;
                    int minutesOfDelay = (int)Math.Round((DateTime.Now - (DateTime)selectedRow.Cells["Dostarczono"].Value).TotalMinutes, 0);
                    lblDelayTime.Text = minutesOfDelay > 0 ? $"{minutesOfDelay / 1440} dni, {(minutesOfDelay % 1440) / 60} godzin i {(minutesOfDelay % 1440) % 60} minut opóźnienia" : "";
                }
            }
            else
            {
                MessageBox.Show("Data dostarczenia jest wcześniejsza od chwili obecnej.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnApproval.Enabled = false;
                btnCheck.Enabled = false;
                btnDone.Enabled = false;
                this.ResetAllCheckedPicBox();
                textBoxEmployeePESEL.Text = "";
                textBoxEmployeePESEL.Enabled = false;
                txtboxThickness.Text = "";
                txtboxThickness.Enabled = false;
                txtboxWidth.Text = "";
                txtboxWidth.Enabled = false;
                txtboxMass.Text = "";
                txtboxMass.Enabled = false;
                txtBoxColor.Text = "";
                txtBoxColor.Enabled = false;
                txtBoxQuantity.Text = "";
                txtBoxQuantity.Enabled = false;
                checkBoxComposition.Checked = false;
                checkBoxComposition.Enabled = false;
                txtboxComment.Text = "";
                txtboxComment.Enabled = false;
                picBoxControlStatus.Image = Properties.Resources.new_80px;
            }
        }
        // ==================================================
        private void TextBoxEmployeePESEL_TextChanged(object sender, EventArgs e)
        {
            textBoxEmployeePESEL.BackColor = Color.White;
            if(textBoxEmployeePESEL.Text.Length < 11)
            {
                lblEmployeeFullName.Text = "Za mało cyfr!";
            }
            else if(textBoxEmployeePESEL.Text.Length > 11)
            {
                lblEmployeeFullName.Text = "Za dużo cyfr!";
            }
            if(textBoxEmployeePESEL.Text.Length == 11)
            {
                Employee employee = db.Employees
                .FirstOrDefault(check => check.PESEL == textBoxEmployeePESEL.Text);
                if(employee == null)
                {
                    MessageBox.Show("Brak pracownika o takim numerze PESEL", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    idControler = employee.IdEmployee;
                    ViewQualityControlerList qualityControler = db.ViewQualityControlerLists
                    .FirstOrDefault(check => check.IdEmployee == idControler);
                    if (qualityControler == null)
                    {
                        MessageBox.Show("Brak pracownika o takim numerze PESEL\nw dziale kontroli jakości", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        lblEmployeeFullName.Text = $"Kontrolował: {qualityControler.EmployeeName} {qualityControler.EmployeeSurname}";
                        /*lblEmployeeFullName.Text = employee != null ?
                        $"Kontrolował: {employee.EmployeeName} {employee.EmployeeSurname}" :
                        "Brak pracownika z takim numerem PESEL";*/
                    }
                }
            }
        }
        // ================================================== 
        private void BtnCheck_Click(object sender, EventArgs e)
        {
            CheckControl();
            this.doResultsChecked = true;
        }
        // ==================================================
        private void BtnApproval_Click(object sender, EventArgs e)
        {
            if (selectedOrderId == null)
            {
                MessageBox.Show("Wybierz zamówienie i półfabrykat!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (this.doControlExist)
            {
                MessageBox.Show("Ta kontrola już istnieje w bazie!", "Wiadomość", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (lblOrderIdShow.Text == "" || lblSfIdShow.Text == "" 
                || textBoxEmployeePESEL.Text == "" || txtboxThickness.Text == ""
                || txtboxWidth.Text == "" || txtboxMass.Text == ""
                || txtBoxColor.Text == "" || txtBoxQuantity.Text == "")
            {
                MessageBox.Show("Nie można zatwierdzić wyników!\nUzupełnij wszystkie pola!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (lblOrderIdShow.Text == "")
                {
                    lblOrderIdShow.BackColor = Color.Red;
                }
                if (lblSfIdShow.Text == "")
                {
                    lblSfIdShow.BackColor = Color.Red;
                }
                if (textBoxEmployeePESEL.Text == "")
                {
                    textBoxEmployeePESEL.BackColor = Color.Red;
                }
                if (txtboxThickness.Text == "")
                {
                    txtboxThickness.BackColor = Color.Red;
                }
                if (txtboxWidth.Text == "")
                {
                    txtboxWidth.BackColor = Color.Red;
                }
                if (txtboxMass.Text == "")
                {
                    txtboxMass.BackColor = Color.Red;
                }
                if (txtBoxColor.Text == "")
                {
                    txtBoxColor.BackColor = Color.Red;
                }
                if (txtBoxQuantity.Text == "")
                {
                    txtBoxQuantity.BackColor = Color.Red;
                }
            }
            else if (lblEmployeeFullName.Text == "" || lblEmployeeFullName.Text == "Za mało cyfr!" || lblEmployeeFullName.Text == "Za dużo cyfr!")
            {
                MessageBox.Show("Nie można zatwierdzić wyników!\nZły pracownik!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(this.doResultsChecked)
            {
                this.doResultsApproved = true;
                MessageBox.Show("Wyniki potwierdzone.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Najpierw sprawdź wyniki!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // ==================================================
        private void BtnDone_Click(object sender, EventArgs e)
        {
            
            if(doResultsApproved)
            {
                SfOrderDetail idSfDetail = db.SfOrderDetails
                    .Where(check =>
                    check.IdSfOrder == selectedOrderId
                    && check.IdSemiFinished == selectedSfId).First();


                EntranceControl entranceControl = new EntranceControl();

                entranceControl.IdSfDetail = idSfDetail.IdSfDetail;
                entranceControl.IdEmployee = this.idControler;
                entranceControl.ControlDate = datePickerSelectedControlsDate.Value;
                entranceControl.Comments = txtboxComment.Text;
                entranceControl.Quantity = int.Parse(txtBoxQuantity.Text);
                entranceControl.RealThickness = Math.Floor(decimal.Parse(txtboxThickness.Text) * 100) / 100;
                entranceControl.RealWidth = Math.Floor(decimal.Parse(txtboxWidth.Text) * 100) / 100;
                entranceControl.RealWeight = Math.Floor(decimal.Parse(txtboxMass.Text) * 100) / 100;
                entranceControl.RealColor = txtBoxColor.Text;
                entranceControl.ChemicalComposition = checkBoxComposition.Checked;
                entranceControl.ControlStatus = this.wholeControlStatus;

                db.EntranceControls.Add(entranceControl);
                db.SaveChanges();
                MessageBox.Show("Kontrola dodana do bazy.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Proszę zatwierdzić wyniki!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // ==================================================
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            (sender as TextBox).BackColor = Color.White;
            ResetAllCheckedPicBox();
            this.doResultsChecked = false;
        }
        // ==================================================
        private void ResetAllCheckedPicBox()
        {
            picBoxThicknessStatus.Image = Properties.Resources.help_40px;
            picBoxWidhtStatus.Image = Properties.Resources.help_40px;
            picBoxMassStatus.Image = Properties.Resources.help_40px;
            picBoxColorStatus.Image = Properties.Resources.help_40px;
            picBoxQuantityStatus.Image = Properties.Resources.help_40px;
        }
        // ==================================================
        private bool ChangeTextBoxesDependingOnExistedSelectedControl()
        {
            ViewEntranceControlHistory selectedControl = db.ViewEntranceControlHistories
                .Where(check => 
                check.IdSfOrder == selectedOrderId && 
                check.IdSemiFinished == selectedSfId)
                .FirstOrDefault();

            if (selectedControl == null)
            {
                lblControlNotExist.Text = "Brak kontroli\nw bazie!";
                this.ResetAllCheckedPicBox();
                textBoxEmployeePESEL.Text = "";
                textBoxEmployeePESEL.Enabled = true;
                txtboxThickness.Text = "";
                txtboxThickness.Enabled = true;
                txtboxWidth.Text = "";
                txtboxWidth.Enabled = true;
                txtboxMass.Text = "";
                txtboxMass.Enabled = true;
                txtBoxColor.Text = "";
                txtBoxColor.Enabled = true;
                txtBoxQuantity.Text = "";
                txtBoxQuantity.Enabled = true;
                checkBoxComposition.Checked = false;
                checkBoxComposition.Enabled = true;
                txtboxComment.Text = "";
                txtboxComment.Enabled = true;
                picBoxControlStatus.Image = Properties.Resources.new_80px;
                return false;
            }
            else
            {
                Employee employee = db.Employees.First(check => check.IdEmployee == selectedControl.IdEmployee);
                lblControlNotExist.Text = "";
                textBoxEmployeePESEL.Text = employee.PESEL;
                txtboxThickness.Text = selectedControl.RealThickness.ToString();
                txtboxWidth.Text = selectedControl.RealWidth.ToString();
                txtboxMass.Text = selectedControl.RealWeight.ToString();
                txtBoxColor.Text = selectedControl.RealColor;
                txtBoxQuantity.Text = selectedControl.Quantity.ToString();
                checkBoxComposition.Checked = selectedControl.ChemicalComposition;
                txtboxComment.Text = selectedControl.Comments;

                CheckControl();

                textBoxEmployeePESEL.Enabled = false;
                txtboxThickness.Enabled = false;
                txtboxWidth.Enabled = false;
                txtboxMass.Enabled = false;
                txtBoxColor.Enabled = false;
                txtBoxQuantity.Enabled = false;
                checkBoxComposition.Enabled = false;
                txtboxComment.Enabled = false;

                picBoxControlStatus.Image = selectedControl.ControlStatus == true ? 
                    Properties.Resources.good_quality_80px : 
                    Properties.Resources.poor_quality_80px;
                return true;
            }
        }
        // ==================================================
        private void CheckControl()
        {
            if (lblOrderIdShow.Text == "")
            {
                MessageBox.Show("Wybierz zamówienie i półfabrykat!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SemiFinished semiFinished = db.SemiFinisheds.FirstOrDefault(sf => sf.IdSemiFinished == selectedSfId);

                bool flagThickness = false;
                bool flagWidth = false;
                bool flagMass = false;
                bool flagColor = false;
                bool flagQuantity = false;

                if (txtboxThickness.Text.Trim() != "")
                {
                    if (decimal.TryParse(txtboxThickness.Text, out decimal thickness))
                    {
                        if ((decimal)(semiFinished.Thickness * 0.95) < thickness &&
                        thickness < (decimal)(semiFinished.Thickness * 1.05))
                        {
                            picBoxThicknessStatus.Image = Properties.Resources.ok_48px;
                            flagThickness = true;
                        }
                        else
                        {
                            picBoxThicknessStatus.Image = Properties.Resources.cancel_48px;
                        }
                    }
                    else
                    {
                        txtboxThickness.Text = "WPISZ LICZBĘ!";
                    }
                }

                if (txtboxWidth.Text.Trim() != "")
                {
                    if (decimal.TryParse(txtboxWidth.Text, out decimal width))
                    {
                        if ((decimal)(semiFinished.Width * 0.95) < width &&
                        width < (decimal)(semiFinished.Width * 1.05))
                        {
                            picBoxWidhtStatus.Image = Properties.Resources.ok_48px;
                            flagWidth = true;
                        }
                        else
                        {
                            picBoxWidhtStatus.Image = Properties.Resources.cancel_48px;
                        }
                    }
                    else
                    {
                        txtboxWidth.Text = "WPISZ LICZBĘ!";
                    }
                }

                if (txtboxMass.Text.Trim() != "")
                {
                    if (decimal.TryParse(txtboxMass.Text, out decimal mass))
                    {
                        if ((decimal)(semiFinished.SfWeight * 0.95) < mass &&
                        mass < (decimal)(semiFinished.SfWeight * 1.05))
                        {
                            picBoxMassStatus.Image = Properties.Resources.ok_48px;
                            flagMass = true;
                        }
                        else
                        {
                            picBoxMassStatus.Image = Properties.Resources.cancel_48px;
                        }
                    }
                    else
                    {
                        txtboxMass.Text = "WPISZ LICZBĘ!";
                    }
                }

                if (txtBoxColor.Text.Trim() != "")
                {
                    if (semiFinished.Color == txtBoxColor.Text)
                    {
                        picBoxColorStatus.Image = Properties.Resources.ok_48px;
                        flagColor = true;
                    }
                    else
                    {
                        picBoxColorStatus.Image = Properties.Resources.cancel_48px;
                    }
                }

                if (txtBoxQuantity.Text.Trim() != "")
                {
                    SfOrderDetail quantitySfOrder = db.SfOrderDetails
                        .Where(check =>
                        check.IdSfOrder == selectedOrderId
                        && check.IdSemiFinished == selectedSfId)
                        .FirstOrDefault();

                    if (int.TryParse(txtBoxQuantity.Text, out int quantity))
                    {
                        if (quantitySfOrder.Quantity == quantity)
                        {
                            picBoxQuantityStatus.Image = Properties.Resources.ok_48px;
                            flagQuantity = true;
                        }
                        else
                        {
                            picBoxQuantityStatus.Image = Properties.Resources.cancel_48px;
                        }
                    }
                    else
                    {
                        txtBoxQuantity.Text = "LICZBA CAŁKOWITA!";
                    }
                }

                if (flagThickness && flagWidth && flagMass && flagColor && flagQuantity && checkBoxComposition.Checked)
                {
                    picBoxControlStatus.Image = Properties.Resources.good_quality_80px;
                    this.wholeControlStatus = true;
                }
                else
                {
                    picBoxControlStatus.Image = Properties.Resources.poor_quality_80px;
                    this.wholeControlStatus = false;
                }
            }
        }
        // ==================================================
        private void ShowControlsFromDate(DateTime selectedDate)
        {
            List<ViewSemiFinishedOrder> orders = db.ViewSemiFinishedOrders
				.Where(check =>
				check.Dostarczono.Year == selectedDate.Year
				&& check.Dostarczono.Month == selectedDate.Month
				&& check.Dostarczono.Day == selectedDate.Day)
				.OrderBy(orderBy => orderBy.Dostarczono)
				.ToList();
            
            dataGridViewEntranceControl.DataSource = orders;
        }
        // ==================================================
        private void ShowControlsFromDate(int month, int year)
        {
            List<ViewSemiFinishedOrder> orders = db.ViewSemiFinishedOrders
				.Where(check =>
				check.Dostarczono.Year == year
				&& check.Dostarczono.Month == month)
				.OrderBy(orderBy => orderBy.Dostarczono)
				.ToList();
            
            dataGridViewEntranceControl.DataSource = orders;
        }
        // ==================================================
        private void ShowControlsFromDate(int year)
        {
            List<ViewSemiFinishedOrder> orders = db.ViewSemiFinishedOrders
				.Where(check =>
				check.Dostarczono.Year == year)
				.OrderBy(orderBy => orderBy.Dostarczono)
				.ToList();
            
            dataGridViewEntranceControl.DataSource = orders;
        }
    }
}
