using System;
using System.Windows.Forms;

namespace tp_examc_
{
    public partial class FormEtudiant : Form
    {
        private NoteDao noteDao = new NoteDao();
        private ModuleDao moduleDao = new ModuleDao();
        private Etudiant etudiant;

        public FormEtudiant(Etudiant etu)
        {
            InitializeComponent();
            etudiant = etu;
            ChargerNotes();
        }

        private void ChargerNotes()
        {
            var modules = moduleDao.GetAllModules();
            var notes = noteDao.GetNotesEtudiant(etudiant.Id);

            foreach (var note in notes)
            {
                var module = modules.Find(m => m.Id == note.ModuleId);
                string matiere = module != null ? module.Nom : "Inconnu";

                ListViewItem item = new ListViewItem(matiere);
                item.SubItems.Add(note.Valeur.ToString());
                listViewNotes.Items.Add(item);
            }
        }
    }
}
