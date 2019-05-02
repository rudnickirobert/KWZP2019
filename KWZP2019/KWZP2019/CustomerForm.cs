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
        private RoofingCompanyEntities db;
        private SalesDepartmentForm previousForm;
        public CustomerForm(RoofingCompanyEntities db, SalesDepartmentForm previousForm)
        {
            InitializeComponent();
            this.db = db;
            this.previousForm = previousForm;
        }
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            //COST CALCULATION ALGORITHM
            foreach (OrderCustomer order in db.OrderCustomers)
            {
                double temporaryCost = 0;
                foreach (OrderDetail detail in db.OrderDetails)
                {
                    double detailCost = 0;
                    double pricePerMeter = 0;
                    foreach (TechnicalProductData productData in db.TechnicalProductDatas)
                    {
                        if (detail.IdProduct == productData.IdProduct)
                        {
                            pricePerMeter = productData.PricePerMeter;
                            break;
                        }
                    }
                    if (detail.IdOrderCustomer == order.IdOrderCustomer)
                    {
                        detailCost = detail.Quantity * pricePerMeter;
                        temporaryCost = temporaryCost + detailCost;
                    }
                }
                order.Cost = Convert.ToDecimal(temporaryCost * (1 + order.Markup));
            }//END OF ALGORITHM
            customersDgv.DataSource = db.Customers.ToList();
        }
        //BUTTONS   //ADD ORDER BUTTON
        private void orderBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddNewOrderForm addNewOrderForm = new AddNewOrderForm(db, this.customersDgv.CurrentRow.Cells[1].Value);
            addNewOrderForm.ShowDialog();
            this.Close();
        }           //ADD ORDER DETAIL BUTTON
        private void addNewOrderDetailBtn_Click(object sender, EventArgs e)
        {
            //EXCEPTION PROTECTION
            if (ordersDgv.SelectedCells.Count == 0)
            {
                MessageBox.Show("Wybierz zamówienie");
            }
            else
            {
                this.Hide();
                AddNewOrderDetailForm newOrderDetail = new AddNewOrderDetailForm(db, this.ordersDgv.CurrentRow.Cells[0].Value);
                newOrderDetail.ShowDialog();
            }
        }           //RETURN BUTTON
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesDepartmentForm salesDepartmentForm = new SalesDepartmentForm(db);
            salesDepartmentForm.Show();
            this.Close();
        }
        private void addNewCustomerBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddNewCustomerForm newCustomer = new AddNewCustomerForm(db);
            newCustomer.ShowDialog();
            RefreshGridCustomer();
            this.Close();
        }
        private void editCustomerBtn_Click(object sender, EventArgs e)
        {
            AddNewCustomerForm newCustomer = new AddNewCustomerForm(db);
            newCustomer.ShowDialog();
            RefreshGridCustomer();
        }
        //Metoda odświeżania klientów
        private void RefreshGridCustomer()
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
        private void customersDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //zadeklarowanie zmiennej "id" typu int i ustalenie wartości na podstawie pierwszej [0] kolumny w customerDgv
            int id = Convert.ToInt32(this.customersDgv.CurrentRow.Cells[0].Value);
            ordersDgv.DataSource = (from OrderCustomer in db.OrderCustomers
                                    where OrderCustomer.IdCustomer == id
                                    select OrderCustomer).ToList();
        }
        private void ordersDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idCustomer = Convert.ToInt32(ordersDgv.CurrentRow.Cells[0].Value);
            orderDetailsDgv.DataSource = (from OrderDetail in db.vOrderDetails
                                          where OrderDetail.IdOrderCustomer == idCustomer
                                          select OrderDetail).ToList();
            orderDetailsDgv.Columns[1].Visible = false;
        }
    }
}

