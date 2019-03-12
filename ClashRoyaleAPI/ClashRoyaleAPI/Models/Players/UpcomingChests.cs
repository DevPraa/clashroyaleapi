using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashRoyaleAPI.Models.Players
{
    [Serializable]
    public class UpcomingChests
    {
        public Chest[] items { get; set; }
    }

    public class Chest
    {
        public int index { get; set; }
        public string name { get; set; }
    }
}
