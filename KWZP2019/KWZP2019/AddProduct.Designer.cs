namespace KWZP2019
{
    partial class AddProduct
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
            this.btAddConfirm = new System.Windows.Forms.Button();
            this.btCloseAddProduct = new System.Windows.Forms.Button();
            this.tBProductCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cBSemiFinished = new System.Windows.Forms.ComboBox();
            this.cBTechnology = new System.Windows.Forms.ComboBox();
            this.dTPAddTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btAddConfirm
            // 
            this.btAddConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btAddConfirm.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btAddConfirm.FlatAppearance.BorderSize = 3;
            this.btAddConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btAddConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btAddConfirm.ForeColor = System.Drawing.Color.White;
            this.btAddConfirm.Image = global::KWZP2019.Properties.Resources.okej;
            this.btAddConfirm.Location = new System.Drawing.Point(447, 50);
            this.btAddConfirm.Name = "btAddConfirm";
            this.btAddConfirm.Size = new System.Drawing.Size(290, 160);
            this.btAddConfirm.TabIndex = 0;
            this.btAddConfirm.Text = "Zatwierdź";
            this.btAddConfirm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btAddConfirm.UseVisualStyleBackColor = false;
            this.btAddConfirm.Click += new System.EventHandler(this.btAddConfirm_Click);
            // 
            // btCloseAddProduct
            // 
            this.btCloseAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btCloseAddProduct.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btCloseAddProduct.FlatAppearance.BorderSize = 3;
            this.btCloseAddProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btCloseAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCloseAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btCloseAddProduct.ForeColor = System.Drawing.Color.White;
            this.btCloseAddProduct.Image = global::KWZP2019.Properties.Resources.powrott;
            this.btCloseAddProduct.Location = new System.Drawing.Point(447, 230);
            this.btCloseAddProduct.Name = "btCloseAddProduct";
            this.btCloseAddProduct.Size = new System.Drawing.Size(290, 160);
            this.btCloseAddProduct.TabIndex = 1;
            this.btCloseAddProduct.Text = "Powrót";
            this.btCloseAddProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCloseAddProduct.UseVisualStyleBackColor = false;
            this.btCloseAddProduct.Click += new System.EventHandler(this.btCloseAddProduct_Click);
            // 
            // tBProductCode
            // 
            this.tBProductCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.tBProductCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tBProductCode.ForeColor = System.Drawing.SystemColors.Window;
            this.tBProductCode.Location = new System.Drawing.Point(140, 187);
            this.tBProductCode.Name = "tBProductCode";
            this.tBProductCode.Size = new System.Drawing.Size(214, 20);
            this.tBProductCode.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(140, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pólfabrykat:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(140, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kod Produktu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(140, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Technologia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(140, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data dodania:";
            // 
            // cBSemiFinished
            // 
            this.cBSemiFinished.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.cBSemiFinished.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cBSemiFinished.ForeColor = System.Drawing.SystemColors.Window;
            this.cBSemiFinished.FormattingEnabled = true;
            this.cBSemiFinished.Location = new System.Drawing.Point(140, 130);
            this.cBSemiFinished.Name = "cBSemiFinished";
            this.cBSemiFinished.Size = new System.Drawing.Size(215, 21);
            this.cBSemiFinished.TabIndex = 10;
            // 
            // cBTechnology
            // 
            this.cBTechnology.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.cBTechnology.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cBTechnology.ForeColor = System.Drawing.SystemColors.Window;
            this.cBTechnology.FormattingEnabled = true;
            this.cBTechnology.Location = new System.Drawing.Point(140, 243);
            this.cBTechnology.Name = "cBTechnology";
            this.cBTechnology.Size = new System.Drawing.Size(213, 21);
            this.cBTechnology.TabIndex = 11;
            // 
            // dTPAddTime
            // 
            this.dTPAddTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dTPAddTime.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.dTPAddTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dTPAddTime.Location = new System.Drawing.Point(140, 300);
            this.dTPAddTime.Name = "dTPAddTime";
            this.dTPAddTime.Size = new System.Drawing.Size(213, 20);
            this.dTPAddTime.TabIndex = 12;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KWZP2019.Properties.Resources._53062472_302328053765523_8291849142804676608_n;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dTPAddTime);
            this.Controls.Add(this.cBTechnology);
            this.Controls.Add(this.cBSemiFinished);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBProductCode);
            this.Controls.Add(this.btCloseAddProduct);
            this.Controls.Add(this.btAddConfirm);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAddConfirm;
        private System.Windows.Forms.Button btCloseAddProduct;
        private System.Windows.Forms.TextBox tBProductCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cBSemiFinished;
        private System.Windows.Forms.ComboBox cBTechnology;
        private System.Windows.Forms.DateTimePicker dTPAddTime;
    }
}