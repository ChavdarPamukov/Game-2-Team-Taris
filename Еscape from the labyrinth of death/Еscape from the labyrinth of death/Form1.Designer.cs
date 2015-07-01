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
            this.CreditsButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.HButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreditsButton
            // 
            this.CreditsButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.CreditsButton.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreditsButton.Location = new System.Drawing.Point(55, 336);
            this.CreditsButton.Name = "CreditsButton";
            this.CreditsButton.Size = new System.Drawing.Size(90, 50);
            this.CreditsButton.TabIndex = 1;
            this.CreditsButton.Text = "CREDITS";
            this.CreditsButton.UseVisualStyleBackColor = false;
            this.CreditsButton.Click += new System.EventHandler(this.CreditsButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.StartButton.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButton.Location = new System.Drawing.Point(229, 336);
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
            this.HButton.Location = new System.Drawing.Point(407, 336);
            this.HButton.Name = "HButton";
            this.HButton.Size = new System.Drawing.Size(90, 50);
            this.HButton.TabIndex = 3;
            this.HButton.Text = "HELP";
            this.HButton.UseVisualStyleBackColor = false;
            this.HButton.Click += new System.EventHandler(this.HButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 32.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(3, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 52);
            this.label1.TabIndex = 4;
            this.label1.Text = "Еscape from the labyrinth of death";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Еscape_from_the_labyrinth_of_death.Properties.Resources.startimg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(556, 437);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.CreditsButton);
            this.DoubleBuffered = true;
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

        private System.Windows.Forms.Button CreditsButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button HButton;
        private System.Windows.Forms.Label label1;
    }
}

