using NewGame.Abstract;
using OdevGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewGame.Concrete
{
    class GameSellManager:IGameBuy
    {
        public void Add(Game games)
        {
            Console.WriteLine(games.GameName + "  The game has been added");
        }

        public void Delete(Game games)
        {
            Console.WriteLine(games.GameName + "  The game has been deleted");
        }

        public void Uptade(Game games)
        {
            Console.WriteLine(games.GameName + "  The game has been uptaded");
        }
    }
}
