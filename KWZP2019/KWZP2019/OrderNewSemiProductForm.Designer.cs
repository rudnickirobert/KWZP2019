namespace KWZP2019
{
    partial class OrderNewSemiProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderNewSemiProductForm));
            this.orderSemiProductLbl = new System.Windows.Forms.Label();
            this.quantityTb = new System.Windows.Forms.TextBox();
            this.quantityLbl = new System.Windows.Forms.Label();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.returnBtn = new System.Windows.Forms.Button();
            this.semiProductCodeLbl = new System.Windows.Forms.Label();
            this.pictureBoxForm = new System.Windows.Forms.PictureBox();
            this.semiProductCodeCb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idSfOrderTb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForm)).BeginInit();
            this.SuspendLayout();
            // 
            // orderSemiProductLbl
            // 
            this.orderSemiProductLbl.AutoSize = true;
            this.orderSemiProductLbl.BackColor = System.Drawing.Color.Transparent;
            this.orderSemiProductLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.orderSemiProductLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.orderSemiProductLbl.Location = new System.Drawing.Point(345, 116);
            this.orderSemiProductLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderSemiProductLbl.Name = "orderSemiProductLbl";
            this.orderSemiProductLbl.Size = new System.Drawing.Size(492, 31);
            this.orderSemiProductLbl.TabIndex = 104;
            this.orderSemiProductLbl.Text = "Złóż zapotrzebowanie na półfabrykat";
            // 
            // quantityTb
            // 
            this.quantityTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.quantityTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.quantityTb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.quantityTb.Location = new System.Drawing.Point(691, 406);
            this.quantityTb.Margin = new System.Windows.Forms.Padding(2);
            this.quantityTb.Name = "quantityTb";
            this.quantityTb.Size = new System.Drawing.Size(197, 24);
            this.quantityTb.TabIndex = 120;
            // 
            // quantityLbl
            // 
            this.quantityLbl.AutoSize = true;
            this.quantityLbl.BackColor = System.Drawing.Color.Transparent;
            this.quantityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.quantityLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.quantityLbl.Location = new System.Drawing.Point(763, 358);
            this.quantityLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.quantityLbl.Name = "quantityLbl";
            this.quantityLbl.Size = new System.Drawing.Size(44, 18);
            this.quantityLbl.TabIndex = 115;
            this.quantityLbl.Text = "Ilość";
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
            // semiProductCodeLbl
            // 
            this.semiProductCodeLbl.AutoSize = true;
            this.semiProductCodeLbl.BackColor = System.Drawing.Color.Transparent;
            this.semiProductCodeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.semiProductCodeLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.semiProductCodeLbl.Location = new System.Drawing.Point(339, 358);
            this.semiProductCodeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.semiProductCodeLbl.Name = "semiProductCodeLbl";
            this.semiProductCodeLbl.Size = new System.Drawing.Size(135, 18);
            this.semiProductCodeLbl.TabIndex = 111;
            this.semiProductCodeLbl.Text = "Kod półfabrykatu";
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
            // semiProductCodeCb
            // 
            this.semiProductCodeCb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.semiProductCodeCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.semiProductCodeCb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.semiProductCodeCb.FormattingEnabled = true;
            this.semiProductCodeCb.Location = new System.Drawing.Point(316, 404);
            this.semiProductCodeCb.Name = "semiProductCodeCb";
            this.semiProductCodeCb.Size = new System.Drawing.Size(197, 26);
            this.semiProductCodeCb.TabIndex = 128;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(560, 223);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 115;
            this.label1.Text = "Nr zamówienia";
            // 
            // idSfOrderTb
            // 
            this.idSfOrderTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.idSfOrderTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.idSfOrderTb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.idSfOrderTb.Location = new System.Drawing.Point(529, 279);
            this.idSfOrderTb.Margin = new System.Windows.Forms.Padding(2);
            this.idSfOrderTb.Name = "idSfOrderTb";
            this.idSfOrderTb.ReadOnly = true;
            this.idSfOrderTb.Size = new System.Drawing.Size(197, 24);
            this.idSfOrderTb.TabIndex = 120;
            // 
            // OrderNewSemiProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.semiProductCodeCb);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.acceptBtn);
            this.Controls.Add(this.idSfOrderTb);
            this.Controls.Add(this.quantityTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quantityLbl);
            this.Controls.Add(this.semiProductCodeLbl);
            this.Controls.Add(this.orderSemiProductLbl);
            this.Controls.Add(this.pictureBoxForm);
            this.Name = "OrderNewSemiProductForm";
            this.Text = "Zapotrzebowanie na pólfabrykat";
            this.Load += new System.EventHandler(this.OrderNewSemiProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label orderSemiProductLbl;
        private System.Windows.Forms.TextBox quantityTb;
        private System.Windows.Forms.Label quantityLbl;
        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Label semiProductCodeLbl;
        private System.Windows.Forms.PictureBox pictureBoxForm;
        private System.Windows.Forms.ComboBox semiProductCodeCb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idSfOrderTb;
    }
}