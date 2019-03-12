using ClashRoyaleAPI.Models.Clans;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashRoyaleAPI.BL
{
    public class Clans
    {
        string _Url;
        public Clans()
        {
            _Url = Path.Combine(Core.CurrentURL, "clans/");
        }


        public Clan GetClanInfo(string ID)
        {
            try
            {
                return  Base.ApiReqest<Clan>(_Url, ID: ID);
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public ClanMembers GetClanMembers(string ID)
        {
            try
            {
                return Base.ApiReqest<ClanMembers>(_Url, ID,"/members");
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.ToString());
                return null;
            }
        }


        public Warlog GetClanWarLog(string ID)
        {
            try
            {
                return Base.ApiReqest<Warlog>(_Url, ID, "/warlog");
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public CurrentWar GetClanCurrentWar(string ID)
        {
            try
            {
                return Base.ApiReqest<CurrentWar>(_Url, ID, "/currentwar");
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.ToString());
                return null;
            }
        }
    }
}
