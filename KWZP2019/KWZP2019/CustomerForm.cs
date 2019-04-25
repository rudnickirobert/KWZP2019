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
    public partial class CustomerForm : Form
        
    {
        RoofingCompanyEntities db;
        public CustomerForm(RoofingCompanyEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            customersDgv.DataSource = db.Customers.ToList();
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderForm orderForm = new OrderForm();
            orderForm.ShowDialog();
            this.Close();
        }

        private void addNewCustomerBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddNewCustomerForm newCustomer = new AddNewCustomerForm(db);
            newCustomer.ShowDialog();
            OdswiezGridCustomer();
            this.Close();
        }

        //PRZYCISKI
        private void saveBtn_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
        }

        private void endCutstomerFormBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void editCustomerBtn_Click(object sender, EventArgs e)
        {
            AddNewCustomerForm newCustomer = new AddNewCustomerForm(db);
            newCustomer.ShowDialog();
            OdswiezGridCustomer();
        }
        private void OdswiezGridCustomer()
        {
            int saveRow = 0;
            if (customersDgv.Rows.Count > 0)

                saveRow = customersDgv.FirstDisplayedCell.RowIndex;
                RoofingCompanyEntities db = new RoofingCompanyEntities();
                customersDgv.DataSource = db.Customers.ToList();

            if (saveRow != 0 && saveRow < customersDgv.Rows.Count)
                customersDgv.FirstDisplayedScrollingRowIndex = saveRow;

            // Odświeżenie dataGridView1 - OrderCustomer

            dataGridView1.DataSource = (from OrderCustomer in db.OrderCustomers
                                        where OrderCustomer.IdOrderCustomer == saveRow
                                        select OrderCustomer).ToList();

        }
        //WYSZUKIWANIE KLIENTA W BAZIE

        private void searchTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (searchTxt.Text.Trim().Length < 1)
            {
                //pobranie wszystkich danych, gdy pole zawiera mniej niż 1 znak
                customersDgv.DataSource = db.Customers.ToList();
            }
            else
            {
                customersDgv.DataSource = (from db in db.Customers
                                           where
                                            db.CustomerName.Contains(searchTxt.Text.Trim())
                                         || db.City.Contains(searchTxt.Text.Trim())
                                           select db).ToList();
            }

        }
        //PRZYPISYWANIE ZAMOWIENIA DO KLIENTA AKTUALNIE WYSZUKIWANEGO

        private void customerDvg_SelectionChanged(object sender, EventArgs e)
        {
            //zadeklarowanie zmiennej "id" typu int i ustalenie wartości na podstawie pierwszej [0] kolumny w customerDgv
            int id = Convert.ToInt32(this.customersDgv.CurrentRow.Cells[0].Value);

            dataGridView1.DataSource = (from OrderCustomer in db.OrderCustomers
                                        where OrderCustomer.IdCustomer == id
                                        select db).ToList();
        }

    }
}

