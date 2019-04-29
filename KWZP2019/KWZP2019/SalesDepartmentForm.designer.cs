namespace KWZP2019
{
    partial class SalesDepartmentForm
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
            this.customerBtn = new System.Windows.Forms.Button();
            this.orderBtn = new System.Windows.Forms.Button();
            this.warehouseBtn = new System.Windows.Forms.Button();
            this.suppliersBtn = new System.Windows.Forms.Button();
            this.outsourcingBtn = new System.Windows.Forms.Button();
            this.returnToMainBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customerBtn
            // 
            this.customerBtn.Location = new System.Drawing.Point(106, 43);
            this.customerBtn.Margin = new System.Windows.Forms.Padding(2);
            this.customerBtn.Name = "customerBtn";
            this.customerBtn.Size = new System.Drawing.Size(94, 20);
            this.customerBtn.TabIndex = 0;
            this.customerBtn.Text = "Klient";
            this.customerBtn.UseVisualStyleBackColor = true;
            this.customerBtn.Click += new System.EventHandler(this.customerBtn_Click);
            // 
            // orderBtn
            // 
            this.orderBtn.Location = new System.Drawing.Point(106, 82);
            this.orderBtn.Margin = new System.Windows.Forms.Padding(2);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(94, 20);
            this.orderBtn.TabIndex = 1;
            this.orderBtn.Text = "Zamówienie";
            this.orderBtn.UseVisualStyleBackColor = true;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // warehouseBtn
            // 
            this.warehouseBtn.Location = new System.Drawing.Point(106, 121);
            this.warehouseBtn.Margin = new System.Windows.Forms.Padding(2);
            this.warehouseBtn.Name = "warehouseBtn";
            this.warehouseBtn.Size = new System.Drawing.Size(94, 20);
            this.warehouseBtn.TabIndex = 2;
            this.warehouseBtn.Text = "Magazyn";
            this.warehouseBtn.UseVisualStyleBackColor = true;
            this.warehouseBtn.Click += new System.EventHandler(this.warehouseBtn_Click);
            // 
            // suppliersBtn
            // 
            this.suppliersBtn.Location = new System.Drawing.Point(106, 163);
            this.suppliersBtn.Margin = new System.Windows.Forms.Padding(2);
            this.suppliersBtn.Name = "suppliersBtn";
            this.suppliersBtn.Size = new System.Drawing.Size(94, 20);
            this.suppliersBtn.TabIndex = 3;
            this.suppliersBtn.Text = "Dostawcy";
            this.suppliersBtn.UseVisualStyleBackColor = true;
            this.suppliersBtn.Click += new System.EventHandler(this.suppliersBtn_Click);
            // 
            // outsourcingBtn
            // 
            this.outsourcingBtn.Location = new System.Drawing.Point(106, 206);
            this.outsourcingBtn.Margin = new System.Windows.Forms.Padding(2);
            this.outsourcingBtn.Name = "outsourcingBtn";
            this.outsourcingBtn.Size = new System.Drawing.Size(94, 20);
            this.outsourcingBtn.TabIndex = 4;
            this.outsourcingBtn.Text = "Outsourcing";
            this.outsourcingBtn.UseVisualStyleBackColor = true;
            this.outsourcingBtn.Click += new System.EventHandler(this.outsourcingBtn_Click);
            // 
            // returnToMainBtn
            // 
            this.returnToMainBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.returnToMainBtn.Location = new System.Drawing.Point(106, 250);
            this.returnToMainBtn.Name = "returnToMainBtn";
            this.returnToMainBtn.Size = new System.Drawing.Size(93, 25);
            this.returnToMainBtn.TabIndex = 5;
            this.returnToMainBtn.Text = "Powrót";
            this.returnToMainBtn.UseVisualStyleBackColor = true;
            this.returnToMainBtn.Click += new System.EventHandler(this.returnToMainBtn_Click);
            // 
            // SalesDepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.returnToMainBtn);
            this.Controls.Add(this.outsourcingBtn);
            this.Controls.Add(this.suppliersBtn);
            this.Controls.Add(this.warehouseBtn);
            this.Controls.Add(this.orderBtn);
            this.Controls.Add(this.customerBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SalesDepartmentForm";
            this.Text = "SalesDepartmentForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button customerBtn;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.Button warehouseBtn;
        private System.Windows.Forms.Button suppliersBtn;
        private System.Windows.Forms.Button outsourcingBtn;
        private System.Windows.Forms.Button returnToMainBtn;
    }
}