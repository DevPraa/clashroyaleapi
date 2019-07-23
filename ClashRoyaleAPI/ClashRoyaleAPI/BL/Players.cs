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
    public class Players : Base
    {
        string _Url;
        public Players()
        {
            _Url = Path.Combine(Core.Instance.CurrentURL, "players/");
        }

        public Player GetPlayerInfo(string ID)
        {
            try
            {
                return ApiReqest<Player>(_Url, ID: ID.Replace("#",""));
            }
            catch (ClashRoyaleAPIException ex)
            {
                throw ex;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public UpcomingChests GetUpcomingChestsPlayer(string ID)
        {
            try
            {
                return ApiReqest<UpcomingChests>(_Url, ID.Replace("#", ""), "/upcomingchests");
            }
            catch (ClashRoyaleAPIException ex)
            {
                throw ex;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Player> GetPlayerInfoAsync(string ID)
        {
            return await Task.Factory.StartNew(() => { return GetPlayerInfo(ID); });
        }

        public async Task<UpcomingChests> GetChestsInfoAsync(string ID)
        {
            return await Task.Factory.StartNew(() => { return GetUpcomingChestsPlayer(ID); });
        }
    }
}
