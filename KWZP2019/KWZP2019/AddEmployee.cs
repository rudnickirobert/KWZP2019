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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
            Clear();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }
        //Function which clears all text boxes
        void Clear()
        {
            tbFirstName.Text = tbLastName.Text = tbZipCode.Text = tbCity.Text
                = tbStreet.Text = tbHouseNumber.Text = tbApartmentNumber.Text
                = tbPhoneNumber.Text = tbPESEL.Text = tbContractLenght.Text = "";
        }
        //button which closes Add Employee form
        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        //button which clears text boxes, using function Clear()
        private void btClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        //button which adds values from text boxes to database
        private void btAdd_Click(object sender, EventArgs e)
        {
            if (tbFirstName.Text.Trim() == "" || tbLastName.Text.Trim() == "")
            {
                MessageBox.Show("First Name and Last Name are required");
            }
            Employee newEmployee = new Employee();
            newEmployee.EmployeeName = tbFirstName.Text.Trim();
            newEmployee.EmployeeSurname = tbLastName.Text.Trim();
            newEmployee.ZipCode = tbZipCode.Text.Trim();
            newEmployee.City = tbCity.Text.Trim();
            newEmployee.Street = tbStreet.Text.Trim();
            newEmployee.HouseNumber = tbHouseNumber.Text.Trim();
            newEmployee.ApartmentNum = tbApartmentNumber.Text.Trim();
            newEmployee.PhoneNumber = tbPhoneNumber.Text.Trim();
            newEmployee.PESEL = long.Parse(tbPESEL.Text.Trim());
            Contract newContract = new Contract();
            if (tbContractLenght.Text.Trim() == "")
            {
                //newContract.StartDate = dateTimePickerStartDate.Value();
                //newContract.EndDate = dateTimePickerEndDate.Value();
            }
            //newContract.StartDate = DateTime.Now();
            newContract.EndDate = DateTime.Now.AddMonths(int.Parse(tbContractLenght.Text));
            /*db.Employee.Add(newEmployee);
            db.SaveChanges();
            Clear();
            MessageBox.Show("Employee has been added correctly");*/
            
        }

        private void lblContractLenght_Click(object sender, EventArgs e)
        {

        }
    }
}
