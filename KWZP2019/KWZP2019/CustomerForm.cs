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

        private void saveBtn_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
        }

        private void returnSalesFormBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void endCustomerFormBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void editCustomerBtn_Click(object sender, EventArgs e)
        {
            CustomerForm newCustomer = new CustomerForm(customersDgv);
            newCustomer.ShowDialog();
            OdswiezGridCustomer();
            //this.customersDgv.EditMode = DataGridViewEditMode.EditOnEnter;
            //AddNewCustomerForm newCustomer = new AddNewCustomerForm(db);
            //newCustomer.ShowDialog();
            //OdswiezGridCustomer();
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

            ordersDgv.DataSource = (from OrderCustomer in db.OrderCustomers
                                        where OrderCustomer.IdOrderCustomer == saveRow
                                        select OrderCustomer).ToList();

        }
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

        private void customersDgv_SelectionChanged(object sender, EventArgs e)
        {
            ////zadeklarowanie zmiennej "id" typu int i ustalenie wartości na podstawie pierwszej [0] kolumny w customerDgv
            //int id = Convert.ToInt32(this.customersDgv.CurrentRow.Cells[0].Value);

            //ordersDgv.DataSource = (from OrderCustomer in db.OrderCustomers
            //                        where OrderCustomer.IdCustomer == id
            //                        select OrderCustomer).ToList();
        }

        private void customersDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //zadeklarowanie zmiennej "id" typu int i ustalenie wartości na podstawie pierwszej [0] kolumny w customerDgv
             int id = Convert.ToInt32(this.customersDgv.CurrentRow.Cells[0].Value);

            ordersDgv.DataSource = (from OrderCustomer in db.OrderCustomers
                                    where OrderCustomer.IdCustomer == id
                                    select OrderCustomer).ToList();
        }
    
    }

}
