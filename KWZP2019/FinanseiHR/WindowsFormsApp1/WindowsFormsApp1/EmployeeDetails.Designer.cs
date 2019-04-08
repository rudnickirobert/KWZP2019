namespace WindowsFormsApp1
{
    partial class EmployeeDetails
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonExamination = new System.Windows.Forms.Button();
            this.buttonContract = new System.Windows.Forms.Button();
            this.buttonEducation = new System.Windows.Forms.Button();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZipCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Street = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HouseNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApartmentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PESEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.ZipCode,
            this.City,
            this.Street,
            this.HouseNumber,
            this.ApartmentNumber,
            this.PhoneNumber,
            this.PESEL});
            this.dataGridView1.Location = new System.Drawing.Point(24, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(597, 370);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(666, 58);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonExamination
            // 
            this.buttonExamination.Location = new System.Drawing.Point(666, 206);
            this.buttonExamination.Name = "buttonExamination";
            this.buttonExamination.Size = new System.Drawing.Size(122, 23);
            this.buttonExamination.TabIndex = 2;
            this.buttonExamination.Text = "Examination";
            this.buttonExamination.UseVisualStyleBackColor = true;
            // 
            // buttonContract
            // 
            this.buttonContract.Location = new System.Drawing.Point(666, 248);
            this.buttonContract.Name = "buttonContract";
            this.buttonContract.Size = new System.Drawing.Size(122, 23);
            this.buttonContract.TabIndex = 3;
            this.buttonContract.Text = "Contract";
            this.buttonContract.UseVisualStyleBackColor = true;
            // 
            // buttonEducation
            // 
            this.buttonEducation.Location = new System.Drawing.Point(666, 292);
            this.buttonEducation.Name = "buttonEducation";
            this.buttonEducation.Size = new System.Drawing.Size(122, 23);
            this.buttonEducation.TabIndex = 4;
            this.buttonEducation.Text = "Education";
            this.buttonEducation.UseVisualStyleBackColor = true;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            // 
            // ZipCode
            // 
            this.ZipCode.HeaderText = "Zip-Code";
            this.ZipCode.Name = "ZipCode";
            // 
            // City
            // 
            this.City.HeaderText = "City";
            this.City.Name = "City";
            // 
            // Street
            // 
            this.Street.HeaderText = "Street";
            this.Street.Name = "Street";
            // 
            // HouseNumber
            // 
            this.HouseNumber.HeaderText = "House Number";
            this.HouseNumber.Name = "HouseNumber";
            // 
            // ApartmentNumber
            // 
            this.ApartmentNumber.HeaderText = "Apartment Number";
            this.ApartmentNumber.Name = "ApartmentNumber";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.HeaderText = "Phone Number";
            this.PhoneNumber.Name = "PhoneNumber";
            // 
            // PESEL
            // 
            this.PESEL.HeaderText = "PESEL";
            this.PESEL.Name = "PESEL";
            // 
            // EmployeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEducation);
            this.Controls.Add(this.buttonContract);
            this.Controls.Add(this.buttonExamination);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EmployeeDetails";
            this.Text = "Employee Details";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonExamination;
        private System.Windows.Forms.Button buttonContract;
        private System.Windows.Forms.Button buttonEducation;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZipCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Street;
        private System.Windows.Forms.DataGridViewTextBoxColumn HouseNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApartmentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn PESEL;
    }
}