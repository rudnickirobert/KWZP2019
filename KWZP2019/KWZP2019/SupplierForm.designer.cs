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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierForm));
            this.sfSupplierRb = new System.Windows.Forms.RadioButton();
            this.partsSupplierRb = new System.Windows.Forms.RadioButton();
            this.supplierTypeGb = new System.Windows.Forms.GroupBox();
            this.supplierDgv = new System.Windows.Forms.DataGridView();
            this.addNewSupplierBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.supplierTypeGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // sfSupplierRb
            // 
            this.sfSupplierRb.AutoSize = true;
            this.sfSupplierRb.Location = new System.Drawing.Point(5, 34);
            this.sfSupplierRb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sfSupplierRb.Name = "sfSupplierRb";
            this.sfSupplierRb.Size = new System.Drawing.Size(278, 33);
            this.sfSupplierRb.TabIndex = 1;
            this.sfSupplierRb.TabStop = true;
            this.sfSupplierRb.Text = "Dostawca półfabrykatu";
            this.sfSupplierRb.UseVisualStyleBackColor = true;
            this.sfSupplierRb.CheckedChanged += new System.EventHandler(this.sfSupplierRb_CheckedChanged);
            // 
            // partsSupplierRb
            // 
            this.partsSupplierRb.AutoSize = true;
            this.partsSupplierRb.Location = new System.Drawing.Point(5, 62);
            this.partsSupplierRb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.partsSupplierRb.Name = "partsSupplierRb";
            this.partsSupplierRb.Size = new System.Drawing.Size(212, 33);
            this.partsSupplierRb.TabIndex = 2;
            this.partsSupplierRb.TabStop = true;
            this.partsSupplierRb.Text = "Dostawca części";
            this.partsSupplierRb.UseVisualStyleBackColor = true;
            // 
            // supplierTypeGb
            // 
            this.supplierTypeGb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.supplierTypeGb.Controls.Add(this.partsSupplierRb);
            this.supplierTypeGb.Controls.Add(this.sfSupplierRb);
            this.supplierTypeGb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.supplierTypeGb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.supplierTypeGb.Location = new System.Drawing.Point(120, 34);
            this.supplierTypeGb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.supplierTypeGb.Name = "supplierTypeGb";
            this.supplierTypeGb.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.supplierTypeGb.Size = new System.Drawing.Size(359, 122);
            this.supplierTypeGb.TabIndex = 10;
            this.supplierTypeGb.TabStop = false;
            this.supplierTypeGb.Text = "Typ dostawcy";
            // 
            // supplierDgv
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.supplierDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.supplierDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.supplierDgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.supplierDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.supplierDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.supplierDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.supplierDgv.DefaultCellStyle = dataGridViewCellStyle7;
            this.supplierDgv.EnableHeadersVisualStyles = false;
            this.supplierDgv.Location = new System.Drawing.Point(120, 231);
            this.supplierDgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.supplierDgv.MultiSelect = false;
            this.supplierDgv.Name = "supplierDgv";
            this.supplierDgv.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(86)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.supplierDgv.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.supplierDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.supplierDgv.Size = new System.Drawing.Size(1391, 321);
            this.supplierDgv.TabIndex = 22;
            // 
            // addNewSupplierBtn
            // 
            this.addNewSupplierBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.addNewSupplierBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.addNewSupplierBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addNewSupplierBtn.Image = ((System.Drawing.Image)(resources.GetObject("addNewSupplierBtn.Image")));
            this.addNewSupplierBtn.Location = new System.Drawing.Point(364, 720);
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
            this.backBtn.Location = new System.Drawing.Point(68, 720);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(267, 148);
            this.backBtn.TabIndex = 24;
            this.backBtn.Text = "Powrót";
            this.backBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1579, 937);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.addNewSupplierBtn);
            this.Controls.Add(this.supplierDgv);
            this.Controls.Add(this.supplierTypeGb);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SupplierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dostawcy";
            this.Load += new System.EventHandler(this.SupplierForm_Load_1);
            this.supplierTypeGb.ResumeLayout(false);
            this.supplierTypeGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton sfSupplierRb;
        private System.Windows.Forms.RadioButton partsSupplierRb;
        private System.Windows.Forms.GroupBox supplierTypeGb;
        private System.Windows.Forms.DataGridView supplierDgv;
        private System.Windows.Forms.Button addNewSupplierBtn;
        private System.Windows.Forms.Button backBtn;
    }
}