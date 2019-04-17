namespace KWZP2019
{
    partial class SupplierForm
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
            this.Dostawcapolfabrykatu_rb = new System.Windows.Forms.RadioButton();
            this.DOstawcaczesci_rb = new System.Windows.Forms.RadioButton();
            this.addNewSupplierBtn = new System.Windows.Forms.Button();
            this.supplierTypeGb = new System.Windows.Forms.GroupBox();
            this.supplierDgv = new System.Windows.Forms.DataGridView();
            this.supplierTypeGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Dostawcapolfabrykatu_rb
            // 
            this.Dostawcapolfabrykatu_rb.AutoSize = true;
            this.Dostawcapolfabrykatu_rb.Location = new System.Drawing.Point(6, 34);
            this.Dostawcapolfabrykatu_rb.Name = "Dostawcapolfabrykatu_rb";
            this.Dostawcapolfabrykatu_rb.Size = new System.Drawing.Size(172, 21);
            this.Dostawcapolfabrykatu_rb.TabIndex = 1;
            this.Dostawcapolfabrykatu_rb.TabStop = true;
            this.Dostawcapolfabrykatu_rb.Text = "Dostawca półfabrykatu";
            this.Dostawcapolfabrykatu_rb.UseVisualStyleBackColor = true;
            // 
            // DOstawcaczesci_rb
            // 
            this.DOstawcaczesci_rb.AutoSize = true;
            this.DOstawcaczesci_rb.Location = new System.Drawing.Point(6, 61);
            this.DOstawcaczesci_rb.Name = "DOstawcaczesci_rb";
            this.DOstawcaczesci_rb.Size = new System.Drawing.Size(133, 21);
            this.DOstawcaczesci_rb.TabIndex = 2;
            this.DOstawcaczesci_rb.TabStop = true;
            this.DOstawcaczesci_rb.Text = "Dostawca części";
            this.DOstawcaczesci_rb.UseVisualStyleBackColor = true;
            // 
            // addNewSupplierBtn
            // 
            this.addNewSupplierBtn.Location = new System.Drawing.Point(37, 150);
            this.addNewSupplierBtn.Name = "addNewSupplierBtn";
            this.addNewSupplierBtn.Size = new System.Drawing.Size(164, 61);
            this.addNewSupplierBtn.TabIndex = 3;
            this.addNewSupplierBtn.Text = "Dodaj nowego dostawcę";
            this.addNewSupplierBtn.UseVisualStyleBackColor = true;
            this.addNewSupplierBtn.Click += new System.EventHandler(this.addNewSupplierBtn_Click);
            // 
            // supplierTypeGb
            // 
            this.supplierTypeGb.Controls.Add(this.DOstawcaczesci_rb);
            this.supplierTypeGb.Controls.Add(this.Dostawcapolfabrykatu_rb);
            this.supplierTypeGb.Location = new System.Drawing.Point(12, 31);
            this.supplierTypeGb.Name = "supplierTypeGb";
            this.supplierTypeGb.Size = new System.Drawing.Size(201, 102);
            this.supplierTypeGb.TabIndex = 10;
            this.supplierTypeGb.TabStop = false;
            this.supplierTypeGb.Text = "Typ dostawcy";
            // 
            // supplierDgv
            // 
            this.supplierDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplierDgv.Location = new System.Drawing.Point(258, 31);
            this.supplierDgv.Name = "supplierDgv";
            this.supplierDgv.RowTemplate.Height = 24;
            this.supplierDgv.Size = new System.Drawing.Size(621, 158);
            this.supplierDgv.TabIndex = 11;
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 450);
            this.Controls.Add(this.supplierDgv);
            this.Controls.Add(this.supplierTypeGb);
            this.Controls.Add(this.addNewSupplierBtn);
            this.Name = "SupplierForm";
            this.Text = "SupplierForm";
            this.supplierTypeGb.ResumeLayout(false);
            this.supplierTypeGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton Dostawcapolfabrykatu_rb;
        private System.Windows.Forms.RadioButton DOstawcaczesci_rb;
        private System.Windows.Forms.Button addNewSupplierBtn;
        private System.Windows.Forms.GroupBox supplierTypeGb;
        private System.Windows.Forms.DataGridView supplierDgv;
    }
}