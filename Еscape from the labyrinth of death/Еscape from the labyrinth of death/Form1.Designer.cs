namespace Еscape_from_the_labyrinth_of_death
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.GameName = new System.Windows.Forms.Label();
            this.CreditsButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.HButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GameName
            // 
            this.GameName.AutoSize = true;
            this.GameName.BackColor = System.Drawing.Color.Maroon;
            this.GameName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GameName.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GameName.Location = new System.Drawing.Point(18, 95);
            this.GameName.Name = "GameName";
            this.GameName.Size = new System.Drawing.Size(493, 45);
            this.GameName.TabIndex = 0;
            this.GameName.Text = "Еscape From The Labyrinth Of Death";
            this.GameName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CreditsButton
            // 
            this.CreditsButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.CreditsButton.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreditsButton.Location = new System.Drawing.Point(35, 327);
            this.CreditsButton.Name = "CreditsButton";
            this.CreditsButton.Size = new System.Drawing.Size(90, 50);
            this.CreditsButton.TabIndex = 1;
            this.CreditsButton.Text = "CREDITS";
            this.CreditsButton.UseVisualStyleBackColor = false;
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.StartButton.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButton.Location = new System.Drawing.Point(214, 327);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(90, 50);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "START";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // HButton
            // 
            this.HButton.BackColor = System.Drawing.Color.Yellow;
            this.HButton.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HButton.Location = new System.Drawing.Point(398, 327);
            this.HButton.Name = "HButton";
            this.HButton.Size = new System.Drawing.Size(90, 50);
            this.HButton.TabIndex = 3;
            this.HButton.Text = "HELP";
            this.HButton.UseVisualStyleBackColor = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Еscape_from_the_labyrinth_of_death.Properties.Resources.stones_wall;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(531, 437);
            this.Controls.Add(this.HButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.CreditsButton);
            this.Controls.Add(this.GameName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Еscape from the labyrinth of death";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GameName;
        private System.Windows.Forms.Button CreditsButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button HButton;
    }
}

