namespace KWZP2019
{
    partial class AddNewOrderForm
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
            this.customerNameLbl = new System.Windows.Forms.Label();
            this.productLbl = new System.Windows.Forms.Label();
            this.quantityLbl = new System.Windows.Forms.Label();
            this.margeLbl = new System.Windows.Forms.Label();
            this.sentToProductionLbl = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.productTb = new System.Windows.Forms.TextBox();
            this.quantityTb = new System.Windows.Forms.TextBox();
            this.margeTb = new System.Windows.Forms.TextBox();
            this.priceTb = new System.Windows.Forms.TextBox();
            this.sentToProductionCb = new System.Windows.Forms.CheckBox();
            this.customerNameTb = new System.Windows.Forms.TextBox();
            this.returnBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customerNameLbl
            // 
            this.customerNameLbl.AutoSize = true;
            this.customerNameLbl.Location = new System.Drawing.Point(24, 36);
            this.customerNameLbl.Name = "customerNameLbl";
            this.customerNameLbl.Size = new System.Drawing.Size(95, 17);
            this.customerNameLbl.TabIndex = 0;
            this.customerNameLbl.Text = "Nazwa klienta";
            // 
            // productLbl
            // 
            this.productLbl.AutoSize = true;
            this.productLbl.Location = new System.Drawing.Point(86, 93);
            this.productLbl.Name = "productLbl";
            this.productLbl.Size = new System.Drawing.Size(57, 17);
            this.productLbl.TabIndex = 1;
            this.productLbl.Text = "Produkt";
            // 
            // quantityLbl
            // 
            this.quantityLbl.AutoSize = true;
            this.quantityLbl.Location = new System.Drawing.Point(86, 137);
            this.quantityLbl.Name = "quantityLbl";
            this.quantityLbl.Size = new System.Drawing.Size(36, 17);
            this.quantityLbl.TabIndex = 2;
            this.quantityLbl.Text = "Ilość";
            // 
            // margeLbl
            // 
            this.margeLbl.AutoSize = true;
            this.margeLbl.Location = new System.Drawing.Point(86, 183);
            this.margeLbl.Name = "margeLbl";
            this.margeLbl.Size = new System.Drawing.Size(47, 17);
            this.margeLbl.TabIndex = 3;
            this.margeLbl.Text = "Marża";
            // 
            // sentToProductionLbl
            // 
            this.sentToProductionLbl.AutoSize = true;
            this.sentToProductionLbl.Location = new System.Drawing.Point(86, 230);
            this.sentToProductionLbl.Name = "sentToProductionLbl";
            this.sentToProductionLbl.Size = new System.Drawing.Size(208, 17);
            this.sentToProductionLbl.TabIndex = 4;
            this.sentToProductionLbl.Text = "Przekazane do Działu Produkcji";
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Location = new System.Drawing.Point(86, 270);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(59, 17);
            this.priceLbl.TabIndex = 5;
            this.priceLbl.Text = "Wycena";
            // 
            // acceptBtn
            // 
            this.acceptBtn.Location = new System.Drawing.Point(611, 375);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(94, 41);
            this.acceptBtn.TabIndex = 6;
            this.acceptBtn.Text = "Zatwierdź";
            this.acceptBtn.UseVisualStyleBackColor = true;
            // 
            // productTb
            // 
            this.productTb.Location = new System.Drawing.Point(320, 89);
            this.productTb.Name = "productTb";
            this.productTb.Size = new System.Drawing.Size(100, 22);
            this.productTb.TabIndex = 7;
            // 
            // quantityTb
            // 
            this.quantityTb.Location = new System.Drawing.Point(320, 134);
            this.quantityTb.Name = "quantityTb";
            this.quantityTb.Size = new System.Drawing.Size(100, 22);
            this.quantityTb.TabIndex = 8;
            // 
            // margeTb
            // 
            this.margeTb.Location = new System.Drawing.Point(320, 180);
            this.margeTb.Name = "margeTb";
            this.margeTb.Size = new System.Drawing.Size(100, 22);
            this.margeTb.TabIndex = 9;
            // 
            // priceTb
            // 
            this.priceTb.Location = new System.Drawing.Point(320, 270);
            this.priceTb.Name = "priceTb";
            this.priceTb.Size = new System.Drawing.Size(100, 22);
            this.priceTb.TabIndex = 10;
            // 
            // sentToProductionCb
            // 
            this.sentToProductionCb.AutoSize = true;
            this.sentToProductionCb.Location = new System.Drawing.Point(320, 226);
            this.sentToProductionCb.Name = "sentToProductionCb";
            this.sentToProductionCb.Size = new System.Drawing.Size(18, 17);
            this.sentToProductionCb.TabIndex = 11;
            this.sentToProductionCb.UseVisualStyleBackColor = true;
            // 
            // customerNameTb
            // 
            this.customerNameTb.Location = new System.Drawing.Point(146, 31);
            this.customerNameTb.Name = "customerNameTb";
            this.customerNameTb.Size = new System.Drawing.Size(274, 22);
            this.customerNameTb.TabIndex = 12;
            // 
            // returnBtn
            // 
            this.returnBtn.Location = new System.Drawing.Point(66, 375);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(94, 41);
            this.returnBtn.TabIndex = 13;
            this.returnBtn.Text = "Powrót";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // AddNewOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.customerNameTb);
            this.Controls.Add(this.sentToProductionCb);
            this.Controls.Add(this.priceTb);
            this.Controls.Add(this.margeTb);
            this.Controls.Add(this.quantityTb);
            this.Controls.Add(this.productTb);
            this.Controls.Add(this.acceptBtn);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.sentToProductionLbl);
            this.Controls.Add(this.margeLbl);
            this.Controls.Add(this.quantityLbl);
            this.Controls.Add(this.productLbl);
            this.Controls.Add(this.customerNameLbl);
            this.Name = "AddNewOrderForm";
            this.Text = "AddNewOrderForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerNameLbl;
        private System.Windows.Forms.Label productLbl;
        private System.Windows.Forms.Label quantityLbl;
        private System.Windows.Forms.Label margeLbl;
        private System.Windows.Forms.Label sentToProductionLbl;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.TextBox productTb;
        private System.Windows.Forms.TextBox quantityTb;
        private System.Windows.Forms.TextBox margeTb;
        private System.Windows.Forms.TextBox priceTb;
        private System.Windows.Forms.CheckBox sentToProductionCb;
        private System.Windows.Forms.TextBox customerNameTb;
        private System.Windows.Forms.Button returnBtn;
    }
}