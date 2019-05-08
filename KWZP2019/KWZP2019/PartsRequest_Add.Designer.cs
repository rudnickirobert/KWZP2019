namespace KWZP2019
{
    partial class PartsRequest_Add
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
            this.btnRequestAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbRequestAdd_Name = new System.Windows.Forms.ComboBox();
            this.lbRequestAdd_Name = new System.Windows.Forms.Label();
            this.tbRequestAdd_Amount = new System.Windows.Forms.TextBox();
            this.lbRequestAdd_Date = new System.Windows.Forms.Label();
            this.lbRequestAdd_Amount = new System.Windows.Forms.Label();
            this.dtpRequestAdd_Date = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRequestAdd
            // 
            this.btnRequestAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnRequestAdd.FlatAppearance.BorderSize = 0;
            this.btnRequestAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRequestAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRequestAdd.ForeColor = System.Drawing.Color.White;
            this.btnRequestAdd.Location = new System.Drawing.Point(56, 197);
            this.btnRequestAdd.Name = "btnRequestAdd";
            this.btnRequestAdd.Size = new System.Drawing.Size(340, 44);
            this.btnRequestAdd.TabIndex = 54;
            this.btnRequestAdd.Text = "Dodaj nowe zapotrzebowanie";
            this.btnRequestAdd.UseVisualStyleBackColor = false;
            this.btnRequestAdd.Click += new System.EventHandler(this.btnRequestAdd_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.panel1.BackgroundImage = global::KWZP2019.Properties.Resources._53062472_302328053765523_8291849142804676608_n;
            this.panel1.Controls.Add(this.cbRequestAdd_Name);
            this.panel1.Controls.Add(this.lbRequestAdd_Name);
            this.panel1.Controls.Add(this.tbRequestAdd_Amount);
            this.panel1.Controls.Add(this.lbRequestAdd_Date);
            this.panel1.Controls.Add(this.lbRequestAdd_Amount);
            this.panel1.Controls.Add(this.dtpRequestAdd_Date);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 185);
            this.panel1.TabIndex = 53;
            // 
            // cbRequestAdd_Name
            // 
            this.cbRequestAdd_Name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbRequestAdd_Name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbRequestAdd_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbRequestAdd_Name.FormattingEnabled = true;
            this.cbRequestAdd_Name.Location = new System.Drawing.Point(198, 15);
            this.cbRequestAdd_Name.Name = "cbRequestAdd_Name";
            this.cbRequestAdd_Name.Size = new System.Drawing.Size(227, 32);
            this.cbRequestAdd_Name.TabIndex = 52;
            // 
            // lbRequestAdd_Name
            // 
            this.lbRequestAdd_Name.AutoSize = true;
            this.lbRequestAdd_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbRequestAdd_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbRequestAdd_Name.ForeColor = System.Drawing.Color.White;
            this.lbRequestAdd_Name.Location = new System.Drawing.Point(34, 21);
            this.lbRequestAdd_Name.Name = "lbRequestAdd_Name";
            this.lbRequestAdd_Name.Size = new System.Drawing.Size(119, 22);
            this.lbRequestAdd_Name.TabIndex = 48;
            this.lbRequestAdd_Name.Text = "Nazwa części";
            // 
            // tbRequestAdd_Amount
            // 
            this.tbRequestAdd_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbRequestAdd_Amount.Location = new System.Drawing.Point(198, 114);
            this.tbRequestAdd_Amount.Name = "tbRequestAdd_Amount";
            this.tbRequestAdd_Amount.Size = new System.Drawing.Size(227, 29);
            this.tbRequestAdd_Amount.TabIndex = 49;
            this.tbRequestAdd_Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbRequestAdd_Amount.TextChanged += new System.EventHandler(this.tbRequestAdd_Amount_TextChanged);
            // 
            // lbRequestAdd_Date
            // 
            this.lbRequestAdd_Date.AutoSize = true;
            this.lbRequestAdd_Date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbRequestAdd_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbRequestAdd_Date.ForeColor = System.Drawing.Color.White;
            this.lbRequestAdd_Date.Location = new System.Drawing.Point(23, 59);
            this.lbRequestAdd_Date.Name = "lbRequestAdd_Date";
            this.lbRequestAdd_Date.Size = new System.Drawing.Size(147, 42);
            this.lbRequestAdd_Date.TabIndex = 46;
            this.lbRequestAdd_Date.Text = "Data wysłania \r\nzapotrzebowania";
            this.lbRequestAdd_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbRequestAdd_Amount
            // 
            this.lbRequestAdd_Amount.AutoSize = true;
            this.lbRequestAdd_Amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbRequestAdd_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbRequestAdd_Amount.ForeColor = System.Drawing.Color.White;
            this.lbRequestAdd_Amount.Location = new System.Drawing.Point(12, 114);
            this.lbRequestAdd_Amount.Name = "lbRequestAdd_Amount";
            this.lbRequestAdd_Amount.Size = new System.Drawing.Size(160, 42);
            this.lbRequestAdd_Amount.TabIndex = 50;
            this.lbRequestAdd_Amount.Text = "Ilość zamawianych\r\nczęści";
            this.lbRequestAdd_Amount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpRequestAdd_Date
            // 
            this.dtpRequestAdd_Date.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpRequestAdd_Date.Enabled = false;
            this.dtpRequestAdd_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpRequestAdd_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRequestAdd_Date.Location = new System.Drawing.Point(198, 62);
            this.dtpRequestAdd_Date.Name = "dtpRequestAdd_Date";
            this.dtpRequestAdd_Date.Size = new System.Drawing.Size(227, 29);
            this.dtpRequestAdd_Date.TabIndex = 51;
            // 
            // PartsRequest_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(448, 253);
            this.Controls.Add(this.btnRequestAdd);
            this.Controls.Add(this.panel1);
            this.Name = "PartsRequest_Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nowe zapotrzebowanie";
            this.Load += new System.EventHandler(this.PartsRequest_Add_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbRequestAdd_Date;
        private System.Windows.Forms.Label lbRequestAdd_Name;
        private System.Windows.Forms.Label lbRequestAdd_Amount;
        private System.Windows.Forms.TextBox tbRequestAdd_Amount;
        private System.Windows.Forms.DateTimePicker dtpRequestAdd_Date;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRequestAdd;
        private System.Windows.Forms.ComboBox cbRequestAdd_Name;
    }
}