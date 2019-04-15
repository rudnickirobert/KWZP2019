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
            this.SDF_Klient_btn = new System.Windows.Forms.Button();
            this.SDF_Zamowienie_btn = new System.Windows.Forms.Button();
            this.SDF_Magazyn_btn = new System.Windows.Forms.Button();
            this.SDF_Dostawcy_btn = new System.Windows.Forms.Button();
            this.SDF_Outsourcing_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SDF_Klient_btn
            // 
            this.SDF_Klient_btn.Location = new System.Drawing.Point(141, 53);
            this.SDF_Klient_btn.Name = "SDF_Klient_btn";
            this.SDF_Klient_btn.Size = new System.Drawing.Size(125, 25);
            this.SDF_Klient_btn.TabIndex = 0;
            this.SDF_Klient_btn.Text = "Klient";
            this.SDF_Klient_btn.UseVisualStyleBackColor = true;
            this.SDF_Klient_btn.Click += new System.EventHandler(this.SDF_Klient_btn_Click);
            // 
            // SDF_Zamowienie_btn
            // 
            this.SDF_Zamowienie_btn.Location = new System.Drawing.Point(141, 101);
            this.SDF_Zamowienie_btn.Name = "SDF_Zamowienie_btn";
            this.SDF_Zamowienie_btn.Size = new System.Drawing.Size(125, 25);
            this.SDF_Zamowienie_btn.TabIndex = 1;
            this.SDF_Zamowienie_btn.Text = "Zamówienie";
            this.SDF_Zamowienie_btn.UseVisualStyleBackColor = true;
            this.SDF_Zamowienie_btn.Click += new System.EventHandler(this.SDF_Zamowienie_btn_Click);
            // 
            // SDF_Magazyn_btn
            // 
            this.SDF_Magazyn_btn.Location = new System.Drawing.Point(141, 149);
            this.SDF_Magazyn_btn.Name = "SDF_Magazyn_btn";
            this.SDF_Magazyn_btn.Size = new System.Drawing.Size(125, 25);
            this.SDF_Magazyn_btn.TabIndex = 2;
            this.SDF_Magazyn_btn.Text = "Magazyn";
            this.SDF_Magazyn_btn.UseVisualStyleBackColor = true;
            this.SDF_Magazyn_btn.Click += new System.EventHandler(this.SDF_Magazyn_btn_Click);
            // 
            // SDF_Dostawcy_btn
            // 
            this.SDF_Dostawcy_btn.Location = new System.Drawing.Point(141, 201);
            this.SDF_Dostawcy_btn.Name = "SDF_Dostawcy_btn";
            this.SDF_Dostawcy_btn.Size = new System.Drawing.Size(125, 25);
            this.SDF_Dostawcy_btn.TabIndex = 3;
            this.SDF_Dostawcy_btn.Text = "Dostawcy";
            this.SDF_Dostawcy_btn.UseVisualStyleBackColor = true;
            this.SDF_Dostawcy_btn.Click += new System.EventHandler(this.SDF_Dostawcy_btn_Click);
            // 
            // SDF_Outsourcing_btn
            // 
            this.SDF_Outsourcing_btn.Location = new System.Drawing.Point(141, 253);
            this.SDF_Outsourcing_btn.Name = "SDF_Outsourcing_btn";
            this.SDF_Outsourcing_btn.Size = new System.Drawing.Size(125, 25);
            this.SDF_Outsourcing_btn.TabIndex = 4;
            this.SDF_Outsourcing_btn.Text = "Outsourcing";
            this.SDF_Outsourcing_btn.UseVisualStyleBackColor = true;
            this.SDF_Outsourcing_btn.Click += new System.EventHandler(this.SDF_Outsourcing_btn_Click);
            // 
            // SalesDepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SDF_Outsourcing_btn);
            this.Controls.Add(this.SDF_Dostawcy_btn);
            this.Controls.Add(this.SDF_Magazyn_btn);
            this.Controls.Add(this.SDF_Zamowienie_btn);
            this.Controls.Add(this.SDF_Klient_btn);
            this.Name = "SalesDepartmentForm";
            this.Text = "SalesDepartmentForm";
            this.Load += new System.EventHandler(this.SalesDepartmentForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SDF_Klient_btn;
        private System.Windows.Forms.Button SDF_Zamowienie_btn;
        private System.Windows.Forms.Button SDF_Magazyn_btn;
        private System.Windows.Forms.Button SDF_Dostawcy_btn;
        private System.Windows.Forms.Button SDF_Outsourcing_btn;
    }
}