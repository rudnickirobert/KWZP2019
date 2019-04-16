namespace KWZP2019
{
    partial class HR
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbEmployeeSearching = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridViewEmloyees = new System.Windows.Forms.DataGridView();
            this.Warnings = new System.Windows.Forms.ListBox();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnExamination = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnTraining = new System.Windows.Forms.Button();
            this.btnAbsences = new System.Windows.Forms.Button();
            this.btnPayChecks = new System.Windows.Forms.Button();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PESEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmloyees)).BeginInit();
            this.SuspendLayout();
            // 
            // tbEmployeeSearching
            // 
            this.tbEmployeeSearching.Location = new System.Drawing.Point(41, 25);
            this.tbEmployeeSearching.Name = "tbEmployeeSearching";
            this.tbEmployeeSearching.Size = new System.Drawing.Size(293, 22);
            this.tbEmployeeSearching.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(353, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 32);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Szukaj";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridViewEmloyees
            // 
            this.dataGridViewEmloyees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmloyees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.Position,
            this.PhoneNumber,
            this.Address,
            this.PESEL});
            this.dataGridViewEmloyees.Location = new System.Drawing.Point(11, 79);
            this.dataGridViewEmloyees.Name = "dataGridViewEmloyees";
            this.dataGridViewEmloyees.RowHeadersVisible = false;
            this.dataGridViewEmloyees.RowTemplate.Height = 24;
            this.dataGridViewEmloyees.Size = new System.Drawing.Size(477, 326);
            this.dataGridViewEmloyees.TabIndex = 2;
            // 
            // Warnings
            // 
            this.Warnings.FormattingEnabled = true;
            this.Warnings.ItemHeight = 16;
            this.Warnings.Location = new System.Drawing.Point(513, 353);
            this.Warnings.Name = "Warnings";
            this.Warnings.Size = new System.Drawing.Size(212, 52);
            this.Warnings.TabIndex = 3;
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(585, 25);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(120, 32);
            this.btnDetails.TabIndex = 4;
            this.btnDetails.Text = "Szczegoly";
            this.btnDetails.UseVisualStyleBackColor = true;
            // 
            // btnExamination
            // 
            this.btnExamination.Location = new System.Drawing.Point(585, 63);
            this.btnExamination.Name = "btnExamination";
            this.btnExamination.Size = new System.Drawing.Size(120, 37);
            this.btnExamination.TabIndex = 5;
            this.btnExamination.Text = "Badania";
            this.btnExamination.UseVisualStyleBackColor = true;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(585, 106);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(120, 51);
            this.btnAddEmployee.TabIndex = 6;
            this.btnAddEmployee.Text = "Dodaj Pracownika";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnTraining
            // 
            this.btnTraining.Location = new System.Drawing.Point(585, 163);
            this.btnTraining.Name = "btnTraining";
            this.btnTraining.Size = new System.Drawing.Size(120, 43);
            this.btnTraining.TabIndex = 7;
            this.btnTraining.Text = "Szkolenia";
            this.btnTraining.UseVisualStyleBackColor = true;
            // 
            // btnAbsences
            // 
            this.btnAbsences.Location = new System.Drawing.Point(585, 212);
            this.btnAbsences.Name = "btnAbsences";
            this.btnAbsences.Size = new System.Drawing.Size(120, 37);
            this.btnAbsences.TabIndex = 8;
            this.btnAbsences.Text = "Nieobecnosci";
            this.btnAbsences.UseVisualStyleBackColor = true;
            // 
            // btnPayChecks
            // 
            this.btnPayChecks.Location = new System.Drawing.Point(585, 255);
            this.btnPayChecks.Name = "btnPayChecks";
            this.btnPayChecks.Size = new System.Drawing.Size(120, 43);
            this.btnPayChecks.TabIndex = 9;
            this.btnPayChecks.Text = "Wyplaty";
            this.btnPayChecks.UseVisualStyleBackColor = true;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "EmployeeName";
            this.FirstName.HeaderText = "Imię";
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "EmployeeSurname";
            this.LastName.HeaderText = "Nazwisko";
            this.LastName.Name = "LastName";
            // 
            // Position
            // 
            this.Position.DataPropertyName = "Position";
            this.Position.HeaderText = "Stanowisko";
            this.Position.Name = "Position";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "Numer telefonu";
            this.PhoneNumber.Name = "PhoneNumber";
            // 
            // Address
            // 
            this.Address.DataPropertyName = "City,HouseNumber";
            this.Address.HeaderText = "Adres";
            this.Address.Name = "Address";
            // 
            // PESEL
            // 
            this.PESEL.DataPropertyName = "PESEL";
            this.PESEL.HeaderText = "PESEL";
            this.PESEL.Name = "PESEL";
            // 
            // HR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPayChecks);
            this.Controls.Add(this.btnAbsences);
            this.Controls.Add(this.btnTraining);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.btnExamination);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.Warnings);
            this.Controls.Add(this.dataGridViewEmloyees);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbEmployeeSearching);
            this.Name = "HR";
            this.Text = "Kadry";
            this.Load += new System.EventHandler(this.HR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmloyees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEmployeeSearching;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridViewEmloyees;
        private System.Windows.Forms.ListBox Warnings;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnExamination;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnTraining;
        private System.Windows.Forms.Button btnAbsences;
        private System.Windows.Forms.Button btnPayChecks;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn PESEL;
    }
}