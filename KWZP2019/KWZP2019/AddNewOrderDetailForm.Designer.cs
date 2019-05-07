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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewOrderDetailForm));
            this.orderLbl = new System.Windows.Forms.Label();
            this.productLbl = new System.Windows.Forms.Label();
            this.quantityLbl = new System.Windows.Forms.Label();
            this.orderTb = new System.Windows.Forms.TextBox();
            this.quantityTb = new System.Windows.Forms.TextBox();
            this.productCb = new System.Windows.Forms.ComboBox();
            this.detailReturnBtn = new System.Windows.Forms.Button();
            this.detailAcceptBtn = new System.Windows.Forms.Button();
            this.pictureBoxForm = new System.Windows.Forms.PictureBox();
            this.addNewOrderDetailsLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForm)).BeginInit();
            this.SuspendLayout();
            // 
            // orderLbl
            // 
            this.orderLbl.AutoSize = true;
            this.orderLbl.BackColor = System.Drawing.Color.Transparent;
            this.orderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.orderLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.orderLbl.Location = new System.Drawing.Point(496, 224);
            this.orderLbl.Name = "orderLbl";
            this.orderLbl.Size = new System.Drawing.Size(98, 18);
            this.orderLbl.TabIndex = 0;
            this.orderLbl.Text = "Zamówienie";
            // 
            // productLbl
            // 
            this.productLbl.AutoSize = true;
            this.productLbl.BackColor = System.Drawing.Color.Transparent;
            this.productLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.productLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.productLbl.Location = new System.Drawing.Point(496, 301);
            this.productLbl.Name = "productLbl";
            this.productLbl.Size = new System.Drawing.Size(67, 18);
            this.productLbl.TabIndex = 0;
            this.productLbl.Text = "Produkt";
            // 
            // quantityLbl
            // 
            this.quantityLbl.AutoSize = true;
            this.quantityLbl.BackColor = System.Drawing.Color.Transparent;
            this.quantityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.quantityLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.quantityLbl.Location = new System.Drawing.Point(496, 398);
            this.quantityLbl.Name = "quantityLbl";
            this.quantityLbl.Size = new System.Drawing.Size(44, 18);
            this.quantityLbl.TabIndex = 0;
            this.quantityLbl.Text = "Ilość";
            // 
            // orderTb
            // 
            this.orderTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.orderTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.orderTb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.orderTb.Location = new System.Drawing.Point(601, 217);
            this.orderTb.Name = "orderTb";
            this.orderTb.ReadOnly = true;
            this.orderTb.Size = new System.Drawing.Size(160, 24);
            this.orderTb.TabIndex = 1;
            // 
            // quantityTb
            // 
            this.quantityTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.quantityTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.quantityTb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.quantityTb.Location = new System.Drawing.Point(601, 391);
            this.quantityTb.Name = "quantityTb";
            this.quantityTb.Size = new System.Drawing.Size(160, 24);
            this.quantityTb.TabIndex = 1;
            // 
            // productCb
            // 
            this.productCb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.productCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.productCb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.productCb.FormattingEnabled = true;
            this.productCb.Location = new System.Drawing.Point(601, 298);
            this.productCb.Name = "productCb";
            this.productCb.Size = new System.Drawing.Size(160, 26);
            this.productCb.TabIndex = 2;
            // 
            // detailReturnBtn
            // 
            this.detailReturnBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.detailReturnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.detailReturnBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.detailReturnBtn.Image = ((System.Drawing.Image)(resources.GetObject("detailReturnBtn.Image")));
            this.detailReturnBtn.Location = new System.Drawing.Point(47, 611);
            this.detailReturnBtn.Name = "detailReturnBtn";
            this.detailReturnBtn.Size = new System.Drawing.Size(200, 120);
            this.detailReturnBtn.TabIndex = 3;
            this.detailReturnBtn.Text = "Powrót";
            this.detailReturnBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.detailReturnBtn.UseVisualStyleBackColor = false;
            this.detailReturnBtn.Click += new System.EventHandler(this.detailReturnBtn_Click);
            // 
            // detailAcceptBtn
            // 
            this.detailAcceptBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.detailAcceptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.detailAcceptBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.detailAcceptBtn.Image = ((System.Drawing.Image)(resources.GetObject("detailAcceptBtn.Image")));
            this.detailAcceptBtn.Location = new System.Drawing.Point(300, 611);
            this.detailAcceptBtn.Name = "detailAcceptBtn";
            this.detailAcceptBtn.Size = new System.Drawing.Size(200, 120);
            this.detailAcceptBtn.TabIndex = 4;
            this.detailAcceptBtn.Text = "Zatwierdź";
            this.detailAcceptBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.detailAcceptBtn.UseVisualStyleBackColor = false;
            this.detailAcceptBtn.Click += new System.EventHandler(this.detailAcceptBtn_Click);
            // 
            // pictureBoxForm
            // 
            this.pictureBoxForm.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxForm.BackgroundImage")));
            this.pictureBoxForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxForm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBoxForm.Location = new System.Drawing.Point(219, 34);
            this.pictureBoxForm.Name = "pictureBoxForm";
            this.pictureBoxForm.Size = new System.Drawing.Size(845, 492);
            this.pictureBoxForm.TabIndex = 56;
            this.pictureBoxForm.TabStop = false;
            // 
            // addNewOrderDetailsLbl
            // 
            this.addNewOrderDetailsLbl.AutoSize = true;
            this.addNewOrderDetailsLbl.BackColor = System.Drawing.Color.Transparent;
            this.addNewOrderDetailsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.addNewOrderDetailsLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addNewOrderDetailsLbl.Location = new System.Drawing.Point(478, 113);
            this.addNewOrderDetailsLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addNewOrderDetailsLbl.Name = "addNewOrderDetailsLbl";
            this.addNewOrderDetailsLbl.Size = new System.Drawing.Size(351, 29);
            this.addNewOrderDetailsLbl.TabIndex = 57;
            this.addNewOrderDetailsLbl.Text = "Dodaj szczegóły zamówienia";
            this.addNewOrderDetailsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddNewOrderDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.addNewOrderDetailsLbl);
            this.Controls.Add(this.detailAcceptBtn);
            this.Controls.Add(this.detailReturnBtn);
            this.Controls.Add(this.productCb);
            this.Controls.Add(this.quantityTb);
            this.Controls.Add(this.orderTb);
            this.Controls.Add(this.quantityLbl);
            this.Controls.Add(this.productLbl);
            this.Controls.Add(this.orderLbl);
            this.Controls.Add(this.pictureBoxForm);
            this.Name = "AddNewOrderDetailForm";
            this.Text = "Dodaj szczegóły zamówienia";
            this.Load += new System.EventHandler(this.AddNewOrderDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForm)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBoxForm;
        private System.Windows.Forms.Label addNewOrderDetailsLbl;
    }
}