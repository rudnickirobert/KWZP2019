﻿namespace KWZP2019
{
    partial class EditProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.tBNumberProd = new System.Windows.Forms.TextBox();
            this.btEditConfirm = new System.Windows.Forms.Button();
            this.btEditBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tBProductCode = new System.Windows.Forms.TextBox();
            this.cBEditSemiFinished = new System.Windows.Forms.ComboBox();
            this.cBEditTechnology = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Produktu";
            // 
            // tBNumberProd
            // 
            this.tBNumberProd.Location = new System.Drawing.Point(256, 112);
            this.tBNumberProd.Name = "tBNumberProd";
            this.tBNumberProd.Size = new System.Drawing.Size(50, 20);
            this.tBNumberProd.TabIndex = 1;
            // 
            // btEditConfirm
            // 
            this.btEditConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btEditConfirm.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btEditConfirm.FlatAppearance.BorderSize = 3;
            this.btEditConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btEditConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btEditConfirm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btEditConfirm.Location = new System.Drawing.Point(478, 42);
            this.btEditConfirm.Name = "btEditConfirm";
            this.btEditConfirm.Size = new System.Drawing.Size(290, 160);
            this.btEditConfirm.TabIndex = 2;
            this.btEditConfirm.Text = "Zatwierdź";
            this.btEditConfirm.UseVisualStyleBackColor = false;
            this.btEditConfirm.Click += new System.EventHandler(this.btEditConfirm_Click);
            // 
            // btEditBack
            // 
            this.btEditBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btEditBack.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btEditBack.FlatAppearance.BorderSize = 3;
            this.btEditBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btEditBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btEditBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btEditBack.Location = new System.Drawing.Point(478, 248);
            this.btEditBack.Name = "btEditBack";
            this.btEditBack.Size = new System.Drawing.Size(290, 160);
            this.btEditBack.TabIndex = 3;
            this.btEditBack.Text = "Powrót";
            this.btEditBack.UseVisualStyleBackColor = false;
            this.btEditBack.Click += new System.EventHandler(this.btEditBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Półfabrykat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Technologia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kod produktu";
            // 
            // tBProductCode
            // 
            this.tBProductCode.Location = new System.Drawing.Point(256, 145);
            this.tBProductCode.Name = "tBProductCode";
            this.tBProductCode.Size = new System.Drawing.Size(150, 20);
            this.tBProductCode.TabIndex = 7;
            // 
            // cBEditSemiFinished
            // 
            this.cBEditSemiFinished.FormattingEnabled = true;
            this.cBEditSemiFinished.Location = new System.Drawing.Point(256, 248);
            this.cBEditSemiFinished.Name = "cBEditSemiFinished";
            this.cBEditSemiFinished.Size = new System.Drawing.Size(150, 21);
            this.cBEditSemiFinished.TabIndex = 8;
            // 
            // cBEditTechnology
            // 
            this.cBEditTechnology.FormattingEnabled = true;
            this.cBEditTechnology.Location = new System.Drawing.Point(256, 286);
            this.cBEditTechnology.Name = "cBEditTechnology";
            this.cBEditTechnology.Size = new System.Drawing.Size(150, 21);
            this.cBEditTechnology.TabIndex = 9;
            // 
            // EditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KWZP2019.Properties.Resources._53062472_302328053765523_8291849142804676608_n;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cBEditTechnology);
            this.Controls.Add(this.cBEditSemiFinished);
            this.Controls.Add(this.tBProductCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btEditBack);
            this.Controls.Add(this.btEditConfirm);
            this.Controls.Add(this.tBNumberProd);
            this.Controls.Add(this.label1);
            this.Name = "EditProduct";
            this.ShowInTaskbar = false;
            this.Text = "EditProduct";
            this.Load += new System.EventHandler(this.EditProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBNumberProd;
        private System.Windows.Forms.Button btEditConfirm;
        private System.Windows.Forms.Button btEditBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBProductCode;
        private System.Windows.Forms.ComboBox cBEditSemiFinished;
        private System.Windows.Forms.ComboBox cBEditTechnology;
    }
}