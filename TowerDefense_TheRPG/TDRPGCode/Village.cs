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
        IsVisible = false;
        switch (currLevel)
        {
            case 2:
                X -= 35;
                Y -= 35;
                W *= 3;
                W /= 2;
                H *= 3;
                H /= 2;
                MakeControls();
                break;

            case 3:
                X -= 45;
                Y -= 45;
                W *= 3;
                W /= 2;
                H *= 3;
                H /= 2;
                MakeControls();
                break;

            case 4:
                X -= 60;
                Y -= 00;
                W *= 5;
                W /= 4;
                H *= 5;
                H /= 4;
                MakeControls();
                break;

            default:
                break;
        }
        IsVisible = true;
    }
  }
}
