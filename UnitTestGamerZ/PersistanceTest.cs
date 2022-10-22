using GamerZ_Lib;
using GamerZ_Lib.Persistance;

namespace UnitTestGamerZ
{
    public class PersistanceTest
    {

        /// <summary>
        /// Default Test
        /// </summary>
        [Fact]
        public void Test1()
        {

        }

        [Fact]
        public void TestDefaultName()
        {
            DefaultPersistance persistance = new RawPersistance();
            persistance.Init();

            Player player = persistance.GetDefaultPlayer();

            Assert.Equal("Corentin", player.Name);
        }
    }
}