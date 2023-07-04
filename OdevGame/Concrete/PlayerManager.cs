using OdevGame.Abstract;
using OdevGame.Adapters;
using System;

namespace OdevGame
{
    internal class PlayerManager: IPlayerService
    {
        EDevletServiceAdapter _eDevletServiceAdapter;

        public PlayerManager(EDevletServiceAdapter eDevletServiceAdapter)
        {
            _eDevletServiceAdapter = eDevletServiceAdapter;
        }

        public void Add(Player player)
        {
            if(_eDevletServiceAdapter.Check(player))
            {
                Console.WriteLine("Gamer to added" + " " + player.FirstName);
            }
            else
            {
                Console.WriteLine("Gamer to  not added" + " " + player.FirstName);
            }
        }

        public void Delete(Player player)
        {
            Console.WriteLine("Gamer to deleted" + " " + player.FirstName);
        }

        public void Update(Player player)
        {
            Console.WriteLine("Gamer to updated" + " " + player.FirstName);
        }
    }
}