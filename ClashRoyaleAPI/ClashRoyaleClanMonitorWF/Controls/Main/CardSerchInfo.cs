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
using ClashRoyaleAPI.Models.Players;

namespace ClashRoyaleClanMonitorWF.Controls.Main
{
    public partial class CardSearchInfo : MetroUserControl
    {
        public CardSearchInfo(string player, int Cardlvl, int CardCount)
        {
            InitializeComponent();
            mlbl_NickName.Text = player;
            lbl_Cardlvl.Text = $"Ур. {Cardlvl}";
            mlbl_CardCount.Text = $"Кол-во {CardCount}";
        }
    }
}
