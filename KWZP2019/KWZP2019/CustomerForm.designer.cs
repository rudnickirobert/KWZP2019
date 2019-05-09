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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.addNewCustomerBtn = new System.Windows.Forms.Button();
            this.orderBtn = new System.Windows.Forms.Button();
            this.customersDgv = new System.Windows.Forms.DataGridView();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameLbl = new System.Windows.Forms.Label();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.returnBtn = new System.Windows.Forms.Button();
            this.ordersDgv = new System.Windows.Forms.DataGridView();
            this.orderCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addNewOrderDetailBtn = new System.Windows.Forms.Button();
            this.orderDetailsDgv = new System.Windows.Forms.DataGridView();
            this.generateReportBtn = new System.Windows.Forms.Button();
            this.orderDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderLbl = new System.Windows.Forms.Label();
            this.orderDetailLbl = new System.Windows.Forms.Label();
            this.deleteOrderDetailBtn = new System.Windows.Forms.Button();
            this.warehouseBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customersDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addNewCustomerBtn
            // 
            this.addNewCustomerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.addNewCustomerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.addNewCustomerBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addNewCustomerBtn.Location = new System.Drawing.Point(936, 28);
            this.addNewCustomerBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addNewCustomerBtn.Name = "addNewCustomerBtn";
            this.addNewCustomerBtn.Size = new System.Drawing.Size(230, 55);
            this.addNewCustomerBtn.TabIndex = 1;
            this.addNewCustomerBtn.Text = "Dodaj klienta";
            this.addNewCustomerBtn.UseVisualStyleBackColor = false;
            this.addNewCustomerBtn.Click += new System.EventHandler(this.addNewCustomerBtn_Click);
            // 
            // orderBtn
            // 
            this.orderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.orderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.orderBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.orderBtn.Location = new System.Drawing.Point(16, 307);
            this.orderBtn.Margin = new System.Windows.Forms.Padding(2);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(230, 55);
            this.orderBtn.TabIndex = 12;
            this.orderBtn.Text = "Dodaj zamówienie";
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
            this.customersDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customersDgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.customersDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customersDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.customersDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customersDgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.customersDgv.EnableHeadersVisualStyles = false;
            this.customersDgv.Location = new System.Drawing.Point(14, 101);
            this.customersDgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customersDgv.Name = "customersDgv";
            this.customersDgv.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(86)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.customersDgv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.customersDgv.RowTemplate.Height = 24;
            this.customersDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customersDgv.Size = new System.Drawing.Size(1152, 161);
            this.customersDgv.TabIndex = 15;
            this.customersDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customersDgv_CellContentClick);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.BackColor = System.Drawing.Color.Transparent;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.nameLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nameLbl.Location = new System.Drawing.Point(11, 40);
            this.nameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(205, 29);
            this.nameLbl.TabIndex = 13;
            this.nameLbl.Text = "Szukaj po nazwie:";
            // 
            // searchTxt
            // 
            this.searchTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.searchTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.searchTxt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchTxt.Location = new System.Drawing.Point(220, 37);
            this.searchTxt.Margin = new System.Windows.Forms.Padding(2);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(230, 35);
            this.searchTxt.TabIndex = 18;
            this.searchTxt.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
            // 
            // returnBtn
            // 
            this.returnBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.returnBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.returnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.returnBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.returnBtn.Image = ((System.Drawing.Image)(resources.GetObject("returnBtn.Image")));
            this.returnBtn.Location = new System.Drawing.Point(16, 617);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(200, 120);
            this.returnBtn.TabIndex = 19;
            this.returnBtn.Text = "Powrót";
            this.returnBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.returnBtn.UseVisualStyleBackColor = false;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // ordersDgv
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.ordersDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ordersDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ordersDgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.ordersDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ordersDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ordersDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ordersDgv.DefaultCellStyle = dataGridViewCellStyle7;
            this.ordersDgv.EnableHeadersVisualStyles = false;
            this.ordersDgv.Location = new System.Drawing.Point(16, 437);
            this.ordersDgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ordersDgv.Name = "ordersDgv";
            this.ordersDgv.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(86)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.ordersDgv.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.ordersDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ordersDgv.Size = new System.Drawing.Size(722, 126);
            this.ordersDgv.TabIndex = 21;
            this.ordersDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ordersDgv_CellContentClick);
            // 
            // addNewOrderDetailBtn
            // 
            this.addNewOrderDetailBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.addNewOrderDetailBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.addNewOrderDetailBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addNewOrderDetailBtn.Location = new System.Drawing.Point(881, 307);
            this.addNewOrderDetailBtn.Name = "addNewOrderDetailBtn";
            this.addNewOrderDetailBtn.Size = new System.Drawing.Size(230, 55);
            this.addNewOrderDetailBtn.TabIndex = 22;
            this.addNewOrderDetailBtn.Text = "Dodaj szczegół ";
            this.addNewOrderDetailBtn.UseVisualStyleBackColor = false;
            this.addNewOrderDetailBtn.Click += new System.EventHandler(this.addNewOrderDetailBtn_Click);
            // 
            // orderDetailsDgv
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.orderDetailsDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.orderDetailsDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderDetailsDgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.orderDetailsDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderDetailsDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.orderDetailsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.orderDetailsDgv.DefaultCellStyle = dataGridViewCellStyle11;
            this.orderDetailsDgv.EnableHeadersVisualStyles = false;
            this.orderDetailsDgv.Location = new System.Drawing.Point(752, 437);
            this.orderDetailsDgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderDetailsDgv.Name = "orderDetailsDgv";
            this.orderDetailsDgv.RowHeadersVisible = false;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(86)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.orderDetailsDgv.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.orderDetailsDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderDetailsDgv.Size = new System.Drawing.Size(415, 126);
            this.orderDetailsDgv.TabIndex = 23;
            // 
            // generateReportBtn
            // 
            this.generateReportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.generateReportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.generateReportBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.generateReportBtn.Location = new System.Drawing.Point(508, 617);
            this.generateReportBtn.Name = "generateReportBtn";
            this.generateReportBtn.Size = new System.Drawing.Size(230, 55);
            this.generateReportBtn.TabIndex = 24;
            this.generateReportBtn.Text = "Generuj raport";
            this.generateReportBtn.UseVisualStyleBackColor = false;
            this.generateReportBtn.Click += new System.EventHandler(this.generateReportBtn_Click);
            // 
            // orderLbl
            // 
            this.orderLbl.AutoSize = true;
            this.orderLbl.BackColor = System.Drawing.Color.Transparent;
            this.orderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.orderLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.orderLbl.Location = new System.Drawing.Point(11, 389);
            this.orderLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderLbl.Name = "orderLbl";
            this.orderLbl.Size = new System.Drawing.Size(227, 29);
            this.orderLbl.TabIndex = 25;
            this.orderLbl.Text = "Zamówienie klienta:";
            // 
            // orderDetailLbl
            // 
            this.orderDetailLbl.AutoSize = true;
            this.orderDetailLbl.BackColor = System.Drawing.Color.Transparent;
            this.orderDetailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.orderDetailLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.orderDetailLbl.Location = new System.Drawing.Point(747, 389);
            this.orderDetailLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderDetailLbl.Name = "orderDetailLbl";
            this.orderDetailLbl.Size = new System.Drawing.Size(265, 29);
            this.orderDetailLbl.TabIndex = 26;
            this.orderDetailLbl.Text = "Szczegóły zamówienia:";
            // 
            // deleteOrderDetailBtn
            // 
            this.deleteOrderDetailBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.deleteOrderDetailBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.deleteOrderDetailBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteOrderDetailBtn.Location = new System.Drawing.Point(881, 617);
            this.deleteOrderDetailBtn.Name = "deleteOrderDetailBtn";
            this.deleteOrderDetailBtn.Size = new System.Drawing.Size(230, 55);
            this.deleteOrderDetailBtn.TabIndex = 27;
            this.deleteOrderDetailBtn.Text = "Usuń szczegół";
            this.deleteOrderDetailBtn.UseVisualStyleBackColor = false;
            this.deleteOrderDetailBtn.Click += new System.EventHandler(this.deleteOrderDetailBtn_Click);
            // 
            // warehouseBtn
            // 
            this.warehouseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.warehouseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.warehouseBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.warehouseBtn.Location = new System.Drawing.Point(220, 617);
            this.warehouseBtn.Name = "warehouseBtn";
            this.warehouseBtn.Size = new System.Drawing.Size(221, 120);
            this.warehouseBtn.TabIndex = 24;
            this.warehouseBtn.Text = "Sprwadź stan magazynowy półfabrykatu";
            this.warehouseBtn.UseVisualStyleBackColor = false;
            this.warehouseBtn.Click += new System.EventHandler(this.warehouseBtn_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.deleteOrderDetailBtn);
            this.Controls.Add(this.orderDetailLbl);
            this.Controls.Add(this.orderLbl);
            this.Controls.Add(this.warehouseBtn);
            this.Controls.Add(this.generateReportBtn);
            this.Controls.Add(this.orderBtn);
            this.Controls.Add(this.orderDetailsDgv);
            this.Controls.Add(this.addNewOrderDetailBtn);
            this.Controls.Add(this.ordersDgv);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.customersDgv);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.addNewCustomerBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Klient";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addNewCustomerBtn;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.DataGridView customersDgv;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.DataGridView ordersDgv;
        private System.Windows.Forms.BindingSource orderCustomerBindingSource;
        private System.Windows.Forms.Button addNewOrderDetailBtn;
        private System.Windows.Forms.BindingSource orderDetailBindingSource;
        private System.Windows.Forms.Button generateReportBtn;
        private System.Windows.Forms.DataGridView orderDetailsDgv;
        private System.Windows.Forms.Label orderLbl;
        private System.Windows.Forms.Label orderDetailLbl;
        private System.Windows.Forms.Button deleteOrderDetailBtn;
        private System.Windows.Forms.Button warehouseBtn;
    }
}