namespace TowerDefense_TheRPG.code {
  /// <summary>
  /// Basic enemy class
  /// </summary>
  public class Enemy : Character {
    /// <summary>
    /// The amount of experience given to player if this enemy is defeated
    /// </summary>
    public int XPGiven { get; private set; }

        // TODO: add helper function to change position on enemy -- add to end of code

    /// <summary>
    /// Default constructor
    /// </summary>
    /// <param name="name">Name of the enemy. Used to lookup an image in resource, so give this the same name as the resource image file</param>
    /// <param name="x">Initial x location</param>
    /// <param name="y">Initial y location</param>
    /// <param name="w">Desired width of the picturebox used to represent this enemy</param>
    /// <param name="h">Desired height of the picturebox used to represent this enemy</param>
    public Enemy(string name, int x, int y, int w, int h) : base(name, x, y, w, h) {
    }

    /// <summary>
    /// Create a red balloon <see cref="Enemy"/> at the specified location
    /// </summary>
    /// <param name="x">Initial X location for the enemy</param>
    /// <param name="y">Initial Y location for the enemy</param>
    /// <returns>The red balloon <see cref="Enemy"/> object</returns>
    public static Enemy MakeRedBalloon(int x, int y) {
      Enemy balloon = new Enemy("redballoon", x, y, 30, 30);
      balloon.MoveSpeed = 5;
      balloon.SetMaxHealth(0.1f);
      balloon.Attack = 0.5f;
      balloon.XPGiven = 1;
      return balloon;
    }

    /// <summary>
    /// Create a purple balloon <see cref="Enemy"/> at the specified location
    /// </summary>
    /// <param name="x">Initial X location for the enemy</param>
    /// <param name="y">Initial Y location for the enemy</param>
    /// <returns>The purple balloon <see cref="Enemy"/> object</returns>
    public static Enemy MakePurpleBalloon(int x, int y) {
      Enemy balloon = new Enemy("purpleballoon", x, y, 50, 50);
      balloon.MoveSpeed = 10;
      balloon.SetMaxHealth(0.5f);
      balloon.Attack = 0.3f;
      balloon.XPGiven = 3;
      return balloon;
    }

    /// <summary>
    /// Create a gray balloon <see cref="Enemy"/> at the specified location
    /// </summary>
    /// <param name="x">Initial X location for the enemy</param>
    /// <param name="y">Initial Y location for the enemy</param>
    /// <returns>The gray balloon <see cref="Enemy"/> object</returns>
    public static Enemy MakeGrayBalloon(int x, int y) {
      Enemy balloon = new Enemy("grayballoon", x, y, 70, 70);
      balloon.MoveSpeed = 3;
      balloon.SetMaxHealth(1.0f);
      balloon.Attack = 1f;
      balloon.XPGiven = 7;
      return balloon;
    }

    /// <summary>
    /// Create a orange balloon <see cref="Enemy"/> at the specified location
    /// </summary>
    /// <param name="x">Initial X location for the enemy</param>
    /// <param name="y">Initial Y location for the enemy</param>
    /// <returns>The orange balloon <see cref="Enemy"/> object</returns>
    public static Enemy MakeOrangeBalloon(int x, int y) {
      Enemy balloon = new Enemy("orangeballoon", x, y, 100, 100);
      balloon.MoveSpeed = 15;
      balloon.SetMaxHealth(0.2f);
      balloon.Attack = 0.1f;
      balloon.XPGiven = 5;
      return balloon;
    }
  }
}
