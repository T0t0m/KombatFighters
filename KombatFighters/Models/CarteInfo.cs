namespace KombatFighters.Models
{
    public class CarteInfo
    {
        public int Id { get; set; }
        public string Titre { get; set; } = "NOUVELLE ATTAQUE";
        public int Degat { get; set; } = 0;
        public int Energie { get; set; } = 0;
        public string ImageUrl { get; set; } = "";
        public string CouleurFond { get; set; } = "";
        public bool EstSpeciale { get; set; } = false;
        public int[] GrilleAttaque { get; set; } = [0, 0, 0, 0, 0, 0, 0, 0, 0];
    }
}