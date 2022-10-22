using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerZ_Lib.Persistance
{
    public abstract class DefaultPersistance
    {
        public abstract void Init();

        public abstract Player GetDefaultPlayer();
    }
}
