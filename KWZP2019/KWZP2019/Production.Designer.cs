namespace KWZP2019
{
    partial class Production
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
            this.btnProductionPlanned = new System.Windows.Forms.Button();
            this.btnProductionProcess = new System.Windows.Forms.Button();
            this.btnFailures = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnTechnology = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProductionPlanned
            // 
            this.btnProductionPlanned.Location = new System.Drawing.Point(12, 284);
            this.btnProductionPlanned.Name = "btnProductionPlanned";
            this.btnProductionPlanned.Size = new System.Drawing.Size(418, 62);
            this.btnProductionPlanned.TabIndex = 9;
            this.btnProductionPlanned.Text = "Planowana produkcja";
            this.btnProductionPlanned.UseVisualStyleBackColor = true;
            this.btnProductionPlanned.Click += new System.EventHandler(this.btnProductionPlanned_Click);
            // 
            // btnProductionProcess
            // 
            this.btnProductionProcess.Location = new System.Drawing.Point(12, 216);
            this.btnProductionProcess.Name = "btnProductionProcess";
            this.btnProductionProcess.Size = new System.Drawing.Size(418, 62);
            this.btnProductionProcess.TabIndex = 8;
            this.btnProductionProcess.Text = "Aktualna Produkcja";
            this.btnProductionProcess.UseVisualStyleBackColor = true;
            this.btnProductionProcess.Click += new System.EventHandler(this.btnProductionProcess_Click);
            // 
            // btnFailures
            // 
            this.btnFailures.Location = new System.Drawing.Point(12, 148);
            this.btnFailures.Name = "btnFailures";
            this.btnFailures.Size = new System.Drawing.Size(418, 62);
            this.btnFailures.TabIndex = 7;
            this.btnFailures.Text = "Awarie";
            this.btnFailures.UseVisualStyleBackColor = true;
            this.btnFailures.Click += new System.EventHandler(this.btnFailures_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(12, 80);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(418, 62);
            this.btnProducts.TabIndex = 6;
            this.btnProducts.Text = "Produkty";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnTechnology
            // 
            this.btnTechnology.Location = new System.Drawing.Point(12, 12);
            this.btnTechnology.Name = "btnTechnology";
            this.btnTechnology.Size = new System.Drawing.Size(418, 62);
            this.btnTechnology.TabIndex = 5;
            this.btnTechnology.Text = "Technologia";
            this.btnTechnology.UseVisualStyleBackColor = true;
            this.btnTechnology.Click += new System.EventHandler(this.btnTechnology_Click);
            // 
            // Production
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 357);
            this.Controls.Add(this.btnProductionPlanned);
            this.Controls.Add(this.btnProductionProcess);
            this.Controls.Add(this.btnFailures);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.btnTechnology);
            this.Name = "Production";
            this.Text = "Produkcja";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProductionPlanned;
        private System.Windows.Forms.Button btnProductionProcess;
        private System.Windows.Forms.Button btnFailures;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnTechnology;
    }
}