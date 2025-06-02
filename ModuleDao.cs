using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace tp_examc_
{
    public class ModuleDao
    {
        private List<Module> modules = new();
        private readonly string fichierCsv = "modules.csv";

        public ModuleDao()
        {
            ChargerDepuisCsv();
        }

        private void ChargerDepuisCsv()
        {
            if (!File.Exists(fichierCsv))
                return;

            var lignes = File.ReadAllLines(fichierCsv);

            bool isFirstLine = true; // 🔥 Ajouté pour sauter la première ligne

            foreach (var ligne in lignes)
            {
                if (isFirstLine)
                {
                    isFirstLine = false; // saute l'entête
                    continue;
                }

                if (string.IsNullOrWhiteSpace(ligne)) continue;

                var donnees = ligne.Split(',');

                if (donnees.Length < 2) continue;

                Module module = new Module
                {
                    Id = int.Parse(donnees[0]),
                    Nom = donnees[1]
                };

                modules.Add(module);
            }
        }

        public List<Module> GetAllModules()
        {
            return modules;
        }

        public Module? TrouverParId(int id)
        {
            return modules.FirstOrDefault(m => m.Id == id);
        }
    }
}
