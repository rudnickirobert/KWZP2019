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
    public partial class AddNewSupplierForm : Form
    {
        RoofingCompanyEntities db;
        public AddNewSupplierForm(RoofingCompanyEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void buttonReturnAddNewwSupplier_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addNewSupplierBtn_Click(object sender, EventArgs e)
        {
            //ŻĄDANIE WPROWADZENIA NAZWY FIRMY 
            if (nameSupplierTb.Text.Trim() == "")
            {
                MessageBox.Show("Nazwa jest wymagana");
            }

            else
            {
                //UTWORZENIE NOWEGO OBIEKTU "supplier"
                Supplier newSupplier = new Supplier();
                SupplierType newsupplierType = new SupplierType();

                //WPRAOWDZENIE DANYCH DOTYCZĄCYCH Dostawcy

                newSupplier.SupplierName = nameSupplierTb.Text.Trim();
                bool phoneTextBox = int.TryParse(phoneSupplierTb.Text.Trim(), out int phoneTextbox);
                if (phoneTextBox)
                {
                    newSupplier.PhoneNumber = phoneTextbox;
                }

                newSupplier.Email = emailSupplierTb.Text.Trim();
                newSupplier.City = citySupplierTb.Text.Trim();
                newSupplier.ZipCode = zipCodeSupplierTb.Text.Trim();
                newSupplier.Street = streetSupplierTb.Text.Trim();

                bool houseNumberTextBox = int.TryParse(houseNumberSupplierTb.Text.Trim(), out int houseNumberTextbox);
                if (houseNumberTextBox)
                {
                    newSupplier.HouseNumber = houseNumberTextbox;
                }
                else
                {
                    MessageBox.Show("Niewłaściwy format numeru domu");
                }
                bool apartmentNumberTextBox = int.TryParse(apartmentNumberSupplierTb.Text.Trim(), out int apartmentNumberTextbox);
                if (apartmentNumberTextBox)
                {
                    newSupplier.ApartmentNumber = apartmentNumberTextbox;
                }
                else
                {
                    MessageBox.Show("Niewłaściwy format numeru lokalu");
                }
                bool nipTextBox = int.TryParse(nipSupplierTb.Text.Trim(), out int nipTextbox);
                if (nipTextBox)
                {
                    newSupplier.NIP = nipTextbox;
                }
                else
                {
                    MessageBox.Show("Niewłaściwy format NIP");
                }
                bool krsTextBox = int.TryParse(krsSupplierTb.Text.Trim(), out int krsTextbox);
                if (krsTextBox)
                {
                    newSupplier.KRS = krsTextbox;
                }
                else
                {
                    MessageBox.Show("Niewłaściwy format KRS");
                }
                newSupplier.Description = descriptionSupplierTb.Text.Trim();
                MessageBox.Show("Czy na pewno chcesz dodać nowego dostawcę?");
                db.Suppliers.Add(newSupplier);
                db.SupplierTypes.Add(newsupplierType);
                db.SaveChanges();
            }
        }

        private void buttonAddNewSupplier_Click(object sender, EventArgs e)
        {
            string typ = textBoxAddNewTypeSupplier.Text;
            comboBoxSupplierType.BeginUpdate();
            comboBoxSupplierType.Items.Add(typ);
            comboBoxSupplierType.EndUpdate();
        }

        private void AddNewSupplierForm_Load(object sender, EventArgs e)
        {
            List<SupplierType> supplierList = db.SupplierTypes.ToList();
            comboBoxSupplierType.BeginUpdate();

            foreach (SupplierType emp in supplierList)
            {
                comboBoxSupplierType.Items.Add(emp.Suppliers);
            }
            comboBoxSupplierType.EndUpdate();
        }
    }
}
