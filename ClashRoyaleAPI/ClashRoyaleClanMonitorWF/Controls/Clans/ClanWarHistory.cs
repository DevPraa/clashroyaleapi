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
using ClashRoyaleClanMonitorWF.Utils;

namespace ClashRoyaleClanMonitorWF.Controls.Clans
{
    public partial class ClanWarHistory : MetroUserControl
    {
        int id = -1;
        public ClanWarHistory()
        {
            InitializeComponent();

            for (int i = 0; i < Program.ClanWarLog.items.Length; i++)
            {
                mgrd_ClanWarInfo.Rows.Add(i, Program.ClanWarLog.items[i].seasonId, Program.ClanWarLog.items[i].createdDate.ClashRoyaleDateToDateTime(), Program.ClanWarLog.items[i].participants.Length);
            }            
        }

        private void mgrd_ClanWarInfo_SelectionChanged(object sender, EventArgs e)
        {
            //Reset selected id
            id = -1;
            mgrd_Enemy.Rows.Clear();
            mgrd_ParticipantsOfWar.Rows.Clear();
            id = Convert.ToInt32(mgrd_ClanWarInfo.Rows[mgrd_ClanWarInfo.CurrentRow.Index].Cells[0].Value);
            if (id>=0)
            {
                for (int i = 0; i < Program.ClanWarLog.items[id].participants.Length; i++)
                {
                    mgrd_ParticipantsOfWar.Rows.Add(
                        Program.ClanWarLog.items[id].participants[i].tag,
                        Program.ClanWarLog.items[id].participants[i].name,
                        Program.ClanWarLog.items[id].participants[i].collectionDayBattlesPlayed,
                        Program.ClanWarLog.items[id].participants[i].cardsEarned,
                        Program.ClanWarLog.items[id].participants[i].numberOfBattles,
                        Program.ClanWarLog.items[id].participants[i].battlesPlayed,
                        Program.ClanWarLog.items[id].participants[i].wins
                        );
                }
                for (int i = 0; i < Program.ClanWarLog.items[id].standings.Length; i++)
                {
                    mgrd_Enemy.Rows.Add(
                        Program.ClanWarLog.items[id].standings[i].clan.tag,
                        Program.ClanWarLog.items[id].standings[i].clan.name,
                        Program.ClanWarLog.items[id].standings[i].clan.clanScore,
                        Program.ClanWarLog.items[id].standings[i].clan.participants,
                        Program.ClanWarLog.items[id].standings[i].clan.battlesPlayed,
                        Program.ClanWarLog.items[id].standings[i].clan.wins,
                        Program.ClanWarLog.items[id].standings[i].clan.crowns,
                        Program.ClanWarLog.items[id].standings[i].trophyChange
                        );
                }
            }
        }
    }
}
