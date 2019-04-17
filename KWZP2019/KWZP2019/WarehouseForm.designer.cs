namespace KWZP2019
{
    partial class WarehouseForm
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
            this.entranceWarehouseBtn = new System.Windows.Forms.Button();
            this.outWarehouseBtn = new System.Windows.Forms.Button();
            this.entranceWarehouseGb = new System.Windows.Forms.GroupBox();
            this.Pracownikkontrola_tb = new System.Windows.Forms.TextBox();
            this.Pracownikzamowienie_tb = new System.Windows.Forms.TextBox();
            this.Iloscpolfabrykat_tb = new System.Windows.Forms.TextBox();
            this.Kodpolfabrykatu_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PracownikZamowienie_lbl = new System.Windows.Forms.Label();
            this.Ilosc_lbl = new System.Windows.Forms.Label();
            this.Kodpolfabrykatu_lbl = new System.Windows.Forms.Label();
            this.outWarehouseGb = new System.Windows.Forms.GroupBox();
            this.Pracownikkontrolaproduktu_tb = new System.Windows.Forms.TextBox();
            this.Przekazanedoprodukcji_tb = new System.Windows.Forms.TextBox();
            this.Iloscprodukt_tb = new System.Windows.Forms.TextBox();
            this.Kodproduktu_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Kodproduktu_lbl = new System.Windows.Forms.Label();
            this.entranceWarehouseGb.SuspendLayout();
            this.outWarehouseGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // entranceWarehouseBtn
            // 
            this.entranceWarehouseBtn.Location = new System.Drawing.Point(42, 60);
            this.entranceWarehouseBtn.Name = "entranceWarehouseBtn";
            this.entranceWarehouseBtn.Size = new System.Drawing.Size(155, 43);
            this.entranceWarehouseBtn.TabIndex = 0;
            this.entranceWarehouseBtn.Text = "Magazyn wejściowy";
            this.entranceWarehouseBtn.UseVisualStyleBackColor = true;
            this.entranceWarehouseBtn.Click += new System.EventHandler(this.entranceWarehouseBtn_Click);
            // 
            // outWarehouseBtn
            // 
            this.outWarehouseBtn.Location = new System.Drawing.Point(42, 149);
            this.outWarehouseBtn.Name = "outWarehouseBtn";
            this.outWarehouseBtn.Size = new System.Drawing.Size(155, 37);
            this.outWarehouseBtn.TabIndex = 1;
            this.outWarehouseBtn.Text = "Magazyn wyjściowy";
            this.outWarehouseBtn.UseVisualStyleBackColor = true;
            this.outWarehouseBtn.Click += new System.EventHandler(this.outWarehouseBtn_Click);
            // 
            // entranceWarehouseGb
            // 
            this.entranceWarehouseGb.Controls.Add(this.Pracownikkontrola_tb);
            this.entranceWarehouseGb.Controls.Add(this.Pracownikzamowienie_tb);
            this.entranceWarehouseGb.Controls.Add(this.Iloscpolfabrykat_tb);
            this.entranceWarehouseGb.Controls.Add(this.Kodpolfabrykatu_tb);
            this.entranceWarehouseGb.Controls.Add(this.label1);
            this.entranceWarehouseGb.Controls.Add(this.PracownikZamowienie_lbl);
            this.entranceWarehouseGb.Controls.Add(this.Ilosc_lbl);
            this.entranceWarehouseGb.Controls.Add(this.Kodpolfabrykatu_lbl);
            this.entranceWarehouseGb.Location = new System.Drawing.Point(233, 49);
            this.entranceWarehouseGb.Name = "entranceWarehouseGb";
            this.entranceWarehouseGb.Size = new System.Drawing.Size(540, 249);
            this.entranceWarehouseGb.TabIndex = 2;
            this.entranceWarehouseGb.TabStop = false;
            this.entranceWarehouseGb.Text = "Magazynwejsciowy";
            this.entranceWarehouseGb.Visible = false;
            // 
            // Pracownikkontrola_tb
            // 
            this.Pracownikkontrola_tb.Location = new System.Drawing.Point(314, 198);
            this.Pracownikkontrola_tb.Name = "Pracownikkontrola_tb";
            this.Pracownikkontrola_tb.Size = new System.Drawing.Size(220, 22);
            this.Pracownikkontrola_tb.TabIndex = 7;
            // 
            // Pracownikzamowienie_tb
            // 
            this.Pracownikzamowienie_tb.Location = new System.Drawing.Point(314, 160);
            this.Pracownikzamowienie_tb.Name = "Pracownikzamowienie_tb";
            this.Pracownikzamowienie_tb.Size = new System.Drawing.Size(220, 22);
            this.Pracownikzamowienie_tb.TabIndex = 6;
            // 
            // Iloscpolfabrykat_tb
            // 
            this.Iloscpolfabrykat_tb.Location = new System.Drawing.Point(314, 115);
            this.Iloscpolfabrykat_tb.Name = "Iloscpolfabrykat_tb";
            this.Iloscpolfabrykat_tb.Size = new System.Drawing.Size(220, 22);
            this.Iloscpolfabrykat_tb.TabIndex = 5;
            // 
            // Kodpolfabrykatu_tb
            // 
            this.Kodpolfabrykatu_tb.Location = new System.Drawing.Point(314, 66);
            this.Kodpolfabrykatu_tb.Name = "Kodpolfabrykatu_tb";
            this.Kodpolfabrykatu_tb.Size = new System.Drawing.Size(220, 22);
            this.Kodpolfabrykatu_tb.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pracownik odpowiedzialny kontrolę jakości";
            // 
            // PracownikZamowienie_lbl
            // 
            this.PracownikZamowienie_lbl.AutoSize = true;
            this.PracownikZamowienie_lbl.Location = new System.Drawing.Point(6, 165);
            this.PracownikZamowienie_lbl.Name = "PracownikZamowienie_lbl";
            this.PracownikZamowienie_lbl.Size = new System.Drawing.Size(268, 17);
            this.PracownikZamowienie_lbl.TabIndex = 2;
            this.PracownikZamowienie_lbl.Text = "Pracownik odpowiedzialny za zamówienie";
            // 
            // Ilosc_lbl
            // 
            this.Ilosc_lbl.AutoSize = true;
            this.Ilosc_lbl.Location = new System.Drawing.Point(7, 120);
            this.Ilosc_lbl.Name = "Ilosc_lbl";
            this.Ilosc_lbl.Size = new System.Drawing.Size(40, 17);
            this.Ilosc_lbl.TabIndex = 1;
            this.Ilosc_lbl.Text = "Ilość ";
            // 
            // Kodpolfabrykatu_lbl
            // 
            this.Kodpolfabrykatu_lbl.AutoSize = true;
            this.Kodpolfabrykatu_lbl.Location = new System.Drawing.Point(6, 71);
            this.Kodpolfabrykatu_lbl.Name = "Kodpolfabrykatu_lbl";
            this.Kodpolfabrykatu_lbl.Size = new System.Drawing.Size(115, 17);
            this.Kodpolfabrykatu_lbl.TabIndex = 0;
            this.Kodpolfabrykatu_lbl.Text = "Kod półfabrykatu";
            // 
            // outWarehouseGb
            // 
            this.outWarehouseGb.Controls.Add(this.Pracownikkontrolaproduktu_tb);
            this.outWarehouseGb.Controls.Add(this.Przekazanedoprodukcji_tb);
            this.outWarehouseGb.Controls.Add(this.Iloscprodukt_tb);
            this.outWarehouseGb.Controls.Add(this.Kodproduktu_tb);
            this.outWarehouseGb.Controls.Add(this.label2);
            this.outWarehouseGb.Controls.Add(this.label3);
            this.outWarehouseGb.Controls.Add(this.label4);
            this.outWarehouseGb.Controls.Add(this.Kodproduktu_lbl);
            this.outWarehouseGb.Location = new System.Drawing.Point(236, 304);
            this.outWarehouseGb.Name = "outWarehouseGb";
            this.outWarehouseGb.Size = new System.Drawing.Size(540, 249);
            this.outWarehouseGb.TabIndex = 8;
            this.outWarehouseGb.TabStop = false;
            this.outWarehouseGb.Text = "Magazynwyjsciowy";
            this.outWarehouseGb.Visible = false;
            // 
            // Pracownikkontrolaproduktu_tb
            // 
            this.Pracownikkontrolaproduktu_tb.Location = new System.Drawing.Point(314, 198);
            this.Pracownikkontrolaproduktu_tb.Name = "Pracownikkontrolaproduktu_tb";
            this.Pracownikkontrolaproduktu_tb.Size = new System.Drawing.Size(220, 22);
            this.Pracownikkontrolaproduktu_tb.TabIndex = 7;
            // 
            // Przekazanedoprodukcji_tb
            // 
            this.Przekazanedoprodukcji_tb.Location = new System.Drawing.Point(314, 160);
            this.Przekazanedoprodukcji_tb.Name = "Przekazanedoprodukcji_tb";
            this.Przekazanedoprodukcji_tb.Size = new System.Drawing.Size(220, 22);
            this.Przekazanedoprodukcji_tb.TabIndex = 6;
            // 
            // Iloscprodukt_tb
            // 
            this.Iloscprodukt_tb.Location = new System.Drawing.Point(314, 115);
            this.Iloscprodukt_tb.Name = "Iloscprodukt_tb";
            this.Iloscprodukt_tb.Size = new System.Drawing.Size(220, 22);
            this.Iloscprodukt_tb.TabIndex = 5;
            // 
            // Kodproduktu_tb
            // 
            this.Kodproduktu_tb.Location = new System.Drawing.Point(314, 66);
            this.Kodproduktu_tb.Name = "Kodproduktu_tb";
            this.Kodproduktu_tb.Size = new System.Drawing.Size(220, 22);
            this.Kodproduktu_tb.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pracownik odpowiedzialny kontrolę jakości";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Czy przekazane do klienta?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ilość ";
            // 
            // Kodproduktu_lbl
            // 
            this.Kodproduktu_lbl.AutoSize = true;
            this.Kodproduktu_lbl.Location = new System.Drawing.Point(6, 71);
            this.Kodproduktu_lbl.Name = "Kodproduktu_lbl";
            this.Kodproduktu_lbl.Size = new System.Drawing.Size(93, 17);
            this.Kodproduktu_lbl.TabIndex = 0;
            this.Kodproduktu_lbl.Text = "Kod produktu";
            // 
            // WarehouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 578);
            this.Controls.Add(this.outWarehouseGb);
            this.Controls.Add(this.entranceWarehouseGb);
            this.Controls.Add(this.outWarehouseBtn);
            this.Controls.Add(this.entranceWarehouseBtn);
            this.Name = "WarehouseForm";
            this.Text = "WarehouseForm";
            this.entranceWarehouseGb.ResumeLayout(false);
            this.entranceWarehouseGb.PerformLayout();
            this.outWarehouseGb.ResumeLayout(false);
            this.outWarehouseGb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button entranceWarehouseBtn;
        private System.Windows.Forms.Button outWarehouseBtn;
        private System.Windows.Forms.GroupBox entranceWarehouseGb;
        private System.Windows.Forms.Label Ilosc_lbl;
        private System.Windows.Forms.Label Kodpolfabrykatu_lbl;
        private System.Windows.Forms.TextBox Pracownikkontrola_tb;
        private System.Windows.Forms.TextBox Pracownikzamowienie_tb;
        private System.Windows.Forms.TextBox Iloscpolfabrykat_tb;
        private System.Windows.Forms.TextBox Kodpolfabrykatu_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PracownikZamowienie_lbl;
        private System.Windows.Forms.GroupBox outWarehouseGb;
        private System.Windows.Forms.TextBox Pracownikkontrolaproduktu_tb;
        private System.Windows.Forms.TextBox Przekazanedoprodukcji_tb;
        private System.Windows.Forms.TextBox Iloscprodukt_tb;
        private System.Windows.Forms.TextBox Kodproduktu_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Kodproduktu_lbl;
    }
}