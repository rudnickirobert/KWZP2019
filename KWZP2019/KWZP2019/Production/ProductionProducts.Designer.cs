namespace KWZP2019
{
    partial class ProductionProducts
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
            this.components = new System.ComponentModel.Container();
            this.btAddProduct = new System.Windows.Forms.Button();
            this.btEditProduct = new System.Windows.Forms.Button();
            this.btDeleteProduct = new System.Windows.Forms.Button();
            this.btEnd = new System.Windows.Forms.Button();
            this.dataGridProducts = new System.Windows.Forms.DataGridView();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btRefresh = new System.Windows.Forms.Button();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btRefresh = new System.Windows.Forms.Button();
            this.idProductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSemiFinishedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTechnologyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btAddProduct
            // 
            this.btAddProduct.Location = new System.Drawing.Point(260, 16);
            this.btAddProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btAddProduct.Name = "btAddProduct";
            this.btAddProduct.Size = new System.Drawing.Size(143, 26);
            this.btAddProduct.TabIndex = 0;
            this.btAddProduct.Text = "Dodaj";
            this.btAddProduct.UseVisualStyleBackColor = true;
            this.btAddProduct.Click += new System.EventHandler(this.btAddProduct_Click);
            // 
            // btEditProduct
            // 
            this.btEditProduct.Location = new System.Drawing.Point(419, 15);
            this.btEditProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btEditProduct.Name = "btEditProduct";
            this.btEditProduct.Size = new System.Drawing.Size(143, 26);
            this.btEditProduct.TabIndex = 1;
            this.btEditProduct.Text = "Edytuj";
            this.btEditProduct.UseVisualStyleBackColor = true;
            this.btEditProduct.Click += new System.EventHandler(this.btEditProduct_Click);
            // 
            // btDeleteProduct
            // 
            this.btDeleteProduct.Location = new System.Drawing.Point(577, 15);
            this.btDeleteProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btDeleteProduct.Name = "btDeleteProduct";
            this.btDeleteProduct.Size = new System.Drawing.Size(143, 26);
            this.btDeleteProduct.TabIndex = 2;
            this.btDeleteProduct.Text = "Usuń";
            this.btDeleteProduct.UseVisualStyleBackColor = true;
            this.btDeleteProduct.Click += new System.EventHandler(this.btDeleteProduct_Click);
            // 
            // btEnd
            // 
            this.btEnd.Location = new System.Drawing.Point(736, 15);
            this.btEnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btEnd.Name = "btEnd";
            this.btEnd.Size = new System.Drawing.Size(143, 26);
            this.btEnd.TabIndex = 3;
            this.btEnd.Text = "Koniec";
            this.btEnd.UseVisualStyleBackColor = true;
            this.btEnd.Click += new System.EventHandler(this.btEnd_Click);
            // 
            // dataGridProducts
            // 
            this.dataGridProducts.AutoGenerateColumns = false;
            this.dataGridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProductDataGridViewTextBoxColumn,
            this.idSemiFinishedDataGridViewTextBoxColumn,
            this.productCodeDataGridViewTextBoxColumn,
            this.idTechnologyDataGridViewTextBoxColumn,
            this.inputDateDataGridViewTextBoxColumn});
            this.dataGridProducts.DataSource = this.productBindingSource;
            this.dataGridProducts.Location = new System.Drawing.Point(16, 49);
            this.dataGridProducts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridProducts.Name = "dataGridProducts";
            this.dataGridProducts.Size = new System.Drawing.Size(1035, 490);
            this.dataGridProducts.TabIndex = 4;
            this.dataGridProducts.SelectionChanged += new System.EventHandler(this.dataGridProducts_SelectionChanged);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(KWZP2019.Product);
            // 
            // btRefresh
            // 
            this.btRefresh.Location = new System.Drawing.Point(447, 13);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(112, 20);
            this.btRefresh.TabIndex = 5;
            this.btRefresh.Text = "Odśwież";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // idProductDataGridViewTextBoxColumn
            // 
            this.idProductDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idProductDataGridViewTextBoxColumn.DataPropertyName = "IdProduct";
            this.idProductDataGridViewTextBoxColumn.HeaderText = "ID Produktu";
            this.idProductDataGridViewTextBoxColumn.Name = "idProductDataGridViewTextBoxColumn";
            // 
            // idSemiFinishedDataGridViewTextBoxColumn
            // 
            this.idSemiFinishedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idSemiFinishedDataGridViewTextBoxColumn.DataPropertyName = "IdSemiFinished";
            this.idSemiFinishedDataGridViewTextBoxColumn.HeaderText = "ID Półproduktu";
            this.idSemiFinishedDataGridViewTextBoxColumn.Name = "idSemiFinishedDataGridViewTextBoxColumn";
            // 
            // productCodeDataGridViewTextBoxColumn
            // 
            this.productCodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productCodeDataGridViewTextBoxColumn.DataPropertyName = "ProductCode";
            this.productCodeDataGridViewTextBoxColumn.HeaderText = "Kod produktu";
            this.productCodeDataGridViewTextBoxColumn.Name = "productCodeDataGridViewTextBoxColumn";
            // 
            // idTechnologyDataGridViewTextBoxColumn
            // 
            this.idTechnologyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idTechnologyDataGridViewTextBoxColumn.DataPropertyName = "IdTechnology";
            this.idTechnologyDataGridViewTextBoxColumn.HeaderText = "ID Technologii";
            this.idTechnologyDataGridViewTextBoxColumn.Name = "idTechnologyDataGridViewTextBoxColumn";
            // 
            // inputDateDataGridViewTextBoxColumn
            // 
            this.inputDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.inputDateDataGridViewTextBoxColumn.DataPropertyName = "InputDate";
            this.inputDateDataGridViewTextBoxColumn.HeaderText = "Data dodania";
            this.inputDateDataGridViewTextBoxColumn.Name = "inputDateDataGridViewTextBoxColumn";
            // 
            // ProductionProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.dataGridProducts);
            this.Controls.Add(this.btEnd);
            this.Controls.Add(this.btDeleteProduct);
            this.Controls.Add(this.btEditProduct);
            this.Controls.Add(this.btAddProduct);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ProductionProducts";
            this.Text = "Produkty";
            this.Load += new System.EventHandler(this.ProductionProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAddProduct;
        private System.Windows.Forms.Button btEditProduct;
        private System.Windows.Forms.Button btDeleteProduct;
        private System.Windows.Forms.Button btEnd;
        private System.Windows.Forms.DataGridView dataGridProducts;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSemiFinishedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTechnologyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inputDateDataGridViewTextBoxColumn;
    }
}