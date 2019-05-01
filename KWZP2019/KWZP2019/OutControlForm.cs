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
    public partial class OutControlForm : Form
    {
        private RoofingCompanyEntities db;
        private StartForm startForm;
        private QualityControl qualityControlForm;
        private Dictionary<int, String> processStatus = new Dictionary<int, string>();
        private enum OutControlStatus  { Oczekuje_na_kontrolę, W_takcie_realizacji, Proces_kontroli_zakończony};

        public OutControlForm(RoofingCompanyEntities db, StartForm startForm, QualityControl qualityControlForm)
        {
            this.db = db;
            this.startForm = startForm;
            this.qualityControlForm = qualityControlForm;
            InitializeComponent();
            ComponentsDataInitialize();
        }

        private void ComponentsDataInitialize()
        {
            cbProcessNumber.DataSource = db.ProductionProcesses.ToList();
            cbProcessNumber.DisplayMember = "IdProces";
            cbProcessNumber.ValueMember = "IdProces";
            cbProcessNumber.SelectedIndex = -1;
            cbProcessNumber.Text = "Proszę wybrać numer procesu";
            cbControlerId.DataSource = db.Employees.ToList();
            cbControlerId.ValueMember = "IdEmployee";
        }

        private void btnReturnMain_Click(object sender, EventArgs e)
        {
            this.startForm.Show();
            this.Hide();
        }

        private void OutControlForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.startForm.Show();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.qualityControlForm.Show();
            this.Hide();
        }

        private void btnSMeasures_Click(object sender, EventArgs e)
        {
            int procesNumber = Int32.Parse(cbProcessNumber.SelectedValue.ToString());

            using (OutMeasures outControlForm = new OutMeasures(db, startForm, qualityControlForm, this, procesNumber))
            {
                outControlForm.ShowDialog();

            }
        }

        private void cbControlerId_Format(object sender, ListControlConvertEventArgs e)
        {
            int id = ((Employee)e.ListItem).IdEmployee;
            string lastname = ((Employee)e.ListItem).EmployeeName;
            string firstname = ((Employee)e.ListItem).EmployeeSurname;
            e.Value = id +" "+ lastname + " " + firstname;
        }

        private void processStatusDictionaryRefresh()
        {
            foreach (ProductionProcess process in db.ProductionProcesses.ToList())
            {
                processStatus[process.IdProces] = OutControlStatus.Oczekuje_na_kontrolę.ToString();
            }
            foreach (OutControl process in db.OutControls.ToList())
            {
                processStatus[process.IdProcess] = OutControlStatus.W_takcie_realizacji.ToString();
            }
            foreach (vSuccesfullyProcess process in db.vSuccesfullyProcesses.ToList())
            {
                processStatus[process.IdProcess] = OutControlStatus.Proces_kontroli_zakończony.ToString();
            }
        }

        public void handleTextBoxes(int processNumber, bool existing)
        {
            if (existing)
            {
                OutControl outControl = db.OutControls.First(e => e.IdProcess == processNumber);
                txtbAcceptableWidthDeviation.Text = outControl.WidthAcceptableDeviation.ToString();
                txtbAcceptableLenghtDeviation.Text = outControl.LenghtAcceptableDeviation.ToString();
                txtbStartDate.Text = outControl.EndControlDate.ToShortDateString() + " " + outControl.EndControlDate.ToShortTimeString();
                txtbEndDate.Text = outControl.EndControlDate.ToShortDateString() + " " + outControl.EndControlDate.ToShortTimeString();
            }
            else
            {
                txtbAcceptableWidthDeviation.Text = null;
                txtbAcceptableLenghtDeviation.Text = null;
                txtbStartDate.Text = null;
                txtbEndDate.Text = null;
            }
            txtbAcceptableWidthDeviation.ReadOnly = existing;
            txtbAcceptableLenghtDeviation.ReadOnly = existing;
        }
       

        private void cbProcessNumber_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbProcessNumber.SelectedIndex != -1)
            {
                processStatusDictionaryRefresh();
                int procesNumber = Int16.Parse(cbProcessNumber.SelectedValue.ToString());
                txtbOutControlStatus.Text = processStatus[procesNumber].ToString().Replace('_', ' ');
                txtbMeasurmentsNumber.Text = db.vTechnicalProductDataPerProcesses.First(i => i.IdProcess == procesNumber).Quantity.ToString();
                switch (txtbOutControlStatus.Text)
                {
                    case "Oczekuje na kontrolę":
                        {
                            btnSMeasures.Visible = true;
                            handleTextBoxes(procesNumber, false);
                            break;
                        }
                    case "W takcie realizacji":
                        {
                            btnSMeasures.Visible = true;
                            handleTextBoxes(procesNumber, true);
                            break;
                        }
                    case "Proces kontroli zakończony":
                        {
                            btnSMeasures.Visible = false;
                            handleTextBoxes(procesNumber, true);
                            break;
                        }
                }
            }
        }
    }
}
