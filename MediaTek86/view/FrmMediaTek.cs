using MediaTek86.controller;
using MediaTek86.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaTek86.view
{
    /// <summary>
    /// Fenêtre principale : gère le personnel et leurs absences
    /// </summary>
    public partial class FrmMediaTek : Form
    {
        /// <summary>
        /// Objet pour gérer la liste du personnel
        /// </summary>
        private BindingSource bdgPersonnel = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des services
        /// </summary>
        private BindingSource bdgServices = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des absences
        /// </summary>
        private BindingSource bdgAbsences = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des motifs
        /// </summary>
        private BindingSource bdgMotifs = new BindingSource();
        /// <summary>
        /// Controleur de la fenêtre
        /// </summary>
        private FrmMediatekController controller;

        /// <summary>
        /// construction des composants graphiques et appel des autres initialisations
        /// </summary>
        /// 

        public FrmMediaTek()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// Initialisations :
        /// Création du controleur et remplissage des listes
        /// </summary>
        private void Init()
        {
            controller = new FrmMediatekController();
            RemplirListePersonnel();
            RemplirListeService();
            RemplirListeAbsences();
            RemplirListeMotif();
            EnCoursModifPersonnel(false);
            EnCoursModifAbsence(false);
        }

        /// <summary>
        /// Affiche le personnel
        /// </summary>
        private void RemplirListePersonnel()
        {
            List<Personnel> lePersonnel = controller.GetLePersonnel();
            bdgPersonnel.DataSource = lePersonnel;
            dgvPersonnel.DataSource = bdgPersonnel;
            dgvPersonnel.Columns["idpersonnel"].Visible = false;
            dgvPersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        /// <summary>
        /// Affiche les services
        /// </summary>
        private void RemplirListeService()
        {
            List<Service> lesServices = controller.GetLesServices();
            bdgServices.DataSource = lesServices;
            cboAjouterService.DataSource = bdgServices;
            cboModifierService.DataSource = bdgServices;
        }

        /// <summary>
        /// Affiche les absences
        /// </summary>
        private void RemplirListeAbsences()
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                int id = personnel.IdPersonnel;

                List<Absence> lesAbsences = controller.GetLesAbsences(id);
                bdgAbsences.DataSource = lesAbsences;
                dgvAbsences.DataSource = bdgAbsences;
                dgvAbsences.Columns["idpersonnel"].Visible = false;
            }
        }

        /// <summary>
        /// Affiche les motifs
        /// </summary>
        private void RemplirListeMotif()
        {
            List<Motif> lesMotifs = controller.GetLesMotifs();
            bdgMotifs.DataSource = lesMotifs;
            cboAjouterMotif.DataSource = bdgMotifs;
            cboModifierMotif.DataSource = bdgMotifs;
        }


        private void DgvPersonnel_SelectionChanged(object sender, EventArgs e)
        {
            RemplirListeAbsences();
        }

        /// <summary>
        ///  Demande de modification d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifierPersonnel_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                EnCoursModifPersonnel(true);
                Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                txtModifierNom.Text = personnel.Nom;
                txtModifierPrenom.Text = personnel.Prenom;
                txtModifierTel.Text = personnel.Tel;
                txtModifierMail.Text = personnel.Mail;
                cboModifierService.SelectedIndex = cboModifierService.FindStringExact(personnel.Service.Nom);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        /// <summary>
        ///  Demande de supression d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimerPersonnel_Click(object sender, EventArgs e)
        {

            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer " + personnel.Nom + " " + personnel.Prenom + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.DelPersonnel(personnel);
                    RemplirListePersonnel();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        /// <summary>
        ///  Enregistrement de l'ajout d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEnregAjouterPersonnel_Click(object sender, EventArgs e)
        {
            if (!txtAjouterNom.Text.Equals("") && !txtAjouterPrenom.Text.Equals("") && !txtAjouterTel.Text.Equals("") && !txtAjouterMail.Text.Equals("") && cboAjouterService.SelectedIndex != -1)
            {
                Service service = (Service)bdgServices.List[bdgServices.Position];

                Personnel personnel = new Personnel(0, txtAjouterNom.Text, txtAjouterPrenom.Text, txtAjouterTel.Text, txtAjouterMail.Text, service);
                controller.AddPersonnel(personnel);

                RemplirListePersonnel();
                txtAjouterNom.Text = "";
                txtAjouterPrenom.Text = "";
                txtAjouterTel.Text = "";
                txtAjouterMail.Text = "";
                cboAjouterService.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }

        private void BtnAnnulAjouterPersonnel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                txtAjouterNom.Text = "";
                txtAjouterPrenom.Text = "";
                txtAjouterTel.Text = "";
                txtAjouterMail.Text = "";
                cboAjouterService.SelectedIndex = -1;
            }
        }

        /// <summary>
        ///  Enregistrement de la modification d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEnregModifierPersonnel_Click(object sender, EventArgs e)
        {
            if (!txtModifierNom.Text.Equals("") && !txtModifierPrenom.Text.Equals("") && !txtModifierTel.Text.Equals("") && !txtModifierMail.Text.Equals("") && cboModifierService.SelectedIndex != -1)
            {
                if (dgvPersonnel.SelectedRows.Count > 0)
                {
                    Service service = (Service)bdgServices.List[bdgServices.Position];

                    Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                    personnel.Nom = txtModifierNom.Text;
                    personnel.Prenom = txtModifierPrenom.Text;
                    personnel.Tel = txtModifierTel.Text;
                    personnel.Mail = txtModifierMail.Text;
                    personnel.Service = service;
                    controller.UpdatePersonnel(personnel);

                    RemplirListePersonnel();
                    EnCoursModifPersonnel(false);
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner une ligne.", "Information");
                }
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }

        private void BtnAnnulModifierPersonnel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EnCoursModifPersonnel(false);
            }
        }

        /// <summary>
        /// Modification d'affichage suivant si on est ou non en cours de modif du personnel
        /// </summary>
        /// <param name="modif"></param>
        private void EnCoursModifPersonnel(Boolean modif)
        {
            grbModifierPersonnel.Enabled = modif;
            grbPersonnel.Enabled = !modif;
            grbAjouterPersonnel.Enabled = !modif;
            grbAbsences.Enabled = !modif;
            grbAjouterAbsence.Enabled = !modif;

            if (!modif)
            {
                txtModifierNom.Text = "";
                txtModifierPrenom.Text = "";
                txtModifierTel.Text = "";
                txtModifierMail.Text = "";
                cboModifierService.SelectedIndex = -1;
            }
        }

        /// <summary>
        ///  Demande de modification d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifierAbsence_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count > 0)
            {
                EnCoursModifAbsence(true);
                Absence absence = (Absence)bdgAbsences.List[bdgAbsences.Position];
                dtpModifierDateDebut.Value = absence.DateDebut;
                dtpModifierDateFin.Value = absence.DateFin;
                cboModifierMotif.SelectedIndex = cboModifierMotif.FindStringExact(absence.Motif.Libelle);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        /// <summary>
        ///  Demande de supression d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimerAbsence_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count > 0)
            {
                Absence absence = (Absence)bdgAbsences.List[bdgAbsences.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer cette absence ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.DelAbsence(absence);
                    RemplirListeAbsences();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        /// <summary>
        ///  Enregistrement de l'ajout d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEnregAjouterAbsence_Click(object sender, EventArgs e)
        {
            if (dtpAjouterDateDebut.Value < dtpAjouterDateFin.Value && cboAjouterMotif.SelectedIndex != -1)
            {
                Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                Motif motif = (Motif)bdgMotifs.List[bdgMotifs.Position];

                Absence absence = new Absence(personnel.IdPersonnel, dtpAjouterDateDebut.Value, dtpAjouterDateFin.Value, motif);
                controller.AddAbsence(absence);

                RemplirListeAbsences();
                dtpAjouterDateDebut.Value = DateTime.Today;
                dtpAjouterDateFin.Value = DateTime.Today;
                cboAjouterMotif.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Un motif doit être sélectionné et la date de début doit être antérieure à la date de fin.", "Information");
            }
        }

        private void BtnAnnulAjouterAbsence_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dtpAjouterDateDebut.Value = DateTime.Today;
                dtpAjouterDateFin.Value = DateTime.Today;
                cboAjouterMotif.SelectedIndex = -1;
            }
        }

        /// <summary>
        ///  Enregistrement de la modification d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEnregModifierAbsence_Click(object sender, EventArgs e)
        {
            if (dtpModifierDateDebut.Value < dtpModifierDateFin.Value && cboModifierMotif.SelectedIndex != -1)
            {
                if (dgvAbsences.SelectedRows.Count > 0)
                {
                    Motif motif = (Motif)bdgMotifs.List[bdgMotifs.Position];

                    Absence absence = (Absence)bdgAbsences.List[bdgAbsences.Position];
                    absence.DateDebut = dtpModifierDateDebut.Value;
                    absence.DateFin = dtpModifierDateFin.Value;
                    absence.Motif = motif;
                    controller.UpdateAbsence(absence);

                    RemplirListeAbsences();
                    EnCoursModifAbsence(false);
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner une ligne.", "Information");
                }
            }
            else
            {
                MessageBox.Show("Un motif doit être sélectionné et la date de début doit être antérieure à la date de fin.", "Information");
            }
        }

        private void BtnAnnulModifierAbsence_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EnCoursModifAbsence(false);
            }
        }

        /// <summary>
        /// Modification d'affichage suivant si on est ou non en cours de modif d'une absence
        /// </summary>
        /// <param name="modif"></param>
        private void EnCoursModifAbsence(Boolean modif)
        {
            grbModifierAbsence.Enabled = modif;
            grbAbsences.Enabled = !modif;
            grbAjouterAbsence.Enabled = !modif;
            grbPersonnel.Enabled = !modif;
            grbAjouterPersonnel.Enabled = !modif;
            dtpModifierDateDebut.Enabled = false;

            if (!modif)
            {
                dtpModifierDateDebut.Value = DateTime.Today;
                dtpModifierDateFin.Value = DateTime.Today;
                cboModifierMotif.SelectedIndex = -1;
            }
        }

    }
}
