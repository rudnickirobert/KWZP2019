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
        RoofingCompanyEntities db;
        StartForm startForm;
        QualityControl qualityControlForm;
        bool resultsApproved = false;
        bool doControlExist = true;

        public EntranceControlForm(RoofingCompanyEntities db, StartForm startForm, QualityControl qualityControlForm)
        {
            this.db = db;
            this.startForm = startForm;
            this.qualityControlForm = qualityControlForm;
            InitializeComponent();
        }

        private void btnReturnMain_Click(object sender, EventArgs e)
        {
            this.startForm.Show();
            this.Hide();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.qualityControlForm.Show();
            this.Hide();
        }

        private void EntranceControlForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.startForm.Show();
        }

        private void EntranceControlForm_Load(object sender, EventArgs e)
        {
            datePickerControlDate.Value = DateTime.Now;
            List<SemiFinishedOrder> sfOrdersList = db.SemiFinishedOrders.ToList();
            foreach (SemiFinishedOrder sfOrder in sfOrdersList)
            {
                domUDOrderId.Items.Add(sfOrder.IdSfOrder);
            }
        }

        private void textBoxEmployeeId_TextChanged(object sender, EventArgs e)
        {
            textBoxEmployeeId.BackColor = Color.White;
            Employee employee = db.Employees.FirstOrDefault(empee => empee.IdEmployee.ToString() == textBoxEmployeeId.Text);
            lblEmployeeFullName.Text = employee != null ? $"{employee.EmployeeName} {employee.EmployeeSurname}" : "";
        }

        private bool changeTextBoxes()
        {
            // var bo to typ anonimowy
            var doControlExist = db.EntranceControls.Join(db.SfOrderDetails, ec => ec.IdSfDetail, order => order.IdSfDetail,
                (ec, order) => new { order.IdSfOrder, order.IdSemiFinished, ec.RealThickness, ec.RealWidth, ec.RealWeight, ec.RealColor, ec.Quantity, ec.ControlStatus, ec.ChemicalComposition })
                .Where(order => order.IdSfOrder.ToString() == domUDOrderId.Text && order.IdSemiFinished.ToString() == domUDSfId.Text).FirstOrDefault();

            if (doControlExist == null)
            {
                lblControlNotExist.Text = "Brak kontroli\nw bazie!";
                this.resetAllCheckedPicBox();
                txtboxThickness.Text = "";
                txtboxWidth.Text = "";
                txtboxMass.Text = "";
                txtBoxColor.Text = "";
                txtBoxQuantity.Text = "";
                checkBoxComposition.Checked = false;
                picBoxControlStatus.Image = Properties.Resources.new_80px;
                return false;
            }
            else
            {
                lblControlNotExist.Text = "";
                txtboxThickness.Text = doControlExist.RealThickness.ToString();
                txtboxWidth.Text = doControlExist.RealWidth.ToString();
                txtboxMass.Text = doControlExist.RealWeight.ToString();
                txtBoxColor.Text = doControlExist.RealColor.ToString();
                txtBoxQuantity.Text = doControlExist.Quantity.ToString();
                checkBoxComposition.Checked = doControlExist.ChemicalComposition;
                picBoxControlStatus.Image = doControlExist.ControlStatus == true ? Properties.Resources.good_quality_80px : Properties.Resources.poor_quality_80px;
                return true;
            }
        }

        private void domUDOrderId_SelectedItemChanged(object sender, EventArgs e)
        {
            domUDOrderId.BackColor = Color.White;
            domUDSfId.Items.Clear(); // czeszczenie z poprzedniego wyboru, listy id półproduktów mogą się rożnic między zamówieniami
            List<SfOrderDetail> sfOrderDetails = db.SfOrderDetails
                .Where(detail => detail.IdSfOrder.ToString() == domUDOrderId.Text).ToList();
            foreach (SfOrderDetail sfOrderDetail in sfOrderDetails)
            {
                domUDSfId.Items.Add(sfOrderDetail.IdSemiFinished);
            }
            domUDSfId.Text = domUDSfId.Items.ToArray()[0].ToString(); // ustawia pierwszy element z danej listy jako aktualny tekst
            
            SemiFinishedOrder semiFinishedOrder = db.SemiFinishedOrders.FirstOrDefault(s => s.IdSfOrder.ToString() == domUDOrderId.Text);
            lblDaysOfDelay.Text = (semiFinishedOrder == null || semiFinishedOrder.SfDeliveryDate == DateTime.Now) ? "" : $"{Math.Round((DateTime.Now - semiFinishedOrder.SfDeliveryDate).TotalDays, 0).ToString()} dni opóźnienia";

            if(changeTextBoxes())
            {
                btnCheck_Click(sender, e);
                this.doControlExist = true;
            }
            else
            {
                this.doControlExist = false;
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            
            if(resultsApproved)
            {
                // var bo to typ anonimowy
                var idSfDetail = db.EntranceControls.Join(db.SfOrderDetails, ec => ec.IdSfDetail, order => order.IdSfDetail,
                (ec, order) => new { ec.IdSfDetail }).FirstOrDefault();

                EntranceControl entranceControl = new EntranceControl();

                entranceControl.IdSfDetail = int.Parse(idSfDetail.ToString());
                entranceControl.ControlDate = datePickerControlDate.Value;
                entranceControl.Comments = txtboxComment.Text;
                entranceControl.Quantity = int.Parse(txtBoxQuantity.Text);
                entranceControl.RealThickness = int.Parse(txtboxThickness.Text);
                entranceControl.RealWidth = int.Parse(txtboxWidth.Text);
                entranceControl.RealWeight = int.Parse(txtboxMass.Text);
                entranceControl.RealColor = txtBoxColor.Text;
                entranceControl.ChemicalComposition = checkBoxComposition.Checked;

                db.EntranceControls.Add(entranceControl);
                //db.SaveChanges();
            }
            {
                MessageBox.Show("Proszę zatwierdzić wyniki", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtbox_TextChanged(object sender, EventArgs e)
        {
            (sender as TextBox).BackColor = Color.White;
        }

        private void domUDSfId_SelectedItemChanged(object sender, EventArgs e)
        {
            domUDSfId.BackColor = Color.White;

            if(changeTextBoxes())
            {
                btnCheck_Click(sender, e);
                this.doControlExist = true;
            }
            else
            {
                this.doControlExist = false;
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            SemiFinished semiFinished = db.SemiFinisheds.FirstOrDefault(sf => sf.IdSemiFinished.ToString() == domUDSfId.Text);

            // var bo to typ anonimowy
            var quantity = db.EntranceControls.Join(db.SfOrderDetails, ec => ec.IdSfDetail, order => order.IdSfDetail,
                (ec, order) => new { ec.Quantity }).FirstOrDefault();

            if (semiFinished == null)
            {
                MessageBox.Show("Wybierz zamówienie i półfabrykat!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(txtboxThickness.Text != "")
                {
                    picBoxThicknessStatus.Image =
                        semiFinished.Thickness * 0.95 < double.Parse(txtboxThickness.Text) &&
                        double.Parse(txtboxThickness.Text) < semiFinished.Thickness * 1.05 ?
                        Properties.Resources.ok_48px :
                        Properties.Resources.cancel_48px;
                }
                    
                if(txtboxWidth.Text != "")
                {
                    picBoxWidhtStatus.Image =
                        semiFinished.Width * 0.95 < double.Parse(txtboxWidth.Text) &&
                        double.Parse(txtboxWidth.Text) < semiFinished.Width * 1.05 ?
                        Properties.Resources.ok_48px :
                        Properties.Resources.cancel_48px;
                }
                    
                if(txtboxMass.Text != "")
                {
                    picBoxMassStatus.Image =
                        semiFinished.SfWeight * 0.95 < double.Parse(txtboxMass.Text) &&
                        double.Parse(txtboxMass.Text) < semiFinished.SfWeight * 1.05 ?
                        Properties.Resources.ok_48px :
                        Properties.Resources.cancel_48px;
                }
                    
                if(txtBoxColor.Text != "")
                {
                    picBoxColorStatus.Image = semiFinished.Color.Equals(txtBoxColor.Text) ?
                        Properties.Resources.ok_48px :
                        Properties.Resources.cancel_48px;
                }
                    
                if(txtBoxQuantity.Text != "")
                {
                    picBoxQuantityStatus.Image = quantity.ToString().Equals(txtBoxQuantity.Text) ?
                        Properties.Resources.ok_48px :
                        Properties.Resources.cancel_48px;
                }
            }
        }

        private void resetAllCheckedPicBox()
        {
            picBoxThicknessStatus.Image = Properties.Resources.help_40px;
            picBoxWidhtStatus.Image = Properties.Resources.help_40px;
            picBoxMassStatus.Image = Properties.Resources.help_40px;
            picBoxColorStatus.Image = Properties.Resources.help_40px;
            picBoxQuantityStatus.Image = Properties.Resources.help_40px;
        }

        private void btnApproval_Click(object sender, EventArgs e)
        {
            if(domUDOrderId.Text == "")
            {
                MessageBox.Show("Wybierz zamówienie i półfabrykat!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(this.doControlExist)
            {
                MessageBox.Show("Ta kontrola już istnieje w bazie!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(domUDOrderId.Text == "" || domUDSfId.Text == "" || textBoxEmployeeId.Text == "" || txtboxThickness.Text == ""
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
    }
}
