using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashRoyaleAPI.Models.Clans
{
    public class StandingClan
    {
        public string tag { get; set; } //"#2LUGU2UY",
        public string name { get; set; } //"EYE OF A TIGER",
        public int? badgeId { get; set; } //16000164,
        public int? clanScore { get; set; } //2097,
        public int? participants { get; set; } //36,
        public int? battlesPlayed { get; set; } //40,
        public int? wins { get; set; } //29,
        public int? crowns { get; set; } //48
    }
}
