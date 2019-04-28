using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KWZP2019
{
    public partial class AddExamination : Form
    {
        RoofingCompanyEntities db;
        SqlConnection conn = new SqlConnection("server =.\\SQLEXPRESS;Database=RoofingCompany;Integrated Security=true");
        public AddExamination(RoofingCompanyEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void Examination_Load(object sender, EventArgs e)
        {

            var group = from d in db.Employees
                        select d.EmployeeSurname;
            checkedListBox1.Items.AddRange(group.ToArray());



            /*SqlCommand cmd = new SqlCommand
                ("SELECT dbo.Employee.EmployeeSurname, dbo.Employee.EmployeeName FROM dbo.Employee", conn);
            conn.Open();           
            //String stddetails = "{0, -30}{1, 00}";
            //lbEmployeeList.Items.Add(String.Format(stddetails, "Nazwisko", "Imię"));
            SqlDataReader reader = cmd.ExecuteReader();
                        //DataTable lista = new DataTable();
                        //lista.Columns.Add("Nazwisko", typeof(string));
                        //lista.Columns.Add("Imię", typeof(string));
            while (reader.Read())
            {
                //lbEmployeeList.Items.Add(String.Format(stddetails, reader["EmployeeSurname"], reader["EmployeeName"]));
            }
            conn.Close();
            checkedListBox1. = lista;*/
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MedicalExamination newMedicalExamination = new MedicalExamination();
            //MessageBox.Show(lbEmployeeList.SelectedItem());
            //newMedicalExamination.IdEmployee = lbEmployeeList.SelectedItem.ToString();
            //newMedicalExamination.Date = dtpNextExaminationDate.ToString("yyyy-MM-dd");
            db.MedicalExaminations.Add(newMedicalExamination);
            db.SaveChanges();
        }

        private void tbSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            lbEmployeeList.Items.Clear();
            SqlCommand cmd = new SqlCommand 
                ("SELECT dbo.Employee.EmployeeSurname, dbo.Employee.EmployeeName FROM dbo.Employee " +
                "WHERE dbo.Employee.EmployeeSurname LIKE '" + tbSearchEmployee.Text + "%'", conn);
            conn.Open();
            String stddetails = "{0, -30}{1, 00}";
            lbEmployeeList.Items.Add(String.Format(stddetails, "Nazwisko", "Imię"));
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lbEmployeeList.Items.Add(String.Format(stddetails, reader["EmployeeSurname"], reader["EmployeeName"]));
            }
            conn.Close();
        }
    }
}
