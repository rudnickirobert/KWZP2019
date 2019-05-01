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
            this.components = new System.ComponentModel.Container();
            this.addNewOutsourcingCompanyBtn = new System.Windows.Forms.Button();
            this.outsourcingTypeDgv = new System.Windows.Forms.DataGridView();
            this.detailsOutsourcingDgv = new System.Windows.Forms.DataGridView();
            this.txtBSerachOutsourcing = new System.Windows.Forms.TextBox();
            this.nameOutsourcingLbl = new System.Windows.Forms.Label();
            this.returnCancelOutBtn = new System.Windows.Forms.Button();
            this.serachOutsourcingCompaniesLbl = new System.Windows.Forms.Label();
            this.nameOutsourcingDgv = new System.Windows.Forms.DataGridView();
            this.labelCommitmentOutsourc = new System.Windows.Forms.Label();
            this.outsourcingTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idOutsourcingTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutsourcingType1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outsourcingCommitmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idCommitmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOutsourcingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endCommitmentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outsourcingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idOutsourcingDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOutsourcingTypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apartmentNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kRSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.outsourcingTypeDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsOutsourcingDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameOutsourcingDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outsourcingTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outsourcingCommitmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outsourcingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addNewOutsourcingCompanyBtn
            // 
            this.addNewOutsourcingCompanyBtn.Location = new System.Drawing.Point(41, 409);
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
            this.outsourcingTypeDgv.AutoGenerateColumns = false;
            this.outsourcingTypeDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outsourcingTypeDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOutsourcingTypeDataGridViewTextBoxColumn,
            this.OutsourcingType1});
            this.outsourcingTypeDgv.DataSource = this.outsourcingTypeBindingSource;
            this.outsourcingTypeDgv.Location = new System.Drawing.Point(41, 58);
            this.outsourcingTypeDgv.Name = "outsourcingTypeDgv";
            this.outsourcingTypeDgv.Size = new System.Drawing.Size(299, 72);
            this.outsourcingTypeDgv.TabIndex = 14;
            this.outsourcingTypeDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.outsourcingTypeDgv_CellContentClick);
            // 
            // detailsOutsourcingDgv
            // 
            this.detailsOutsourcingDgv.AutoGenerateColumns = false;
            this.detailsOutsourcingDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detailsOutsourcingDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOutsourcingDataGridViewTextBoxColumn1,
            this.idOutsourcingTypeDataGridViewTextBoxColumn1,
            this.companyNameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.zipCodeDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.houseNumberDataGridViewTextBoxColumn,
            this.apartmentNumberDataGridViewTextBoxColumn,
            this.nIPDataGridViewTextBoxColumn,
            this.kRSDataGridViewTextBoxColumn});
            this.detailsOutsourcingDgv.DataSource = this.outsourcingBindingSource;
            this.detailsOutsourcingDgv.Location = new System.Drawing.Point(41, 315);
            this.detailsOutsourcingDgv.Name = "detailsOutsourcingDgv";
            this.detailsOutsourcingDgv.Size = new System.Drawing.Size(604, 80);
            this.detailsOutsourcingDgv.TabIndex = 15;
            // 
            // txtBSerachOutsourcing
            // 
            this.txtBSerachOutsourcing.Location = new System.Drawing.Point(221, 20);
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
            this.nameOutsourcingLbl.Size = new System.Drawing.Size(177, 13);
            this.nameOutsourcingLbl.TabIndex = 17;
            this.nameOutsourcingLbl.Text = "Wyszukaj typ firmy outsourcingowej:";
            // 
            // returnCancelOutBtn
            // 
            this.returnCancelOutBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.returnCancelOutBtn.Location = new System.Drawing.Point(517, 427);
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
            this.serachOutsourcingCompaniesLbl.Location = new System.Drawing.Point(38, 281);
            this.serachOutsourcingCompaniesLbl.Name = "serachOutsourcingCompaniesLbl";
            this.serachOutsourcingCompaniesLbl.Size = new System.Drawing.Size(164, 13);
            this.serachOutsourcingCompaniesLbl.TabIndex = 19;
            this.serachOutsourcingCompaniesLbl.Text = "Szczegóły firmy outsourcingowej:";
            // 
            // nameOutsourcingDgv
            // 
            this.nameOutsourcingDgv.AutoGenerateColumns = false;
            this.nameOutsourcingDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nameOutsourcingDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCommitmentDataGridViewTextBoxColumn,
            this.idOutsourcingDataGridViewTextBoxColumn,
            this.endCommitmentDateDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn});
            this.nameOutsourcingDgv.DataSource = this.outsourcingCommitmentBindingSource;
            this.nameOutsourcingDgv.Location = new System.Drawing.Point(41, 179);
            this.nameOutsourcingDgv.Name = "nameOutsourcingDgv";
            this.nameOutsourcingDgv.Size = new System.Drawing.Size(487, 93);
            this.nameOutsourcingDgv.TabIndex = 20;
            // 
            // labelCommitmentOutsourc
            // 
            this.labelCommitmentOutsourc.AutoSize = true;
            this.labelCommitmentOutsourc.Location = new System.Drawing.Point(41, 145);
            this.labelCommitmentOutsourc.Name = "labelCommitmentOutsourc";
            this.labelCommitmentOutsourc.Size = new System.Drawing.Size(140, 13);
            this.labelCommitmentOutsourc.TabIndex = 21;
            this.labelCommitmentOutsourc.Text = "Zobowiązania outsourcingu:";
            // 
            // outsourcingTypeBindingSource
            // 
            this.outsourcingTypeBindingSource.DataSource = typeof(KWZP2019.OutsourcingType);
            // 
            // idOutsourcingTypeDataGridViewTextBoxColumn
            // 
            this.idOutsourcingTypeDataGridViewTextBoxColumn.DataPropertyName = "IdOutsourcingType";
            this.idOutsourcingTypeDataGridViewTextBoxColumn.HeaderText = "IdOutsourcingType";
            this.idOutsourcingTypeDataGridViewTextBoxColumn.Name = "idOutsourcingTypeDataGridViewTextBoxColumn";
            // 
            // OutsourcingType1
            // 
            this.OutsourcingType1.DataPropertyName = "OutsourcingType1";
            this.OutsourcingType1.HeaderText = "OutsourcingType1";
            this.OutsourcingType1.Name = "OutsourcingType1";
            // 
            // outsourcingCommitmentBindingSource
            // 
            this.outsourcingCommitmentBindingSource.DataSource = typeof(KWZP2019.OutsourcingCommitment);
            // 
            // idCommitmentDataGridViewTextBoxColumn
            // 
            this.idCommitmentDataGridViewTextBoxColumn.DataPropertyName = "IdCommitment";
            this.idCommitmentDataGridViewTextBoxColumn.HeaderText = "IdCommitment";
            this.idCommitmentDataGridViewTextBoxColumn.Name = "idCommitmentDataGridViewTextBoxColumn";
            // 
            // idOutsourcingDataGridViewTextBoxColumn
            // 
            this.idOutsourcingDataGridViewTextBoxColumn.DataPropertyName = "IdOutsourcing";
            this.idOutsourcingDataGridViewTextBoxColumn.HeaderText = "IdOutsourcing";
            this.idOutsourcingDataGridViewTextBoxColumn.Name = "idOutsourcingDataGridViewTextBoxColumn";
            // 
            // endCommitmentDateDataGridViewTextBoxColumn
            // 
            this.endCommitmentDateDataGridViewTextBoxColumn.DataPropertyName = "EndCommitmentDate";
            this.endCommitmentDateDataGridViewTextBoxColumn.HeaderText = "EndCommitmentDate";
            this.endCommitmentDateDataGridViewTextBoxColumn.Name = "endCommitmentDateDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // outsourcingBindingSource
            // 
            this.outsourcingBindingSource.DataSource = typeof(KWZP2019.Outsourcing);
            // 
            // idOutsourcingDataGridViewTextBoxColumn1
            // 
            this.idOutsourcingDataGridViewTextBoxColumn1.DataPropertyName = "IdOutsourcing";
            this.idOutsourcingDataGridViewTextBoxColumn1.HeaderText = "IdOutsourcing";
            this.idOutsourcingDataGridViewTextBoxColumn1.Name = "idOutsourcingDataGridViewTextBoxColumn1";
            // 
            // idOutsourcingTypeDataGridViewTextBoxColumn1
            // 
            this.idOutsourcingTypeDataGridViewTextBoxColumn1.DataPropertyName = "IdOutsourcingType";
            this.idOutsourcingTypeDataGridViewTextBoxColumn1.HeaderText = "IdOutsourcingType";
            this.idOutsourcingTypeDataGridViewTextBoxColumn1.Name = "idOutsourcingTypeDataGridViewTextBoxColumn1";
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // zipCodeDataGridViewTextBoxColumn
            // 
            this.zipCodeDataGridViewTextBoxColumn.DataPropertyName = "ZipCode";
            this.zipCodeDataGridViewTextBoxColumn.HeaderText = "ZipCode";
            this.zipCodeDataGridViewTextBoxColumn.Name = "zipCodeDataGridViewTextBoxColumn";
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "Street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "Street";
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            // 
            // houseNumberDataGridViewTextBoxColumn
            // 
            this.houseNumberDataGridViewTextBoxColumn.DataPropertyName = "HouseNumber";
            this.houseNumberDataGridViewTextBoxColumn.HeaderText = "HouseNumber";
            this.houseNumberDataGridViewTextBoxColumn.Name = "houseNumberDataGridViewTextBoxColumn";
            // 
            // apartmentNumberDataGridViewTextBoxColumn
            // 
            this.apartmentNumberDataGridViewTextBoxColumn.DataPropertyName = "ApartmentNumber";
            this.apartmentNumberDataGridViewTextBoxColumn.HeaderText = "ApartmentNumber";
            this.apartmentNumberDataGridViewTextBoxColumn.Name = "apartmentNumberDataGridViewTextBoxColumn";
            // 
            // nIPDataGridViewTextBoxColumn
            // 
            this.nIPDataGridViewTextBoxColumn.DataPropertyName = "NIP";
            this.nIPDataGridViewTextBoxColumn.HeaderText = "NIP";
            this.nIPDataGridViewTextBoxColumn.Name = "nIPDataGridViewTextBoxColumn";
            // 
            // kRSDataGridViewTextBoxColumn
            // 
            this.kRSDataGridViewTextBoxColumn.DataPropertyName = "KRS";
            this.kRSDataGridViewTextBoxColumn.HeaderText = "KRS";
            this.kRSDataGridViewTextBoxColumn.Name = "kRSDataGridViewTextBoxColumn";
            // 
            // OutsourcingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 483);
            this.Controls.Add(this.labelCommitmentOutsourc);
            this.Controls.Add(this.nameOutsourcingDgv);
            this.Controls.Add(this.serachOutsourcingCompaniesLbl);
            this.Controls.Add(this.returnCancelOutBtn);
            this.Controls.Add(this.nameOutsourcingLbl);
            this.Controls.Add(this.txtBSerachOutsourcing);
            this.Controls.Add(this.detailsOutsourcingDgv);
            this.Controls.Add(this.outsourcingTypeDgv);
            this.Controls.Add(this.addNewOutsourcingCompanyBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OutsourcingForm";
            this.Text = "OutsourcingForm";
            this.Load += new System.EventHandler(this.OutsourcingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.outsourcingTypeDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsOutsourcingDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameOutsourcingDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outsourcingTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outsourcingCommitmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outsourcingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addNewOutsourcingCompanyBtn;
        private System.Windows.Forms.DataGridView outsourcingTypeDgv;
        private System.Windows.Forms.DataGridView detailsOutsourcingDgv;
        private System.Windows.Forms.TextBox txtBSerachOutsourcing;
        private System.Windows.Forms.Label nameOutsourcingLbl;
        private System.Windows.Forms.Button returnCancelOutBtn;
        private System.Windows.Forms.Label serachOutsourcingCompaniesLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn outsourcingType1DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource outsourcingTypeBindingSource;
        private System.Windows.Forms.DataGridView nameOutsourcingDgv;
        private System.Windows.Forms.Label labelCommitmentOutsourc;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOutsourcingTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutsourcingType1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCommitmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOutsourcingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endCommitmentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource outsourcingCommitmentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOutsourcingDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOutsourcingTypeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartmentNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kRSDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource outsourcingBindingSource;
    }
}