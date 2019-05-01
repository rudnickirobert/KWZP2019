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
            if (nameTb.Text.Trim() == "")
            {
                MessageBox.Show("Nazwa jest wymagana");
            }

            else
            {
                //UTWORZENIE NOWEGO OBIEKTU "customer"
                Outsourcing newOutsourcing = new Outsourcing();
                OutsourcingType newOutsourcingType = new OutsourcingType();

                //WPRAOWDZENIE DANYCH DOTYCZĄCYCH KLIENTA

                newOutsourcing.CompanyName = nameTb.Text.Trim();
                bool phoneTextBox = int.TryParse(phoneTb.Text.Trim(), out int phoneTextbox);
                if (phoneTextBox)
                {
                    newOutsourcing.PhoneNumber = phoneTextbox;
                }
               
                newOutsourcing.Email = emailTb.Text.Trim();
                newOutsourcing.City = cityTb.Text.Trim();
                newOutsourcing.ZipCode = zipCodeTb.Text.Trim();
                newOutsourcing.Street = streetTb.Text.Trim();

                bool houseNumberTextBox = int.TryParse(houseNumberTb.Text.Trim(), out int houseNumberTextbox);
                if (houseNumberTextBox)
                {
                    newOutsourcing.HouseNumber = houseNumberTextbox;
                }
                else
                {
                    MessageBox.Show("Niewłaściwy format numeru domu");
                }
                bool apartmentNumberTextBox = int.TryParse(apartmentNumberTb.Text.Trim(), out int apartmentNumberTextbox);
                if (apartmentNumberTextBox)
                {
                    newOutsourcing.ApartmentNumber = apartmentNumberTextbox;
                }
                else
                {
                    MessageBox.Show("Niewłaściwy format numeru lokalu");
                }
                bool nipTextBox = int.TryParse(nipTb.Text.Trim(), out int nipTextbox);
                if (nipTextBox)
                {
                    newOutsourcing.NIP = nipTextbox;
                }
                else
                {
                    MessageBox.Show("Niewłaściwy format NIP");
                }
                bool krsTextBox = int.TryParse(krsTb.Text.Trim(), out int krsTextbox);
                if (krsTextBox)
                {
                    newOutsourcing.KRS = krsTextbox;
                }
                else
                {
                    MessageBox.Show("Niewłaściwy format KRS");
                }
               
                MessageBox.Show("Czy na pewno chcesz dodać nową fimrę outsourcingową?");
                db.Outsourcings.Add(newOutsourcing);
                db.OutsourcingTypes.Add(newOutsourcingType);
                db.SaveChanges();
            }
        }
        private void AddNewOutsourcingCompanyForm_Load(object sender, EventArgs e)
        {
            List<OutsourcingType> outsourcingList = db.OutsourcingTypes.ToList();
            comboBoxOutsourcingType.BeginUpdate();

            foreach (OutsourcingType emp in outsourcingList)
            {
                comboBoxOutsourcingType.Items.Add(emp.OutsourcingType1);
            }
            comboBoxOutsourcingType.EndUpdate();
        }
        private void buttonAddTypeOutsourcing_Click(object sender, EventArgs e)
        {
            string typ = textBoxNewTypeOutsourcing.Text;
            comboBoxOutsourcingType.BeginUpdate();
            comboBoxOutsourcingType.Items.Add(typ);
            comboBoxOutsourcingType.EndUpdate();
        }
    }
}
