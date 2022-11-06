namespace TowerDefense_TheRPG.code {
  /// <summary>
  /// Used to handle the opening and closing of multiple forms
  /// </summary>
  public static class FormManager {
    /// <summary>
    /// Used so we can have a record of the forms open and an ordering to those forms
    /// </summary>
    private static Stack<Form> formStack;

    /// <summary>
    /// Default static constructor. Initializes our form stack
    /// </summary>
    static FormManager() {
      formStack = new Stack<Form>();
    }

    /// <summary>
    /// Push a new form onto the stack. Call this when you create a new form dynamically. Also, call
    /// this on the first form that opens when the application is launched.
    /// </summary>
    /// <param name="frm">The <see cref="Form"/> object to push on the stack</param>
    public static void PushToFormStack(Form frm) {
      formStack.Push(frm);
    }

    /// <summary>
    /// Removes the top form from the stack and closes it
    /// </summary>
    public static void PopAndCloseFromFormStack() {
      if (formStack.Count == 0) {
        return;
      }

      Form frm = formStack.Pop();
      frm.Close();
      if (formStack.Count > 0) {
        formStack.Peek().Show();
      }
    }

    /// <summary>
    /// Clears out the stack and closes all forms. Call this when the application is closing.
    /// </summary>
    public static void ClearAndCloseFormStack() {
      while (formStack.Count > 0) {
        PopAndCloseFromFormStack();

      }
    }
 
    }
}
