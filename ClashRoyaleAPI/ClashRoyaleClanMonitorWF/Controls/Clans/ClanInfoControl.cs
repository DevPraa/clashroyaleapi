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
        }
    }
}
