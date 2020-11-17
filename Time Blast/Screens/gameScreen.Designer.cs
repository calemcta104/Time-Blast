namespace Time_Blast
{
    partial class gameScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.enemyTimer = new System.Windows.Forms.Timer(this.components);
            this.healthLabel = new System.Windows.Forms.Label();
            this.lossLabel = new System.Windows.Forms.Label();
            this.winLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // enemyTimer
            // 
            this.enemyTimer.Enabled = true;
            this.enemyTimer.Interval = 50;
            this.enemyTimer.Tick += new System.EventHandler(this.enemyTimer_Tick);
            // 
            // healthLabel
            // 
            this.healthLabel.AutoSize = true;
            this.healthLabel.Location = new System.Drawing.Point(38, 120);
            this.healthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(16, 17);
            this.healthLabel.TabIndex = 0;
            this.healthLabel.Text = "4";
            // 
            // lossLabel
            // 
            this.lossLabel.AutoSize = true;
            this.lossLabel.BackColor = System.Drawing.Color.Transparent;
            this.lossLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lossLabel.ForeColor = System.Drawing.Color.Red;
            this.lossLabel.Location = new System.Drawing.Point(148, 171);
            this.lossLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lossLabel.Name = "lossLabel";
            this.lossLabel.Size = new System.Drawing.Size(669, 135);
            this.lossLabel.TabIndex = 2;
            this.lossLabel.Text = "YOU LOSE";
            this.lossLabel.Visible = false;
            // 
            // winLabel
            // 
            this.winLabel.AutoSize = true;
            this.winLabel.BackColor = System.Drawing.Color.Transparent;
            this.winLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLabel.ForeColor = System.Drawing.Color.Gold;
            this.winLabel.Location = new System.Drawing.Point(148, 326);
            this.winLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(582, 135);
            this.winLabel.TabIndex = 3;
            this.winLabel.Text = "YOU WIN";
            this.winLabel.Visible = false;
            // 
            // gameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.winLabel);
            this.Controls.Add(this.lossLabel);
            this.Controls.Add(this.healthLabel);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "gameScreen";
            this.Size = new System.Drawing.Size(1200, 1000);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.gameScreen_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameScreen_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gameScreen_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameScreen_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer enemyTimer;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.Label lossLabel;
        private System.Windows.Forms.Label winLabel;
    }
}
