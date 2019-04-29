namespace KWZP2019
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
            this.label1.Location = new System.Drawing.Point(188, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Produktu";
            // 
            // tBNumberProd
            // 
            this.tBNumberProd.Location = new System.Drawing.Point(286, 70);
            this.tBNumberProd.Name = "tBNumberProd";
            this.tBNumberProd.Size = new System.Drawing.Size(62, 20);
            this.tBNumberProd.TabIndex = 1;
            // 
            // btEditConfirm
            // 
            this.btEditConfirm.Location = new System.Drawing.Point(592, 24);
            this.btEditConfirm.Name = "btEditConfirm";
            this.btEditConfirm.Size = new System.Drawing.Size(162, 36);
            this.btEditConfirm.TabIndex = 2;
            this.btEditConfirm.Text = "Zatwierdź";
            this.btEditConfirm.UseVisualStyleBackColor = true;
            this.btEditConfirm.Click += new System.EventHandler(this.btEditConfirm_Click);
            // 
            // btEditBack
            // 
            this.btEditBack.Location = new System.Drawing.Point(587, 83);
            this.btEditBack.Name = "btEditBack";
            this.btEditBack.Size = new System.Drawing.Size(166, 42);
            this.btEditBack.TabIndex = 3;
            this.btEditBack.Text = "Powrót";
            this.btEditBack.UseVisualStyleBackColor = true;
            this.btEditBack.Click += new System.EventHandler(this.btEditBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Półfabrykat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Technologia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kod produktu";
            // 
            // tBProductCode
            // 
            this.tBProductCode.Location = new System.Drawing.Point(286, 103);
            this.tBProductCode.Name = "tBProductCode";
            this.tBProductCode.Size = new System.Drawing.Size(109, 20);
            this.tBProductCode.TabIndex = 7;
            // 
            // cBEditSemiFinished
            // 
            this.cBEditSemiFinished.FormattingEnabled = true;
            this.cBEditSemiFinished.Location = new System.Drawing.Point(286, 206);
            this.cBEditSemiFinished.Name = "cBEditSemiFinished";
            this.cBEditSemiFinished.Size = new System.Drawing.Size(119, 21);
            this.cBEditSemiFinished.TabIndex = 8;
            // 
            // cBEditTechnology
            // 
            this.cBEditTechnology.FormattingEnabled = true;
            this.cBEditTechnology.Location = new System.Drawing.Point(286, 244);
            this.cBEditTechnology.Name = "cBEditTechnology";
            this.cBEditTechnology.Size = new System.Drawing.Size(119, 21);
            this.cBEditTechnology.TabIndex = 9;
            // 
            // EditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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