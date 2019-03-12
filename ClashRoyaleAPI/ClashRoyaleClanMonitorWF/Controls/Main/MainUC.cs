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
using ClashRoyaleClanMonitorWF.Properties;
using System.Diagnostics;
using ClashRoyaleClanMonitorWF.Models;

namespace ClashRoyaleClanMonitorWF.Controls.Main
{
    public partial class MainUC : MetroUserControl
    {
        PictureBox[] pboxList;
        Label[] labellist;


        public MainUC()
        {
            InitializeComponent();
            //long before = GC.GetTotalMemory(false);
            // ваш код тут
            //long after = GC.GetTotalMemory(false);

            if (Program.MyPlayerProfile != null)
            {
                NickName.Text = Program.MyPlayerProfile.name;
                mlbl_Tag.Text = Program.MyPlayerProfile.tag;
                mlbl_MaxTrophies.Text = Program.MyPlayerProfile.bestTrophies.ToString();
                mlbl_Trophies.Text = Program.MyPlayerProfile.trophies.ToString();
                mlbl_Wins.Text = Program.MyPlayerProfile.wins.ToString();
                mlbl_Losses.Text = Program.MyPlayerProfile.losses.ToString();
                mlbl_WinThreeCrown.Text = Program.MyPlayerProfile.threeCrownWins.ToString();
                mlbl_AllDonation.Text = Program.MyPlayerProfile.totalDonations.ToString();
                mlbl_WinsOnWarDay.Text = Program.MyPlayerProfile.warDayWins.ToString();
                mlbl_GetWarCards.Text = Program.MyPlayerProfile.clanCardsCollected.ToString();
                mlbl_ChallengesMaxWins.Text = Program.MyPlayerProfile.challengeMaxWins.ToString();
                mlbl_ChallengesCardWin.Text = Program.MyPlayerProfile.challengeCardsWon.ToString();
                mlbl_ChallengesBattle.Text = Program.MyPlayerProfile.battleCount.ToString();
                ArenaSwitch(Program.MyPlayerProfile.arena.id);
                mlbl_LvlPlayer.Text = Program.MyPlayerProfile.expLevel.ToString();
            }
            if (Program.ClanInfo != null)
            {
                mlbl_ClanName.Text = Program.ClanInfo.name;
                mlbl_ClanScore.Text = Program.ClanInfo.clanScore.ToString();
                mlbl_ClanDonation.Text = Program.ClanInfo.donationsPerWeek.ToString();
                mlbl_ClanMembers.Text = Program.ClanInfo.members.ToString();
            }
            ChestSwitch();

            if (Program.ClanWarLog != null)
            {
                var Members = (from MemberList in Program.ClanMembersDetailInfo
                               from ClanWarOne in Program.ClanWarLog.items[0].participants
                              .Where(CWO=> CWO?.tag == MemberList?.tag).DefaultIfEmpty()
                               from ClanWarTwo in Program.ClanWarLog.items[1].participants
                              .Where(CWT => CWT?.tag == MemberList?.tag).DefaultIfEmpty()
                               select new PlayerWarLeave
                              {
                                   Name = MemberList?.name,
                                   role = PositionSwitch(MemberList?.role),
                                  WarOneBatCards = ClanWarOne?.collectionDayBattlesPlayed,
                                  WarOneBattles = ClanWarOne?.battlesPlayed,
                                  WarOneWins = ClanWarOne?.wins,
                                  WarTwoBatCards = ClanWarTwo?.collectionDayBattlesPlayed,
                                  WarTwoBattles = ClanWarTwo?.battlesPlayed,
                                  WarTwoWins = ClanWarTwo?.wins,
                              }).Where(c=>  (c.WarOneBatCards == null || c.WarOneBatCards < 3 || c.WarOneBattles == 0 ) && (c.WarTwoBatCards == null || c.WarTwoBatCards < 3) ||  c.WarTwoBattles == 0).ToList();

                if (Members != null)
                {
                    foreach (var item in Members)
                    {
                        PlayerLeaveCW playerLeaveCW = new PlayerLeaveCW(item);
                        FLP_PlayersNotPlayed.Controls.Add(playerLeaveCW);
                    }
                }
                //Program.ClanWarLog.items[1].participants;
                //Program.ClanWarLog.items[2].participants;
                //FLP_PlayersNotPlayed.Controls.Add();
            }
        }

        private string PositionSwitch(string Position)
        {
            switch (Position)
            {
                case "leader": return "Глава";
                case "coLeader": return "Сорук.";
                case "elder": return "Старейш.";
                case "member": return "Участ.";
                default:
                    return "Участ.";
            }
        }
        private void ChestSwitch()
        {
            if (Program.MyChests != null)
            {
                CustomInitializeComponent();
                #region Pbox List
                pboxList = new PictureBox[14];
                pboxList[0] = pbox_Chest1;
                pboxList[1] = pbox_Chest2;
                pboxList[2] = pbox_Chest3;
                pboxList[3] = pbox_Chest4;
                pboxList[4] = pbox_Chest5;
                pboxList[5] = pbox_Chest6;
                pboxList[6] = pbox_Chest7;
                pboxList[7] = pbox_Chest8;
                pboxList[8] = pbox_Chest9;
                pboxList[9] = pbox_Chest10;
                pboxList[10] = pbox_Chest11;
                pboxList[11] = pbox_Chest12;
                pboxList[12] = pbox_Chest13;
                pboxList[13] = pbox_Chest14;
                #endregion
                #region Lbl CHest List
                labellist = new Label[14];
                labellist[0] = lbl_Chest1;
                labellist[1] = lbl_Chest2;
                labellist[2] = lbl_Chest3;
                labellist[3] = lbl_Chest4;
                labellist[4] = lbl_Chest5;
                labellist[5] = lbl_Chest6;
                labellist[6] = lbl_Chest7;
                labellist[7] = lbl_Chest8;
                labellist[8] = lbl_Chest9;
                labellist[9] = lbl_Chest10;
                labellist[10] = lbl_Chest11;
                labellist[11] = lbl_Chest12;
                labellist[12] = lbl_Chest13;
                labellist[13] = lbl_Chest14;
                #endregion
                int count = ((Program.MyChests.items.Length > 14) ? 14 : Program.MyChests.items.Length);
                for (int i = 0; i < count; i++)
                {
                    labellist[i].Text = (Program.MyChests.items[i].index + 1).ToString();
                    pboxList[i].Image = ChestImage(Program.MyChests.items[i].name);
                }
                pboxList = null;
                labellist = null;
            }

        }

        private Image ChestImage(string ChestName)
        {
            switch (ChestName)
            {
                case "Silver Chest": return Resources.silver_chest;
                case "Golden Chest": return Resources.gold_chest;
                case "Magical Chest": return Resources.magical_chest;
                case "Epic Chest": return Resources.epic_chest;
                case "Giant Chest": return Resources.giant_chest;
                case "Legendary Chest": return Resources.legendary_chest;
                case "Super Magical Chest": return Resources.super_magical_chest;
                default:
                    return Resources.silver_chest;
            }
        }

        private void ArenaSwitch(int ArenaID)
        {
            switch (ArenaID)
            {
                case 54000011: pbox_League.Image = Resources.league_0; break;
                case 54000012: pbox_League.Image = Resources.league_1; break;
                case 54000013: pbox_League.Image = Resources.league_2; break;
                case 54000014: pbox_League.Image = Resources.league_3; break;
                case 54000015: pbox_League.Image = Resources.league_4; break;
                case 54000016: pbox_League.Image = Resources.league_5; break;
                case 54000017: pbox_League.Image = Resources.league_6; break;
                case 54000018: pbox_League.Image = Resources.league_7; break;
                case 54000019: pbox_League.Image = Resources.league_8; break;
                case 54000020: pbox_League.Image = Resources.league_9; break;
                default:
                    pbox_League.Image = Resources.league_0;
                    break;
            }
        }

        private void mtb_SearchCard_ButtonClick(object sender, EventArgs e)
        {
            FLP_CardSearch.Controls.Clear();
            if (Program.ClanMembersDetailInfo != null)
            {
                //var t = _PlayerListInfo.Select(c => new { c.name, c.cards });//.Where(card => card.name == mtb_SearchCard.Text).ToList();
                //var T = player.GetPlayerInfo(PersonOnClan[i]);
                
                foreach (var item in Program.ClanMembersDetailInfo)
                {
                    var Card = item.cards.Where(c => c.name == mtb_SearchCard.Text).FirstOrDefault();
                    if (Card != null)
                    {
                        int lvl = Card.level + Utils.CardHelper.GetStartLvl(Utils.CardHelper.GetCardRare(Card.name));
                        var rare = Utils.CardHelper.GetCardRare(Card.name);
                        switch (rare)
                        {
                            case Enums.CardRare.Common:
                                {
                                    if (Card.count > 250)
                                    {
                                        CardSearchInfo cardSearchInfo = new CardSearchInfo(item.name, lvl, Card.count);
                                        FLP_CardSearch.Controls.Add(cardSearchInfo);
                                    }
                                }
                                break;
                            case Enums.CardRare.Rare:
                                {
                                    if (Card.count > 50)
                                    {
                                        CardSearchInfo cardSearchInfo = new CardSearchInfo(item.name, lvl, Card.count);
                                        FLP_CardSearch.Controls.Add(cardSearchInfo);
                                    }
                                }
                                break;
                            case Enums.CardRare.Epic:
                                {
                                    if (Card.count > 10)
                                    {
                                        CardSearchInfo cardSearchInfo = new CardSearchInfo(item.name, lvl, Card.count);
                                        FLP_CardSearch.Controls.Add(cardSearchInfo);
                                    }
                                }
                                break;
                            case Enums.CardRare.Legendary:
                                {
                                    if ((lvl == 9 && Card.count == 1))
                                    {

                                    }
                                    else
                                    {
                                        if (Card.count > 0)
                                        {
                                            CardSearchInfo cardSearchInfo = new CardSearchInfo(item.name, lvl, Card.count);
                                            FLP_CardSearch.Controls.Add(cardSearchInfo);
                                        }

                                    }
                                }
                                break;
                            case Enums.CardRare.Unknown:
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Прогрузка дополнительных контролов для отображения сундуков
        /// </summary>
        private void CustomInitializeComponent()
        {
            this.lbl_Chest14 = new System.Windows.Forms.Label();
            this.lbl_Chest13 = new System.Windows.Forms.Label();
            this.lbl_Chest12 = new System.Windows.Forms.Label();
            this.lbl_Chest11 = new System.Windows.Forms.Label();
            this.lbl_Chest10 = new System.Windows.Forms.Label();
            this.lbl_Chest9 = new System.Windows.Forms.Label();
            this.lbl_Chest8 = new System.Windows.Forms.Label();
            this.lbl_Chest7 = new System.Windows.Forms.Label();
            this.lbl_Chest6 = new System.Windows.Forms.Label();
            this.lbl_Chest5 = new System.Windows.Forms.Label();
            this.lbl_Chest4 = new System.Windows.Forms.Label();
            this.lbl_Chest3 = new System.Windows.Forms.Label();
            this.lbl_Chest2 = new System.Windows.Forms.Label();
            this.lbl_Chest1 = new System.Windows.Forms.Label();
            this.pbox_Chest14 = new System.Windows.Forms.PictureBox();
            this.pbox_Chest13 = new System.Windows.Forms.PictureBox();
            this.pbox_Chest12 = new System.Windows.Forms.PictureBox();
            this.pbox_Chest11 = new System.Windows.Forms.PictureBox();
            this.pbox_Chest9 = new System.Windows.Forms.PictureBox();
            this.pbox_Chest10 = new System.Windows.Forms.PictureBox();
            this.pbox_Chest8 = new System.Windows.Forms.PictureBox();
            this.pbox_Chest7 = new System.Windows.Forms.PictureBox();
            this.pbox_Chest6 = new System.Windows.Forms.PictureBox();
            this.pbox_Chest5 = new System.Windows.Forms.PictureBox();
            this.pbox_Chest4 = new System.Windows.Forms.PictureBox();
            this.pbox_Chest3 = new System.Windows.Forms.PictureBox();
            this.pbox_Chest1 = new System.Windows.Forms.PictureBox();
            this.pbox_Chest2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Chest14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Chest13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Chest12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Chest11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Chest9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Chest10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Chest8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Chest7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Chest6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Chest5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Chest4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Chest3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Chest1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Chest2)).BeginInit();
            this.SuspendLayout();

            // 
            // lbl_Chest14
            // 
            this.lbl_Chest14.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_Chest14.BackColor = System.Drawing.Color.White;
            this.lbl_Chest14.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Chest14.Location = new System.Drawing.Point(570, 534);
            this.lbl_Chest14.Name = "lbl_Chest14";
            this.lbl_Chest14.Size = new System.Drawing.Size(36, 16);
            this.lbl_Chest14.TabIndex = 82;
            this.lbl_Chest14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Chest13
            // 
            this.lbl_Chest13.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_Chest13.BackColor = System.Drawing.Color.White;
            this.lbl_Chest13.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Chest13.Location = new System.Drawing.Point(528, 534);
            this.lbl_Chest13.Name = "lbl_Chest13";
            this.lbl_Chest13.Size = new System.Drawing.Size(36, 16);
            this.lbl_Chest13.TabIndex = 81;
            this.lbl_Chest13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Chest12
            // 
            this.lbl_Chest12.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_Chest12.BackColor = System.Drawing.Color.White;
            this.lbl_Chest12.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Chest12.Location = new System.Drawing.Point(486, 534);
            this.lbl_Chest12.Name = "lbl_Chest12";
            this.lbl_Chest12.Size = new System.Drawing.Size(36, 16);
            this.lbl_Chest12.TabIndex = 80;
            this.lbl_Chest12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Chest11
            // 
            this.lbl_Chest11.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_Chest11.BackColor = System.Drawing.Color.White;
            this.lbl_Chest11.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Chest11.Location = new System.Drawing.Point(444, 534);
            this.lbl_Chest11.Name = "lbl_Chest11";
            this.lbl_Chest11.Size = new System.Drawing.Size(36, 16);
            this.lbl_Chest11.TabIndex = 79;
            this.lbl_Chest11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Chest10
            // 
            this.lbl_Chest10.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_Chest10.BackColor = System.Drawing.Color.White;
            this.lbl_Chest10.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Chest10.Location = new System.Drawing.Point(402, 534);
            this.lbl_Chest10.Name = "lbl_Chest10";
            this.lbl_Chest10.Size = new System.Drawing.Size(36, 16);
            this.lbl_Chest10.TabIndex = 78;
            this.lbl_Chest10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Chest9
            // 
            this.lbl_Chest9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_Chest9.BackColor = System.Drawing.Color.White;
            this.lbl_Chest9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Chest9.Location = new System.Drawing.Point(360, 534);
            this.lbl_Chest9.Name = "lbl_Chest9";
            this.lbl_Chest9.Size = new System.Drawing.Size(36, 16);
            this.lbl_Chest9.TabIndex = 77;
            this.lbl_Chest9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Chest8
            // 
            this.lbl_Chest8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_Chest8.BackColor = System.Drawing.Color.White;
            this.lbl_Chest8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Chest8.Location = new System.Drawing.Point(318, 534);
            this.lbl_Chest8.Name = "lbl_Chest8";
            this.lbl_Chest8.Size = new System.Drawing.Size(36, 16);
            this.lbl_Chest8.TabIndex = 76;
            this.lbl_Chest8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Chest7
            // 
            this.lbl_Chest7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_Chest7.BackColor = System.Drawing.Color.White;
            this.lbl_Chest7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Chest7.Location = new System.Drawing.Point(278, 534);
            this.lbl_Chest7.Name = "lbl_Chest7";
            this.lbl_Chest7.Size = new System.Drawing.Size(32, 16);
            this.lbl_Chest7.TabIndex = 75;
            this.lbl_Chest7.Text = "4025";
            this.lbl_Chest7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Chest6
            // 
            this.lbl_Chest6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_Chest6.BackColor = System.Drawing.Color.White;
            this.lbl_Chest6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Chest6.Location = new System.Drawing.Point(236, 534);
            this.lbl_Chest6.Name = "lbl_Chest6";
            this.lbl_Chest6.Size = new System.Drawing.Size(32, 16);
            this.lbl_Chest6.TabIndex = 74;
            this.lbl_Chest6.Text = "4025";
            this.lbl_Chest6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Chest5
            // 
            this.lbl_Chest5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_Chest5.BackColor = System.Drawing.Color.White;
            this.lbl_Chest5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Chest5.Location = new System.Drawing.Point(194, 534);
            this.lbl_Chest5.Name = "lbl_Chest5";
            this.lbl_Chest5.Size = new System.Drawing.Size(32, 16);
            this.lbl_Chest5.TabIndex = 73;
            this.lbl_Chest5.Text = "4025";
            this.lbl_Chest5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Chest4
            // 
            this.lbl_Chest4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_Chest4.BackColor = System.Drawing.Color.White;
            this.lbl_Chest4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Chest4.Location = new System.Drawing.Point(152, 534);
            this.lbl_Chest4.Name = "lbl_Chest4";
            this.lbl_Chest4.Size = new System.Drawing.Size(32, 16);
            this.lbl_Chest4.TabIndex = 72;
            this.lbl_Chest4.Text = "4025";
            this.lbl_Chest4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Chest3
            // 
            this.lbl_Chest3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_Chest3.BackColor = System.Drawing.Color.White;
            this.lbl_Chest3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Chest3.Location = new System.Drawing.Point(110, 534);
            this.lbl_Chest3.Name = "lbl_Chest3";
            this.lbl_Chest3.Size = new System.Drawing.Size(32, 16);
            this.lbl_Chest3.TabIndex = 71;
            this.lbl_Chest3.Text = "4025";
            this.lbl_Chest3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Chest2
            // 
            this.lbl_Chest2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_Chest2.BackColor = System.Drawing.Color.White;
            this.lbl_Chest2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Chest2.Location = new System.Drawing.Point(68, 534);
            this.lbl_Chest2.Name = "lbl_Chest2";
            this.lbl_Chest2.Size = new System.Drawing.Size(32, 16);
            this.lbl_Chest2.TabIndex = 70;
            this.lbl_Chest2.Text = "4025";
            this.lbl_Chest2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Chest1
            // 
            this.lbl_Chest1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_Chest1.BackColor = System.Drawing.Color.White;
            this.lbl_Chest1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Chest1.Location = new System.Drawing.Point(26, 534);
            this.lbl_Chest1.Name = "lbl_Chest1";
            this.lbl_Chest1.Size = new System.Drawing.Size(32, 16);
            this.lbl_Chest1.TabIndex = 69;
            this.lbl_Chest1.Text = "4025";
            this.lbl_Chest1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbox_Chest14
            // 
            this.pbox_Chest14.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pbox_Chest14.BackColor = System.Drawing.Color.Transparent;
            this.pbox_Chest14.Location = new System.Drawing.Point(568, 493);
            this.pbox_Chest14.Name = "pbox_Chest14";
            this.pbox_Chest14.Size = new System.Drawing.Size(40, 40);
            this.pbox_Chest14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_Chest14.TabIndex = 68;
            this.pbox_Chest14.TabStop = false;
            // 
            // pbox_Chest13
            // 
            this.pbox_Chest13.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pbox_Chest13.BackColor = System.Drawing.Color.Transparent;
            this.pbox_Chest13.Location = new System.Drawing.Point(526, 493);
            this.pbox_Chest13.Name = "pbox_Chest13";
            this.pbox_Chest13.Size = new System.Drawing.Size(40, 40);
            this.pbox_Chest13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_Chest13.TabIndex = 67;
            this.pbox_Chest13.TabStop = false;
            // 
            // pbox_Chest12
            // 
            this.pbox_Chest12.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pbox_Chest12.BackColor = System.Drawing.Color.Transparent;
            this.pbox_Chest12.Location = new System.Drawing.Point(484, 493);
            this.pbox_Chest12.Name = "pbox_Chest12";
            this.pbox_Chest12.Size = new System.Drawing.Size(40, 40);
            this.pbox_Chest12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_Chest12.TabIndex = 66;
            this.pbox_Chest12.TabStop = false;
            // 
            // pbox_Chest11
            // 
            this.pbox_Chest11.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pbox_Chest11.BackColor = System.Drawing.Color.Transparent;
            this.pbox_Chest11.Location = new System.Drawing.Point(442, 493);
            this.pbox_Chest11.Name = "pbox_Chest11";
            this.pbox_Chest11.Size = new System.Drawing.Size(40, 40);
            this.pbox_Chest11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_Chest11.TabIndex = 65;
            this.pbox_Chest11.TabStop = false;
            // 
            // pbox_Chest9
            // 
            this.pbox_Chest9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pbox_Chest9.BackColor = System.Drawing.Color.Transparent;
            this.pbox_Chest9.Location = new System.Drawing.Point(358, 493);
            this.pbox_Chest9.Name = "pbox_Chest9";
            this.pbox_Chest9.Size = new System.Drawing.Size(40, 40);
            this.pbox_Chest9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_Chest9.TabIndex = 64;
            this.pbox_Chest9.TabStop = false;
            // 
            // pbox_Chest10
            // 
            this.pbox_Chest10.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pbox_Chest10.BackColor = System.Drawing.Color.Transparent;
            this.pbox_Chest10.Location = new System.Drawing.Point(400, 493);
            this.pbox_Chest10.Name = "pbox_Chest10";
            this.pbox_Chest10.Size = new System.Drawing.Size(40, 40);
            this.pbox_Chest10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_Chest10.TabIndex = 63;
            this.pbox_Chest10.TabStop = false;
            // 
            // pbox_Chest8
            // 
            this.pbox_Chest8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pbox_Chest8.BackColor = System.Drawing.Color.Transparent;
            this.pbox_Chest8.Location = new System.Drawing.Point(316, 493);
            this.pbox_Chest8.Name = "pbox_Chest8";
            this.pbox_Chest8.Size = new System.Drawing.Size(40, 40);
            this.pbox_Chest8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_Chest8.TabIndex = 62;
            this.pbox_Chest8.TabStop = false;
            // 
            // pbox_Chest7
            // 
            this.pbox_Chest7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pbox_Chest7.BackColor = System.Drawing.Color.Transparent;
            this.pbox_Chest7.Image = global::ClashRoyaleClanMonitorWF.Properties.Resources.magical_chest;
            this.pbox_Chest7.Location = new System.Drawing.Point(274, 493);
            this.pbox_Chest7.Name = "pbox_Chest7";
            this.pbox_Chest7.Size = new System.Drawing.Size(40, 40);
            this.pbox_Chest7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_Chest7.TabIndex = 61;
            this.pbox_Chest7.TabStop = false;
            // 
            // pbox_Chest6
            // 
            this.pbox_Chest6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pbox_Chest6.BackColor = System.Drawing.Color.Transparent;
            this.pbox_Chest6.Image = global::ClashRoyaleClanMonitorWF.Properties.Resources.gold_chest;
            this.pbox_Chest6.Location = new System.Drawing.Point(232, 493);
            this.pbox_Chest6.Name = "pbox_Chest6";
            this.pbox_Chest6.Size = new System.Drawing.Size(40, 40);
            this.pbox_Chest6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_Chest6.TabIndex = 60;
            this.pbox_Chest6.TabStop = false;
            // 
            // pbox_Chest5
            // 
            this.pbox_Chest5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pbox_Chest5.BackColor = System.Drawing.Color.Transparent;
            this.pbox_Chest5.Image = global::ClashRoyaleClanMonitorWF.Properties.Resources.giant_chest;
            this.pbox_Chest5.Location = new System.Drawing.Point(190, 493);
            this.pbox_Chest5.Name = "pbox_Chest5";
            this.pbox_Chest5.Size = new System.Drawing.Size(40, 40);
            this.pbox_Chest5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_Chest5.TabIndex = 59;
            this.pbox_Chest5.TabStop = false;
            // 
            // pbox_Chest4
            // 
            this.pbox_Chest4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pbox_Chest4.BackColor = System.Drawing.Color.Transparent;
            this.pbox_Chest4.Image = global::ClashRoyaleClanMonitorWF.Properties.Resources.epic_chest;
            this.pbox_Chest4.Location = new System.Drawing.Point(148, 493);
            this.pbox_Chest4.Name = "pbox_Chest4";
            this.pbox_Chest4.Size = new System.Drawing.Size(40, 40);
            this.pbox_Chest4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_Chest4.TabIndex = 58;
            this.pbox_Chest4.TabStop = false;
            // 
            // pbox_Chest3
            // 
            this.pbox_Chest3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pbox_Chest3.BackColor = System.Drawing.Color.Transparent;
            this.pbox_Chest3.Image = global::ClashRoyaleClanMonitorWF.Properties.Resources.legendary_chest;
            this.pbox_Chest3.Location = new System.Drawing.Point(106, 493);
            this.pbox_Chest3.Name = "pbox_Chest3";
            this.pbox_Chest3.Size = new System.Drawing.Size(40, 40);
            this.pbox_Chest3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_Chest3.TabIndex = 57;
            this.pbox_Chest3.TabStop = false;
            // 
            // pbox_Chest1
            // 
            this.pbox_Chest1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pbox_Chest1.BackColor = System.Drawing.Color.Transparent;
            this.pbox_Chest1.Image = global::ClashRoyaleClanMonitorWF.Properties.Resources.silver_chest;
            this.pbox_Chest1.Location = new System.Drawing.Point(22, 493);
            this.pbox_Chest1.Name = "pbox_Chest1";
            this.pbox_Chest1.Size = new System.Drawing.Size(40, 40);
            this.pbox_Chest1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_Chest1.TabIndex = 56;
            this.pbox_Chest1.TabStop = false;
            // 
            // pbox_Chest2
            // 
            this.pbox_Chest2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pbox_Chest2.BackColor = System.Drawing.Color.Transparent;
            this.pbox_Chest2.Image = global::ClashRoyaleClanMonitorWF.Properties.Resources.super_magical_chest;
            this.pbox_Chest2.Location = new System.Drawing.Point(64, 493);
            this.pbox_Chest2.Name = "pbox_Chest2";
            this.pbox_Chest2.Size = new System.Drawing.Size(40, 40);
            this.pbox_Chest2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_Chest2.TabIndex = 55;
            this.pbox_Chest2.TabStop = false;
            this.Controls.Add(this.lbl_Chest14);
            this.Controls.Add(this.lbl_Chest13);
            this.Controls.Add(this.lbl_Chest12);
            this.Controls.Add(this.lbl_Chest11);
            this.Controls.Add(this.lbl_Chest10);
            this.Controls.Add(this.lbl_Chest9);
            this.Controls.Add(this.lbl_Chest8);
            this.Controls.Add(this.lbl_Chest7);
            this.Controls.Add(this.lbl_Chest6);
            this.Controls.Add(this.lbl_Chest5);
            this.Controls.Add(this.lbl_Chest4);
            this.Controls.Add(this.lbl_Chest3);
            this.Controls.Add(this.lbl_Chest2);
            this.Controls.Add(this.lbl_Chest1);
            this.Controls.Add(this.pbox_Chest14);
            this.Controls.Add(this.pbox_Chest13);
            this.Controls.Add(this.pbox_Chest12);
            this.Controls.Add(this.pbox_Chest11);
            this.Controls.Add(this.pbox_Chest9);
            this.Controls.Add(this.pbox_Chest10);
            this.Controls.Add(this.pbox_Chest8);
            this.Controls.Add(this.pbox_Chest7);
            this.Controls.Add(this.pbox_Chest6);
            this.Controls.Add(this.pbox_Chest5);
            this.Controls.Add(this.pbox_Chest4);
            this.Controls.Add(this.pbox_Chest3);
            this.Controls.Add(this.pbox_Chest1);
            this.Controls.Add(this.pbox_Chest2);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Chest14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Chest13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Chest12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Chest11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Chest9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Chest10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Chest8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Chest7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Chest6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Chest5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Chest4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Chest3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Chest1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Chest2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
