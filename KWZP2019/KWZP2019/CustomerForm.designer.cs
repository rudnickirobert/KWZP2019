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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.addNewCustomerBtn = new System.Windows.Forms.Button();
            this.orderBtn = new System.Windows.Forms.Button();
            this.customersDgv = new System.Windows.Forms.DataGridView();
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
            this.nameLbl = new System.Windows.Forms.Label();
            this.editCustomerBtn = new System.Windows.Forms.Button();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.backBtn = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.customersDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderCustomerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addNewCustomerBtn
            // 
            this.addNewCustomerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.addNewCustomerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.addNewCustomerBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addNewCustomerBtn.Image = ((System.Drawing.Image)(resources.GetObject("addNewCustomerBtn.Image")));
            this.addNewCustomerBtn.Location = new System.Drawing.Point(554, 594);
            this.addNewCustomerBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addNewCustomerBtn.Name = "addNewCustomerBtn";
            this.addNewCustomerBtn.Size = new System.Drawing.Size(267, 148);
            this.addNewCustomerBtn.TabIndex = 1;
            this.addNewCustomerBtn.Text = "Dodaj klienta";
            this.addNewCustomerBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addNewCustomerBtn.UseVisualStyleBackColor = false;
            this.addNewCustomerBtn.Click += new System.EventHandler(this.addNewCustomerBtn_Click);
            // 
            // orderBtn
            // 
            this.orderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.orderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.orderBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.orderBtn.Image = ((System.Drawing.Image)(resources.GetObject("orderBtn.Image")));
            this.orderBtn.Location = new System.Drawing.Point(828, 422);
            this.orderBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(267, 148);
            this.orderBtn.TabIndex = 12;
            this.orderBtn.Text = "Dodaj zamówienie";
            this.orderBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.orderBtn.UseVisualStyleBackColor = false;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // customersDgv
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.customersDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.customersDgv.AutoGenerateColumns = false;
            this.customersDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.customersDgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.customersDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.customersDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.customersDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
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
            this.customersDgv.EnableHeadersVisualStyles = false;
            this.customersDgv.Location = new System.Drawing.Point(22, 69);
            this.customersDgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customersDgv.MultiSelect = false;
            this.customersDgv.Name = "customersDgv";
            this.customersDgv.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(86)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.customersDgv.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.customersDgv.RowTemplate.Height = 24;
            this.customersDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customersDgv.Size = new System.Drawing.Size(1148, 176);
            this.customersDgv.TabIndex = 15;
            this.customersDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customersDgv_CellContentClick);
            // 
            // idCustomerDataGridViewTextBoxColumn
            // 
            this.idCustomerDataGridViewTextBoxColumn.DataPropertyName = "IdCustomer";
            this.idCustomerDataGridViewTextBoxColumn.HeaderText = "IdCustomer";
            this.idCustomerDataGridViewTextBoxColumn.Name = "idCustomerDataGridViewTextBoxColumn";
            this.idCustomerDataGridViewTextBoxColumn.Width = 133;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.Width = 166;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Width = 154;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 84;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.Width = 70;
            // 
            // zipCodeDataGridViewTextBoxColumn
            // 
            this.zipCodeDataGridViewTextBoxColumn.DataPropertyName = "ZipCode";
            this.zipCodeDataGridViewTextBoxColumn.HeaderText = "ZipCode";
            this.zipCodeDataGridViewTextBoxColumn.Name = "zipCodeDataGridViewTextBoxColumn";
            this.zipCodeDataGridViewTextBoxColumn.Width = 105;
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "Street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "Street";
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            this.streetDataGridViewTextBoxColumn.Width = 88;
            // 
            // houseNumberDataGridViewTextBoxColumn
            // 
            this.houseNumberDataGridViewTextBoxColumn.DataPropertyName = "HouseNumber";
            this.houseNumberDataGridViewTextBoxColumn.HeaderText = "HouseNumber";
            this.houseNumberDataGridViewTextBoxColumn.Name = "houseNumberDataGridViewTextBoxColumn";
            this.houseNumberDataGridViewTextBoxColumn.Width = 156;
            // 
            // apartmentNumberDataGridViewTextBoxColumn
            // 
            this.apartmentNumberDataGridViewTextBoxColumn.DataPropertyName = "ApartmentNumber";
            this.apartmentNumberDataGridViewTextBoxColumn.HeaderText = "ApartmentNumber";
            this.apartmentNumberDataGridViewTextBoxColumn.Name = "apartmentNumberDataGridViewTextBoxColumn";
            this.apartmentNumberDataGridViewTextBoxColumn.Width = 188;
            // 
            // peselDataGridViewTextBoxColumn
            // 
            this.peselDataGridViewTextBoxColumn.DataPropertyName = "Pesel";
            this.peselDataGridViewTextBoxColumn.HeaderText = "Pesel";
            this.peselDataGridViewTextBoxColumn.Name = "peselDataGridViewTextBoxColumn";
            this.peselDataGridViewTextBoxColumn.Width = 84;
            // 
            // nIPDataGridViewTextBoxColumn
            // 
            this.nIPDataGridViewTextBoxColumn.DataPropertyName = "NIP";
            this.nIPDataGridViewTextBoxColumn.HeaderText = "NIP";
            this.nIPDataGridViewTextBoxColumn.Name = "nIPDataGridViewTextBoxColumn";
            this.nIPDataGridViewTextBoxColumn.Width = 67;
            // 
            // kRSDataGridViewTextBoxColumn
            // 
            this.kRSDataGridViewTextBoxColumn.DataPropertyName = "KRS";
            this.kRSDataGridViewTextBoxColumn.HeaderText = "KRS";
            this.kRSDataGridViewTextBoxColumn.Name = "kRSDataGridViewTextBoxColumn";
            this.kRSDataGridViewTextBoxColumn.Width = 74;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 134;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(KWZP2019.Customer);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.BackColor = System.Drawing.Color.Transparent;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.nameLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nameLbl.Location = new System.Drawing.Point(38, 25);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(72, 24);
            this.nameLbl.TabIndex = 13;
            this.nameLbl.Text = "Nazwa";
            // 
            // editCustomerBtn
            // 
            this.editCustomerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.editCustomerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.editCustomerBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.editCustomerBtn.Image = ((System.Drawing.Image)(resources.GetObject("editCustomerBtn.Image")));
            this.editCustomerBtn.Location = new System.Drawing.Point(828, 594);
            this.editCustomerBtn.Margin = new System.Windows.Forms.Padding(4);
            this.editCustomerBtn.Name = "editCustomerBtn";
            this.editCustomerBtn.Size = new System.Drawing.Size(267, 148);
            this.editCustomerBtn.TabIndex = 16;
            this.editCustomerBtn.Text = "Edytuj klienta";
            this.editCustomerBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.editCustomerBtn.UseVisualStyleBackColor = false;
            this.editCustomerBtn.Click += new System.EventHandler(this.editCustomerBtn_Click);
            // 
            // searchTxt
            // 
            this.searchTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.searchTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.searchTxt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchTxt.Location = new System.Drawing.Point(126, 25);
            this.searchTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(360, 28);
            this.searchTxt.TabIndex = 18;
            this.searchTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchTxt_KeyPress);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.backBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.backBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(280, 594);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(267, 148);
            this.backBtn.TabIndex = 19;
            this.backBtn.Text = "Powrót";
            this.backBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.backBtn.UseVisualStyleBackColor = false;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.saveBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.saveBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveBtn.Image")));
            this.saveBtn.Location = new System.Drawing.Point(5, 594);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(267, 148);
            this.saveBtn.TabIndex = 20;
            this.saveBtn.Text = "Zatwierdź";
            this.saveBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // ordersDgv
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.ordersDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ordersDgv.AutoGenerateColumns = false;
            this.ordersDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ordersDgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.ordersDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ordersDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.ordersDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ordersDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOrderCustomerDataGridViewTextBoxColumn,
            this.idCustomerDataGridViewTextBoxColumn1,
            this.orderDateDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.employeeDataGridViewTextBoxColumn,
            this.orderDetailsDataGridViewTextBoxColumn});
            this.ordersDgv.DataSource = this.orderCustomerBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ordersDgv.DefaultCellStyle = dataGridViewCellStyle6;
            this.ordersDgv.EnableHeadersVisualStyles = false;
            this.ordersDgv.Location = new System.Drawing.Point(22, 294);
            this.ordersDgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ordersDgv.MultiSelect = false;
            this.ordersDgv.Name = "ordersDgv";
            this.ordersDgv.RowHeadersVisible = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(86)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.ordersDgv.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.ordersDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ordersDgv.Size = new System.Drawing.Size(901, 124);
            this.ordersDgv.TabIndex = 21;
            // 
            // idOrderCustomerDataGridViewTextBoxColumn
            // 
            this.idOrderCustomerDataGridViewTextBoxColumn.DataPropertyName = "IdOrderCustomer";
            this.idOrderCustomerDataGridViewTextBoxColumn.HeaderText = "IdOrderCustomer";
            this.idOrderCustomerDataGridViewTextBoxColumn.Name = "idOrderCustomerDataGridViewTextBoxColumn";
            this.idOrderCustomerDataGridViewTextBoxColumn.Width = 181;
            // 
            // idCustomerDataGridViewTextBoxColumn1
            // 
            this.idCustomerDataGridViewTextBoxColumn1.DataPropertyName = "IdCustomer";
            this.idCustomerDataGridViewTextBoxColumn1.HeaderText = "IdCustomer";
            this.idCustomerDataGridViewTextBoxColumn1.Name = "idCustomerDataGridViewTextBoxColumn1";
            this.idCustomerDataGridViewTextBoxColumn1.Width = 133;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.Width = 76;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.Width = 118;
            // 
            // employeeDataGridViewTextBoxColumn
            // 
            this.employeeDataGridViewTextBoxColumn.DataPropertyName = "Employee";
            this.employeeDataGridViewTextBoxColumn.HeaderText = "Employee";
            this.employeeDataGridViewTextBoxColumn.Name = "employeeDataGridViewTextBoxColumn";
            this.employeeDataGridViewTextBoxColumn.Width = 118;
            // 
            // orderDetailsDataGridViewTextBoxColumn
            // 
            this.orderDetailsDataGridViewTextBoxColumn.DataPropertyName = "OrderDetails";
            this.orderDetailsDataGridViewTextBoxColumn.HeaderText = "OrderDetails";
            this.orderDetailsDataGridViewTextBoxColumn.Name = "orderDetailsDataGridViewTextBoxColumn";
            this.orderDetailsDataGridViewTextBoxColumn.Width = 145;
            // 
            // orderCustomerBindingSource
            // 
            this.orderCustomerBindingSource.DataSource = typeof(KWZP2019.OrderCustomer);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.ordersDgv);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.editCustomerBtn);
            this.Controls.Add(this.customersDgv);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.orderBtn);
            this.Controls.Add(this.addNewCustomerBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderCustomerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addNewCustomerBtn;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.DataGridView customersDgv;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Button editCustomerBtn;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Button backBtn;
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