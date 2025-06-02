using System;
using System.Windows.Forms;

namespace tp_examc_
{
    public partial class FormEnseignant : Form
    {
        private NoteDao noteDao = new NoteDao();
        private UtilisateurDao utilisateurDao = new UtilisateurDao();
        private ModuleDao moduleDao = new ModuleDao();

        public FormEnseignant()
        {
            InitializeComponent();
            ChargerEtudiants();
            ChargerModules();
        }

        private void ChargerEtudiants()
        {
            var etudiants = utilisateurDao.GetEtudiants();
            cbEtudiants.DataSource = etudiants;
            cbEtudiants.DisplayMember = "Nom"; // Ce qui est affiché
            cbEtudiants.ValueMember = "Id";    // Ce qu'on utilise (l'Id)
        }

        private void ChargerModules()
        {
            var modules = moduleDao.GetAllModules();
            cbModules.DataSource = modules;
            cbModules.DisplayMember = "Nom"; // Ce qui est affiché
            cbModules.ValueMember = "Id";    // Ce qu'on utilise (l'Id)
        }

        private void btnAjouterNote_Click(object sender, EventArgs e)
        {
            if (cbEtudiants.SelectedItem == null || cbModules.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un étudiant et un module.");
                return;
            }

            Etudiant etudiant = (Etudiant)cbEtudiants.SelectedItem;
            Module module = (Module)cbModules.SelectedItem;

            if (!double.TryParse(txtNote.Text.Trim(), out double valeur))
            {
                MessageBox.Show("Note invalide.");
                return;
            }

            Note note = new Note
            {
                EtudiantId = etudiant.Id,
                ModuleId = module.Id,
                Valeur = valeur
            };

            noteDao.Ajouter(note);

            MessageBox.Show($"Note ajoutée pour {etudiant.Nom} {etudiant.Prenom} en {module.Nom}.");
        }
    }
}
