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
    public partial class DevelopmentHistoryForm : Form
    {
        private RoofingCompanyEntities db;
        private StartForm startForm;
        private DevelopmentForm developmentForm;
        private int selectedDevelopment;

        public DevelopmentHistoryForm(RoofingCompanyEntities db, StartForm startForm, DevelopmentForm developmentForm)
        {
            InitializeComponent();
            this.db = db;
            this.startForm = startForm;
            this.developmentForm = developmentForm;
        }

        private void DevelopmentHistoryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            developmentForm.Show();
        }

        private void DevelopmentHistoryForm_Load(object sender, EventArgs e)
        {
            List<FEMAnalysi> fEMAnalysisList = db.FEMAnalysis.ToList();
            foreach (FEMAnalysi fEMAnalysis in fEMAnalysisList)
            {
                domainUpDownDevelompentNumber.Items.Add(fEMAnalysis.IdFEMAnalysis);               
            }
        }

        private void domainUpDownDevelompentNumber_SelectedItemChanged(object sender, EventArgs e)
        {
            FEMAnalysi FEMAnalysi = db.FEMAnalysis.First(fEMA => fEMA.IdFEMAnalysis.ToString() == domainUpDownDevelompentNumber.Text);
            textBoxDevelopmentDate.Text = $"{FEMAnalysi.AnalysisDate}";
            textBoxEmployeeNumber.Text = $"{FEMAnalysi.IdEmployee}";
            textBoxDevelopmentDescription.Text = $"{FEMAnalysi.AnalysisResults}";
            Employee Employee = db.Employees.First(emp => emp.IdEmployee.ToString() == FEMAnalysi.IdEmployee.ToString());
            textBoxEmployeeName.Text = $"{Employee.EmployeeName}";
            textBoxEmployeeSurname.Text = $"{Employee.EmployeeSurname}";
            selectedDevelopment = Convert.ToInt32(domainUpDownDevelompentNumber.Text);
            MemoryStream memoryStream = new MemoryStream((byte[])FEMAnalysi.NewPattern);
            pictureBoxPattern.Image = new Bitmap(memoryStream);
        }
    }
}
