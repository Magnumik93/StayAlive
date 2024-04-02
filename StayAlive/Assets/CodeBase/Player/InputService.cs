using UnityEngine;

namespace CodeBase.Player
{
  public abstract class InputService 
  {
    protected const string Horizontal = "Horizontal";
    protected const string Vertical = "Vertical";
    private const string Button = "Fire";

    public virtual Vector2 Axis
    {
      get
      {
        Vector2 axis = SimpleInputAxis();
        return axis;
      }
    } protected static Vector2 SimpleInputAxis()
    {
      return new Vector2(UnityEngine.Input.GetAxis(Horizontal), UnityEngine.Input.GetAxis(Vertical));
    }
  }
}