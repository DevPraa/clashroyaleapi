using ClashRoyaleClanMonitorWF.Utils;
using System;

namespace ClashRoyaleClanMonitorWF.Controls.Clans
{
    partial class ClanCoreUC
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {

                this.Tile = new System.Windows.Forms.Label();
            this.MainTabControl = new MetroFramework.Controls.MetroTabControl();
            this.InformationTPage = new MetroFramework.Controls.MetroTabPage();
            this.PlayersTPage = new MetroFramework.Controls.MetroTabPage();
            this.WarTPage = new MetroFramework.Controls.MetroTabPage();
            this.FLP_ClanMembers = new System.Windows.Forms.FlowLayoutPanel();
            this.MainTabControl.SuspendLayout();
            this.PlayersTPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tile
            // 
            this.Tile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.Tile.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tile.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tile.ForeColor = System.Drawing.Color.White;
            this.Tile.Location = new System.Drawing.Point(0, 0);
            this.Tile.Name = "Tile";
            this.Tile.Size = new System.Drawing.Size(689, 32);
            this.Tile.TabIndex = 7;
            this.Tile.Text = "Клан";
            this.Tile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainTabControl
            // 
            this.MainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTabControl.Controls.Add(this.InformationTPage);
            this.MainTabControl.Controls.Add(this.PlayersTPage);
            this.MainTabControl.Controls.Add(this.WarTPage);
            this.MainTabControl.Location = new System.Drawing.Point(0, 34);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 1;
            this.MainTabControl.Size = new System.Drawing.Size(689, 330);
            this.MainTabControl.Style = MetroFramework.MetroColorStyle.Red;
            this.MainTabControl.TabIndex = 8;
            this.MainTabControl.UseSelectable = true;
            // 
            // InformationTPage
            // 
            this.InformationTPage.BackColor = System.Drawing.Color.White;
            this.InformationTPage.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InformationTPage.HorizontalScrollbarBarColor = false;
            this.InformationTPage.HorizontalScrollbarHighlightOnWheel = false;
            this.InformationTPage.HorizontalScrollbarSize = 0;
            this.InformationTPage.Location = new System.Drawing.Point(4, 38);
            this.InformationTPage.Name = "InformationTPage";
            this.InformationTPage.Size = new System.Drawing.Size(681, 288);
            this.InformationTPage.TabIndex = 0;
            this.InformationTPage.Text = "Информация";
            this.InformationTPage.VerticalScrollbarBarColor = false;
            this.InformationTPage.VerticalScrollbarHighlightOnWheel = false;
            this.InformationTPage.VerticalScrollbarSize = 0;
            // 
            // PlayersTPage
            // 
            this.PlayersTPage.BackColor = System.Drawing.Color.White;
            this.PlayersTPage.Controls.Add(this.FLP_ClanMembers);
            this.PlayersTPage.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayersTPage.HorizontalScrollbarBarColor = false;
            this.PlayersTPage.HorizontalScrollbarHighlightOnWheel = false;
            this.PlayersTPage.HorizontalScrollbarSize = 0;
            this.PlayersTPage.Location = new System.Drawing.Point(4, 38);
            this.PlayersTPage.Margin = new System.Windows.Forms.Padding(0);
            this.PlayersTPage.Name = "PlayersTPage";
            this.PlayersTPage.Size = new System.Drawing.Size(681, 288);
            this.PlayersTPage.TabIndex = 1;
            this.PlayersTPage.Text = "Участники";
            this.PlayersTPage.VerticalScrollbarBarColor = false;
            this.PlayersTPage.VerticalScrollbarHighlightOnWheel = false;
            this.PlayersTPage.VerticalScrollbarSize = 0;
            // 
            // WarTPage
            // 
            this.WarTPage.BackColor = System.Drawing.Color.White;
            this.WarTPage.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WarTPage.HorizontalScrollbarBarColor = false;
            this.WarTPage.HorizontalScrollbarHighlightOnWheel = false;
            this.WarTPage.HorizontalScrollbarSize = 0;
            this.WarTPage.Location = new System.Drawing.Point(4, 38);
            this.WarTPage.Name = "WarTPage";
            this.WarTPage.Size = new System.Drawing.Size(681, 288);
            this.WarTPage.TabIndex = 2;
            this.WarTPage.Text = "Война";
            this.WarTPage.VerticalScrollbarBarColor = false;
            this.WarTPage.VerticalScrollbarHighlightOnWheel = false;
            this.WarTPage.VerticalScrollbarSize = 0;
            // 
            // flowLayoutPanel1
            // 
            this.FLP_ClanMembers.AutoScroll = true;
            this.FLP_ClanMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLP_ClanMembers.Location = new System.Drawing.Point(0, 0);
            this.FLP_ClanMembers.Margin = new System.Windows.Forms.Padding(0);
            this.FLP_ClanMembers.Name = "flowLayoutPanel1";
            this.FLP_ClanMembers.Size = new System.Drawing.Size(681, 288);
            this.FLP_ClanMembers.TabIndex = 2;
            this.FLP_ClanMembers.SizeChanged += new System.EventHandler(this.flowLayoutPanel1_SizeChanged);
            // 
            // ClanCoreUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.Tile);
            this.Name = "ClanCoreUC";
            this.Size = new System.Drawing.Size(689, 363);
            this.MainTabControl.ResumeLayout(false);
            this.PlayersTPage.ResumeLayout(false);
            this.ResumeLayout(false);
            
        }

        #endregion

        private System.Windows.Forms.Label Tile;
        private MetroFramework.Controls.MetroTabControl MainTabControl;
        private MetroFramework.Controls.MetroTabPage InformationTPage;
        private MetroFramework.Controls.MetroTabPage PlayersTPage;
        private MetroFramework.Controls.MetroTabPage WarTPage;
        private System.Windows.Forms.FlowLayoutPanel FLP_ClanMembers;
    }
}
