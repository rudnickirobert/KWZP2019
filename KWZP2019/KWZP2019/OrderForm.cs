﻿using System;
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
        public OrderForm()
        {
            InitializeComponent();
        }
        private void OF_WyszukajZamowienie_btn_Click(object sender, EventArgs e)
        {
            searchOrderGb.Visible = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
          orderDetailsGb.Visible = true;
        }
        private void StanMagazynowy_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            WarehouseForm warehouseForm = new WarehouseForm();
            warehouseForm.ShowDialog();
            this.Close();
        }
        private void TransportdoKlienta_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            OutsourcingForm outsourcingForm = new OutsourcingForm();
            outsourcingForm.ShowDialog();
            this.Close();
        }
        private void OF_DodajZamowienie_btn_Click(object sender, EventArgs e)
        {
            addOrderGb.Visible = true; 
        }
    }
}
