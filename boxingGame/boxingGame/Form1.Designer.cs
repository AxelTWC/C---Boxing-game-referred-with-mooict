namespace boxingGame
{
    partial class myHealth
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
            this.components = new System.ComponentModel.Container();
            this.enemyLife = new System.Windows.Forms.ProgressBar();
            this.playerLife = new System.Windows.Forms.ProgressBar();
            this.enemyBoxer = new System.Windows.Forms.PictureBox();
            this.boxer = new System.Windows.Forms.PictureBox();
            this.enemyTimer = new System.Windows.Forms.Timer(this.components);
            this.enemyMove = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.enemyBoxer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxer)).BeginInit();
            this.SuspendLayout();
            // 
            // enemyLife
            // 
            this.enemyLife.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.enemyLife.Location = new System.Drawing.Point(12, 44);
            this.enemyLife.Name = "enemyLife";
            this.enemyLife.Size = new System.Drawing.Size(300, 25);
            this.enemyLife.TabIndex = 0;
            // 
            // playerLife
            // 
            this.playerLife.Location = new System.Drawing.Point(521, 44);
            this.playerLife.Name = "playerLife";
            this.playerLife.Size = new System.Drawing.Size(300, 25);
            this.playerLife.TabIndex = 1;
            // 
            // enemyBoxer
            // 
            this.enemyBoxer.BackColor = System.Drawing.Color.Transparent;
            this.enemyBoxer.Image = global::boxingGame.Properties.Resources.enemy_stand;
            this.enemyBoxer.Location = new System.Drawing.Point(385, 209);
            this.enemyBoxer.Name = "enemyBoxer";
            this.enemyBoxer.Size = new System.Drawing.Size(77, 185);
            this.enemyBoxer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.enemyBoxer.TabIndex = 2;
            this.enemyBoxer.TabStop = false;
            // 
            // boxer
            // 
            this.boxer.BackColor = System.Drawing.Color.Transparent;
            this.boxer.Image = global::boxingGame.Properties.Resources.boxer_stand;
            this.boxer.Location = new System.Drawing.Point(401, 400);
            this.boxer.Name = "boxer";
            this.boxer.Size = new System.Drawing.Size(61, 153);
            this.boxer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.boxer.TabIndex = 3;
            this.boxer.TabStop = false;
            // 
            // enemyTimer
            // 
            this.enemyTimer.Enabled = true;
            this.enemyTimer.Interval = 1000;
            this.enemyTimer.Tick += new System.EventHandler(this.enemyPunchEvent);
            // 
            // enemyMove
            // 
            this.enemyMove.Enabled = true;
            this.enemyMove.Interval = 20;
            this.enemyMove.Tick += new System.EventHandler(this.enemyMoveEvent);
            // 
            // myHealth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::boxingGame.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(825, 565);
            this.Controls.Add(this.boxer);
            this.Controls.Add(this.enemyBoxer);
            this.Controls.Add(this.playerLife);
            this.Controls.Add(this.enemyLife);
            this.Location = new System.Drawing.Point(521, 44);
            this.Name = "myHealth";
            this.Text = "Boxing Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.enemyBoxer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar enemyLife;
        private System.Windows.Forms.ProgressBar playerLife;
        private System.Windows.Forms.PictureBox enemyBoxer;
        private System.Windows.Forms.PictureBox boxer;
        private System.Windows.Forms.Timer enemyTimer;
        private System.Windows.Forms.Timer enemyMove;
    }
}

