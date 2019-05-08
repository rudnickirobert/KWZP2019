namespace KWZP2019
{
    partial class OrderNewPartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderNewPartForm));
            this.orderPartLbl = new System.Windows.Forms.Label();
            this.supplierLbl = new System.Windows.Forms.Label();
            this.supplierComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.orderDtp = new System.Windows.Forms.DateTimePicker();
            this.quantityLbl = new System.Windows.Forms.Label();
            this.quantityTb = new System.Windows.Forms.TextBox();
            this.partTypeLbl = new System.Windows.Forms.Label();
            this.partTypeComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBoxForm = new System.Windows.Forms.PictureBox();
            this.returnBtn = new System.Windows.Forms.Button();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.statusLbl = new System.Windows.Forms.Label();
            this.statusTb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForm)).BeginInit();
            this.SuspendLayout();
            // 
            // orderPartLbl
            // 
            this.orderPartLbl.AutoSize = true;
            this.orderPartLbl.BackColor = System.Drawing.Color.Transparent;
            this.orderPartLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.orderPartLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.orderPartLbl.Location = new System.Drawing.Point(381, 101);
            this.orderPartLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderPartLbl.Name = "orderPartLbl";
            this.orderPartLbl.Size = new System.Drawing.Size(430, 31);
            this.orderPartLbl.TabIndex = 105;
            this.orderPartLbl.Text = "Złóż zapotrzebowanie na części";
            // 
            // supplierLbl
            // 
            this.supplierLbl.AutoSize = true;
            this.supplierLbl.BackColor = System.Drawing.Color.Transparent;
            this.supplierLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.supplierLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.supplierLbl.Location = new System.Drawing.Point(219, 191);
            this.supplierLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.supplierLbl.Name = "supplierLbl";
            this.supplierLbl.Size = new System.Drawing.Size(146, 18);
            this.supplierLbl.TabIndex = 107;
            this.supplierLbl.Text = "Wybierz dostawcę";
            // 
            // supplierComboBox
            // 
            this.supplierComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.supplierComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.supplierComboBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.supplierComboBox.FormattingEnabled = true;
            this.supplierComboBox.Location = new System.Drawing.Point(222, 230);
            this.supplierComboBox.Name = "supplierComboBox";
            this.supplierComboBox.Size = new System.Drawing.Size(197, 26);
            this.supplierComboBox.TabIndex = 109;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(473, 384);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 18);
            this.label1.TabIndex = 111;
            this.label1.Text = "Data złożenia zapotrzebowania";
            // 
            // orderDtp
            // 
            this.orderDtp.CalendarTitleForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.orderDtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.orderDtp.Location = new System.Drawing.Point(441, 421);
            this.orderDtp.Name = "orderDtp";
            this.orderDtp.Size = new System.Drawing.Size(302, 24);
            this.orderDtp.TabIndex = 112;
            // 
            // quantityLbl
            // 
            this.quantityLbl.AutoSize = true;
            this.quantityLbl.BackColor = System.Drawing.Color.Transparent;
            this.quantityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.quantityLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.quantityLbl.Location = new System.Drawing.Point(686, 287);
            this.quantityLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.quantityLbl.Name = "quantityLbl";
            this.quantityLbl.Size = new System.Drawing.Size(44, 18);
            this.quantityLbl.TabIndex = 116;
            this.quantityLbl.Text = "Ilość";
            // 
            // quantityTb
            // 
            this.quantityTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.quantityTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.quantityTb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.quantityTb.Location = new System.Drawing.Point(689, 316);
            this.quantityTb.Margin = new System.Windows.Forms.Padding(2);
            this.quantityTb.Name = "quantityTb";
            this.quantityTb.Size = new System.Drawing.Size(197, 24);
            this.quantityTb.TabIndex = 121;
            // 
            // partTypeLbl
            // 
            this.partTypeLbl.AutoSize = true;
            this.partTypeLbl.BackColor = System.Drawing.Color.Transparent;
            this.partTypeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.partTypeLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.partTypeLbl.Location = new System.Drawing.Point(686, 191);
            this.partTypeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.partTypeLbl.Name = "partTypeLbl";
            this.partTypeLbl.Size = new System.Drawing.Size(89, 18);
            this.partTypeLbl.TabIndex = 123;
            this.partTypeLbl.Text = "Typ części";
            // 
            // partTypeComboBox
            // 
            this.partTypeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.partTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.partTypeComboBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.partTypeComboBox.FormattingEnabled = true;
            this.partTypeComboBox.Location = new System.Drawing.Point(689, 224);
            this.partTypeComboBox.Name = "partTypeComboBox";
            this.partTypeComboBox.Size = new System.Drawing.Size(197, 26);
            this.partTypeComboBox.TabIndex = 124;
            // 
            // pictureBoxForm
            // 
            this.pictureBoxForm.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxForm.BackgroundImage")));
            this.pictureBoxForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxForm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBoxForm.Location = new System.Drawing.Point(112, 23);
            this.pictureBoxForm.Name = "pictureBoxForm";
            this.pictureBoxForm.Size = new System.Drawing.Size(958, 492);
            this.pictureBoxForm.TabIndex = 125;
            this.pictureBoxForm.TabStop = false;
            // 
            // returnBtn
            // 
            this.returnBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.returnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.returnBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.returnBtn.Image = ((System.Drawing.Image)(resources.GetObject("returnBtn.Image")));
            this.returnBtn.Location = new System.Drawing.Point(32, 608);
            this.returnBtn.Margin = new System.Windows.Forms.Padding(2);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(200, 120);
            this.returnBtn.TabIndex = 127;
            this.returnBtn.Text = "Powrót";
            this.returnBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.returnBtn.UseVisualStyleBackColor = false;
            // 
            // acceptBtn
            // 
            this.acceptBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.acceptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.acceptBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.acceptBtn.Image = ((System.Drawing.Image)(resources.GetObject("acceptBtn.Image")));
            this.acceptBtn.Location = new System.Drawing.Point(298, 608);
            this.acceptBtn.Margin = new System.Windows.Forms.Padding(2);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(200, 120);
            this.acceptBtn.TabIndex = 126;
            this.acceptBtn.Text = "Zrealizuj";
            this.acceptBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.acceptBtn.UseVisualStyleBackColor = false;
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.BackColor = System.Drawing.Color.Transparent;
            this.statusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.statusLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.statusLbl.Location = new System.Drawing.Point(219, 287);
            this.statusLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(56, 18);
            this.statusLbl.TabIndex = 128;
            this.statusLbl.Text = "Status";
            // 
            // statusTb
            // 
            this.statusTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.statusTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.statusTb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.statusTb.Location = new System.Drawing.Point(222, 316);
            this.statusTb.Margin = new System.Windows.Forms.Padding(2);
            this.statusTb.Name = "statusTb";
            this.statusTb.Size = new System.Drawing.Size(197, 24);
            this.statusTb.TabIndex = 129;
            // 
            // OrderNewPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.statusTb);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.acceptBtn);
            this.Controls.Add(this.partTypeComboBox);
            this.Controls.Add(this.partTypeLbl);
            this.Controls.Add(this.quantityTb);
            this.Controls.Add(this.quantityLbl);
            this.Controls.Add(this.orderDtp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.supplierComboBox);
            this.Controls.Add(this.supplierLbl);
            this.Controls.Add(this.orderPartLbl);
            this.Controls.Add(this.pictureBoxForm);
            this.Name = "OrderNewPartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zapotrzebowanie na części";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label orderPartLbl;
        private System.Windows.Forms.Label supplierLbl;
        private System.Windows.Forms.ComboBox supplierComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker orderDtp;
        private System.Windows.Forms.Label quantityLbl;
        private System.Windows.Forms.TextBox quantityTb;
        private System.Windows.Forms.Label partTypeLbl;
        private System.Windows.Forms.ComboBox partTypeComboBox;
        private System.Windows.Forms.PictureBox pictureBoxForm;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.TextBox statusTb;
    }
}