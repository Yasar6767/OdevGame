using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevGame.Adapters
{
    public class EDevletServiceAdapter : IPlayerCheckService
    {
     
        public bool Check(Player player)
        {
            if (player.Id == 1 && player.FirstName == "Yaşar" && player.LastName == "Akat" && player.IdentıtyNumber == "12345678901")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
