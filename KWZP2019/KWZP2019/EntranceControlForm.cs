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
        private bool resultsApproved = false;
        private bool doControlExist = true;

        // ==================================================

        public EntranceControlForm(RoofingCompanyEntities db, StartForm startForm, QualityControl qualityControlForm)
        {
            this.db = db;
            this.startForm = startForm;
            this.qualityControlForm = qualityControlForm;
            InitializeComponent();
        }

        // ==================================================

        private void btnReturnMain_Click(object sender, EventArgs e)
        {
            this.startForm.Show();
            this.qualityControlForm.Close();
            this.Close();
        }

        // ==================================================

        private void btnReturn_Click(object sender, EventArgs e)
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
            datePickerControlDate.Value = DateTime.Now;
            List<SemiFinishedOrder> sfOrdersList = db.SemiFinishedOrders.ToList();
            foreach (SemiFinishedOrder sfOrder in sfOrdersList)
            {
                domUDOrderId.Items.Add(sfOrder.IdSfOrder);
            }
        }

        // ==================================================

        private void textBoxEmployeeId_TextChanged(object sender, EventArgs e)
        {
            textBoxEmployeeId.BackColor = Color.White;
            Employee employee = db.Employees.FirstOrDefault(empee => empee.IdEmployee.ToString() == textBoxEmployeeId.Text);
            lblEmployeeFullName.Text = employee != null ? $"{employee.EmployeeName} {employee.EmployeeSurname}" : "";
        }

        // ==================================================

        private void domUDOrderId_SelectedItemChanged(object sender, EventArgs e)
        {
            domUDOrderId.BackColor = Color.White;
            domUDSfId.Items.Clear();
            List<SfOrderDetail> sfOrderDetails = db.SfOrderDetails
                .Where(detail => detail.IdSfOrder.ToString() == domUDOrderId.Text).ToList();
            foreach (SfOrderDetail sfOrderDetail in sfOrderDetails)
            {
                domUDSfId.Items.Add(sfOrderDetail.IdSemiFinished);
            }
            domUDSfId.Text = domUDSfId.Items.ToArray()[0].ToString(); // set first element as active from actual Items collection
            
            SemiFinishedOrder semiFinishedOrder = db.SemiFinishedOrders.FirstOrDefault(s => s.IdSfOrder.ToString() == domUDOrderId.Text);
            lblDaysOfDelay.Text = (semiFinishedOrder == null || semiFinishedOrder.SfDeliveryDate == DateTime.Now) ? "" : $"{Math.Round((DateTime.Now - semiFinishedOrder.SfDeliveryDate).TotalDays, 0).ToString()} dni opóźnienia";

            if(changeTextBoxesDependingOnExistedSelectedControl())
            {
                btnCheck_Click(sender, e);
                this.doControlExist = true;
            }
            else
            {
                this.doControlExist = false;
            }
        }

        // ==================================================

        private void domUDSfId_SelectedItemChanged(object sender, EventArgs e)
        {
            domUDSfId.BackColor = Color.White;

            if (changeTextBoxesDependingOnExistedSelectedControl())
            {
                btnCheck_Click(sender, e);
                this.doControlExist = true;
            }
            else
            {
                this.doControlExist = false;
            }
        }

        // ================================================== 

        private void btnCheck_Click(object sender, EventArgs e)
        {
            SemiFinished semiFinished = db.SemiFinisheds.FirstOrDefault(sf => sf.IdSemiFinished.ToString() == domUDSfId.Text);

            SfOrderDetail quantitySfOrder = db.SfOrderDetails
                .Where(sfod => sfod.IdSfOrder.ToString() == domUDOrderId.Text && sfod.IdSemiFinished.ToString() == domUDSfId.Text)
                .FirstOrDefault();

            if (semiFinished == null)
            {
                MessageBox.Show("Wybierz zamówienie i półfabrykat!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtboxThickness.Text != "")
                {
                    double thickness;
                    if(double.TryParse(txtboxThickness.Text, out thickness))
                    {
                        picBoxThicknessStatus.Image =
                        semiFinished.Thickness * 0.95 < thickness &&
                        thickness < semiFinished.Thickness * 1.05 ?
                        Properties.Resources.ok_48px :
                        Properties.Resources.cancel_48px;
                    }
                    else if(doControlExist)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Wpisz liczbę w pole 'Grubość'!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }

                if (txtboxWidth.Text != "")
                {
                    double width;
                    if(double.TryParse(txtboxWidth.Text, out width))
                    {
                        picBoxWidhtStatus.Image =
                        semiFinished.Width * 0.95 < width &&
                        width < semiFinished.Width * 1.05 ?
                        Properties.Resources.ok_48px :
                        Properties.Resources.cancel_48px;
                    }
                    else if(doControlExist)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Wpisz liczbę w pole 'Szerokość'!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (txtboxMass.Text != "")
                {
                    double mass;
                    if(double.TryParse(txtboxMass.Text, out mass))
                    {
                        picBoxMassStatus.Image =
                        semiFinished.SfWeight * 0.95 < mass &&
                        mass < semiFinished.SfWeight * 1.05 ?
                        Properties.Resources.ok_48px :
                        Properties.Resources.cancel_48px;
                    }
                    else if(doControlExist)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Wpisz liczbę w pole 'Masa'!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }

                if (txtBoxColor.Text != "")
                {
                    picBoxColorStatus.Image = semiFinished.Color == txtBoxColor.Text ?
                        Properties.Resources.ok_48px :
                        Properties.Resources.cancel_48px;
                }

                if (txtBoxQuantity.Text != "")
                {
                    double quantity;
                    if(double.TryParse(txtBoxQuantity.Text, out quantity))
                    {
                        picBoxQuantityStatus.Image = quantitySfOrder.Quantity == quantity ?
                        Properties.Resources.ok_48px :
                        Properties.Resources.cancel_48px;
                    }
                    else if(doControlExist)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Wpisz liczbę w pole 'Ilość'!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }
        }

        // ==================================================

        private void btnApproval_Click(object sender, EventArgs e)
        {
            if (domUDOrderId.Text == "")
            {
                MessageBox.Show("Wybierz zamówienie i półfabrykat!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (this.doControlExist)
            {
                MessageBox.Show("Ta kontrola już istnieje w bazie!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (domUDOrderId.Text == "" || domUDSfId.Text == "" || textBoxEmployeeId.Text == "" || txtboxThickness.Text == ""
                        || txtboxWidth.Text == "" || txtboxMass.Text == "" || txtBoxColor.Text == "" || txtBoxQuantity.Text == "")
            {
                MessageBox.Show("Nie można zatwierdzić wyników!\nUzupełnij wszystkie pola!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (domUDOrderId.Text == "")
                {
                    domUDOrderId.BackColor = Color.Red;
                }
                if (domUDSfId.Text == "")
                {
                    domUDSfId.BackColor = Color.Red;
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
            else
            {
                resultsApproved = true;
            }
        }

        // ==================================================

        private void btnDone_Click(object sender, EventArgs e)
        {
            
            if(resultsApproved)
            {
                // var because it's anonymouse type
                var idSfDetail = db.EntranceControls.Join(db.SfOrderDetails, ec => ec.IdSfDetail, order => order.IdSfDetail,
                (ec, order) => new { ec.IdSfDetail }).FirstOrDefault();

                EntranceControl entranceControl = new EntranceControl();

                entranceControl.IdSfDetail = int.Parse(idSfDetail.ToString());
                entranceControl.ControlDate = datePickerControlDate.Value;
                entranceControl.Comments = txtboxComment.Text;
                entranceControl.Quantity = int.Parse(txtBoxQuantity.Text);
                entranceControl.RealThickness = decimal.Parse(txtboxThickness.Text);
                entranceControl.RealWidth = decimal.Parse(txtboxWidth.Text);
                entranceControl.RealWeight = decimal.Parse(txtboxMass.Text);
                entranceControl.RealColor = txtBoxColor.Text;
                entranceControl.ChemicalComposition = checkBoxComposition.Checked;

                db.EntranceControls.Add(entranceControl);
                //db.SaveChanges();
            }
            {
                MessageBox.Show("Proszę zatwierdzić wyniki", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // ==================================================

        private void txtbox_TextChanged(object sender, EventArgs e)
        {
            (sender as TextBox).BackColor = Color.White;
        }

        // ==================================================

        private void resetAllCheckedPicBox()
        {
            picBoxThicknessStatus.Image = Properties.Resources.help_40px;
            picBoxWidhtStatus.Image = Properties.Resources.help_40px;
            picBoxMassStatus.Image = Properties.Resources.help_40px;
            picBoxColorStatus.Image = Properties.Resources.help_40px;
            picBoxQuantityStatus.Image = Properties.Resources.help_40px;
        }

        // ==================================================

        private bool changeTextBoxesDependingOnExistedSelectedControl()
        {
            // Changed text boxes style depending on if selected control exist in database and return true if exist, if not return false
            // var because it's anonymouse type
            var doControlExist = db.EntranceControls.Join(db.SfOrderDetails, ec => ec.IdSfDetail, order => order.IdSfDetail,
                (ec, order) => new { order.IdSfOrder, order.IdSemiFinished, ec.IdEmployee, ec.RealThickness, ec.RealWidth, ec.RealWeight, ec.RealColor, ec.Quantity, ec.ControlStatus, ec.ChemicalComposition, ec.Comments })
                .Where(order => order.IdSfOrder.ToString() == domUDOrderId.Text && order.IdSemiFinished.ToString() == domUDSfId.Text).FirstOrDefault();

            if (doControlExist == null)
            {
                lblControlNotExist.Text = "Brak kontroli\nw bazie!";
                this.resetAllCheckedPicBox();
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
                textBoxEmployeeId.Text = doControlExist.IdEmployee.ToString();
                textBoxEmployeeId.Enabled = false;
                txtboxThickness.Text = doControlExist.RealThickness.ToString();
                txtboxThickness.Enabled = false;
                txtboxWidth.Text = doControlExist.RealWidth.ToString();
                txtboxWidth.Enabled = false;
                txtboxMass.Text = doControlExist.RealWeight.ToString();
                txtboxMass.Enabled = false;
                txtBoxColor.Text = doControlExist.RealColor;
                txtBoxColor.Enabled = false;
                txtBoxQuantity.Text = doControlExist.Quantity.ToString();
                txtBoxQuantity.Enabled = false;
                checkBoxComposition.Checked = doControlExist.ChemicalComposition;
                checkBoxComposition.Enabled = false;
                txtboxComment.Text = doControlExist.Comments;
                txtboxComment.Enabled = false;
                picBoxControlStatus.Image = doControlExist.ControlStatus == true ? Properties.Resources.good_quality_80px : Properties.Resources.poor_quality_80px;
                return true;
            }
        }
    }
}
