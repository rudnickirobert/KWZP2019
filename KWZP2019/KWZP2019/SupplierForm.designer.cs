﻿namespace KWZP2019
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierForm));
            this.Dostawcapolfabrykatu_rb = new System.Windows.Forms.RadioButton();
            this.DOstawcaczesci_rb = new System.Windows.Forms.RadioButton();
            this.supplierTypeGb = new System.Windows.Forms.GroupBox();
            this.supplierDgv = new System.Windows.Forms.DataGridView();
            this.addNewSupplierBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.supplierTypeGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Dostawcapolfabrykatu_rb
            // 
            this.Dostawcapolfabrykatu_rb.AutoSize = true;
            this.Dostawcapolfabrykatu_rb.Location = new System.Drawing.Point(6, 34);
            this.Dostawcapolfabrykatu_rb.Name = "Dostawcapolfabrykatu_rb";
            this.Dostawcapolfabrykatu_rb.Size = new System.Drawing.Size(221, 28);
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
            this.DOstawcaczesci_rb.Size = new System.Drawing.Size(170, 28);
            this.DOstawcaczesci_rb.TabIndex = 2;
            this.DOstawcaczesci_rb.TabStop = true;
            this.DOstawcaczesci_rb.Text = "Dostawca części";
            this.DOstawcaczesci_rb.UseVisualStyleBackColor = true;
            // 
            // supplierTypeGb
            // 
            this.supplierTypeGb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.supplierTypeGb.Controls.Add(this.DOstawcaczesci_rb);
            this.supplierTypeGb.Controls.Add(this.Dostawcapolfabrykatu_rb);
            this.supplierTypeGb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.supplierTypeGb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.supplierTypeGb.Location = new System.Drawing.Point(120, 35);
            this.supplierTypeGb.Name = "supplierTypeGb";
            this.supplierTypeGb.Size = new System.Drawing.Size(265, 102);
            this.supplierTypeGb.TabIndex = 10;
            this.supplierTypeGb.TabStop = false;
            this.supplierTypeGb.Text = "Typ dostawcy";
            // 
            // supplierDgv
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.supplierDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.supplierDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.supplierDgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.supplierDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.supplierDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.supplierDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.supplierDgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.supplierDgv.EnableHeadersVisualStyles = false;
            this.supplierDgv.Location = new System.Drawing.Point(120, 178);
            this.supplierDgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.supplierDgv.MultiSelect = false;
            this.supplierDgv.Name = "supplierDgv";
            this.supplierDgv.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(86)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.supplierDgv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.supplierDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.supplierDgv.Size = new System.Drawing.Size(997, 237);
            this.supplierDgv.TabIndex = 22;
            // 
            // addNewSupplierBtn
            // 
            this.addNewSupplierBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.addNewSupplierBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.addNewSupplierBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addNewSupplierBtn.Image = ((System.Drawing.Image)(resources.GetObject("addNewSupplierBtn.Image")));
            this.addNewSupplierBtn.Location = new System.Drawing.Point(341, 489);
            this.addNewSupplierBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addNewSupplierBtn.Name = "addNewSupplierBtn";
            this.addNewSupplierBtn.Size = new System.Drawing.Size(267, 148);
            this.addNewSupplierBtn.TabIndex = 23;
            this.addNewSupplierBtn.Text = "Dodaj dostawcę";
            this.addNewSupplierBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addNewSupplierBtn.UseVisualStyleBackColor = false;
            this.addNewSupplierBtn.Click += new System.EventHandler(this.addNewSupplierBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.backBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.backBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(45, 489);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(267, 148);
            this.backBtn.TabIndex = 24;
            this.backBtn.Text = "Powrót";
            this.backBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.backBtn.UseVisualStyleBackColor = false;
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.addNewSupplierBtn);
            this.Controls.Add(this.supplierDgv);
            this.Controls.Add(this.supplierTypeGb);
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
        private System.Windows.Forms.GroupBox supplierTypeGb;
        private System.Windows.Forms.DataGridView supplierDgv;
        private System.Windows.Forms.Button addNewSupplierBtn;
        private System.Windows.Forms.Button backBtn;
    }
}