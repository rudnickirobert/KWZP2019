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

            // var bo nie wiem jaki typ zwraca join
            var doControlExist = db.EntranceControls.Join(db.SfOrderDetails, ec => ec.IdSfDetail, order => order.IdSfDetail,
                (ec, order) => new { order.IdSfOrder, order.IdSemiFinished, ec.RealThickness, ec.RealWidth, ec.RealWeight, ec.RealColor, ec.Quantity })
                .Where(order => order.IdSfOrder.ToString() == domUDOrderId.Text && order.IdSemiFinished.ToString() == domUDSfId.Text).FirstOrDefault();

            if(doControlExist == null)
            {
                lblControlNotExist.Text = "Brak kontroli\nw bazie!";
                txtboxThickness.Text = "";
                txtboxWidth.Text = "";
                txtboxMass.Text = "";
                txtBoxColor.Text = "";
                txtBoxQuantity.Text = "";
            }
            else
            {
                lblControlNotExist.Text = "";
                txtboxThickness.Text = doControlExist.RealThickness.ToString();
                txtboxWidth.Text = doControlExist.RealWidth.ToString();
                txtboxMass.Text = doControlExist.RealWeight.ToString();
                txtBoxColor.Text = doControlExist.RealColor.ToString();
                txtBoxQuantity.Text = doControlExist.Quantity.ToString();
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if(domUDOrderId.Text == "" || domUDSfId.Text == "" || textBoxEmployeeId.Text == "" || txtboxThickness.Text == ""
                || txtboxWidth.Text == "" || txtboxMass.Text == "" || txtBoxColor.Text == "" || txtBoxQuantity.Text == "")
            {
                MessageBox.Show("Proszę uzupełnić wszystkie pola", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if(domUDOrderId.Text == "")
                {
                    domUDOrderId.BackColor = Color.Red;
                }
                if(domUDSfId.Text == "")
                {
                    domUDSfId.BackColor = Color.Red;
                }
                if(textBoxEmployeeId.Text == "")
                {
                    textBoxEmployeeId.BackColor = Color.Red;
                }
                if(txtboxThickness.Text == "")
                {
                    txtboxThickness.BackColor = Color.Red;
                }
                if(txtboxWidth.Text == "")
                {
                    txtboxWidth.BackColor = Color.Red;
                }
                if(txtboxMass.Text == "")
                {
                    txtboxMass.BackColor = Color.Red;
                }
                if(txtBoxColor.Text == "")
                {
                    txtBoxColor.BackColor = Color.Red;
                }
                if(txtBoxQuantity.Text == "")
                {
                    txtBoxQuantity.BackColor = Color.Red;
                }
            }
            else
            {
                MessageBox.Show("Operacja udana!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtbox_TextChanged(object sender, EventArgs e)
        {
            (sender as TextBox).BackColor = Color.White;
        }

        private void domUDSfId_SelectedItemChanged(object sender, EventArgs e)
        {
            domUDSfId.BackColor = Color.White;
        }
    }
}
