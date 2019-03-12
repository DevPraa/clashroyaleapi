namespace ClashRoyaleClanMonitorWF
{
    partial class FormMain
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MSM = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.mpnl_LeftMenu = new MetroFramework.Controls.MetroPanel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.MainPanel = new MetroFramework.Controls.MetroPanel();
            this.bgw_LoadData = new System.ComponentModel.BackgroundWorker();
            this.pgbar_Loading = new MetroFramework.Controls.MetroProgressBar();
            this.btn_Minimize = new System.Windows.Forms.Button();
            this.btn_Maximize = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Help = new System.Windows.Forms.Button();
            this.btn_Settings = new System.Windows.Forms.Button();
            this.btn_Clan = new System.Windows.Forms.Button();
            this.btn_Main = new System.Windows.Forms.Button();
            this.mlbl_ProgressText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MSM)).BeginInit();
            this.mpnl_LeftMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MSM
            // 
            this.MSM.Owner = this;
            this.MSM.Style = MetroFramework.MetroColorStyle.Red;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(8, 508);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(98, 23);
            this.metroTile1.TabIndex = 1;
            this.metroTile1.Text = "metroTile1";
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // mpnl_LeftMenu
            // 
            this.mpnl_LeftMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mpnl_LeftMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.mpnl_LeftMenu.Controls.Add(this.btn_Minimize);
            this.mpnl_LeftMenu.Controls.Add(this.btn_Maximize);
            this.mpnl_LeftMenu.Controls.Add(this.btn_Close);
            this.mpnl_LeftMenu.Controls.Add(this.SidePanel);
            this.mpnl_LeftMenu.Controls.Add(this.metroTile1);
            this.mpnl_LeftMenu.Controls.Add(this.btn_Help);
            this.mpnl_LeftMenu.Controls.Add(this.btn_Settings);
            this.mpnl_LeftMenu.Controls.Add(this.btn_Clan);
            this.mpnl_LeftMenu.Controls.Add(this.btn_Main);
            this.mpnl_LeftMenu.HorizontalScrollbarBarColor = false;
            this.mpnl_LeftMenu.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnl_LeftMenu.HorizontalScrollbarSize = 0;
            this.mpnl_LeftMenu.Location = new System.Drawing.Point(0, -1);
            this.mpnl_LeftMenu.Name = "mpnl_LeftMenu";
            this.mpnl_LeftMenu.Size = new System.Drawing.Size(168, 602);
            this.mpnl_LeftMenu.TabIndex = 2;
            this.mpnl_LeftMenu.UseCustomBackColor = true;
            this.mpnl_LeftMenu.UseStyleColors = true;
            this.mpnl_LeftMenu.VerticalScrollbarBarColor = false;
            this.mpnl_LeftMenu.VerticalScrollbarHighlightOnWheel = false;
            this.mpnl_LeftMenu.VerticalScrollbarSize = 0;
            this.mpnl_LeftMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mpnl_LeftMenu_MouseDown);
            this.mpnl_LeftMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mpnl_LeftMenu_MouseMove);
            this.mpnl_LeftMenu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mpnl_LeftMenu_MouseUp);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.SidePanel.Location = new System.Drawing.Point(-4, 53);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 47);
            this.SidePanel.TabIndex = 3;
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.HorizontalScrollbarBarColor = false;
            this.MainPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.MainPanel.HorizontalScrollbarSize = 0;
            this.MainPanel.Location = new System.Drawing.Point(168, 5);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(732, 572);
            this.MainPanel.TabIndex = 3;
            this.MainPanel.VerticalScrollbarBarColor = false;
            this.MainPanel.VerticalScrollbarHighlightOnWheel = false;
            this.MainPanel.VerticalScrollbarSize = 0;
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            this.MainPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseUp);
            // 
            // bgw_LoadData
            // 
            this.bgw_LoadData.WorkerReportsProgress = true;
            this.bgw_LoadData.WorkerSupportsCancellation = true;
            this.bgw_LoadData.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_LoadData_DoWork);
            this.bgw_LoadData.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgw_LoadData_ProgressChanged);
            this.bgw_LoadData.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_LoadData_RunWorkerCompleted);
            // 
            // pgbar_Loading
            // 
            this.pgbar_Loading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgbar_Loading.HideProgressText = false;
            this.pgbar_Loading.Location = new System.Drawing.Point(514, 576);
            this.pgbar_Loading.Margin = new System.Windows.Forms.Padding(0);
            this.pgbar_Loading.Name = "pgbar_Loading";
            this.pgbar_Loading.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pgbar_Loading.Size = new System.Drawing.Size(366, 25);
            this.pgbar_Loading.Style = MetroFramework.MetroColorStyle.Red;
            this.pgbar_Loading.TabIndex = 4;
            this.pgbar_Loading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pgbar_Loading.Value = 50;
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.FlatAppearance.BorderSize = 0;
            this.btn_Minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimize.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Minimize.ForeColor = System.Drawing.Color.White;
            this.btn_Minimize.Image = global::ClashRoyaleClanMonitorWF.Properties.Resources.window_minimize_white;
            this.btn_Minimize.Location = new System.Drawing.Point(64, 0);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(29, 27);
            this.btn_Minimize.TabIndex = 9;
            this.btn_Minimize.UseVisualStyleBackColor = true;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // btn_Maximize
            // 
            this.btn_Maximize.FlatAppearance.BorderSize = 0;
            this.btn_Maximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.btn_Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Maximize.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Maximize.ForeColor = System.Drawing.Color.White;
            this.btn_Maximize.Image = global::ClashRoyaleClanMonitorWF.Properties.Resources.window_maximize_White;
            this.btn_Maximize.Location = new System.Drawing.Point(32, 0);
            this.btn_Maximize.Name = "btn_Maximize";
            this.btn_Maximize.Size = new System.Drawing.Size(29, 27);
            this.btn_Maximize.TabIndex = 8;
            this.btn_Maximize.UseVisualStyleBackColor = true;
            this.btn_Maximize.Click += new System.EventHandler(this.btn_Maximize_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Image = global::ClashRoyaleClanMonitorWF.Properties.Resources.window_close_White;
            this.btn_Close.Location = new System.Drawing.Point(0, 0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(29, 27);
            this.btn_Close.TabIndex = 7;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Help
            // 
            this.btn_Help.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Help.FlatAppearance.BorderSize = 0;
            this.btn_Help.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.btn_Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Help.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Help.ForeColor = System.Drawing.Color.White;
            this.btn_Help.Image = global::ClashRoyaleClanMonitorWF.Properties.Resources.help__white;
            this.btn_Help.Location = new System.Drawing.Point(-1, 573);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(29, 27);
            this.btn_Help.TabIndex = 6;
            this.btn_Help.UseVisualStyleBackColor = true;
            // 
            // btn_Settings
            // 
            this.btn_Settings.FlatAppearance.BorderSize = 0;
            this.btn_Settings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Settings.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Settings.ForeColor = System.Drawing.Color.White;
            this.btn_Settings.Image = global::ClashRoyaleClanMonitorWF.Properties.Resources.Settings_white;
            this.btn_Settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Settings.Location = new System.Drawing.Point(0, 159);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Size = new System.Drawing.Size(168, 47);
            this.btn_Settings.TabIndex = 5;
            this.btn_Settings.Text = "Настройки";
            this.btn_Settings.UseVisualStyleBackColor = true;
            this.btn_Settings.Click += new System.EventHandler(this.btn_Settings_Click);
            this.btn_Settings.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Settings_MouseDown);
            // 
            // btn_Clan
            // 
            this.btn_Clan.FlatAppearance.BorderSize = 0;
            this.btn_Clan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.btn_Clan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Clan.ForeColor = System.Drawing.Color.White;
            this.btn_Clan.Image = global::ClashRoyaleClanMonitorWF.Properties.Resources.account_group_white;
            this.btn_Clan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Clan.Location = new System.Drawing.Point(0, 106);
            this.btn_Clan.Name = "btn_Clan";
            this.btn_Clan.Size = new System.Drawing.Size(168, 47);
            this.btn_Clan.TabIndex = 4;
            this.btn_Clan.Text = "Клан";
            this.btn_Clan.UseVisualStyleBackColor = true;
            this.btn_Clan.Click += new System.EventHandler(this.btn_Clan_Click);
            this.btn_Clan.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Clan_MouseDown);
            // 
            // btn_Main
            // 
            this.btn_Main.FlatAppearance.BorderSize = 0;
            this.btn_Main.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.btn_Main.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Main.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Main.ForeColor = System.Drawing.Color.White;
            this.btn_Main.Image = global::ClashRoyaleClanMonitorWF.Properties.Resources.home_white;
            this.btn_Main.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Main.Location = new System.Drawing.Point(0, 53);
            this.btn_Main.Name = "btn_Main";
            this.btn_Main.Size = new System.Drawing.Size(168, 47);
            this.btn_Main.TabIndex = 3;
            this.btn_Main.Text = "Главная";
            this.btn_Main.UseVisualStyleBackColor = true;
            this.btn_Main.Click += new System.EventHandler(this.btn_Main_Click);
            this.btn_Main.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Main_MouseDown);
            // 
            // mlbl_ProgressText
            // 
            this.mlbl_ProgressText.BackColor = System.Drawing.Color.White;
            this.mlbl_ProgressText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mlbl_ProgressText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mlbl_ProgressText.Location = new System.Drawing.Point(168, 580);
            this.mlbl_ProgressText.Name = "mlbl_ProgressText";
            this.mlbl_ProgressText.Size = new System.Drawing.Size(343, 17);
            this.mlbl_ProgressText.TabIndex = 18;
            this.mlbl_ProgressText.Text = "PlayerNick";
            this.mlbl_ProgressText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.mlbl_ProgressText);
            this.Controls.Add(this.pgbar_Loading);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.mpnl_LeftMenu);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(5, 60, 5, 20);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MSM)).EndInit();
            this.mpnl_LeftMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager MSM;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroPanel mpnl_LeftMenu;
        private System.Windows.Forms.Button btn_Settings;
        private System.Windows.Forms.Button btn_Clan;
        private System.Windows.Forms.Button btn_Main;
        private System.Windows.Forms.Button btn_Help;
        private System.Windows.Forms.Panel SidePanel;
        private MetroFramework.Controls.MetroPanel MainPanel;
        private System.Windows.Forms.Button btn_Minimize;
        private System.Windows.Forms.Button btn_Maximize;
        private System.Windows.Forms.Button btn_Close;
        private System.ComponentModel.BackgroundWorker bgw_LoadData;
        private MetroFramework.Controls.MetroProgressBar pgbar_Loading;
        private System.Windows.Forms.Label mlbl_ProgressText;
    }
}

