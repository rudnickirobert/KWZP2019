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
    public partial class AddNewCustomerForm : Form
    {
        private RoofingCompanyEntities db;
        private SalesDepartmentForm previousForm;
        public AddNewCustomerForm(RoofingCompanyEntities db, SalesDepartmentForm form)
        {
            InitializeComponent();
            this.db = db;
            this.previousForm = form;
        }
        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerForm customerForm = new CustomerForm(db, previousForm);
            customerForm.ShowDialog();
            this.Close();
        }
        private void addNewCustomerBtn_Click(object sender, EventArgs e)
        {
            //ŻĄDANIE WPROWADZENIA NAZWY FIRMY 
            if (nameTb.Text.Trim() == "")
            {
                MessageBox.Show("Nazwa jest wymagana");
                return;
            }
            Customer newCustomer = new Customer();
            newCustomer.CustomerName = nameTb.Text.Trim();
            bool phoneTb2 = int.TryParse(phoneTb.Text, out int phoneTb21);
            if (phoneTb2)
            {
                newCustomer.PhoneNumber = Convert.ToString(phoneTb21);
            }
            else
            {
                MessageBox.Show("Niewłaściwy format numeru telefonu");
                return;
            }
            newCustomer.Email = emailTb.Text.Trim();
            newCustomer.City = cityTb.Text.Trim();
            newCustomer.ZipCode = zipCodeTb.Text.Trim();
            newCustomer.Street = streetTb.Text.Trim();
            bool houseNumberTb2 = int.TryParse(houseNumberTb.Text.Trim(), out int houseNumberTb21);
            if (houseNumberTb2)
            {
                newCustomer.HouseNumber = Convert.ToString(houseNumberTb21);
            }
            else
            {
                MessageBox.Show("Niewłaściwy format numeru domu");
                return;
            }
            bool apartmentNumberTb2 = int.TryParse(apartmentNumberTb.Text.Trim(), out int apartmentNumberTb21);
            if (apartmentNumberTb2)
            {
                newCustomer.ApartmentNumber = Convert.ToString(apartmentNumberTb21);
            }
            else
            {
                MessageBox.Show("Niewłaściwy format numeru lokalu");
                return;
            }
            bool nipTb2 = float.TryParse(nipTb.Text.Trim(), out float nipTb21);
            if (nipTb2)
            {
                newCustomer.NIP = Convert.ToString(nipTb21);
            }
            else
            {
                MessageBox.Show("Niewłaściwy format NIP");
                return;
            }
            bool krsTb2 = float.TryParse(krsTb.Text.Trim(), out float krsTb21);
            if (krsTb2)
            {
                newCustomer.KRS = Convert.ToString(krsTb21);
            }
            else
            {
                MessageBox.Show("Niewłaściwy format KRS");
                return;
            }
            bool peselTb2 = float.TryParse(peselTb.Text.Trim(), out float peselTb21);
            if (peselTb2)
            {
                newCustomer.Pesel = Convert.ToString(peselTb21);
            }
            else
            {
                MessageBox.Show("Niewłaściwy format PESEL");
                return;
            }
            MessageBox.Show("Czy na pewno chcesz dodać nowego klienta?");
            db.Customers.Add(newCustomer);
            db.SaveChanges();
        }
    }
}
