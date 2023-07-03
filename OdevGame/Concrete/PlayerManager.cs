using OdevGame.Abstract;
using OdevGame.Adapters;
using System;

namespace OdevGame
{
    internal class PlayerManager: IPlayerService
    {
        private EDevletServiceAdapter eDevletServiceAdapter;

        public PlayerManager(EDevletServiceAdapter eDevletServiceAdapter)
        {
            this.eDevletServiceAdapter = eDevletServiceAdapter;
        }

        public void Add(Player player)
        {
            Console.WriteLine("Gamer to added" + " " +player.FirstName);
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