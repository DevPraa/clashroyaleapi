namespace ClashRoyaleClanMonitorWF.Controls.Main
{
    partial class CardSearchInfo
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
            this.mlbl_NickName = new System.Windows.Forms.Label();
            this.lbl_Cardlvl = new System.Windows.Forms.Label();
            this.mlbl_CardCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mlbl_NickName
            // 
            this.mlbl_NickName.AutoSize = true;
            this.mlbl_NickName.BackColor = System.Drawing.Color.White;
            this.mlbl_NickName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mlbl_NickName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mlbl_NickName.Location = new System.Drawing.Point(3, 2);
            this.mlbl_NickName.Name = "mlbl_NickName";
            this.mlbl_NickName.Size = new System.Drawing.Size(74, 17);
            this.mlbl_NickName.TabIndex = 18;
            this.mlbl_NickName.Text = "PlayerNick";
            // 
            // lbl_Cardlvl
            // 
            this.lbl_Cardlvl.BackColor = System.Drawing.Color.White;
            this.lbl_Cardlvl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Cardlvl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Cardlvl.Location = new System.Drawing.Point(105, 2);
            this.lbl_Cardlvl.Name = "lbl_Cardlvl";
            this.lbl_Cardlvl.Size = new System.Drawing.Size(53, 17);
            this.lbl_Cardlvl.TabIndex = 19;
            this.lbl_Cardlvl.Text = "Ур. 12";
            this.lbl_Cardlvl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mlbl_CardCount
            // 
            this.mlbl_CardCount.BackColor = System.Drawing.Color.White;
            this.mlbl_CardCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mlbl_CardCount.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mlbl_CardCount.Location = new System.Drawing.Point(154, 2);
            this.mlbl_CardCount.Name = "mlbl_CardCount";
            this.mlbl_CardCount.Size = new System.Drawing.Size(94, 17);
            this.mlbl_CardCount.TabIndex = 20;
            this.mlbl_CardCount.Text = "Кол-во 3000";
            this.mlbl_CardCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CardSearchInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.mlbl_CardCount);
            this.Controls.Add(this.lbl_Cardlvl);
            this.Controls.Add(this.mlbl_NickName);
            this.Name = "CardSearchInfo";
            this.Size = new System.Drawing.Size(247, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mlbl_NickName;
        private System.Windows.Forms.Label lbl_Cardlvl;
        private System.Windows.Forms.Label mlbl_CardCount;
    }
}
