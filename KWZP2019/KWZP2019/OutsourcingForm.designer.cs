namespace KWZP2019
{
    partial class OutsourcingForm
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
            this.addNewOutsourcingCompanyBtn = new System.Windows.Forms.Button();
            this.outsourcingTypeDgv = new System.Windows.Forms.DataGridView();
            this.outsourcingDgv = new System.Windows.Forms.DataGridView();
            this.txtBSerachOutsourcing = new System.Windows.Forms.TextBox();
            this.nameOutsourcingLbl = new System.Windows.Forms.Label();
            this.returnCancelOutBtn = new System.Windows.Forms.Button();
            this.serachOutsourcingCompaniesLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.outsourcingTypeDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outsourcingDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // addNewOutsourcingCompanyBtn
            // 
            this.addNewOutsourcingCompanyBtn.Location = new System.Drawing.Point(41, 381);
            this.addNewOutsourcingCompanyBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addNewOutsourcingCompanyBtn.Name = "addNewOutsourcingCompanyBtn";
            this.addNewOutsourcingCompanyBtn.Size = new System.Drawing.Size(111, 52);
            this.addNewOutsourcingCompanyBtn.TabIndex = 13;
            this.addNewOutsourcingCompanyBtn.Text = "Dodaj firmę outsourcingową";
            this.addNewOutsourcingCompanyBtn.UseVisualStyleBackColor = true;
            this.addNewOutsourcingCompanyBtn.Click += new System.EventHandler(this.addNewOutsourcingCompanyBtn_Click);
            // 
            // outsourcingTypeDgv
            // 
            this.outsourcingTypeDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outsourcingTypeDgv.Location = new System.Drawing.Point(41, 67);
            this.outsourcingTypeDgv.Name = "outsourcingTypeDgv";
            this.outsourcingTypeDgv.Size = new System.Drawing.Size(604, 114);
            this.outsourcingTypeDgv.TabIndex = 14;
            this.outsourcingTypeDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.outsourcingTypeDgv_CellContentClick);
            // 
            // outsourcingDgv
            // 
            this.outsourcingDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outsourcingDgv.Location = new System.Drawing.Point(41, 224);
            this.outsourcingDgv.Name = "outsourcingDgv";
            this.outsourcingDgv.Size = new System.Drawing.Size(604, 114);
            this.outsourcingDgv.TabIndex = 15;
            // 
            // txtBSerachOutsourcing
            // 
            this.txtBSerachOutsourcing.Location = new System.Drawing.Point(211, 16);
            this.txtBSerachOutsourcing.Name = "txtBSerachOutsourcing";
            this.txtBSerachOutsourcing.Size = new System.Drawing.Size(195, 20);
            this.txtBSerachOutsourcing.TabIndex = 16;
            this.txtBSerachOutsourcing.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBSerachOutsourcing_KeyPress);
            // 
            // nameOutsourcingLbl
            // 
            this.nameOutsourcingLbl.AutoSize = true;
            this.nameOutsourcingLbl.Location = new System.Drawing.Point(38, 23);
            this.nameOutsourcingLbl.Name = "nameOutsourcingLbl";
            this.nameOutsourcingLbl.Size = new System.Drawing.Size(159, 13);
            this.nameOutsourcingLbl.TabIndex = 17;
            this.nameOutsourcingLbl.Text = "Wyszukaj firmę outsourcingową:";
            // 
            // returnCancelOutBtn
            // 
            this.returnCancelOutBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.returnCancelOutBtn.Location = new System.Drawing.Point(516, 387);
            this.returnCancelOutBtn.Name = "returnCancelOutBtn";
            this.returnCancelOutBtn.Size = new System.Drawing.Size(128, 34);
            this.returnCancelOutBtn.TabIndex = 18;
            this.returnCancelOutBtn.Text = "Powrót";
            this.returnCancelOutBtn.UseVisualStyleBackColor = true;
            this.returnCancelOutBtn.Click += new System.EventHandler(this.returnCancelOutBtn_Click);
            // 
            // serachOutsourcingCompaniesLbl
            // 
            this.serachOutsourcingCompaniesLbl.AutoSize = true;
            this.serachOutsourcingCompaniesLbl.Location = new System.Drawing.Point(43, 199);
            this.serachOutsourcingCompaniesLbl.Name = "serachOutsourcingCompaniesLbl";
            this.serachOutsourcingCompaniesLbl.Size = new System.Drawing.Size(164, 13);
            this.serachOutsourcingCompaniesLbl.TabIndex = 19;
            this.serachOutsourcingCompaniesLbl.Text = "Szczegóły firmy outsourcingowej:";
            // 
            // OutsourcingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 483);
            this.Controls.Add(this.serachOutsourcingCompaniesLbl);
            this.Controls.Add(this.returnCancelOutBtn);
            this.Controls.Add(this.nameOutsourcingLbl);
            this.Controls.Add(this.txtBSerachOutsourcing);
            this.Controls.Add(this.outsourcingDgv);
            this.Controls.Add(this.outsourcingTypeDgv);
            this.Controls.Add(this.addNewOutsourcingCompanyBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OutsourcingForm";
            this.Text = "OutsourcingForm";
            this.Load += new System.EventHandler(this.OutsourcingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.outsourcingTypeDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outsourcingDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addNewOutsourcingCompanyBtn;
        private System.Windows.Forms.DataGridView outsourcingTypeDgv;
        private System.Windows.Forms.DataGridView outsourcingDgv;
        private System.Windows.Forms.TextBox txtBSerachOutsourcing;
        private System.Windows.Forms.Label nameOutsourcingLbl;
        private System.Windows.Forms.Button returnCancelOutBtn;
        private System.Windows.Forms.Label serachOutsourcingCompaniesLbl;
    }
}