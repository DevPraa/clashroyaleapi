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

namespace ClashRoyaleClanMonitorWF.Controls.Clans
{
    public partial class ClanInfoControl : MetroUserControl
    {
        public ClanInfoControl()
        {
            InitializeComponent();
            mlbl_ClanDescription.Text = Program.ClanInfo.description;
            lbl_Trophies.Text = Program.ClanInfo.clanScore.ToString();
            lbl_RequiredTrophies.Text = Program.ClanInfo.requiredTrophies.ToString();
            lbl_Donations.Text = Program.ClanInfo.donationsPerWeek.ToString();
            lbl_ClanTrophies.Text = Program.ClanInfo.clanWarTrophies.ToString();
            mlbl_CurrentWarState.Text = $"Статус дня войны : {Program.ClanCurrentWar.state}";
            mlbl_Participants.Text = $"Участники {Program.ClanCurrentWar.clan.participants}";
            mlbl_battlesPlayed.Text = $"Сыграно боев {Program.ClanCurrentWar.clan.battlesPlayed}";
            mlbl_wins.Text = $"Побед {Program.ClanCurrentWar.clan.wins}";
            mlbl_crowns.Text = $"Корон {Program.ClanCurrentWar.clan.crowns}";
            LoadParticipants();
        }


        private void LoadParticipants()
        {
            for (int i = 0; i < Program.ClanCurrentWar.participants.Length; i++)
            {
                mgrd_Participants.Rows.Add(
                    Program.ClanCurrentWar.participants[i].tag,
                    Program.ClanCurrentWar.participants[i].name,
                    Program.ClanCurrentWar.participants[i].cardsEarned,
                    Program.ClanCurrentWar.participants[i].collectionDayBattlesPlayed,
                    Program.ClanCurrentWar.participants[i].numberOfBattles,
                    Program.ClanCurrentWar.participants[i].battlesPlayed,
                    Program.ClanCurrentWar.participants[i].wins
                    );
            }
            mgrd_Participants.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //mgrd_Participants.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.
            mgrd_Participants.Sort(mgrd_Participants.Columns[2], ListSortDirection.Descending);
        }
    }
}
