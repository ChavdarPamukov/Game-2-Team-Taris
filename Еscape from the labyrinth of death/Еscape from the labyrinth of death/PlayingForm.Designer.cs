namespace Еscape_from_the_labyrinth_of_death
{
    partial class PlayingForm
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
            this.playingpn = new System.Windows.Forms.Panel();
            this.wall_1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.NaPlayer = new System.Windows.Forms.Label();
            this.CharPlayer = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbDefense = new System.Windows.Forms.Label();
            this.lbAttack = new System.Windows.Forms.Label();
            this.lbHealth = new System.Windows.Forms.Label();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.wall_2 = new System.Windows.Forms.PictureBox();
            this.playingpn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wall_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wall_2)).BeginInit();
            this.SuspendLayout();
            // 
            // playingpn
            // 
            this.playingpn.Controls.Add(this.wall_2);
            this.playingpn.Controls.Add(this.wall_1);
            this.playingpn.Controls.Add(this.player);
            this.playingpn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.playingpn.Location = new System.Drawing.Point(0, 115);
            this.playingpn.Name = "playingpn";
            this.playingpn.Size = new System.Drawing.Size(1015, 446);
            this.playingpn.TabIndex = 0;
            // 
            // wall_1
            // 
            this.wall_1.BackColor = System.Drawing.Color.Black;
            this.wall_1.Location = new System.Drawing.Point(571, 224);
            this.wall_1.Name = "wall_1";
            this.wall_1.Size = new System.Drawing.Size(100, 50);
            this.wall_1.TabIndex = 1;
            this.wall_1.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.SystemColors.Control;
            this.player.Image = global::Еscape_from_the_labyrinth_of_death.Properties.Resources.wiz_ch;
            this.player.Location = new System.Drawing.Point(352, 264);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(32, 44);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // NaPlayer
            // 
            this.NaPlayer.AutoSize = true;
            this.NaPlayer.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NaPlayer.Location = new System.Drawing.Point(3, 16);
            this.NaPlayer.Name = "NaPlayer";
            this.NaPlayer.Size = new System.Drawing.Size(51, 22);
            this.NaPlayer.TabIndex = 1;
            this.NaPlayer.Text = "label1";
            // 
            // CharPlayer
            // 
            this.CharPlayer.AutoSize = true;
            this.CharPlayer.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CharPlayer.Location = new System.Drawing.Point(3, 59);
            this.CharPlayer.Name = "CharPlayer";
            this.CharPlayer.Size = new System.Drawing.Size(51, 22);
            this.CharPlayer.TabIndex = 2;
            this.CharPlayer.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbDefense);
            this.panel1.Controls.Add(this.lbAttack);
            this.panel1.Controls.Add(this.lbHealth);
            this.panel1.Controls.Add(this.progressBar3);
            this.panel1.Controls.Add(this.progressBar2);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.CharPlayer);
            this.panel1.Controls.Add(this.NaPlayer);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 121);
            this.panel1.TabIndex = 3;
            // 
            // lbDefense
            // 
            this.lbDefense.AutoSize = true;
            this.lbDefense.Location = new System.Drawing.Point(196, 68);
            this.lbDefense.Name = "lbDefense";
            this.lbDefense.Size = new System.Drawing.Size(47, 13);
            this.lbDefense.TabIndex = 8;
            this.lbDefense.Text = "Defense";
            // 
            // lbAttack
            // 
            this.lbAttack.AutoSize = true;
            this.lbAttack.Location = new System.Drawing.Point(196, 43);
            this.lbAttack.Name = "lbAttack";
            this.lbAttack.Size = new System.Drawing.Size(38, 13);
            this.lbAttack.TabIndex = 7;
            this.lbAttack.Text = "Attack";
            // 
            // lbHealth
            // 
            this.lbHealth.AutoSize = true;
            this.lbHealth.Location = new System.Drawing.Point(196, 15);
            this.lbHealth.Name = "lbHealth";
            this.lbHealth.Size = new System.Drawing.Size(38, 13);
            this.lbHealth.TabIndex = 6;
            this.lbHealth.Text = "Health";
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(254, 42);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(162, 12);
            this.progressBar3.TabIndex = 5;
            this.progressBar3.Value = 100;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(254, 68);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(162, 12);
            this.progressBar2.TabIndex = 4;
            this.progressBar2.Value = 100;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Red;
            this.progressBar1.Location = new System.Drawing.Point(254, 15);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(162, 12);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Value = 100;
            // 
            // wall_2
            // 
            this.wall_2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.wall_2.Location = new System.Drawing.Point(988, 3);
            this.wall_2.Name = "wall_2";
            this.wall_2.Size = new System.Drawing.Size(27, 296);
            this.wall_2.TabIndex = 2;
            this.wall_2.TabStop = false;
            // 
            // PlayingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.playingpn);
            this.MaximizeBox = false;
            this.Name = "PlayingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlayingForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PlayingForm_FormClosed);
            this.Load += new System.EventHandler(this.PlayingForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PlayingForm_KeyDown);
            this.playingpn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wall_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wall_2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel playingpn;
        private System.Windows.Forms.Label NaPlayer;
        private System.Windows.Forms.Label CharPlayer;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox wall_1;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbDefense;
        private System.Windows.Forms.Label lbAttack;
        private System.Windows.Forms.Label lbHealth;
        private System.Windows.Forms.PictureBox wall_2;
    }
}