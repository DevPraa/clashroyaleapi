using ClashRoyaleAPI.Exceptions;
using ClashRoyaleAPI.Models.Clans;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashRoyaleAPI.BL
{
    public class Clans : Base
    {
        string _Url;
        public Clans()
        {
            _Url = Path.Combine(Core.Instance.CurrentURL, "clans/");
        }


        public Clan GetClanInfo(string ID)
        {
            try
            {
                return  ApiReqest<Clan>(_Url, ID: ID);
            }
            catch (ClashRoyaleAPIException ex)
            {
                throw ex;
            }
            catch
            {
                return null;
            }
        }

        public ClanMembers GetClanMembers(string ID)
        {
            try
            {
                return ApiReqest<ClanMembers>(_Url, ID,"/members");
            }
            catch (ClashRoyaleAPIException ex)
            {
                throw ex;
            }
            catch
            {
                return null;
            }
        }

        public Warlog GetClanWarLog(string ID)
        {
            try
            {
                return ApiReqest<Warlog>(_Url, ID, "/warlog");
            }
            catch (ClashRoyaleAPIException ex)
            {
                throw ex;
            }
            catch
            {
                return null;
            }
        }

        public CurrentWar GetClanCurrentWar(string ID)
        {
            try
            {
                return ApiReqest<CurrentWar>(_Url, ID, "/currentwar");
            }
            catch (ClashRoyaleAPIException ex)
            {
                throw ex;
            }
            catch
            {
                return null;
            }
        }

        public async Task<ClanMembers> GetClanMembersInfoAsync(string ID)
        {
            return await Task.Factory.StartNew(() => {
                return GetClanMembers(ID);
            });
        }

        public async Task<Clan> GetClanInfoAsync(string ID)
        {
            return await Task.Factory.StartNew(() => {
                return GetClanInfo(ID);
            });
        }

        public async Task<Warlog> GetClanWarLogAsync(string ID)
        {
            return await Task.Factory.StartNew(() => {
                return GetClanWarLog(ID);
            });
        }

        public async Task<CurrentWar> GetCurrentClanWarAsync(string ID)
        {
            return await Task.Factory.StartNew(() => {
                return GetClanCurrentWar(ID);
            });
        }
    }
}
