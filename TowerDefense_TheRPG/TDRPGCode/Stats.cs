namespace TowerDefense_TheRPG.code {
  /// <summary>
  /// Holds the stats for our character
  /// </summary>
  public class Stats {
    /// <summary>
    /// Amount of damage inflicted
    /// </summary>
    public float Attack { get; set; }

    /// <summary>
    /// Total health
    /// </summary>
    public float MaxHealth { get; set; }

    /// <summary>
    /// Current health
    /// </summary>
    public float CurHealth { get; set; }

    /// <summary>
    /// Movement speed (in pixels)
    /// </summary>
    public int Speed { get; set; }

    /// <summary>
    /// Default constructor assigning all ones to stats.
    /// Change the values you want to change after calling
    /// this constructor
    /// </summary>
    public Stats() {
      Attack = 1;
      CurHealth = 1;
      MaxHealth = 1;
      Speed = 1;
    }
  }
}
