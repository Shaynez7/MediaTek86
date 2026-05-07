namespace MediaTek86.view
{
    partial class FrmAuthentification
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
            this.LblLogin = new System.Windows.Forms.Label();
            this.LblPwd = new System.Windows.Forms.Label();
            this.BtnConnexion = new System.Windows.Forms.Button();
            this.TxtLogin = new System.Windows.Forms.TextBox();
            this.TxtPwd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblLogin
            // 
            this.LblLogin.AutoSize = true;
            this.LblLogin.Location = new System.Drawing.Point(28, 54);
            this.LblLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(39, 13);
            this.LblLogin.TabIndex = 0;
            this.LblLogin.Text = "Login :";
            // 
            // LblPwd
            // 
            this.LblPwd.AutoSize = true;
            this.LblPwd.Location = new System.Drawing.Point(260, 54);
            this.LblPwd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPwd.Name = "LblPwd";
            this.LblPwd.Size = new System.Drawing.Size(78, 13);
            this.LblPwd.TabIndex = 1;
            this.LblPwd.Text = "Mot de Passe :";
            // 
            // BtnConnexion
            // 
            this.BtnConnexion.Location = new System.Drawing.Point(31, 126);
            this.BtnConnexion.Margin = new System.Windows.Forms.Padding(2);
            this.BtnConnexion.Name = "BtnConnexion";
            this.BtnConnexion.Size = new System.Drawing.Size(110, 30);
            this.BtnConnexion.TabIndex = 2;
            this.BtnConnexion.Text = "Se connecter";
            this.BtnConnexion.UseVisualStyleBackColor = true;
            this.BtnConnexion.Click += new System.EventHandler(this.BtnConnexion_Click);
            // 
            // TxtLogin
            // 
            this.TxtLogin.Location = new System.Drawing.Point(79, 52);
            this.TxtLogin.Margin = new System.Windows.Forms.Padding(2);
            this.TxtLogin.Name = "TxtLogin";
            this.TxtLogin.Size = new System.Drawing.Size(164, 20);
            this.TxtLogin.TabIndex = 3;
            // 
            // TxtPwd
            // 
            this.TxtPwd.Location = new System.Drawing.Point(344, 52);
            this.TxtPwd.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPwd.Name = "TxtPwd";
            this.TxtPwd.Size = new System.Drawing.Size(164, 20);
            this.TxtPwd.TabIndex = 4;
            this.TxtPwd.UseSystemPasswordChar = true;
            // 
            // FrmAuthentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 193);
            this.Controls.Add(this.TxtPwd);
            this.Controls.Add(this.TxtLogin);
            this.Controls.Add(this.BtnConnexion);
            this.Controls.Add(this.LblPwd);
            this.Controls.Add(this.LblLogin);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmAuthentification";
            this.Text = "FrmAuthentification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblLogin;
        private System.Windows.Forms.Label LblPwd;
        private System.Windows.Forms.Button BtnConnexion;
        private System.Windows.Forms.TextBox TxtLogin;
        private System.Windows.Forms.TextBox TxtPwd;
    }
}