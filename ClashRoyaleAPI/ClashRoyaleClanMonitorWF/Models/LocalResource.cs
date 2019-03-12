using ClashRoyaleClanMonitorWF.Enums;
using ClashRoyaleClanMonitorWF.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashRoyaleClanMonitorWF.Models
{
    public class LocalResource
    {
        public class ImageCardsOfDisk
        {            
            string _Name;
            public Image Img { get; set; }
            public string Name { get {
                    return _Name;//.Replace(".png", "");
                } set { _Name = value; } }
            public CardRare Rare { get { return CardHelper.GetCardRare(Name); } }
            public CardType Type { get { return CardHelper.GetCardType(Name); } }
            public int Cost { get { return CardHelper.GetCardCost(Name); } }
            public int StartLvl { get { return CardHelper.GetStartLvl(Rare); } }
            public string Description { get; set; }


        }
    }
}
