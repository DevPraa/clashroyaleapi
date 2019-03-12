using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashRoyaleAPI.Models.Clans
{
    public class CurrentWar
    {
        public string state { get; set; }
        public string warEndTime { get; set; }
        public StandingClan clan { get; set; }
        public Participant[] participants { get; set; }
        public StandingClan[] clans { get; set; }
    }
}
