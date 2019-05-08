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
            Supplier newSupplier = new Supplier();
            if (comboBoxSupplierType.SelectedIndex == -1)
            {
                MessageBox.Show("Nie wybrano typu dostawcy");
                comboBoxSupplierType.BackColor = Color.Red;
                return;
            }
            else
            {
                foreach (SupplierType type in db.SupplierTypes.Where(type => type.SupplierNameType.Contains(comboBoxSupplierType.Text.ToString())))
                {
                    newSupplier.IdSupplierType = type.IdSupplierType;
                }
            }
                if (nameTb.Text.Trim() == "")
            {
                MessageBox.Show("Nazwa jest wymagana");
                nameTb.BackColor = Color.Red;
                return;
            }
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
            newSupplier.SupplierDescription = descriptionTb.Text.Trim();

            bool houseNumberTextBox = int.TryParse(houseNumberTb.Text.Trim(), out int houseNumberTextbox);
            if (houseNumberTextBox)
            {
                newSupplier.HouseNumber = Convert.ToString(houseNumberTextbox);
            }
            else
            {
                MessageBox.Show("Niewłaściwy format numeru domu");
                houseNumberTb.BackColor = Color.Red;
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
                apartmentNumberTb.BackColor = Color.Red;
                return;
            }
            bool nipTextBox = long.TryParse(nipTb.Text.Trim(), out long nipTextbox);
            if (nipTextBox)
            {
                newSupplier.NIP = Convert.ToString(nipTextbox);
            }
            else
            {
                MessageBox.Show("Niewłaściwy format NIP");
                nipTb.BackColor = Color.Red;
                return;
            }
            bool krsTextBox = long.TryParse(krsTb.Text.Trim(), out long krsTextbox);
            if (krsTextBox)
            {
                newSupplier.KRS = Convert.ToString(krsTextbox);
            }
            else
            {
                MessageBox.Show("Niewłaściwy format KRS");
                krsTb.BackColor = Color.Red;
                return;
            }
            db.Suppliers.Add(newSupplier);
            db.SaveChanges();
            MessageBox.Show("Dodano dostawcę");
        }
       

        private void buttonAddNewSupplier_Click_1(object sender, EventArgs e)
        {
            string typ = textBoxAddNewTypeSupplier.Text;
            comboBoxSupplierType.BeginUpdate();
            comboBoxSupplierType.Items.Add(typ);
            comboBoxSupplierType.EndUpdate();
            SupplierType newsupplierType = new SupplierType();
            newsupplierType.SupplierNameType = typ;
            db.SupplierTypes.Add(newsupplierType);
            db.SaveChanges();
        }

        private void AddNewSupplierForm_Load(object sender, EventArgs e)
        {
                List<SupplierType> supplierList = db.SupplierTypes.ToList();
                comboBoxSupplierType.BeginUpdate();

                foreach (SupplierType emp in supplierList)
                {
                    comboBoxSupplierType.Items.Add(emp.SupplierNameType);
                }
                comboBoxSupplierType.EndUpdate();
        }
    }
}
