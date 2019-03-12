using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashRoyaleAPI.Models.Cards
{
    public class AllCards
    {
        public Сard[] items { get; set; }
    }

    public class Сard
    {
        public string name { get; set; } //": "Ice Wizard",
        public int level { get; set; } //": 2,
        public int maxLevel { get; set; } //": 5,
        public int count { get; set; } //": 1,
        public IconUrl iconUrls { get; set; } 
    }

    public class IconUrl
    {
        public string medium { get; set; } //"medium": "https://api-assets.clashroyale.com/cards/300/W3dkw0HTw9n1jB-zbknY2w3wHuyuLxSRIAV5fUT1SEY.png"
    }
}

