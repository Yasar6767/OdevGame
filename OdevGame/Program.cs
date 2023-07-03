
using NewGame.Concrete;
using OdevGame.Abstract;
using OdevGame.Adapters;
using System;
using System.Collections.Generic;

namespace OdevGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.Id = 1;
            player1.FirstName = "Yaşar";
            player1.LastName = "Akat";
            player1.IdentıtyNumber = "12345678901";
            player1.BirthYear = 1992;


            Player player2 = new Player();
            player2.Id = 2;
            player2.FirstName = "Elif";
            player2.LastName = "Akat";
            player2.IdentıtyNumber = "45680375478";
            player2.BirthYear = 1991;

            PlayerManager playerManager = new PlayerManager(new EDevletServiceAdapter());
            playerManager.Add(player1);
            playerManager.Update(player2);

            Game game1 = new Game();
            game1.GameName = "FIFA 2023";
            game1.Price = 2000;


            Game game2 = new Game();
            game2.GameName = "PES 2023";
            game2.Price = 1800;

            GameSellManager gameSellManager = new GameSellManager();
            gameSellManager.Add(game2);
            

            GameCampaing gameCampaing = new GameCampaing();
            gameCampaing.CampaingId = 1;
            gameCampaing.CampaingName = "Futbol Şenliği";
            gameCampaing.DiscountRate = 20;

            GameCampaingManager gameCampaingManager = new GameCampaingManager();
            gameCampaingManager.Add(gameCampaing);

            Console.ReadLine();
        }
    }
}
