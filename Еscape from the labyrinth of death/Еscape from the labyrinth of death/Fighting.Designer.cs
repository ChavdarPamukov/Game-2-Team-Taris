namespace Еscape_from_the_labyrinth_of_death
{
    partial class Fighting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fighting));
            this.buttonAttack = new System.Windows.Forms.Button();
            this.buttonHeal = new System.Windows.Forms.Button();
            this.buttonForfeit = new System.Windows.Forms.Button();
            this.pictureBoxPlayer = new System.Windows.Forms.PictureBox();
            this.pictureBoxEnemy = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PlayerHealthPoints = new System.Windows.Forms.Label();
            this.EnemyHealthPoints = new System.Windows.Forms.Label();
            this.EnemyName = new System.Windows.Forms.Label();
            this.HumanName = new System.Windows.Forms.Label();
            this.labelAction = new System.Windows.Forms.Label();
            this.ActionCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAttack
            // 
            this.buttonAttack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAttack.Location = new System.Drawing.Point(428, 444);
            this.buttonAttack.Name = "buttonAttack";
            this.buttonAttack.Size = new System.Drawing.Size(99, 34);
            this.buttonAttack.TabIndex = 0;
            this.buttonAttack.Text = "Attack";
            this.buttonAttack.UseVisualStyleBackColor = false;
            this.buttonAttack.Click += new System.EventHandler(this.buttonAttack_EventHandler);
            // 
            // buttonHeal
            // 
            this.buttonHeal.BackColor = System.Drawing.Color.Green;
            this.buttonHeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHeal.Location = new System.Drawing.Point(223, 444);
            this.buttonHeal.Name = "buttonHeal";
            this.buttonHeal.Size = new System.Drawing.Size(99, 34);
            this.buttonHeal.TabIndex = 1;
            this.buttonHeal.Text = "Heal";
            this.buttonHeal.UseVisualStyleBackColor = false;
            this.buttonHeal.Click += new System.EventHandler(this.buttonHeal_EventHandler);
            // 
            // buttonForfeit
            // 
            this.buttonForfeit.BackColor = System.Drawing.Color.Green;
            this.buttonForfeit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonForfeit.Location = new System.Drawing.Point(622, 444);
            this.buttonForfeit.Name = "buttonForfeit";
            this.buttonForfeit.Size = new System.Drawing.Size(99, 34);
            this.buttonForfeit.TabIndex = 2;
            this.buttonForfeit.Text = "Forfeit";
            this.buttonForfeit.UseVisualStyleBackColor = false;
            this.buttonForfeit.Click += new System.EventHandler(this.butonForfeit_eventHandler);
            // 
            // pictureBoxPlayer
            // 
            this.pictureBoxPlayer.Location = new System.Drawing.Point(117, 147);
            this.pictureBoxPlayer.Name = "pictureBoxPlayer";
            this.pictureBoxPlayer.Size = new System.Drawing.Size(100, 248);
            this.pictureBoxPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxPlayer.TabIndex = 3;
            this.pictureBoxPlayer.TabStop = false;
            // 
            // pictureBoxEnemy
            // 
            this.pictureBoxEnemy.Location = new System.Drawing.Point(454, 147);
            this.pictureBoxEnemy.Name = "pictureBoxEnemy";
            this.pictureBoxEnemy.Size = new System.Drawing.Size(48, 35);
            this.pictureBoxEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxEnemy.TabIndex = 4;
            this.pictureBoxEnemy.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Еscape_from_the_labyrinth_of_death.Properties.Resources.hart_50;
            this.pictureBox1.Location = new System.Drawing.Point(57, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Еscape_from_the_labyrinth_of_death.Properties.Resources.hart_50;
            this.pictureBox2.Location = new System.Drawing.Point(821, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // PlayerHealthPoints
            // 
            this.PlayerHealthPoints.AutoSize = true;
            this.PlayerHealthPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayerHealthPoints.Location = new System.Drawing.Point(137, 71);
            this.PlayerHealthPoints.Name = "PlayerHealthPoints";
            this.PlayerHealthPoints.Size = new System.Drawing.Size(79, 29);
            this.PlayerHealthPoints.TabIndex = 7;
            this.PlayerHealthPoints.Text = "label1";
            // 
            // EnemyHealthPoints
            // 
            this.EnemyHealthPoints.AutoSize = true;
            this.EnemyHealthPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnemyHealthPoints.Location = new System.Drawing.Point(723, 75);
            this.EnemyHealthPoints.Name = "EnemyHealthPoints";
            this.EnemyHealthPoints.Size = new System.Drawing.Size(79, 29);
            this.EnemyHealthPoints.TabIndex = 8;
            this.EnemyHealthPoints.Text = "label2";
            // 
            // EnemyName
            // 
            this.EnemyName.AutoSize = true;
            this.EnemyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnemyName.Location = new System.Drawing.Point(817, 9);
            this.EnemyName.Name = "EnemyName";
            this.EnemyName.Size = new System.Drawing.Size(78, 25);
            this.EnemyName.TabIndex = 9;
            this.EnemyName.Text = "Enemy";
            // 
            // HumanName
            // 
            this.HumanName.AutoSize = true;
            this.HumanName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HumanName.Location = new System.Drawing.Point(52, 9);
            this.HumanName.Name = "HumanName";
            this.HumanName.Size = new System.Drawing.Size(73, 25);
            this.HumanName.TabIndex = 10;
            this.HumanName.Text = "Player";
            // 
            // labelAction
            // 
            this.labelAction.AutoSize = true;
            this.labelAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAction.Location = new System.Drawing.Point(449, 9);
            this.labelAction.Name = "labelAction";
            this.labelAction.Size = new System.Drawing.Size(72, 25);
            this.labelAction.TabIndex = 11;
            this.labelAction.Text = "Action";
            // 
            // ActionCount
            // 
            this.ActionCount.AutoSize = true;
            this.ActionCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActionCount.Location = new System.Drawing.Point(467, 54);
            this.ActionCount.Name = "ActionCount";
            this.ActionCount.Size = new System.Drawing.Size(31, 33);
            this.ActionCount.TabIndex = 12;
            this.ActionCount.Text = "2";
            // 
            // Fighting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(939, 509);
            this.Controls.Add(this.ActionCount);
            this.Controls.Add(this.labelAction);
            this.Controls.Add(this.HumanName);
            this.Controls.Add(this.EnemyName);
            this.Controls.Add(this.EnemyHealthPoints);
            this.Controls.Add(this.PlayerHealthPoints);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxEnemy);
            this.Controls.Add(this.pictureBoxPlayer);
            this.Controls.Add(this.buttonForfeit);
            this.Controls.Add(this.buttonHeal);
            this.Controls.Add(this.buttonAttack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Fighting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fighting Arena";
            this.Load += new System.EventHandler(this.Fighting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAttack;
        private System.Windows.Forms.Button buttonHeal;
        private System.Windows.Forms.Button buttonForfeit;
        private System.Windows.Forms.PictureBox pictureBoxPlayer;
        private System.Windows.Forms.PictureBox pictureBoxEnemy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label PlayerHealthPoints;
        private System.Windows.Forms.Label EnemyHealthPoints;
        private System.Windows.Forms.Label EnemyName;
        private System.Windows.Forms.Label HumanName;
        private System.Windows.Forms.Label labelAction;
        private System.Windows.Forms.Label ActionCount;
    }
}