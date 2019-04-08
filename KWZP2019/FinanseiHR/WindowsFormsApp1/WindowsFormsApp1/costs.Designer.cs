namespace WindowsFormsApp1
{
    partial class costs
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
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lista_rozwijana_działów = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(143, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(250, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Wybierz dział (lub całe przedsiębiorstwo) oraz datę:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(478, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Zatwierdź wybór";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lista_rozwijana_działów
            // 
            this.lista_rozwijana_działów.FormattingEnabled = true;
            this.lista_rozwijana_działów.Location = new System.Drawing.Point(212, 25);
            this.lista_rozwijana_działów.Name = "lista_rozwijana_działów";
            this.lista_rozwijana_działów.Size = new System.Drawing.Size(120, 17);
            this.lista_rozwijana_działów.TabIndex = 23;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(174, 48);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Zsumowane koszta dla danego podmiotu:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(231, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 20);
            this.textBox1.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(478, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Dodaj fakturę";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(24, 259);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(478, 50);
            this.button4.TabIndex = 29;
            this.button4.Text = "Generuj raport szczegółowy";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(24, 203);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(478, 50);
            this.button3.TabIndex = 30;
            this.button3.Text = "Generuj raport ogólny";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 331);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lista_rozwijana_działów);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label11);
            this.Name = "Form4";
            this.Text = "Koszty";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lista_rozwijana_działów;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}