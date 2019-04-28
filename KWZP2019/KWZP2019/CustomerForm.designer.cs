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
            this.editCustomerBtn = new System.Windows.Forms.Button();
            this.endCutstomerFormBtn = new System.Windows.Forms.Button();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.ordersDgv = new System.Windows.Forms.DataGridView();
            this.idOrderCustomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCustomerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.customersDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addNewCustomerBtn
            // 
            this.addNewCustomerBtn.Location = new System.Drawing.Point(247, 6);
            this.addNewCustomerBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addNewCustomerBtn.Name = "addNewCustomerBtn";
            this.addNewCustomerBtn.Size = new System.Drawing.Size(111, 22);
            this.addNewCustomerBtn.TabIndex = 1;
            this.addNewCustomerBtn.Text = "Dodaj klienta";
            this.addNewCustomerBtn.UseVisualStyleBackColor = true;
            this.addNewCustomerBtn.Click += new System.EventHandler(this.addNewCustomerBtn_Click);
            // 
            // orderBtn
            // 
            this.orderBtn.Location = new System.Drawing.Point(548, 6);
            this.orderBtn.Margin = new System.Windows.Forms.Padding(2);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(111, 21);
            this.orderBtn.TabIndex = 12;
            this.orderBtn.Text = "Zamówienie";
            this.orderBtn.UseVisualStyleBackColor = true;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // customersDgv
            // 
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
            this.customersDgv.MultiSelect = false;
            this.customersDgv.Name = "customersDgv";
            this.customersDgv.RowTemplate.Height = 24;
            this.customersDgv.Size = new System.Drawing.Size(624, 122);
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
            // editCustomerBtn
            // 
            this.editCustomerBtn.Location = new System.Drawing.Point(374, 6);
            this.editCustomerBtn.Name = "editCustomerBtn";
            this.editCustomerBtn.Size = new System.Drawing.Size(145, 21);
            this.editCustomerBtn.TabIndex = 16;
            this.editCustomerBtn.Text = "Edytuj klienta";
            this.editCustomerBtn.UseVisualStyleBackColor = true;
            this.editCustomerBtn.Click += new System.EventHandler(this.editCustomerBtn_Click);
            // 
            // endCutstomerFormBtn
            // 
            this.endCutstomerFormBtn.Location = new System.Drawing.Point(36, 392);
            this.endCutstomerFormBtn.Name = "endCutstomerFormBtn";
            this.endCutstomerFormBtn.Size = new System.Drawing.Size(128, 30);
            this.endCutstomerFormBtn.TabIndex = 17;
            this.endCutstomerFormBtn.Text = "Koniec";
            this.endCutstomerFormBtn.UseVisualStyleBackColor = true;
            this.endCutstomerFormBtn.Click += new System.EventHandler(this.endCutstomerFormBtn_Click);
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(82, 8);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(149, 20);
            this.searchTxt.TabIndex = 18;
            this.searchTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchTxt_KeyPress);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(381, 392);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(107, 29);
            this.cancelBtn.TabIndex = 19;
            this.cancelBtn.Text = "Anuluj";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            this.saveBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveBtn.Location = new System.Drawing.Point(531, 392);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(128, 30);
            this.saveBtn.TabIndex = 20;
            this.saveBtn.Text = "Zapisz";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // ordersDgv
            // 
            this.ordersDgv.AutoGenerateColumns = false;
            this.ordersDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOrderCustomerDataGridViewTextBoxColumn,
            this.idCustomerDataGridViewTextBoxColumn1,
            this.orderDateDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.employeeDataGridViewTextBoxColumn,
            this.orderDetailsDataGridViewTextBoxColumn});
            this.ordersDgv.DataSource = this.orderCustomerBindingSource;
            this.ordersDgv.Location = new System.Drawing.Point(35, 232);
            this.ordersDgv.Name = "ordersDgv";
            this.ordersDgv.Size = new System.Drawing.Size(622, 128);
            this.ordersDgv.TabIndex = 21;
            // 
            // idOrderCustomerDataGridViewTextBoxColumn
            // 
            this.idOrderCustomerDataGridViewTextBoxColumn.DataPropertyName = "IdOrderCustomer";
            this.idOrderCustomerDataGridViewTextBoxColumn.HeaderText = "IdOrderCustomer";
            this.idOrderCustomerDataGridViewTextBoxColumn.Name = "idOrderCustomerDataGridViewTextBoxColumn";
            // 
            // idCustomerDataGridViewTextBoxColumn1
            // 
            this.idCustomerDataGridViewTextBoxColumn1.DataPropertyName = "IdCustomer";
            this.idCustomerDataGridViewTextBoxColumn1.HeaderText = "IdCustomer";
            this.idCustomerDataGridViewTextBoxColumn1.Name = "idCustomerDataGridViewTextBoxColumn1";
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
            // orderDetailsDataGridViewTextBoxColumn
            // 
            this.orderDetailsDataGridViewTextBoxColumn.DataPropertyName = "OrderDetails";
            this.orderDetailsDataGridViewTextBoxColumn.HeaderText = "OrderDetails";
            this.orderDetailsDataGridViewTextBoxColumn.Name = "orderDetailsDataGridViewTextBoxColumn";
            // 
            // orderCustomerBindingSource
            // 
            this.orderCustomerBindingSource.DataSource = typeof(KWZP2019.OrderCustomer);
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
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 612);
            this.Controls.Add(this.ordersDgv);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.endCutstomerFormBtn);
            this.Controls.Add(this.editCustomerBtn);
            this.Controls.Add(this.customersDgv);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.orderBtn);
            this.Controls.Add(this.addNewCustomerBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addNewCustomerBtn;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.DataGridView customersDgv;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Button editCustomerBtn;
        private System.Windows.Forms.Button endCutstomerFormBtn;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.DataGridView ordersDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOrderCustomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCustomerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderCustomerBindingSource;
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
    }
}