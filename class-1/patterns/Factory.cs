namespace Patterns 
{
  // generated classes need to share some type,
  // we have no way to know what class is being returned
  // otherwise
  public interface Shape
  {
    void Draw();
  }

  public class Circle : Shape 
  {
    public void Draw() 
    {
      Console.WriteLine("Drawing a circle.");
    }
  }
  
  public class Square : Shape 
  {
    public void Draw() 
    {
      Console.WriteLine("Drawing a square.");
    }
  }

  public static class Factory {
    public static Shape GetShape(string ShapeType) 
    {
      switch (ShapeType.ToLower())
      {
        case "circle":
          // if circle or shape needs a default int x, int y  in the future, callers don't need to be changed
          // to handle the new requirement
          // only this class would have to be changed
          return new Circle(); 
        case "square":
          return new Square();
        default:
          throw new ArgumentException($"Invalid shape type: {ShapeType}");
      }
    }
  }
}
