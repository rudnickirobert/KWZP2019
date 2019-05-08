﻿using System;
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
            newEmployee
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
            int lenght1 = db.Employees.Where(editEmployeeWhere => editEmployeeWhere.IdEmployee.Equals(id)).Select(editEmployeeSelect => new { editEmployeeSelect.EmployeeName }).First().ToString().Length -1;
            int lenght2 = db.Employees.Where(editEmployeeWhere => editEmployeeWhere.IdEmployee.Equals(id)).Select(editEmployeeSelect => new { editEmployeeSelect.EmployeeSurname }).First().ToString().Length -1;
            int lenght3 = db.Employees.Where(editEmployeeWhere => editEmployeeWhere.IdEmployee.Equals(id)).Select(editEmployeeSelect => new { editEmployeeSelect.ZipCode }).First().ToString().Length -1;
            int lenght4 = db.Employees.Where(editEmployeeWhere => editEmployeeWhere.IdEmployee.Equals(id)).Select(editEmployeeSelect => new { editEmployeeSelect.City }).First().ToString().Length -1;
            int lenght5 = db.Employees.Where(editEmployeeWhere => editEmployeeWhere.IdEmployee.Equals(id)).Select(editEmployeeSelect => new { editEmployeeSelect.Street }).First().ToString().Length -1;
            int lenght6 = db.Employees.Where(editEmployeeWhere => editEmployeeWhere.IdEmployee.Equals(id)).Select(editEmployeeSelect => new { editEmployeeSelect.HouseNumber }).First().ToString().Length -1;
            int lenght7 = db.Employees.Where(editEmployeeWhere => editEmployeeWhere.IdEmployee.Equals(id)).Select(editEmployeeSelect => new { editEmployeeSelect.ApartmentNum }).First().ToString().Length -1;
            int lenght8 = db.Employees.Where(editEmployeeWhere => editEmployeeWhere.IdEmployee.Equals(id)).Select(editEmployeeSelect => new { editEmployeeSelect.PhoneNumber }).First().ToString().Length -1;
            int lenght9 = db.Employees.Where(editEmployeeWhere => editEmployeeWhere.IdEmployee.Equals(id)).Select(editEmployeeSelect => new { editEmployeeSelect.PESEL }).First().ToString().Length -1;

            tbFirstName.Text = db.Employees.Where(editEmployeeWhere => editEmployeeWhere.IdEmployee.Equals(id)).Select(editEmployeeSelect => new { editEmployeeSelect.EmployeeName}).First().ToString().Substring(17, lenght1 -17);
            tbLastName.Text = db.Employees.Where(editEmployeeWhere => editEmployeeWhere.IdEmployee.Equals(id)).Select(editEmployeeSelect => new { editEmployeeSelect.EmployeeSurname }).First().ToString().Substring(20, lenght2 -20);
            tbZipCode.Text = db.Employees.Where(editEmployeeWhere => editEmployeeWhere.IdEmployee.Equals(id)).Select(editEmployeeSelect => new { editEmployeeSelect.ZipCode }).First().ToString().Substring(12, lenght3 -12);
            tbCity.Text = db.Employees.Where(editEmployeeWhere => editEmployeeWhere.IdEmployee.Equals(id)).Select(editEmployeeSelect => new { editEmployeeSelect.City }).First().ToString().Substring(9, lenght4 -9);
            tbStreet.Text = db.Employees.Where(editEmployeeWhere => editEmployeeWhere.IdEmployee.Equals(id)).Select(editEmployeeSelect => new { editEmployeeSelect.Street }).First().ToString().Substring(11, lenght5 -11);
            tbHouseNumber.Text = db.Employees.Where(editEmployeeWhere => editEmployeeWhere.IdEmployee.Equals(id)).Select(editEmployeeSelect => new { editEmployeeSelect.HouseNumber }).First().ToString().Substring(16, lenght6 -16);
            tbApartmentNumber.Text = db.Employees.Where(editEmployeeWhere => editEmployeeWhere.IdEmployee.Equals(id)).Select(editEmployeeSelect => new { editEmployeeSelect.ApartmentNum }).First().ToString().Substring(17, lenght7 -17);
            tbPhoneNumber.Text = db.Employees.Where(editEmployeeWhere => editEmployeeWhere.IdEmployee.Equals(id)).Select(editEmployeeSelect => new { editEmployeeSelect.PhoneNumber }).First().ToString().Substring(16, lenght8 -16);
            tbPESEL.Text = db.Employees.Where(editEmployeeWhere => editEmployeeWhere.IdEmployee.Equals(id)).Select(editEmployeeSelect => new { editEmployeeSelect.PESEL }).First().ToString().Substring(10, lenght9 -10);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.startForm.Show();
            this.Hide();
        }
    }
}
