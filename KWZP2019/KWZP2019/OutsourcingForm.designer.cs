namespace KWZP2019
{
    partial class OutsourcingForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Reklama_rb = new System.Windows.Forms.RadioButton();
            this.Odpady_rb = new System.Windows.Forms.RadioButton();
            this.Transportdoklienta_rb = new System.Windows.Forms.RadioButton();
            this.Nazwatransport_lbl = new System.Windows.Forms.Label();
            this.Nazwaodpady_lbl = new System.Windows.Forms.Label();
            this.Nazwareklama_lbl = new System.Windows.Forms.Label();
            this.Nazwatransport_tb = new System.Windows.Forms.TextBox();
            this.Nazwaodpady_tb = new System.Windows.Forms.TextBox();
            this.Nazwareklama_tb = new System.Windows.Forms.TextBox();
            this.Szczegolytransport_lbl = new System.Windows.Forms.Label();
            this.Szczegolyodpady_lbl = new System.Windows.Forms.Label();
            this.Szczegolyreklama_lbl = new System.Windows.Forms.Label();
            this.Szczegolytransport_lv = new System.Windows.Forms.ListView();
            this.Szczegolyodpady_lv = new System.Windows.Forms.ListView();
            this.Szczegolyreklama_lv = new System.Windows.Forms.ListView();
            this.Dodajfirmeoutsourcingowa_btn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Reklama_rb);
            this.groupBox1.Controls.Add(this.Odpady_rb);
            this.groupBox1.Controls.Add(this.Transportdoklienta_rb);
            this.groupBox1.Location = new System.Drawing.Point(49, 389);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Typ firmy outsourcingowej";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Reklama_rb
            // 
            this.Reklama_rb.AutoSize = true;
            this.Reklama_rb.Location = new System.Drawing.Point(21, 125);
            this.Reklama_rb.Name = "Reklama_rb";
            this.Reklama_rb.Size = new System.Drawing.Size(79, 21);
            this.Reklama_rb.TabIndex = 2;
            this.Reklama_rb.TabStop = true;
            this.Reklama_rb.Text = "reklama";
            this.Reklama_rb.UseVisualStyleBackColor = true;
            this.Reklama_rb.CheckedChanged += new System.EventHandler(this.Reklama_rb_CheckedChanged);
            // 
            // Odpady_rb
            // 
            this.Odpady_rb.AutoSize = true;
            this.Odpady_rb.Location = new System.Drawing.Point(21, 82);
            this.Odpady_rb.Name = "Odpady_rb";
            this.Odpady_rb.Size = new System.Drawing.Size(76, 21);
            this.Odpady_rb.TabIndex = 1;
            this.Odpady_rb.TabStop = true;
            this.Odpady_rb.Text = "odpady";
            this.Odpady_rb.UseVisualStyleBackColor = true;
            this.Odpady_rb.CheckedChanged += new System.EventHandler(this.Odpady_rb_CheckedChanged);
            // 
            // Transportdoklienta_rb
            // 
            this.Transportdoklienta_rb.AutoSize = true;
            this.Transportdoklienta_rb.Location = new System.Drawing.Point(21, 45);
            this.Transportdoklienta_rb.Name = "Transportdoklienta_rb";
            this.Transportdoklienta_rb.Size = new System.Drawing.Size(151, 21);
            this.Transportdoklienta_rb.TabIndex = 0;
            this.Transportdoklienta_rb.TabStop = true;
            this.Transportdoklienta_rb.Text = "transport do klienta";
            this.Transportdoklienta_rb.UseVisualStyleBackColor = true;
            this.Transportdoklienta_rb.CheckedChanged += new System.EventHandler(this.Transportdoklienta_rb_CheckedChanged);
            // 
            // Nazwatransport_lbl
            // 
            this.Nazwatransport_lbl.AutoSize = true;
            this.Nazwatransport_lbl.Location = new System.Drawing.Point(259, 434);
            this.Nazwatransport_lbl.Name = "Nazwatransport_lbl";
            this.Nazwatransport_lbl.Size = new System.Drawing.Size(50, 17);
            this.Nazwatransport_lbl.TabIndex = 1;
            this.Nazwatransport_lbl.Text = "Nazwa";
            this.Nazwatransport_lbl.Visible = false;
            // 
            // Nazwaodpady_lbl
            // 
            this.Nazwaodpady_lbl.AutoSize = true;
            this.Nazwaodpady_lbl.Location = new System.Drawing.Point(259, 475);
            this.Nazwaodpady_lbl.Name = "Nazwaodpady_lbl";
            this.Nazwaodpady_lbl.Size = new System.Drawing.Size(50, 17);
            this.Nazwaodpady_lbl.TabIndex = 2;
            this.Nazwaodpady_lbl.Text = "Nazwa";
            this.Nazwaodpady_lbl.Visible = false;
            // 
            // Nazwareklama_lbl
            // 
            this.Nazwareklama_lbl.AutoSize = true;
            this.Nazwareklama_lbl.Location = new System.Drawing.Point(259, 518);
            this.Nazwareklama_lbl.Name = "Nazwareklama_lbl";
            this.Nazwareklama_lbl.Size = new System.Drawing.Size(50, 17);
            this.Nazwareklama_lbl.TabIndex = 3;
            this.Nazwareklama_lbl.Text = "Nazwa";
            this.Nazwareklama_lbl.Visible = false;
            // 
            // Nazwatransport_tb
            // 
            this.Nazwatransport_tb.Location = new System.Drawing.Point(346, 429);
            this.Nazwatransport_tb.Name = "Nazwatransport_tb";
            this.Nazwatransport_tb.Size = new System.Drawing.Size(151, 22);
            this.Nazwatransport_tb.TabIndex = 4;
            this.Nazwatransport_tb.Visible = false;
            // 
            // Nazwaodpady_tb
            // 
            this.Nazwaodpady_tb.Location = new System.Drawing.Point(346, 470);
            this.Nazwaodpady_tb.Name = "Nazwaodpady_tb";
            this.Nazwaodpady_tb.Size = new System.Drawing.Size(151, 22);
            this.Nazwaodpady_tb.TabIndex = 5;
            this.Nazwaodpady_tb.Visible = false;
            // 
            // Nazwareklama_tb
            // 
            this.Nazwareklama_tb.Location = new System.Drawing.Point(346, 515);
            this.Nazwareklama_tb.Name = "Nazwareklama_tb";
            this.Nazwareklama_tb.Size = new System.Drawing.Size(151, 22);
            this.Nazwareklama_tb.TabIndex = 6;
            this.Nazwareklama_tb.Visible = false;
            // 
            // Szczegolytransport_lbl
            // 
            this.Szczegolytransport_lbl.AutoSize = true;
            this.Szczegolytransport_lbl.Location = new System.Drawing.Point(519, 432);
            this.Szczegolytransport_lbl.Name = "Szczegolytransport_lbl";
            this.Szczegolytransport_lbl.Size = new System.Drawing.Size(72, 17);
            this.Szczegolytransport_lbl.TabIndex = 7;
            this.Szczegolytransport_lbl.Text = "Szczegóły";
            this.Szczegolytransport_lbl.Visible = false;
            // 
            // Szczegolyodpady_lbl
            // 
            this.Szczegolyodpady_lbl.AutoSize = true;
            this.Szczegolyodpady_lbl.Location = new System.Drawing.Point(519, 475);
            this.Szczegolyodpady_lbl.Name = "Szczegolyodpady_lbl";
            this.Szczegolyodpady_lbl.Size = new System.Drawing.Size(72, 17);
            this.Szczegolyodpady_lbl.TabIndex = 8;
            this.Szczegolyodpady_lbl.Text = "Szczegóły";
            this.Szczegolyodpady_lbl.Visible = false;
            // 
            // Szczegolyreklama_lbl
            // 
            this.Szczegolyreklama_lbl.AutoSize = true;
            this.Szczegolyreklama_lbl.Location = new System.Drawing.Point(519, 520);
            this.Szczegolyreklama_lbl.Name = "Szczegolyreklama_lbl";
            this.Szczegolyreklama_lbl.Size = new System.Drawing.Size(72, 17);
            this.Szczegolyreklama_lbl.TabIndex = 9;
            this.Szczegolyreklama_lbl.Text = "Szczegóły";
            this.Szczegolyreklama_lbl.Visible = false;
            // 
            // Szczegolytransport_lv
            // 
            this.Szczegolytransport_lv.Location = new System.Drawing.Point(607, 422);
            this.Szczegolytransport_lv.Name = "Szczegolytransport_lv";
            this.Szczegolytransport_lv.Size = new System.Drawing.Size(155, 29);
            this.Szczegolytransport_lv.TabIndex = 10;
            this.Szczegolytransport_lv.UseCompatibleStateImageBehavior = false;
            this.Szczegolytransport_lv.Visible = false;
            // 
            // Szczegolyodpady_lv
            // 
            this.Szczegolyodpady_lv.Location = new System.Drawing.Point(607, 470);
            this.Szczegolyodpady_lv.Name = "Szczegolyodpady_lv";
            this.Szczegolyodpady_lv.Size = new System.Drawing.Size(155, 29);
            this.Szczegolyodpady_lv.TabIndex = 11;
            this.Szczegolyodpady_lv.UseCompatibleStateImageBehavior = false;
            this.Szczegolyodpady_lv.Visible = false;
            // 
            // Szczegolyreklama_lv
            // 
            this.Szczegolyreklama_lv.Location = new System.Drawing.Point(607, 520);
            this.Szczegolyreklama_lv.Name = "Szczegolyreklama_lv";
            this.Szczegolyreklama_lv.Size = new System.Drawing.Size(155, 29);
            this.Szczegolyreklama_lv.TabIndex = 12;
            this.Szczegolyreklama_lv.UseCompatibleStateImageBehavior = false;
            this.Szczegolyreklama_lv.Visible = false;
            // 
            // Dodajfirmeoutsourcingowa_btn
            // 
            this.Dodajfirmeoutsourcingowa_btn.Location = new System.Drawing.Point(51, 268);
            this.Dodajfirmeoutsourcingowa_btn.Name = "Dodajfirmeoutsourcingowa_btn";
            this.Dodajfirmeoutsourcingowa_btn.Size = new System.Drawing.Size(148, 64);
            this.Dodajfirmeoutsourcingowa_btn.TabIndex = 13;
            this.Dodajfirmeoutsourcingowa_btn.Text = "Dodaj firmę outsourcingową";
            this.Dodajfirmeoutsourcingowa_btn.UseVisualStyleBackColor = true;
            this.Dodajfirmeoutsourcingowa_btn.Click += new System.EventHandler(this.Dodajfirmeoutsourcingowa_btn_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(51, 62);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(827, 157);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // OutsourcingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 594);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Dodajfirmeoutsourcingowa_btn);
            this.Controls.Add(this.Szczegolyreklama_lv);
            this.Controls.Add(this.Szczegolyodpady_lv);
            this.Controls.Add(this.Szczegolytransport_lv);
            this.Controls.Add(this.Szczegolyreklama_lbl);
            this.Controls.Add(this.Szczegolyodpady_lbl);
            this.Controls.Add(this.Szczegolytransport_lbl);
            this.Controls.Add(this.Nazwareklama_tb);
            this.Controls.Add(this.Nazwaodpady_tb);
            this.Controls.Add(this.Nazwatransport_tb);
            this.Controls.Add(this.Nazwareklama_lbl);
            this.Controls.Add(this.Nazwaodpady_lbl);
            this.Controls.Add(this.Nazwatransport_lbl);
            this.Controls.Add(this.groupBox1);
            this.Name = "OutsourcingForm";
            this.Text = "OutsourcingForm";
            this.Load += new System.EventHandler(this.OutsourcingForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Reklama_rb;
        private System.Windows.Forms.RadioButton Odpady_rb;
        private System.Windows.Forms.RadioButton Transportdoklienta_rb;
        private System.Windows.Forms.Label Nazwatransport_lbl;
        private System.Windows.Forms.Label Nazwaodpady_lbl;
        private System.Windows.Forms.Label Nazwareklama_lbl;
        private System.Windows.Forms.TextBox Nazwatransport_tb;
        private System.Windows.Forms.TextBox Nazwaodpady_tb;
        private System.Windows.Forms.TextBox Nazwareklama_tb;
        private System.Windows.Forms.Label Szczegolytransport_lbl;
        private System.Windows.Forms.Label Szczegolyodpady_lbl;
        private System.Windows.Forms.Label Szczegolyreklama_lbl;
        private System.Windows.Forms.ListView Szczegolytransport_lv;
        private System.Windows.Forms.ListView Szczegolyodpady_lv;
        private System.Windows.Forms.ListView Szczegolyreklama_lv;
        private System.Windows.Forms.Button Dodajfirmeoutsourcingowa_btn;
        private System.Windows.Forms.ListView listView1;
    }
}