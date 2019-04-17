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
            this.productionBtn = new System.Windows.Forms.Button();
            this.transportBtn = new System.Windows.Forms.Button();
            this.warehouseBtn = new System.Windows.Forms.Button();
            this.orderDetailsGb = new System.Windows.Forms.GroupBox();
            this.amountTb = new System.Windows.Forms.TextBox();
            this.productTb = new System.Windows.Forms.TextBox();
            this.amountLbl = new System.Windows.Forms.Label();
            this.productLbl = new System.Windows.Forms.Label();
            this.orderDetailsBtn = new System.Windows.Forms.Button();
            this.costTb = new System.Windows.Forms.TextBox();
            this.dateTb = new System.Windows.Forms.TextBox();
            this.codeTb = new System.Windows.Forms.TextBox();
            this.codeLbl = new System.Windows.Forms.Label();
            this.costLbl = new System.Windows.Forms.Label();
            this.dateLbl = new System.Windows.Forms.Label();
            this.addOrderGb = new System.Windows.Forms.GroupBox();
            this.productionNewOrderBtn = new System.Windows.Forms.Button();
            this.transportNewOrderBtn = new System.Windows.Forms.Button();
            this.warehouseNewOrderBtn = new System.Windows.Forms.Button();
            this.Szczegolynowegozamowienia = new System.Windows.Forms.GroupBox();
            this.Opis_tb = new System.Windows.Forms.TextBox();
            this.Opis_lbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newOrderDetailsLbl = new System.Windows.Forms.Button();
            this.costNewOrderTb = new System.Windows.Forms.TextBox();
            this.dateNewOrderTb = new System.Windows.Forms.TextBox();
            this.costNewOrderLbl = new System.Windows.Forms.Label();
            this.dateNewOrderLbl = new System.Windows.Forms.Label();
            this.searchOrderGb.SuspendLayout();
            this.orderDetailsGb.SuspendLayout();
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
            this.searchOrderGb.Controls.Add(this.productionBtn);
            this.searchOrderGb.Controls.Add(this.transportBtn);
            this.searchOrderGb.Controls.Add(this.warehouseBtn);
            this.searchOrderGb.Controls.Add(this.orderDetailsGb);
            this.searchOrderGb.Controls.Add(this.orderDetailsBtn);
            this.searchOrderGb.Controls.Add(this.costTb);
            this.searchOrderGb.Controls.Add(this.dateTb);
            this.searchOrderGb.Controls.Add(this.codeTb);
            this.searchOrderGb.Controls.Add(this.codeLbl);
            this.searchOrderGb.Controls.Add(this.costLbl);
            this.searchOrderGb.Controls.Add(this.dateLbl);
            this.searchOrderGb.Location = new System.Drawing.Point(242, 30);
            this.searchOrderGb.Name = "searchOrderGb";
            this.searchOrderGb.Size = new System.Drawing.Size(798, 339);
            this.searchOrderGb.TabIndex = 2;
            this.searchOrderGb.TabStop = false;
            this.searchOrderGb.Text = "WyszukajZamowienie";
            this.searchOrderGb.Visible = false;
            // 
            // productionBtn
            // 
            this.productionBtn.Location = new System.Drawing.Point(580, 157);
            this.productionBtn.Name = "productionBtn";
            this.productionBtn.Size = new System.Drawing.Size(169, 42);
            this.productionBtn.TabIndex = 15;
            this.productionBtn.Text = "Przekazanie do produkcji";
            this.productionBtn.UseVisualStyleBackColor = true;
            // 
            // transportBtn
            // 
            this.transportBtn.Location = new System.Drawing.Point(390, 157);
            this.transportBtn.Name = "transportBtn";
            this.transportBtn.Size = new System.Drawing.Size(169, 42);
            this.transportBtn.TabIndex = 14;
            this.transportBtn.Text = "Transport do Klienta";
            this.transportBtn.UseVisualStyleBackColor = true;
            this.transportBtn.Click += new System.EventHandler(this.transportBtn_Click);
            // 
            // warehouseBtn
            // 
            this.warehouseBtn.Location = new System.Drawing.Point(199, 155);
            this.warehouseBtn.Name = "warehouseBtn";
            this.warehouseBtn.Size = new System.Drawing.Size(169, 44);
            this.warehouseBtn.TabIndex = 10;
            this.warehouseBtn.Text = "Stan magazynowy";
            this.warehouseBtn.UseVisualStyleBackColor = true;
            this.warehouseBtn.Click += new System.EventHandler(this.warehouseBtn_Click);
            // 
            // orderDetailsGb
            // 
            this.orderDetailsGb.Controls.Add(this.amountTb);
            this.orderDetailsGb.Controls.Add(this.productTb);
            this.orderDetailsGb.Controls.Add(this.amountLbl);
            this.orderDetailsGb.Controls.Add(this.productLbl);
            this.orderDetailsGb.Location = new System.Drawing.Point(20, 215);
            this.orderDetailsGb.Name = "orderDetailsGb";
            this.orderDetailsGb.Size = new System.Drawing.Size(400, 114);
            this.orderDetailsGb.TabIndex = 9;
            this.orderDetailsGb.TabStop = false;
            this.orderDetailsGb.Text = "SzczegolyZamowienia";
            this.orderDetailsGb.Visible = false;
            // 
            // amountTb
            // 
            this.amountTb.Location = new System.Drawing.Point(115, 69);
            this.amountTb.Name = "amountTb";
            this.amountTb.Size = new System.Drawing.Size(266, 22);
            this.amountTb.TabIndex = 12;
            // 
            // productTb
            // 
            this.productTb.Location = new System.Drawing.Point(115, 36);
            this.productTb.Name = "productTb";
            this.productTb.Size = new System.Drawing.Size(266, 22);
            this.productTb.TabIndex = 11;
            // 
            // amountLbl
            // 
            this.amountLbl.AutoSize = true;
            this.amountLbl.Location = new System.Drawing.Point(8, 72);
            this.amountLbl.Name = "amountLbl";
            this.amountLbl.Size = new System.Drawing.Size(36, 17);
            this.amountLbl.TabIndex = 5;
            this.amountLbl.Text = "Ilość";
            // 
            // productLbl
            // 
            this.productLbl.AutoSize = true;
            this.productLbl.Location = new System.Drawing.Point(8, 36);
            this.productLbl.Name = "productLbl";
            this.productLbl.Size = new System.Drawing.Size(57, 17);
            this.productLbl.TabIndex = 4;
            this.productLbl.Text = "Produkt";
            // 
            // orderDetailsBtn
            // 
            this.orderDetailsBtn.Location = new System.Drawing.Point(6, 155);
            this.orderDetailsBtn.Name = "orderDetailsBtn";
            this.orderDetailsBtn.Size = new System.Drawing.Size(169, 44);
            this.orderDetailsBtn.TabIndex = 8;
            this.orderDetailsBtn.Text = "Szczegóły zamówienia";
            this.orderDetailsBtn.UseVisualStyleBackColor = true;
            this.orderDetailsBtn.Click += new System.EventHandler(this.orderDetailsBtn_Click);
            // 
            // costTb
            // 
            this.costTb.Location = new System.Drawing.Point(154, 98);
            this.costTb.Name = "costTb";
            this.costTb.Size = new System.Drawing.Size(266, 22);
            this.costTb.TabIndex = 7;
            // 
            // dateTb
            // 
            this.dateTb.Location = new System.Drawing.Point(154, 68);
            this.dateTb.Name = "dateTb";
            this.dateTb.Size = new System.Drawing.Size(266, 22);
            this.dateTb.TabIndex = 6;
            // 
            // codeTb
            // 
            this.codeTb.Location = new System.Drawing.Point(154, 38);
            this.codeTb.Name = "codeTb";
            this.codeTb.Size = new System.Drawing.Size(266, 22);
            this.codeTb.TabIndex = 5;
            // 
            // codeLbl
            // 
            this.codeLbl.AutoSize = true;
            this.codeLbl.Location = new System.Drawing.Point(17, 38);
            this.codeLbl.Name = "codeLbl";
            this.codeLbl.Size = new System.Drawing.Size(33, 17);
            this.codeLbl.TabIndex = 3;
            this.codeLbl.Text = "Kod";
            // 
            // costLbl
            // 
            this.costLbl.AutoSize = true;
            this.costLbl.Location = new System.Drawing.Point(17, 98);
            this.costLbl.Name = "costLbl";
            this.costLbl.Size = new System.Drawing.Size(120, 17);
            this.costLbl.TabIndex = 2;
            this.costLbl.Text = "Koszt zamówienia";
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Location = new System.Drawing.Point(17, 68);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(98, 17);
            this.dateLbl.TabIndex = 1;
            this.dateLbl.Text = "Data przyjęcia";
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
            this.addOrderGb.Location = new System.Drawing.Point(242, 375);
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
            this.Szczegolynowegozamowienia.Controls.Add(this.textBox3);
            this.Szczegolynowegozamowienia.Controls.Add(this.label1);
            this.Szczegolynowegozamowienia.Controls.Add(this.label2);
            this.Szczegolynowegozamowienia.Controls.Add(this.label3);
            this.Szczegolynowegozamowienia.Location = new System.Drawing.Point(20, 197);
            this.Szczegolynowegozamowienia.Name = "Szczegolynowegozamowienia";
            this.Szczegolynowegozamowienia.Size = new System.Drawing.Size(405, 193);
            this.Szczegolynowegozamowienia.TabIndex = 9;
            this.Szczegolynowegozamowienia.TabStop = false;
            this.Szczegolynowegozamowienia.Text = "SzczegolyNowegoZamowienia";
            this.Szczegolynowegozamowienia.Visible = false;
            // 
            // Opis_tb
            // 
            this.Opis_tb.Location = new System.Drawing.Point(126, 143);
            this.Opis_tb.Name = "Opis_tb";
            this.Opis_tb.Size = new System.Drawing.Size(266, 22);
            this.Opis_tb.TabIndex = 14;
            // 
            // Opis_lbl
            // 
            this.Opis_lbl.AutoSize = true;
            this.Opis_lbl.Location = new System.Drawing.Point(19, 143);
            this.Opis_lbl.Name = "Opis_lbl";
            this.Opis_lbl.Size = new System.Drawing.Size(37, 17);
            this.Opis_lbl.TabIndex = 13;
            this.Opis_lbl.Text = "Opis";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(266, 22);
            this.textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(126, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(266, 22);
            this.textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(126, 40);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(266, 22);
            this.textBox3.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ilość";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Produkt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID_szczegółu";
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
            this.searchOrderGb.PerformLayout();
            this.orderDetailsGb.ResumeLayout(false);
            this.orderDetailsGb.PerformLayout();
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
        private System.Windows.Forms.GroupBox orderDetailsGb;
        private System.Windows.Forms.Label amountLbl;
        private System.Windows.Forms.Label productLbl;
        private System.Windows.Forms.Button orderDetailsBtn;
        private System.Windows.Forms.TextBox costTb;
        private System.Windows.Forms.TextBox dateTb;
        private System.Windows.Forms.TextBox codeTb;
        private System.Windows.Forms.Label codeLbl;
        private System.Windows.Forms.Label costLbl;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.TextBox amountTb;
        private System.Windows.Forms.TextBox productTb;
        private System.Windows.Forms.Button transportBtn;
        private System.Windows.Forms.Button warehouseBtn;
        private System.Windows.Forms.Button productionBtn;
        private System.Windows.Forms.GroupBox addOrderGb;
        private System.Windows.Forms.Button productionNewOrderBtn;
        private System.Windows.Forms.Button transportNewOrderBtn;
        private System.Windows.Forms.Button warehouseNewOrderBtn;
        private System.Windows.Forms.GroupBox Szczegolynowegozamowienia;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button newOrderDetailsLbl;
        private System.Windows.Forms.TextBox costNewOrderTb;
        private System.Windows.Forms.TextBox dateNewOrderTb;
        private System.Windows.Forms.Label costNewOrderLbl;
        private System.Windows.Forms.Label dateNewOrderLbl;
        private System.Windows.Forms.Label Opis_lbl;
        private System.Windows.Forms.TextBox Opis_tb;
    }
}