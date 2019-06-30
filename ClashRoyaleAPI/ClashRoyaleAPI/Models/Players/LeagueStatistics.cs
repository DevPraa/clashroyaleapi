using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashRoyaleAPI.Models.Players
{
    public class LeagueStatistics
    {
        public CurrentSeason currentSeason { get; set; }
    }
    public class CurrentSeason
    {
        public int trophies { get; set; } //": 4074,
        public int bestTrophies { get; set; } //": 4074
    }
}
