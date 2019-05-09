namespace KWZP2019
{
    partial class OrderSfForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderSfForm));
            this.orderSemiProductLbl = new System.Windows.Forms.Label();
            this.costLbl = new System.Windows.Forms.Label();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.returnBtn = new System.Windows.Forms.Button();
            this.typeLbl = new System.Windows.Forms.Label();
            this.pictureBoxForm = new System.Windows.Forms.PictureBox();
            this.typeCb = new System.Windows.Forms.ComboBox();
            this.orderDateLbl = new System.Windows.Forms.Label();
            this.costTb = new System.Windows.Forms.TextBox();
            this.orderDateDtp = new System.Windows.Forms.DateTimePicker();
            this.deliveryDateDtp = new System.Windows.Forms.DateTimePicker();
            this.deliveryDateLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForm)).BeginInit();
            this.SuspendLayout();
            // 
            // orderSemiProductLbl
            // 
            this.orderSemiProductLbl.AutoSize = true;
            this.orderSemiProductLbl.BackColor = System.Drawing.Color.Transparent;
            this.orderSemiProductLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.orderSemiProductLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.orderSemiProductLbl.Location = new System.Drawing.Point(365, 116);
            this.orderSemiProductLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderSemiProductLbl.Name = "orderSemiProductLbl";
            this.orderSemiProductLbl.Size = new System.Drawing.Size(458, 31);
            this.orderSemiProductLbl.TabIndex = 104;
            this.orderSemiProductLbl.Text = "Stwórz zamówienie na półfabrykat";
            // 
            // costLbl
            // 
            this.costLbl.AutoSize = true;
            this.costLbl.BackColor = System.Drawing.Color.Transparent;
            this.costLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.costLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.costLbl.Location = new System.Drawing.Point(620, 243);
            this.costLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.costLbl.Name = "costLbl";
            this.costLbl.Size = new System.Drawing.Size(146, 18);
            this.costLbl.TabIndex = 115;
            this.costLbl.Text = "Koszt zamówienia";
            // 
            // acceptBtn
            // 
            this.acceptBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.acceptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.acceptBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.acceptBtn.Image = ((System.Drawing.Image)(resources.GetObject("acceptBtn.Image")));
            this.acceptBtn.Location = new System.Drawing.Point(313, 609);
            this.acceptBtn.Margin = new System.Windows.Forms.Padding(2);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(200, 120);
            this.acceptBtn.TabIndex = 124;
            this.acceptBtn.Text = "Zrealizuj";
            this.acceptBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.acceptBtn.UseVisualStyleBackColor = false;
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // returnBtn
            // 
            this.returnBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.returnBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.returnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.returnBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.returnBtn.Image = ((System.Drawing.Image)(resources.GetObject("returnBtn.Image")));
            this.returnBtn.Location = new System.Drawing.Point(47, 609);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(200, 120);
            this.returnBtn.TabIndex = 125;
            this.returnBtn.Text = "Powrót";
            this.returnBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.returnBtn.UseVisualStyleBackColor = false;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.BackColor = System.Drawing.Color.Transparent;
            this.typeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.typeLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.typeLbl.Location = new System.Drawing.Point(348, 243);
            this.typeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(135, 18);
            this.typeLbl.TabIndex = 111;
            this.typeLbl.Text = "Nazwa dostawcy";
            // 
            // pictureBoxForm
            // 
            this.pictureBoxForm.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxForm.BackgroundImage")));
            this.pictureBoxForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxForm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBoxForm.Location = new System.Drawing.Point(97, 23);
            this.pictureBoxForm.Name = "pictureBoxForm";
            this.pictureBoxForm.Size = new System.Drawing.Size(987, 565);
            this.pictureBoxForm.TabIndex = 127;
            this.pictureBoxForm.TabStop = false;
            // 
            // typeCb
            // 
            this.typeCb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.typeCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.typeCb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.typeCb.FormattingEnabled = true;
            this.typeCb.Location = new System.Drawing.Point(351, 297);
            this.typeCb.Name = "typeCb";
            this.typeCb.Size = new System.Drawing.Size(197, 26);
            this.typeCb.TabIndex = 128;
            // 
            // orderDateLbl
            // 
            this.orderDateLbl.AutoSize = true;
            this.orderDateLbl.BackColor = System.Drawing.Color.Transparent;
            this.orderDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.orderDateLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.orderDateLbl.Location = new System.Drawing.Point(348, 360);
            this.orderDateLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderDateLbl.Name = "orderDateLbl";
            this.orderDateLbl.Size = new System.Drawing.Size(205, 18);
            this.orderDateLbl.TabIndex = 115;
            this.orderDateLbl.Text = "Data złożenia zamówienia";
            // 
            // costTb
            // 
            this.costTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.costTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.costTb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.costTb.Location = new System.Drawing.Point(623, 297);
            this.costTb.Margin = new System.Windows.Forms.Padding(2);
            this.costTb.Name = "costTb";
            this.costTb.Size = new System.Drawing.Size(197, 24);
            this.costTb.TabIndex = 120;
            // 
            // orderDateDtp
            // 
            this.orderDateDtp.Location = new System.Drawing.Point(348, 404);
            this.orderDateDtp.Name = "orderDateDtp";
            this.orderDateDtp.Size = new System.Drawing.Size(200, 20);
            this.orderDateDtp.TabIndex = 129;
            // 
            // deliveryDateDtp
            // 
            this.deliveryDateDtp.Location = new System.Drawing.Point(623, 404);
            this.deliveryDateDtp.Name = "deliveryDateDtp";
            this.deliveryDateDtp.Size = new System.Drawing.Size(200, 20);
            this.deliveryDateDtp.TabIndex = 130;
            // 
            // deliveryDateLbl
            // 
            this.deliveryDateLbl.AutoSize = true;
            this.deliveryDateLbl.BackColor = System.Drawing.Color.Transparent;
            this.deliveryDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.deliveryDateLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deliveryDateLbl.Location = new System.Drawing.Point(620, 360);
            this.deliveryDateLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.deliveryDateLbl.Name = "deliveryDateLbl";
            this.deliveryDateLbl.Size = new System.Drawing.Size(199, 18);
            this.deliveryDateLbl.TabIndex = 115;
            this.deliveryDateLbl.Text = "Data odbioru zamówienia";
            // 
            // OrderSfForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.deliveryDateDtp);
            this.Controls.Add(this.orderDateDtp);
            this.Controls.Add(this.typeCb);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.acceptBtn);
            this.Controls.Add(this.costTb);
            this.Controls.Add(this.orderDateLbl);
            this.Controls.Add(this.deliveryDateLbl);
            this.Controls.Add(this.costLbl);
            this.Controls.Add(this.typeLbl);
            this.Controls.Add(this.orderSemiProductLbl);
            this.Controls.Add(this.pictureBoxForm);
            this.Name = "OrderSfForm";
            this.Text = "Zapotrzebowanie na pólfabrykat";
            this.Load += new System.EventHandler(this.OrderSfForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label orderSemiProductLbl;
        private System.Windows.Forms.Label costLbl;
        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.PictureBox pictureBoxForm;
        private System.Windows.Forms.ComboBox typeCb;
        private System.Windows.Forms.Label orderDateLbl;
        private System.Windows.Forms.TextBox costTb;
        private System.Windows.Forms.DateTimePicker orderDateDtp;
        private System.Windows.Forms.DateTimePicker deliveryDateDtp;
        private System.Windows.Forms.Label deliveryDateLbl;
    }
}