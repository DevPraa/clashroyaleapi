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
using ClashRoyaleAPI;
using ClashRoyaleClanMonitorWF.Properties;

namespace ClashRoyaleClanMonitorWF.Controls.Settings
{
    public partial class SettingsUC : MetroUserControl
    {

        public SettingsUC()
        {
            InitializeComponent();
            Core.Init(mtb_Token.Text, ClashRoyaleAPI.Enums.VersionAPI.v1);
            mtb_PlayerID.Text = ClashRoyaleClanMonitorWF.Properties.Settings.Default.PlayerID;
            mtb_Token.Text = ClashRoyaleClanMonitorWF.Properties.Settings.Default.Token;

        }

        private void mtb_PlayerID_TextChanged(object sender, EventArgs e)
        {
            ClashRoyaleClanMonitorWF.Properties.Settings.Default.PlayerID = mtb_PlayerID.Text;
            ClashRoyaleClanMonitorWF.Properties.Settings.Default.Save();
        }

        private void mtb_Token_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(mtb_Token.Text))
            {
                Core.Init(mtb_Token.Text, ClashRoyaleAPI.Enums.VersionAPI.v1);
                ClashRoyaleClanMonitorWF.Properties.Settings.Default.Token = mtb_Token.Text;
                ClashRoyaleClanMonitorWF.Properties.Settings.Default.Save();
            }
        }
    }
}
