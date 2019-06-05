using ClashRoyaleClanMonitorWF.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ClashRoyaleClanMonitorWF.Utils
{
    public static class LocalizationManager
    {
        
        public static void Localize(Language Lng, object obj)
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(Path.Combine(Application.StartupPath, "Localization", $"{Lng.ToString()}.xml"));
            //xdoc.Load(Path.Combine(Application.StartupPath,"Localization",$"{Lng.ToString()}.xml"));
            //var t = xdoc.DocumentElement.FirstChild.ChildNodes;//.Item(10).Attributes.GetNamedItem("Name").Value;
            Program.LocalizationCard = xdoc.DocumentElement.FirstChild.ChildNodes;
            LocalizeCard(Lng);
        }

        private static void LocalizeCard(Language Lng)
        {
            for (int i = 0; i < Program.ImgCards.Length; i++)
            {
                for (int j = 0; j < Program.LocalizationCard.Count; j++)
                {
                    if (Program.ImgCards[i].Name == Program.LocalizationCard.Item(j).Attributes.GetNamedItem("Name").Value)
                    {
                        Program.ImgCards[i].Rare = Program.LocalizationCard.Item(j).Attributes.GetNamedItem("Rare").Value.StrToEnum<CardRare>();
                        Program.ImgCards[i].Type = Program.LocalizationCard.Item(j).Attributes.GetNamedItem("Type").Value.StrToEnum<CardType>();
                        Program.ImgCards[i].Cost = int.Parse(Program.LocalizationCard.Item(j).Attributes.GetNamedItem("Cost").Value);
                        if (Lng == Language.Ru)
                        {
                            Program.ImgCards[i].RusName = Program.LocalizationCard.Item(j).Attributes.GetNamedItem("RusName").Value;
                        }
                    }
                }                
            }
        }

    }
}
