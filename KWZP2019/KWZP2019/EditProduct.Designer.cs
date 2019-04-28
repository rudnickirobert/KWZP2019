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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Produktu";
            // 
            // tBNumberProd
            // 
            this.tBNumberProd.Location = new System.Drawing.Point(401, 14);
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
            // EditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btEditBack);
            this.Controls.Add(this.btEditConfirm);
            this.Controls.Add(this.tBNumberProd);
            this.Controls.Add(this.label1);
            this.Name = "EditProduct";
            this.Text = "EditProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBNumberProd;
        private System.Windows.Forms.Button btEditConfirm;
        private System.Windows.Forms.Button btEditBack;
    }
}