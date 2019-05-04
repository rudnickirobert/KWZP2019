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
            //ŻĄDANIE WPROWADZENIA NAZWY FIRMY 
            if (nameTb.Text.Trim() == "")
            {
                MessageBox.Show("Nazwa jest wymagana");
            }
            else
            {
                //UTWORZENIE NOWEGO OBIEKTU "customer"
                Customer newCustomer = new Customer();

                //WPRAOWDZENIE DANYCH DOTYCZĄCYCH KLIENTA
                newCustomer.CustomerName = nameTb.Text.Trim();
                newCustomer.Email = emailTb.Text.Trim();
                newCustomer.City = cityTb.Text.Trim();
                newCustomer.ZipCode = zipCodeTb.Text.Trim();
                newCustomer.Street = streetTb.Text.Trim();
                newCustomer.CustomerDescription = descriptionTb.Text.Trim();

                bool phoneTbBool = int.TryParse(phoneTb.Text, out int phoneTbParsed);
                if (phoneTbBool)
                {
                    newCustomer.PhoneNumber = phoneTbParsed;
                }
                else
                {
                    MessageBox.Show("Niewłaściwy format numeru telefonu");
                }
                bool houseNumberTbBool = int.TryParse(houseNumberTb.Text.Trim(), out int houseNumberTbParsed);
                if (houseNumberTbBool)
                {
                    newCustomer.HouseNumber = houseNumberTbParsed;
                }
                else
                {
                    MessageBox.Show("Niewłaściwy format numeru domu");
                }
                bool apartmentNumberTbBool = int.TryParse(apartmentNumberTb.Text.Trim(), out int apartmentNumberTbParsed);
                if (apartmentNumberTbBool)
                {
                    newCustomer.ApartmentNumber = apartmentNumberTbParsed;
                }
                else
                {
                    MessageBox.Show("Niewłaściwy format numeru lokalu");
                }
                bool nipTbBool = float.TryParse(nipTb.Text.Trim(), out float nipTbParsed);
                if (nipTbBool)
                {
                    newCustomer.NIP = nipTbParsed;
                }
                else
                {
                    MessageBox.Show("Niewłaściwy format NIP");
                }
                bool krsTbBool = float.TryParse(krsTb.Text.Trim(), out float krsTbParsed);
                if (krsTbBool)
                {
                    newCustomer.KRS = krsTbParsed;
                }
                else
                {
                    MessageBox.Show("Niewłaściwy format KRS");
                }
                bool peselTbBool = float.TryParse(peselTb.Text.Trim(), out float peselTbParsed);
                if (peselTbBool)
                {
                    newCustomer.Pesel = peselTbParsed;
                }
                else
                {
                    MessageBox.Show("Niewłaściwy format PESEL");
                }
                MessageBox.Show("Czy na pewno chcesz dodać nowego klienta?");
                db.Customers.Add(newCustomer);
            }
            db.SaveChanges();
        }

    }
}
