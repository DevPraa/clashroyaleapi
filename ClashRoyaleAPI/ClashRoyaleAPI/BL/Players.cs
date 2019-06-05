using ClashRoyaleAPI.Exceptions;
using ClashRoyaleAPI.Models.Players;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace ClashRoyaleAPI.BL
{
    public class Players
    {
        string _Url;
        public Players()
        {
            _Url = Path.Combine(Core.CurrentURL, "players/");
        }

        public Player GetPlayerInfo(string ID)
        {
            try
            {
                return Base.ApiReqest<Player>(_Url, ID: ID.Replace("#",""));
            }
            catch (ClashRoyaleAPIException ex)
            {
                throw ex;
            }
        }

        public UpcomingChests GetUpcomingChestsPlayer(string ID)
        {
            try
            {
                return Base.ApiReqest<UpcomingChests>(_Url, ID.Replace("#", ""), "/upcomingchests");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
