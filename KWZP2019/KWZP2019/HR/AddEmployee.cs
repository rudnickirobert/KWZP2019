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
        RoofingCompanyEntities db;
        StartForm startForm;
        HR hr;
        public AddEmployee(RoofingCompanyEntities db, StartForm startForm, HR hr)
        {
            InitializeComponent();
            this.db = db;
            this.startForm = startForm;
            this.hr = hr;
            clear();
        }
     
        void clear()
        {
            tbFirstName.Text = "";
            tbLastName.Text =  "";
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
            {
                bool numbersInTbPESEL = long.TryParse(tbPESEL.Text.Trim(), out long number);
                bool numbersInTbPhoneNum = long.TryParse(tbPhoneNumber.Text.Trim(), out long number1);
                if (numbersInTbPESEL == false || numbersInTbPhoneNum == false)
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
                        newEmployee.PESEL = (tbPESEL.Text.Trim());
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
            clear();
        }
    }
}
