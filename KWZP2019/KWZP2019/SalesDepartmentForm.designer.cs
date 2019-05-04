﻿namespace KWZP2019
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesDepartmentForm));
            this.customerBtn = new System.Windows.Forms.Button();
            this.orderBtn = new System.Windows.Forms.Button();
            this.warehouseBtn = new System.Windows.Forms.Button();
            this.suppliersBtn = new System.Windows.Forms.Button();
            this.outsourcingBtn = new System.Windows.Forms.Button();
            this.returnToMainBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customerBtn
            // 
            this.customerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.customerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.customerBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.customerBtn.Image = ((System.Drawing.Image)(resources.GetObject("customerBtn.Image")));
            this.customerBtn.Location = new System.Drawing.Point(454, 161);
            this.customerBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customerBtn.Name = "customerBtn";
            this.customerBtn.Size = new System.Drawing.Size(294, 160);
            this.customerBtn.TabIndex = 0;
            this.customerBtn.Text = "Klient";
            this.customerBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.customerBtn.UseVisualStyleBackColor = false;
            this.customerBtn.Click += new System.EventHandler(this.customerBtn_Click);
            // 
            // orderBtn
            // 
            this.orderBtn.Location = new System.Drawing.Point(1218, 875);
            this.orderBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(125, 25);
            this.orderBtn.TabIndex = 1;
            this.orderBtn.Text = "Zamówienie";
            this.orderBtn.UseVisualStyleBackColor = true;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // warehouseBtn
            // 
            this.warehouseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.warehouseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.warehouseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.warehouseBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.warehouseBtn.Image = ((System.Drawing.Image)(resources.GetObject("warehouseBtn.Image")));
            this.warehouseBtn.Location = new System.Drawing.Point(853, 161);
            this.warehouseBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.warehouseBtn.Name = "warehouseBtn";
            this.warehouseBtn.Size = new System.Drawing.Size(294, 160);
            this.warehouseBtn.TabIndex = 2;
            this.warehouseBtn.Text = "Magazyn";
            this.warehouseBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.warehouseBtn.UseVisualStyleBackColor = false;
            this.warehouseBtn.Click += new System.EventHandler(this.warehouseBtn_Click);
            // 
            // suppliersBtn
            // 
            this.suppliersBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.suppliersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.suppliersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.suppliersBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.suppliersBtn.Image = ((System.Drawing.Image)(resources.GetObject("suppliersBtn.Image")));
            this.suppliersBtn.Location = new System.Drawing.Point(698, 429);
            this.suppliersBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.suppliersBtn.Name = "suppliersBtn";
            this.suppliersBtn.Size = new System.Drawing.Size(294, 160);
            this.suppliersBtn.TabIndex = 3;
            this.suppliersBtn.Text = "Dostawcy";
            this.suppliersBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.suppliersBtn.UseVisualStyleBackColor = false;
            this.suppliersBtn.Click += new System.EventHandler(this.suppliersBtn_Click);
            // 
            // outsourcingBtn
            // 
            this.outsourcingBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.outsourcingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outsourcingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.outsourcingBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.outsourcingBtn.Image = ((System.Drawing.Image)(resources.GetObject("outsourcingBtn.Image")));
            this.outsourcingBtn.Location = new System.Drawing.Point(219, 429);
            this.outsourcingBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.outsourcingBtn.Name = "outsourcingBtn";
            this.outsourcingBtn.Size = new System.Drawing.Size(294, 160);
            this.outsourcingBtn.TabIndex = 4;
            this.outsourcingBtn.Text = "Outsourcing";
            this.outsourcingBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.outsourcingBtn.UseVisualStyleBackColor = false;
            this.outsourcingBtn.Click += new System.EventHandler(this.outsourcingBtn_Click);
            // 
            // returnToMainBtn
            // 
            this.returnToMainBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.returnToMainBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.returnToMainBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnToMainBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.returnToMainBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.returnToMainBtn.Image = ((System.Drawing.Image)(resources.GetObject("returnToMainBtn.Image")));
            this.returnToMainBtn.Location = new System.Drawing.Point(30, 161);
            this.returnToMainBtn.Margin = new System.Windows.Forms.Padding(4);
            this.returnToMainBtn.Name = "returnToMainBtn";
            this.returnToMainBtn.Size = new System.Drawing.Size(294, 160);
            this.returnToMainBtn.TabIndex = 5;
            this.returnToMainBtn.Text = "Powrót do Menu";
            this.returnToMainBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.returnToMainBtn.UseVisualStyleBackColor = false;
            this.returnToMainBtn.Click += new System.EventHandler(this.returnToMainBtn_Click);
            // 
            // SalesDepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.returnToMainBtn);
            this.Controls.Add(this.outsourcingBtn);
            this.Controls.Add(this.suppliersBtn);
            this.Controls.Add(this.warehouseBtn);
            this.Controls.Add(this.orderBtn);
            this.Controls.Add(this.customerBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SalesDepartmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Handlowy";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button customerBtn;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.Button warehouseBtn;
        private System.Windows.Forms.Button suppliersBtn;
        private System.Windows.Forms.Button outsourcingBtn;
        private System.Windows.Forms.Button returnToMainBtn;
    }
}