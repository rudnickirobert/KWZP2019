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
    public partial class OutsourcingForm : Form
    {
        AddNewOutsourcingCompanyForm addnewoutsourcingcompanyForm = new AddNewOutsourcingCompanyForm();
        public OutsourcingForm()
        {
            InitializeComponent();
        }

        private void OutsourcingForm_Load(object sender, EventArgs e)
        {

        }

        private void Transportdoklienta_rb_CheckedChanged(object sender, EventArgs e)
        {
            Nazwatransport_tb.Visible = true;
            Nazwatransport_lbl.Visible = true;
            Szczegolytransport_lbl.Visible = true;
            Szczegolytransport_lv.Visible = true;

            Nazwaodpady_lbl.Visible = false;
            Nazwaodpady_tb.Visible = false;
            Nazwareklama_lbl.Visible = false;
            Nazwareklama_tb.Visible = false;
            Szczegolyodpady_lbl.Visible = false;
            Szczegolyodpady_lv.Visible = false;
            Szczegolyreklama_lbl.Visible = false;
            Szczegolyreklama_lv.Visible = false;
            
        }

        private void Odpady_rb_CheckedChanged(object sender, EventArgs e)
        {
            Nazwaodpady_tb.Visible = true;
            Nazwaodpady_lbl.Visible = true;
            Szczegolyodpady_lbl.Visible = true;
            Szczegolyodpady_lv.Visible = true;

            Nazwatransport_lbl.Visible = false;
            Nazwatransport_tb.Visible = false;
            Nazwareklama_lbl.Visible = false;
            Nazwareklama_tb.Visible = false;
            Szczegolytransport_lbl.Visible = false;
            Szczegolytransport_lv.Visible = false;
            Szczegolyreklama_lbl.Visible = false;
            Szczegolyreklama_lv.Visible = false;
        }

        private void Reklama_rb_CheckedChanged(object sender, EventArgs e)
        {
            Nazwareklama_tb.Visible = true;
            Nazwareklama_lbl.Visible = true;
            Szczegolyreklama_lbl.Visible = true;
            Szczegolyreklama_lv.Visible = true;

            Nazwatransport_lbl.Visible = false;
            Nazwatransport_tb.Visible = false;
            Nazwaodpady_lbl.Visible = false;
            Nazwaodpady_tb.Visible = false;
            Szczegolytransport_lbl.Visible = false;
            Szczegolytransport_lv.Visible = false;
            Szczegolyodpady_lbl.Visible = false;
            Szczegolyodpady_lv.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Dodajfirmeoutsourcingowa_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            addnewoutsourcingcompanyForm.ShowDialog();
            this.Close();
        }
    }
}
