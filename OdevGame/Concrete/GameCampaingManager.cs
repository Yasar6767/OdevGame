using OdevGame;
using OdevGame.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewGame.Concrete
{
    public class GameCampaingManager:IGameCampingService 
    {
        public void Add(GameCampaing gameCampaing)
        {
            Console.WriteLine("The campaign has been added" + " " + gameCampaing.CampaingName);
        }

        public void Delete(GameCampaing gameCampaing)
        {
            Console.WriteLine("The campaign has been deleted" + " " + gameCampaing.CampaingName);
        }

        public void Update(GameCampaing gameCampaing)
        {
            Console.WriteLine("The campaign has been updated" + " " + gameCampaing.CampaingName);
        }
    }
}
