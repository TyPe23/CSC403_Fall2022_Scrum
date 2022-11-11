namespace TowerDefense_TheRPG {
  partial class FrmMain {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.lblStoryLine = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.tmrTextCrawl = new System.Windows.Forms.Timer(this.components);
            this.tmrSpawnEnemies = new System.Windows.Forms.Timer(this.components);
            this.tmrMoveEnemies = new System.Windows.Forms.Timer(this.components);
            this.btnStoryLine = new System.Windows.Forms.Button();
            this.tmrMoveArrows = new System.Windows.Forms.Timer(this.components);
            this.tmrSpawnArrows = new System.Windows.Forms.Timer(this.components);
            this.tmrMovePlayer = new System.Windows.Forms.Timer(this.components);
            this.btnAddAttack = new System.Windows.Forms.Button();
            this.btnAddMagic = new System.Windows.Forms.Button();
            this.btnAddSpeed = new System.Windows.Forms.Button();
            this.btnNextLevel = new System.Windows.Forms.Button();
            this.AttackLabel = new System.Windows.Forms.Label();
            this.MagicLabel = new System.Windows.Forms.Label();
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.Level5Story = new System.Windows.Forms.Label();
            this.level10 = new System.Windows.Forms.Label();
            this.level15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStoryLine
            // 
            this.lblStoryLine.BackColor = System.Drawing.Color.Transparent;
            this.lblStoryLine.Font = new System.Drawing.Font("Segoe UI Emoji", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStoryLine.ForeColor = System.Drawing.Color.White;
            this.lblStoryLine.Location = new System.Drawing.Point(12, 68);
            this.lblStoryLine.Name = "lblStoryLine";
            this.lblStoryLine.Size = new System.Drawing.Size(1125, 619);
            this.lblStoryLine.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.AutoSize = true;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStart.Location = new System.Drawing.Point(315, 617);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(220, 70);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Play";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tmrTextCrawl
            // 
            this.tmrTextCrawl.Interval = 20;
            this.tmrTextCrawl.Tick += new System.EventHandler(this.tmrTextCrawl_Tick);
            // 
            // tmrSpawnEnemies
            // 
            this.tmrSpawnEnemies.Interval = 300;
            this.tmrSpawnEnemies.Tick += new System.EventHandler(this.tmrSpawnEnemies_Tick);
            // 
            // tmrMoveEnemies
            // 
            this.tmrMoveEnemies.Tick += new System.EventHandler(this.tmrMoveEnemies_Tick);
            // 
            // btnStoryLine
            // 
            this.btnStoryLine.AutoSize = true;
            this.btnStoryLine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnStoryLine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnStoryLine.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStoryLine.Location = new System.Drawing.Point(630, 617);
            this.btnStoryLine.Name = "btnStoryLine";
            this.btnStoryLine.Size = new System.Drawing.Size(220, 70);
            this.btnStoryLine.TabIndex = 3;
            this.btnStoryLine.Text = "Show Storyline";
            this.btnStoryLine.UseVisualStyleBackColor = true;
            this.btnStoryLine.Click += new System.EventHandler(this.btnStoryLine_Click);
            // 
            // tmrMoveArrows
            // 
            this.tmrMoveArrows.Interval = 10;
            this.tmrMoveArrows.Tick += new System.EventHandler(this.tmrMoveArrows_Tick);
            // 
            // tmrSpawnArrows
            // 
            this.tmrSpawnArrows.Interval = 5000;
            this.tmrSpawnArrows.Tick += new System.EventHandler(this.tmrSpawnArrows_Tick);
            // 
            // tmrMovePlayer
            // 
            this.tmrMovePlayer.Tick += new System.EventHandler(this.tmrMovePlayer_Tick);
            // 
            // btnAddAttack
            // 
            this.btnAddAttack.Enabled = false;
            this.btnAddAttack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddAttack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAddAttack.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddAttack.Location = new System.Drawing.Point(89, 135);
            this.btnAddAttack.Name = "btnAddAttack";
            this.btnAddAttack.Size = new System.Drawing.Size(220, 70);
            this.btnAddAttack.TabIndex = 4;
            this.btnAddAttack.Text = "Increase Attack";
            this.btnAddAttack.UseVisualStyleBackColor = true;
            this.btnAddAttack.Visible = false;
            this.btnAddAttack.Click += new System.EventHandler(this.btnAddAttack_Click);
            // 
            // btnAddMagic
            // 
            this.btnAddMagic.Enabled = false;
            this.btnAddMagic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddMagic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAddMagic.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddMagic.Location = new System.Drawing.Point(89, 290);
            this.btnAddMagic.Name = "btnAddMagic";
            this.btnAddMagic.Size = new System.Drawing.Size(220, 70);
            this.btnAddMagic.TabIndex = 5;
            this.btnAddMagic.Text = "Increase Magic";
            this.btnAddMagic.UseVisualStyleBackColor = true;
            this.btnAddMagic.Visible = false;
            this.btnAddMagic.Click += new System.EventHandler(this.btnAddMagic_Click);
            // 
            // btnAddSpeed
            // 
            this.btnAddSpeed.Enabled = false;
            this.btnAddSpeed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddSpeed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAddSpeed.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddSpeed.Location = new System.Drawing.Point(89, 439);
            this.btnAddSpeed.Name = "btnAddSpeed";
            this.btnAddSpeed.Size = new System.Drawing.Size(220, 70);
            this.btnAddSpeed.TabIndex = 6;
            this.btnAddSpeed.Text = "Increase Speed";
            this.btnAddSpeed.UseVisualStyleBackColor = true;
            this.btnAddSpeed.Visible = false;
            this.btnAddSpeed.Click += new System.EventHandler(this.btnAddSpeed_Click);
            // 
            // btnNextLevel
            // 
            this.btnNextLevel.Enabled = false;
            this.btnNextLevel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNextLevel.Location = new System.Drawing.Point(473, 541);
            this.btnNextLevel.Name = "btnNextLevel";
            this.btnNextLevel.Size = new System.Drawing.Size(220, 70);
            this.btnNextLevel.TabIndex = 7;
            this.btnNextLevel.Text = "Next Level";
            this.btnNextLevel.UseVisualStyleBackColor = true;
            this.btnNextLevel.Visible = false;
            this.btnNextLevel.Click += new System.EventHandler(this.btnNextLevel_Click);
            // 
            // AttackLabel
            // 
            this.AttackLabel.AutoSize = true;
            this.AttackLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.AttackLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AttackLabel.Location = new System.Drawing.Point(362, 135);
            this.AttackLabel.MinimumSize = new System.Drawing.Size(220, 70);
            this.AttackLabel.Name = "AttackLabel";
            this.AttackLabel.Size = new System.Drawing.Size(220, 70);
            this.AttackLabel.TabIndex = 8;
            this.AttackLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AttackLabel.Visible = false;
            // 
            // MagicLabel
            // 
            this.MagicLabel.AutoSize = true;
            this.MagicLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.MagicLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MagicLabel.Location = new System.Drawing.Point(362, 290);
            this.MagicLabel.MinimumSize = new System.Drawing.Size(220, 70);
            this.MagicLabel.Name = "MagicLabel";
            this.MagicLabel.Size = new System.Drawing.Size(220, 70);
            this.MagicLabel.TabIndex = 9;
            this.MagicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MagicLabel.Visible = false;
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.SpeedLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SpeedLabel.Location = new System.Drawing.Point(362, 439);
            this.SpeedLabel.MinimumSize = new System.Drawing.Size(220, 70);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(220, 70);
            this.SpeedLabel.TabIndex = 10;
            this.SpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SpeedLabel.Visible = false;
            // 
            // Level5Story
            // 
            this.Level5Story.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Level5Story.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Level5Story.Location = new System.Drawing.Point(750, 150);
            this.Level5Story.Name = "Level5Story";
            this.Level5Story.Size = new System.Drawing.Size(300, 300);
            this.Level5Story.TabIndex = 11;
            this.Level5Story.Text = "Peaches has successfully defended this town[5], time to move to the next one";
            this.Level5Story.Visible = false;
            // 
            // level10
            // 
            this.level10.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.level10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.level10.Location = new System.Drawing.Point(750, 150);
            this.level10.Name = "level10";
            this.level10.Size = new System.Drawing.Size(300, 300);
            this.level10.TabIndex = 12;
            this.level10.Text = "Peaches has successfully defended this town[10], time to move to the next one\r\n";
            this.level10.Visible = false;
            // 
            // level15
            // 
            this.level15.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.level15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.level15.Location = new System.Drawing.Point(750, 150);
            this.level15.Name = "level15";
            this.level15.Size = new System.Drawing.Size(300, 300);
            this.level15.TabIndex = 13;
            this.level15.Text = "Peaches has successfully defended this town[15], time to move to the next one\r\n";
            this.level15.Visible = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::TowerDefense_TheRPG.Properties.Resources.title;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1149, 726);
            this.Controls.Add(this.level15);
            this.Controls.Add(this.level10);
            this.Controls.Add(this.Level5Story);
            this.Controls.Add(this.SpeedLabel);
            this.Controls.Add(this.MagicLabel);
            this.Controls.Add(this.AttackLabel);
            this.Controls.Add(this.btnNextLevel);
            this.Controls.Add(this.btnAddSpeed);
            this.Controls.Add(this.btnAddMagic);
            this.Controls.Add(this.btnAddAttack);
            this.Controls.Add(this.btnStoryLine);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblStoryLine);
            this.DoubleBuffered = true;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tower Defense The RPG";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Label lblStoryLine;
    private Button btnStart;
    private System.Windows.Forms.Timer tmrTextCrawl;
    private System.Windows.Forms.Timer tmrSpawnEnemies;
    private System.Windows.Forms.Timer tmrMoveEnemies;
    private Button btnStoryLine;
    private System.Windows.Forms.Timer tmrMoveArrows;
    private System.Windows.Forms.Timer tmrSpawnArrows;
        private System.Windows.Forms.Timer tmrMovePlayer;
        private Button btnAddAttack;
        private Button btnAddMagic;
        private Button btnAddSpeed;
        private Button btnNextLevel;
        private Label AttackLabel;
        private Label MagicLabel;
        private Label SpeedLabel;
        private Label Level5Story;
        private Label level10;
        private Label level15;
    }
}