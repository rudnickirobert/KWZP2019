namespace KWZP2019
{
    partial class OSHControlHistory
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
            this.dGVControlHistory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGVControlHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVControlHistory
            // 
            this.dGVControlHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVControlHistory.Location = new System.Drawing.Point(1, 0);
            this.dGVControlHistory.Name = "dGVControlHistory";
            this.dGVControlHistory.Size = new System.Drawing.Size(800, 456);
            this.dGVControlHistory.TabIndex = 0;
            // 
            // OSHControlHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dGVControlHistory);
            this.Name = "OSHControlHistory";
            this.Text = "OSHControlHistory";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OSHControlHistory_FormClosed);
            this.Load += new System.EventHandler(this.OSHControlHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVControlHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVControlHistory;
    }
}