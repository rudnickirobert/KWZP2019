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
            this.lblDateadded = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.dtpDateadded = new System.Windows.Forms.DateTimePicker();
            this.tbInvoiceValue = new System.Windows.Forms.TextBox();
            this.lblPln = new System.Windows.Forms.Label();
            this.btnAddNewInvoice = new System.Windows.Forms.Button();
            this.btnAddNewCompany = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.invoiceTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDateadded
            // 
            this.lblDateadded.AutoSize = true;
            this.lblDateadded.Location = new System.Drawing.Point(74, 58);
            this.lblDateadded.Name = "lblDateadded";
            this.lblDateadded.Size = new System.Drawing.Size(93, 13);
            this.lblDateadded.TabIndex = 9;
            this.lblDateadded.Text = "Data wystawienia:";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(74, 85);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(85, 13);
            this.lblValue.TabIndex = 10;
            this.lblValue.Text = "Wartosć faktury:";
            // 
            // dtpDateadded
            // 
            this.dtpDateadded.Location = new System.Drawing.Point(186, 52);
            this.dtpDateadded.Name = "dtpDateadded";
            this.dtpDateadded.Size = new System.Drawing.Size(200, 20);
            this.dtpDateadded.TabIndex = 17;
            // 
            // tbInvoiceValue
            // 
            this.tbInvoiceValue.Location = new System.Drawing.Point(186, 82);
            this.tbInvoiceValue.Name = "tbInvoiceValue";
            this.tbInvoiceValue.Size = new System.Drawing.Size(200, 20);
            this.tbInvoiceValue.TabIndex = 18;
            // 
            // lblPln
            // 
            this.lblPln.AutoSize = true;
            this.lblPln.Location = new System.Drawing.Point(392, 85);
            this.lblPln.Name = "lblPln";
            this.lblPln.Size = new System.Drawing.Size(42, 13);
            this.lblPln.TabIndex = 19;
            this.lblPln.Text = "złotych";
            // 
            // btnAddNewInvoice
            // 
            this.btnAddNewInvoice.Location = new System.Drawing.Point(12, 145);
            this.btnAddNewInvoice.Name = "btnAddNewInvoice";
            this.btnAddNewInvoice.Size = new System.Drawing.Size(500, 23);
            this.btnAddNewInvoice.TabIndex = 20;
            this.btnAddNewInvoice.Text = "Dodaj nową fakturę";
            this.btnAddNewInvoice.UseVisualStyleBackColor = true;
            this.btnAddNewInvoice.Click += new System.EventHandler(this.btnAddNewInvoice_Click);
            // 
            // btnAddNewCompany
            // 
            this.btnAddNewCompany.Location = new System.Drawing.Point(12, 236);
            this.btnAddNewCompany.Name = "btnAddNewCompany";
            this.btnAddNewCompany.Size = new System.Drawing.Size(500, 83);
            this.btnAddNewCompany.TabIndex = 22;
            this.btnAddNewCompany.Text = "Dodaj nowy podmiot do listy rozwijanej";
            this.btnAddNewCompany.UseVisualStyleBackColor = true;
            this.btnAddNewCompany.Click += new System.EventHandler(this.btnAddNewCompany_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(500, 21);
            this.comboBox1.TabIndex = 23;
            // 
            // comboBox2
            // 
            this.comboBox2.AllowDrop = true;
            this.comboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.invoiceTypeBindingSource, "Type", true));
            this.comboBox2.DataSource = this.invoiceTypeBindingSource;
            this.comboBox2.DisplayMember = "Type";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(186, 108);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 21);
            this.comboBox2.TabIndex = 24;
            this.comboBox2.ValueMember = "IdInvoiceType";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // invoiceTypeBindingSource
            // 
            this.invoiceTypeBindingSource.DataSource = typeof(KWZP2019.InvoiceType);
            // 
            // AddInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 331);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnAddNewCompany);
            this.Controls.Add(this.btnAddNewInvoice);
            this.Controls.Add(this.lblPln);
            this.Controls.Add(this.tbInvoiceValue);
            this.Controls.Add(this.dtpDateadded);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lblDateadded);
            this.Name = "AddInvoices";
            this.Text = "Dodaj fakturę";
            ((System.ComponentModel.ISupportInitialize)(this.invoiceTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDateadded;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.DateTimePicker dtpDateadded;
        private System.Windows.Forms.TextBox tbInvoiceValue;
        private System.Windows.Forms.Label lblPln;
        private System.Windows.Forms.Button btnAddNewInvoice;
        private System.Windows.Forms.Button btnAddNewCompany;
        private System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource invoiceTypeBindingSource;
    }
}