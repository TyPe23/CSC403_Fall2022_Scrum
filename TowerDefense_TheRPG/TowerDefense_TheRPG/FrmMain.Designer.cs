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
            this.SuspendLayout();
            // 
            // lblStoryLine
            // 
            this.lblStoryLine.BackColor = System.Drawing.Color.Transparent;
            this.lblStoryLine.Font = new System.Drawing.Font("Segoe UI Emoji", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStoryLine.ForeColor = System.Drawing.Color.White;
            this.lblStoryLine.Location = new System.Drawing.Point(14, 12);
            this.lblStoryLine.Name = "lblStoryLine";
            this.lblStoryLine.Size = new System.Drawing.Size(1286, 825);
            this.lblStoryLine.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.AutoSize = true;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStart.Location = new System.Drawing.Point(360, 823);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(251, 93);
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
            this.tmrSpawnEnemies.Interval = 3000;
            this.tmrSpawnEnemies.Tick += new System.EventHandler(this.tmrSpawnEnemies_Tick);
            // 
            // tmrMoveEnemies
            // 
            this.tmrMoveEnemies.Tick += new System.EventHandler(this.tmrMoveEnemies_Tick);
            // 
            // btnStoryLine
            // 
            this.btnStoryLine.AutoSize = true;
            this.btnStoryLine.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStoryLine.Location = new System.Drawing.Point(720, 823);
            this.btnStoryLine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStoryLine.Name = "btnStoryLine";
            this.btnStoryLine.Size = new System.Drawing.Size(251, 93);
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
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::TowerDefense_TheRPG.Properties.Resources.title;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1313, 968);
            this.Controls.Add(this.btnStoryLine);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblStoryLine);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tower Defense The RPG";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
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
  }
}