namespace ClashRoyaleClanMonitorWF.Controls.Cards
{
    partial class CardInfoUC
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
            this.lbl_Card_Lvl = new System.Windows.Forms.Label();
            this.lbl_CountCard = new System.Windows.Forms.Label();
            this.CardImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CardImg)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Card_Lvl
            // 
            this.lbl_Card_Lvl.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Card_Lvl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Card_Lvl.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Card_Lvl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.lbl_Card_Lvl.Location = new System.Drawing.Point(-1, 63);
            this.lbl_Card_Lvl.Name = "lbl_Card_Lvl";
            this.lbl_Card_Lvl.Size = new System.Drawing.Size(50, 13);
            this.lbl_Card_Lvl.TabIndex = 8;
            this.lbl_Card_Lvl.Text = "Ур. 12";
            this.lbl_Card_Lvl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_CountCard
            // 
            this.lbl_CountCard.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CountCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_CountCard.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CountCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.lbl_CountCard.Location = new System.Drawing.Point(-5, 75);
            this.lbl_CountCard.Name = "lbl_CountCard";
            this.lbl_CountCard.Size = new System.Drawing.Size(61, 16);
            this.lbl_CountCard.TabIndex = 9;
            this.lbl_CountCard.Text = "5000/5000";
            this.lbl_CountCard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CardImg
            // 
            this.CardImg.BackColor = System.Drawing.Color.Transparent;
            this.CardImg.Location = new System.Drawing.Point(-2, -2);
            this.CardImg.Name = "CardImg";
            this.CardImg.Size = new System.Drawing.Size(54, 65);
            this.CardImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CardImg.TabIndex = 7;
            this.CardImg.TabStop = false;
            // 
            // CardInfoUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbl_CountCard);
            this.Controls.Add(this.lbl_Card_Lvl);
            this.Controls.Add(this.CardImg);
            this.Name = "CardInfoUC";
            this.Size = new System.Drawing.Size(50, 92);
            this.UseCustomBackColor = true;
            ((System.ComponentModel.ISupportInitialize)(this.CardImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox CardImg;
        private System.Windows.Forms.Label lbl_Card_Lvl;
        private System.Windows.Forms.Label lbl_CountCard;
    }
}
