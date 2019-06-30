using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashRoyaleAPI.Models.Players
{
    public class Achievements
    {
        public string name { get; set; } //": "Team Player",
        public int stars { get; set; } //": 3,
        public int value { get; set; } // 7,
        public int target { get; set; } //": 1,
        public string info { get; set; } //": "Join a Clan"
    }
}
