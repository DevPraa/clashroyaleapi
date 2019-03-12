using CMC = ClashRoyaleAPI.Models.Clans;
using ClashRoyaleAPI.Models.Players;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static ClashRoyaleClanMonitorWF.Models.LocalResource;

namespace ClashRoyaleClanMonitorWF
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }

        public static string PathImgCards = Path.Combine(Application.StartupPath, "Images", "Cards");
        public static ImageCardsOfDisk[] ImgCards;//= new List<ImageCardsOfDisk>();
        public static Player MyPlayerProfile;
        public static UpcomingChests MyChests;
        public static CMC.Clan ClanInfo;
        public static CMC.ClanMembers ClanMembers;
        public static Player[] ClanMembersDetailInfo;
        public static UpcomingChests[] ClanMembersChests;
        public static CMC.Warlog ClanWarLog;
    }
}
