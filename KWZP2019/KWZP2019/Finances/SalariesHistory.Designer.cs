namespace KWZP2019
{
    partial class SalariesHistory
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
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.lblSurnameSearching = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHistory
            // 
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Location = new System.Drawing.Point(12, 12);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.Size = new System.Drawing.Size(776, 387);
            this.dgvHistory.TabIndex = 0;
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(121, 418);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(667, 20);
            this.tbSurname.TabIndex = 1;
            this.tbSurname.TextChanged += new System.EventHandler(this.tbSurname_TextChanged);
            // 
            // lblSurnameSearching
            // 
            this.lblSurnameSearching.AutoSize = true;
            this.lblSurnameSearching.Location = new System.Drawing.Point(12, 421);
            this.lblSurnameSearching.Name = "lblSurnameSearching";
            this.lblSurnameSearching.Size = new System.Drawing.Size(103, 13);
            this.lblSurnameSearching.TabIndex = 2;
            this.lblSurnameSearching.Text = "Wyszukaj nazwisko:";
            // 
            // SalariesHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSurnameSearching);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.dgvHistory);
            this.Name = "SalariesHistory";
            this.Text = "Historia wypłat";
            this.Load += new System.EventHandler(this.SalariesHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Label lblSurnameSearching;
    }
}