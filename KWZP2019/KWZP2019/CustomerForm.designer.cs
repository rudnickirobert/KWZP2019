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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
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
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            this.customersDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.customersDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customersDgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.customersDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customersDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.customersDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customersDgv.DefaultCellStyle = dataGridViewCellStyle15;
            this.customersDgv.EnableHeadersVisualStyles = false;
            this.customersDgv.Location = new System.Drawing.Point(14, 101);
            this.customersDgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customersDgv.Name = "customersDgv";
            this.customersDgv.RowHeadersVisible = false;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(86)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            this.customersDgv.RowsDefaultCellStyle = dataGridViewCellStyle16;
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
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            this.ordersDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.ordersDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ordersDgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.ordersDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ordersDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.ordersDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ordersDgv.DefaultCellStyle = dataGridViewCellStyle19;
            this.ordersDgv.EnableHeadersVisualStyles = false;
            this.ordersDgv.Location = new System.Drawing.Point(16, 437);
            this.ordersDgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ordersDgv.Name = "ordersDgv";
            this.ordersDgv.RowHeadersVisible = false;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(86)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White;
            this.ordersDgv.RowsDefaultCellStyle = dataGridViewCellStyle20;
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
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.White;
            this.orderDetailsDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.orderDetailsDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderDetailsDgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.orderDetailsDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderDetailsDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.orderDetailsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.orderDetailsDgv.DefaultCellStyle = dataGridViewCellStyle23;
            this.orderDetailsDgv.EnableHeadersVisualStyles = false;
            this.orderDetailsDgv.Location = new System.Drawing.Point(752, 437);
            this.orderDetailsDgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderDetailsDgv.Name = "orderDetailsDgv";
            this.orderDetailsDgv.RowHeadersVisible = false;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(86)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.White;
            this.orderDetailsDgv.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.orderDetailsDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderDetailsDgv.Size = new System.Drawing.Size(415, 126);
            this.orderDetailsDgv.TabIndex = 23;
            // 
            // generateReportBtn
            // 
            this.generateReportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.generateReportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.generateReportBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.generateReportBtn.Location = new System.Drawing.Point(340, 617);
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
        private System.Windows.Forms.Button addNewOrderDetailBtn;
        private System.Windows.Forms.BindingSource orderDetailBindingSource;
        private System.Windows.Forms.Button generateReportBtn;
        private System.Windows.Forms.DataGridView orderDetailsDgv;
        private System.Windows.Forms.Label orderLbl;
        private System.Windows.Forms.Label orderDetailLbl;
        private System.Windows.Forms.Button deleteOrderDetailBtn;
    }
}