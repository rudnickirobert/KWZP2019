namespace KWZP2019
{
    partial class AddNewOrderDetailForm
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
            this.orderLbl = new System.Windows.Forms.Label();
            this.productLbl = new System.Windows.Forms.Label();
            this.quantityLbl = new System.Windows.Forms.Label();
            this.orderTb = new System.Windows.Forms.TextBox();
            this.quantityTb = new System.Windows.Forms.TextBox();
            this.productCb = new System.Windows.Forms.ComboBox();
            this.detailReturnBtn = new System.Windows.Forms.Button();
            this.detailAcceptBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // orderLbl
            // 
            this.orderLbl.AutoSize = true;
            this.orderLbl.Location = new System.Drawing.Point(26, 40);
            this.orderLbl.Name = "orderLbl";
            this.orderLbl.Size = new System.Drawing.Size(64, 13);
            this.orderLbl.TabIndex = 0;
            this.orderLbl.Text = "Zamówienie";
            // 
            // productLbl
            // 
            this.productLbl.AutoSize = true;
            this.productLbl.Location = new System.Drawing.Point(26, 117);
            this.productLbl.Name = "productLbl";
            this.productLbl.Size = new System.Drawing.Size(44, 13);
            this.productLbl.TabIndex = 0;
            this.productLbl.Text = "Produkt";
            // 
            // quantityLbl
            // 
            this.quantityLbl.AutoSize = true;
            this.quantityLbl.Location = new System.Drawing.Point(26, 214);
            this.quantityLbl.Name = "quantityLbl";
            this.quantityLbl.Size = new System.Drawing.Size(29, 13);
            this.quantityLbl.TabIndex = 0;
            this.quantityLbl.Text = "Ilość";
            // 
            // orderTb
            // 
            this.orderTb.Location = new System.Drawing.Point(131, 33);
            this.orderTb.Name = "orderTb";
            this.orderTb.ReadOnly = true;
            this.orderTb.Size = new System.Drawing.Size(100, 20);
            this.orderTb.TabIndex = 1;
            // 
            // quantityTb
            // 
            this.quantityTb.Location = new System.Drawing.Point(131, 207);
            this.quantityTb.Name = "quantityTb";
            this.quantityTb.Size = new System.Drawing.Size(100, 20);
            this.quantityTb.TabIndex = 1;
            // 
            // productCb
            // 
            this.productCb.FormattingEnabled = true;
            this.productCb.Location = new System.Drawing.Point(131, 114);
            this.productCb.Name = "productCb";
            this.productCb.Size = new System.Drawing.Size(100, 21);
            this.productCb.TabIndex = 2;
            // 
            // detailReturnBtn
            // 
            this.detailReturnBtn.Location = new System.Drawing.Point(74, 366);
            this.detailReturnBtn.Name = "detailReturnBtn";
            this.detailReturnBtn.Size = new System.Drawing.Size(75, 23);
            this.detailReturnBtn.TabIndex = 3;
            this.detailReturnBtn.Text = "Powrót";
            this.detailReturnBtn.UseVisualStyleBackColor = true;
            this.detailReturnBtn.Click += new System.EventHandler(this.detailReturnBtn_Click);
            // 
            // detailAcceptBtn
            // 
            this.detailAcceptBtn.Location = new System.Drawing.Point(566, 366);
            this.detailAcceptBtn.Name = "detailAcceptBtn";
            this.detailAcceptBtn.Size = new System.Drawing.Size(77, 23);
            this.detailAcceptBtn.TabIndex = 4;
            this.detailAcceptBtn.Text = "Zatwierdź";
            this.detailAcceptBtn.UseVisualStyleBackColor = true;
            this.detailAcceptBtn.Click += new System.EventHandler(this.detailAcceptBtn_Click);
            // 
            // AddNewOrderDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.detailAcceptBtn);
            this.Controls.Add(this.detailReturnBtn);
            this.Controls.Add(this.productCb);
            this.Controls.Add(this.quantityTb);
            this.Controls.Add(this.orderTb);
            this.Controls.Add(this.quantityLbl);
            this.Controls.Add(this.productLbl);
            this.Controls.Add(this.orderLbl);
            this.Name = "AddNewOrderDetailForm";
            this.Text = "AddNewOrderDetailForm";
            this.Load += new System.EventHandler(this.AddNewOrderDetailForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label orderLbl;
        private System.Windows.Forms.Label productLbl;
        private System.Windows.Forms.Label quantityLbl;
        private System.Windows.Forms.TextBox orderTb;
        private System.Windows.Forms.TextBox quantityTb;
        private System.Windows.Forms.ComboBox productCb;
        private System.Windows.Forms.Button detailReturnBtn;
        private System.Windows.Forms.Button detailAcceptBtn;
    }
}