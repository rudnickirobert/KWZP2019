namespace KWZP2019
{
    partial class AddInvoices
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
            this.lblDateAdded = new System.Windows.Forms.Label();
            this.lblInvoiceValue = new System.Windows.Forms.Label();
            this.dtpDateAdded = new System.Windows.Forms.DateTimePicker();
            this.tbInvoiceValue = new System.Windows.Forms.TextBox();
            this.lblPln = new System.Windows.Forms.Label();
            this.btnAddNewInvoice = new System.Windows.Forms.Button();
            this.btnAddNewCompany = new System.Windows.Forms.Button();
            this.cbContractors = new System.Windows.Forms.ComboBox();
            this.cbInvoiceType = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDateAdded
            // 
            this.lblDateAdded.AutoSize = true;
            this.lblDateAdded.Location = new System.Drawing.Point(407, 276);
            this.lblDateAdded.Name = "lblDateAdded";
            this.lblDateAdded.Size = new System.Drawing.Size(93, 13);
            this.lblDateAdded.TabIndex = 9;
            this.lblDateAdded.Text = "Data wystawienia:";
            // 
            // lblInvoiceValue
            // 
            this.lblInvoiceValue.AutoSize = true;
            this.lblInvoiceValue.Location = new System.Drawing.Point(407, 303);
            this.lblInvoiceValue.Name = "lblInvoiceValue";
            this.lblInvoiceValue.Size = new System.Drawing.Size(85, 13);
            this.lblInvoiceValue.TabIndex = 10;
            this.lblInvoiceValue.Text = "Wartosć faktury:";
            // 
            // dtpDateAdded
            // 
            this.dtpDateAdded.Location = new System.Drawing.Point(519, 270);
            this.dtpDateAdded.Name = "dtpDateAdded";
            this.dtpDateAdded.Size = new System.Drawing.Size(200, 20);
            this.dtpDateAdded.TabIndex = 17;
            // 
            // tbInvoiceValue
            // 
            this.tbInvoiceValue.Location = new System.Drawing.Point(519, 300);
            this.tbInvoiceValue.Name = "tbInvoiceValue";
            this.tbInvoiceValue.Size = new System.Drawing.Size(200, 20);
            this.tbInvoiceValue.TabIndex = 18;
            this.tbInvoiceValue.Text = "0";
            this.tbInvoiceValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPln
            // 
            this.lblPln.AutoSize = true;
            this.lblPln.Location = new System.Drawing.Point(725, 303);
            this.lblPln.Name = "lblPln";
            this.lblPln.Size = new System.Drawing.Size(75, 13);
            this.lblPln.TabIndex = 19;
            this.lblPln.Text = "złotych (netto)";
            // 
            // btnAddNewInvoice
            // 
            this.btnAddNewInvoice.Location = new System.Drawing.Point(322, 472);
            this.btnAddNewInvoice.Name = "btnAddNewInvoice";
            this.btnAddNewInvoice.Size = new System.Drawing.Size(500, 47);
            this.btnAddNewInvoice.TabIndex = 20;
            this.btnAddNewInvoice.Text = "Dodaj nową fakturę";
            this.btnAddNewInvoice.UseVisualStyleBackColor = true;
            this.btnAddNewInvoice.Click += new System.EventHandler(this.btnAddNewInvoice_Click);
            // 
            // btnAddNewCompany
            // 
            this.btnAddNewCompany.Location = new System.Drawing.Point(322, 546);
            this.btnAddNewCompany.Name = "btnAddNewCompany";
            this.btnAddNewCompany.Size = new System.Drawing.Size(500, 83);
            this.btnAddNewCompany.TabIndex = 22;
            this.btnAddNewCompany.Text = "Dodaj nowy podmiot do listy rozwijanej";
            this.btnAddNewCompany.UseVisualStyleBackColor = true;
            this.btnAddNewCompany.Click += new System.EventHandler(this.btnAddNewCompany_Click);
            // 
            // cbContractors
            // 
            this.cbContractors.FormattingEnabled = true;
            this.cbContractors.Location = new System.Drawing.Point(345, 230);
            this.cbContractors.Name = "cbContractors";
            this.cbContractors.Size = new System.Drawing.Size(500, 21);
            this.cbContractors.TabIndex = 23;
            this.cbContractors.Text = "wybierz podmiot";
            // 
            // cbInvoiceType
            // 
            this.cbInvoiceType.FormattingEnabled = true;
            this.cbInvoiceType.Location = new System.Drawing.Point(519, 326);
            this.cbInvoiceType.Name = "cbInvoiceType";
            this.cbInvoiceType.Size = new System.Drawing.Size(200, 21);
            this.cbInvoiceType.TabIndex = 25;
            this.cbInvoiceType.Text = "wybierz typ faktury";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(386, 169);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // AddInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KWZP2019.Properties.Resources._53062472_302328053765523_8291849142804676608_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 749);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbInvoiceType);
            this.Controls.Add(this.cbContractors);
            this.Controls.Add(this.btnAddNewCompany);
            this.Controls.Add(this.btnAddNewInvoice);
            this.Controls.Add(this.lblPln);
            this.Controls.Add(this.tbInvoiceValue);
            this.Controls.Add(this.dtpDateAdded);
            this.Controls.Add(this.lblInvoiceValue);
            this.Controls.Add(this.lblDateAdded);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddInvoices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj fakturę";
            this.Load += new System.EventHandler(this.AddInvoices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDateAdded;
        private System.Windows.Forms.Label lblInvoiceValue;
        private System.Windows.Forms.DateTimePicker dtpDateAdded;
        private System.Windows.Forms.TextBox tbInvoiceValue;
        private System.Windows.Forms.Label lblPln;
        private System.Windows.Forms.Button btnAddNewInvoice;
        private System.Windows.Forms.Button btnAddNewCompany;
        private System.Windows.Forms.ComboBox cbContractors;
        private System.Windows.Forms.ComboBox cbInvoiceType;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}