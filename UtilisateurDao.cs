using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace tp_examc_
{
    public class UtilisateurDao
    {
        private List<Utilisateur> utilisateurs = new();
        private readonly string fichierCsv = "utilisateurs.csv";

        public UtilisateurDao()
        {
            ChargerDepuisCsv();
        }

        private void ChargerDepuisCsv()
        {
            if (!File.Exists(fichierCsv))
                return;

            var lignes = File.ReadAllLines(fichierCsv);
            bool premiereLigne = true; // 🔥 Pour ignorer l'entête

            foreach (var ligne in lignes)
            {
                if (premiereLigne)
                {
                    premiereLigne = false;
                    continue; // ignore l'entête
                }

                if (string.IsNullOrWhiteSpace(ligne)) continue;

                var donnees = ligne.Split(',');

                if (donnees.Length < 6) continue;

                if (!int.TryParse(donnees[0], out int id))
                    continue; // Skip invalid rows

                string role = donnees[1];
                string nom = donnees[2];
                string prenom = donnees[3];
                string email = donnees[4];
                string mdp = donnees[5];

                Utilisateur utilisateur = role switch
                {
                    "Admin" or "Administrateur" => new Admin(),
                    "Enseignant" => new Enseignant(),
                    "Etudiant" => new Etudiant(),
                    _ => throw new InvalidDataException($"Role inconnu : {role}")
                };

                utilisateur.Id = id;
                utilisateur.Nom = nom;
                utilisateur.Prenom = prenom;
                utilisateur.Email = email;
                utilisateur.MotDePasse = mdp;

                utilisateurs.Add(utilisateur);
            }
        }

        private void SauvegarderVersCsv()
        {
            // 🔥 On ajoute l'entête manuellement
            var lignes = new List<string> { "Id,Role,Nom,Prenom,Email,MotDePasse" };
            lignes.AddRange(utilisateurs.Select(u =>
                $"{u.Id},{u.Role},{u.Nom},{u.Prenom},{u.Email},{u.MotDePasse}"));
            File.WriteAllLines(fichierCsv, lignes);
        }

        public int GetNextId() => utilisateurs.Count == 0 ? 1 : utilisateurs.Max(u => u.Id) + 1;

        public void Ajouter(Utilisateur utilisateur)
        {
            utilisateur.Id = GetNextId();
            utilisateurs.Add(utilisateur);
            SauvegarderVersCsv();
        }

        public Utilisateur? Authentifier(string email, string motDePasse)
        {
            return utilisateurs.FirstOrDefault(u => u.Email.Equals(email, System.StringComparison.OrdinalIgnoreCase) && u.MotDePasse == motDePasse);
        }

        public List<Etudiant> GetEtudiants()
        {
            return utilisateurs.OfType<Etudiant>().ToList();
        }
    }
}
