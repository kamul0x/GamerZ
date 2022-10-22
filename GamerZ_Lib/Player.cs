namespace GamerZ_Lib
{
    // All the code in this file is included in all platforms.

    public class Player
    {
        public enum Sexe
        {
            Homme = 0,
            Femme = 1,
            Autre = 2,
            HommeEtAutre = 10,
            FemmeEtAutre = 20,
            HommeEtFemme = 30,
            Tous = -1,
        }


        public string Name { get; set; }

        public int Age { get; set; } 

        public string Description { get; set; }

        public string DiscordName { get; set; }

        public Sexe CurrentSexe { get; set; }

        public Sexe LookingFor { get; set; }

        public List<GameLevel> Levels { get; set; }


    }
}