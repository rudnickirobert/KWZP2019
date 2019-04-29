namespace KWZP2019
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.btnSales = new System.Windows.Forms.Button();
            this.btnProduction = new System.Windows.Forms.Button();
            this.btnHR = new System.Windows.Forms.Button();
            this.btnQA = new System.Windows.Forms.Button();
            this.btnMaintenance = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSales
            // 
            resources.ApplyResources(this.btnSales, "btnSales");
            this.btnSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnSales.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnSales.FlatAppearance.BorderSize = 3;
            this.btnSales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnSales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnSales.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSales.Image = global::KWZP2019.Properties.Resources.icons8_sell_stock_80;
            this.btnSales.Name = "btnSales";
            this.btnSales.UseVisualStyleBackColor = false;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnProduction
            // 
            resources.ApplyResources(this.btnProduction, "btnProduction");
            this.btnProduction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnProduction.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnProduction.FlatAppearance.BorderSize = 3;
            this.btnProduction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnProduction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnProduction.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProduction.Image = global::KWZP2019.Properties.Resources.icons8_automation_80;
            this.btnProduction.Name = "btnProduction";
            this.btnProduction.UseVisualStyleBackColor = false;
            this.btnProduction.Click += new System.EventHandler(this.btnProduction_Click);
            // 
            // btnHR
            // 
            resources.ApplyResources(this.btnHR, "btnHR");
            this.btnHR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnHR.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnHR.FlatAppearance.BorderSize = 3;
            this.btnHR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnHR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnHR.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHR.Image = global::KWZP2019.Properties.Resources.icons8_duration_finance_80;
            this.btnHR.Name = "btnHR";
            this.btnHR.UseVisualStyleBackColor = false;
            this.btnHR.Click += new System.EventHandler(this.btnHR_Click);
            // 
            // btnQA
            // 
            resources.ApplyResources(this.btnQA, "btnQA");
            this.btnQA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnQA.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnQA.FlatAppearance.BorderSize = 3;
            this.btnQA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnQA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnQA.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnQA.Image = global::KWZP2019.Properties.Resources.icons8_quality_80;
            this.btnQA.Name = "btnQA";
            this.btnQA.UseVisualStyleBackColor = false;
            this.btnQA.Click += new System.EventHandler(this.btnQA_Click);
            // 
            // btnMaintenance
            // 
            resources.ApplyResources(this.btnMaintenance, "btnMaintenance");
            this.btnMaintenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnMaintenance.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMaintenance.FlatAppearance.BorderSize = 3;
            this.btnMaintenance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnMaintenance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnMaintenance.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMaintenance.Image = global::KWZP2019.Properties.Resources.icons8_maintenance_80;
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.UseVisualStyleBackColor = false;
            this.btnMaintenance.Click += new System.EventHandler(this.btnMaintenance_Click);
            // 
            // lblWelcome
            // 
            resources.ApplyResources(this.lblWelcome, "lblWelcome");
            this.lblWelcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.lblWelcome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblWelcome.Name = "lblWelcome";
            // 
            // StartForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::KWZP2019.Properties.Resources._53062472_302328053765523_8291849142804676608_n;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnMaintenance);
            this.Controls.Add(this.btnQA);
            this.Controls.Add(this.btnHR);
            this.Controls.Add(this.btnProduction);
            this.Controls.Add(this.btnSales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnProduction;
        private System.Windows.Forms.Button btnHR;
        private System.Windows.Forms.Button btnQA;
        private System.Windows.Forms.Button btnMaintenance;
        private System.Windows.Forms.Label lblWelcome;
    }
}

