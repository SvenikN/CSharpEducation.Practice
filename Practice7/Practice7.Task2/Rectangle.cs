using System;

namespace Practice7.Task2
{
  public class Rectangle : ICloneable
  {
    public int Width;
    public int Height;

    public Rectangle(int wight, int height)
    {
      Width = wight;
      Height = height;
    }

    public object Clone() => MemberwiseClone();
  }
}
