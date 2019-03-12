namespace ClashRoyaleClanMonitorWF.Controls.Settings
{
    partial class SettingsUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsUC));
            this.mtb_PlayerID = new MetroFramework.Controls.MetroTextBox();
            this.mtb_Token = new MetroFramework.Controls.MetroTextBox();
            this.Tile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mtb_PlayerID
            // 
            // 
            // 
            // 
            this.mtb_PlayerID.CustomButton.Image = null;
            this.mtb_PlayerID.CustomButton.Location = new System.Drawing.Point(170, 1);
            this.mtb_PlayerID.CustomButton.Name = "";
            this.mtb_PlayerID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtb_PlayerID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtb_PlayerID.CustomButton.TabIndex = 1;
            this.mtb_PlayerID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtb_PlayerID.CustomButton.UseSelectable = true;
            this.mtb_PlayerID.CustomButton.Visible = false;
            this.mtb_PlayerID.Lines = new string[] {
        "P2RQGRP9G"};
            this.mtb_PlayerID.Location = new System.Drawing.Point(3, 58);
            this.mtb_PlayerID.MaxLength = 32767;
            this.mtb_PlayerID.Name = "mtb_PlayerID";
            this.mtb_PlayerID.PasswordChar = '\0';
            this.mtb_PlayerID.PromptText = "Укажите тег вашего аккаунта";
            this.mtb_PlayerID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtb_PlayerID.SelectedText = "";
            this.mtb_PlayerID.SelectionLength = 0;
            this.mtb_PlayerID.SelectionStart = 0;
            this.mtb_PlayerID.ShortcutsEnabled = true;
            this.mtb_PlayerID.Size = new System.Drawing.Size(192, 23);
            this.mtb_PlayerID.Style = MetroFramework.MetroColorStyle.Red;
            this.mtb_PlayerID.TabIndex = 5;
            this.mtb_PlayerID.Text = "P2RQGRP9G";
            this.mtb_PlayerID.UseSelectable = true;
            this.mtb_PlayerID.UseStyleColors = true;
            this.mtb_PlayerID.WaterMark = "Укажите тег вашего аккаунта";
            this.mtb_PlayerID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtb_PlayerID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtb_PlayerID.TextChanged += new System.EventHandler(this.mtb_PlayerID_TextChanged);
            // 
            // mtb_Token
            // 
            // 
            // 
            // 
            this.mtb_Token.CustomButton.Image = null;
            this.mtb_Token.CustomButton.Location = new System.Drawing.Point(278, 2);
            this.mtb_Token.CustomButton.Name = "";
            this.mtb_Token.CustomButton.Size = new System.Drawing.Size(181, 181);
            this.mtb_Token.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtb_Token.CustomButton.TabIndex = 1;
            this.mtb_Token.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtb_Token.CustomButton.UseSelectable = true;
            this.mtb_Token.CustomButton.Visible = false;
            this.mtb_Token.Lines = new string[] {
        resources.GetString("mtb_Token.Lines")};
            this.mtb_Token.Location = new System.Drawing.Point(3, 87);
            this.mtb_Token.MaxLength = 32767;
            this.mtb_Token.Multiline = true;
            this.mtb_Token.Name = "mtb_Token";
            this.mtb_Token.PasswordChar = '\0';
            this.mtb_Token.PromptText = "Укажите токен доступа к API.";
            this.mtb_Token.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtb_Token.SelectedText = "";
            this.mtb_Token.SelectionLength = 0;
            this.mtb_Token.SelectionStart = 0;
            this.mtb_Token.ShortcutsEnabled = true;
            this.mtb_Token.Size = new System.Drawing.Size(462, 186);
            this.mtb_Token.Style = MetroFramework.MetroColorStyle.Red;
            this.mtb_Token.TabIndex = 4;
            this.mtb_Token.Text = resources.GetString("mtb_Token.Text");
            this.mtb_Token.UseSelectable = true;
            this.mtb_Token.UseStyleColors = true;
            this.mtb_Token.WaterMark = "Укажите токен доступа к API.";
            this.mtb_Token.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtb_Token.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtb_Token.TextChanged += new System.EventHandler(this.mtb_Token_TextChanged);
            // 
            // Tile
            // 
            this.Tile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.Tile.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tile.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tile.ForeColor = System.Drawing.Color.White;
            this.Tile.Location = new System.Drawing.Point(0, 0);
            this.Tile.Name = "Tile";
            this.Tile.Size = new System.Drawing.Size(653, 32);
            this.Tile.TabIndex = 6;
            this.Tile.Text = "Настройки";
            this.Tile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SettingsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Tile);
            this.Controls.Add(this.mtb_PlayerID);
            this.Controls.Add(this.mtb_Token);
            this.Name = "SettingsUC";
            this.Size = new System.Drawing.Size(653, 350);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox mtb_PlayerID;
        private MetroFramework.Controls.MetroTextBox mtb_Token;
        private System.Windows.Forms.Label Tile;
    }
}
