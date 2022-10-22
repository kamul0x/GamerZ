using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerZ_Lib
{
    public class Game
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageCover { get; set; }

        public decimal Note { get; set; }

        public Rank.TypeRanking TypeRank { get; set; }
    }
}
