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
            public string Name
            {
                get { return _Name; }
                set { _Name = value; }
            }
            public CardRare Rare { get; set; }
            public CardType Type { get; set; }
            public int Cost { get; set; }
            public int StartLvl { get { return CardHelper.GetStartLvl(Rare); } }
            public string RusName { get; set; }
            public string Description { get; set; }


        }
    }
}
