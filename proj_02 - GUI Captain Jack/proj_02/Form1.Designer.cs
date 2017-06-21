namespace proj_02
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MuTMain = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblNumOfPirates = new System.Windows.Forms.Label();
            this.LblNumOfCoins = new System.Windows.Forms.Label();
            this.LblJackShare = new System.Windows.Forms.Label();
            this.LblMateShare = new System.Windows.Forms.Label();
            this.LblCrewShare = new System.Windows.Forms.Label();
            this.LblFund = new System.Windows.Forms.Label();
            this.BtnSplitGold = new System.Windows.Forms.Button();
            this.TxtNumOfPirates = new System.Windows.Forms.TextBox();
            this.TxtNumOfCoins = new System.Windows.Forms.TextBox();
            this.TxtJackShare = new System.Windows.Forms.TextBox();
            this.TxtMateShare = new System.Windows.Forms.TextBox();
            this.TxtCrewShare = new System.Windows.Forms.TextBox();
            this.TxtFund = new System.Windows.Forms.TextBox();
            this.MuTMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MuTMain
            // 
            this.MuTMain.BackColor = System.Drawing.Color.Black;
            this.MuTMain.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MuTMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.MuTMain.Location = new System.Drawing.Point(0, 0);
            this.MuTMain.Name = "MuTMain";
            this.MuTMain.Size = new System.Drawing.Size(427, 24);
            this.MuTMain.TabIndex = 0;
            this.MuTMain.Text = "MuTMain";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(105, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::proj_02.Properties.Resources.pirate_flag;
            this.pictureBox1.Location = new System.Drawing.Point(49, 252);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 174);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // LblNumOfPirates
            // 
            this.LblNumOfPirates.AutoSize = true;
            this.LblNumOfPirates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumOfPirates.Location = new System.Drawing.Point(69, 36);
            this.LblNumOfPirates.Name = "LblNumOfPirates";
            this.LblNumOfPirates.Size = new System.Drawing.Size(140, 20);
            this.LblNumOfPirates.TabIndex = 2;
            this.LblNumOfPirates.Text = "Number of Pirates:";
            // 
            // LblNumOfCoins
            // 
            this.LblNumOfCoins.AutoSize = true;
            this.LblNumOfCoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumOfCoins.Location = new System.Drawing.Point(36, 62);
            this.LblNumOfCoins.Name = "LblNumOfCoins";
            this.LblNumOfCoins.Size = new System.Drawing.Size(173, 20);
            this.LblNumOfCoins.TabIndex = 3;
            this.LblNumOfCoins.Text = "Number of Gold Coins: ";
            // 
            // LblJackShare
            // 
            this.LblJackShare.AutoSize = true;
            this.LblJackShare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblJackShare.Location = new System.Drawing.Point(105, 150);
            this.LblJackShare.Name = "LblJackShare";
            this.LblJackShare.Size = new System.Drawing.Size(104, 20);
            this.LblJackShare.TabIndex = 4;
            this.LblJackShare.Text = "Jack\'s Share:";
            // 
            // LblMateShare
            // 
            this.LblMateShare.AutoSize = true;
            this.LblMateShare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMateShare.Location = new System.Drawing.Point(102, 179);
            this.LblMateShare.Name = "LblMateShare";
            this.LblMateShare.Size = new System.Drawing.Size(107, 20);
            this.LblMateShare.TabIndex = 5;
            this.LblMateShare.Text = "Mate\'s Share:";
            // 
            // LblCrewShare
            // 
            this.LblCrewShare.AutoSize = true;
            this.LblCrewShare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCrewShare.Location = new System.Drawing.Point(40, 208);
            this.LblCrewShare.Name = "LblCrewShare";
            this.LblCrewShare.Size = new System.Drawing.Size(169, 20);
            this.LblCrewShare.TabIndex = 6;
            this.LblCrewShare.Text = "Crew Member\'s Share:";
            // 
            // LblFund
            // 
            this.LblFund.AutoSize = true;
            this.LblFund.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFund.Location = new System.Drawing.Point(19, 237);
            this.LblFund.Name = "LblFund";
            this.LblFund.Size = new System.Drawing.Size(190, 20);
            this.LblFund.TabIndex = 7;
            this.LblFund.Text = "Pirate\'s Benevolent Fund:";
            // 
            // BtnSplitGold
            // 
            this.BtnSplitGold.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSplitGold.ForeColor = System.Drawing.Color.Black;
            this.BtnSplitGold.Location = new System.Drawing.Point(129, 105);
            this.BtnSplitGold.Name = "BtnSplitGold";
            this.BtnSplitGold.Size = new System.Drawing.Size(147, 25);
            this.BtnSplitGold.TabIndex = 8;
            this.BtnSplitGold.Text = "Split the Gold";
            this.BtnSplitGold.UseVisualStyleBackColor = true;
            this.BtnSplitGold.Click += new System.EventHandler(this.BtnSplitGold_Click);
            // 
            // TxtNumOfPirates
            // 
            this.TxtNumOfPirates.Location = new System.Drawing.Point(216, 35);
            this.TxtNumOfPirates.Name = "TxtNumOfPirates";
            this.TxtNumOfPirates.Size = new System.Drawing.Size(199, 20);
            this.TxtNumOfPirates.TabIndex = 9;
            // 
            // TxtNumOfCoins
            // 
            this.TxtNumOfCoins.Location = new System.Drawing.Point(216, 62);
            this.TxtNumOfCoins.Name = "TxtNumOfCoins";
            this.TxtNumOfCoins.Size = new System.Drawing.Size(199, 20);
            this.TxtNumOfCoins.TabIndex = 10;
            // 
            // TxtJackShare
            // 
            this.TxtJackShare.Location = new System.Drawing.Point(216, 149);
            this.TxtJackShare.Name = "TxtJackShare";
            this.TxtJackShare.ReadOnly = true;
            this.TxtJackShare.Size = new System.Drawing.Size(199, 20);
            this.TxtJackShare.TabIndex = 11;
            // 
            // TxtMateShare
            // 
            this.TxtMateShare.Location = new System.Drawing.Point(216, 178);
            this.TxtMateShare.Name = "TxtMateShare";
            this.TxtMateShare.ReadOnly = true;
            this.TxtMateShare.Size = new System.Drawing.Size(199, 20);
            this.TxtMateShare.TabIndex = 12;
            // 
            // TxtCrewShare
            // 
            this.TxtCrewShare.Location = new System.Drawing.Point(216, 207);
            this.TxtCrewShare.Name = "TxtCrewShare";
            this.TxtCrewShare.ReadOnly = true;
            this.TxtCrewShare.Size = new System.Drawing.Size(199, 20);
            this.TxtCrewShare.TabIndex = 13;
            // 
            // TxtFund
            // 
            this.TxtFund.Location = new System.Drawing.Point(216, 236);
            this.TxtFund.Name = "TxtFund";
            this.TxtFund.ReadOnly = true;
            this.TxtFund.Size = new System.Drawing.Size(199, 20);
            this.TxtFund.TabIndex = 14;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(427, 426);
            this.Controls.Add(this.TxtFund);
            this.Controls.Add(this.TxtCrewShare);
            this.Controls.Add(this.TxtMateShare);
            this.Controls.Add(this.TxtJackShare);
            this.Controls.Add(this.TxtNumOfCoins);
            this.Controls.Add(this.TxtNumOfPirates);
            this.Controls.Add(this.BtnSplitGold);
            this.Controls.Add(this.LblFund);
            this.Controls.Add(this.LblCrewShare);
            this.Controls.Add(this.LblMateShare);
            this.Controls.Add(this.LblJackShare);
            this.Controls.Add(this.LblNumOfCoins);
            this.Controls.Add(this.LblNumOfPirates);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MuTMain);
            this.ForeColor = System.Drawing.Color.White;
            this.MainMenuStrip = this.MuTMain;
            this.Name = "Main";
            this.Text = "CS 1400 Project #2 - Captain Jack\'s Calculator";
            this.MuTMain.ResumeLayout(false);
            this.MuTMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MuTMain;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblNumOfPirates;
        private System.Windows.Forms.Label LblNumOfCoins;
        private System.Windows.Forms.Label LblJackShare;
        private System.Windows.Forms.Label LblMateShare;
        private System.Windows.Forms.Label LblCrewShare;
        private System.Windows.Forms.Label LblFund;
        private System.Windows.Forms.Button BtnSplitGold;
        private System.Windows.Forms.TextBox TxtNumOfPirates;
        private System.Windows.Forms.TextBox TxtNumOfCoins;
        private System.Windows.Forms.TextBox TxtJackShare;
        private System.Windows.Forms.TextBox TxtMateShare;
        private System.Windows.Forms.TextBox TxtCrewShare;
        private System.Windows.Forms.TextBox TxtFund;
    }
}

