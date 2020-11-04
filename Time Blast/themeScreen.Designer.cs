﻿namespace Time_Blast
{
    partial class themeScreen
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
            this.themeChooseLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.pirateButton = new System.Windows.Forms.Button();
            this.futureButton = new System.Windows.Forms.Button();
            this.wildWestButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // themeChooseLabel
            // 
            this.themeChooseLabel.BackColor = System.Drawing.Color.Transparent;
            this.themeChooseLabel.Font = new System.Drawing.Font("OCR A Extended", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themeChooseLabel.ForeColor = System.Drawing.Color.White;
            this.themeChooseLabel.Location = new System.Drawing.Point(70, 80);
            this.themeChooseLabel.Name = "themeChooseLabel";
            this.themeChooseLabel.Size = new System.Drawing.Size(706, 63);
            this.themeChooseLabel.TabIndex = 3;
            this.themeChooseLabel.Text = "CHOOSE YOUR THEME:";
            // 
            // backButton
            // 
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Image = global::Time_Blast.Properties.Resources.exitButton;
            this.backButton.Location = new System.Drawing.Point(686, 534);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(146, 88);
            this.backButton.TabIndex = 4;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // pirateButton
            // 
            this.pirateButton.BackColor = System.Drawing.Color.SteelBlue;
            this.pirateButton.FlatAppearance.BorderSize = 0;
            this.pirateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.pirateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.pirateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pirateButton.Image = global::Time_Blast.Properties.Resources.piratebigger;
            this.pirateButton.Location = new System.Drawing.Point(286, 437);
            this.pirateButton.Name = "pirateButton";
            this.pirateButton.Size = new System.Drawing.Size(285, 166);
            this.pirateButton.TabIndex = 2;
            this.pirateButton.UseVisualStyleBackColor = false;
            this.pirateButton.Click += new System.EventHandler(this.pirateButton_Click);
            // 
            // futureButton
            // 
            this.futureButton.BackColor = System.Drawing.Color.DarkRed;
            this.futureButton.FlatAppearance.BorderSize = 0;
            this.futureButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.futureButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.futureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.futureButton.Image = global::Time_Blast.Properties.Resources.futureResize;
            this.futureButton.Location = new System.Drawing.Point(481, 201);
            this.futureButton.Name = "futureButton";
            this.futureButton.Size = new System.Drawing.Size(286, 143);
            this.futureButton.TabIndex = 1;
            this.futureButton.UseVisualStyleBackColor = false;
            this.futureButton.Click += new System.EventHandler(this.futureButton_Click);
            // 
            // wildWestButton
            // 
            this.wildWestButton.BackColor = System.Drawing.Color.DarkKhaki;
            this.wildWestButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.wildWestButton.FlatAppearance.BorderSize = 0;
            this.wildWestButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkKhaki;
            this.wildWestButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
            this.wildWestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wildWestButton.Image = global::Time_Blast.Properties.Resources.WWResize;
            this.wildWestButton.Location = new System.Drawing.Point(60, 201);
            this.wildWestButton.Name = "wildWestButton";
            this.wildWestButton.Size = new System.Drawing.Size(287, 160);
            this.wildWestButton.TabIndex = 0;
            this.wildWestButton.UseVisualStyleBackColor = false;
            this.wildWestButton.Click += new System.EventHandler(this.wildWestButton_Click);
            // 
            // themeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.themeChooseLabel);
            this.Controls.Add(this.pirateButton);
            this.Controls.Add(this.futureButton);
            this.Controls.Add(this.wildWestButton);
            this.Name = "themeScreen";
            this.Size = new System.Drawing.Size(900, 700);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button wildWestButton;
        private System.Windows.Forms.Button futureButton;
        private System.Windows.Forms.Button pirateButton;
        private System.Windows.Forms.Label themeChooseLabel;
        private System.Windows.Forms.Button backButton;
    }
}