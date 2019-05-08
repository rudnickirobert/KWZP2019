namespace KWZP2019
{
    partial class MaintenanceDescriptionForm
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
            this.txtDetailDescription = new System.Windows.Forms.TextBox();
            this.txtShortDescription = new System.Windows.Forms.TextBox();
            this.lblShortDescription = new System.Windows.Forms.Label();
            this.lblDetailDescription = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDetailDescription
            // 
            this.txtDetailDescription.Location = new System.Drawing.Point(55, 96);
            this.txtDetailDescription.Multiline = true;
            this.txtDetailDescription.Name = "txtDetailDescription";
            this.txtDetailDescription.Size = new System.Drawing.Size(733, 265);
            this.txtDetailDescription.TabIndex = 1;
            // 
            // txtShortDescription
            // 
            this.txtShortDescription.Location = new System.Drawing.Point(55, 32);
            this.txtShortDescription.MaxLength = 50;
            this.txtShortDescription.Name = "txtShortDescription";
            this.txtShortDescription.Size = new System.Drawing.Size(733, 20);
            this.txtShortDescription.TabIndex = 2;
            // 
            // lblShortDescription
            // 
            this.lblShortDescription.AutoSize = true;
            this.lblShortDescription.Location = new System.Drawing.Point(52, 9);
            this.lblShortDescription.Name = "lblShortDescription";
            this.lblShortDescription.Size = new System.Drawing.Size(77, 13);
            this.lblShortDescription.TabIndex = 3;
            this.lblShortDescription.Text = "Opis skrócony:";
            // 
            // lblDetailDescription
            // 
            this.lblDetailDescription.AutoSize = true;
            this.lblDetailDescription.Location = new System.Drawing.Point(52, 66);
            this.lblDetailDescription.Name = "lblDetailDescription";
            this.lblDetailDescription.Size = new System.Drawing.Size(96, 13);
            this.lblDetailDescription.TabIndex = 3;
            this.lblDetailDescription.Text = "Opis szczegółowy:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(244, 383);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(161, 39);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Zamknij";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MaintenanceDescriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDetailDescription);
            this.Controls.Add(this.lblShortDescription);
            this.Controls.Add(this.txtShortDescription);
            this.Controls.Add(this.txtDetailDescription);
            this.Controls.Add(this.btnClose);
            this.Name = "MaintenanceDescriptionForm";
            this.Text = "MaintenanceDescriptionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDetailDescription;
        private System.Windows.Forms.TextBox txtShortDescription;
        private System.Windows.Forms.Label lblShortDescription;
        private System.Windows.Forms.Label lblDetailDescription;
        private System.Windows.Forms.Button btnClose;
    }
}