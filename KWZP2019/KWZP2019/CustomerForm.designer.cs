namespace KWZP2019
{
    partial class CustomerForm
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
            this.addNewCustomerBtn = new System.Windows.Forms.Button();
            this.orderBtn = new System.Windows.Forms.Button();
            this.customersDgv = new System.Windows.Forms.DataGridView();
            this.nameLbl = new System.Windows.Forms.Label();
            this.nameTb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.customersDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // addNewCustomerBtn
            // 
            this.addNewCustomerBtn.Location = new System.Drawing.Point(365, 8);
            this.addNewCustomerBtn.Name = "addNewCustomerBtn";
            this.addNewCustomerBtn.Size = new System.Drawing.Size(148, 25);
            this.addNewCustomerBtn.TabIndex = 1;
            this.addNewCustomerBtn.Text = "Dodaj klienta";
            this.addNewCustomerBtn.UseVisualStyleBackColor = true;
            this.addNewCustomerBtn.Click += new System.EventHandler(this.addNewCustomerBtn_Click);
            // 
            // orderBtn
            // 
            this.orderBtn.Location = new System.Drawing.Point(616, 10);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(148, 23);
            this.orderBtn.TabIndex = 12;
            this.orderBtn.Text = "Zamówienie";
            this.orderBtn.UseVisualStyleBackColor = true;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // customersDgv
            // 
            this.customersDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDgv.Location = new System.Drawing.Point(47, 54);
            this.customersDgv.Name = "customersDgv";
            this.customersDgv.RowTemplate.Height = 24;
            this.customersDgv.Size = new System.Drawing.Size(832, 150);
            this.customersDgv.TabIndex = 15;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(44, 9);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(50, 17);
            this.nameLbl.TabIndex = 13;
            this.nameLbl.Text = "Nazwa";
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(112, 9);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(172, 22);
            this.nameTb.TabIndex = 14;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.customersDgv);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.orderBtn);
            this.Controls.Add(this.addNewCustomerBtn);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            ((System.ComponentModel.ISupportInitialize)(this.customersDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addNewCustomerBtn;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.DataGridView customersDgv;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox nameTb;
    }
}