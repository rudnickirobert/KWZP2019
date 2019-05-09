using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            costCountingAlgorithm();
            customersDgv.DataSource = db.vCustomers.ToList();
            customersDgv.Columns["Numer"].Visible = false;
        }
        private void costCountingAlgorithm()
        {
            foreach (OrderCustomer order in db.OrderCustomers)
            {
                double temporaryCost = 0;
                foreach (OrderDetail detail in db.OrderDetails.Where(detail => detail.IdOrderCustomer == order.IdOrderCustomer))
                {
                    double detailCost = 0;
                    double pricePerMeter = 0;
                    foreach (TechnicalProductData productData in db.TechnicalProductDatas.Where(productData => productData.IdProduct == detail.IdProduct))
                    {
                        pricePerMeter = productData.PricePerMeter;
                        break;
                    }
                    detailCost = detail.Quantity * pricePerMeter;
                    temporaryCost = temporaryCost + detailCost;
                }
                order.Cost = Convert.ToDecimal(temporaryCost * (1 + order.Markup));
            }
        }
        //BUTTONS  
        private void orderBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddNewOrderForm addNewOrderForm = new AddNewOrderForm(db, this.customersDgv.CurrentRow.Cells[1].Value, previousForm);
            addNewOrderForm.ShowDialog();
            this.Close();
        }
        private void warehouseBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            WarehouseForm warehouseForm = new WarehouseForm(db, previousForm, this);
            warehouseForm.ShowDialog();
        }
        private void deleteOrderDetailBtn_Click(object sender, EventArgs e)
        {
            int idDetailToRemove = Convert.ToInt32(this.orderDetailsDgv.CurrentRow.Cells["IdDetail"].Value);
            string messageDuringRemovingDetail = "Usunięto szczegół o numerze: " + Convert.ToString(idDetailToRemove);
            MessageBox.Show(messageDuringRemovingDetail, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OrderDetail detailToRemove = db.OrderDetails.First(f => f.IdDetail == idDetailToRemove);
            db.OrderDetails.Remove(detailToRemove);
            db.SaveChanges();
            int idCustomer = Convert.ToInt32(ordersDgv.CurrentRow.Cells["Nr_zamówienia"].Value);
            orderDetailsDgv.DataSource = (from OrderDetail in db.vOrderDetails
                                          where OrderDetail.Nr_zamówienia == idCustomer
                                          select OrderDetail).ToList();
            orderDetailsDgv.Columns["Nr_zamówienia"].Visible = false;
            orderDetailsDgv.Columns["IdDetail"].Visible = false;
            orderDetailLbl.Text = "Szczegóły zamówienia nr: " + ordersDgv.CurrentRow.Cells["Nr_zamówienia"].Value.ToString();
        }
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
                AddNewOrderDetailForm newOrderDetail = new AddNewOrderDetailForm(db, this.ordersDgv.CurrentRow.Cells[0].Value, previousForm);
                newOrderDetail.ShowDialog();
            }
        }
        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            previousForm.Show();
            this.Close();
        }
        private void addNewCustomerBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddNewCustomerForm newCustomer = new AddNewCustomerForm(db, previousForm);
            newCustomer.ShowDialog();
            this.Close();
        }
        //Metoda odświeżania klientów
        private void RefreshGridCustomer()
        {
            int saveRow = 0;
            if (customersDgv.Rows.Count > 0)

                saveRow = customersDgv.FirstDisplayedCell.RowIndex;
            RoofingCompanyEntities db = new RoofingCompanyEntities();
            customersDgv.DataSource = db.vCustomers.ToList();
            customersDgv.Columns["Numer"].Visible = false;

            if (saveRow != 0 && saveRow < customersDgv.Rows.Count)
                customersDgv.FirstDisplayedScrollingRowIndex = saveRow;

            // Odświeżenie dataGridView1 - OrderCustomer

            ordersDgv.DataSource = (from OrderCustomer in db.OrderCustomers
                                    where OrderCustomer.IdOrderCustomer == saveRow
                                    select OrderCustomer).ToList();
        }
        //WYSZUKIWANIE KLIENTA W BAZIE

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            if (searchTxt.Text.Trim().Length < 1)
            {
                //pobranie wszystkich danych, gdy pole zawiera mniej niż 1 znak
                customersDgv.DataSource = db.vCustomers.ToList();
                //customersDgv.Columns["Numer"].Visible = false;
            }
            else
            {
                customersDgv.DataSource = (from db in db.vCustomers
                                           where
                                            db.Nazwa.Contains(searchTxt.Text.Trim())
                                         || db.Miasto.Contains(searchTxt.Text.Trim())
                                           select db).ToList();
                customersDgv.Columns["Numer"].Visible = false;
            }
        }
        //PRZYPISYWANIE ZAMOWIENIA DO KLIENTA AKTUALNIE WYSZUKIWANEGO
        private void customersDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //zadeklarowanie zmiennej "id" typu int i ustalenie wartości na podstawie pierwszej [0] kolumny w customerDgv
            int id = Convert.ToInt32(this.customersDgv.CurrentRow.Cells["Numer"].Value);
            ordersDgv.DataSource = (from OrderCustomer in db.vOrders
                                    where OrderCustomer.IdCustomer == id
                                    select OrderCustomer).ToList();
            ordersDgv.Columns["IdCustomer"].Visible = false;
            orderLbl.Text = "Zamówienie klienta: " + this.customersDgv.CurrentRow.Cells["Nazwa"].Value.ToString();
        }
        private void ordersDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idCustomer = Convert.ToInt32(ordersDgv.CurrentRow.Cells["Nr_zamówienia"].Value);
            orderDetailsDgv.DataSource = (from OrderDetail in db.vOrderDetails
                                          where OrderDetail.Nr_zamówienia == idCustomer
                                          select OrderDetail).ToList();
            orderDetailsDgv.Columns["Nr_zamówienia"].Visible = false;
            orderDetailsDgv.Columns["IdDetail"].Visible = false;
            orderDetailLbl.Text = "Szczegóły zamówienia nr: " + ordersDgv.CurrentRow.Cells["Nr_zamówienia"].Value.ToString();
            //orderDetailsDgv.Columns[1].Visible = false;
        }
        //REPORT GENERATE ALGORITHM
        private void generateReportBtn_Click(object sender, EventArgs e)
        {
            PdfPCell cell;
            String customerName = "Klient";
            //EXCEPTION PROTECTION
            if (ordersDgv.SelectedCells.Count == 0)
            {
                MessageBox.Show("Wybierz zamówienie");
            }
            else
            {
                int idOrder = Convert.ToInt32(ordersDgv.CurrentRow.Cells[0].Value);
                PdfPTable pdfCustomerReport = new PdfPTable(3);
                pdfCustomerReport.DefaultCell.Padding = 3;
                pdfCustomerReport.WidthPercentage = 80;
                pdfCustomerReport.DefaultCell.BorderWidth = 1;

                foreach (Customer cust in db.Customers)
                {
                    if (cust.IdCustomer == Convert.ToInt32(ordersDgv.CurrentRow.Cells[1].Value))
                    {
                        customerName = cust.CustomerName;
                        cell = new PdfPCell(new Phrase("Klient: " + customerName, FontFactory.GetFont("Times New Roman", BaseFont.CP1257, false, 12, 1)));
                        pdfCustomerReport.AddCell(cell);
                    }

                }
                cell = new PdfPCell(new Phrase("Zamówienie nr: " + idOrder, FontFactory.GetFont("Times New Roman", BaseFont.CP1257, false, 12, 1)));
                pdfCustomerReport.AddCell(cell);
                cell = new PdfPCell(new Phrase("Koszt: " + ordersDgv.CurrentRow.Cells[3].Value + " zl", FontFactory.GetFont("Times New Roman", BaseFont.CP1257, false, 12, 1)));
                pdfCustomerReport.AddCell(cell);
                cell = new PdfPCell(new Phrase("Kod produktu:", FontFactory.GetFont("Times New Roman", BaseFont.CP1257, false, 12, 1)));
                pdfCustomerReport.AddCell(cell);
                cell = new PdfPCell(new Phrase("Wzór:", FontFactory.GetFont("Times New Roman", BaseFont.CP1257, false, 12, 1)));
                pdfCustomerReport.AddCell(cell);
                cell = new PdfPCell(new Phrase("Ilosc:", FontFactory.GetFont("Times New Roman", BaseFont.CP1257, false, 12, 1)));
                pdfCustomerReport.AddCell(cell);

                foreach (OrderDetail detail in db.OrderDetails.Where(detail => detail.IdOrderCustomer == idOrder))
                {
                        foreach (Product prod in db.Products.Where(prod => prod.IdProduct == detail.IdProduct))
                        {
                                pdfCustomerReport.AddCell(prod.ProductCode);
                                foreach (Technology tech in db.Technologies.Where(tech => tech.IdTechnology == prod.IdTechnology))
                                {
                                        pdfCustomerReport.AddCell(tech.TechnologyName);
                                }
                        }
                        pdfCustomerReport.AddCell(detail.Quantity.ToString());
                }


                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +"\\";
                if (!Directory.Exists(desktopPath))
                {
                    Directory.CreateDirectory(desktopPath);
                }
                using (FileStream stream = new FileStream(desktopPath + @customerName + " zam " + ordersDgv.CurrentRow.Cells[0].Value + ".pdf", FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(pdfCustomerReport);
                    pdfDoc.Close();
                    stream.Close();
                }
                MessageBox.Show("Pomyślnie wygenerowano raport.");
            }
        }
    }
}

