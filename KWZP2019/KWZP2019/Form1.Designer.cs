namespace KWZP2019
{
    partial class startForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
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
            this.btnSales = new System.Windows.Forms.Button();
            this.btnProduction = new System.Windows.Forms.Button();
            this.btnHR = new System.Windows.Forms.Button();
            this.btnQA = new System.Windows.Forms.Button();
            this.btnMaintenance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSales
            // 
            this.btnSales.Location = new System.Drawing.Point(12, 12);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(418, 62);
            this.btnSales.TabIndex = 0;
            this.btnSales.Text = "Dział handlowy";
            this.btnSales.UseVisualStyleBackColor = true;
            // 
            // btnProduction
            // 
            this.btnProduction.Location = new System.Drawing.Point(12, 80);
            this.btnProduction.Name = "btnProduction";
            this.btnProduction.Size = new System.Drawing.Size(418, 62);
            this.btnProduction.TabIndex = 1;
            this.btnProduction.Text = "Produkcja";
            this.btnProduction.UseVisualStyleBackColor = true;
            // 
            // btnHR
            // 
            this.btnHR.Location = new System.Drawing.Point(12, 148);
            this.btnHR.Name = "btnHR";
            this.btnHR.Size = new System.Drawing.Size(418, 62);
            this.btnHR.TabIndex = 2;
            this.btnHR.Text = "Kadry i finanse";
            this.btnHR.UseVisualStyleBackColor = true;
            // 
            // btnQA
            // 
            this.btnQA.Location = new System.Drawing.Point(12, 216);
            this.btnQA.Name = "btnQA";
            this.btnQA.Size = new System.Drawing.Size(418, 62);
            this.btnQA.TabIndex = 3;
            this.btnQA.Text = "Kontrola jakości";
            this.btnQA.UseVisualStyleBackColor = true;
            this.btnQA.Click += new System.EventHandler(this.btnQA_Click);
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.Location = new System.Drawing.Point(12, 284);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Size = new System.Drawing.Size(418, 62);
            this.btnMaintenance.TabIndex = 4;
            this.btnMaintenance.Text = "Utrzymanie ruchu";
            this.btnMaintenance.UseVisualStyleBackColor = true;
            // 
            // startForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 364);
            this.Controls.Add(this.btnMaintenance);
            this.Controls.Add(this.btnQA);
            this.Controls.Add(this.btnHR);
            this.Controls.Add(this.btnProduction);
            this.Controls.Add(this.btnSales);
            this.Name = "startForm";
            this.Text = "Formularz startowy";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnProduction;
        private System.Windows.Forms.Button btnHR;
        private System.Windows.Forms.Button btnQA;
        private System.Windows.Forms.Button btnMaintenance;
    }
}

