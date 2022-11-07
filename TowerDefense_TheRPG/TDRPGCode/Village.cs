namespace TowerDefense_TheRPG.code {
  /// <summary>
  /// Represents our village, the thing we are trying to protect
  /// </summary>
  public class Village : Character {
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="x">Initial X (aka left) position of village</param>
    /// <param name="y">Initial Y (aka top) position of village</param>
    /// <param name="w">Initial W (aka width) of the village</param>
    /// <param name="h">Initial H (aka height) of the w</param>
    public Village(int x, int y, int w, int h) : base("village", x, y, w, h) {
      SetMaxHealth(5.0f);
    }
  }
}
