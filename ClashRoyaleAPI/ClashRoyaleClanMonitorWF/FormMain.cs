using ClashRoyaleAPI;
using ClashRoyaleAPI.BL;
using ClashRoyaleAPI.Exceptions;
using ClashRoyaleAPI.Models.Cards;
using ClashRoyaleAPI.Models.Clans;
using ClashRoyaleAPI.Models.Players;
using ClashRoyaleClanMonitorWF.Controls.Clans;
using ClashRoyaleClanMonitorWF.Controls.Main;
using ClashRoyaleClanMonitorWF.Controls.Settings;
using ClashRoyaleClanMonitorWF.Utils;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClashRoyaleClanMonitorWF
{
    public partial class FormMain : MetroForm
    {
        SettingsUC settingsUC = new SettingsUC();
        ClanCoreUC clanCoreUC;
        MainUC mainUC;
        Players player = new Players();
        Clans clan = new Clans();
        
        public FormMain()
        {
            InitializeComponent();
        }

        void LoadStaticResource()
        {
            try
            {
                if (!Directory.Exists(Program.PathImgCards))
                {
                    Directory.CreateDirectory(Program.PathImgCards);
                }
                string[] ImgTmp = Directory.GetFiles(Program.PathImgCards);

                #region Загрузка картинок из API
                Cards CardList = new Cards();                
                var img = CardList.GetAllCards();
                bool IsLoad = false;
                foreach (var item in img.items)
                {
                    if (ImgTmp.Length == 0)
                    {
                        IsLoad = true;
                    }
                    for (int i = 0; i < ImgTmp.Length; i++)
                    {
                        if (item.name == Path.GetFileName(ImgTmp[i].Replace(".png", "")))
                        {
                            IsLoad = false;
                            break;
                        }
                        IsLoad = true;
                    }
                    if (IsLoad)
                    {
                        using (WebClient client = new WebClient())
                        {
                            client.DownloadFile(item.iconUrls.medium, Path.Combine(Program.PathImgCards, $"{item.name}.png"));
                            ImgTmp = Directory.GetFiles(Program.PathImgCards);
                        }
                    }
                    IsLoad = false;
                }
                #endregion

                

                Program.ImgCards = new Models.LocalResource.ImageCardsOfDisk[ImgTmp.Length];
                for (int i = 0; i < ImgTmp.Length; i++)
                {
                    string CardName = Path.GetFileNameWithoutExtension(ImgTmp[i]);
                    Program.ImgCards[i] = new Models.LocalResource.ImageCardsOfDisk() { Img = Image.FromFile(ImgTmp[i]), Name = CardName, };
                }
                //CardHelper.GenerateXML(Program.ImgCards);
                LocalizationManager.Localize(Enums.Language.Ru, this);
                Program.LocalLanguage = Enums.Language.Ru;
            }
            catch (Exception e)
            {
                //throw;
            }
            //bgw_LoadData.ReportProgress(10, "Идет загрузка статических ресурсов...");

            //bgw_LoadData.ReportProgress(20, "Загрузка статических ресурсов завершена...");
        }


        async void LoadInfo()
        {
            try
            {
                ReportProgress(20, "Идет загрузка информации о игроке...");
                Program.MyPlayerProfile = await GetPlayerInfoWF(ClashRoyaleClanMonitorWF.Properties.Settings.Default.PlayerID);
                ReportProgress(30, "Идет загрузка информации о предстоящих сундуках...");
                Program.MyChests = await GetChestsInfoWF(Program.MyPlayerProfile.tag);//player.GetUpcomingChestsPlayer(PlayerInfo.tag);
                Program.ClanInfo = await GetClanInfoWF(Program.MyPlayerProfile.clan.tag);
                //ClashRoyaleClanMonitorWF.Controls.Players.PlayerInfo playerInfo = new ClashRoyaleClanMonitorWF.Controls.Players.PlayerInfo(0, MyPlayerProfile, MyChests);
                ReportProgress(40, "Идет загрузка информации о войнах...");
                Program.ClanWarLog = await GetClanWarLogWF(Program.MyPlayerProfile.clan.tag);
                ReportProgress(50, "Идет загрузка информации о клане...");
                Program.ClanMembers = await GetClanMembersInfoWF(Program.MyPlayerProfile.clan.tag); //clan.GetClanMembers(PlayerInfo.clan.tag);
                int value = (100 - Program.ClanMembers.items.Length);
                ReportProgress(value, "Идет загрузка информации о клане...");
                Program.ClanMembersDetailInfo = new Player[Program.ClanMembers.items.Length];
                Program.ClanMembersChests = new UpcomingChests[Program.ClanMembers.items.Length];
                for (int i = 0; i < Program.ClanMembers.items.Length; i++)
                {
                    Program.ClanMembersDetailInfo[i] = await GetPlayerInfoWF(Program.ClanMembers.items[i].tag);
                    Program.ClanMembersDetailInfo[i].trophies = Program.ClanMembers.items[i].trophies;
                    Program.ClanMembersDetailInfo[i].lastSeen = Program.ClanMembers.items[i].lastSeen;
                    Program.ClanMembersChests[i] = await GetChestsInfoWF(Program.ClanMembers.items[i].tag);
                    ReportProgress(value, $"Идет загрузка информации о {Program.ClanMembers.items[i].name}...");
                    value++;
                }
                ReportProgress(value, "Информация загружена...");
                if (mainUC != null)
                {
                    mainUC.Dispose();
                    mainUC = new MainUC();
                    mainUC.Dock = DockStyle.Fill;
                    MainPanel.Controls.Add(mainUC);
                }
                else
                {
                    mainUC = new MainUC();
                    mainUC.Dock = DockStyle.Fill;
                    MainPanel.Controls.Add(mainUC);
                }
                if (clanCoreUC !=null)
                {
                    clanCoreUC.Dispose();
                    clanCoreUC = new ClanCoreUC();
                    clanCoreUC.Dock = DockStyle.Fill;
                }
                else
                {
                    clanCoreUC = new ClanCoreUC();
                    clanCoreUC.Dock = DockStyle.Fill;
                }
                settingsUC.Dock = DockStyle.Fill;
            }
            catch (ClashRoyaleAPIException e)
            {
                MetroFramework.MetroMessageBox.Show(this, e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MetroFramework.MetroMessageBox.Show(this, e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            LoadInfo();
        }

        private void btn_Main_Click(object sender, EventArgs e)
        {
            //this.InvokeEx(() => {
            if (mainUC!=null)
            {
                MainPanel.Controls.Clear();
                MainPanel.Controls.Add(mainUC);
            }

            //});
            //MainPanel.Controls.Add(settingsUC);
        }

        private void btn_Clan_Click(object sender, EventArgs e)
        {
            if (clanCoreUC != null)
            {
                MainPanel.Controls.Clear();
                MainPanel.Controls.Add(clanCoreUC);
            }
            //MainPanel.InvokeEx(new Action(() => {

            //}));
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            if (settingsUC != null)
            {
                MainPanel.Controls.Clear();
                MainPanel.Controls.Add(settingsUC);
            }
            //this.InvokeEx(() => {

            //});
        }

        #region STYLES
        private void btn_Main_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeSidePanelPosition(btn_Main);
        }

        private void btn_Clan_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeSidePanelPosition(btn_Clan);
        }

        private void btn_Settings_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeSidePanelPosition(btn_Settings);
        }

        private void ChangeSidePanelPosition(Control control)
        {
            SidePanel.Height = control.Height;
            SidePanel.Top = control.Top;
        }
        #endregion

        #region System Methods
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void mpnl_LeftMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (downPoint == Point.Empty)
            {
                return;
            }
            Point location = new Point(
                this.Left + e.X - downPoint.X,
                this.Top + e.Y - downPoint.Y);
            this.Location = location;
        }

        private void mpnl_LeftMenu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            downPoint = new Point(e.X, e.Y);
        }

        private void mpnl_LeftMenu_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            downPoint = Point.Empty;
        }

        public Point downPoint = Point.Empty;

        private void MainPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            downPoint = Point.Empty;
        }

        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (downPoint == Point.Empty)
            {
                return;
            }
            Point location = new Point(
                this.Left + e.X - downPoint.X,
                this.Top + e.Y - downPoint.Y);
            this.Location = location;
        }

        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            downPoint = new Point(e.X, e.Y);
        }
        #endregion

        private void bgw_LoadData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
           var t = e.Result;
        }

        private void bgw_LoadData_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pgbar_Loading.Value = e.ProgressPercentage;
        }

        private void bgw_LoadData_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                bgw_LoadData.ReportProgress(0,"Идет загрузка информации...");
                
            }
            catch (Exception)
            {

            }
            e.Result = true;
        }

        private async void FormMain_Load(object sender, EventArgs e)
        {
            ReportProgress(0, "Идет загрузка статических ресурсов");
            LoadStaticResource();
            LoadInfo();
            //bgw_LoadData.RunWorkerAsync();
        }



        public async Task<Player> GetPlayerInfoWF(string ID)
        {
            return await Task.Factory.StartNew(() => { return player.GetPlayerInfo(ID); });
        }

        public async Task<UpcomingChests> GetChestsInfoWF(string ID)
        {
            return await Task.Factory.StartNew(() => { return player.GetUpcomingChestsPlayer(ID); });
        }

        public async Task<ClanMembers> GetClanMembersInfoWF(string ID)
        {
            return await Task.Factory.StartNew(() => {
                return clan.GetClanMembers(ID);            
            });
        }

        public async Task<ClashRoyaleAPI.Models.Clans.Clan> GetClanInfoWF(string ID)
        {
            return await Task.Factory.StartNew(() => {
                return clan.GetClanInfo(ID);
            });
        }

        public async Task<ClashRoyaleAPI.Models.Clans.Warlog> GetClanWarLogWF(string ID)
        {
            return await Task.Factory.StartNew(() => {
                return clan.GetClanWarLog(ID);
            });
        }

        private void ReportProgress(int value, string text)
        {
            pgbar_Loading.ProgressBarStyle = ProgressBarStyle.Continuous;
            pgbar_Loading.Value = value;
            mlbl_ProgressText.Text = text;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            LoadInfo();
        }
    }
}
