﻿namespace KWZP2019
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
            System.Windows.Forms.ComboBox cBSemiFinished;
            System.Windows.Forms.ComboBox cBTechnology;
            this.btAddConfirm = new System.Windows.Forms.Button();
            this.btCloseAddProduct = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            cBSemiFinished = new System.Windows.Forms.ComboBox();
            cBTechnology = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cBSemiFinished
            // 
            cBSemiFinished.FormattingEnabled = true;
            cBSemiFinished.Location = new System.Drawing.Point(310, 123);
            cBSemiFinished.Name = "cBSemiFinished";
            cBSemiFinished.Size = new System.Drawing.Size(215, 21);
            cBSemiFinished.TabIndex = 2;
            // 
            // btAddConfirm
            // 
            this.btAddConfirm.Location = new System.Drawing.Point(283, 20);
            this.btAddConfirm.Name = "btAddConfirm";
            this.btAddConfirm.Size = new System.Drawing.Size(100, 34);
            this.btAddConfirm.TabIndex = 0;
            this.btAddConfirm.Text = "Dodaj";
            this.btAddConfirm.UseVisualStyleBackColor = true;
            this.btAddConfirm.Click += new System.EventHandler(this.btAddConfirm_Click);
            // 
            // btCloseAddProduct
            // 
            this.btCloseAddProduct.Location = new System.Drawing.Point(427, 23);
            this.btCloseAddProduct.Name = "btCloseAddProduct";
            this.btCloseAddProduct.Size = new System.Drawing.Size(113, 30);
            this.btCloseAddProduct.TabIndex = 1;
            this.btCloseAddProduct.Text = "Powrót";
            this.btCloseAddProduct.UseVisualStyleBackColor = true;
            this.btCloseAddProduct.Click += new System.EventHandler(this.btCloseAddProduct_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(310, 159);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pólfabrykat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kod Produktu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Technologia";
            // 
            // cBTechnology
            // 
            cBTechnology.FormattingEnabled = true;
            cBTechnology.Location = new System.Drawing.Point(310, 193);
            cBTechnology.Name = "cBTechnology";
            cBTechnology.Size = new System.Drawing.Size(215, 21);
            cBTechnology.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(310, 229);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(215, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data dodania";
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(cBTechnology);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(cBSemiFinished);
            this.Controls.Add(this.btCloseAddProduct);
            this.Controls.Add(this.btAddConfirm);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAddConfirm;
        private System.Windows.Forms.Button btCloseAddProduct;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
    }
}