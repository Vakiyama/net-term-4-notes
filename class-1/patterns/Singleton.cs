namespace Patterns {
  public class Singleton {
    // to prove it's the same instance, we generate a random id at instantiation
    private int Id = GetId();

    private static int GetId() {
      Random random = new Random();

      int RandomNumber = random.Next(0, 99);
      return RandomNumber;
    }

    // lazy will only create this class (will only run the lambda) when called with .Value 
    // subsequent calls will return the same previously instantiated value
    private static Lazy<Singleton> _instance = new Lazy<Singleton>(() => new Singleton());

    public static Singleton Instance => _instance.Value;

    // private constructor prevents outside instantiation of class
    private Singleton() {}

    public void Log() {
      Console.WriteLine($"Singleton Id: {Id}");
    }
  }
}
