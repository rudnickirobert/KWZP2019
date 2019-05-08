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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewOrderForm));
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
            this.markupInfoLbl = new System.Windows.Forms.Label();
            this.pictureBoxForm = new System.Windows.Forms.PictureBox();
            this.addNewOrderLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForm)).BeginInit();
            this.SuspendLayout();
            // 
            // customerNameLbl
            // 
            this.customerNameLbl.AutoSize = true;
            this.customerNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.customerNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.customerNameLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.customerNameLbl.Location = new System.Drawing.Point(316, 216);
            this.customerNameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerNameLbl.Name = "customerNameLbl";
            this.customerNameLbl.Size = new System.Drawing.Size(113, 18);
            this.customerNameLbl.TabIndex = 0;
            this.customerNameLbl.Text = "Nazwa klienta";
            // 
            // employeeLbl
            // 
            this.employeeLbl.AutoSize = true;
            this.employeeLbl.BackColor = System.Drawing.Color.Transparent;
            this.employeeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.employeeLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.employeeLbl.Location = new System.Drawing.Point(316, 260);
            this.employeeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.employeeLbl.Name = "employeeLbl";
            this.employeeLbl.Size = new System.Drawing.Size(87, 18);
            this.employeeLbl.TabIndex = 1;
            this.employeeLbl.Text = "Pracownik";
            // 
            // dataLbl
            // 
            this.dataLbl.AutoSize = true;
            this.dataLbl.BackColor = System.Drawing.Color.Transparent;
            this.dataLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.dataLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataLbl.Location = new System.Drawing.Point(316, 293);
            this.dataLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dataLbl.Name = "dataLbl";
            this.dataLbl.Size = new System.Drawing.Size(43, 18);
            this.dataLbl.TabIndex = 2;
            this.dataLbl.Text = "Data";
            // 
            // markupLbl
            // 
            this.markupLbl.AutoSize = true;
            this.markupLbl.BackColor = System.Drawing.Color.Transparent;
            this.markupLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.markupLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.markupLbl.Location = new System.Drawing.Point(316, 330);
            this.markupLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.markupLbl.Name = "markupLbl";
            this.markupLbl.Size = new System.Drawing.Size(55, 18);
            this.markupLbl.TabIndex = 3;
            this.markupLbl.Text = "Marża";
            // 
            // sentToProductionLbl
            // 
            this.sentToProductionLbl.AutoSize = true;
            this.sentToProductionLbl.BackColor = System.Drawing.Color.Transparent;
            this.sentToProductionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.sentToProductionLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sentToProductionLbl.Location = new System.Drawing.Point(316, 368);
            this.sentToProductionLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sentToProductionLbl.Name = "sentToProductionLbl";
            this.sentToProductionLbl.Size = new System.Drawing.Size(249, 18);
            this.sentToProductionLbl.TabIndex = 4;
            this.sentToProductionLbl.Text = "Przekazane do Działu Produkcji";
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.BackColor = System.Drawing.Color.Transparent;
            this.priceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.priceLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.priceLbl.Location = new System.Drawing.Point(316, 403);
            this.priceLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(68, 18);
            this.priceLbl.TabIndex = 5;
            this.priceLbl.Text = "Wycena";
            // 
            // acceptBtn
            // 
            this.acceptBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.acceptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.acceptBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.acceptBtn.Image = ((System.Drawing.Image)(resources.GetObject("acceptBtn.Image")));
            this.acceptBtn.Location = new System.Drawing.Point(319, 613);
            this.acceptBtn.Margin = new System.Windows.Forms.Padding(2);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(200, 120);
            this.acceptBtn.TabIndex = 6;
            this.acceptBtn.Text = "Zatwierdź";
            this.acceptBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.acceptBtn.UseVisualStyleBackColor = false;
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // priceTb
            // 
            this.priceTb.BackColor = System.Drawing.Color.White;
            this.priceTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.priceTb.ForeColor = System.Drawing.Color.Black;
            this.priceTb.Location = new System.Drawing.Point(447, 404);
            this.priceTb.Margin = new System.Windows.Forms.Padding(2);
            this.priceTb.Name = "priceTb";
            this.priceTb.Size = new System.Drawing.Size(302, 24);
            this.priceTb.TabIndex = 10;
            this.priceTb.Text = "0";
            // 
            // sentToProductionCb
            // 
            this.sentToProductionCb.AutoSize = true;
            this.sentToProductionCb.Location = new System.Drawing.Point(735, 372);
            this.sentToProductionCb.Margin = new System.Windows.Forms.Padding(2);
            this.sentToProductionCb.Name = "sentToProductionCb";
            this.sentToProductionCb.Size = new System.Drawing.Size(15, 14);
            this.sentToProductionCb.TabIndex = 11;
            this.sentToProductionCb.UseVisualStyleBackColor = true;
            // 
            // customerNameTb
            // 
            this.customerNameTb.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.customerNameTb.BackColor = System.Drawing.Color.White;
            this.customerNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.customerNameTb.ForeColor = System.Drawing.Color.Black;
            this.customerNameTb.Location = new System.Drawing.Point(448, 210);
            this.customerNameTb.Margin = new System.Windows.Forms.Padding(2);
            this.customerNameTb.Name = "customerNameTb";
            this.customerNameTb.ReadOnly = true;
            this.customerNameTb.Size = new System.Drawing.Size(302, 24);
            this.customerNameTb.TabIndex = 12;
            // 
            // returnBtn
            // 
            this.returnBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.returnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.returnBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.returnBtn.Image = ((System.Drawing.Image)(resources.GetObject("returnBtn.Image")));
            this.returnBtn.Location = new System.Drawing.Point(55, 613);
            this.returnBtn.Margin = new System.Windows.Forms.Padding(2);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(200, 120);
            this.returnBtn.TabIndex = 13;
            this.returnBtn.Text = "Powrót";
            this.returnBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.returnBtn.UseVisualStyleBackColor = false;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // orderDtp
            // 
            this.orderDtp.CalendarTitleForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.orderDtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.orderDtp.Location = new System.Drawing.Point(448, 288);
            this.orderDtp.Name = "orderDtp";
            this.orderDtp.Size = new System.Drawing.Size(302, 24);
            this.orderDtp.TabIndex = 14;
            // 
            // employeeCb
            // 
            this.employeeCb.BackColor = System.Drawing.Color.White;
            this.employeeCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.employeeCb.ForeColor = System.Drawing.Color.Black;
            this.employeeCb.FormattingEnabled = true;
            this.employeeCb.Location = new System.Drawing.Point(448, 253);
            this.employeeCb.Name = "employeeCb";
            this.employeeCb.Size = new System.Drawing.Size(302, 26);
            this.employeeCb.TabIndex = 15;
            this.employeeCb.Text = "Wybierz pracownika";
            // 
            // markupTb
            // 
            this.markupTb.BackColor = System.Drawing.Color.White;
            this.markupTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.markupTb.ForeColor = System.Drawing.Color.Black;
            this.markupTb.Location = new System.Drawing.Point(448, 328);
            this.markupTb.Name = "markupTb";
            this.markupTb.Size = new System.Drawing.Size(302, 24);
            this.markupTb.TabIndex = 16;
            this.markupTb.Text = "0,3";
            this.markupTb.TextChanged += new System.EventHandler(this.markupTb_TextChanged);
            // 
            // markupInfoLbl
            // 
            this.markupInfoLbl.AutoSize = true;
            this.markupInfoLbl.BackColor = System.Drawing.Color.Transparent;
            this.markupInfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.markupInfoLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.markupInfoLbl.Location = new System.Drawing.Point(766, 334);
            this.markupInfoLbl.Name = "markupInfoLbl";
            this.markupInfoLbl.Size = new System.Drawing.Size(103, 18);
            this.markupInfoLbl.TabIndex = 17;
            this.markupInfoLbl.Text = "Preferowana";
            // 
            // pictureBoxForm
            // 
            this.pictureBoxForm.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxForm.BackgroundImage")));
            this.pictureBoxForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxForm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBoxForm.Location = new System.Drawing.Point(125, 29);
            this.pictureBoxForm.Name = "pictureBoxForm";
            this.pictureBoxForm.Size = new System.Drawing.Size(958, 492);
            this.pictureBoxForm.TabIndex = 57;
            this.pictureBoxForm.TabStop = false;
            // 
            // addNewOrderLbl
            // 
            this.addNewOrderLbl.AutoSize = true;
            this.addNewOrderLbl.BackColor = System.Drawing.Color.Transparent;
            this.addNewOrderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.addNewOrderLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addNewOrderLbl.Location = new System.Drawing.Point(459, 109);
            this.addNewOrderLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addNewOrderLbl.Name = "addNewOrderLbl";
            this.addNewOrderLbl.Size = new System.Drawing.Size(298, 29);
            this.addNewOrderLbl.TabIndex = 58;
            this.addNewOrderLbl.Text = "Dodaj nowe zamówienie";
            this.addNewOrderLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddNewOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.addNewOrderLbl);
            this.Controls.Add(this.markupInfoLbl);
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
            this.Controls.Add(this.pictureBoxForm);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddNewOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj nowe zamówienie";
            this.Load += new System.EventHandler(this.AddNewOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForm)).EndInit();
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
        private System.Windows.Forms.Label markupInfoLbl;
        private System.Windows.Forms.PictureBox pictureBoxForm;
        private System.Windows.Forms.Label addNewOrderLbl;
    }
}