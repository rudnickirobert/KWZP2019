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
            this.employeeLbl = new System.Windows.Forms.Label();
            this.dataLbl = new System.Windows.Forms.Label();
            this.markupLbl = new System.Windows.Forms.Label();
            this.sentToProductionLbl = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.priceTb = new System.Windows.Forms.TextBox();
            this.sentToProductionCb = new System.Windows.Forms.CheckBox();
            this.customerNameTb = new System.Windows.Forms.TextBox();
            this.returnBtn = new System.Windows.Forms.Button();
            this.orderDtp = new System.Windows.Forms.DateTimePicker();
            this.employeeCb = new System.Windows.Forms.ComboBox();
            this.markupTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // customerNameLbl
            // 
            this.customerNameLbl.AutoSize = true;
            this.customerNameLbl.Location = new System.Drawing.Point(18, 29);
            this.customerNameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerNameLbl.Name = "customerNameLbl";
            this.customerNameLbl.Size = new System.Drawing.Size(74, 13);
            this.customerNameLbl.TabIndex = 0;
            this.customerNameLbl.Text = "Nazwa klienta";
            // 
            // employeeLbl
            // 
            this.employeeLbl.AutoSize = true;
            this.employeeLbl.Location = new System.Drawing.Point(18, 76);
            this.employeeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.employeeLbl.Name = "employeeLbl";
            this.employeeLbl.Size = new System.Drawing.Size(57, 13);
            this.employeeLbl.TabIndex = 1;
            this.employeeLbl.Text = "Pracownik";
            // 
            // dataLbl
            // 
            this.dataLbl.AutoSize = true;
            this.dataLbl.Location = new System.Drawing.Point(18, 109);
            this.dataLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dataLbl.Name = "dataLbl";
            this.dataLbl.Size = new System.Drawing.Size(30, 13);
            this.dataLbl.TabIndex = 2;
            this.dataLbl.Text = "Data";
            // 
            // markupLbl
            // 
            this.markupLbl.AutoSize = true;
            this.markupLbl.Location = new System.Drawing.Point(18, 146);
            this.markupLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.markupLbl.Name = "markupLbl";
            this.markupLbl.Size = new System.Drawing.Size(36, 13);
            this.markupLbl.TabIndex = 3;
            this.markupLbl.Text = "Marża";
            // 
            // sentToProductionLbl
            // 
            this.sentToProductionLbl.AutoSize = true;
            this.sentToProductionLbl.Location = new System.Drawing.Point(18, 184);
            this.sentToProductionLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sentToProductionLbl.Name = "sentToProductionLbl";
            this.sentToProductionLbl.Size = new System.Drawing.Size(159, 13);
            this.sentToProductionLbl.TabIndex = 4;
            this.sentToProductionLbl.Text = "Przekazane do Działu Produkcji";
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Location = new System.Drawing.Point(18, 219);
            this.priceLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(47, 13);
            this.priceLbl.TabIndex = 5;
            this.priceLbl.Text = "Wycena";
            // 
            // acceptBtn
            // 
            this.acceptBtn.Location = new System.Drawing.Point(458, 305);
            this.acceptBtn.Margin = new System.Windows.Forms.Padding(2);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(70, 33);
            this.acceptBtn.TabIndex = 6;
            this.acceptBtn.Text = "Zatwierdź";
            this.acceptBtn.UseVisualStyleBackColor = true;
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // priceTb
            // 
            this.priceTb.Location = new System.Drawing.Point(110, 219);
            this.priceTb.Margin = new System.Windows.Forms.Padding(2);
            this.priceTb.Name = "priceTb";
            this.priceTb.Size = new System.Drawing.Size(206, 20);
            this.priceTb.TabIndex = 10;
            // 
            // sentToProductionCb
            // 
            this.sentToProductionCb.AutoSize = true;
            this.sentToProductionCb.Location = new System.Drawing.Point(240, 184);
            this.sentToProductionCb.Margin = new System.Windows.Forms.Padding(2);
            this.sentToProductionCb.Name = "sentToProductionCb";
            this.sentToProductionCb.Size = new System.Drawing.Size(15, 14);
            this.sentToProductionCb.TabIndex = 11;
            this.sentToProductionCb.UseVisualStyleBackColor = true;
            // 
            // customerNameTb
            // 
            this.customerNameTb.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.customerNameTb.Location = new System.Drawing.Point(110, 25);
            this.customerNameTb.Margin = new System.Windows.Forms.Padding(2);
            this.customerNameTb.Name = "customerNameTb";
            this.customerNameTb.Size = new System.Drawing.Size(206, 20);
            this.customerNameTb.TabIndex = 12;
            // 
            // returnBtn
            // 
            this.returnBtn.Location = new System.Drawing.Point(50, 305);
            this.returnBtn.Margin = new System.Windows.Forms.Padding(2);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(70, 33);
            this.returnBtn.TabIndex = 13;
            this.returnBtn.Text = "Powrót";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // orderDtp
            // 
            this.orderDtp.Location = new System.Drawing.Point(110, 103);
            this.orderDtp.Name = "orderDtp";
            this.orderDtp.Size = new System.Drawing.Size(206, 20);
            this.orderDtp.TabIndex = 14;
            // 
            // employeeCb
            // 
            this.employeeCb.FormattingEnabled = true;
            this.employeeCb.Location = new System.Drawing.Point(110, 68);
            this.employeeCb.Name = "employeeCb";
            this.employeeCb.Size = new System.Drawing.Size(206, 21);
            this.employeeCb.TabIndex = 15;
            this.employeeCb.Text = "Wybierz pracownika";
            // 
            // markupTb
            // 
            this.markupTb.Location = new System.Drawing.Point(110, 143);
            this.markupTb.Name = "markupTb";
            this.markupTb.Size = new System.Drawing.Size(206, 20);
            this.markupTb.TabIndex = 16;
            // 
            // AddNewOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.markupTb);
            this.Controls.Add(this.employeeCb);
            this.Controls.Add(this.orderDtp);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.customerNameTb);
            this.Controls.Add(this.sentToProductionCb);
            this.Controls.Add(this.priceTb);
            this.Controls.Add(this.acceptBtn);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.sentToProductionLbl);
            this.Controls.Add(this.markupLbl);
            this.Controls.Add(this.dataLbl);
            this.Controls.Add(this.employeeLbl);
            this.Controls.Add(this.customerNameLbl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddNewOrderForm";
            this.Text = "AddNewOrderForm";
            this.Load += new System.EventHandler(this.AddNewOrderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerNameLbl;
        private System.Windows.Forms.Label employeeLbl;
        private System.Windows.Forms.Label dataLbl;
        private System.Windows.Forms.Label markupLbl;
        private System.Windows.Forms.Label sentToProductionLbl;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.TextBox priceTb;
        private System.Windows.Forms.CheckBox sentToProductionCb;
        private System.Windows.Forms.TextBox customerNameTb;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.DateTimePicker orderDtp;
        private System.Windows.Forms.ComboBox employeeCb;
        private System.Windows.Forms.TextBox markupTb;
    }
}