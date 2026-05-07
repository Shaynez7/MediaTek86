using MediaTek86.controller;
using MediaTek86.model;
using MediaTek86.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaTek86.view
{
    /// <summary>
    /// Fenêtre d'authentification (seuls le responsable peut accéder à l'application)
    /// </summary>
    public partial class FrmAuthentification : Form
    {

        /// <summary>
        /// Contrôleur de la fenêtre
        /// </summary>
        private FrmAuthentificationController controller;

        /// <summary>
        /// Construction des composants graphiques et appel des autres initialisations
        /// </summary>
        public FrmAuthentification()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// Initialisations : 
        /// Création du controleur
        /// </summary>
        private void Init()
        {
            controller = new FrmAuthentificationController();
        }

        /// <summary>
        /// Demande au controleur de controler l'authentification
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnConnexion_Click(object sender, EventArgs e)
        {
            String login = TxtLogin.Text;
            String pwd = TxtPwd.Text;
            if (String.IsNullOrEmpty(login) ||  String.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
            else
            {
                Responsable responsable = new Responsable(login, pwd);
                if (controller.ControleAuthentification(responsable))
                {
                    FrmMediaTek frm = new FrmMediaTek();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Authentification incorrecte ou vous n'êtes pas le responsable", "Alerte");
                }
            }
        }
    }
}

