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
    public partial class ProductionTechnology : Form
    {
        private RoofingCompanyEntities db;
        private DataGridViewRow selectedRow;
        private int selectedId;
        private Technology technology;
        private int selectedRowIndex;

        public ProductionTechnology(RoofingCompanyEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void ProductionTechnology_Load(object sender, EventArgs e)
        {
            dataGVtechnology.DataSource = db.Technologies.ToList();
        }



        //===========================================================

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void dataGVtechnology_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedRow = dataGVtechnology.Rows[dataGVtechnology.SelectedCells[0].RowIndex];
            selectedRowIndex = selectedRow.Index;
            // TimePermeter nazywa się pole w tabeli Technology
            selectedId = (int)selectedRow.Cells[0].Value;
            technology = db.Technologies.Where(t => t.IdTechnology == selectedId).First();
        }
        //===========================================================
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(technology == null)
            {
                MessageBox.Show("Wybierz technologię", "Wiadomość", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                EditTechnology editTechnology = new EditTechnology(db, technology, this);
                editTechnology.Show();
                this.Hide();
            }
        }

        //===========================================================

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(technology != null)
            {
                db.Technologies.Remove(technology);
                db.SaveChanges();
                refreshDataGridView();
            }
         }
        //===========================================================
        public void refreshDataGridView()
        {
            dataGVtechnology.DataSource = db.Technologies.ToList();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            NewTechnology newTechnology = new NewTechnology(db, this);
            newTechnology.Show();
            this.Hide();
        }

        public void selectRow(int idNewTechnology)
        {
            int index = dataGVtechnology.Rows.Count;
            dataGVtechnology.Rows[index - 1].Selected = true;
        }
    }
}
