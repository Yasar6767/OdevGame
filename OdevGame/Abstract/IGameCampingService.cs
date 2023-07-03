
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevGame
{
    public interface IGameCampingService
    {
        void Add(GameCampaing gameCampaing);
        void Delete(GameCampaing gameCampaing);
        void Update(GameCampaing gameCampaing);
    }
}
