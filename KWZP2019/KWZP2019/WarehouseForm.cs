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
   
        private void outWarehouseBtn_Click(object sender, EventArgs e)
        {
            outWarehouseGb.Visible = true;
        }
        private void entranceWarehouseBtn_Click(object sender, EventArgs e)
        {
            entranceWarehouseGb.Visible = true;
        }
    }
}
