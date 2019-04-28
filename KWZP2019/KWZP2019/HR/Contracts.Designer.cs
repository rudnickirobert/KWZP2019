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
            this.btnAddTraining = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvContracts
            // 
            this.dgvContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContracts.Location = new System.Drawing.Point(63, 46);
            this.dgvContracts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvContracts.Name = "dgvContracts";
            this.dgvContracts.RowTemplate.Height = 24;
            this.dgvContracts.Size = new System.Drawing.Size(433, 310);
            this.dgvContracts.TabIndex = 0;
            // 
            // tbSearchContract
            // 
            this.tbSearchContract.Location = new System.Drawing.Point(63, 11);
            this.tbSearchContract.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSearchContract.Name = "tbSearchContract";
            this.tbSearchContract.Size = new System.Drawing.Size(298, 20);
            this.tbSearchContract.TabIndex = 1;
            this.tbSearchContract.TextChanged += new System.EventHandler(this.tbSearchContract_TextChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(521, 182);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(70, 41);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edytuj";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAddTraining
            // 
            this.btnAddTraining.Location = new System.Drawing.Point(521, 228);
            this.btnAddTraining.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddTraining.Name = "btnAddTraining";
            this.btnAddTraining.Size = new System.Drawing.Size(70, 41);
            this.btnAddTraining.TabIndex = 3;
            this.btnAddTraining.Text = "Dodaj szkolenie";
            this.btnAddTraining.UseVisualStyleBackColor = true;
            // 
            // Contracts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnAddTraining);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.tbSearchContract);
            this.Controls.Add(this.dgvContracts);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button btnAddTraining;
    }
}