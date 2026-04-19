namespace MediaTek86.view
{
    partial class FrmMediaTek
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
            this.gbPersonnel = new System.Windows.Forms.GroupBox();
            this.gbAbsences = new System.Windows.Forms.GroupBox();
            this.btnAjouterPersonnel = new System.Windows.Forms.Button();
            this.btnModifierPersonnel = new System.Windows.Forms.Button();
            this.btnSupprimerPersonnel = new System.Windows.Forms.Button();
            this.btnAjouterAbsence = new System.Windows.Forms.Button();
            this.btnModifierAbsence = new System.Windows.Forms.Button();
            this.btnSupprimerAbsence = new System.Windows.Forms.Button();
            this.dgvPersonnel = new System.Windows.Forms.DataGridView();
            this.dgvAbsences = new System.Windows.Forms.DataGridView();
            this.gbPersonnel.SuspendLayout();
            this.gbAbsences.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPersonnel
            // 
            this.gbPersonnel.Controls.Add(this.dgvPersonnel);
            this.gbPersonnel.Location = new System.Drawing.Point(12, 12);
            this.gbPersonnel.Name = "gbPersonnel";
            this.gbPersonnel.Size = new System.Drawing.Size(776, 288);
            this.gbPersonnel.TabIndex = 0;
            this.gbPersonnel.TabStop = false;
            this.gbPersonnel.Text = "Personnel";
            // 
            // gbAbsences
            // 
            this.gbAbsences.Controls.Add(this.dgvAbsences);
            this.gbAbsences.Location = new System.Drawing.Point(12, 306);
            this.gbAbsences.Name = "gbAbsences";
            this.gbAbsences.Size = new System.Drawing.Size(776, 288);
            this.gbAbsences.TabIndex = 1;
            this.gbAbsences.TabStop = false;
            this.gbAbsences.Text = "Absences";
            // 
            // btnAjouterPersonnel
            // 
            this.btnAjouterPersonnel.Location = new System.Drawing.Point(24, 259);
            this.btnAjouterPersonnel.Name = "btnAjouterPersonnel";
            this.btnAjouterPersonnel.Size = new System.Drawing.Size(103, 23);
            this.btnAjouterPersonnel.TabIndex = 2;
            this.btnAjouterPersonnel.Text = "Ajouter";
            this.btnAjouterPersonnel.UseVisualStyleBackColor = true;
            this.btnAjouterPersonnel.Click += new System.EventHandler(this.btnAjouterPersonnel_Click);
            // 
            // btnModifierPersonnel
            // 
            this.btnModifierPersonnel.Location = new System.Drawing.Point(152, 259);
            this.btnModifierPersonnel.Name = "btnModifierPersonnel";
            this.btnModifierPersonnel.Size = new System.Drawing.Size(103, 23);
            this.btnModifierPersonnel.TabIndex = 3;
            this.btnModifierPersonnel.Text = "Modifier";
            this.btnModifierPersonnel.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerPersonnel
            // 
            this.btnSupprimerPersonnel.Location = new System.Drawing.Point(282, 259);
            this.btnSupprimerPersonnel.Name = "btnSupprimerPersonnel";
            this.btnSupprimerPersonnel.Size = new System.Drawing.Size(103, 23);
            this.btnSupprimerPersonnel.TabIndex = 4;
            this.btnSupprimerPersonnel.Text = "Supprimer";
            this.btnSupprimerPersonnel.UseVisualStyleBackColor = true;
            // 
            // btnAjouterAbsence
            // 
            this.btnAjouterAbsence.Location = new System.Drawing.Point(24, 553);
            this.btnAjouterAbsence.Name = "btnAjouterAbsence";
            this.btnAjouterAbsence.Size = new System.Drawing.Size(103, 23);
            this.btnAjouterAbsence.TabIndex = 5;
            this.btnAjouterAbsence.Text = "Ajouter";
            this.btnAjouterAbsence.UseVisualStyleBackColor = true;
            // 
            // btnModifierAbsence
            // 
            this.btnModifierAbsence.Location = new System.Drawing.Point(152, 553);
            this.btnModifierAbsence.Name = "btnModifierAbsence";
            this.btnModifierAbsence.Size = new System.Drawing.Size(103, 23);
            this.btnModifierAbsence.TabIndex = 6;
            this.btnModifierAbsence.Text = "Modifier";
            this.btnModifierAbsence.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerAbsence
            // 
            this.btnSupprimerAbsence.Location = new System.Drawing.Point(282, 553);
            this.btnSupprimerAbsence.Name = "btnSupprimerAbsence";
            this.btnSupprimerAbsence.Size = new System.Drawing.Size(103, 23);
            this.btnSupprimerAbsence.TabIndex = 7;
            this.btnSupprimerAbsence.Text = "Supprimer";
            this.btnSupprimerAbsence.UseVisualStyleBackColor = true;
            // 
            // dgvPersonnel
            // 
            this.dgvPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonnel.Location = new System.Drawing.Point(6, 21);
            this.dgvPersonnel.Name = "dgvPersonnel";
            this.dgvPersonnel.RowHeadersWidth = 51;
            this.dgvPersonnel.RowTemplate.Height = 24;
            this.dgvPersonnel.Size = new System.Drawing.Size(764, 220);
            this.dgvPersonnel.TabIndex = 0;
            // 
            // dgvAbsences
            // 
            this.dgvAbsences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsences.Location = new System.Drawing.Point(6, 21);
            this.dgvAbsences.Name = "dgvAbsences";
            this.dgvAbsences.RowHeadersWidth = 51;
            this.dgvAbsences.RowTemplate.Height = 24;
            this.dgvAbsences.Size = new System.Drawing.Size(764, 220);
            this.dgvAbsences.TabIndex = 1;
            // 
            // FrmMediaTek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 606);
            this.Controls.Add(this.btnSupprimerAbsence);
            this.Controls.Add(this.btnModifierAbsence);
            this.Controls.Add(this.btnAjouterAbsence);
            this.Controls.Add(this.btnSupprimerPersonnel);
            this.Controls.Add(this.btnModifierPersonnel);
            this.Controls.Add(this.btnAjouterPersonnel);
            this.Controls.Add(this.gbAbsences);
            this.Controls.Add(this.gbPersonnel);
            this.Name = "FrmMediaTek";
            this.Text = "FrmMediaTek";
            this.gbPersonnel.ResumeLayout(false);
            this.gbAbsences.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPersonnel;
        private System.Windows.Forms.GroupBox gbAbsences;
        private System.Windows.Forms.Button btnAjouterPersonnel;
        private System.Windows.Forms.Button btnModifierPersonnel;
        private System.Windows.Forms.Button btnSupprimerPersonnel;
        private System.Windows.Forms.Button btnAjouterAbsence;
        private System.Windows.Forms.Button btnModifierAbsence;
        private System.Windows.Forms.Button btnSupprimerAbsence;
        private System.Windows.Forms.DataGridView dgvPersonnel;
        private System.Windows.Forms.DataGridView dgvAbsences;
    }
}