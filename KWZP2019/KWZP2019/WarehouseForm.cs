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
    public partial class WarehouseForm : Form
    {
        public WarehouseForm()
        {
            InitializeComponent();
        }
        private void Magazynwejściowy_btn_Click(object sender, EventArgs e)
        {
            entranceWarehouseGb.Visible = true;
        }
        private void Magazynwyjsciowy_btn_Click(object sender, EventArgs e)
        {
            outWarehouseGb.Visible = true;
        }
    }
}
