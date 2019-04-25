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
    public partial class AddNewCustomerForm : Form
    {
        RoofingCompanyEntities db; 

        public AddNewCustomerForm(RoofingCompanyEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        

        private void returnBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addNewCustomerBtn_Click(object sender, EventArgs e)
        {
            //AddNewCustomerForm addCustomer = new AddNewCustomerForm(db);
            
            //ŻĄDANIE WPROWADZENIA NAZWY FIRMY 
            if (nameTb.Text.Trim() == "")
            {
                MessageBox.Show("Nazwa jest wymagana");
            }

            //UTWORZENIE NOWEGO OBIEKTU "customer"
            Customer newCustomer = new Customer();

            //WPRAOWDZENIE DANYCH DOTYCZĄCYCH KLIENTA

            newCustomer.CustomerName = nameTb.Text.Trim();
            //newCustomer.PhoneNumber = int.Parse(phoneTb.Text.Trim());
            newCustomer.Email = emailTb.Text.Trim();
            newCustomer.City = cityTb.Text.Trim();
            newCustomer.ZipCode = zipCodeTb.Text.Trim();
            newCustomer.Street = streetTb.Text.Trim();
            //newCustomer.HouseNumber = int.Parse(houseNumberTb.Text.Trim());
            //newCustomer.ApartmentNumber = int.Parse(apartmentNumberTb.Text.Trim());
            //newCustomer.NIP = float.Parse(nipTb.Text.Trim());
            //newCustomer.KRS = float.Parse(krsTb.Text.Trim());
            //newCustomer.Pesel = float.Parse(peselTb.Text.Trim());

            MessageBox.Show("Czy na pewno chcesz dodać nowego klienta?");
            db.Customers.Add(newCustomer);
            //db.SaveChanges();

        
        }
    }
}
