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
        private RoofingCompanyEntities db;
        private OutsourcingForm previousForm;
        public AddNewOutsourcingCompanyForm(RoofingCompanyEntities db, OutsourcingForm form)
        {
            InitializeComponent();
            this.db = db;
            this.previousForm = form;
        }
        private void returnANOFBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            previousForm.Show();
            this.Close();
        }
        private void addNewOutsourcingCompanyBtn_Click(object sender, EventArgs e)
        {
            if (nameTb.Text.Trim() == "")
            {
                MessageBox.Show("Nazwa jest wymagana");
                return;
            }
            Outsourcing newOutsourcing = new Outsourcing();
            OutsourcingType newOutsourcingType = new OutsourcingType();

            newOutsourcing.CompanyName = nameTb.Text.Trim();
            bool phoneTextBox = int.TryParse(phoneTb.Text.Trim(), out int phoneTextbox);
            if (phoneTextBox)
            {
                newOutsourcing.PhoneNumber = Convert.ToString(phoneTextbox);
            }
            newOutsourcing.Email = emailTb.Text.Trim();
            newOutsourcing.City = cityTb.Text.Trim();
            newOutsourcing.ZipCode = zipCodeTb.Text.Trim();
            newOutsourcing.Street = streetTb.Text.Trim();

            bool houseNumberTextBox = int.TryParse(houseNumberTb.Text.Trim(), out int houseNumberTextbox);
            if (houseNumberTextBox)
            {
                newOutsourcing.HouseNumber = Convert.ToString(houseNumberTextbox);
            }
            else
            {
                MessageBox.Show("Niewłaściwy format numeru domu");
                return;
            }
            bool apartmentNumberTextBox = int.TryParse(apartmentNumberTb.Text.Trim(), out int apartmentNumberTextbox);
            if (apartmentNumberTextBox)
            {
                newOutsourcing.ApartmentNumber = Convert.ToString(apartmentNumberTextbox);
            }
            else
            {
                MessageBox.Show("Niewłaściwy format numeru lokalu");
                return;
            }
            bool nipTextBox = float.TryParse(nipTb.Text.Trim(), out float nipTextbox);
            if (nipTextBox)
            {
                newOutsourcing.NIP = Convert.ToString(nipTextbox);
            }
            else
            {
                MessageBox.Show("Niewłaściwy format NIP");
                return;
            }
            bool krsTextBox = float.TryParse(krsTb.Text.Trim(), out float krsTextbox);
            if (krsTextBox)
            {
                newOutsourcing.KRS = Convert.ToString(krsTextbox);
            }
            else
            {
                MessageBox.Show("Niewłaściwy format KRS");
                return;
            }
            MessageBox.Show("Czy na pewno chcesz dodać nową fimrę outsourcingową?");
            db.Outsourcings.Add(newOutsourcing);
            db.OutsourcingTypes.Add(newOutsourcingType);
            db.SaveChanges();
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
