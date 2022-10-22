using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerZ_Lib.Persistance
{
    public class RawPersistance : DefaultPersistance
    {

        internal List<GameLevel> GameLevels { get; set; }

        internal Game DefaulGame { get; set; }

        internal Rank DefaultRank { get; set; }

        internal Player DefaultPlayer { get; set; }

        public override void Init()
        {
            GameLevels = new List<GameLevel>();

            DefaulGame = new Game()
            {
                Name = "League of Legends",
                Description = "Jeu de type MOBA permettant d'incarner plus de 150 personnes",
                Note = 9.2M,
                TypeRank = Rank.TypeRanking.Tier,
                ImageCover = "lol_cover.png"
            };



            DefaultRank = new Rank()
            {
                TypeRank = Rank.TypeRanking.Tier,
                NameTier = "Silver IV",
                EloLevel = 0
            };

            GameLevels.Add(new GameLevel()
            {
                Game = DefaulGame,
                PlayingSince = DateTime.Now.AddYears(-10),
                Rank = DefaultRank
            });

            DefaultPlayer = new Player()
            {
                Age = 25,
                Name = "Corentin",
                Description = "Ma petite description de gamer de folie, on test pleins de trucs ici.",
                DiscordName = "Corentin#2064",
                CurrentSexe = Player.Sexe.Homme,
                LookingFor = Player.Sexe.Tous,
                Levels = GameLevels

            };
        }


        public override Player GetDefaultPlayer()
        {
            return DefaultPlayer;
        }

        
    }
}
