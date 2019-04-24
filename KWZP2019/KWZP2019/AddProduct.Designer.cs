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
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btCloseAddProduct);
            this.Controls.Add(this.btAddConfirm);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAddConfirm;
        private System.Windows.Forms.Button btCloseAddProduct;
    }
}