namespace KWZP2019
{
    partial class OrderForm
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
            this.searchOrderBtn = new System.Windows.Forms.Button();
            this.addOrderBtn = new System.Windows.Forms.Button();
            this.searchOrderGb = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderDetailsBtn = new System.Windows.Forms.Button();
            this.addOrderGb = new System.Windows.Forms.GroupBox();
            this.productionNewOrderBtn = new System.Windows.Forms.Button();
            this.transportNewOrderBtn = new System.Windows.Forms.Button();
            this.warehouseNewOrderBtn = new System.Windows.Forms.Button();
            this.Szczegolynowegozamowienia = new System.Windows.Forms.GroupBox();
            this.Opis_tb = new System.Windows.Forms.TextBox();
            this.Opis_lbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.newOrderDetailsLbl = new System.Windows.Forms.Button();
            this.costNewOrderTb = new System.Windows.Forms.TextBox();
            this.dateNewOrderTb = new System.Windows.Forms.TextBox();
            this.costNewOrderLbl = new System.Windows.Forms.Label();
            this.dateNewOrderLbl = new System.Windows.Forms.Label();
            this.searchOrderGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.addOrderGb.SuspendLayout();
            this.Szczegolynowegozamowienia.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchOrderBtn
            // 
            this.searchOrderBtn.Location = new System.Drawing.Point(12, 30);
            this.searchOrderBtn.Name = "searchOrderBtn";
            this.searchOrderBtn.Size = new System.Drawing.Size(179, 93);
            this.searchOrderBtn.TabIndex = 0;
            this.searchOrderBtn.Text = "Wyszukaj zamówienie";
            this.searchOrderBtn.UseVisualStyleBackColor = true;
            this.searchOrderBtn.Click += new System.EventHandler(this.searchOrderBtn_Click);
            // 
            // addOrderBtn
            // 
            this.addOrderBtn.Location = new System.Drawing.Point(12, 129);
            this.addOrderBtn.Name = "addOrderBtn";
            this.addOrderBtn.Size = new System.Drawing.Size(179, 87);
            this.addOrderBtn.TabIndex = 1;
            this.addOrderBtn.Text = "Dodaj zamówienie";
            this.addOrderBtn.UseVisualStyleBackColor = true;
            // 
            // searchOrderGb
            // 
            this.searchOrderGb.Controls.Add(this.dataGridView2);
            this.searchOrderGb.Controls.Add(this.dataGridView1);
            this.searchOrderGb.Controls.Add(this.orderDetailsBtn);
            this.searchOrderGb.Location = new System.Drawing.Point(242, 30);
            this.searchOrderGb.Name = "searchOrderGb";
            this.searchOrderGb.Size = new System.Drawing.Size(798, 318);
            this.searchOrderGb.TabIndex = 2;
            this.searchOrderGb.TabStop = false;
            this.searchOrderGb.Text = "WyszukajZamowienie";
            this.searchOrderGb.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(42, 214);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(641, 89);
            this.dataGridView2.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(661, 89);
            this.dataGridView1.TabIndex = 16;
            // 
            // orderDetailsBtn
            // 
            this.orderDetailsBtn.Location = new System.Drawing.Point(6, 155);
            this.orderDetailsBtn.Name = "orderDetailsBtn";
            this.orderDetailsBtn.Size = new System.Drawing.Size(169, 44);
            this.orderDetailsBtn.TabIndex = 8;
            this.orderDetailsBtn.Text = "Szczegóły zamówienia";
            this.orderDetailsBtn.UseVisualStyleBackColor = true;
            // 
            // addOrderGb
            // 
            this.addOrderGb.Controls.Add(this.productionNewOrderBtn);
            this.addOrderGb.Controls.Add(this.transportNewOrderBtn);
            this.addOrderGb.Controls.Add(this.warehouseNewOrderBtn);
            this.addOrderGb.Controls.Add(this.Szczegolynowegozamowienia);
            this.addOrderGb.Controls.Add(this.newOrderDetailsLbl);
            this.addOrderGb.Controls.Add(this.costNewOrderTb);
            this.addOrderGb.Controls.Add(this.dateNewOrderTb);
            this.addOrderGb.Controls.Add(this.costNewOrderLbl);
            this.addOrderGb.Controls.Add(this.dateNewOrderLbl);
            this.addOrderGb.Location = new System.Drawing.Point(242, 377);
            this.addOrderGb.Name = "addOrderGb";
            this.addOrderGb.Size = new System.Drawing.Size(798, 408);
            this.addOrderGb.TabIndex = 16;
            this.addOrderGb.TabStop = false;
            this.addOrderGb.Text = "DodajZamowienie";
            this.addOrderGb.Visible = false;
            this.addOrderGb.Enter += new System.EventHandler(this.addOrderGb_Enter);
            // 
            // productionNewOrderBtn
            // 
            this.productionNewOrderBtn.Location = new System.Drawing.Point(579, 131);
            this.productionNewOrderBtn.Name = "productionNewOrderBtn";
            this.productionNewOrderBtn.Size = new System.Drawing.Size(169, 42);
            this.productionNewOrderBtn.TabIndex = 15;
            this.productionNewOrderBtn.Text = "Przekazanie do produkcji";
            this.productionNewOrderBtn.UseVisualStyleBackColor = true;
            // 
            // transportNewOrderBtn
            // 
            this.transportNewOrderBtn.Location = new System.Drawing.Point(390, 131);
            this.transportNewOrderBtn.Name = "transportNewOrderBtn";
            this.transportNewOrderBtn.Size = new System.Drawing.Size(169, 42);
            this.transportNewOrderBtn.TabIndex = 14;
            this.transportNewOrderBtn.Text = "Transport do Klienta";
            this.transportNewOrderBtn.UseVisualStyleBackColor = true;
            // 
            // warehouseNewOrderBtn
            // 
            this.warehouseNewOrderBtn.Location = new System.Drawing.Point(205, 129);
            this.warehouseNewOrderBtn.Name = "warehouseNewOrderBtn";
            this.warehouseNewOrderBtn.Size = new System.Drawing.Size(169, 44);
            this.warehouseNewOrderBtn.TabIndex = 10;
            this.warehouseNewOrderBtn.Text = "Stan magazynowy";
            this.warehouseNewOrderBtn.UseVisualStyleBackColor = true;
            // 
            // Szczegolynowegozamowienia
            // 
            this.Szczegolynowegozamowienia.Controls.Add(this.Opis_tb);
            this.Szczegolynowegozamowienia.Controls.Add(this.Opis_lbl);
            this.Szczegolynowegozamowienia.Controls.Add(this.textBox1);
            this.Szczegolynowegozamowienia.Controls.Add(this.textBox2);
            this.Szczegolynowegozamowienia.Controls.Add(this.label1);
            this.Szczegolynowegozamowienia.Controls.Add(this.label2);
            this.Szczegolynowegozamowienia.Location = new System.Drawing.Point(20, 197);
            this.Szczegolynowegozamowienia.Name = "Szczegolynowegozamowienia";
            this.Szczegolynowegozamowienia.Size = new System.Drawing.Size(400, 158);
            this.Szczegolynowegozamowienia.TabIndex = 9;
            this.Szczegolynowegozamowienia.TabStop = false;
            this.Szczegolynowegozamowienia.Text = "SzczegolyNowegoZamowienia";
            this.Szczegolynowegozamowienia.Visible = false;
            // 
            // Opis_tb
            // 
            this.Opis_tb.Location = new System.Drawing.Point(117, 110);
            this.Opis_tb.Name = "Opis_tb";
            this.Opis_tb.Size = new System.Drawing.Size(266, 22);
            this.Opis_tb.TabIndex = 14;
            // 
            // Opis_lbl
            // 
            this.Opis_lbl.AutoSize = true;
            this.Opis_lbl.Location = new System.Drawing.Point(10, 110);
            this.Opis_lbl.Name = "Opis_lbl";
            this.Opis_lbl.Size = new System.Drawing.Size(37, 17);
            this.Opis_lbl.TabIndex = 13;
            this.Opis_lbl.Text = "Opis";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(266, 22);
            this.textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(117, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(266, 22);
            this.textBox2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ilość";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Produkt";
            // 
            // newOrderDetailsLbl
            // 
            this.newOrderDetailsLbl.Location = new System.Drawing.Point(20, 129);
            this.newOrderDetailsLbl.Name = "newOrderDetailsLbl";
            this.newOrderDetailsLbl.Size = new System.Drawing.Size(169, 44);
            this.newOrderDetailsLbl.TabIndex = 8;
            this.newOrderDetailsLbl.Text = "Szczegóły nowego zamówienia";
            this.newOrderDetailsLbl.UseVisualStyleBackColor = true;
            // 
            // costNewOrderTb
            // 
            this.costNewOrderTb.Location = new System.Drawing.Point(154, 71);
            this.costNewOrderTb.Name = "costNewOrderTb";
            this.costNewOrderTb.Size = new System.Drawing.Size(266, 22);
            this.costNewOrderTb.TabIndex = 7;
            // 
            // dateNewOrderTb
            // 
            this.dateNewOrderTb.Location = new System.Drawing.Point(154, 41);
            this.dateNewOrderTb.Name = "dateNewOrderTb";
            this.dateNewOrderTb.Size = new System.Drawing.Size(266, 22);
            this.dateNewOrderTb.TabIndex = 6;
            // 
            // costNewOrderLbl
            // 
            this.costNewOrderLbl.AutoSize = true;
            this.costNewOrderLbl.Location = new System.Drawing.Point(17, 71);
            this.costNewOrderLbl.Name = "costNewOrderLbl";
            this.costNewOrderLbl.Size = new System.Drawing.Size(120, 17);
            this.costNewOrderLbl.TabIndex = 2;
            this.costNewOrderLbl.Text = "Koszt zamówienia";
            // 
            // dateNewOrderLbl
            // 
            this.dateNewOrderLbl.AutoSize = true;
            this.dateNewOrderLbl.Location = new System.Drawing.Point(17, 41);
            this.dateNewOrderLbl.Name = "dateNewOrderLbl";
            this.dateNewOrderLbl.Size = new System.Drawing.Size(98, 17);
            this.dateNewOrderLbl.TabIndex = 1;
            this.dateNewOrderLbl.Text = "Data przyjęcia";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 945);
            this.Controls.Add(this.addOrderGb);
            this.Controls.Add(this.searchOrderGb);
            this.Controls.Add(this.addOrderBtn);
            this.Controls.Add(this.searchOrderBtn);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.searchOrderGb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.addOrderGb.ResumeLayout(false);
            this.addOrderGb.PerformLayout();
            this.Szczegolynowegozamowienia.ResumeLayout(false);
            this.Szczegolynowegozamowienia.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button searchOrderBtn;
        private System.Windows.Forms.Button addOrderBtn;
        private System.Windows.Forms.GroupBox searchOrderGb;
        private System.Windows.Forms.Button orderDetailsBtn;
        private System.Windows.Forms.GroupBox addOrderGb;
        private System.Windows.Forms.Button productionNewOrderBtn;
        private System.Windows.Forms.Button transportNewOrderBtn;
        private System.Windows.Forms.Button warehouseNewOrderBtn;
        private System.Windows.Forms.GroupBox Szczegolynowegozamowienia;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button newOrderDetailsLbl;
        private System.Windows.Forms.TextBox costNewOrderTb;
        private System.Windows.Forms.TextBox dateNewOrderTb;
        private System.Windows.Forms.Label costNewOrderLbl;
        private System.Windows.Forms.Label dateNewOrderLbl;
        private System.Windows.Forms.Label Opis_lbl;
        private System.Windows.Forms.TextBox Opis_tb;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}