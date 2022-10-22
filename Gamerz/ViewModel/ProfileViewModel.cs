using GamerZ_Lib;
using GamerZ_Lib.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamerz.ViewModel
{
    internal class ProfileViewModel
    {
        public Player Player { get; set; }

        public ProfileViewModel()
        {
            DefaultPersistance persistance = new RawPersistance();
            persistance.Init();

            Player = persistance.GetDefaultPlayer();
        }

    }
}
