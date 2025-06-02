using System;
using System.Windows.Forms;

namespace tp_examc_
{
    public partial class FormAdmin : Form
    {
        private UtilisateurDao utilisateurDao = new UtilisateurDao();

        public FormAdmin()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            string nom = txtNom.Text.Trim();
            string prenom = txtPrenom.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string? role = cbRole.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Veuillez sélectionner un rôle.");
                return;
            }

            Utilisateur utilisateur = role == "Etudiant" ? new Etudiant() : new Enseignant();
            utilisateur.Nom = nom;
            utilisateur.Prenom = prenom;
            utilisateur.Email = email;
            utilisateur.MotDePasse = password;

            utilisateurDao.Ajouter(utilisateur);

            MessageBox.Show($"{role} ajouté avec succès.");
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
