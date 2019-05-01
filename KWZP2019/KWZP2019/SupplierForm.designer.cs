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
            this.radioButtonSupplierSemis = new System.Windows.Forms.RadioButton();
            this.radioButtonSupplierParts = new System.Windows.Forms.RadioButton();
            this.addNewSupplierBtn = new System.Windows.Forms.Button();
            this.supplierTypeGb = new System.Windows.Forms.GroupBox();
            this.supplierDgv = new System.Windows.Forms.DataGridView();
            this.buttonreturnSupplierForm = new System.Windows.Forms.Button();
            this.supplierTypeGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonSupplierSemis
            // 
            this.radioButtonSupplierSemis.AutoSize = true;
            this.radioButtonSupplierSemis.Location = new System.Drawing.Point(4, 28);
            this.radioButtonSupplierSemis.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonSupplierSemis.Name = "radioButtonSupplierSemis";
            this.radioButtonSupplierSemis.Size = new System.Drawing.Size(136, 17);
            this.radioButtonSupplierSemis.TabIndex = 1;
            this.radioButtonSupplierSemis.TabStop = true;
            this.radioButtonSupplierSemis.Text = "Dostawca półfabrykatu";
            this.radioButtonSupplierSemis.UseVisualStyleBackColor = true;
            this.radioButtonSupplierSemis.CheckedChanged += new System.EventHandler(this.Dostawcapolfabrykatu_rb_CheckedChanged);
            // 
            // radioButtonSupplierParts
            // 
            this.radioButtonSupplierParts.AutoSize = true;
            this.radioButtonSupplierParts.Location = new System.Drawing.Point(4, 50);
            this.radioButtonSupplierParts.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonSupplierParts.Name = "radioButtonSupplierParts";
            this.radioButtonSupplierParts.Size = new System.Drawing.Size(106, 17);
            this.radioButtonSupplierParts.TabIndex = 2;
            this.radioButtonSupplierParts.TabStop = true;
            this.radioButtonSupplierParts.Text = "Dostawca części";
            this.radioButtonSupplierParts.UseVisualStyleBackColor = true;
            // 
            // addNewSupplierBtn
            // 
            this.addNewSupplierBtn.Location = new System.Drawing.Point(13, 285);
            this.addNewSupplierBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addNewSupplierBtn.Name = "addNewSupplierBtn";
            this.addNewSupplierBtn.Size = new System.Drawing.Size(123, 50);
            this.addNewSupplierBtn.TabIndex = 3;
            this.addNewSupplierBtn.Text = "Dodaj nowego dostawcę";
            this.addNewSupplierBtn.UseVisualStyleBackColor = true;
            this.addNewSupplierBtn.Click += new System.EventHandler(this.addNewSupplierBtn_Click);
            // 
            // supplierTypeGb
            // 
            this.supplierTypeGb.Controls.Add(this.radioButtonSupplierParts);
            this.supplierTypeGb.Controls.Add(this.radioButtonSupplierSemis);
            this.supplierTypeGb.Location = new System.Drawing.Point(9, 25);
            this.supplierTypeGb.Margin = new System.Windows.Forms.Padding(2);
            this.supplierTypeGb.Name = "supplierTypeGb";
            this.supplierTypeGb.Padding = new System.Windows.Forms.Padding(2);
            this.supplierTypeGb.Size = new System.Drawing.Size(151, 83);
            this.supplierTypeGb.TabIndex = 10;
            this.supplierTypeGb.TabStop = false;
            this.supplierTypeGb.Text = "Typ dostawcy";
            // 
            // supplierDgv
            // 
            this.supplierDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplierDgv.Location = new System.Drawing.Point(194, 25);
            this.supplierDgv.Margin = new System.Windows.Forms.Padding(2);
            this.supplierDgv.Name = "supplierDgv";
            this.supplierDgv.RowTemplate.Height = 24;
            this.supplierDgv.Size = new System.Drawing.Size(466, 128);
            this.supplierDgv.TabIndex = 11;
            // 
            // buttonreturnSupplierForm
            // 
            this.buttonreturnSupplierForm.Location = new System.Drawing.Point(554, 304);
            this.buttonreturnSupplierForm.Name = "buttonreturnSupplierForm";
            this.buttonreturnSupplierForm.Size = new System.Drawing.Size(125, 30);
            this.buttonreturnSupplierForm.TabIndex = 12;
            this.buttonreturnSupplierForm.Text = "Powrót";
            this.buttonreturnSupplierForm.UseVisualStyleBackColor = true;
            this.buttonreturnSupplierForm.Click += new System.EventHandler(this.buttonreturnSupplierForm_Click);
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 366);
            this.Controls.Add(this.buttonreturnSupplierForm);
            this.Controls.Add(this.supplierDgv);
            this.Controls.Add(this.supplierTypeGb);
            this.Controls.Add(this.addNewSupplierBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SupplierForm";
            this.Text = "SupplierForm";
            this.Load += new System.EventHandler(this.SupplierForm_Load);
            this.supplierTypeGb.ResumeLayout(false);
            this.supplierTypeGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton radioButtonSupplierSemis;
        private System.Windows.Forms.RadioButton radioButtonSupplierParts;
        private System.Windows.Forms.Button addNewSupplierBtn;
        private System.Windows.Forms.GroupBox supplierTypeGb;
        private System.Windows.Forms.DataGridView supplierDgv;
        private System.Windows.Forms.Button buttonreturnSupplierForm;
    }
}