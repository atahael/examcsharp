using System;
using System.Windows.Forms;

namespace tp_examc_
{
    public partial class FormLogin : Form
    {
        private UtilisateurDao utilisateurDao = new UtilisateurDao();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            Utilisateur? utilisateur = utilisateurDao.Authentifier(email, password);

            if (utilisateur == null)
            {
                MessageBox.Show("Email ou mot de passe incorrect.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (utilisateur is Admin)
            {
                FormAdmin adminForm = new FormAdmin();
                adminForm.Show();
            }
            else if (utilisateur is Enseignant)
            {
                FormEnseignant enseignantForm = new FormEnseignant();
                enseignantForm.Show();
            }
            else if (utilisateur is Etudiant etudiant)
            {
                FormEtudiant etudiantForm = new FormEtudiant(etudiant);
                etudiantForm.Show();
            }

            this.Hide();
        }
    }
}
