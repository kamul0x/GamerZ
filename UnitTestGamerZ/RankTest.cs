using GamerZ_Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestGamerZLib
{
    public class RankTest
    {
        [Theory]
        [InlineData("180 pts",180)]
        public void GettingRankWithElo(string expected, decimal elo)
        {
            Rank myRank = new Rank()
            {
                TypeRank = Rank.TypeRanking.Elo,
                EloLevel = elo
            };

            Assert.Equal(expected, myRank.GetRankLevel());
        }

        [Theory]
        [InlineData("Silver II", "Silver II")]
        public void GettingRankWithTier(string expected, string elo)
        {
            Rank myRank = new Rank()
            {
                TypeRank = Rank.TypeRanking.Tier,
                NameTier = elo
            };

            Assert.Equal(expected, myRank.GetRankLevel());
        }

        [Fact]
        public void GettingRankWithNoRank()
        {
            Rank myRank = new Rank()
            {
                TypeRank = Rank.TypeRanking.None
            };

            Assert.Equal("", myRank.GetRankLevel());
        }

    }
}
