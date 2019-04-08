using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class financesandhr : Form
    {
        public financesandhr()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            finances finanse = new finances();
            finanse.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HumanResources humanresources = new HumanResources();
            humanresources.ShowDialog();
        }
    }
}
