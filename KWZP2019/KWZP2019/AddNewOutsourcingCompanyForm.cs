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
    public partial class AddNewOutsourcingCompanyForm : Form
    {
        RoofingCompanyEntities db;
        public AddNewOutsourcingCompanyForm(RoofingCompanyEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void returnANOFBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addNewOutsourcingCompanyBtn_Click(object sender, EventArgs e)
        {
            //ŻĄDANIE WPROWADZENIA NAZWY FIRMY 
            if (nameTb.Text.Trim() == "")  //|| typeTb.Text.Trim() == "")
            {
                MessageBox.Show("Nazwa i typ są wymagane");
            }

            else
            {
                //UTWORZENIE NOWEGO OBIEKTU "customer"
                Outsourcing newOutsourcing = new Outsourcing();

                //WPRAOWDZENIE DANYCH DOTYCZĄCYCH KLIENTA

                newOutsourcing.CompanyName = nameTb.Text.Trim();
                //newOutsourcing.OutsourcingType = typeTb.Text.Trim();
                bool phoneTb2 = int.TryParse(phoneTb.Text.Trim(), out int phoneTb21);
                if (phoneTb2)
                {
                    newOutsourcing.PhoneNumber = phoneTb21;
                }
               
                newOutsourcing.Email = emailTb.Text.Trim();
                newOutsourcing.City = cityTb.Text.Trim();
                newOutsourcing.ZipCode = zipCodeTb.Text.Trim();
                newOutsourcing.Street = streetTb.Text.Trim();

                bool houseNumberTb2 = int.TryParse(houseNumberTb.Text.Trim(), out int houseNumberTb21);
                if (houseNumberTb2)
                {
                    newOutsourcing.HouseNumber = houseNumberTb21;
                }

                else
                {
                    MessageBox.Show("Niewłaściwy format numeru domu");
                }
                bool apartmentNumberTb2 = int.TryParse(apartmentNumberTb.Text.Trim(), out int apartmentNumberTb21);
                if (apartmentNumberTb2)
                {
                    newOutsourcing.ApartmentNumber = apartmentNumberTb21;
                }
                else
                {
                    MessageBox.Show("Niewłaściwy format numeru lokalu");
                }
                bool nipTb2 = int.TryParse(nipTb.Text.Trim(), out int nipTb21);

                if (nipTb2)
                {
                    newOutsourcing.NIP = nipTb21;
                }
                else
                {
                    MessageBox.Show("Niewłaściwy format NIP");
                }
                bool krsTb2 = int.TryParse(krsTb.Text.Trim(), out int krsTb21);
                if (krsTb2)
                {
                    newOutsourcing.KRS = krsTb21;
                }
                else
                {
                    MessageBox.Show("Niewłaściwy format KRS");
                }
               
                MessageBox.Show("Czy na pewno chcesz dodać nową fimrę outsourcingową?");
                db.Outsourcings.Add(newOutsourcing);
                
            }
        
        }
    }
}
