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
    public partial class finances : Form
    {
        public finances()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            salaries obecnosci = new salaries();
            obecnosci.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            salariessummary urlopy = new salariessummary();
            urlopy.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            costs faktury = new costs();
            faktury.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            profits kadry = new profits();
            kadry.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            allcosts wyplaty = new allcosts();
            wyplaty.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            addfvat raporty = new addfvat();
            raporty.ShowDialog();
        }
    }
}
