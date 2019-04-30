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
            // tBProductCode
            // 
            this.tBProductCode.Location = new System.Drawing.Point(310, 159);
            this.tBProductCode.Name = "tBProductCode";
            this.tBProductCode.Size = new System.Drawing.Size(214, 20);
            this.tBProductCode.TabIndex = 3;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data dodania";
            // 
            // cBSemiFinished
            // 
            this.cBSemiFinished.FormattingEnabled = true;
            this.cBSemiFinished.Location = new System.Drawing.Point(310, 118);
            this.cBSemiFinished.Name = "cBSemiFinished";
            this.cBSemiFinished.Size = new System.Drawing.Size(215, 21);
            this.cBSemiFinished.TabIndex = 10;
            // 
            // cBTechnology
            // 
            this.cBTechnology.FormattingEnabled = true;
            this.cBTechnology.Location = new System.Drawing.Point(310, 194);
            this.cBTechnology.Name = "cBTechnology";
            this.cBTechnology.Size = new System.Drawing.Size(213, 21);
            this.cBTechnology.TabIndex = 11;
            // 
            // dTPAddTime
            // 
            this.dTPAddTime.Location = new System.Drawing.Point(309, 227);
            this.dTPAddTime.Name = "dTPAddTime";
            this.dTPAddTime.Size = new System.Drawing.Size(213, 20);
            this.dTPAddTime.TabIndex = 12;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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