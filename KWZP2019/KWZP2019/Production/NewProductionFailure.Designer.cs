namespace KWZP2019
{
    partial class NewProductionFailure
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
            this.button_save = new System.Windows.Forms.Button();
            this.cBidproces = new System.Windows.Forms.ComboBox();
            this.productionProcessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker_Failure = new System.Windows.Forms.DateTimePicker();
            this.label_idProces = new System.Windows.Forms.Label();
            this.tBdescription = new System.Windows.Forms.TextBox();
            this.label_failureDate = new System.Windows.Forms.Label();
            this.label_description = new System.Windows.Forms.Label();
            this.button_Back = new System.Windows.Forms.Button();
            this.productionFailuresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.productionProcessBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionFailuresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.button_save.BackgroundImage = global::KWZP2019.Properties.Resources.addp;
            this.button_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_save.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_save.Location = new System.Drawing.Point(299, 224);
            this.button_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(203, 166);
            this.button_save.TabIndex = 0;
            this.button_save.Text = "Zapisz";
            this.button_save.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // cBidproces
            // 
            this.cBidproces.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productionProcessBindingSource, "IdProces", true));
            this.cBidproces.DataSource = this.productionProcessBindingSource;
            this.cBidproces.DisplayMember = "IdProces";
            this.cBidproces.FormattingEnabled = true;
            this.cBidproces.Location = new System.Drawing.Point(255, 57);
            this.cBidproces.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBidproces.Name = "cBidproces";
            this.cBidproces.Size = new System.Drawing.Size(245, 24);
            this.cBidproces.TabIndex = 1;
            this.cBidproces.ValueMember = "IdProces";
            // 
            // productionProcessBindingSource
            // 
            this.productionProcessBindingSource.DataSource = typeof(KWZP2019.ProductionProcess);
            // 
            // dateTimePicker_Failure
            // 
            this.dateTimePicker_Failure.Location = new System.Drawing.Point(255, 110);
            this.dateTimePicker_Failure.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker_Failure.Name = "dateTimePicker_Failure";
            this.dateTimePicker_Failure.Size = new System.Drawing.Size(245, 22);
            this.dateTimePicker_Failure.TabIndex = 2;
            // 
            // label_idProces
            // 
            this.label_idProces.AutoSize = true;
            this.label_idProces.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.label_idProces.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_idProces.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_idProces.Location = new System.Drawing.Point(40, 57);
            this.label_idProces.Name = "label_idProces";
            this.label_idProces.Size = new System.Drawing.Size(158, 25);
            this.label_idProces.TabIndex = 3;
            this.label_idProces.Text = "Numer procesu";
            // 
            // tBdescription
            // 
            this.tBdescription.ForeColor = System.Drawing.Color.Black;
            this.tBdescription.Location = new System.Drawing.Point(255, 160);
            this.tBdescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBdescription.Name = "tBdescription";
            this.tBdescription.Size = new System.Drawing.Size(245, 22);
            this.tBdescription.TabIndex = 4;
            // 
            // label_failureDate
            // 
            this.label_failureDate.AutoSize = true;
            this.label_failureDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.label_failureDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_failureDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_failureDate.Location = new System.Drawing.Point(40, 110);
            this.label_failureDate.Name = "label_failureDate";
            this.label_failureDate.Size = new System.Drawing.Size(119, 25);
            this.label_failureDate.TabIndex = 5;
            this.label_failureDate.Text = "Data awarii";
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.label_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_description.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_description.Location = new System.Drawing.Point(40, 162);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(57, 25);
            this.label_description.TabIndex = 6;
            this.label_description.Text = "Opis";
            // 
            // button_Back
            // 
            this.button_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.button_Back.BackgroundImage = global::KWZP2019.Properties.Resources.powrott;
            this.button_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Back.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Back.Location = new System.Drawing.Point(45, 224);
            this.button_Back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(203, 167);
            this.button_Back.TabIndex = 7;
            this.button_Back.Text = "Powrót";
            this.button_Back.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_Back.UseVisualStyleBackColor = false;
            this.button_Back.Click += new System.EventHandler(this.button_abort_Click);
            // 
            // productionFailuresBindingSource
            // 
            this.productionFailuresBindingSource.DataSource = typeof(KWZP2019.ProductionFailures);
            // 
            // NewProductionFailure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KWZP2019.Properties.Resources._53062472_302328053765523_8291849142804676608_n;
            this.ClientSize = new System.Drawing.Size(549, 405);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.label_description);
            this.Controls.Add(this.label_failureDate);
            this.Controls.Add(this.tBdescription);
            this.Controls.Add(this.label_idProces);
            this.Controls.Add(this.dateTimePicker_Failure);
            this.Controls.Add(this.cBidproces);
            this.Controls.Add(this.button_save);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NewProductionFailure";
            this.Text = "Nowa awaria";
            this.Load += new System.EventHandler(this.NewProductionFailure_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productionProcessBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionFailuresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.ComboBox cBidproces;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Failure;
        private System.Windows.Forms.Label label_idProces;
        private System.Windows.Forms.TextBox tBdescription;
        private System.Windows.Forms.Label label_failureDate;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.BindingSource productionProcessBindingSource;
        private System.Windows.Forms.BindingSource productionFailuresBindingSource;
    }
}