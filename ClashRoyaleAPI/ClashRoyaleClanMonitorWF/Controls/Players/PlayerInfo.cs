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
using ClashRoyaleClanMonitorWF.Controls.Cards;
using ClashRoyaleClanMonitorWF.Properties;
using ClashRoyaleAPI.Models.Cards;

namespace ClashRoyaleClanMonitorWF.Controls.Players
{
    public partial class PlayerInfo : MetroUserControl
    {
        bool ShowDeck = true;
        public int CustomWidth
        {
            set
            {
                MinimumSize = new Size(value, 56);
                MaximumSize = new Size(value, 56);
                this.Size = new Size(value, this.Height);
            }
        }

        Сard[] tmpDeck;
        public PlayerInfo(int Number, Player player, UpcomingChests chests)
        {
            InitializeComponent();         
            lbl_Number.Text = Number.ToString();
            mlbl_NickName.Text = player.name;
            mlbl_Tag.Text = player.tag;
            mlbl_Trophies.Text = player.trophies.ToString();
            label2.Text = player.expLevel.ToString();
            lbl_Position.Text = PositionSwitch(player.role);
            lbl_donated.Text = player.donations.ToString();
            lbl_received.Text = player.donationsReceived.ToString();
            ArenaSwitch(player.arena.id);
            tmpDeck = player.currentDeck.ToArray();            
        }

        List<CardInfoUC> tmpCIUC = new List<CardInfoUC>();
        private void mbtn_Show_Click(object sender, EventArgs e)
        {
            using (FormPlayerDetail fpd = new FormPlayerDetail(mlbl_Tag.Text))
            {
                fpd.ShowDialog();
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

        private void PlayerInfo_Load(object sender, EventArgs e)
        {

        }

        private void btn_ShowDeck_Click(object sender, EventArgs e)
        {
            if (ShowDeck)
            {
                CustomizeInitializeComponent();
                pictureBox1.Image = Program.ImgCards.Where(c => c.Name == $"{tmpDeck[0].name}").FirstOrDefault().Img; //tmpDeck[0].iconUrls.medium);
                pictureBox2.Image = Program.ImgCards.Where(c => c.Name == $"{tmpDeck[1].name}").FirstOrDefault().Img;//.LoadAsync(tmpDeck[1].iconUrls.medium);
                pictureBox3.Image = Program.ImgCards.Where(c => c.Name == $"{tmpDeck[2].name}").FirstOrDefault().Img;//.LoadAsync(tmpDeck[2].iconUrls.medium);
                pictureBox4.Image = Program.ImgCards.Where(c => c.Name == $"{tmpDeck[3].name}").FirstOrDefault().Img;//.LoadAsync(tmpDeck[3].iconUrls.medium);
                pictureBox5.Image = Program.ImgCards.Where(c => c.Name == $"{tmpDeck[4].name}").FirstOrDefault().Img;//.LoadAsync(tmpDeck[4].iconUrls.medium);
                pictureBox6.Image = Program.ImgCards.Where(c => c.Name == $"{tmpDeck[5].name}").FirstOrDefault().Img;//.LoadAsync(tmpDeck[5].iconUrls.medium);
                pictureBox7.Image = Program.ImgCards.Where(c => c.Name == $"{tmpDeck[6].name}").FirstOrDefault().Img;//.LoadAsync(tmpDeck[6].iconUrls.medium);
                pictureBox8.Image = Program.ImgCards.Where(c => c.Name == $"{tmpDeck[7].name}").FirstOrDefault().Img;//.LoadAsync(tmpDeck[7].iconUrls.medium);
                btn_ShowDeck.Text = "Hide Deck";
                ShowDeck = false;
            }
            else
            {
                CustomizeDisposeComponent();
                btn_ShowDeck.Text = "Show Deck";
                ShowDeck = true;
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
        private void CustomizeDisposeComponent()
        {
            this.pictureBox8?.Dispose();
            this.pictureBox7?.Dispose();
            this.pictureBox6?.Dispose();
            this.pictureBox5?.Dispose();
            this.pictureBox4?.Dispose();
            this.pictureBox3?.Dispose();
            this.pictureBox1?.Dispose();
            this.pictureBox2?.Dispose();
        }
    }
}
