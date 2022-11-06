namespace TowerDefense_TheRPG.code {
  /// <summary>
  /// Base character class. Inherits from <see cref="Stats">Stats</see>.
  /// <see cref="Enemy"/>, <see cref="Player"/> and <see cref="Village"/> inherit from this class.
  /// Note: this should probably be marked as "abstract" since you never need to directly 
  /// instantiate it
  /// </summary>
  public class Character : Stats {
    #region Properties
    /// <summary>
    /// Name of this character. This is used to look up an image in resources
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Current X (aka left) position
    /// </summary>
    public int X { get; private set; }

    /// <summary>
    /// Current Y (aka top) position
    /// </summary>
    public int Y { get; private set; }

    /// <summary>
    /// Width of the picture box showing this character
    /// </summary>
    public int W { get; private set; }

    /// <summary>
    /// Height of the picture box showing this character
    /// </summary>
    public int H { get; private set; }

    /// <summary>
    /// Panel that contains the picturebox (showing the character) and the
    /// character's health bar (which is composed of an empty health bar for background
    /// and a filled health bar whose width scales with the character current health.
    /// </summary>
    public Panel ControlContainer { get; private set; }

    /// <summary>
    /// Used to indicate whether this character is visually shown or not on the screen
    /// </summary>
    public bool IsVisible { get; private set; }
    #endregion

    #region Fields
    private Control ControlCharacter;
    private Control ControlHealthBarFull;
    private Control ControlHealthBarEmpty;
    private const int HEALTH_BAR_WIDTH = 50;
    private int lastMoveDirX;
    private int lastMoveDirY;
    #endregion

    #region Methods
    #region Ctor
    /// <summary>
    /// Explicit constructor.
    /// </summary>
    /// <param name="name">Name of this character</param>
    /// <param name="x">Initial X position</param>
    /// <param name="y">Initial Y position</param>
    /// <param name="w">Desired width of the picturebox showing this character</param>
    /// <param name="h">Desired height of the picturebox showing this character</param>
    public Character(string name, int x, int y, int w, int h) {
      Name = name;
      X = x;
      Y = y;
      W = w;
      H = h;
      IsVisible = true;
      MakeControls();
      UpdateHealth();
    }
    #endregion

    #region Health and Damage
    /// <summary>
    /// Sets the maximum health for the character. This also resets 
    /// curhealth to be the maximum health.
    /// </summary>
    /// <param name="health"></param>
    public void SetMaxHealth(float health) {
      MaxHealth = health;
      CurHealth = MaxHealth;
    }

    /// <summary>
    /// Updates the visual health bar for the character based on their
    /// current health. The width of the health bar is ((the percentage of curhealth 
    /// divided by maxhealth) multiplied by a constant value). You can change the constant
    /// value by changing HEALTH_BAR_WIDTH.
    /// </summary>
    public void UpdateHealth() {
      if (CurHealth > 0) {
        ControlHealthBarFull.Width = (int)(CurHealth / MaxHealth * HEALTH_BAR_WIDTH);
      }
      else {
        ControlHealthBarFull.Width = 0;
        Hide();
      }
    }

    /// <summary>
    /// Decreases this character's current health by the Attack stat of the given
    /// character object. This also calls <see cref="UpdateHealth"/> to update the
    /// visual health bar.
    /// </summary>
    /// <param name="chr">The <see cref="Character"/> object that we are taking damage from</param>
    public void TakeDamageFrom(Character chr) {
      CurHealth -= chr.Attack;
      UpdateHealth();
    }

    /// <summary>
    /// Similar to <see cref="TakeDamageFrom(Character)"/> however this will allow for a hard coded amount
    /// of damage to be given. This is used to take damage from <see cref="Arrow"/> objects.
    /// </summary>
    /// <param name="amount">Amount of damage to take</param>
    public void TakeDamage(float amount) {
      CurHealth -= amount;
      UpdateHealth();
    }
    #endregion

    #region Visuals
    /// <summary>
    /// This function will create the picturebox to represent the character, the empty health bar for health
    /// bar background, and the full red health bar to show current health. It will then create the <see cref="ControlContainer"/>
    /// and put all those controls into this container. Finally, it uses <see cref="ControlManager.Form"/> to grab a reference
    /// to the current form and will then add the ControlContainer to this form.
    /// </summary>
    private void MakeControls() {
      ControlContainer = new Panel() {
        Top = Y,
        Left = X,
        Width = Math.Max(W, HEALTH_BAR_WIDTH),
        Height = H + 30,
        BackColor = Color.Transparent,
      };
      ControlCharacter = new PictureBox() {
        BackgroundImage = ControlManager.ResMan.GetObject(Name) as Bitmap,
        BackgroundImageLayout = ImageLayout.Stretch,
        Width = W,
        Height = H,
        BackColor = Color.Transparent,
      };
      ControlHealthBarFull = new Label() {
        Text = "",
        BackColor = Color.Red,
        Width = HEALTH_BAR_WIDTH,
        Height = 15,
        Top = H + 2,
        Left = 0,
      };
      ControlHealthBarEmpty = new Label() {
        Text = "",
        BackColor = Color.Black,
        BorderStyle = BorderStyle.Fixed3D,
        Width = HEALTH_BAR_WIDTH,
        Height = 15,
        Top = H + 2,
        Left = 0,
      };
      ControlContainer.Controls.Add(ControlCharacter);
      ControlContainer.Controls.Add(ControlHealthBarFull);
      ControlContainer.Controls.Add(ControlHealthBarEmpty);
      ControlManager.Form.Controls.Add(ControlContainer);
    }

    /// <summary>
    /// This will force a change of the image being displayed for this character. This is used
    /// to make the image change for the player when a new level is obtained or to make the village "grow" after every 5 levels
    /// </summary>
    /// <param name="resourceName">The name of the resource file. You can find this by opening Resources.resx and looking at the name under the image</param>
    public void ChangeCharacterPic(string resourceName) {
      ControlCharacter.BackgroundImage = ControlManager.ResMan.GetObject(resourceName) as Bitmap;
    }

    /// <summary>
    /// Show this character on the screen. This both sets the <see cref="IsVisible"/> property to true and sets the
    /// Visible property of <see cref="ControlContainer"/> to true, thereby forcing the ControlContainer to show up.
    /// </summary>
    public void Show() {
      IsVisible = true;
      ControlContainer.Visible = IsVisible;
    }

    /// <summary>
    /// Hide this character from the screen. This both sets the <see cref="IsVisible"/> property to false and sets the
    /// Visible property of <see cref="ControlContainer"/> to false, thereby forcing the ControlContainer to hide.
    /// </summary>
    public void Hide() {
      IsVisible = false;
      ControlContainer.Visible = IsVisible;
    }
    #endregion

    #region Movement
    /// <summary>
    /// Visually moves this character object. This sets the X and Y properties to the new values
    /// after the move and updates the <see cref="ControlContainer"/> Top and Left properties so the character
    /// both visually moves and has its X and Y properties updated. This function automatically accounts for
    /// movement speed (using <see cref="Stats.MoveSpeed"/>)
    /// </summary>
    /// <param name="dirX">X direction to move. This should be either +1, 0, or -1</param>
    /// <param name="dirY">Y direction to move. This should be either +1, 0, or -1</param>
    /// <param name="rememberLastMove">This is used internally for knockback. Ignore this parameter if calling this function from outside of this class</param>
    public virtual void Move(int dirX, int dirY, bool rememberLastMove = true) {
      Y += dirY * MoveSpeed;
      X += dirX * MoveSpeed;
      ControlContainer.Top = Y;
      ControlContainer.Left = X;
      if (rememberLastMove) {
        lastMoveDirX = dirX;
        lastMoveDirY = dirY;
      }
    }

    /// <summary>
    /// Used to see if two characters have collided. The <see cref="ControlContainer"/> of each character is
    /// checked to see if there is an overlap. Note that this means that the health bar and empty area between image and
    /// health bar are all part of the collision box of this character. If you change this code to only use <see cref="ControlCharacter"/>,
    /// you will have to do extra math add in the offset from the ControlContainer as the Bounds property will only consider the
    /// ControlCharacter's relative position within the ControlContainer and not its absolute position on the form.
    /// </summary>
    /// <param name="chr">The <see cref="Character"/> to check collision with</param>
    /// <returns>True if these character collided, false otherwise</returns>
    public bool DidCollide(Character chr) {
      return ControlContainer.Bounds.IntersectsWith(chr.ControlContainer.Bounds);
    }

    /// <summary>
    /// Knocks the character back after a hit or attack. This function uses the last 
    /// movement direction and moves the character 10 times in the opposite direction. For example,
    /// if the character last moved left and this function is called, that character will move 10
    /// times to the right.
    /// </summary>
    public void KnockBack() {
      const int TIMES = 10;
      for (int i = 0; i < TIMES; i++) {
        Move(-lastMoveDirX, -lastMoveDirY, false);
      }
    }
    #endregion
    #endregion
  }
}
