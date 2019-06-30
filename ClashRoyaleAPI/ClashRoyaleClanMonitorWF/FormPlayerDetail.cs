using ClashRoyaleAPI.Models.Cards;
using ClashRoyaleAPI.Models.Players;
using ClashRoyaleClanMonitorWF.Controls.Cards;
using ClashRoyaleClanMonitorWF.Properties;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClashRoyaleClanMonitorWF
{
    public partial class FormPlayerDetail : MetroForm
    {

        //Player _player;
        UpcomingChests _chests;
        PictureBox[] pboxList;
        Label[] labellist;
        Сard[] tmpDeck;
        CardInfoUC[] cardInfo;
        public FormPlayerDetail(string PlayerTag)
        {
            InitializeComponent();

            for (int i = 0; i < Program.ClanMembersDetailInfo.Length; i++)
            {
                if (Program.ClanMembersDetailInfo[i].tag == PlayerTag)
                {
                    _chests = Program.ClanMembersChests[i];
                    lbl_Number.Text = (i+1).ToString();
                    this.Text = Program.ClanMembersDetailInfo[i].name;
                    mlbl_Tag.Text = Program.ClanMembersDetailInfo[i].tag;
                    mlbl_Trophies.Text = Program.ClanMembersDetailInfo[i].trophies.ToString();
                    label2.Text = Program.ClanMembersDetailInfo[i].expLevel.ToString();
                    lbl_Position.Text = PositionSwitch(Program.ClanMembersDetailInfo[i].role);
                    lbl_donated.Text = Program.ClanMembersDetailInfo[i].donations.ToString();
                    lbl_received.Text = Program.ClanMembersDetailInfo[i].donationsReceived.ToString();
                    ArenaSwitch(Program.ClanMembersDetailInfo[i].arena.id);
                    //CustomizeInitializeComponent();
                    CardGrouping.SelectedIndex = 1;
                    tmpDeck = Program.ClanMembersDetailInfo[i].currentDeck.ToArray();
                    pictureBox1.Image = Program.ImgCards.Where(c => c.Name == $"{tmpDeck[0].name}").FirstOrDefault().Img; //tmpDeck[0].iconUrls.medium);
                    pictureBox2.Image = Program.ImgCards.Where(c => c.Name == $"{tmpDeck[1].name}").FirstOrDefault().Img;//.LoadAsync(tmpDeck[1].iconUrls.medium);
                    pictureBox3.Image = Program.ImgCards.Where(c => c.Name == $"{tmpDeck[2].name}").FirstOrDefault().Img;//.LoadAsync(tmpDeck[2].iconUrls.medium);
                    pictureBox4.Image = Program.ImgCards.Where(c => c.Name == $"{tmpDeck[3].name}").FirstOrDefault().Img;//.LoadAsync(tmpDeck[3].iconUrls.medium);
                    pictureBox5.Image = Program.ImgCards.Where(c => c.Name == $"{tmpDeck[4].name}").FirstOrDefault().Img;//.LoadAsync(tmpDeck[4].iconUrls.medium);
                    pictureBox6.Image = Program.ImgCards.Where(c => c.Name == $"{tmpDeck[5].name}").FirstOrDefault().Img;//.LoadAsync(tmpDeck[5].iconUrls.medium);
                    pictureBox7.Image = Program.ImgCards.Where(c => c.Name == $"{tmpDeck[6].name}").FirstOrDefault().Img;//.LoadAsync(tmpDeck[6].iconUrls.medium);
                    pictureBox8.Image = Program.ImgCards.Where(c => c.Name == $"{tmpDeck[7].name}").FirstOrDefault().Img;//.LoadAsync(tmpDeck[7].iconUrls.medium);
                    if (FLP_PlayerCards.Controls.Count == 0)
                    {
                        ChestSwitch(_chests);
                        cardInfo = new CardInfoUC[Program.ClanMembersDetailInfo[i].cards.Count];
                        for (int CardCounter = 0; CardCounter < Program.ClanMembersDetailInfo[i].cards.Count; CardCounter++)
                        {
                            var tmpCard = Program.ImgCards.Where(c => c.Name == $"{Program.ClanMembersDetailInfo[i].cards[CardCounter].name}").FirstOrDefault();
                            if (tmpCard != null)
                            {
                                cardInfo[CardCounter] = new CardInfoUC(tmpCard.Img, tmpCard.StartLvl + Program.ClanMembersDetailInfo[i].cards[CardCounter].level, Program.ClanMembersDetailInfo[i].cards[CardCounter].count, tmpCard.Rare, tmpCard.Cost);
                            }

                        }
                        FLP_PlayerCards.Controls.AddRange(cardInfo.OrderByDescending(c => c.Rare).ToArray<CardInfoUC>());
                    }
                }
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

        private void CardGrouping_SelectedIndexChanged(object sender, EventArgs e)
        {
            CardSort(CardGrouping.SelectedIndex);
        }

        private void CardSort(int index)
        {
            if (FLP_PlayerCards.Controls.Count > 0)
            {
                switch (index)
                {
                    case 0: cardInfo = cardInfo.OrderBy(c => c.Rare).ToArray(); break;
                    case 1: cardInfo = cardInfo.OrderByDescending(c => c.Rare).ToArray(); break;
                    case 2: cardInfo = cardInfo.OrderBy(c => c.Cost).ToArray(); break;
                    case 3: cardInfo = cardInfo.OrderByDescending(c => c.Cost).ToArray(); break;
                    case 4: cardInfo = cardInfo.OrderBy(c => c.Lvl).ToArray(); break;
                    case 5: cardInfo = cardInfo.OrderByDescending(c => c.Lvl).ToArray(); break;
                    default:
                        cardInfo = cardInfo.OrderByDescending(c => c.Rare).ToArray();
                        break;
                }
                FLP_PlayerCards.Controls.Clear();
                FLP_PlayerCards.Controls.AddRange(cardInfo);
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

        private void ChestSwitch(UpcomingChests chests)
        {
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
            int count = ((chests.items.Length > 14) ? 14 : chests.items.Length);
            for (int i = 0; i < count; i++)
            {
                labellist[i].Text = (chests.items[i].index + 1).ToString();
                pboxList[i].Image = ChestImage(chests.items[i].name);
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
                case "Mega Lightning Chest": return Resources.super_lightning_chest;
                default:
                    return Resources.silver_chest;
            }
        }

        private void CustomizeInitializeComponent()
        {
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Location = new System.Drawing.Point(632, 2);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(40, 50);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 12;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Location = new System.Drawing.Point(590, 2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(40, 50);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 11;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Location = new System.Drawing.Point(548, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(40, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Location = new System.Drawing.Point(506, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(40, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Location = new System.Drawing.Point(464, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Location = new System.Drawing.Point(422, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(338, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(380, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
