namespace KWZP2019
{
    partial class CustomerForm
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
            this.addNewCustomerBtn = new System.Windows.Forms.Button();
            this.orderBtn = new System.Windows.Forms.Button();
            this.customersDgv = new System.Windows.Forms.DataGridView();
            this.nameLbl = new System.Windows.Forms.Label();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.returnSalesFormBtn = new System.Windows.Forms.Button();
            this.endCustomerFormBtn = new System.Windows.Forms.Button();
            this.ordersDgv = new System.Windows.Forms.DataGridView();
            this.orderLbl = new System.Windows.Forms.Label();
            this.editCustomerBtn = new System.Windows.Forms.Button();
            this.idCustomerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOrderCustomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderCustomerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idCustomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apartmentNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peselDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kRSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.customersDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderCustomerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderCustomerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addNewCustomerBtn
            // 
            this.addNewCustomerBtn.Location = new System.Drawing.Point(486, 8);
            this.addNewCustomerBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addNewCustomerBtn.Name = "addNewCustomerBtn";
            this.addNewCustomerBtn.Size = new System.Drawing.Size(111, 34);
            this.addNewCustomerBtn.TabIndex = 1;
            this.addNewCustomerBtn.Text = "Dodaj klienta";
            this.addNewCustomerBtn.UseVisualStyleBackColor = true;
            this.addNewCustomerBtn.Click += new System.EventHandler(this.addNewCustomerBtn_Click);
            // 
            // orderBtn
            // 
            this.orderBtn.Location = new System.Drawing.Point(739, 8);
            this.orderBtn.Margin = new System.Windows.Forms.Padding(2);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(111, 32);
            this.orderBtn.TabIndex = 12;
            this.orderBtn.Text = "Zamówienie";
            this.orderBtn.UseVisualStyleBackColor = true;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // customersDgv
            // 
            this.customersDgv.AllowUserToOrderColumns = true;
            this.customersDgv.AutoGenerateColumns = false;
            this.customersDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customersDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCustomerDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.zipCodeDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.houseNumberDataGridViewTextBoxColumn,
            this.apartmentNumberDataGridViewTextBoxColumn,
            this.peselDataGridViewTextBoxColumn,
            this.nIPDataGridViewTextBoxColumn,
            this.kRSDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.customersDgv.DataSource = this.customerBindingSource;
            this.customersDgv.Location = new System.Drawing.Point(35, 44);
            this.customersDgv.Margin = new System.Windows.Forms.Padding(2);
            this.customersDgv.Name = "customersDgv";
            this.customersDgv.RowTemplate.Height = 24;
            this.customersDgv.Size = new System.Drawing.Size(815, 122);
            this.customersDgv.TabIndex = 15;
            this.customersDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customersDgv_CellContentClick);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(33, 7);
            this.nameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(40, 13);
            this.nameLbl.TabIndex = 13;
            this.nameLbl.Text = "Nazwa";
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(100, 4);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(100, 20);
            this.searchTxt.TabIndex = 0;
            this.searchTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchTxt_KeyPress);
            // 
            // saveBtn
            // 
            this.saveBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveBtn.Location = new System.Drawing.Point(733, 379);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(117, 31);
            this.saveBtn.TabIndex = 16;
            this.saveBtn.Text = "Zapisz";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // returnSalesFormBtn
            // 
            this.returnSalesFormBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.returnSalesFormBtn.Location = new System.Drawing.Point(601, 379);
            this.returnSalesFormBtn.Name = "returnSalesFormBtn";
            this.returnSalesFormBtn.Size = new System.Drawing.Size(110, 31);
            this.returnSalesFormBtn.TabIndex = 17;
            this.returnSalesFormBtn.Text = "Anuluj";
            this.returnSalesFormBtn.UseVisualStyleBackColor = true;
            this.returnSalesFormBtn.Click += new System.EventHandler(this.returnSalesFormBtn_Click);
            // 
            // endCustomerFormBtn
            // 
            this.endCustomerFormBtn.Location = new System.Drawing.Point(36, 374);
            this.endCustomerFormBtn.Name = "endCustomerFormBtn";
            this.endCustomerFormBtn.Size = new System.Drawing.Size(103, 36);
            this.endCustomerFormBtn.TabIndex = 18;
            this.endCustomerFormBtn.Text = "Koniec";
            this.endCustomerFormBtn.UseVisualStyleBackColor = true;
            this.endCustomerFormBtn.Click += new System.EventHandler(this.endCustomerFormBtn_Click);
            // 
            // ordersDgv
            // 
            this.ordersDgv.AllowUserToOrderColumns = true;
            this.ordersDgv.AutoGenerateColumns = false;
            this.ordersDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ordersDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCustomerDataGridViewTextBoxColumn1,
            this.idOrderCustomerDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.employeeDataGridViewTextBoxColumn});
            this.ordersDgv.DataSource = this.orderCustomerBindingSource1;
            this.ordersDgv.Location = new System.Drawing.Point(35, 211);
            this.ordersDgv.Name = "ordersDgv";
            this.ordersDgv.Size = new System.Drawing.Size(815, 120);
            this.ordersDgv.TabIndex = 19;
            // 
            // orderLbl
            // 
            this.orderLbl.AutoSize = true;
            this.orderLbl.Location = new System.Drawing.Point(40, 191);
            this.orderLbl.Name = "orderLbl";
            this.orderLbl.Size = new System.Drawing.Size(98, 13);
            this.orderLbl.TabIndex = 20;
            this.orderLbl.Text = "Zamówienia klienta";
            // 
            // editCustomerBtn
            // 
            this.editCustomerBtn.Location = new System.Drawing.Point(615, 9);
            this.editCustomerBtn.Name = "editCustomerBtn";
            this.editCustomerBtn.Size = new System.Drawing.Size(110, 31);
            this.editCustomerBtn.TabIndex = 21;
            this.editCustomerBtn.Text = "Edytuj klienta";
            this.editCustomerBtn.UseVisualStyleBackColor = true;
            this.editCustomerBtn.Click += new System.EventHandler(this.editCustomerBtn_Click);
            // 
            // idCustomerDataGridViewTextBoxColumn1
            // 
            this.idCustomerDataGridViewTextBoxColumn1.DataPropertyName = "IdCustomer";
            this.idCustomerDataGridViewTextBoxColumn1.HeaderText = "IdCustomer";
            this.idCustomerDataGridViewTextBoxColumn1.Name = "idCustomerDataGridViewTextBoxColumn1";
            // 
            // idOrderCustomerDataGridViewTextBoxColumn
            // 
            this.idOrderCustomerDataGridViewTextBoxColumn.DataPropertyName = "IdOrderCustomer";
            this.idOrderCustomerDataGridViewTextBoxColumn.HeaderText = "IdOrderCustomer";
            this.idOrderCustomerDataGridViewTextBoxColumn.Name = "idOrderCustomerDataGridViewTextBoxColumn";
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            // 
            // employeeDataGridViewTextBoxColumn
            // 
            this.employeeDataGridViewTextBoxColumn.DataPropertyName = "Employee";
            this.employeeDataGridViewTextBoxColumn.HeaderText = "Employee";
            this.employeeDataGridViewTextBoxColumn.Name = "employeeDataGridViewTextBoxColumn";
            // 
            // orderCustomerBindingSource1
            // 
            this.orderCustomerBindingSource1.DataSource = typeof(KWZP2019.OrderCustomer);
            // 
            // idCustomerDataGridViewTextBoxColumn
            // 
            this.idCustomerDataGridViewTextBoxColumn.DataPropertyName = "IdCustomer";
            this.idCustomerDataGridViewTextBoxColumn.HeaderText = "IdCustomer";
            this.idCustomerDataGridViewTextBoxColumn.Name = "idCustomerDataGridViewTextBoxColumn";
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
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
            // peselDataGridViewTextBoxColumn
            // 
            this.peselDataGridViewTextBoxColumn.DataPropertyName = "Pesel";
            this.peselDataGridViewTextBoxColumn.HeaderText = "Pesel";
            this.peselDataGridViewTextBoxColumn.Name = "peselDataGridViewTextBoxColumn";
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
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(KWZP2019.Customer);
            // 
            // orderCustomerBindingSource
            // 
            this.orderCustomerBindingSource.DataSource = typeof(KWZP2019.OrderCustomer);
            // 
            // CustomerForm
            // 
            this.AcceptButton = this.saveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.returnSalesFormBtn;
            this.ClientSize = new System.Drawing.Size(886, 612);
            this.Controls.Add(this.editCustomerBtn);
            this.Controls.Add(this.orderLbl);
            this.Controls.Add(this.ordersDgv);
            this.Controls.Add(this.endCustomerFormBtn);
            this.Controls.Add(this.returnSalesFormBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.customersDgv);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.orderBtn);
            this.Controls.Add(this.addNewCustomerBtn);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderCustomerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderCustomerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addNewCustomerBtn;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.DataGridView customersDgv;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button returnSalesFormBtn;
        private System.Windows.Forms.Button endCustomerFormBtn;
        private System.Windows.Forms.DataGridView ordersDgv;
        private System.Windows.Forms.Label orderLbl;
        private System.Windows.Forms.Button editCustomerBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCustomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartmentNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peselDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kRSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.BindingSource orderCustomerBindingSource;
        private System.Windows.Forms.BindingSource orderCustomerBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCustomerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOrderCustomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeDataGridViewTextBoxColumn;
    }
}