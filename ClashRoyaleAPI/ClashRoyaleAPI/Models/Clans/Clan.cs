using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashRoyaleAPI.Models.Clans
{
    public class Clan
    {
        public string tag { get; set; } //"#2LUGU2UY",
        public string name { get; set; } //"EYE OF A TIGER",
        public string type { get; set; } //"open",
        public string description { get; set; } //"Здоров! Заходи располагайся! Обязательно участвовать в войне кланов! Продинамил 2 отбора подряд- офф! Не провел бой в войне офф!",  
        public int badgeId { get; set; } //16000164
        public int clanScore { get; set; } //43442,
        public int clanWarTrophies { get; set; }
        public Location location { get; set; }
        public int requiredTrophies { get; set; } //4000,
        public int donationsPerWeek { get; set; } //11556,
        public string clanChestStatus { get; set; } //"inactive",
        public int clanChestPoints { get; set; } //1600,
        public int clanChestLevel { get; set; } //10,
        public int clanChestMaxLevel { get; set; } //10,
        public int members { get; set; } //50,
        public Member[] memberList { get; set; }
    }
}
