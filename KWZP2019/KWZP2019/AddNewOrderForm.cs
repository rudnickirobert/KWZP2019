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
        private String customerName;
        public AddNewOrderForm(RoofingCompanyEntities db, object customerDgvCell1)
        {
            InitializeComponent();
            this.db = db;
            customerName = customerDgvCell1.ToString();
            this.customerNameTb.Text = customerName;
        }
        private void AddNewOrderForm_Load(object sender, EventArgs e)
        {
            List<Employee> employeeList = db.Employees.ToList();
            employeeCb.BeginUpdate();
            foreach (Employee emp in employeeList)
            {
                employeeCb.Items.Add(emp.EmployeeName + " " + emp.EmployeeSurname);
            }
            employeeCb.EndUpdate();
        }
        //BUTTONS       //Return
        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }               //Accept
        private void acceptBtn_Click(object sender, EventArgs e)
        {
            OrderCustomer newOrderCustomer = new OrderCustomer();
            foreach(Customer cust in db.Customers)
            {
                if (cust.CustomerName == customerName)
                {
                    newOrderCustomer.IdCustomer = cust.IdCustomer;
                }
            }
            foreach(Employee emp in db.Employees)
            {
                if ((emp.EmployeeName + " " + emp.EmployeeSurname).ToString() == employeeCb.Text.ToString())
                {
                    newOrderCustomer.IdEmployee = emp.IdEmployee;
                }
            }
            newOrderCustomer.OrderDate = orderDtp.Value;
            /*
            string stringVal = markupTb.Text.Trim();
            if (stringVal.Contains("."))
            {
                stringVal = stringVal.Replace(".", ",");
            }
            decimal decVal = System.Convert.ToDecimal(stringVal);
            double doubleVal = System.Convert.ToDouble(stringVal);
            float fVal = System.Convert.ToSingle(stringVal);
            int intVal = System.Convert.ToInt16(stringVal);*/
            int markup = int.Parse(markupTb.Text.Trim());
            newOrderCustomer.Markup = markup;
            newOrderCustomer.Cost = Decimal.Parse(priceTb.Text.Trim());

            db.OrderCustomers.Add(newOrderCustomer);
            db.SaveChanges();
                }
      
    }
}
