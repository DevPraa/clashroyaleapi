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
using ClashRoyaleClanMonitorWF.Models;

namespace ClashRoyaleClanMonitorWF.Controls.Main
{
    public partial class PlayerLeaveCW : MetroUserControl
    {
        public PlayerLeaveCW(PlayerWarLeave player)
        {
            InitializeComponent();
            mlbl_NickName.Text = player.Name;
            mlbl_Position.Text = player.role;
            lbl_WarOneBatCards.Text = (player.WarOneBatCards != null) ? player.WarOneBatCards.ToString() : "Не участв.";
            lbl_WarOneBattles.Text = (player.WarOneBattles != null) ? player.WarOneBattles.ToString() : "Не участв.";
            lbl_WarOneWins.Text = (player.WarOneWins != null) ? player.WarOneWins.ToString() : "Не участв.";
            lbl_WarTwoBatCards.Text = (player.WarTwoBatCards != null) ? player.WarTwoBatCards.ToString() : "Не участв.";
            lbl_WarTwoBattles.Text = (player.WarTwoBattles != null) ? player.WarTwoBattles.ToString() : "Не участв.";
            lbl_WarTwoWins.Text = (player.WarTwoWins != null) ? player.WarTwoWins.ToString() : "Не участв.";
        }
    }
}
