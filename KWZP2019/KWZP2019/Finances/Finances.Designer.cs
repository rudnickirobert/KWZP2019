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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Finances));
            this.btnPayments = new System.Windows.Forms.Button();
            this.btnCountPayments = new System.Windows.Forms.Button();
            this.btnCosts = new System.Windows.Forms.Button();
            this.btnEarnings = new System.Windows.Forms.Button();
            this.btnFinancialStatement = new System.Windows.Forms.Button();
            this.btnAddInvoice = new System.Windows.Forms.Button();
            this.lblIntroduction = new System.Windows.Forms.Label();
            this.lblOtherFunctions = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnReturnMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPayments
            // 
            this.btnPayments.Location = new System.Drawing.Point(365, 116);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(290, 160);
            this.btnPayments.TabIndex = 0;
            this.btnPayments.Text = "Wypłaty";
            this.btnPayments.UseVisualStyleBackColor = true;
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // btnCountPayments
            // 
            this.btnCountPayments.Location = new System.Drawing.Point(365, 310);
            this.btnCountPayments.Name = "btnCountPayments";
            this.btnCountPayments.Size = new System.Drawing.Size(290, 160);
            this.btnCountPayments.TabIndex = 1;
            this.btnCountPayments.Text = "Podlicz wypłaty";
            this.btnCountPayments.UseVisualStyleBackColor = true;
            this.btnCountPayments.Click += new System.EventHandler(this.btnCountPayments_Click);
            // 
            // btnCosts
            // 
            this.btnCosts.Location = new System.Drawing.Point(787, 116);
            this.btnCosts.Name = "btnCosts";
            this.btnCosts.Size = new System.Drawing.Size(290, 160);
            this.btnCosts.TabIndex = 2;
            this.btnCosts.Text = "Koszty";
            this.btnCosts.UseVisualStyleBackColor = true;
            this.btnCosts.Click += new System.EventHandler(this.btnCosts_Click);
            // 
            // btnEarnings
            // 
            this.btnEarnings.Location = new System.Drawing.Point(787, 310);
            this.btnEarnings.Name = "btnEarnings";
            this.btnEarnings.Size = new System.Drawing.Size(290, 160);
            this.btnEarnings.TabIndex = 3;
            this.btnEarnings.Text = "Zyski";
            this.btnEarnings.UseVisualStyleBackColor = true;
            this.btnEarnings.Click += new System.EventHandler(this.btnEarnings_Click);
            // 
            // btnFinancialStatement
            // 
            this.btnFinancialStatement.Location = new System.Drawing.Point(787, 502);
            this.btnFinancialStatement.Name = "btnFinancialStatement";
            this.btnFinancialStatement.Size = new System.Drawing.Size(290, 160);
            this.btnFinancialStatement.TabIndex = 4;
            this.btnFinancialStatement.Text = "Bilans finansowy";
            this.btnFinancialStatement.UseVisualStyleBackColor = true;
            this.btnFinancialStatement.Click += new System.EventHandler(this.btnFinancialStatement_Click);
            // 
            // btnAddInvoice
            // 
            this.btnAddInvoice.Location = new System.Drawing.Point(365, 502);
            this.btnAddInvoice.Name = "btnAddInvoice";
            this.btnAddInvoice.Size = new System.Drawing.Size(290, 160);
            this.btnAddInvoice.TabIndex = 5;
            this.btnAddInvoice.Text = "Dodaj fakturę";
            this.btnAddInvoice.UseVisualStyleBackColor = true;
            this.btnAddInvoice.Click += new System.EventHandler(this.btnAddInvoice_Click);
            // 
            // lblIntroduction
            // 
            this.lblIntroduction.Location = new System.Drawing.Point(369, 32);
            this.lblIntroduction.Margin = new System.Windows.Forms.Padding(0);
            this.lblIntroduction.Name = "lblIntroduction";
            this.lblIntroduction.Size = new System.Drawing.Size(286, 39);
            this.lblIntroduction.TabIndex = 6;
            this.lblIntroduction.Text = "WPROWADZANIE";
            this.lblIntroduction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOtherFunctions
            // 
            this.lblOtherFunctions.Location = new System.Drawing.Point(787, 32);
            this.lblOtherFunctions.Name = "lblOtherFunctions";
            this.lblOtherFunctions.Size = new System.Drawing.Size(290, 39);
            this.lblOtherFunctions.TabIndex = 7;
            this.lblOtherFunctions.Text = "POZOSTAŁE FUNKCJE";
            this.lblOtherFunctions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnReturn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
            this.btnReturn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReturn.Location = new System.Drawing.Point(31, 32);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(0);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(208, 118);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.Text = "Powrót";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturn.UseVisualStyleBackColor = false;
            // 
            // btnReturnMain
            // 
            this.btnReturnMain.Location = new System.Drawing.Point(31, 157);
            this.btnReturnMain.Name = "btnReturnMain";
            this.btnReturnMain.Size = new System.Drawing.Size(208, 119);
            this.btnReturnMain.TabIndex = 9;
            this.btnReturnMain.Text = "Menu główne";
            this.btnReturnMain.UseVisualStyleBackColor = true;
            // 
            // Finances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KWZP2019.Properties.Resources._53062472_302328053765523_8291849142804676608_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 749);
            this.Controls.Add(this.btnReturnMain);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblOtherFunctions);
            this.Controls.Add(this.lblIntroduction);
            this.Controls.Add(this.btnAddInvoice);
            this.Controls.Add(this.btnFinancialStatement);
            this.Controls.Add(this.btnEarnings);
            this.Controls.Add(this.btnCosts);
            this.Controls.Add(this.btnCountPayments);
            this.Controls.Add(this.btnPayments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Finances";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finanse";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPayments;
        private System.Windows.Forms.Button btnCountPayments;
        private System.Windows.Forms.Button btnCosts;
        private System.Windows.Forms.Button btnEarnings;
        private System.Windows.Forms.Button btnFinancialStatement;
        private System.Windows.Forms.Button btnAddInvoice;
        private System.Windows.Forms.Label lblIntroduction;
        private System.Windows.Forms.Label lblOtherFunctions;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnReturnMain;
    }
}

