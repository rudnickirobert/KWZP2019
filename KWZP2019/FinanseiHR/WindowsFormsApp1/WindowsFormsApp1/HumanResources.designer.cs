namespace WindowsFormsApp1
{
    partial class HumanResources
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonEmployeeDetails = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBoxSearchEmployee = new System.Windows.Forms.TextBox();
            this.buttonSearchEmployee = new System.Windows.Forms.Button();
            this.buttonExamination = new System.Windows.Forms.Button();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.buttonTraining = new System.Windows.Forms.Button();
            this.buttonAbsences = new System.Windows.Forms.Button();
            this.buttonPayChecks = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEmployeeDetails
            // 
            this.buttonEmployeeDetails.Location = new System.Drawing.Point(607, 21);
            this.buttonEmployeeDetails.Name = "buttonEmployeeDetails";
            this.buttonEmployeeDetails.Size = new System.Drawing.Size(98, 38);
            this.buttonEmployeeDetails.TabIndex = 0;
            this.buttonEmployeeDetails.Text = "Details";
            this.buttonEmployeeDetails.UseVisualStyleBackColor = true;
            this.buttonEmployeeDetails.UseWaitCursor = true;
            this.buttonEmployeeDetails.Click += new System.EventHandler(this.buttonEmployeeDetails_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(565, 335);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(188, 84);
            this.listBox1.TabIndex = 3;
            this.listBox1.UseWaitCursor = true;
            // 
            // textBoxSearchEmployee
            // 
            this.textBoxSearchEmployee.Location = new System.Drawing.Point(12, 12);
            this.textBoxSearchEmployee.Name = "textBoxSearchEmployee";
            this.textBoxSearchEmployee.Size = new System.Drawing.Size(295, 22);
            this.textBoxSearchEmployee.TabIndex = 4;
            this.textBoxSearchEmployee.UseWaitCursor = true;
            // 
            // buttonSearchEmployee
            // 
            this.buttonSearchEmployee.Location = new System.Drawing.Point(388, 5);
            this.buttonSearchEmployee.Name = "buttonSearchEmployee";
            this.buttonSearchEmployee.Size = new System.Drawing.Size(89, 36);
            this.buttonSearchEmployee.TabIndex = 5;
            this.buttonSearchEmployee.Text = "Search";
            this.buttonSearchEmployee.UseVisualStyleBackColor = true;
            this.buttonSearchEmployee.UseWaitCursor = true;
            // 
            // buttonExamination
            // 
            this.buttonExamination.Location = new System.Drawing.Point(607, 65);
            this.buttonExamination.Name = "buttonExamination";
            this.buttonExamination.Size = new System.Drawing.Size(98, 46);
            this.buttonExamination.TabIndex = 6;
            this.buttonExamination.Text = "Examination";
            this.buttonExamination.UseVisualStyleBackColor = true;
            this.buttonExamination.UseWaitCursor = true;
            this.buttonExamination.Click += new System.EventHandler(this.buttonExamination_Click);
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Location = new System.Drawing.Point(596, 117);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(127, 44);
            this.buttonAddEmployee.TabIndex = 7;
            this.buttonAddEmployee.Text = "Add Employee";
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            this.buttonAddEmployee.UseWaitCursor = true;
            this.buttonAddEmployee.Click += new System.EventHandler(this.buttonAddEmployee_Click);
            // 
            // buttonTraining
            // 
            this.buttonTraining.Location = new System.Drawing.Point(596, 178);
            this.buttonTraining.Name = "buttonTraining";
            this.buttonTraining.Size = new System.Drawing.Size(116, 35);
            this.buttonTraining.TabIndex = 8;
            this.buttonTraining.Text = "Training";
            this.buttonTraining.UseVisualStyleBackColor = true;
            this.buttonTraining.UseWaitCursor = true;
            this.buttonTraining.Click += new System.EventHandler(this.buttonTraining_Click);
            // 
            // buttonAbsences
            // 
            this.buttonAbsences.Location = new System.Drawing.Point(607, 219);
            this.buttonAbsences.Name = "buttonAbsences";
            this.buttonAbsences.Size = new System.Drawing.Size(116, 42);
            this.buttonAbsences.TabIndex = 9;
            this.buttonAbsences.Text = "Absences";
            this.buttonAbsences.UseVisualStyleBackColor = true;
            this.buttonAbsences.UseWaitCursor = true;
            this.buttonAbsences.Click += new System.EventHandler(this.buttonAbsences_Click);
            // 
            // buttonPayChecks
            // 
            this.buttonPayChecks.Location = new System.Drawing.Point(607, 277);
            this.buttonPayChecks.Name = "buttonPayChecks";
            this.buttonPayChecks.Size = new System.Drawing.Size(116, 37);
            this.buttonPayChecks.TabIndex = 10;
            this.buttonPayChecks.Text = "PayChecks";
            this.buttonPayChecks.UseVisualStyleBackColor = true;
            this.buttonPayChecks.UseWaitCursor = true;
            this.buttonPayChecks.Click += new System.EventHandler(this.buttonPayChecks_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.LastName,
            this.FirstName,
            this.Position,
            this.PhoneNumber,
            this.Address});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.dataGridView1.Location = new System.Drawing.Point(12, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(547, 367);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.UseWaitCursor = true;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "IdEmployee";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "EmployeeSurname";
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "EmployeeName";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // Position
            // 
            this.Position.DataPropertyName = "Workplace";
            this.Position.HeaderText = "Position";
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "Phone Number";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "City";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // HumanResources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonPayChecks);
            this.Controls.Add(this.buttonAbsences);
            this.Controls.Add(this.buttonTraining);
            this.Controls.Add(this.buttonAddEmployee);
            this.Controls.Add(this.buttonExamination);
            this.Controls.Add(this.buttonSearchEmployee);
            this.Controls.Add(this.textBoxSearchEmployee);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonEmployeeDetails);
            this.Name = "HumanResources";
            this.Text = "Human Resources";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.HumanResources_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEmployeeDetails;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBoxSearchEmployee;
        private System.Windows.Forms.Button buttonSearchEmployee;
        private System.Windows.Forms.Button buttonExamination;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.Button buttonTraining;
        private System.Windows.Forms.Button buttonAbsences;
        private System.Windows.Forms.Button buttonPayChecks;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
    }
}

