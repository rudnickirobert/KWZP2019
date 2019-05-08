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
    public partial class EditEmployee : Form
    {
        RoofingCompanyEntities db;
        StartForm startForm;
        HR hr;
        int id;
        public EditEmployee(RoofingCompanyEntities db, StartForm startForm, HR hr, int id)
        {
            InitializeComponent();
            this.db = db;
            this.startForm = startForm;
            this.hr = hr;
            this.id = id;
        }

        void clear()
        {
            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbZipCode.Text = "";
            tbCity.Text = "";
            tbStreet.Text = "";
            tbHouseNumber.Text = "";
            tbApartmentNumber.Text = "";
            tbPhoneNumber.Text = "";
            tbPESEL.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Employee newEmployee = db.Employees.First(employeeModifying => employeeModifying.IdEmployee == id);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbFirstName.Text.Trim() == "" || tbLastName.Text.Trim() == "" || tbPESEL.Text.Trim() == "")
            {
                MessageBox.Show("Imię, nazwisko oraz PESEL są wymagane");
            }
            else
            {
                bool numbersInTbPESEL = long.TryParse(tbPESEL.Text.Trim(), out long number);
                bool numbersInTbPhoneNum = long.TryParse(tbPhoneNumber.Text.Trim(), out long number1);
                if (numbersInTbPESEL == false || numbersInTbPhoneNum == false)
                {
                    MessageBox.Show("W polach Numer telefonu i PESEL muszą znajdować się wyłącznie cyfry");
                }
                else
                {
                    if (tbPESEL.Text.Trim().Length != 11 || tbPhoneNumber.Text.Trim().Length != 9)
                    {
                        MessageBox.Show("Numer telefonu musi składać się z 9 cyfr a PESEL z 11");
                    }
                    else
                    {
                        Employee newEmployee = db.Employees.First(employeeModifying => employeeModifying.IdEmployee == id);
                        newEmployee.EmployeeName = tbFirstName.Text.Trim();
                        newEmployee.EmployeeSurname = tbLastName.Text.Trim();
                        newEmployee.ZipCode = tbZipCode.Text.Trim();
                        newEmployee.City = tbCity.Text.Trim();
                        newEmployee.Street = tbStreet.Text.Trim();
                        newEmployee.HouseNumber = tbHouseNumber.Text.Trim();
                        newEmployee.ApartmentNum = tbApartmentNumber.Text.Trim();
                        newEmployee.PhoneNumber = tbPhoneNumber.Text.Trim();
                        newEmployee.PESEL = tbPESEL.Text.Trim();
                        db.SaveChanges();
                        MessageBox.Show("Zmieniono dane pracownika");
                        clear();
                        this.Close();
                        hr.Show();
                    }
                }
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.hr.Show();
            this.Hide();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            fill();
        }

        void fill()
        {
            Employee employee = db.Employees.First(employeeModifying => employeeModifying.IdEmployee == id);
            tbLastName.Text = employee.EmployeeSurname.ToString();
            tbFirstName.Text = employee.EmployeeName.ToString();
            if (employee.ZipCode == null)
                tbZipCode.Text = "";
            else
                tbZipCode.Text = employee.ZipCode.ToString();
            if (employee.City == null)
                tbCity.Text = "";
            else
                tbCity.Text = employee.City.ToString();
            if (employee.Street == null)
                tbStreet.Text = "";
            else
                tbStreet.Text = employee.Street.ToString();
            if (employee.HouseNumber == null)
                tbHouseNumber.Text = "";
            else
                tbHouseNumber.Text = employee.HouseNumber.ToString();
            if (employee.ApartmentNum == null)
                tbApartmentNumber.Text = "";
            else
                tbApartmentNumber.Text = employee.ApartmentNum.ToString();
            if (employee.PhoneNumber == null)
                tbPhoneNumber.Text = "";
            else
                tbPhoneNumber.Text = employee.PhoneNumber.ToString();
            if (employee.PESEL == null)
                tbPESEL.Text = "";
            else
                tbPESEL.Text = employee.PESEL.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.startForm.Show();
            this.Hide();
        }
    }
}
