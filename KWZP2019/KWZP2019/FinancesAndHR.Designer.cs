namespace KWZP2019
{
    partial class FinancesAndHR
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
            this.btnFinances = new System.Windows.Forms.Button();
            this.btnHR = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFinances
            // 
            this.btnFinances.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnFinances.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFinances.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnFinances.FlatAppearance.BorderSize = 3;
            this.btnFinances.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnFinances.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnFinances.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinances.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFinances.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFinances.Image = global::KWZP2019.Properties.Resources.icons8_euro_money_80;
            this.btnFinances.Location = new System.Drawing.Point(322, 65);
            this.btnFinances.Margin = new System.Windows.Forms.Padding(0);
            this.btnFinances.Name = "btnFinances";
            this.btnFinances.Size = new System.Drawing.Size(290, 160);
            this.btnFinances.TabIndex = 0;
            this.btnFinances.Text = "Finanse";
            this.btnFinances.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFinances.UseVisualStyleBackColor = false;
            this.btnFinances.Click += new System.EventHandler(this.btnFinances_Click);
            // 
            // btnHR
            // 
            this.btnHR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnHR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHR.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnHR.FlatAppearance.BorderSize = 3;
            this.btnHR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnHR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnHR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHR.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHR.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHR.Image = global::KWZP2019.Properties.Resources.icons8_user_groups_80__1_;
            this.btnHR.Location = new System.Drawing.Point(322, 263);
            this.btnHR.Margin = new System.Windows.Forms.Padding(0);
            this.btnHR.Name = "btnHR";
            this.btnHR.Size = new System.Drawing.Size(290, 160);
            this.btnHR.TabIndex = 2;
            this.btnHR.Text = "Kadry";
            this.btnHR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHR.UseVisualStyleBackColor = false;
            this.btnHR.Click += new System.EventHandler(this.btnHR_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(715, 157);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(153, 68);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Powrót do menu";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // FinancesAndHR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KWZP2019.Properties.Resources._53529133_302328057098856_6495078002911608832_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 749);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnHR);
            this.Controls.Add(this.btnFinances);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FinancesAndHR";
            this.Text = "Finanse i Kadry";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFinances;
        private System.Windows.Forms.Button btnHR;
        private System.Windows.Forms.Button btnBack;
    }
}