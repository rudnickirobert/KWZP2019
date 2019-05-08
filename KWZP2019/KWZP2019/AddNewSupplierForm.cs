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
        private RoofingCompanyEntities db;
        private SupplierForm previousForm;
        public AddNewSupplierForm(RoofingCompanyEntities db, SupplierForm form)
        {
            InitializeComponent();
            this.db = db;
            this.previousForm = form;
        }
        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            previousForm.Show();
            this.Close();
        }
        private void addNewSupplierBtn_Click(object sender, EventArgs e)
        {
            if (nameTb.Text.Trim() == "")
            {
                MessageBox.Show("Nazwa jest wymagana");
                return;
            }
            Supplier newSupplier = new Supplier();
            SupplierType newsupplierType = new SupplierType();
            newSupplier.SupplierName = nameTb.Text.Trim();
            bool phoneTextBox = int.TryParse(phoneTb.Text.Trim(), out int phoneTextbox);
            if (phoneTextBox)
            {
                newSupplier.PhoneNumber = Convert.ToString(phoneTextbox);
            }
            newSupplier.Email = emailTb.Text.Trim();
            newSupplier.City = cityTb.Text.Trim();
            newSupplier.ZipCode = zipCodeTb.Text.Trim();
            newSupplier.Street = streetTb.Text.Trim();

            bool houseNumberTextBox = int.TryParse(houseNumberTb.Text.Trim(), out int houseNumberTextbox);
            if (houseNumberTextBox)
            {
                newSupplier.HouseNumber = Convert.ToString(houseNumberTextbox);
            }
            else
            {
                MessageBox.Show("Niewłaściwy format numeru domu");
                return;
            }
            bool apartmentNumberTextBox = int.TryParse(apartmentNumberTb.Text.Trim(), out int apartmentNumberTextbox);
            if (apartmentNumberTextBox)
            {
                newSupplier.ApartmentNumber = Convert.ToString(apartmentNumberTextbox);
            }
            else
            {
                MessageBox.Show("Niewłaściwy format numeru lokalu");
                return;
            }
            bool nipTextBox = float.TryParse(nipTb.Text.Trim(), out float nipTextbox);
            if (nipTextBox)
            {
                newSupplier.NIP = Convert.ToString(nipTextbox);
            }
            else
            {
                MessageBox.Show("Niewłaściwy format NIP");
                return;
            }
            bool krsTextBox = float.TryParse(krsTb.Text.Trim(), out float krsTextbox);
            if (krsTextBox)
            {
                newSupplier.KRS = Convert.ToString(krsTextbox);
            }
            else
            {
                MessageBox.Show("Niewłaściwy format KRS");
                return;
            }
            newSupplier.SupplierDescription = descriptionTb.Text.Trim();
            MessageBox.Show("Czy na pewno chcesz dodać nowego dostawcę?");
            db.Suppliers.Add(newSupplier);
            db.SupplierTypes.Add(newsupplierType);
            db.SaveChanges();
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
