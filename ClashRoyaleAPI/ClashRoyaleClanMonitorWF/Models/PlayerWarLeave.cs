using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashRoyaleClanMonitorWF.Models
{
    public class PlayerWarLeave
    {
        public string Name { get; set; }
        public string role { get; set; }
        public int? WarOneBatCards { get; set; }
        public int? WarOneBattles { get; set; }
        public int? WarOneWins { get; set; }
        public int? WarTwoBatCards { get; set; }
        public int? WarTwoBattles { get; set; }
        public int? WarTwoWins { get; set; }
    }
}
