namespace project01
{
    partial class project01
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
            this.MuT_top = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LblMeal = new System.Windows.Forms.Label();
            this.LblPoor = new System.Windows.Forms.Label();
            this.LblAverage = new System.Windows.Forms.Label();
            this.LblExcellent = new System.Windows.Forms.Label();
            this.TxtMeal = new System.Windows.Forms.TextBox();
            this.TxtPoor = new System.Windows.Forms.TextBox();
            this.TxtAverage = new System.Windows.Forms.TextBox();
            this.TxtExcellent = new System.Windows.Forms.TextBox();
            this.MuT_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // MuT_top
            // 
            this.MuT_top.BackColor = System.Drawing.Color.Gray;
            this.MuT_top.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.MuT_top.Location = new System.Drawing.Point(0, 0);
            this.MuT_top.Name = "MuT_top";
            this.MuT_top.Size = new System.Drawing.Size(439, 24);
            this.MuT_top.TabIndex = 0;
            this.MuT_top.Text = "MuT_top";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // LblMeal
            // 
            this.LblMeal.AutoSize = true;
            this.LblMeal.Location = new System.Drawing.Point(12, 62);
            this.LblMeal.Name = "LblMeal";
            this.LblMeal.Size = new System.Drawing.Size(151, 13);
            this.LblMeal.TabIndex = 1;
            this.LblMeal.Text = "Enter the cost of your meal:  $ ";
            // 
            // LblPoor
            // 
            this.LblPoor.AutoSize = true;
            this.LblPoor.Location = new System.Drawing.Point(147, 135);
            this.LblPoor.Name = "LblPoor";
            this.LblPoor.Size = new System.Drawing.Size(71, 13);
            this.LblPoor.TabIndex = 2;
            this.LblPoor.Text = "Poor Service:";
            // 
            // LblAverage
            // 
            this.LblAverage.AutoSize = true;
            this.LblAverage.Location = new System.Drawing.Point(129, 178);
            this.LblAverage.Name = "LblAverage";
            this.LblAverage.Size = new System.Drawing.Size(89, 13);
            this.LblAverage.TabIndex = 3;
            this.LblAverage.Text = "Average Service:";
            // 
            // LblExcellent
            // 
            this.LblExcellent.AutoSize = true;
            this.LblExcellent.Location = new System.Drawing.Point(126, 223);
            this.LblExcellent.Name = "LblExcellent";
            this.LblExcellent.Size = new System.Drawing.Size(92, 13);
            this.LblExcellent.TabIndex = 4;
            this.LblExcellent.Text = "Excellent Service:";
            // 
            // TxtMeal
            // 
            this.TxtMeal.Location = new System.Drawing.Point(157, 59);
            this.TxtMeal.Name = "TxtMeal";
            this.TxtMeal.Size = new System.Drawing.Size(242, 20);
            this.TxtMeal.TabIndex = 5;
            this.TxtMeal.Leave += new System.EventHandler(this.TxtMeal_Leave);
            // 
            // TxtPoor
            // 
            this.TxtPoor.Location = new System.Drawing.Point(224, 132);
            this.TxtPoor.Name = "TxtPoor";
            this.TxtPoor.ReadOnly = true;
            this.TxtPoor.Size = new System.Drawing.Size(175, 20);
            this.TxtPoor.TabIndex = 6;
            // 
            // TxtAverage
            // 
            this.TxtAverage.Location = new System.Drawing.Point(225, 178);
            this.TxtAverage.Name = "TxtAverage";
            this.TxtAverage.ReadOnly = true;
            this.TxtAverage.Size = new System.Drawing.Size(174, 20);
            this.TxtAverage.TabIndex = 7;
            // 
            // TxtExcellent
            // 
            this.TxtExcellent.Location = new System.Drawing.Point(224, 220);
            this.TxtExcellent.Name = "TxtExcellent";
            this.TxtExcellent.ReadOnly = true;
            this.TxtExcellent.Size = new System.Drawing.Size(175, 20);
            this.TxtExcellent.TabIndex = 8;
            // 
            // project01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(439, 291);
            this.Controls.Add(this.TxtExcellent);
            this.Controls.Add(this.TxtAverage);
            this.Controls.Add(this.TxtPoor);
            this.Controls.Add(this.TxtMeal);
            this.Controls.Add(this.LblExcellent);
            this.Controls.Add(this.LblAverage);
            this.Controls.Add(this.LblPoor);
            this.Controls.Add(this.LblMeal);
            this.Controls.Add(this.MuT_top);
            this.MainMenuStrip = this.MuT_top;
            this.Name = "project01";
            this.Text = "CS 1400 Project #1 - Tip Calculator";
            this.MuT_top.ResumeLayout(false);
            this.MuT_top.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MuT_top;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label LblMeal;
        private System.Windows.Forms.Label LblPoor;
        private System.Windows.Forms.Label LblAverage;
        private System.Windows.Forms.Label LblExcellent;
        private System.Windows.Forms.TextBox TxtMeal;
        private System.Windows.Forms.TextBox TxtPoor;
        private System.Windows.Forms.TextBox TxtAverage;
        private System.Windows.Forms.TextBox TxtExcellent;
    }
}

