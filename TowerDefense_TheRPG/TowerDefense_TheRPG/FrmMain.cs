using TowerDefense_TheRPG.code;
using TowerDefense_TheRPG.Properties;

namespace TowerDefense_TheRPG
{
    public partial class FrmMain : Form
    {
        #region Fields
        private Player player;
        private Village village;
        private List<Enemy> enemies;
        private List<Arrow> arrows;
        private List<Fireball> fireballs;
        private string storyLine;
        private int curStoryLineIndex;
        private Random rand;
        public int currlevel;
        private int enemyCount;
        private int enemyMax;
        private bool upMove = false;
        private bool downMove = false;
        private bool leftMove = false;
        private bool rightMove = false;

        #endregion

        #region Methods
        #region Ctor
        public FrmMain()
        {
            InitializeComponent();
            FormManager.PushToFormStack(this);
            DoubleBuffered = true;
            ControlManager.ResMan = Resources.ResourceManager;
            ControlManager.Form = this;
            rand = new Random();
        }
        #endregion

        #region Event functions
        // timers
        private void tmrTextCrawl_Tick(object sender, EventArgs e)
        {
            if (curStoryLineIndex < storyLine.Length)
            {
                lblStoryLine.Text += storyLine[curStoryLineIndex++];
                lblStoryLine.Refresh();
            }
            else
            {
                tmrTextCrawl.Enabled = false;
            }
        }

        private void tmrSpawnEnemies_Tick(object sender, EventArgs e)
        {
            if (enemyCount < enemyMax)
            {
                GenEnemyPos(out int x, out int y);
                int enemyType = rand.Next(4);
                Enemy balloon;
                switch (enemyType)
                {
                    case 0:
                        balloon = Enemy.MakeRedBalloon(x, y);
                        break;
                    case 1:
                        balloon = Enemy.MakePurpleBalloon(x, y);
                        break;
                    case 2:
                        balloon = Enemy.MakeGrayBalloon(x, y);
                        break;
                    default:
                        balloon = Enemy.MakeOrangeBalloon(x, y);
                        break;
                }
                enemies.Add(balloon);
                enemyCount++;
            }
            else
            {
                // place show skill menu method call here

                // place show button method call here
                // button should call Level() as FrmMain.Level();

                Level();
            }
        }
        private void tmrMoveEnemies_Tick(object sender, EventArgs e)
        {
            MoveEnemies();
        }
        private void tmrSpawnArrows_Tick(object sender, EventArgs e)
        {
            FireArrows();
        }
        private void tmrMoveArrows_Tick(object sender, EventArgs e)
        {
            MoveArrows();
        }
        
        
        private void tmrMoveFireballs_Tick(object sender, EventArgs e)
        {
            MoveFireballs();
        }

        private void tmrMovePlayer_Tick(object sender, EventArgs e)
        {
            if (player.Y > 0 && upMove)
            {
                player.Move(0, -1);
            }
            if (player.Y < Height - (player.H * 1.5) && downMove)
            {
                player.Move(0, +1);
            }
                
            if (player.X > 0 && leftMove)
            {
                player.Move(-1, 0);
            }
            if (player.X < Width - (player.W * 1.5) && rightMove)
            {
                player.Move(+1, 0);
            }
        }

        // form
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            PlayerMove(e.KeyCode);
        }
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            Abilities(e.KeyCode);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            PlayerStopMove(e.KeyCode);
        }

        // buttons
        private void btnStart_Click(object sender, EventArgs e)
        {
            BackgroundImage = null;
            btnStart.Visible = false;
            btnStart.Enabled = false;
            btnStoryLine.Visible = false;
            btnStart.Enabled = false;
            lblStoryLine.Visible = false;

            enemies = new List<Enemy>();
            arrows = new List<Arrow>();
            fireballs = new List<Fireball>();
            player = new Player(Width / 2, Height / 2 + 100);
            village = new Village(Width / 2 - 80, Height / 2 - 50, 165, 100);
            village.ControlContainer.SendToBack();
            currlevel = 1;
            enemyMax = 5 * currlevel;
            enemyCount = 0;

            tmrSpawnEnemies.Enabled = true;
            tmrMoveEnemies.Enabled = true;
            tmrMoveArrows.Enabled = true;
            tmrMoveFireballs.Enabled = true;
            tmrTextCrawl.Enabled = false;
            tmrMovePlayer.Enabled = true;


            // TODO: setting the background image here causes visual defects as enemies and player move
            //       around the screen. Consider either fixing these defects or setting BackgroundImage to null
            BackgroundImage = Resources.ground;

            // important, keep this call to Focus()!
            // otherwise, for whatever reason, the start button retains focus (even when enabled = false)
            // and arrow key presses are ignored and won't move player.
            Focus();
        }
        private void btnStoryLine_Click(object sender, EventArgs e)
        {
            if (btnStoryLine.Text.StartsWith("Show"))
            {
                Storyline();
                BackgroundImage = null;
                btnStart.Visible = false;
                btnStoryLine.Text = "Hide Storyline";
                lblStoryLine.Visible = true;

                tmrSpawnEnemies.Enabled = false;
                tmrMoveEnemies.Enabled = false;
                tmrMoveArrows.Enabled = false;
                tmrTextCrawl.Enabled = true;
            }
            else
            {
                BackgroundImage = Resources.title;
                btnStart.Visible = true;
                btnStoryLine.Text = "Show Storyline";
                lblStoryLine.Visible = false;

                tmrTextCrawl.Enabled = false;
            }
        }
        #endregion

        #region Helper functions
        private void Storyline()
        {
            // TODO: probably should be read from a resource text file
            storyLine = "Ok, you want a story line, here it is. Once upon a time, there was this village. ";
            storyLine += "In this village we're towers. These were great times where towers could roam around, ";
            storyLine += "free of their nature predator..... the balloon! One day, dark clouds appeared in the sky. ";
            storyLine += "It looked like M Night Shamaleon was creating another movie. Then, something strange happened! ";
            storyLine += "Evil balloons started entering the village. 1 balloon, then 2 balloons, then several more. The towers became afraid. ";
            storyLine += "As everyone knows, if a balloon hits a tower and pops, the tower loses health (and it hurts the tower's feelings). ";
            storyLine += "Well, one of the towers was having none of this and decided to take action! Wearing the only balloon proof vest in the entire town, ";
            storyLine += "Peaches the tower stood guard against the balloons. ";
            storyLine += "Your role in this game is to play as Peaches and defeat the evil balloons thereby defending the village (and the towers within).";
            lblStoryLine.Text = "";
            tmrTextCrawl.Enabled = true;
            curStoryLineIndex = 0;
        }
        public void GenEnemyPos(out int x, out int y)
        {
            int enterDir = rand.Next(4);
            const int offscreen = 50;
            switch (enterDir)
            {
                case 0: // left
                    y = rand.Next(0, Height);
                    x = -offscreen;
                    break;
                case 1: // bottom
                    x = rand.Next(0, Width);
                    y = Height + offscreen;
                    break;
                case 2: // right
                    y = rand.Next(0, Height);
                    x = Width + offscreen;
                    break;
                default: // top
                    x = rand.Next(0, Width);
                    y = -offscreen;
                    break;
            }
        }
        private void MoveEnemies()
        {
            foreach (var enemy in enemies)
            {
                if (enemy.CurHealth <= 0)
                {
                    continue;
                }
                int xDir = 0;
                int yDir = 0;
                if (enemy.ControlContainer.Left < Width / 2)
                {
                    xDir = 1;
                }
                else
                {
                    xDir = -1;
                }
                if (enemy.ControlContainer.Top < Height / 2)
                {
                    yDir = 1;
                }
                else
                {
                    yDir = -1;
                }
                enemy.Move(xDir, yDir);
                if (enemy.DidCollide(player))
                {
                    enemy.TakeDamageFrom(player);
                    if (enemy.CurHealth <= 0)
                    {
                        enemy.Hide();
                        int levelBefore = player.Level;
                        player.GainXP(enemy.XPGiven);
                        int levelAfter = player.Level;
                        if (levelBefore == 1 && levelAfter == 2)
                        {
                            tmrSpawnArrows.Enabled = true;
                            tmrMoveArrows.Enabled = true;
                            FireArrows();
                        }
                        else if (levelBefore == 2 && levelAfter == 3)
                        {
                            tmrSpawnArrows.Interval = 2500;
                            tmrSpawnArrows.Enabled = true;
                            FireArrows();
                        }
                    }
                    else
                    {
                        enemy.KnockBack();
                    }
                }
                else if (enemy.DidCollide(village))
                {
                    village.TakeDamageFrom(enemy);
                    if (village.CurHealth <= 0)
                    {
                        village.Hide(); // defeated
                        Form frmGO = new FrmGameOver();
                        frmGO.Show();
                        this.Hide();
                        FormManager.PushToFormStack(frmGO);

                        // disable timers
                        tmrMoveArrows.Enabled = false;
                        tmrMoveEnemies.Enabled = false;
                        tmrSpawnArrows.Enabled = false;

                        tmrSpawnEnemies.Enabled = false;
                    }
                    else
                    {
                        enemy.KnockBack();
                    }
                }
            }

            List<Enemy> enemiesToRemove = new List<Enemy>();
            foreach (Enemy enemy in enemies)
            {
                if (enemy.CurHealth <= 0)
                {
                    enemiesToRemove.Add(enemy);
                }
            }

            foreach (Enemy enemy in enemiesToRemove)
            {
                enemies.Remove(enemy);
            }
        }
        private void MoveArrows()
        {
            List<Arrow> arrowsToRemove = new List<Arrow>();
            foreach (Arrow arrow in arrows)
            {
                arrow.Move();
                foreach (Enemy enemy in enemies)
                {
                    if (arrow.DidCollide(enemy))
                    {
                        enemy.TakeDamage(0.1f);
                        if (enemy.CurHealth <= 0)
                        {
                            enemy.Hide();
                            player.GainXP(enemy.XPGiven);
                        }
                        else
                        {
                            enemy.KnockBack();
                        }
                        arrowsToRemove.Add(arrow);
                    }
                }
            }
            foreach (Arrow arrow in arrowsToRemove)
            {
                arrows.Remove(arrow);
                Controls.Remove(arrow.ControlCharacter);
            }
        }
        private void MoveFireballs()
        {
            List<Fireball> FireballsToRemove = new List<Fireball>();
            foreach (Fireball fireball in fireballs)
            {
                fireball.Move();
                foreach (Enemy enemy in enemies)
                {
                    if (fireball.DidCollide(enemy))
                    {
                        enemy.TakeDamage(0.1f);
                        if (enemy.CurHealth <= 0)
                        {
                            enemy.Hide();
                            player.GainXP(enemy.XPGiven);
                        }
                        else
                        {
                            enemy.KnockBack();
                        }
                        FireballsToRemove.Add(fireball);
                    }
                }
            }
            foreach (Fireball fireball in FireballsToRemove)
            {
                fireballs.Remove(fireball);
                Controls.Remove(fireball.ControlCharacter);
            }
        }
        private void FireArrows()
        {
            Arrow arrowLeft = new Arrow(player.X, player.Y, -1, 0);
            Arrow arrowRight = new Arrow(player.X, player.Y, +1, 0);
            arrows.Add(arrowLeft);
            arrows.Add(arrowRight);
            arrowLeft.ControlCharacter.BringToFront();
            arrowRight.ControlCharacter.BringToFront();
        }
        private void FireBall()
        {
            Fireball ballLeft = new Fireball(player.X, player.Y, -1, 0);
            Fireball ballRight = new Fireball(player.X, player.Y, +1, 0);
            fireballs.Add(ballLeft);
            fireballs.Add(ballRight);
            ballLeft.ControlCharacter.BringToFront();
            ballRight.ControlCharacter.BringToFront();
        }
        private void PlayerMove(Keys keyCode)
        {
            /*switch (keyCode)
            {
                case Keys.Up:
                case Keys.W:
                    if (player.Y > 0)
                    {
                        player.Move(0, -1);
                    }
                    break;
                case Keys.Down:
                case Keys.S:
                    if (player.Y < Height - (player.H * 1.5))
                    {
                        player.Move(0, +1);
                    }
                    break;
                case Keys.Left:
                case Keys.A:
                    if (player.X > 0)
                    {
                        player.Move(-1, 0);
                    }
                    break;
                case Keys.Right:
                case Keys.D:
                    if (player.X < Width - (player.W * 1.5))
                    {
                        player.Move(+1, 0);
                    }
                    break;
            }*/
            upMove = false;
            downMove = false;
            leftMove = false;
            rightMove = false;

            switch (keyCode)
            {
                case Keys.Up:
                case Keys.W:
                    upMove = true;
                    break;
                case Keys.Down:
                case Keys.S:
                    downMove = true;
                    break;
                case Keys.Left:
                case Keys.A:
                    leftMove = true;
                    break;
                case Keys.Right:
                case Keys.D:
                    rightMove = true;
                    break;
            }
        }
        private void Abilities(Keys keyCode)
        {
            switch (keyCode)
            {
                case Keys.Space:
                    FireBall();
                    break;
            }
        }
        private void PlayerStopMove(Keys keyCode)
        {
            upMove = false;
            downMove = false;
            leftMove = false;
            rightMove = false;
        }

        private void Level()
        {
            currlevel++;
            enemyMax = 5 * currlevel;
            enemyCount = 0;

            switch (currlevel)
            {
                case 5:
                    village.Hide();
                    village = new Village(Width / 2 - 110, Height / 2 - 65, 220, 135);
                    village.SetMaxHealth(7.5f);
                    break;

                case 10:
                    village.Hide();
                    village = new Village(Width / 2 - 150, Height / 2 - 85, 295, 175);
                    village.SetMaxHealth(10.0f);
                    break;

                case 15:
                    village.Hide();
                    village = new Village(Width / 2 - 200, Height / 2 - 150, 390, 235);
                    village.SetMaxHealth(15.0f);
                    break;

                default:
                    break;
            }
        }
        #endregion

        #endregion


    }
}
