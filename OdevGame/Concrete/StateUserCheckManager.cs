using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevGame.Abstract
{
    class StateUserCheckManager : IPlayerCheckService
    {
        public bool Check(Player player)
        {
            return true;
        }
    }
}
