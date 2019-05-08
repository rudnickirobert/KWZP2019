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
            List<FEMAnalysis> fEMAnalysisList = db.FEMAnalysis.ToList();
            foreach (FEMAnalysis fEMAnalysis in fEMAnalysisList)
            {
                domainUpDownDevelompentNumber.Items.Add(fEMAnalysis.IdFEMAnalysis);               
            }
        }

        private void domainUpDownDevelompentNumber_SelectedItemChanged(object sender, EventArgs e)
        {
            FEMAnalysis fEMAnalysi = db.FEMAnalysis.First(fEMA => fEMA.IdFEMAnalysis.ToString() == domainUpDownDevelompentNumber.Text);
            textBoxDevelopmentDate.Text = $"{fEMAnalysi.AnalysisDate}";
            textBoxEmployeeNumber.Text = $"{fEMAnalysi.IdEmployee}";
            textBoxDevelopmentDescription.Text = $"{fEMAnalysi.AnalysisResults}";
            Employee employee = db.Employees.First(emp => emp.IdEmployee.ToString() == fEMAnalysi.IdEmployee.ToString());
            textBoxEmployeeName.Text = $"{employee.EmployeeName}";
            textBoxEmployeeSurname.Text = $"{employee.EmployeeSurname}";
            selectedDevelopment = Convert.ToInt32(domainUpDownDevelompentNumber.Text);
            MemoryStream memoryStream = new MemoryStream((byte[])fEMAnalysi.NewPattern);
            pictureBoxPattern.Image = new Bitmap(memoryStream);
        }
    }
}
