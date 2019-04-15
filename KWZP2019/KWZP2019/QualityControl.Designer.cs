namespace KWZP2019
{
    partial class QualityControl
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
            this.btnEntranceControl = new System.Windows.Forms.Button();
            this.btnOutControl = new System.Windows.Forms.Button();
            this.btnReturnMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEntranceControl
            // 
            this.btnEntranceControl.AutoSize = true;
            this.btnEntranceControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(178)))));
            this.btnEntranceControl.FlatAppearance.BorderSize = 0;
            this.btnEntranceControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntranceControl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEntranceControl.Location = new System.Drawing.Point(32, 74);
            this.btnEntranceControl.Margin = new System.Windows.Forms.Padding(0);
            this.btnEntranceControl.Name = "btnEntranceControl";
            this.btnEntranceControl.Size = new System.Drawing.Size(200, 50);
            this.btnEntranceControl.TabIndex = 2;
            this.btnEntranceControl.Text = "Kontrola Wejściowa";
            this.btnEntranceControl.UseVisualStyleBackColor = false;
            this.btnEntranceControl.Click += new System.EventHandler(this.btnEntranceControl_Click);
            // 
            // btnOutControl
            // 
            this.btnOutControl.AutoSize = true;
            this.btnOutControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(178)))));
            this.btnOutControl.FlatAppearance.BorderSize = 0;
            this.btnOutControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOutControl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOutControl.Location = new System.Drawing.Point(32, 156);
            this.btnOutControl.Margin = new System.Windows.Forms.Padding(0);
            this.btnOutControl.Name = "btnOutControl";
            this.btnOutControl.Size = new System.Drawing.Size(200, 50);
            this.btnOutControl.TabIndex = 2;
            this.btnOutControl.Text = "Kontrola Wyjściowa";
            this.btnOutControl.UseVisualStyleBackColor = false;
            this.btnOutControl.Click += new System.EventHandler(this.btnOutControl_Click);
            // 
            // btnReturnMain
            // 
            this.btnReturnMain.AutoSize = true;
            this.btnReturnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(178)))));
            this.btnReturnMain.FlatAppearance.BorderSize = 0;
            this.btnReturnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnMain.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReturnMain.Location = new System.Drawing.Point(852, 43);
            this.btnReturnMain.Margin = new System.Windows.Forms.Padding(0);
            this.btnReturnMain.Name = "btnReturnMain";
            this.btnReturnMain.Size = new System.Drawing.Size(200, 50);
            this.btnReturnMain.TabIndex = 2;
            this.btnReturnMain.Text = "Menu Główne";
            this.btnReturnMain.UseVisualStyleBackColor = false;
            this.btnReturnMain.Click += new System.EventHandler(this.btnReturnMain_Click);
            // 
            // QualityControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.btnReturnMain);
            this.Controls.Add(this.btnOutControl);
            this.Controls.Add(this.btnEntranceControl);
            this.Name = "QualityControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QualityControl";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.QualityControl_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEntranceControl;
        private System.Windows.Forms.Button btnOutControl;
        private System.Windows.Forms.Button btnReturnMain;
    }
}