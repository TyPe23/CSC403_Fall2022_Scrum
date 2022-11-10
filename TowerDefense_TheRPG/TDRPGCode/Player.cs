namespace TowerDefense_TheRPG.code
{
    /// <summary>
    /// Class for our player
    /// </summary>
    public class Player : Character
    {
        /// <summary>
        /// Amount of money the player has. Currently this is not being
        /// used but you could add this as a feature.
        /// </summary>
        public int Money { get; private set; }

        /// <summary>
        /// Skill points held by the player
        /// Gained by finishing a level
        /// </summary>
        public int SkillPoints { get; private set; }

        /// <summary>
        /// Current level player has
        /// </summary>
        public int Level { get; private set; }

        /// <summary>
        /// If this is set to true, player will automatically shoot arrows
        /// every so often (the time interval is set as the Interval property
        /// of the tmrSpawnArrows object in FrmMain)
        /// </summary>
        public bool AutoShoot { get; private set; }

        /// <summary>
        /// Explicit constructor
        /// </summary>
        /// <param name="x">Initial x position of player</param>
        /// <param name="y">Initial y position of player</param>
        public Player(int x, int y) : base("player", x, y, 50, 100)
        {
            SetMaxHealth(1.0f);
            Money = 0;
            Attack = 0.15f;
            MoveSpeed = 15;
            Level = 1;
            SkillPoints = 0;
            ChangeCharacterPic("playerL" + Level);
        }

        /// <summary>
        /// Internal function that is automatically called when 
        /// player gains a level (called from GainXP method)
        /// </summary>
        public void GainLevel()
        {
            Level++;
            SkillPoints++;
        }

        /// <summary>
        /// Increases the attack of the player if skill points are available
        /// </summary>
        public void AddAttack()
        {

        }

        /// <summary>
        /// Increases the magic of the player if skill points are available
        /// </summary>
        public void AddMagic()
        {

        }

        /// <summary>
        /// Increases the speed of the player if skill points are available
        /// </summary>
        public void AddSpeed()
        {

        }
    }
}
