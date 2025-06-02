using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace tp_examc_
{
    public class NoteDao
    {
        private List<Note> notes = new();
        private readonly string fichierCsv = "notes.csv";

        public NoteDao()
        {
            ChargerDepuisCsv();
        }

        private void ChargerDepuisCsv()
        {
            if (!File.Exists(fichierCsv))
                return;

            var lignes = File.ReadAllLines(fichierCsv);
            foreach (var ligne in lignes)
            {
                if (string.IsNullOrWhiteSpace(ligne)) continue;

                var donnees = ligne.Split(',');

                if (donnees.Length < 4) continue;

                Note note = new Note
                {
                    Id = int.Parse(donnees[0]),
                    EtudiantId = int.Parse(donnees[1]),
                    ModuleId = int.Parse(donnees[2]),
                    Valeur = double.Parse(donnees[3])
                };

                notes.Add(note);
            }
        }

        private void SauvegarderVersCsv()
        {
            var lignes = notes.Select(n =>
                $"{n.Id},{n.EtudiantId},{n.ModuleId},{n.Valeur}");
            File.WriteAllLines(fichierCsv, lignes);
        }

        public int GetNextId() => notes.Count == 0 ? 1 : notes.Max(n => n.Id) + 1;

        public void Ajouter(Note note)
        {
            note.Id = GetNextId();
            notes.Add(note);
            SauvegarderVersCsv();
        }

        public List<Note> GetNotesEtudiant(int etudiantId)
        {
            return notes.Where(n => n.EtudiantId == etudiantId).ToList();
        }
    }
}
