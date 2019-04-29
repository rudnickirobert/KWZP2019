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
        private String selectedOrderId;
        private String selectedSfId;

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

        private void BtnShowFromDate_Click(object sender, EventArgs e)
        {
            ShowControlsFromDate(datePickerSelectedControlsDate.Value);
        }

        // ==================================================

        private void BtnShow_Click(object sender, EventArgs e)
        {
            // Polish names only for displaying into dataGridView in form
            // var because it's an anonymouse type
            var orders = db.SfOrderDetails
                .Join(db.SemiFinishedOrders,
                sfOrderDetail => sfOrderDetail.IdSfOrder,
                sfOrder => sfOrder.IdSfOrder,
                (sfOrderDetail, sfOrder) => new {
                    ID_zamówienia = sfOrderDetail.IdSfOrder,
                    ID_półfabrykatu = sfOrderDetail.IdSemiFinished,
                    Data_dostarczenia = sfOrder.SfDeliveryDate
                })
                .OrderBy(orderBy =>
                orderBy.Data_dostarczenia)
                .ToList();
            dataGVEntranceControl.DataSource = orders;
        }

        // ==================================================
        private void DataGVEntranceControl_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow selectedRow = dataGVEntranceControl.SelectedRows[0];
            selectedOrderId = selectedRow.Cells["ID_zamówienia"].Value.ToString();
            lblOrderIdShow.Text = selectedOrderId;
            selectedSfId = selectedRow.Cells["ID_półfabrykatu"].Value.ToString();
            lblSfIdShow.Text = selectedSfId;
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
                int minutesOfDelay = (int)Math.Round((DateTime.Now - (DateTime)selectedRow.Cells["Data_dostarczenia"].Value).TotalMinutes, 0);
                lblDelayTime.Text = $"{minutesOfDelay / 1440} dni, {(minutesOfDelay % 1440) / 60} godzin i {(minutesOfDelay % 1440) % 60} minut opóźnienia";
            }
        }

        // ==================================================
        private void TextBoxEmployeeId_TextChanged(object sender, EventArgs e)
        {
            textBoxEmployeeId.BackColor = Color.White;

            Employee employee = db.Employees
                .FirstOrDefault(check => 
                check.IdEmployee.ToString() == textBoxEmployeeId.Text);

            lblEmployeeFullName.Text = employee != null ? 
                $"Kontrolował: {employee.EmployeeName} {employee.EmployeeSurname}" : 
                "Brak pracownika z takim ID";
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
                MessageBox.Show("Wybierz zamówienie i półfabrykat!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (this.doControlExist)
            {
                MessageBox.Show("Ta kontrola już istnieje w bazie!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (lblOrderIdShow.Text == "" || lblSfIdShow.Text == "" 
                || textBoxEmployeeId.Text == "" || txtboxThickness.Text == ""
                || txtboxWidth.Text == "" || txtboxMass.Text == ""
                || txtBoxColor.Text == "" || txtBoxQuantity.Text == "")
            {
                MessageBox.Show("Nie można zatwierdzić wyników!\nUzupełnij wszystkie pola!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (lblOrderIdShow.Text == "")
                {
                    lblOrderIdShow.BackColor = Color.Red;
                }
                if (lblSfIdShow.Text == "")
                {
                    lblSfIdShow.BackColor = Color.Red;
                }
                if (textBoxEmployeeId.Text == "")
                {
                    textBoxEmployeeId.BackColor = Color.Red;
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
                // var because it's anonymouse type
                SfOrderDetail idSfDetail = db.SfOrderDetails
                    .Where(check =>
                    check.IdSfOrder.ToString() == selectedOrderId
                    && check.IdSemiFinished.ToString() == selectedSfId).First();


                EntranceControl entranceControl = new EntranceControl();

                entranceControl.IdSfDetail = idSfDetail.IdSfDetail;
                entranceControl.IdEmployee = int.Parse(textBoxEmployeeId.Text);
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
            // Changed text boxes style depending on if selected control exist in database and return true if exist and false if not
            // var because it's anonymouse type
            var selectedControl = db.EntranceControls
                .Join(db.SfOrderDetails,
                ec => ec.IdSfDetail,
                order => order.IdSfDetail,
                (ec, order) => new
                {
                    order.IdSfOrder,
                    order.IdSemiFinished,
                    ec.IdEmployee,
                    ec.RealThickness,
                    ec.RealWidth,
                    ec.RealWeight,
                    ec.RealColor,
                    ec.Quantity,
                    ec.ControlStatus,
                    ec.ChemicalComposition,
                    ec.Comments
                })
                .Where(check => 
                check.IdSfOrder.ToString() == selectedOrderId && 
                check.IdSemiFinished.ToString() == selectedSfId)
                .FirstOrDefault();

            if (selectedControl == null)
            {
                lblControlNotExist.Text = "Brak kontroli\nw bazie!";
                this.ResetAllCheckedPicBox();
                textBoxEmployeeId.Text = "";
                textBoxEmployeeId.Enabled = true;
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
                lblControlNotExist.Text = "";
                textBoxEmployeeId.Text = selectedControl.IdEmployee.ToString();
                txtboxThickness.Text = selectedControl.RealThickness.ToString();
                txtboxWidth.Text = selectedControl.RealWidth.ToString();
                txtboxMass.Text = selectedControl.RealWeight.ToString();
                txtBoxColor.Text = selectedControl.RealColor;
                txtBoxQuantity.Text = selectedControl.Quantity.ToString();
                checkBoxComposition.Checked = selectedControl.ChemicalComposition;
                txtboxComment.Text = selectedControl.Comments;

                CheckControl();

                textBoxEmployeeId.Enabled = false;
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
                SemiFinished semiFinished = db.SemiFinisheds.FirstOrDefault(sf => sf.IdSemiFinished.ToString() == selectedSfId);

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
                        check.IdSfOrder.ToString() == selectedOrderId
                        && check.IdSemiFinished.ToString() == selectedSfId)
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
            // var because it's an anonymouse type
            var orders = db.SfOrderDetails
                .Join(db.SemiFinishedOrders,
                sfOrderDetail => sfOrderDetail.IdSfOrder,
                sfOrder => sfOrder.IdSfOrder,
                (sfOrderDetail, sfOrder) => new
                {
                    sfOrderDetail,
                    sfOrder
                })
                .Where(check =>
                check.sfOrder.SfDeliveryDate.Year == selectedDate.Year
                && check.sfOrder.SfDeliveryDate.Month == selectedDate.Month
                && check.sfOrder.SfDeliveryDate.Day == selectedDate.Day)
                .Select(sfOrderDetailJoinSfOrder => new
                {
                    ID_zamówienia = sfOrderDetailJoinSfOrder.sfOrderDetail.IdSfOrder,
                    ID_półfabrykatu = sfOrderDetailJoinSfOrder.sfOrderDetail.IdSemiFinished,
                    Data_dostarczenia = sfOrderDetailJoinSfOrder.sfOrder.SfDeliveryDate
                })
                .OrderBy(orderBy =>
                orderBy.Data_dostarczenia)
                .ToList();
            // Polish names only for displaying into dataGridView in form
            dataGVEntranceControl.DataSource = orders;
        }
    }
}
