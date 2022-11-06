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
    public Village(int x, int y) : base("village", x, y, 165, 100) {
      SetMaxHealth(5.0f);
    }

    /// <summary>
    /// Updates the .png used every 5 levels
    /// </summary>
    /// <param name="currLevel"></param>
    public void UpdateVillageImg(int currLevel)
    {
        switch (currLevel)
        {
            case 2:
                ChangeCharacterPic("village2");
                break;

            case 10:
                ChangeCharacterPic("village3");
                break;

            case 15:
                ChangeCharacterPic("village4");
                break;

            default:
                break;
        }
    }
  }
}
