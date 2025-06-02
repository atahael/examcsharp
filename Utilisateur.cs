namespace tp_examc_
{
    public abstract class Utilisateur
    {
        public int Id { get; set; }
        public string Nom { get; set; } = "";
        public string Prenom { get; set; } = "";
        public string Email { get; set; } = "";
        public string MotDePasse { get; set; } = "";

        public abstract string Role { get; }
    }
}
