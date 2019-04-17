namespace KWZP2019
{
    partial class Finances
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPayments = new System.Windows.Forms.Button();
            this.btnCountpayments = new System.Windows.Forms.Button();
            this.btnCosts = new System.Windows.Forms.Button();
            this.btnEarnings = new System.Windows.Forms.Button();
            this.btnFinancialstatement = new System.Windows.Forms.Button();
            this.btnAddinvoice = new System.Windows.Forms.Button();
            this.lblIntroduction = new System.Windows.Forms.Label();
            this.lblOtherfunctions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPayments
            // 
            this.btnPayments.Location = new System.Drawing.Point(49, 77);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(140, 50);
            this.btnPayments.TabIndex = 0;
            this.btnPayments.Text = "Wypłaty";
            this.btnPayments.UseVisualStyleBackColor = true;
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // btnCountpayments
            // 
            this.btnCountpayments.Location = new System.Drawing.Point(195, 77);
            this.btnCountpayments.Name = "btnCountpayments";
            this.btnCountpayments.Size = new System.Drawing.Size(140, 50);
            this.btnCountpayments.TabIndex = 1;
            this.btnCountpayments.Text = "Podlicz wypłaty";
            this.btnCountpayments.UseVisualStyleBackColor = true;
            this.btnCountpayments.Click += new System.EventHandler(this.btnCountpayments_Click);
            // 
            // btnCosts
            // 
            this.btnCosts.Location = new System.Drawing.Point(342, 77);
            this.btnCosts.Name = "btnCosts";
            this.btnCosts.Size = new System.Drawing.Size(140, 50);
            this.btnCosts.TabIndex = 2;
            this.btnCosts.Text = "Koszty";
            this.btnCosts.UseVisualStyleBackColor = true;
            this.btnCosts.Click += new System.EventHandler(this.btnCosts_Click);
            // 
            // btnEarnings
            // 
            this.btnEarnings.Location = new System.Drawing.Point(49, 218);
            this.btnEarnings.Name = "btnEarnings";
            this.btnEarnings.Size = new System.Drawing.Size(140, 50);
            this.btnEarnings.TabIndex = 3;
            this.btnEarnings.Text = "Zyski";
            this.btnEarnings.UseVisualStyleBackColor = true;
            this.btnEarnings.Click += new System.EventHandler(this.btnEarnings_Click);
            // 
            // btnFinancialstatement
            // 
            this.btnFinancialstatement.Location = new System.Drawing.Point(195, 218);
            this.btnFinancialstatement.Name = "btnFinancialstatement";
            this.btnFinancialstatement.Size = new System.Drawing.Size(140, 50);
            this.btnFinancialstatement.TabIndex = 4;
            this.btnFinancialstatement.Text = "Bilans finansowy";
            this.btnFinancialstatement.UseVisualStyleBackColor = true;
            this.btnFinancialstatement.Click += new System.EventHandler(this.btnFinancialstatement_Click);
            // 
            // btnAddinvoice
            // 
            this.btnAddinvoice.Location = new System.Drawing.Point(342, 218);
            this.btnAddinvoice.Name = "btnAddinvoice";
            this.btnAddinvoice.Size = new System.Drawing.Size(140, 50);
            this.btnAddinvoice.TabIndex = 5;
            this.btnAddinvoice.Text = "Dodaj fakturę";
            this.btnAddinvoice.UseVisualStyleBackColor = true;
            this.btnAddinvoice.Click += new System.EventHandler(this.btnAddinvoice_Click);
            // 
            // lblIntroduction
            // 
            this.lblIntroduction.AutoSize = true;
            this.lblIntroduction.Location = new System.Drawing.Point(218, 32);
            this.lblIntroduction.Name = "lblIntroduction";
            this.lblIntroduction.Size = new System.Drawing.Size(99, 13);
            this.lblIntroduction.TabIndex = 6;
            this.lblIntroduction.Text = "WPROWADZANIE";
            // 
            // lblOtherfunctions
            // 
            this.lblOtherfunctions.AutoSize = true;
            this.lblOtherfunctions.Location = new System.Drawing.Point(203, 186);
            this.lblOtherfunctions.Name = "lblOtherfunctions";
            this.lblOtherfunctions.Size = new System.Drawing.Size(123, 13);
            this.lblOtherfunctions.TabIndex = 7;
            this.lblOtherfunctions.Text = "POZOSTAŁE FUNKCJE";
            // 
            // finances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 331);
            this.Controls.Add(this.lblOtherfunctions);
            this.Controls.Add(this.lblIntroduction);
            this.Controls.Add(this.btnAddinvoice);
            this.Controls.Add(this.btnFinancialstatement);
            this.Controls.Add(this.btnEarnings);
            this.Controls.Add(this.btnCosts);
            this.Controls.Add(this.btnCountpayments);
            this.Controls.Add(this.btnPayments);
            this.Name = "finances";
            this.Text = "Finanse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPayments;
        private System.Windows.Forms.Button btnCountpayments;
        private System.Windows.Forms.Button btnCosts;
        private System.Windows.Forms.Button btnEarnings;
        private System.Windows.Forms.Button btnFinancialstatement;
        private System.Windows.Forms.Button btnAddinvoice;
        private System.Windows.Forms.Label lblIntroduction;
        private System.Windows.Forms.Label lblOtherfunctions;
    }
}

