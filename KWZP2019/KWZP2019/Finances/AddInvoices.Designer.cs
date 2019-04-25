namespace KWZP2019
{
    partial class AddInvoices
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
            this.components = new System.ComponentModel.Container();
            this.lblAdddata = new System.Windows.Forms.Label();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.lblNameofentity = new System.Windows.Forms.Label();
            this.llbNip = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblHousenumber = new System.Windows.Forms.Label();
            this.lblApartmentnumber = new System.Windows.Forms.Label();
            this.lblZipcode = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblDateadded = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.tbHouseNumber = new System.Windows.Forms.TextBox();
            this.tbPostalCode = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbCompanyName = new System.Windows.Forms.TextBox();
            this.dtpDateadded = new System.Windows.Forms.DateTimePicker();
            this.tbInvoiceValue = new System.Windows.Forms.TextBox();
            this.lblPln = new System.Windows.Forms.Label();
            this.tbLocalNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbKRS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.hRFinancesDataSet = new KWZP2019.HRFinancesDataSet();
            this.invoiceTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceTypeTableAdapter = new KWZP2019.HRFinancesDataSetTableAdapters.InvoiceTypeTableAdapter();
            this.fillBy2ToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillBy2ToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.hRFinancesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceTypeBindingSource)).BeginInit();
            this.fillBy2ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAdddata
            // 
            this.lblAdddata.AutoSize = true;
            this.lblAdddata.Location = new System.Drawing.Point(12, 9);
            this.lblAdddata.Name = "lblAdddata";
            this.lblAdddata.Size = new System.Drawing.Size(152, 13);
            this.lblAdddata.TabIndex = 0;
            this.lblAdddata.Text = "Dodawanie danych do faktury:";
            // 
            // tbStreet
            // 
            this.tbStreet.Location = new System.Drawing.Point(118, 161);
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.Size = new System.Drawing.Size(162, 20);
            this.tbStreet.TabIndex = 1;
            // 
            // lblNameofentity
            // 
            this.lblNameofentity.AutoSize = true;
            this.lblNameofentity.Location = new System.Drawing.Point(14, 34);
            this.lblNameofentity.Name = "lblNameofentity";
            this.lblNameofentity.Size = new System.Drawing.Size(89, 13);
            this.lblNameofentity.TabIndex = 2;
            this.lblNameofentity.Text = "Nazwa podmiotu:";
            // 
            // llbNip
            // 
            this.llbNip.AutoSize = true;
            this.llbNip.Location = new System.Drawing.Point(14, 60);
            this.llbNip.Name = "llbNip";
            this.llbNip.Size = new System.Drawing.Size(46, 13);
            this.llbNip.TabIndex = 3;
            this.llbNip.Text = "Telefon:";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(14, 86);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(35, 13);
            this.lblStreet.TabIndex = 4;
            this.lblStreet.Text = "Email:";
            // 
            // lblHousenumber
            // 
            this.lblHousenumber.AutoSize = true;
            this.lblHousenumber.Location = new System.Drawing.Point(12, 112);
            this.lblHousenumber.Name = "lblHousenumber";
            this.lblHousenumber.Size = new System.Drawing.Size(41, 13);
            this.lblHousenumber.TabIndex = 5;
            this.lblHousenumber.Text = "Miasto:";
            // 
            // lblApartmentnumber
            // 
            this.lblApartmentnumber.AutoSize = true;
            this.lblApartmentnumber.Location = new System.Drawing.Point(14, 138);
            this.lblApartmentnumber.Name = "lblApartmentnumber";
            this.lblApartmentnumber.Size = new System.Drawing.Size(77, 13);
            this.lblApartmentnumber.TabIndex = 6;
            this.lblApartmentnumber.Text = "Kod pocztowy:";
            // 
            // lblZipcode
            // 
            this.lblZipcode.AutoSize = true;
            this.lblZipcode.Location = new System.Drawing.Point(14, 164);
            this.lblZipcode.Name = "lblZipcode";
            this.lblZipcode.Size = new System.Drawing.Size(34, 13);
            this.lblZipcode.TabIndex = 7;
            this.lblZipcode.Text = "Ulica:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(16, 190);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(50, 13);
            this.lblCity.TabIndex = 8;
            this.lblCity.Text = "Nr domu:";
            // 
            // lblDateadded
            // 
            this.lblDateadded.AutoSize = true;
            this.lblDateadded.Location = new System.Drawing.Point(14, 238);
            this.lblDateadded.Name = "lblDateadded";
            this.lblDateadded.Size = new System.Drawing.Size(93, 13);
            this.lblDateadded.TabIndex = 9;
            this.lblDateadded.Text = "Data wystawienia:";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(14, 290);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(85, 13);
            this.lblValue.TabIndex = 10;
            this.lblValue.Text = "Wartosć faktury:";
            // 
            // tbHouseNumber
            // 
            this.tbHouseNumber.Location = new System.Drawing.Point(118, 187);
            this.tbHouseNumber.Name = "tbHouseNumber";
            this.tbHouseNumber.Size = new System.Drawing.Size(162, 20);
            this.tbHouseNumber.TabIndex = 11;
            // 
            // tbPostalCode
            // 
            this.tbPostalCode.Location = new System.Drawing.Point(118, 135);
            this.tbPostalCode.Name = "tbPostalCode";
            this.tbPostalCode.Size = new System.Drawing.Size(162, 20);
            this.tbPostalCode.TabIndex = 12;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(118, 109);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(162, 20);
            this.tbCity.TabIndex = 13;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(118, 83);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(162, 20);
            this.tbEmail.TabIndex = 14;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(118, 57);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(162, 20);
            this.tbPhone.TabIndex = 15;
            // 
            // tbCompanyName
            // 
            this.tbCompanyName.Location = new System.Drawing.Point(118, 31);
            this.tbCompanyName.Name = "tbCompanyName";
            this.tbCompanyName.Size = new System.Drawing.Size(453, 20);
            this.tbCompanyName.TabIndex = 16;
            // 
            // dtpDateadded
            // 
            this.dtpDateadded.Location = new System.Drawing.Point(118, 232);
            this.dtpDateadded.Name = "dtpDateadded";
            this.dtpDateadded.Size = new System.Drawing.Size(200, 20);
            this.dtpDateadded.TabIndex = 17;
            // 
            // tbInvoiceValue
            // 
            this.tbInvoiceValue.Location = new System.Drawing.Point(105, 287);
            this.tbInvoiceValue.Name = "tbInvoiceValue";
            this.tbInvoiceValue.Size = new System.Drawing.Size(162, 20);
            this.tbInvoiceValue.TabIndex = 18;
            // 
            // lblPln
            // 
            this.lblPln.AutoSize = true;
            this.lblPln.Location = new System.Drawing.Point(273, 290);
            this.lblPln.Name = "lblPln";
            this.lblPln.Size = new System.Drawing.Size(42, 13);
            this.lblPln.TabIndex = 19;
            this.lblPln.Text = "złotych";
            // 
            // tbLocalNumber
            // 
            this.tbLocalNumber.Location = new System.Drawing.Point(409, 60);
            this.tbLocalNumber.Name = "tbLocalNumber";
            this.tbLocalNumber.Size = new System.Drawing.Size(162, 20);
            this.tbLocalNumber.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nr mieszkania:";
            // 
            // tbNIP
            // 
            this.tbNIP.Location = new System.Drawing.Point(409, 86);
            this.tbNIP.Name = "tbNIP";
            this.tbNIP.Size = new System.Drawing.Size(162, 20);
            this.tbNIP.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "NIP:";
            // 
            // tbKRS
            // 
            this.tbKRS.Location = new System.Drawing.Point(409, 112);
            this.tbKRS.Name = "tbKRS";
            this.tbKRS.Size = new System.Drawing.Size(162, 20);
            this.tbKRS.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "KRS:";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(409, 138);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(162, 20);
            this.tbDescription.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Uwagi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Typ faktury:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(489, 279);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 31;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.invoiceTypeBindingSource;
            this.comboBox1.DisplayMember = "Type";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(450, 232);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 34;
            this.comboBox1.ValueMember = "IdInvoiceType";
            // 
            // hRFinancesDataSet
            // 
            this.hRFinancesDataSet.DataSetName = "HRFinancesDataSet";
            this.hRFinancesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoiceTypeBindingSource
            // 
            this.invoiceTypeBindingSource.DataMember = "InvoiceType";
            this.invoiceTypeBindingSource.DataSource = this.hRFinancesDataSet;
            // 
            // invoiceTypeTableAdapter
            // 
            this.invoiceTypeTableAdapter.ClearBeforeFill = true;
            // 
            // fillBy2ToolStrip
            // 
            this.fillBy2ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillBy2ToolStripButton});
            this.fillBy2ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy2ToolStrip.Name = "fillBy2ToolStrip";
            this.fillBy2ToolStrip.Size = new System.Drawing.Size(111, 25);
            this.fillBy2ToolStrip.TabIndex = 35;
            this.fillBy2ToolStrip.Text = "fillBy2ToolStrip";
            // 
            // fillBy2ToolStripButton
            // 
            this.fillBy2ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy2ToolStripButton.Name = "fillBy2ToolStripButton";
            this.fillBy2ToolStripButton.Size = new System.Drawing.Size(45, 22);
            this.fillBy2ToolStripButton.Text = "FillBy2";
            this.fillBy2ToolStripButton.Click += new System.EventHandler(this.fillBy2ToolStripButton_Click);
            // 
            // AddInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 331);
            this.Controls.Add(this.fillBy2ToolStrip);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbKRS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbLocalNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPln);
            this.Controls.Add(this.tbInvoiceValue);
            this.Controls.Add(this.dtpDateadded);
            this.Controls.Add(this.tbCompanyName);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.tbPostalCode);
            this.Controls.Add(this.tbHouseNumber);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lblDateadded);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblZipcode);
            this.Controls.Add(this.lblApartmentnumber);
            this.Controls.Add(this.lblHousenumber);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.llbNip);
            this.Controls.Add(this.lblNameofentity);
            this.Controls.Add(this.tbStreet);
            this.Controls.Add(this.lblAdddata);
            this.Name = "AddInvoices";
            this.Text = "Dodaj fakturę";
            this.Load += new System.EventHandler(this.AddInvoices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hRFinancesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceTypeBindingSource)).EndInit();
            this.fillBy2ToolStrip.ResumeLayout(false);
            this.fillBy2ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdddata;
        private System.Windows.Forms.TextBox tbStreet;
        private System.Windows.Forms.Label lblNameofentity;
        private System.Windows.Forms.Label llbNip;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblHousenumber;
        private System.Windows.Forms.Label lblApartmentnumber;
        private System.Windows.Forms.Label lblZipcode;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblDateadded;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.TextBox tbHouseNumber;
        private System.Windows.Forms.TextBox tbPostalCode;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbCompanyName;
        private System.Windows.Forms.DateTimePicker dtpDateadded;
        private System.Windows.Forms.TextBox tbInvoiceValue;
        private System.Windows.Forms.Label lblPln;
        private System.Windows.Forms.TextBox tbLocalNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbKRS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox comboBox1;
        private HRFinancesDataSet hRFinancesDataSet;
        private System.Windows.Forms.BindingSource invoiceTypeBindingSource;
        private HRFinancesDataSetTableAdapters.InvoiceTypeTableAdapter invoiceTypeTableAdapter;
        private System.Windows.Forms.ToolStrip fillBy2ToolStrip;
        private System.Windows.Forms.ToolStripButton fillBy2ToolStripButton;
    }
}