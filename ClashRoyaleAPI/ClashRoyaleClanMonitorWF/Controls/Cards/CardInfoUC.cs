using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using ClashRoyaleClanMonitorWF.Enums;

namespace ClashRoyaleClanMonitorWF.Controls.Cards
{
    public partial class CardInfoUC : MetroUserControl
    {
        private CardRare _rare;
        private int _cost;

        public CardRare Rare { get => _rare; set => _rare = value; }

        public int Cost { get => _cost; set => _cost = value; }

        private int _Lvl;

        public int Lvl
        {
            get { return _Lvl; }
            set { _Lvl = value; }
        }


        public CardInfoUC(Image img, int Cardlvl, int CountCard, CardRare Rare, int cost)
        {
            InitializeComponent();
            _rare = Rare;
            _cost = cost;
            CardImg.Image = img;
            _Lvl = Cardlvl;
            lbl_Card_Lvl.Text = $"Ур. {Cardlvl}"; //Cardlvl.ToString();
            lbl_CountCard.Text = $"{CountCard}/{CardNeed(Rare, Cardlvl)}";
        }


        private int CardNeed(CardRare Rare, int Cardlvl)
        {
            int MaxLvl = 0;
            switch (Rare)
            {
                case CardRare.Common:
                    MaxLvl = 12;
                    if (Cardlvl == 13)
                    {
                        return 0;
                    }
                    break;
                case CardRare.Rare:
                    MaxLvl = 10;
                    if (Cardlvl == 13)
                    {
                        return 0;
                    }
                    break;
                case CardRare.Epic:
                    MaxLvl = 7;
                    if (Cardlvl == 13)
                    {
                        return 0;
                    }
                    break;
                case CardRare.Legendary:
                    MaxLvl = 4;
                    if (Cardlvl == 13)
                    {
                        return 0;
                    }
                    break;
                case CardRare.Unknown:
                    MaxLvl = 13;
                    if (Cardlvl == 13)
                    {
                        return 0;
                    }
                    break;
                default:
                    MaxLvl = 0;
                    if (Cardlvl == 13)
                    {
                        return 0;
                    }
                    break;
            }            
            return CardMass[(Cardlvl - (13 - MaxLvl))];
        }

        int[] CardMass = new int[] {2,4,10,20,50,100,200,400,800,1000,2000,5000};
    }
}
