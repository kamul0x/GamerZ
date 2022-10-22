using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerZ_Lib
{
    public class Rank
    {
        public enum TypeRanking
        {
            None = -1,
            Elo = 0,
            Tier = 2,
        }

        public TypeRanking TypeRank { get; set; }
        
        public decimal EloLevel { get; set; }

        public string NameTier { get; set; }

        public string GetRankLevel()
        {
            string ranking =  string.Empty;

           switch(TypeRank)
            {
                case TypeRanking.Elo:
                    ranking = string.Format("{0} pts",EloLevel);
                    break;
                case TypeRanking.Tier:
                    ranking = NameTier;
                    break;
            }

            return ranking;
        }
    }
}
