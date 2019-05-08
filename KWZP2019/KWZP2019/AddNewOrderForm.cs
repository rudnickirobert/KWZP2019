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
    public partial class AddNewOrderForm : Form

    {
        private RoofingCompanyEntities db;
        private SalesDepartmentForm salesForm;
        private String customerName;
        bool isMarkupCorrect = true;
        public AddNewOrderForm(RoofingCompanyEntities db, object customerDgvCell1, SalesDepartmentForm salesForm)
        {
            InitializeComponent();
            this.db = db;
            this.salesForm = salesForm;
            customerName = customerDgvCell1.ToString();
            this.customerNameTb.Text = customerName;
        }
        private void AddNewOrderForm_Load(object sender, EventArgs e)
        {//INSERTS EMPLOYEES TO COMBOBOX
            markupTb.BackColor = Color.LightGreen;
            List<vEmployeeSD> employeeList = db.vEmployeeSDs.ToList();
            employeeCb.BeginUpdate();
            foreach (vEmployeeSD emp in employeeList)
            {
                employeeCb.Items.Add(emp.Imię + " " + emp.Nazwisko);
            }
            employeeCb.EndUpdate();
        }//MARKUP INSERT PROTECTION
        private void markupTb_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(markupTb.Text.Trim(), out double isMarkupValueDouble))
            {
                if (double.Parse(markupTb.Text.Trim()) < 0 && double.Parse(markupTb.Text.Trim()) > 1)
                {
                    markupTb.BackColor = Color.Red;
                    MessageBox.Show("Wprowadź poprawną wartość");
                    isMarkupCorrect = false;
                }
                else if (double.Parse(markupTb.Text.Trim()) < 0.3)
                {
                    markupTb.BackColor = Color.Yellow;
                    markupInfoLbl.Text = "Poniżej preferowanej";
                    isMarkupCorrect = true;
                    
                }
                else if (double.Parse(markupTb.Text.Trim()) == 0.3)
                {
                    markupTb.BackColor = Color.LightGreen;
                    markupInfoLbl.Text = "Preferowana";
                    isMarkupCorrect = true;
                }
                else
                {
                    markupTb.BackColor = Color.LightGreen;
                    markupInfoLbl.Text = "Powyżej preferowanej";
                    isMarkupCorrect = true;
                }
            }
            else
            {
                markupTb.BackColor = Color.Red;
                MessageBox.Show("Możesz wprowadzić tylko liczby");
                isMarkupCorrect = false;
            }

        }

        //BUTTONS      
        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerForm customerForm = new CustomerForm(db, salesForm);
            customerForm.ShowDialog();
            this.Close();
        }               
        private void acceptBtn_Click(object sender, EventArgs e)
        {
            OrderCustomer newOrderCustomer = new OrderCustomer();
            //IdCustomer
            foreach (Customer cust in db.Customers)
            {
                if (cust.CustomerName == customerName)
                {
                    newOrderCustomer.IdCustomer = cust.IdCustomer;
                }
            }
            //IdEmployee
            if (employeeCb.SelectedIndex == -1)
            {
                MessageBox.Show("Nie wybrano pracownika");
                employeeCb.BackColor = Color.Red;
                return;
            }
            else
            {
                foreach (Employee emp in db.Employees)
                {
                    if ((emp.EmployeeName + " " + emp.EmployeeSurname).ToString() == employeeCb.Text.ToString())
                    {
                        newOrderCustomer.IdEmployee = emp.IdEmployee;
                    }
                }
            }
            //OrderDate
            if (orderDtp.Value.ToShortDateString() == DateTime.Today.ToShortDateString())
            {
                MessageBox.Show("Wybrano dzisiejszą datę");
                orderDtp.CalendarTitleForeColor = Color.Red;
                return;
            }
            else
            {
                newOrderCustomer.OrderDate = orderDtp.Value;
            }
            if (isMarkupCorrect)
            {
                newOrderCustomer.Markup = double.Parse(markupTb.Text.Trim());
                newOrderCustomer.Cost = 0;
                db.OrderCustomers.Add(newOrderCustomer);
                db.SaveChanges();
                this.Hide();
                MessageBox.Show("Dodaj szczegół zamówienia");
                AddNewOrderDetailForm newOrderDetail = new AddNewOrderDetailForm(db, newOrderCustomer.IdOrderCustomer, salesForm);
                newOrderDetail.ShowDialog();
                this.Close();
                return;
            }
            MessageBox.Show("Coś poszło nie tak");
        }
    }
}
