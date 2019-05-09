namespace KWZP2019
{
    partial class NewTechnology
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewTechnology));
            this.lblSpeedFactor = new System.Windows.Forms.Label();
            this.lblTimePerMeter = new System.Windows.Forms.Label();
            this.lblTechnologyName = new System.Windows.Forms.Label();
            this.textBoxSpeedFactor = new System.Windows.Forms.TextBox();
            this.textBoxTimePerMeter = new System.Windows.Forms.TextBox();
            this.textBoxTechnologyName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSpeedFactor
            // 
            this.lblSpeedFactor.AutoSize = true;
            this.lblSpeedFactor.BackColor = System.Drawing.Color.Transparent;
            this.lblSpeedFactor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSpeedFactor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSpeedFactor.Location = new System.Drawing.Point(12, 180);
            this.lblSpeedFactor.Name = "lblSpeedFactor";
            this.lblSpeedFactor.Size = new System.Drawing.Size(157, 16);
            this.lblSpeedFactor.TabIndex = 7;
            this.lblSpeedFactor.Text = "Współczynnik prędkości";
            // 
            // lblTimePerMeter
            // 
            this.lblTimePerMeter.AutoSize = true;
            this.lblTimePerMeter.BackColor = System.Drawing.Color.Transparent;
            this.lblTimePerMeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTimePerMeter.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTimePerMeter.Location = new System.Drawing.Point(3, 132);
            this.lblTimePerMeter.Name = "lblTimePerMeter";
            this.lblTimePerMeter.Size = new System.Drawing.Size(171, 16);
            this.lblTimePerMeter.TabIndex = 8;
            this.lblTimePerMeter.Text = "Prędkość produkcji [m/min]";
            // 
            // lblTechnologyName
            // 
            this.lblTechnologyName.AutoSize = true;
            this.lblTechnologyName.BackColor = System.Drawing.Color.Transparent;
            this.lblTechnologyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTechnologyName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTechnologyName.Location = new System.Drawing.Point(52, 78);
            this.lblTechnologyName.Name = "lblTechnologyName";
            this.lblTechnologyName.Size = new System.Drawing.Size(117, 16);
            this.lblTechnologyName.TabIndex = 9;
            this.lblTechnologyName.Text = "Nazwa technologii";
            // 
            // textBoxSpeedFactor
            // 
            this.textBoxSpeedFactor.Location = new System.Drawing.Point(180, 179);
            this.textBoxSpeedFactor.Name = "textBoxSpeedFactor";
            this.textBoxSpeedFactor.Size = new System.Drawing.Size(137, 20);
            this.textBoxSpeedFactor.TabIndex = 4;
            // 
            // textBoxTimePerMeter
            // 
            this.textBoxTimePerMeter.Location = new System.Drawing.Point(180, 128);
            this.textBoxTimePerMeter.Name = "textBoxTimePerMeter";
            this.textBoxTimePerMeter.Size = new System.Drawing.Size(137, 20);
            this.textBoxTimePerMeter.TabIndex = 5;
            // 
            // textBoxTechnologyName
            // 
            this.textBoxTechnologyName.Location = new System.Drawing.Point(180, 78);
            this.textBoxTechnologyName.Name = "textBoxTechnologyName";
            this.textBoxTechnologyName.Size = new System.Drawing.Size(137, 20);
            this.textBoxTechnologyName.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnSave.FlatAppearance.BorderSize = 3;
            this.btnSave.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(351, 48);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(172, 98);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Zatwierdź";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnReturn.FlatAppearance.BorderSize = 3;
            this.btnReturn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReturn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
            this.btnReturn.Location = new System.Drawing.Point(351, 190);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(172, 98);
            this.btnReturn.TabIndex = 18;
            this.btnReturn.Text = "Powrót";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // NewTechnology
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KWZP2019.Properties.Resources._53062472_302328053765523_8291849142804676608_n;
            this.ClientSize = new System.Drawing.Size(560, 331);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblSpeedFactor);
            this.Controls.Add(this.lblTimePerMeter);
            this.Controls.Add(this.lblTechnologyName);
            this.Controls.Add(this.textBoxSpeedFactor);
            this.Controls.Add(this.textBoxTimePerMeter);
            this.Controls.Add(this.textBoxTechnologyName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewTechnology";
            this.Text = "Nowa technlogia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSpeedFactor;
        private System.Windows.Forms.Label lblTimePerMeter;
        private System.Windows.Forms.Label lblTechnologyName;
        private System.Windows.Forms.TextBox textBoxSpeedFactor;
        private System.Windows.Forms.TextBox textBoxTimePerMeter;
        private System.Windows.Forms.TextBox textBoxTechnologyName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReturn;
    }
}