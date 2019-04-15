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
            this.CF_Dodajklienta_btn = new System.Windows.Forms.Button();
            this.CF_Zamówienie_btn = new System.Windows.Forms.Button();
            this.Klienci_dgv = new System.Windows.Forms.DataGridView();
            this.Nazwa_lbl = new System.Windows.Forms.Label();
            this.Nazwa_tb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Klienci_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // CF_Dodajklienta_btn
            // 
            this.CF_Dodajklienta_btn.Location = new System.Drawing.Point(365, 8);
            this.CF_Dodajklienta_btn.Name = "CF_Dodajklienta_btn";
            this.CF_Dodajklienta_btn.Size = new System.Drawing.Size(148, 25);
            this.CF_Dodajklienta_btn.TabIndex = 1;
            this.CF_Dodajklienta_btn.Text = "Dodaj klienta";
            this.CF_Dodajklienta_btn.UseVisualStyleBackColor = true;
            this.CF_Dodajklienta_btn.Click += new System.EventHandler(this.CF_Dodajklienta_btn_Click);
            // 
            // CF_Zamówienie_btn
            // 
            this.CF_Zamówienie_btn.Location = new System.Drawing.Point(616, 10);
            this.CF_Zamówienie_btn.Name = "CF_Zamówienie_btn";
            this.CF_Zamówienie_btn.Size = new System.Drawing.Size(148, 23);
            this.CF_Zamówienie_btn.TabIndex = 12;
            this.CF_Zamówienie_btn.Text = "Zamówienie";
            this.CF_Zamówienie_btn.UseVisualStyleBackColor = true;
            this.CF_Zamówienie_btn.Click += new System.EventHandler(this.CF_Zamówienie_btn_Click);
            // 
            // Klienci_dgv
            // 
            this.Klienci_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Klienci_dgv.Location = new System.Drawing.Point(47, 54);
            this.Klienci_dgv.Name = "Klienci_dgv";
            this.Klienci_dgv.RowTemplate.Height = 24;
            this.Klienci_dgv.Size = new System.Drawing.Size(832, 150);
            this.Klienci_dgv.TabIndex = 15;
            // 
            // Nazwa_lbl
            // 
            this.Nazwa_lbl.AutoSize = true;
            this.Nazwa_lbl.Location = new System.Drawing.Point(44, 9);
            this.Nazwa_lbl.Name = "Nazwa_lbl";
            this.Nazwa_lbl.Size = new System.Drawing.Size(50, 17);
            this.Nazwa_lbl.TabIndex = 13;
            this.Nazwa_lbl.Text = "Nazwa";
            // 
            // Nazwa_tb
            // 
            this.Nazwa_tb.Location = new System.Drawing.Point(112, 9);
            this.Nazwa_tb.Name = "Nazwa_tb";
            this.Nazwa_tb.Size = new System.Drawing.Size(172, 22);
            this.Nazwa_tb.TabIndex = 14;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.Klienci_dgv);
            this.Controls.Add(this.Nazwa_tb);
            this.Controls.Add(this.Nazwa_lbl);
            this.Controls.Add(this.CF_Zamówienie_btn);
            this.Controls.Add(this.CF_Dodajklienta_btn);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Klienci_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CF_Dodajklienta_btn;
        private System.Windows.Forms.Button CF_Zamówienie_btn;
        private System.Windows.Forms.DataGridView Klienci_dgv;
        private System.Windows.Forms.Label Nazwa_lbl;
        private System.Windows.Forms.TextBox Nazwa_tb;
    }
}