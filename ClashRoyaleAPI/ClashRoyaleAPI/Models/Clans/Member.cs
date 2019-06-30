using ClashRoyaleAPI.Models.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashRoyaleAPI.Models.Clans
{
    [Serializable]
    public class Member
    {
        public string tag { get; set; } //"#80UGRY9V8",
        public string name { get; set; } //"SuchPower",
        public string lastSeen { get; set; } //: "20190512T235522.000Z",
        public int expLevel { get; set; } //12,
        public int trophies { get; set; } //4852,
        public Arena arena { get; set; } //{
        public string role { get; set; } //string",
        public int clanRank { get; set; } //1,
        public int previousClanRank { get; set; } //1,
        public int donations { get; set; } //1040,
        public int donationsReceived { get; set; } //480,
        public int? clanChestPoints { get; set; } //138
    }

    [Serializable]
    public class ClanMembers
    {
        public Member[] items { get; set; }
    }
}
