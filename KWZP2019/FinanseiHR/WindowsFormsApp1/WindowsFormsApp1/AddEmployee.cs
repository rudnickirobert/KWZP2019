using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddEmployee : Form
    {

        public AddEmployee()
        {
            InitializeComponent();
            Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        void Clear()
        {
            textBoxFirstName.Text = textBoxLastName.Text = textBoxZipCode.Text = textBoxCity.Text
                = textBoxStreet.Text = textBoxHouseNumber.Text = textBoxApartmentNumber.Text
                = textBoxPhoneNumber.Text = textBoxPESEL.Text ="";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text.Trim() == "" || textBoxLastName.Text.Trim() == "")
            {
                MessageBox.Show("First Name and Last Name are required");
            }
            else
            {
            /*    Employee newEmployee = new Employee();
                newEmployee.EmployeeName = textBoxFirstName.Text.Trim();
                newEmployee.EmployeeSurname = textBoxLastName.Text.Trim();
                newEmployee.ZipCode = textBoxZipCode.Text.Trim();
                newEmployee.City = textBoxCity.Text.Trim();
                newEmployee.Street = textBoxStreet.Text.Trim();
                newEmployee.HouseNumber = textBoxHouseNumber.Text.Trim();
                newEmployee.ApartmentNum = textBoxApartmentNumber.Text.Trim();
                newEmployee.PhoneNumber = textBoxPhoneNumber.Text.Trim();
                //newEmployee.PESEL = textBoxPESEL.Text.Trim();*/
            
                /*Contract newContract = new Contract();
                if (textBoxLengthOfContract.Text.Trim() == "")
                {
                    newContract.StartDate = dateTimePicker2.Value
                }*/
            /*    db.Employee.Add(newEmployee);
                db.SaveChanges();
                Clear();
                MessageBox.Show("Employee has been added correctly");*/
            }
        }

    }
}
