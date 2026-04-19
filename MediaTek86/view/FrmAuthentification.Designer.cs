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
            this.LblLogin.Location = new System.Drawing.Point(38, 67);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(46, 16);
            this.LblLogin.TabIndex = 0;
            this.LblLogin.Text = "Login :";
            // 
            // LblPwd
            // 
            this.LblPwd.AutoSize = true;
            this.LblPwd.Location = new System.Drawing.Point(346, 67);
            this.LblPwd.Name = "LblPwd";
            this.LblPwd.Size = new System.Drawing.Size(96, 16);
            this.LblPwd.TabIndex = 1;
            this.LblPwd.Text = "Mot de Passe :";
            // 
            // BtnConnexion
            // 
            this.BtnConnexion.Location = new System.Drawing.Point(41, 155);
            this.BtnConnexion.Name = "BtnConnexion";
            this.BtnConnexion.Size = new System.Drawing.Size(98, 23);
            this.BtnConnexion.TabIndex = 2;
            this.BtnConnexion.Text = "Se connecter";
            this.BtnConnexion.UseVisualStyleBackColor = true;
            // 
            // TxtLogin
            // 
            this.TxtLogin.Location = new System.Drawing.Point(105, 64);
            this.TxtLogin.Name = "TxtLogin";
            this.TxtLogin.Size = new System.Drawing.Size(217, 22);
            this.TxtLogin.TabIndex = 3;
            // 
            // TxtPwd
            // 
            this.TxtPwd.Location = new System.Drawing.Point(458, 64);
            this.TxtPwd.Name = "TxtPwd";
            this.TxtPwd.Size = new System.Drawing.Size(217, 22);
            this.TxtPwd.TabIndex = 4;
            // 
            // FrmAuthentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 238);
            this.Controls.Add(this.TxtPwd);
            this.Controls.Add(this.TxtLogin);
            this.Controls.Add(this.BtnConnexion);
            this.Controls.Add(this.LblPwd);
            this.Controls.Add(this.LblLogin);
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