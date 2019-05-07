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
            clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbFirstName.Text.Trim() == "" || tbLastName.Text.Trim() == "" || tbPESEL.Text.Trim() == "")
            {
                MessageBox.Show("Imię, nazwisko oraz PESEL są wymagane");
            }
            else
            {
                bool condition1 = long.TryParse(tbPESEL.Text.Trim(), out long number);
                bool condition2 = long.TryParse(tbPhoneNumber.Text.Trim(), out long number1);
                if (condition1 == false || condition2 == false)
                {
                    MessageBox.Show("W polach Numer telefonu i PESEL muszą znajdować się wyłącznie cyfry");
                }
                else
                {
                    if (tbPESEL.TextLength != 11 || tbPhoneNumber.TextLength != 9)
                    {
                        MessageBox.Show("Numer telefonu musi składać się z 9 cyfr a PESEL z 11");
                    }
                    else
                    {
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
                        db.Employees.Add(newEmployee);
                        db.SaveChanges();
                        clear();
                        MessageBox.Show("Prawidłowo wprowadzono pracownika");
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
            tbPESEL.MaxLength = 11;
            tbPhoneNumber.MaxLength = 9;
            fill();
        }

        void fill()
        {
            tbFirstName.Text = db.Employees.Where(editEmployeeWhere => editEmployeeWhere.IdEmployee.Equals(id)).Select(editEmployeeSelect => new { editEmployeeSelect.EmployeeSurname}).First().ToString().Substring(20, 8);
            tbLastName.Text = db.Employees.Where(editEmployeeWhere => editEmployeeWhere.IdEmployee.Equals(id)).Select(editEmployeeSelect => new { editEmployeeSelect.EmployeeName }).First().ToString();
            tbZipCode.Text = db.Employees.Where(editEmployeeWhere => editEmployeeWhere.IdEmployee.Equals(id)).Select(editEmployeeSelect => new { editEmployeeSelect.ZipCode }).First().ToString();
            tbCity.Text = db.Employees.Where(editEmployeeWhere => editEmployeeWhere.IdEmployee.Equals(id)).Select(editEmployeeSelect => new { editEmployeeSelect.City }).First().ToString();
            tbStreet.Text = db.Employees.Where(editEmployeeWhere => editEmployeeWhere.IdEmployee.Equals(id)).Select(editEmployeeSelect => new { editEmployeeSelect.Street }).First().ToString();
            tbHouseNumber.Text = db.Employees.Where(editEmployeeWhere => editEmployeeWhere.IdEmployee.Equals(id)).Select(editEmployeeSelect => new { editEmployeeSelect.HouseNumber }).First().ToString();
            tbApartmentNumber.Text = db.Employees.Where(editEmployeeWhere => editEmployeeWhere.IdEmployee.Equals(id)).Select(editEmployeeSelect => new { editEmployeeSelect.ApartmentNum }).First().ToString();
            tbPhoneNumber.Text = db.Employees.Where(editEmployeeWhere => editEmployeeWhere.IdEmployee.Equals(id)).Select(editEmployeeSelect => new { editEmployeeSelect.PhoneNumber }).First().ToString();
            tbPESEL.Text = db.Employees.Where(editEmployeeWhere => editEmployeeWhere.IdEmployee.Equals(id)).Select(editEmployeeSelect => new { editEmployeeSelect.PESEL }).First().ToString();
        }

    }
}
