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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaintenanceDescriptionForm));
            this.txtDetailDescription = new System.Windows.Forms.TextBox();
            this.txtShortDescription = new System.Windows.Forms.TextBox();
            this.lblShortDescription = new System.Windows.Forms.Label();
            this.lblDetailDescription = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDetailDescription
            // 
            this.txtDetailDescription.Location = new System.Drawing.Point(34, 87);
            this.txtDetailDescription.Multiline = true;
            this.txtDetailDescription.Name = "txtDetailDescription";
            this.txtDetailDescription.Size = new System.Drawing.Size(733, 265);
            this.txtDetailDescription.TabIndex = 1;
            // 
            // txtShortDescription
            // 
            this.txtShortDescription.Location = new System.Drawing.Point(34, 32);
            this.txtShortDescription.MaxLength = 50;
            this.txtShortDescription.Name = "txtShortDescription";
            this.txtShortDescription.Size = new System.Drawing.Size(733, 20);
            this.txtShortDescription.TabIndex = 2;
            // 
            // lblShortDescription
            // 
            this.lblShortDescription.AutoSize = true;
            this.lblShortDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblShortDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblShortDescription.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblShortDescription.Location = new System.Drawing.Point(30, 9);
            this.lblShortDescription.Name = "lblShortDescription";
            this.lblShortDescription.Size = new System.Drawing.Size(126, 20);
            this.lblShortDescription.TabIndex = 3;
            this.lblShortDescription.Text = "Opis skrócony:";
            // 
            // lblDetailDescription
            // 
            this.lblDetailDescription.AutoSize = true;
            this.lblDetailDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDetailDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDetailDescription.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDetailDescription.Location = new System.Drawing.Point(30, 64);
            this.lblDetailDescription.Name = "lblDetailDescription";
            this.lblDetailDescription.Size = new System.Drawing.Size(156, 20);
            this.lblDetailDescription.TabIndex = 3;
            this.lblDetailDescription.Text = "Opis szczegółowy:";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnClose.FlatAppearance.BorderSize = 3;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.Location = new System.Drawing.Point(606, 369);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(161, 80);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Zamknij";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MaintenanceDescriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KWZP2019.Properties.Resources._53062472_302328053765523_8291849142804676608_n;
            this.ClientSize = new System.Drawing.Size(800, 461);
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