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
            this.grbPersonnel = new System.Windows.Forms.GroupBox();
            this.dgvPersonnel = new System.Windows.Forms.DataGridView();
            this.btnModifierPersonnel = new System.Windows.Forms.Button();
            this.btnSupprimerPersonnel = new System.Windows.Forms.Button();
            this.grbAbsences = new System.Windows.Forms.GroupBox();
            this.btnSupprimerAbsence = new System.Windows.Forms.Button();
            this.dgvAbsences = new System.Windows.Forms.DataGridView();
            this.btnModifierAbsence = new System.Windows.Forms.Button();
            this.grbModifierPersonnel = new System.Windows.Forms.GroupBox();
            this.cboModifierService = new System.Windows.Forms.ComboBox();
            this.txtModifierMail = new System.Windows.Forms.TextBox();
            this.txtModifierTel = new System.Windows.Forms.TextBox();
            this.txtModifierPrenom = new System.Windows.Forms.TextBox();
            this.txtModifierNom = new System.Windows.Forms.TextBox();
            this.BtnAnnulModifierPersonnel = new System.Windows.Forms.Button();
            this.BtnEnregModifierPersonnel = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grbAjouterPersonnel = new System.Windows.Forms.GroupBox();
            this.cboAjouterService = new System.Windows.Forms.ComboBox();
            this.txtAjouterMail = new System.Windows.Forms.TextBox();
            this.txtAjouterTel = new System.Windows.Forms.TextBox();
            this.txtAjouterPrenom = new System.Windows.Forms.TextBox();
            this.txtAjouterNom = new System.Windows.Forms.TextBox();
            this.BtnAnnulAjouterPersonnel = new System.Windows.Forms.Button();
            this.BtnEnregAjouterPersonnel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbAjouterAbsence = new System.Windows.Forms.GroupBox();
            this.cboAjouterMotif = new System.Windows.Forms.ComboBox();
            this.dtpAjouterDateFin = new System.Windows.Forms.DateTimePicker();
            this.dtpAjouterDateDebut = new System.Windows.Forms.DateTimePicker();
            this.BtnEnregAjouterAbsence = new System.Windows.Forms.Button();
            this.BtnAnnulAjouterAbsence = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.grbModifierAbsence = new System.Windows.Forms.GroupBox();
            this.cboModifierMotif = new System.Windows.Forms.ComboBox();
            this.dtpModifierDateFin = new System.Windows.Forms.DateTimePicker();
            this.dtpModifierDateDebut = new System.Windows.Forms.DateTimePicker();
            this.BtnEnregModifierAbsence = new System.Windows.Forms.Button();
            this.BtnAnnulModifierAbsence = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.grbPersonnel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).BeginInit();
            this.grbAbsences.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).BeginInit();
            this.grbModifierPersonnel.SuspendLayout();
            this.grbAjouterPersonnel.SuspendLayout();
            this.grbAjouterAbsence.SuspendLayout();
            this.grbModifierAbsence.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbPersonnel
            // 
            this.grbPersonnel.Controls.Add(this.dgvPersonnel);
            this.grbPersonnel.Controls.Add(this.btnModifierPersonnel);
            this.grbPersonnel.Controls.Add(this.btnSupprimerPersonnel);
            this.grbPersonnel.Location = new System.Drawing.Point(9, 10);
            this.grbPersonnel.Margin = new System.Windows.Forms.Padding(2);
            this.grbPersonnel.Name = "grbPersonnel";
            this.grbPersonnel.Padding = new System.Windows.Forms.Padding(2);
            this.grbPersonnel.Size = new System.Drawing.Size(514, 245);
            this.grbPersonnel.TabIndex = 0;
            this.grbPersonnel.TabStop = false;
            this.grbPersonnel.Text = "Personnel";
            // 
            // dgvPersonnel
            // 
            this.dgvPersonnel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonnel.Location = new System.Drawing.Point(9, 17);
            this.dgvPersonnel.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPersonnel.MultiSelect = false;
            this.dgvPersonnel.Name = "dgvPersonnel";
            this.dgvPersonnel.ReadOnly = true;
            this.dgvPersonnel.RowHeadersVisible = false;
            this.dgvPersonnel.RowHeadersWidth = 51;
            this.dgvPersonnel.RowTemplate.Height = 24;
            this.dgvPersonnel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonnel.Size = new System.Drawing.Size(496, 179);
            this.dgvPersonnel.TabIndex = 0;
            this.dgvPersonnel.SelectionChanged += new System.EventHandler(this.DgvPersonnel_SelectionChanged);
            // 
            // btnModifierPersonnel
            // 
            this.btnModifierPersonnel.Location = new System.Drawing.Point(9, 204);
            this.btnModifierPersonnel.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifierPersonnel.Name = "btnModifierPersonnel";
            this.btnModifierPersonnel.Size = new System.Drawing.Size(77, 30);
            this.btnModifierPersonnel.TabIndex = 3;
            this.btnModifierPersonnel.Text = "Modifier";
            this.btnModifierPersonnel.UseVisualStyleBackColor = true;
            this.btnModifierPersonnel.Click += new System.EventHandler(this.btnModifierPersonnel_Click);
            // 
            // btnSupprimerPersonnel
            // 
            this.btnSupprimerPersonnel.Location = new System.Drawing.Point(90, 204);
            this.btnSupprimerPersonnel.Margin = new System.Windows.Forms.Padding(2);
            this.btnSupprimerPersonnel.Name = "btnSupprimerPersonnel";
            this.btnSupprimerPersonnel.Size = new System.Drawing.Size(77, 30);
            this.btnSupprimerPersonnel.TabIndex = 4;
            this.btnSupprimerPersonnel.Text = "Supprimer";
            this.btnSupprimerPersonnel.UseVisualStyleBackColor = true;
            this.btnSupprimerPersonnel.Click += new System.EventHandler(this.btnSupprimerPersonnel_Click);
            // 
            // grbAbsences
            // 
            this.grbAbsences.Controls.Add(this.btnSupprimerAbsence);
            this.grbAbsences.Controls.Add(this.dgvAbsences);
            this.grbAbsences.Controls.Add(this.btnModifierAbsence);
            this.grbAbsences.Location = new System.Drawing.Point(536, 11);
            this.grbAbsences.Margin = new System.Windows.Forms.Padding(2);
            this.grbAbsences.Name = "grbAbsences";
            this.grbAbsences.Padding = new System.Windows.Forms.Padding(2);
            this.grbAbsences.Size = new System.Drawing.Size(323, 244);
            this.grbAbsences.TabIndex = 1;
            this.grbAbsences.TabStop = false;
            this.grbAbsences.Text = "Absences";
            // 
            // btnSupprimerAbsence
            // 
            this.btnSupprimerAbsence.Location = new System.Drawing.Point(95, 204);
            this.btnSupprimerAbsence.Margin = new System.Windows.Forms.Padding(2);
            this.btnSupprimerAbsence.Name = "btnSupprimerAbsence";
            this.btnSupprimerAbsence.Size = new System.Drawing.Size(77, 29);
            this.btnSupprimerAbsence.TabIndex = 7;
            this.btnSupprimerAbsence.Text = "Supprimer";
            this.btnSupprimerAbsence.UseVisualStyleBackColor = true;
            this.btnSupprimerAbsence.Click += new System.EventHandler(this.btnSupprimerAbsence_Click);
            // 
            // dgvAbsences
            // 
            this.dgvAbsences.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAbsences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsences.Location = new System.Drawing.Point(14, 16);
            this.dgvAbsences.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAbsences.MultiSelect = false;
            this.dgvAbsences.Name = "dgvAbsences";
            this.dgvAbsences.ReadOnly = true;
            this.dgvAbsences.RowHeadersVisible = false;
            this.dgvAbsences.RowHeadersWidth = 51;
            this.dgvAbsences.RowTemplate.Height = 24;
            this.dgvAbsences.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAbsences.Size = new System.Drawing.Size(296, 179);
            this.dgvAbsences.TabIndex = 1;
            // 
            // btnModifierAbsence
            // 
            this.btnModifierAbsence.Location = new System.Drawing.Point(14, 204);
            this.btnModifierAbsence.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifierAbsence.Name = "btnModifierAbsence";
            this.btnModifierAbsence.Size = new System.Drawing.Size(77, 29);
            this.btnModifierAbsence.TabIndex = 6;
            this.btnModifierAbsence.Text = "Modifier";
            this.btnModifierAbsence.UseVisualStyleBackColor = true;
            this.btnModifierAbsence.Click += new System.EventHandler(this.btnModifierAbsence_Click);
            // 
            // grbModifierPersonnel
            // 
            this.grbModifierPersonnel.Controls.Add(this.cboModifierService);
            this.grbModifierPersonnel.Controls.Add(this.txtModifierMail);
            this.grbModifierPersonnel.Controls.Add(this.txtModifierTel);
            this.grbModifierPersonnel.Controls.Add(this.txtModifierPrenom);
            this.grbModifierPersonnel.Controls.Add(this.txtModifierNom);
            this.grbModifierPersonnel.Controls.Add(this.BtnAnnulModifierPersonnel);
            this.grbModifierPersonnel.Controls.Add(this.BtnEnregModifierPersonnel);
            this.grbModifierPersonnel.Controls.Add(this.label10);
            this.grbModifierPersonnel.Controls.Add(this.label9);
            this.grbModifierPersonnel.Controls.Add(this.label8);
            this.grbModifierPersonnel.Controls.Add(this.label7);
            this.grbModifierPersonnel.Controls.Add(this.label6);
            this.grbModifierPersonnel.Location = new System.Drawing.Point(9, 442);
            this.grbModifierPersonnel.Margin = new System.Windows.Forms.Padding(2);
            this.grbModifierPersonnel.Name = "grbModifierPersonnel";
            this.grbModifierPersonnel.Padding = new System.Windows.Forms.Padding(2);
            this.grbModifierPersonnel.Size = new System.Drawing.Size(514, 174);
            this.grbModifierPersonnel.TabIndex = 6;
            this.grbModifierPersonnel.TabStop = false;
            this.grbModifierPersonnel.Text = "Modifier du personnel";
            // 
            // cboModifierService
            // 
            this.cboModifierService.FormattingEnabled = true;
            this.cboModifierService.Location = new System.Drawing.Point(74, 134);
            this.cboModifierService.Name = "cboModifierService";
            this.cboModifierService.Size = new System.Drawing.Size(143, 21);
            this.cboModifierService.TabIndex = 12;
            // 
            // txtModifierMail
            // 
            this.txtModifierMail.Location = new System.Drawing.Point(284, 87);
            this.txtModifierMail.Name = "txtModifierMail";
            this.txtModifierMail.Size = new System.Drawing.Size(196, 20);
            this.txtModifierMail.TabIndex = 11;
            // 
            // txtModifierTel
            // 
            this.txtModifierTel.Location = new System.Drawing.Point(284, 42);
            this.txtModifierTel.Name = "txtModifierTel";
            this.txtModifierTel.Size = new System.Drawing.Size(196, 20);
            this.txtModifierTel.TabIndex = 10;
            // 
            // txtModifierPrenom
            // 
            this.txtModifierPrenom.Location = new System.Drawing.Point(74, 87);
            this.txtModifierPrenom.Name = "txtModifierPrenom";
            this.txtModifierPrenom.Size = new System.Drawing.Size(143, 20);
            this.txtModifierPrenom.TabIndex = 9;
            // 
            // txtModifierNom
            // 
            this.txtModifierNom.Location = new System.Drawing.Point(74, 42);
            this.txtModifierNom.Name = "txtModifierNom";
            this.txtModifierNom.Size = new System.Drawing.Size(143, 20);
            this.txtModifierNom.TabIndex = 8;
            // 
            // BtnAnnulModifierPersonnel
            // 
            this.BtnAnnulModifierPersonnel.Location = new System.Drawing.Point(405, 132);
            this.BtnAnnulModifierPersonnel.Name = "BtnAnnulModifierPersonnel";
            this.BtnAnnulModifierPersonnel.Size = new System.Drawing.Size(75, 23);
            this.BtnAnnulModifierPersonnel.TabIndex = 7;
            this.BtnAnnulModifierPersonnel.Text = "Annuler";
            this.BtnAnnulModifierPersonnel.UseVisualStyleBackColor = true;
            this.BtnAnnulModifierPersonnel.Click += new System.EventHandler(this.BtnAnnulModifierPersonnel_Click);
            // 
            // BtnEnregModifierPersonnel
            // 
            this.BtnEnregModifierPersonnel.Location = new System.Drawing.Point(324, 132);
            this.BtnEnregModifierPersonnel.Name = "BtnEnregModifierPersonnel";
            this.BtnEnregModifierPersonnel.Size = new System.Drawing.Size(75, 23);
            this.BtnEnregModifierPersonnel.TabIndex = 6;
            this.BtnEnregModifierPersonnel.Text = "Enregistrer";
            this.BtnEnregModifierPersonnel.UseVisualStyleBackColor = true;
            this.BtnEnregModifierPersonnel.Click += new System.EventHandler(this.BtnEnregModifierPersonnel_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(245, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Mail";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(245, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Tel";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Service";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Prénom";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nom";
            // 
            // grbAjouterPersonnel
            // 
            this.grbAjouterPersonnel.Controls.Add(this.cboAjouterService);
            this.grbAjouterPersonnel.Controls.Add(this.txtAjouterMail);
            this.grbAjouterPersonnel.Controls.Add(this.txtAjouterTel);
            this.grbAjouterPersonnel.Controls.Add(this.txtAjouterPrenom);
            this.grbAjouterPersonnel.Controls.Add(this.txtAjouterNom);
            this.grbAjouterPersonnel.Controls.Add(this.BtnAnnulAjouterPersonnel);
            this.grbAjouterPersonnel.Controls.Add(this.BtnEnregAjouterPersonnel);
            this.grbAjouterPersonnel.Controls.Add(this.label5);
            this.grbAjouterPersonnel.Controls.Add(this.label4);
            this.grbAjouterPersonnel.Controls.Add(this.label3);
            this.grbAjouterPersonnel.Controls.Add(this.label2);
            this.grbAjouterPersonnel.Controls.Add(this.label1);
            this.grbAjouterPersonnel.Location = new System.Drawing.Point(9, 259);
            this.grbAjouterPersonnel.Margin = new System.Windows.Forms.Padding(2);
            this.grbAjouterPersonnel.Name = "grbAjouterPersonnel";
            this.grbAjouterPersonnel.Padding = new System.Windows.Forms.Padding(2);
            this.grbAjouterPersonnel.Size = new System.Drawing.Size(514, 170);
            this.grbAjouterPersonnel.TabIndex = 5;
            this.grbAjouterPersonnel.TabStop = false;
            this.grbAjouterPersonnel.Text = "Ajouter du personnel";
            // 
            // cboAjouterService
            // 
            this.cboAjouterService.FormattingEnabled = true;
            this.cboAjouterService.Location = new System.Drawing.Point(74, 125);
            this.cboAjouterService.Name = "cboAjouterService";
            this.cboAjouterService.Size = new System.Drawing.Size(143, 21);
            this.cboAjouterService.TabIndex = 13;
            // 
            // txtAjouterMail
            // 
            this.txtAjouterMail.Location = new System.Drawing.Point(284, 75);
            this.txtAjouterMail.Name = "txtAjouterMail";
            this.txtAjouterMail.Size = new System.Drawing.Size(196, 20);
            this.txtAjouterMail.TabIndex = 10;
            // 
            // txtAjouterTel
            // 
            this.txtAjouterTel.Location = new System.Drawing.Point(284, 34);
            this.txtAjouterTel.Name = "txtAjouterTel";
            this.txtAjouterTel.Size = new System.Drawing.Size(196, 20);
            this.txtAjouterTel.TabIndex = 9;
            // 
            // txtAjouterPrenom
            // 
            this.txtAjouterPrenom.Location = new System.Drawing.Point(74, 75);
            this.txtAjouterPrenom.Name = "txtAjouterPrenom";
            this.txtAjouterPrenom.Size = new System.Drawing.Size(143, 20);
            this.txtAjouterPrenom.TabIndex = 8;
            // 
            // txtAjouterNom
            // 
            this.txtAjouterNom.Location = new System.Drawing.Point(74, 37);
            this.txtAjouterNom.Name = "txtAjouterNom";
            this.txtAjouterNom.Size = new System.Drawing.Size(143, 20);
            this.txtAjouterNom.TabIndex = 7;
            // 
            // BtnAnnulAjouterPersonnel
            // 
            this.BtnAnnulAjouterPersonnel.Location = new System.Drawing.Point(405, 128);
            this.BtnAnnulAjouterPersonnel.Name = "BtnAnnulAjouterPersonnel";
            this.BtnAnnulAjouterPersonnel.Size = new System.Drawing.Size(75, 23);
            this.BtnAnnulAjouterPersonnel.TabIndex = 6;
            this.BtnAnnulAjouterPersonnel.Text = "Annuler";
            this.BtnAnnulAjouterPersonnel.UseVisualStyleBackColor = true;
            this.BtnAnnulAjouterPersonnel.Click += new System.EventHandler(this.BtnAnnulAjouterPersonnel_Click);
            // 
            // BtnEnregAjouterPersonnel
            // 
            this.BtnEnregAjouterPersonnel.Location = new System.Drawing.Point(324, 128);
            this.BtnEnregAjouterPersonnel.Name = "BtnEnregAjouterPersonnel";
            this.BtnEnregAjouterPersonnel.Size = new System.Drawing.Size(75, 23);
            this.BtnEnregAjouterPersonnel.TabIndex = 5;
            this.BtnEnregAjouterPersonnel.Text = "Enregistrer";
            this.BtnEnregAjouterPersonnel.UseVisualStyleBackColor = true;
            this.BtnEnregAjouterPersonnel.Click += new System.EventHandler(this.BtnEnregAjouterPersonnel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Service";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prénom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // grbAjouterAbsence
            // 
            this.grbAjouterAbsence.Controls.Add(this.cboAjouterMotif);
            this.grbAjouterAbsence.Controls.Add(this.dtpAjouterDateFin);
            this.grbAjouterAbsence.Controls.Add(this.dtpAjouterDateDebut);
            this.grbAjouterAbsence.Controls.Add(this.BtnEnregAjouterAbsence);
            this.grbAjouterAbsence.Controls.Add(this.BtnAnnulAjouterAbsence);
            this.grbAjouterAbsence.Controls.Add(this.label13);
            this.grbAjouterAbsence.Controls.Add(this.label12);
            this.grbAjouterAbsence.Controls.Add(this.label11);
            this.grbAjouterAbsence.Location = new System.Drawing.Point(536, 259);
            this.grbAjouterAbsence.Margin = new System.Windows.Forms.Padding(2);
            this.grbAjouterAbsence.Name = "grbAjouterAbsence";
            this.grbAjouterAbsence.Padding = new System.Windows.Forms.Padding(2);
            this.grbAjouterAbsence.Size = new System.Drawing.Size(323, 170);
            this.grbAjouterAbsence.TabIndex = 7;
            this.grbAjouterAbsence.TabStop = false;
            this.grbAjouterAbsence.Text = "Ajouter une absence";
            // 
            // cboAjouterMotif
            // 
            this.cboAjouterMotif.FormattingEnabled = true;
            this.cboAjouterMotif.Location = new System.Drawing.Point(112, 92);
            this.cboAjouterMotif.Name = "cboAjouterMotif";
            this.cboAjouterMotif.Size = new System.Drawing.Size(178, 21);
            this.cboAjouterMotif.TabIndex = 14;
            // 
            // dtpAjouterDateFin
            // 
            this.dtpAjouterDateFin.Location = new System.Drawing.Point(112, 60);
            this.dtpAjouterDateFin.Name = "dtpAjouterDateFin";
            this.dtpAjouterDateFin.Size = new System.Drawing.Size(178, 20);
            this.dtpAjouterDateFin.TabIndex = 10;
            // 
            // dtpAjouterDateDebut
            // 
            this.dtpAjouterDateDebut.Location = new System.Drawing.Point(112, 31);
            this.dtpAjouterDateDebut.Name = "dtpAjouterDateDebut";
            this.dtpAjouterDateDebut.Size = new System.Drawing.Size(178, 20);
            this.dtpAjouterDateDebut.TabIndex = 9;
            // 
            // BtnEnregAjouterAbsence
            // 
            this.BtnEnregAjouterAbsence.Location = new System.Drawing.Point(132, 128);
            this.BtnEnregAjouterAbsence.Name = "BtnEnregAjouterAbsence";
            this.BtnEnregAjouterAbsence.Size = new System.Drawing.Size(75, 23);
            this.BtnEnregAjouterAbsence.TabIndex = 8;
            this.BtnEnregAjouterAbsence.Text = "Enregistrer";
            this.BtnEnregAjouterAbsence.UseVisualStyleBackColor = true;
            this.BtnEnregAjouterAbsence.Click += new System.EventHandler(this.BtnEnregAjouterAbsence_Click);
            // 
            // BtnAnnulAjouterAbsence
            // 
            this.BtnAnnulAjouterAbsence.Location = new System.Drawing.Point(213, 128);
            this.BtnAnnulAjouterAbsence.Name = "BtnAnnulAjouterAbsence";
            this.BtnAnnulAjouterAbsence.Size = new System.Drawing.Size(75, 23);
            this.BtnAnnulAjouterAbsence.TabIndex = 7;
            this.BtnAnnulAjouterAbsence.Text = "Annuler";
            this.BtnAnnulAjouterAbsence.UseVisualStyleBackColor = true;
            this.BtnAnnulAjouterAbsence.Click += new System.EventHandler(this.BtnAnnulAjouterAbsence_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Motif";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Date de fin";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Date de début";
            // 
            // grbModifierAbsence
            // 
            this.grbModifierAbsence.Controls.Add(this.cboModifierMotif);
            this.grbModifierAbsence.Controls.Add(this.dtpModifierDateFin);
            this.grbModifierAbsence.Controls.Add(this.dtpModifierDateDebut);
            this.grbModifierAbsence.Controls.Add(this.BtnEnregModifierAbsence);
            this.grbModifierAbsence.Controls.Add(this.BtnAnnulModifierAbsence);
            this.grbModifierAbsence.Controls.Add(this.label16);
            this.grbModifierAbsence.Controls.Add(this.label15);
            this.grbModifierAbsence.Controls.Add(this.label14);
            this.grbModifierAbsence.Location = new System.Drawing.Point(536, 446);
            this.grbModifierAbsence.Margin = new System.Windows.Forms.Padding(2);
            this.grbModifierAbsence.Name = "grbModifierAbsence";
            this.grbModifierAbsence.Padding = new System.Windows.Forms.Padding(2);
            this.grbModifierAbsence.Size = new System.Drawing.Size(323, 170);
            this.grbModifierAbsence.TabIndex = 8;
            this.grbModifierAbsence.TabStop = false;
            this.grbModifierAbsence.Text = "Modifier une absence";
            // 
            // cboModifierMotif
            // 
            this.cboModifierMotif.FormattingEnabled = true;
            this.cboModifierMotif.Location = new System.Drawing.Point(112, 99);
            this.cboModifierMotif.Name = "cboModifierMotif";
            this.cboModifierMotif.Size = new System.Drawing.Size(178, 21);
            this.cboModifierMotif.TabIndex = 15;
            // 
            // dtpModifierDateFin
            // 
            this.dtpModifierDateFin.Location = new System.Drawing.Point(112, 65);
            this.dtpModifierDateFin.Name = "dtpModifierDateFin";
            this.dtpModifierDateFin.Size = new System.Drawing.Size(178, 20);
            this.dtpModifierDateFin.TabIndex = 11;
            // 
            // dtpModifierDateDebut
            // 
            this.dtpModifierDateDebut.Location = new System.Drawing.Point(112, 38);
            this.dtpModifierDateDebut.Name = "dtpModifierDateDebut";
            this.dtpModifierDateDebut.Size = new System.Drawing.Size(178, 20);
            this.dtpModifierDateDebut.TabIndex = 10;
            // 
            // BtnEnregModifierAbsence
            // 
            this.BtnEnregModifierAbsence.Location = new System.Drawing.Point(132, 133);
            this.BtnEnregModifierAbsence.Name = "BtnEnregModifierAbsence";
            this.BtnEnregModifierAbsence.Size = new System.Drawing.Size(75, 23);
            this.BtnEnregModifierAbsence.TabIndex = 8;
            this.BtnEnregModifierAbsence.Text = "Enregistrer";
            this.BtnEnregModifierAbsence.UseVisualStyleBackColor = true;
            this.BtnEnregModifierAbsence.Click += new System.EventHandler(this.BtnEnregModifierAbsence_Click);
            // 
            // BtnAnnulModifierAbsence
            // 
            this.BtnAnnulModifierAbsence.Location = new System.Drawing.Point(213, 133);
            this.BtnAnnulModifierAbsence.Name = "BtnAnnulModifierAbsence";
            this.BtnAnnulModifierAbsence.Size = new System.Drawing.Size(75, 23);
            this.BtnAnnulModifierAbsence.TabIndex = 7;
            this.BtnAnnulModifierAbsence.Text = "Annuler";
            this.BtnAnnulModifierAbsence.UseVisualStyleBackColor = true;
            this.BtnAnnulModifierAbsence.Click += new System.EventHandler(this.BtnAnnulModifierAbsence_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 102);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Motif";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 65);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Date de fin";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Date de début";
            // 
            // FrmMediaTek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 627);
            this.Controls.Add(this.grbModifierAbsence);
            this.Controls.Add(this.grbAjouterAbsence);
            this.Controls.Add(this.grbModifierPersonnel);
            this.Controls.Add(this.grbAjouterPersonnel);
            this.Controls.Add(this.grbAbsences);
            this.Controls.Add(this.grbPersonnel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMediaTek";
            this.Text = "FrmMediaTek";
            this.grbPersonnel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).EndInit();
            this.grbAbsences.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).EndInit();
            this.grbModifierPersonnel.ResumeLayout(false);
            this.grbModifierPersonnel.PerformLayout();
            this.grbAjouterPersonnel.ResumeLayout(false);
            this.grbAjouterPersonnel.PerformLayout();
            this.grbAjouterAbsence.ResumeLayout(false);
            this.grbAjouterAbsence.PerformLayout();
            this.grbModifierAbsence.ResumeLayout(false);
            this.grbModifierAbsence.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPersonnel;
        private System.Windows.Forms.GroupBox grbAbsences;
        private System.Windows.Forms.Button btnModifierPersonnel;
        private System.Windows.Forms.Button btnSupprimerPersonnel;
        private System.Windows.Forms.Button btnModifierAbsence;
        private System.Windows.Forms.Button btnSupprimerAbsence;
        private System.Windows.Forms.DataGridView dgvAbsences;
        private System.Windows.Forms.GroupBox grbModifierPersonnel;
        private System.Windows.Forms.GroupBox grbAjouterPersonnel;
        private System.Windows.Forms.GroupBox grbAjouterAbsence;
        private System.Windows.Forms.GroupBox grbModifierAbsence;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAnnulModifierPersonnel;
        private System.Windows.Forms.Button BtnEnregModifierPersonnel;
        private System.Windows.Forms.Button BtnAnnulAjouterPersonnel;
        private System.Windows.Forms.Button BtnEnregAjouterPersonnel;
        private System.Windows.Forms.Button BtnEnregAjouterAbsence;
        private System.Windows.Forms.Button BtnAnnulAjouterAbsence;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnEnregModifierAbsence;
        private System.Windows.Forms.Button BtnAnnulModifierAbsence;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtModifierMail;
        private System.Windows.Forms.TextBox txtModifierTel;
        private System.Windows.Forms.TextBox txtModifierPrenom;
        private System.Windows.Forms.TextBox txtModifierNom;
        private System.Windows.Forms.TextBox txtAjouterMail;
        private System.Windows.Forms.TextBox txtAjouterTel;
        private System.Windows.Forms.TextBox txtAjouterPrenom;
        private System.Windows.Forms.TextBox txtAjouterNom;
        private System.Windows.Forms.DateTimePicker dtpAjouterDateDebut;
        private System.Windows.Forms.ComboBox cboModifierService;
        private System.Windows.Forms.ComboBox cboAjouterService;
        private System.Windows.Forms.DateTimePicker dtpAjouterDateFin;
        private System.Windows.Forms.ComboBox cboAjouterMotif;
        private System.Windows.Forms.ComboBox cboModifierMotif;
        private System.Windows.Forms.DateTimePicker dtpModifierDateFin;
        private System.Windows.Forms.DateTimePicker dtpModifierDateDebut;
        private System.Windows.Forms.DataGridView dgvPersonnel;
    }
}