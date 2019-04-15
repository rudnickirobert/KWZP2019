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
    public partial class OrderForm : Form
    {
        OutsourcingForm outsourcingForm = new OutsourcingForm();
        WarehouseForm warehouseForm = new WarehouseForm();
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OF_WyszukajZamowienie_btn_Click(object sender, EventArgs e)
        {
            WyszukajZamowienie_gb.Visible = true;
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          SzczegolyZamowienia_gb.Visible = true;
           
        }

        private void StanMagazynowy_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            warehouseForm.ShowDialog();
            this.Close();
           
        }

        private void TransportdoKlienta_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            outsourcingForm.ShowDialog();
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void WyszukajZamowienie_gb_Enter(object sender, EventArgs e)
        {

        }

        private void OF_DodajZamowienie_btn_Click(object sender, EventArgs e)
        {
            Dodajzamowienie_gb.Visible = true; 
        }

        private void Szczegolynowegozamowienia_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
