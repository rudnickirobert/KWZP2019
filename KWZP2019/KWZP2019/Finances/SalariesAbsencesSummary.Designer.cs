namespace KWZP2019
{
    partial class SalariesSummary
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
            this.dgvAllAbsencesData = new System.Windows.Forms.DataGridView();
            this.dgvAbsencesWorker = new System.Windows.Forms.DataGridView();
            this.btnSUM = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllAbsencesData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsencesWorker)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllAbsencesData
            // 
            this.dgvAllAbsencesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllAbsencesData.Location = new System.Drawing.Point(12, 12);
            this.dgvAllAbsencesData.Name = "dgvAllAbsencesData";
            this.dgvAllAbsencesData.Size = new System.Drawing.Size(500, 150);
            this.dgvAllAbsencesData.TabIndex = 0;
            // 
            // dgvAbsencesWorker
            // 
            this.dgvAbsencesWorker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsencesWorker.Location = new System.Drawing.Point(12, 220);
            this.dgvAbsencesWorker.Name = "dgvAbsencesWorker";
            this.dgvAbsencesWorker.Size = new System.Drawing.Size(500, 150);
            this.dgvAbsencesWorker.TabIndex = 1;
            // 
            // btnSUM
            // 
            this.btnSUM.Location = new System.Drawing.Point(181, 177);
            this.btnSUM.Name = "btnSUM";
            this.btnSUM.Size = new System.Drawing.Size(197, 23);
            this.btnSUM.TabIndex = 2;
            this.btnSUM.Text = "SUM";
            this.btnSUM.UseVisualStyleBackColor = true;
            // 
            // SalariesSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 416);
            this.Controls.Add(this.btnSUM);
            this.Controls.Add(this.dgvAbsencesWorker);
            this.Controls.Add(this.dgvAllAbsencesData);
            this.Name = "SalariesSummary";
            this.Text = "Podlicz wypłaty";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllAbsencesData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsencesWorker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllAbsencesData;
        private System.Windows.Forms.DataGridView dgvAbsencesWorker;
        private System.Windows.Forms.Button btnSUM;
    }
}