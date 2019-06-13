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
using ClashRoyaleClanMonitorWF.Controls.Players;
using ClashRoyaleClanMonitorWF.Utils;

namespace ClashRoyaleClanMonitorWF.Controls.Clans
{
    public partial class ClanCoreUC : MetroUserControl
    {

        PlayerInfo playerInfo;

        public ClanCoreUC()
        {
            InitializeComponent();
            if (Program.MyPlayerProfile != null)
            {
                Tile.Text = Program.MyPlayerProfile.clan.name;
            }
            if (Program.ClanMembersDetailInfo != null)
            {
                for (int i = 0; i < Program.ClanMembersDetailInfo.Length; i++)
                {
                    playerInfo = new PlayerInfo((i + 1), Program.ClanMembersDetailInfo[i], Program.ClanMembersChests[i]);
                    FLP_ClanMembers.Controls.Add(playerInfo);
                }
            }

            ClanInfoControl clanInfo = new ClanInfoControl();
            clanInfo.Dock = DockStyle.Fill;
            InformationTPage.Controls.Add(clanInfo);
            MainTabControl.SelectedTab = InformationTPage;
        }

        private void flowLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {
            this.InvokeEx(new Action(() => {
                foreach (var item in FLP_ClanMembers.Controls)
            {
                if (item is PlayerInfo)
                {
                    (item as PlayerInfo).CustomWidth = FLP_ClanMembers.Width - 25;
                }
            }
            }));
        }
    }
}
