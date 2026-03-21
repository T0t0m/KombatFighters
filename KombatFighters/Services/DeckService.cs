using KombatFighters.Models;

namespace KombatFighters.Services
{
    public class DeckService
    {
        public List<CarteInfo> MesCartes { get; private set; } = [];

        public void GenererDeckDeBase()
        {
            MesCartes.Clear();

            // Les 8 cartes fixes
            MesCartes.Add(new CarteInfo { Id = 1, Titre = "BAS", Degat = 0, Energie = 0, EstSpeciale = false, GrilleAttaque = [0, 0, 0, 0, 0, 1, 0, 0, 0] });
            MesCartes.Add(new CarteInfo { Id = 2, Titre = "DROITE", Degat = 0, Energie = 0, EstSpeciale = false, GrilleAttaque = [0, 0, 0, 0, 0, 0, 0, 1, 0] });
            MesCartes.Add(new CarteInfo { Id = 3, Titre = "GAUCHE", Degat = 0, Energie = 0, EstSpeciale = false, GrilleAttaque = [0, 1, 0, 0, 0, 0, 0, 0, 0] });
            MesCartes.Add(new CarteInfo { Id = 4, Titre = "HAUT", Degat = 0, Energie = 0, EstSpeciale = false, GrilleAttaque = [0, 0, 0, 1, 0, 0, 0, 0, 0] });
            MesCartes.Add(new CarteInfo { Id = 5, Titre = "PARADE", Degat = -15, Energie = 0, EstSpeciale = false, GrilleAttaque = [0, 0, 0, 0, 1, 0, 0, 0, 0] });
            MesCartes.Add(new CarteInfo { Id = 6, Titre = "MEGA PARADE", Degat = 0, Energie = 20, EstSpeciale = false, GrilleAttaque = [0, 0, 0, 0, 1, 0, 0, 0, 0] });
            MesCartes.Add(new CarteInfo { Id = 7, Titre = "REGENERATION", Degat = 0, Energie = +15, EstSpeciale = false, GrilleAttaque = [0, 0, 0, 0, 1, 0, 0, 0, 0] });
            MesCartes.Add(new CarteInfo { Id = 8, Titre = "BURST LIMIT", Degat = 80, Energie = 80, EstSpeciale = false, GrilleAttaque = [0, 0, 0, 0, 1, 0, 0, 0, 0] });

            // Les 4 cartes spéciales
            for (int i = 1; i <= 4; i++)
            {
                MesCartes.Add(new CarteInfo { Id = 8 + i, Titre = $"ATTAQUE SPÉCIALE {i}", EstSpeciale = true, GrilleAttaque = [0, 0, 0, 0, 0, 0, 0, 0, 0] });
            }
        }
    }
}