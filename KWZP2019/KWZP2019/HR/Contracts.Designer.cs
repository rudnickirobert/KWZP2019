namespace KWZP2019
{
    partial class Contracts
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
            this.dgvContracts = new System.Windows.Forms.DataGridView();
            this.tbSearchContract = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.AddTraining = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvContracts
            // 
            this.dgvContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContracts.Location = new System.Drawing.Point(84, 57);
            this.dgvContracts.Name = "dgvContracts";
            this.dgvContracts.RowTemplate.Height = 24;
            this.dgvContracts.Size = new System.Drawing.Size(577, 381);
            this.dgvContracts.TabIndex = 0;
            // 
            // tbSearchContract
            // 
            this.tbSearchContract.Location = new System.Drawing.Point(84, 13);
            this.tbSearchContract.Name = "tbSearchContract";
            this.tbSearchContract.Size = new System.Drawing.Size(396, 22);
            this.tbSearchContract.TabIndex = 1;
            this.tbSearchContract.TextChanged += new System.EventHandler(this.tbSearchContract_TextChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(695, 224);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(93, 50);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edytuj";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // AddTraining
            // 
            this.AddTraining.Location = new System.Drawing.Point(695, 280);
            this.AddTraining.Name = "AddTraining";
            this.AddTraining.Size = new System.Drawing.Size(93, 50);
            this.AddTraining.TabIndex = 3;
            this.AddTraining.Text = "Dodaj szkolenie";
            this.AddTraining.UseVisualStyleBackColor = true;
            // 
            // Contracts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddTraining);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.tbSearchContract);
            this.Controls.Add(this.dgvContracts);
            this.Name = "Contracts";
            this.Text = "Contracts";
            this.Load += new System.EventHandler(this.Contracts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContracts;
        private System.Windows.Forms.TextBox tbSearchContract;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button AddTraining;
    }
}